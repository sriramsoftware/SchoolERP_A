/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/8/2012 11:48:03 AM                                    */
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
public partial class TMSHolidayCalender
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_HolidayCalender]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _hcHolidayID;
	private System.String _hcName;
	private System.String _hcDscription;
	private System.String _hcDescription1;
	private System.String _hcType;
	private System.DateTime? _hcDate;
	private System.String _hcYear;
	private System.String _hcAddedby;
	private System.DateTime? _hcAdddate;
	private System.Int64? _hcSchoolCatId;
	private System.Int64? _hcSchoolSubCatID;
	private System.Int32? _hcStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? HCHolidayID
	{
		get
		{
			return _hcHolidayID;
		}
		set
		{
			_hcHolidayID = value;
		}
	}
	
	public System.String HCName
	{
		get
		{
			return _hcName;
		}
		set
		{
			_hcName = value;
		}
	}
	
	public System.String HCDscription
	{
		get
		{
			return _hcDscription;
		}
		set
		{
			_hcDscription = value;
		}
	}
	
	public System.String HCDescription1
	{
		get
		{
			return _hcDescription1;
		}
		set
		{
			_hcDescription1 = value;
		}
	}
	
	public System.String HCType
	{
		get
		{
			return _hcType;
		}
		set
		{
			_hcType = value;
		}
	}
	
	public System.DateTime? HCDate
	{
		get
		{
			return _hcDate;
		}
		set
		{
			_hcDate = value;
		}
	}
	
	public System.String HCYear
	{
		get
		{
			return _hcYear;
		}
		set
		{
			_hcYear = value;
		}
	}
	
	public System.String HCAddedby
	{
		get
		{
			return _hcAddedby;
		}
		set
		{
			_hcAddedby = value;
		}
	}
	
	public System.DateTime? HCAdddate
	{
		get
		{
			return _hcAdddate;
		}
		set
		{
			_hcAdddate = value;
		}
	}
	
	public System.Int64? HCSchoolCatId
	{
		get
		{
			return _hcSchoolCatId;
		}
		set
		{
			_hcSchoolCatId = value;
		}
	}
	
	public System.Int64? HCSchoolSubCatID
	{
		get
		{
			return _hcSchoolSubCatID;
		}
		set
		{
			_hcSchoolSubCatID = value;
		}
	}
	
	public System.Int32? HCStatus
	{
		get
		{
			return _hcStatus;
		}
		set
		{
			_hcStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("HC_HolidayID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("HC_Name", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("HC_Dscription", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("HC_Description1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("HC_Type", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("HC_date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("HC_year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("HC_Addedby", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("HC_adddate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("HC_SchoolCatId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("HC_SchoolSubCatID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("HC_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (HCHolidayID == null)
		dr["HC_HolidayID"] = DBNull.Value;
		else
		dr["HC_HolidayID"] = HCHolidayID;
		
		if (HCName == null)
		dr["HC_Name"] = DBNull.Value;
		else
		dr["HC_Name"] = HCName;
		
		if (HCDscription == null)
		dr["HC_Dscription"] = DBNull.Value;
		else
		dr["HC_Dscription"] = HCDscription;
		
		if (HCDescription1 == null)
		dr["HC_Description1"] = DBNull.Value;
		else
		dr["HC_Description1"] = HCDescription1;
		
		if (HCType == null)
		dr["HC_Type"] = DBNull.Value;
		else
		dr["HC_Type"] = HCType;
		
		if (HCDate == null)
		dr["HC_date"] = DBNull.Value;
		else
		dr["HC_date"] = HCDate;
		
		if (HCYear == null)
		dr["HC_year"] = DBNull.Value;
		else
		dr["HC_year"] = HCYear;
		
		if (HCAddedby == null)
		dr["HC_Addedby"] = DBNull.Value;
		else
		dr["HC_Addedby"] = HCAddedby;
		
		if (HCAdddate == null)
		dr["HC_adddate"] = DBNull.Value;
		else
		dr["HC_adddate"] = HCAdddate;
		
		if (HCSchoolCatId == null)
		dr["HC_SchoolCatId"] = DBNull.Value;
		else
		dr["HC_SchoolCatId"] = HCSchoolCatId;
		
		if (HCSchoolSubCatID == null)
		dr["HC_SchoolSubCatID"] = DBNull.Value;
		else
		dr["HC_SchoolSubCatID"] = HCSchoolSubCatID;
		
		if (HCStatus == null)
		dr["HC_Status"] = DBNull.Value;
		else
		dr["HC_Status"] = HCStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		HCHolidayID = dr["HC_HolidayID"] != DBNull.Value ? Convert.ToInt64(dr["HC_HolidayID"]) : HCHolidayID = null;
		HCName = dr["HC_Name"] != DBNull.Value ? Convert.ToString(dr["HC_Name"]) : HCName = null;
		HCDscription = dr["HC_Dscription"] != DBNull.Value ? Convert.ToString(dr["HC_Dscription"]) : HCDscription = null;
		HCDescription1 = dr["HC_Description1"] != DBNull.Value ? Convert.ToString(dr["HC_Description1"]) : HCDescription1 = null;
		HCType = dr["HC_Type"] != DBNull.Value ? Convert.ToString(dr["HC_Type"]) : HCType = null;
		HCDate = dr["HC_date"] != DBNull.Value ? Convert.ToDateTime(dr["HC_date"]) : HCDate = null;
		HCYear = dr["HC_year"] != DBNull.Value ? Convert.ToString(dr["HC_year"]) : HCYear = null;
		HCAddedby = dr["HC_Addedby"] != DBNull.Value ? Convert.ToString(dr["HC_Addedby"]) : HCAddedby = null;
		HCAdddate = dr["HC_adddate"] != DBNull.Value ? Convert.ToDateTime(dr["HC_adddate"]) : HCAdddate = null;
		HCSchoolCatId = dr["HC_SchoolCatId"] != DBNull.Value ? Convert.ToInt64(dr["HC_SchoolCatId"]) : HCSchoolCatId = null;
		HCSchoolSubCatID = dr["HC_SchoolSubCatID"] != DBNull.Value ? Convert.ToInt64(dr["HC_SchoolSubCatID"]) : HCSchoolSubCatID = null;
		HCStatus = dr["HC_Status"] != DBNull.Value ? Convert.ToInt32(dr["HC_Status"]) : HCStatus = null;
	}
	
	public static TMSHolidayCalender[] MapFrom(DataSet ds)
	{
		List<TMSHolidayCalender> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSHolidayCalender>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_HolidayCalender] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_HolidayCalender] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSHolidayCalender instance = new TMSHolidayCalender();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSHolidayCalender Get(System.Int64 hcHolidayID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSHolidayCalender instance;
		
		
		instance = new TMSHolidayCalender();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSHolidayCalender_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, hcHolidayID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSHolidayCalender ID:" + hcHolidayID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String hcName, System.String hcDscription, System.String hcDescription1, System.String hcType, System.DateTime? hcDate, System.String hcYear, System.String hcAddedby, System.DateTime? hcAdddate, System.Int64? hcSchoolCatId, System.Int64? hcSchoolSubCatID, System.Int32? hcStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSHolidayCalender_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, hcName, hcDscription, hcDescription1, hcType, hcDate, hcYear, hcAddedby, hcAdddate, hcSchoolCatId, hcSchoolSubCatID, hcStatus);
		
		if (transaction == null)
		this.HCHolidayID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.HCHolidayID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String hcName, System.String hcDscription, System.String hcDescription1, System.String hcType, System.DateTime? hcDate, System.String hcYear, System.String hcAddedby, System.DateTime? hcAdddate, System.Int64? hcSchoolCatId, System.Int64? hcSchoolSubCatID, System.Int32? hcStatus)
	{
		Insert(hcName, hcDscription, hcDescription1, hcType, hcDate, hcYear, hcAddedby, hcAdddate, hcSchoolCatId, hcSchoolSubCatID, hcStatus, null);
	}
	/// <summary>
	/// Insert current TMSHolidayCalender to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(HCName, HCDscription, HCDescription1, HCType, HCDate, HCYear, HCAddedby, HCAdddate, HCSchoolCatId, HCSchoolSubCatID, HCStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSHolidayCalender to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? hcHolidayID, System.String hcName, System.String hcDscription, System.String hcDescription1, System.String hcType, System.DateTime? hcDate, System.String hcYear, System.String hcAddedby, System.DateTime? hcAdddate, System.Int64? hcSchoolCatId, System.Int64? hcSchoolSubCatID, System.Int32? hcStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSHolidayCalender_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@hcHolidayID"].Value = hcHolidayID;
		dbCommand.Parameters["@hcName"].Value = hcName;
		dbCommand.Parameters["@hcDscription"].Value = hcDscription;
		dbCommand.Parameters["@hcDescription1"].Value = hcDescription1;
		dbCommand.Parameters["@hcType"].Value = hcType;
		dbCommand.Parameters["@hcDate"].Value = hcDate;
		dbCommand.Parameters["@hcYear"].Value = hcYear;
		dbCommand.Parameters["@hcAddedby"].Value = hcAddedby;
		dbCommand.Parameters["@hcAdddate"].Value = hcAdddate;
		dbCommand.Parameters["@hcSchoolCatId"].Value = hcSchoolCatId;
		dbCommand.Parameters["@hcSchoolSubCatID"].Value = hcSchoolSubCatID;
		dbCommand.Parameters["@hcStatus"].Value = hcStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? hcHolidayID, System.String hcName, System.String hcDscription, System.String hcDescription1, System.String hcType, System.DateTime? hcDate, System.String hcYear, System.String hcAddedby, System.DateTime? hcAdddate, System.Int64? hcSchoolCatId, System.Int64? hcSchoolSubCatID, System.Int32? hcStatus)
	{
		Update(hcHolidayID, hcName, hcDscription, hcDescription1, hcType, hcDate, hcYear, hcAddedby, hcAdddate, hcSchoolCatId, hcSchoolSubCatID, hcStatus, null);
	}
	
	public static void Update(TMSHolidayCalender tMSHolidayCalender)
	{
		tMSHolidayCalender.Update();
	}
	
	public static void Update(TMSHolidayCalender tMSHolidayCalender, DbTransaction transaction)
	{
		tMSHolidayCalender.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSHolidayCalender_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@hcHolidayID"].SourceColumn = "HC_HolidayID";
		dbCommand.Parameters["@hcName"].SourceColumn = "HC_Name";
		dbCommand.Parameters["@hcDscription"].SourceColumn = "HC_Dscription";
		dbCommand.Parameters["@hcDescription1"].SourceColumn = "HC_Description1";
		dbCommand.Parameters["@hcType"].SourceColumn = "HC_Type";
		dbCommand.Parameters["@hcDate"].SourceColumn = "HC_date";
		dbCommand.Parameters["@hcYear"].SourceColumn = "HC_year";
		dbCommand.Parameters["@hcAddedby"].SourceColumn = "HC_Addedby";
		dbCommand.Parameters["@hcAdddate"].SourceColumn = "HC_adddate";
		dbCommand.Parameters["@hcSchoolCatId"].SourceColumn = "HC_SchoolCatId";
		dbCommand.Parameters["@hcSchoolSubCatID"].SourceColumn = "HC_SchoolSubCatID";
		dbCommand.Parameters["@hcStatus"].SourceColumn = "HC_Status";
		
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
	public static void Delete(System.Int64? hcHolidayID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSHolidayCalender_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, hcHolidayID);
		
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
	public static void Delete(System.Int64? hcHolidayID)
	{
		Delete(
		hcHolidayID);
	}
	
	/// <summary>
	/// Delete current TMSHolidayCalender from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSHolidayCalender_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, HCHolidayID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.HCHolidayID = null;
	}
	
	/// <summary>
	/// Delete current TMSHolidayCalender from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSHolidayCalender[] Search(System.Int64? hcHolidayID, System.String hcName, System.String hcDscription, System.String hcDescription1, System.String hcType, System.DateTime? hcDate, System.String hcYear, System.String hcAddedby, System.DateTime? hcAdddate, System.Int64? hcSchoolCatId, System.Int64? hcSchoolSubCatID, System.Int32? hcStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSHolidayCalender_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, hcHolidayID, hcName, hcDscription, hcDescription1, hcType, hcDate, hcYear, hcAddedby, hcAdddate, hcSchoolCatId, hcSchoolSubCatID, hcStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSHolidayCalender.MapFrom(ds);
	}
	
	
	public static TMSHolidayCalender[] Search(TMSHolidayCalender searchObject)
	{
		return Search ( searchObject.HCHolidayID, searchObject.HCName, searchObject.HCDscription, searchObject.HCDescription1, searchObject.HCType, searchObject.HCDate, searchObject.HCYear, searchObject.HCAddedby, searchObject.HCAdddate, searchObject.HCSchoolCatId, searchObject.HCSchoolSubCatID, searchObject.HCStatus);
	}
	
	/// <summary>
	/// Returns all TMSHolidayCalender objects.
	/// </summary>
	/// <returns>List of all TMSHolidayCalender objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSHolidayCalender[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

