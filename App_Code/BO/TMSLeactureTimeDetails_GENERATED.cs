/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/12/2012 1:23:03 PM                                    */
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
public partial class TMSLeactureTimeDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_LeactureTimeDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ltdTimeId;
	private System.String _ltdStartTime;
	private System.String _ltdEndTime;
	private System.Int64? _ltdSchoolCatId;
	private System.Int64? _ltdSubCategoryId;
	private System.DateTime? _ltdDate;
	private System.Int32? _ltdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? LTDTimeId
	{
		get
		{
			return _ltdTimeId;
		}
		set
		{
			_ltdTimeId = value;
		}
	}
	
	public System.String LTDStartTime
	{
		get
		{
			return _ltdStartTime;
		}
		set
		{
			_ltdStartTime = value;
		}
	}
	
	public System.String LTDEndTime
	{
		get
		{
			return _ltdEndTime;
		}
		set
		{
			_ltdEndTime = value;
		}
	}
	
	public System.Int64? LTDSchoolCatId
	{
		get
		{
			return _ltdSchoolCatId;
		}
		set
		{
			_ltdSchoolCatId = value;
		}
	}
	
	public System.Int64? LTDSubCategoryId
	{
		get
		{
			return _ltdSubCategoryId;
		}
		set
		{
			_ltdSubCategoryId = value;
		}
	}
	
	public System.DateTime? LTDDate
	{
		get
		{
			return _ltdDate;
		}
		set
		{
			_ltdDate = value;
		}
	}
	
	public System.Int32? LTDStatus
	{
		get
		{
			return _ltdStatus;
		}
		set
		{
			_ltdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("LTD_TimeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LTD_StartTime", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LTD_EndTime", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LTD_SchoolCatId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LTD_SubCategoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LTD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("LTD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (LTDTimeId == null)
		dr["LTD_TimeId"] = DBNull.Value;
		else
		dr["LTD_TimeId"] = LTDTimeId;
		
		if (LTDStartTime == null)
		dr["LTD_StartTime"] = DBNull.Value;
		else
		dr["LTD_StartTime"] = LTDStartTime;
		
		if (LTDEndTime == null)
		dr["LTD_EndTime"] = DBNull.Value;
		else
		dr["LTD_EndTime"] = LTDEndTime;
		
		if (LTDSchoolCatId == null)
		dr["LTD_SchoolCatId"] = DBNull.Value;
		else
		dr["LTD_SchoolCatId"] = LTDSchoolCatId;
		
		if (LTDSubCategoryId == null)
		dr["LTD_SubCategoryId"] = DBNull.Value;
		else
		dr["LTD_SubCategoryId"] = LTDSubCategoryId;
		
		if (LTDDate == null)
		dr["LTD_Date"] = DBNull.Value;
		else
		dr["LTD_Date"] = LTDDate;
		
		if (LTDStatus == null)
		dr["LTD_Status"] = DBNull.Value;
		else
		dr["LTD_Status"] = LTDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		LTDTimeId = dr["LTD_TimeId"] != DBNull.Value ? Convert.ToInt64(dr["LTD_TimeId"]) : LTDTimeId = null;
		LTDStartTime = dr["LTD_StartTime"] != DBNull.Value ? Convert.ToString(dr["LTD_StartTime"]) : LTDStartTime = null;
		LTDEndTime = dr["LTD_EndTime"] != DBNull.Value ? Convert.ToString(dr["LTD_EndTime"]) : LTDEndTime = null;
		LTDSchoolCatId = dr["LTD_SchoolCatId"] != DBNull.Value ? Convert.ToInt64(dr["LTD_SchoolCatId"]) : LTDSchoolCatId = null;
		LTDSubCategoryId = dr["LTD_SubCategoryId"] != DBNull.Value ? Convert.ToInt64(dr["LTD_SubCategoryId"]) : LTDSubCategoryId = null;
		LTDDate = dr["LTD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["LTD_Date"]) : LTDDate = null;
		LTDStatus = dr["LTD_Status"] != DBNull.Value ? Convert.ToInt32(dr["LTD_Status"]) : LTDStatus = null;
	}
	
	public static TMSLeactureTimeDetails[] MapFrom(DataSet ds)
	{
		List<TMSLeactureTimeDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSLeactureTimeDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_LeactureTimeDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_LeactureTimeDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSLeactureTimeDetails instance = new TMSLeactureTimeDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLeactureTimeDetails Get(System.Int64 ltdTimeId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSLeactureTimeDetails instance;
		
		
		instance = new TMSLeactureTimeDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeactureTimeDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ltdTimeId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSLeactureTimeDetails ID:" + ltdTimeId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String ltdStartTime, System.String ltdEndTime, System.Int64? ltdSchoolCatId, System.Int64? ltdSubCategoryId, System.DateTime? ltdDate, System.Int32? ltdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeactureTimeDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ltdStartTime, ltdEndTime, ltdSchoolCatId, ltdSubCategoryId, ltdDate, ltdStatus);
		
		if (transaction == null)
		this.LTDTimeId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.LTDTimeId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String ltdStartTime, System.String ltdEndTime, System.Int64? ltdSchoolCatId, System.Int64? ltdSubCategoryId, System.DateTime? ltdDate, System.Int32? ltdStatus)
	{
		Insert(ltdStartTime, ltdEndTime, ltdSchoolCatId, ltdSubCategoryId, ltdDate, ltdStatus, null);
	}
	/// <summary>
	/// Insert current TMSLeactureTimeDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(LTDStartTime, LTDEndTime, LTDSchoolCatId, LTDSubCategoryId, LTDDate, LTDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSLeactureTimeDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ltdTimeId, System.String ltdStartTime, System.String ltdEndTime, System.Int64? ltdSchoolCatId, System.Int64? ltdSubCategoryId, System.DateTime? ltdDate, System.Int32? ltdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeactureTimeDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ltdTimeId"].Value = ltdTimeId;
		dbCommand.Parameters["@ltdStartTime"].Value = ltdStartTime;
		dbCommand.Parameters["@ltdEndTime"].Value = ltdEndTime;
		dbCommand.Parameters["@ltdSchoolCatId"].Value = ltdSchoolCatId;
		dbCommand.Parameters["@ltdSubCategoryId"].Value = ltdSubCategoryId;
		dbCommand.Parameters["@ltdDate"].Value = ltdDate;
		dbCommand.Parameters["@ltdStatus"].Value = ltdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ltdTimeId, System.String ltdStartTime, System.String ltdEndTime, System.Int64? ltdSchoolCatId, System.Int64? ltdSubCategoryId, System.DateTime? ltdDate, System.Int32? ltdStatus)
	{
		Update(ltdTimeId, ltdStartTime, ltdEndTime, ltdSchoolCatId, ltdSubCategoryId, ltdDate, ltdStatus, null);
	}
	
	public static void Update(TMSLeactureTimeDetails tMSLeactureTimeDetails)
	{
		tMSLeactureTimeDetails.Update();
	}
	
	public static void Update(TMSLeactureTimeDetails tMSLeactureTimeDetails, DbTransaction transaction)
	{
		tMSLeactureTimeDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSLeactureTimeDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ltdTimeId"].SourceColumn = "LTD_TimeId";
		dbCommand.Parameters["@ltdStartTime"].SourceColumn = "LTD_StartTime";
		dbCommand.Parameters["@ltdEndTime"].SourceColumn = "LTD_EndTime";
		dbCommand.Parameters["@ltdSchoolCatId"].SourceColumn = "LTD_SchoolCatId";
		dbCommand.Parameters["@ltdSubCategoryId"].SourceColumn = "LTD_SubCategoryId";
		dbCommand.Parameters["@ltdDate"].SourceColumn = "LTD_Date";
		dbCommand.Parameters["@ltdStatus"].SourceColumn = "LTD_Status";
		
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
	public static void Delete(System.Int64? ltdTimeId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeactureTimeDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ltdTimeId);
		
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
	public static void Delete(System.Int64? ltdTimeId)
	{
		Delete(
		ltdTimeId);
	}
	
	/// <summary>
	/// Delete current TMSLeactureTimeDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeactureTimeDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, LTDTimeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.LTDTimeId = null;
	}
	
	/// <summary>
	/// Delete current TMSLeactureTimeDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLeactureTimeDetails[] Search(System.Int64? ltdTimeId, System.String ltdStartTime, System.String ltdEndTime, System.Int64? ltdSchoolCatId, System.Int64? ltdSubCategoryId, System.DateTime? ltdDate, System.Int32? ltdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeactureTimeDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ltdTimeId, ltdStartTime, ltdEndTime, ltdSchoolCatId, ltdSubCategoryId, ltdDate, ltdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSLeactureTimeDetails.MapFrom(ds);
	}
	
	
	public static TMSLeactureTimeDetails[] Search(TMSLeactureTimeDetails searchObject)
	{
		return Search ( searchObject.LTDTimeId, searchObject.LTDStartTime, searchObject.LTDEndTime, searchObject.LTDSchoolCatId, searchObject.LTDSubCategoryId, searchObject.LTDDate, searchObject.LTDStatus);
	}
	
	/// <summary>
	/// Returns all TMSLeactureTimeDetails objects.
	/// </summary>
	/// <returns>List of all TMSLeactureTimeDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSLeactureTimeDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

