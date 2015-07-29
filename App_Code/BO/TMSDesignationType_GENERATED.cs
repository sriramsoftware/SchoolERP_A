/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/24/2012 2:53:46 PM                                    */
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
public partial class TMSDesignationType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_DesignationType]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _dtDestId;
	private System.String _dtDesignationName;
	private System.Int32? _dtStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? DTDestId
	{
		get
		{
			return _dtDestId;
		}
		set
		{
			_dtDestId = value;
		}
	}
	
	public System.String DTDesignationName
	{
		get
		{
			return _dtDesignationName;
		}
		set
		{
			_dtDesignationName = value;
		}
	}
	
	public System.Int32? DTStatus
	{
		get
		{
			return _dtStatus;
		}
		set
		{
			_dtStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("DT_DestId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("DT_DesignationName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DT_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (DTDestId == null)
		dr["DT_DestId"] = DBNull.Value;
		else
		dr["DT_DestId"] = DTDestId;
		
		if (DTDesignationName == null)
		dr["DT_DesignationName"] = DBNull.Value;
		else
		dr["DT_DesignationName"] = DTDesignationName;
		
		if (DTStatus == null)
		dr["DT_Status"] = DBNull.Value;
		else
		dr["DT_Status"] = DTStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		DTDestId = dr["DT_DestId"] != DBNull.Value ? Convert.ToInt64(dr["DT_DestId"]) : DTDestId = null;
		DTDesignationName = dr["DT_DesignationName"] != DBNull.Value ? Convert.ToString(dr["DT_DesignationName"]) : DTDesignationName = null;
		DTStatus = dr["DT_Status"] != DBNull.Value ? Convert.ToInt32(dr["DT_Status"]) : DTStatus = null;
	}
	
	public static TMSDesignationType[] MapFrom(DataSet ds)
	{
		List<TMSDesignationType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSDesignationType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_DesignationType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_DesignationType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSDesignationType instance = new TMSDesignationType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSDesignationType Get(System.Int64 dtDestId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSDesignationType instance;
		
		
		instance = new TMSDesignationType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDesignationType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dtDestId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSDesignationType ID:" + dtDestId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String dtDesignationName, System.Int32? dtStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDesignationType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dtDesignationName, dtStatus);
		
		if (transaction == null)
		this.DTDestId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.DTDestId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String dtDesignationName, System.Int32? dtStatus)
	{
		Insert(dtDesignationName, dtStatus, null);
	}
	/// <summary>
	/// Insert current TMSDesignationType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(DTDesignationName, DTStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSDesignationType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? dtDestId, System.String dtDesignationName, System.Int32? dtStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDesignationType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@dtDestId"].Value = dtDestId;
		dbCommand.Parameters["@dtDesignationName"].Value = dtDesignationName;
		dbCommand.Parameters["@dtStatus"].Value = dtStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? dtDestId, System.String dtDesignationName, System.Int32? dtStatus)
	{
		Update(dtDestId, dtDesignationName, dtStatus, null);
	}
	
	public static void Update(TMSDesignationType tMSDesignationType)
	{
		tMSDesignationType.Update();
	}
	
	public static void Update(TMSDesignationType tMSDesignationType, DbTransaction transaction)
	{
		tMSDesignationType.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSDesignationType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@dtDestId"].SourceColumn = "DT_DestId";
		dbCommand.Parameters["@dtDesignationName"].SourceColumn = "DT_DesignationName";
		dbCommand.Parameters["@dtStatus"].SourceColumn = "DT_Status";
		
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
	public static void Delete(System.Int64? dtDestId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDesignationType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dtDestId);
		
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
	public static void Delete(System.Int64? dtDestId)
	{
		Delete(
		dtDestId);
	}
	
	/// <summary>
	/// Delete current TMSDesignationType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDesignationType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, DTDestId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.DTDestId = null;
	}
	
	/// <summary>
	/// Delete current TMSDesignationType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSDesignationType[] Search(System.Int64? dtDestId, System.String dtDesignationName, System.Int32? dtStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDesignationType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dtDestId, dtDesignationName, dtStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSDesignationType.MapFrom(ds);
	}
	
	
	public static TMSDesignationType[] Search(TMSDesignationType searchObject)
	{
		return Search ( searchObject.DTDestId, searchObject.DTDesignationName, searchObject.DTStatus);
	}
	
	/// <summary>
	/// Returns all TMSDesignationType objects.
	/// </summary>
	/// <returns>List of all TMSDesignationType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSDesignationType[] Search()
	{
		return Search ( null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

