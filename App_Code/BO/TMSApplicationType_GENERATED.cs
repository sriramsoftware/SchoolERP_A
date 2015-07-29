/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/27/2012 1:32:38 PM                                    */
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
public partial class TMSApplicationType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ApplicationType]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _adApplicationTypeId;
	private System.String _adApplicationType;
	private System.DateTime? _adApplicationTypeDate;
	private System.Int32? _adApplicationTypeStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ADApplicationTypeId
	{
		get
		{
			return _adApplicationTypeId;
		}
		set
		{
			_adApplicationTypeId = value;
		}
	}
	
	public System.String ADApplicationType
	{
		get
		{
			return _adApplicationType;
		}
		set
		{
			_adApplicationType = value;
		}
	}
	
	public System.DateTime? ADApplicationTypeDate
	{
		get
		{
			return _adApplicationTypeDate;
		}
		set
		{
			_adApplicationTypeDate = value;
		}
	}
	
	public System.Int32? ADApplicationTypeStatus
	{
		get
		{
			return _adApplicationTypeStatus;
		}
		set
		{
			_adApplicationTypeStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("AD_ApplicationTypeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_ApplicationType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_ApplicationTypeDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_ApplicationTypeStatus", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ADApplicationTypeId == null)
		dr["AD_ApplicationTypeId"] = DBNull.Value;
		else
		dr["AD_ApplicationTypeId"] = ADApplicationTypeId;
		
		if (ADApplicationType == null)
		dr["AD_ApplicationType"] = DBNull.Value;
		else
		dr["AD_ApplicationType"] = ADApplicationType;
		
		if (ADApplicationTypeDate == null)
		dr["AD_ApplicationTypeDate"] = DBNull.Value;
		else
		dr["AD_ApplicationTypeDate"] = ADApplicationTypeDate;
		
		if (ADApplicationTypeStatus == null)
		dr["AD_ApplicationTypeStatus"] = DBNull.Value;
		else
		dr["AD_ApplicationTypeStatus"] = ADApplicationTypeStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ADApplicationTypeId = dr["AD_ApplicationTypeId"] != DBNull.Value ? Convert.ToInt64(dr["AD_ApplicationTypeId"]) : ADApplicationTypeId = null;
		ADApplicationType = dr["AD_ApplicationType"] != DBNull.Value ? Convert.ToString(dr["AD_ApplicationType"]) : ADApplicationType = null;
		ADApplicationTypeDate = dr["AD_ApplicationTypeDate"] != DBNull.Value ? Convert.ToDateTime(dr["AD_ApplicationTypeDate"]) : ADApplicationTypeDate = null;
		ADApplicationTypeStatus = dr["AD_ApplicationTypeStatus"] != DBNull.Value ? Convert.ToInt32(dr["AD_ApplicationTypeStatus"]) : ADApplicationTypeStatus = null;
	}
	
	public static TMSApplicationType[] MapFrom(DataSet ds)
	{
		List<TMSApplicationType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSApplicationType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ApplicationType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ApplicationType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSApplicationType instance = new TMSApplicationType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSApplicationType Get(System.Int64 adApplicationTypeId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSApplicationType instance;
		
		
		instance = new TMSApplicationType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adApplicationTypeId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSApplicationType ID:" + adApplicationTypeId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String adApplicationType, System.DateTime? adApplicationTypeDate, System.Int32? adApplicationTypeStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adApplicationType, adApplicationTypeDate, adApplicationTypeStatus);
		
		if (transaction == null)
		this.ADApplicationTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ADApplicationTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String adApplicationType, System.DateTime? adApplicationTypeDate, System.Int32? adApplicationTypeStatus)
	{
		Insert(adApplicationType, adApplicationTypeDate, adApplicationTypeStatus, null);
	}
	/// <summary>
	/// Insert current TMSApplicationType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ADApplicationType, ADApplicationTypeDate, ADApplicationTypeStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSApplicationType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? adApplicationTypeId, System.String adApplicationType, System.DateTime? adApplicationTypeDate, System.Int32? adApplicationTypeStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adApplicationTypeId"].Value = adApplicationTypeId;
		dbCommand.Parameters["@adApplicationType"].Value = adApplicationType;
		dbCommand.Parameters["@adApplicationTypeDate"].Value = adApplicationTypeDate;
		dbCommand.Parameters["@adApplicationTypeStatus"].Value = adApplicationTypeStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? adApplicationTypeId, System.String adApplicationType, System.DateTime? adApplicationTypeDate, System.Int32? adApplicationTypeStatus)
	{
		Update(adApplicationTypeId, adApplicationType, adApplicationTypeDate, adApplicationTypeStatus, null);
	}
	
	public static void Update(TMSApplicationType tMSApplicationType)
	{
		tMSApplicationType.Update();
	}
	
	public static void Update(TMSApplicationType tMSApplicationType, DbTransaction transaction)
	{
		tMSApplicationType.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSApplicationType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adApplicationTypeId"].SourceColumn = "AD_ApplicationTypeId";
		dbCommand.Parameters["@adApplicationType"].SourceColumn = "AD_ApplicationType";
		dbCommand.Parameters["@adApplicationTypeDate"].SourceColumn = "AD_ApplicationTypeDate";
		dbCommand.Parameters["@adApplicationTypeStatus"].SourceColumn = "AD_ApplicationTypeStatus";
		
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
	public static void Delete(System.Int64? adApplicationTypeId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adApplicationTypeId);
		
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
	public static void Delete(System.Int64? adApplicationTypeId)
	{
		Delete(
		adApplicationTypeId);
	}
	
	/// <summary>
	/// Delete current TMSApplicationType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ADApplicationTypeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ADApplicationTypeId = null;
	}
	
	/// <summary>
	/// Delete current TMSApplicationType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSApplicationType[] Search(System.Int64? adApplicationTypeId, System.String adApplicationType, System.DateTime? adApplicationTypeDate, System.Int32? adApplicationTypeStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adApplicationTypeId, adApplicationType, adApplicationTypeDate, adApplicationTypeStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSApplicationType.MapFrom(ds);
	}
	
	
	public static TMSApplicationType[] Search(TMSApplicationType searchObject)
	{
		return Search ( searchObject.ADApplicationTypeId, searchObject.ADApplicationType, searchObject.ADApplicationTypeDate, searchObject.ADApplicationTypeStatus);
	}
	
	/// <summary>
	/// Returns all TMSApplicationType objects.
	/// </summary>
	/// <returns>List of all TMSApplicationType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSApplicationType[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

