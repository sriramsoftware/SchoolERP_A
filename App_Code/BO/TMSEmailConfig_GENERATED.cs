/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/28/2012 10:00:00 AM                                    */
/*                                                                          */
/* www.CodeAuthor.org                                                       */
/****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

[DataObject]
[Serializable]
public partial class TMSEmailConfig
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_EmailConfig]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _econfigId;
	private System.String _econfigHost;
	private System.String _econfigUserName;
	private System.String _econfigPassword;
	
	#endregion
	
	
	#region Properties
	public System.Int32? EconfigId
	{
		get
		{
			return _econfigId;
		}
		set
		{
			_econfigId = value;
		}
	}
	
	public System.String EconfigHost
	{
		get
		{
			return _econfigHost;
		}
		set
		{
			_econfigHost = value;
		}
	}
	
	public System.String EconfigUserName
	{
		get
		{
			return _econfigUserName;
		}
		set
		{
			_econfigUserName = value;
		}
	}
	
	public System.String EconfigPassword
	{
		get
		{
			return _econfigPassword;
		}
		set
		{
			_econfigPassword = value;
		}
	}
	
	#endregion
	
	
	#region Methods
	
	
	#region Mapping Methods
	
	protected void MapTo(DataSet ds)
	{
		DataRow dr;
		
		
		if (ds == null)
		ds = new DataSet();
		
		if (ds.Tables["TABLE_NAME"] == null)
		ds.Tables.Add(TABLE_NAME);
		
		ds.Tables[TABLE_NAME].Columns.Add("Econfig_Id", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("Econfig_Host", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Econfig_UserName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Econfig_Password", typeof(System.String) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (EconfigId == null)
		dr["Econfig_Id"] = DBNull.Value;
		else
		dr["Econfig_Id"] = EconfigId;
		
		if (EconfigHost == null)
		dr["Econfig_Host"] = DBNull.Value;
		else
		dr["Econfig_Host"] = EconfigHost;
		
		if (EconfigUserName == null)
		dr["Econfig_UserName"] = DBNull.Value;
		else
		dr["Econfig_UserName"] = EconfigUserName;
		
		if (EconfigPassword == null)
		dr["Econfig_Password"] = DBNull.Value;
		else
		dr["Econfig_Password"] = EconfigPassword;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		EconfigId = dr["Econfig_Id"] != DBNull.Value ? Convert.ToInt32(dr["Econfig_Id"]) : EconfigId = null;
		EconfigHost = dr["Econfig_Host"] != DBNull.Value ? Convert.ToString(dr["Econfig_Host"]) : EconfigHost = null;
		EconfigUserName = dr["Econfig_UserName"] != DBNull.Value ? Convert.ToString(dr["Econfig_UserName"]) : EconfigUserName = null;
		EconfigPassword = dr["Econfig_Password"] != DBNull.Value ? Convert.ToString(dr["Econfig_Password"]) : EconfigPassword = null;
	}
	
	public static TMSEmailConfig[] MapFrom(DataSet ds)
	{
		List<TMSEmailConfig> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSEmailConfig>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_EmailConfig] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_EmailConfig] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSEmailConfig instance = new TMSEmailConfig();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEmailConfig Get(System.Int32 econfigId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSEmailConfig instance;
		
		
		instance = new TMSEmailConfig();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEmailConfig_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, econfigId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSEmailConfig ID:" + econfigId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String econfigHost, System.String econfigUserName, System.String econfigPassword, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEmailConfig_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, econfigHost, econfigUserName, econfigPassword);
		
		if (transaction == null)
		this.EconfigId = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.EconfigId = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String econfigHost, System.String econfigUserName, System.String econfigPassword)
	{
		Insert(econfigHost, econfigUserName, econfigPassword, null);
	}
	/// <summary>
	/// Insert current TMSEmailConfig to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(EconfigHost, EconfigUserName, EconfigPassword, transaction);
	}
	
	/// <summary>
	/// Insert current TMSEmailConfig to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? econfigId, System.String econfigHost, System.String econfigUserName, System.String econfigPassword, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEmailConfig_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@econfigId"].Value = econfigId;
		dbCommand.Parameters["@econfigHost"].Value = econfigHost;
		dbCommand.Parameters["@econfigUserName"].Value = econfigUserName;
		dbCommand.Parameters["@econfigPassword"].Value = econfigPassword;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? econfigId, System.String econfigHost, System.String econfigUserName, System.String econfigPassword)
	{
		Update(econfigId, econfigHost, econfigUserName, econfigPassword, null);
	}
	
	public static void Update(TMSEmailConfig tMSEmailConfig)
	{
		tMSEmailConfig.Update();
	}
	
	public static void Update(TMSEmailConfig tMSEmailConfig, DbTransaction transaction)
	{
		tMSEmailConfig.Update(transaction);
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Update(DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEmailConfig_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@econfigId"].SourceColumn = "Econfig_Id";
		dbCommand.Parameters["@econfigHost"].SourceColumn = "Econfig_Host";
		dbCommand.Parameters["@econfigUserName"].SourceColumn = "Econfig_UserName";
		dbCommand.Parameters["@econfigPassword"].SourceColumn = "Econfig_Password";
		
		ds = new DataSet();
		this.MapTo( ds );
		ds.AcceptChanges();
		ds.Tables[0].Rows[0].SetModified();
		if (transaction == null)
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, UpdateBehavior.Standard);
		else
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, transaction);
		return;
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	public void Update()
	{
		this.Update((DbTransaction)null);
	}
	#endregion
	
	
	#region DELETE
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, false)]
	public static void Delete(System.Int32? econfigId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEmailConfig_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, econfigId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
	public static void Delete(System.Int32? econfigId)
	{
		Delete(
		econfigId);
	}
	
	/// <summary>
	/// Delete current TMSEmailConfig from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEmailConfig_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, EconfigId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.EconfigId = null;
	}
	
	/// <summary>
	/// Delete current TMSEmailConfig from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEmailConfig[] Search(System.Int32? econfigId, System.String econfigHost, System.String econfigUserName, System.String econfigPassword)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEmailConfig_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, econfigId, econfigHost, econfigUserName, econfigPassword);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSEmailConfig.MapFrom(ds);
	}
	
	
	public static TMSEmailConfig[] Search(TMSEmailConfig searchObject)
	{
		return Search ( searchObject.EconfigId, searchObject.EconfigHost, searchObject.EconfigUserName, searchObject.EconfigPassword);
	}
	
	/// <summary>
	/// Returns all TMSEmailConfig objects.
	/// </summary>
	/// <returns>List of all TMSEmailConfig objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSEmailConfig[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

