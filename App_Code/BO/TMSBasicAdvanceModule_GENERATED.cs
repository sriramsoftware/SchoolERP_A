/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/13/2012 5:18:43 PM                                    */
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
public partial class TMSBasicAdvanceModule
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_BasicAdvanceModule]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _adModuleID;
	private System.String _adText;
	private System.String _adType;
	private System.String _adDescription;
	private System.DateTime? _adDate;
	private System.Int32? _adStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ADModuleID
	{
		get
		{
			return _adModuleID;
		}
		set
		{
			_adModuleID = value;
		}
	}
	
	public System.String ADText
	{
		get
		{
			return _adText;
		}
		set
		{
			_adText = value;
		}
	}
	
	public System.String ADType
	{
		get
		{
			return _adType;
		}
		set
		{
			_adType = value;
		}
	}
	
	public System.String ADDescription
	{
		get
		{
			return _adDescription;
		}
		set
		{
			_adDescription = value;
		}
	}
	
	public System.DateTime? ADDate
	{
		get
		{
			return _adDate;
		}
		set
		{
			_adDate = value;
		}
	}
	
	public System.Int32? ADStatus
	{
		get
		{
			return _adStatus;
		}
		set
		{
			_adStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("AD_ModuleID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Text", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Type", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ADModuleID == null)
		dr["AD_ModuleID"] = DBNull.Value;
		else
		dr["AD_ModuleID"] = ADModuleID;
		
		if (ADText == null)
		dr["AD_Text"] = DBNull.Value;
		else
		dr["AD_Text"] = ADText;
		
		if (ADType == null)
		dr["AD_Type"] = DBNull.Value;
		else
		dr["AD_Type"] = ADType;
		
		if (ADDescription == null)
		dr["AD_Description"] = DBNull.Value;
		else
		dr["AD_Description"] = ADDescription;
		
		if (ADDate == null)
		dr["AD_Date"] = DBNull.Value;
		else
		dr["AD_Date"] = ADDate;
		
		if (ADStatus == null)
		dr["AD_Status"] = DBNull.Value;
		else
		dr["AD_Status"] = ADStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ADModuleID = dr["AD_ModuleID"] != DBNull.Value ? Convert.ToInt64(dr["AD_ModuleID"]) : ADModuleID = null;
		ADText = dr["AD_Text"] != DBNull.Value ? Convert.ToString(dr["AD_Text"]) : ADText = null;
		ADType = dr["AD_Type"] != DBNull.Value ? Convert.ToString(dr["AD_Type"]) : ADType = null;
		ADDescription = dr["AD_Description"] != DBNull.Value ? Convert.ToString(dr["AD_Description"]) : ADDescription = null;
		ADDate = dr["AD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["AD_Date"]) : ADDate = null;
		ADStatus = dr["AD_Status"] != DBNull.Value ? Convert.ToInt32(dr["AD_Status"]) : ADStatus = null;
	}
	
	public static TMSBasicAdvanceModule[] MapFrom(DataSet ds)
	{
		List<TMSBasicAdvanceModule> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSBasicAdvanceModule>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_BasicAdvanceModule] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_BasicAdvanceModule] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSBasicAdvanceModule instance = new TMSBasicAdvanceModule();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBasicAdvanceModule Get(System.Int64 adModuleID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSBasicAdvanceModule instance;
		
		
		instance = new TMSBasicAdvanceModule();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBasicAdvanceModule_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adModuleID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSBasicAdvanceModule ID:" + adModuleID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String adText, System.String adType, System.String adDescription, System.DateTime? adDate, System.Int32? adStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBasicAdvanceModule_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adText, adType, adDescription, adDate, adStatus);
		
		if (transaction == null)
		this.ADModuleID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ADModuleID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String adText, System.String adType, System.String adDescription, System.DateTime? adDate, System.Int32? adStatus)
	{
		Insert(adText, adType, adDescription, adDate, adStatus, null);
	}
	/// <summary>
	/// Insert current TMSBasicAdvanceModule to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ADText, ADType, ADDescription, ADDate, ADStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSBasicAdvanceModule to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? adModuleID, System.String adText, System.String adType, System.String adDescription, System.DateTime? adDate, System.Int32? adStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBasicAdvanceModule_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adModuleID"].Value = adModuleID;
		dbCommand.Parameters["@adText"].Value = adText;
		dbCommand.Parameters["@adType"].Value = adType;
		dbCommand.Parameters["@adDescription"].Value = adDescription;
		dbCommand.Parameters["@adDate"].Value = adDate;
		dbCommand.Parameters["@adStatus"].Value = adStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? adModuleID, System.String adText, System.String adType, System.String adDescription, System.DateTime? adDate, System.Int32? adStatus)
	{
		Update(adModuleID, adText, adType, adDescription, adDate, adStatus, null);
	}
	
	public static void Update(TMSBasicAdvanceModule tMSBasicAdvanceModule)
	{
		tMSBasicAdvanceModule.Update();
	}
	
	public static void Update(TMSBasicAdvanceModule tMSBasicAdvanceModule, DbTransaction transaction)
	{
		tMSBasicAdvanceModule.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSBasicAdvanceModule_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adModuleID"].SourceColumn = "AD_ModuleID";
		dbCommand.Parameters["@adText"].SourceColumn = "AD_Text";
		dbCommand.Parameters["@adType"].SourceColumn = "AD_Type";
		dbCommand.Parameters["@adDescription"].SourceColumn = "AD_Description";
		dbCommand.Parameters["@adDate"].SourceColumn = "AD_Date";
		dbCommand.Parameters["@adStatus"].SourceColumn = "AD_Status";
		
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
	public static void Delete(System.Int64? adModuleID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBasicAdvanceModule_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adModuleID);
		
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
	public static void Delete(System.Int64? adModuleID)
	{
		Delete(
		adModuleID);
	}
	
	/// <summary>
	/// Delete current TMSBasicAdvanceModule from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBasicAdvanceModule_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ADModuleID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ADModuleID = null;
	}
	
	/// <summary>
	/// Delete current TMSBasicAdvanceModule from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBasicAdvanceModule[] Search(System.Int64? adModuleID, System.String adText, System.String adType, System.String adDescription, System.DateTime? adDate, System.Int32? adStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBasicAdvanceModule_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adModuleID, adText, adType, adDescription, adDate, adStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSBasicAdvanceModule.MapFrom(ds);
	}
	
	
	public static TMSBasicAdvanceModule[] Search(TMSBasicAdvanceModule searchObject)
	{
		return Search ( searchObject.ADModuleID, searchObject.ADText, searchObject.ADType, searchObject.ADDescription, searchObject.ADDate, searchObject.ADStatus);
	}
	
	/// <summary>
	/// Returns all TMSBasicAdvanceModule objects.
	/// </summary>
	/// <returns>List of all TMSBasicAdvanceModule objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSBasicAdvanceModule[] Search()
	{
		return Search ( null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

