/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/6/2012 10:06:58 AM                                    */
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
public partial class TMSLogHistory
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_LogHistory]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _lhHistoryId;
	private System.Int64? _lhFacultyLoginId;
	private System.String _lhLoginType;
	private System.String _lhLogType;
	private System.String _lhActivityDo;
	private System.DateTime? _lhStartTime;
	private System.DateTime? _lhEndTime;
	private System.Int64? _lhAddedById;
	private System.DateTime? _lhDate;
	private System.Int32? _lhStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? LHHistoryId
	{
		get
		{
			return _lhHistoryId;
		}
		set
		{
			_lhHistoryId = value;
		}
	}
	
	public System.Int64? LHFacultyLoginId
	{
		get
		{
			return _lhFacultyLoginId;
		}
		set
		{
			_lhFacultyLoginId = value;
		}
	}
	
	public System.String LHLoginType
	{
		get
		{
			return _lhLoginType;
		}
		set
		{
			_lhLoginType = value;
		}
	}
	
	public System.String LHLogType
	{
		get
		{
			return _lhLogType;
		}
		set
		{
			_lhLogType = value;
		}
	}
	
	public System.String LHActivityDo
	{
		get
		{
			return _lhActivityDo;
		}
		set
		{
			_lhActivityDo = value;
		}
	}
	
	public System.DateTime? LHStartTime
	{
		get
		{
			return _lhStartTime;
		}
		set
		{
			_lhStartTime = value;
		}
	}
	
	public System.DateTime? LHEndTime
	{
		get
		{
			return _lhEndTime;
		}
		set
		{
			_lhEndTime = value;
		}
	}
	
	public System.Int64? LHAddedById
	{
		get
		{
			return _lhAddedById;
		}
		set
		{
			_lhAddedById = value;
		}
	}
	
	public System.DateTime? LHDate
	{
		get
		{
			return _lhDate;
		}
		set
		{
			_lhDate = value;
		}
	}
	
	public System.Int32? LHStatus
	{
		get
		{
			return _lhStatus;
		}
		set
		{
			_lhStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("LH_HistoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LH_FacultyLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LH_LoginType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LH_LogType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LH_ActivityDo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LH_StartTime", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("LH_EndTime", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("LH_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LH_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("LH_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (LHHistoryId == null)
		dr["LH_HistoryId"] = DBNull.Value;
		else
		dr["LH_HistoryId"] = LHHistoryId;
		
		if (LHFacultyLoginId == null)
		dr["LH_FacultyLoginId"] = DBNull.Value;
		else
		dr["LH_FacultyLoginId"] = LHFacultyLoginId;
		
		if (LHLoginType == null)
		dr["LH_LoginType"] = DBNull.Value;
		else
		dr["LH_LoginType"] = LHLoginType;
		
		if (LHLogType == null)
		dr["LH_LogType"] = DBNull.Value;
		else
		dr["LH_LogType"] = LHLogType;
		
		if (LHActivityDo == null)
		dr["LH_ActivityDo"] = DBNull.Value;
		else
		dr["LH_ActivityDo"] = LHActivityDo;
		
		if (LHStartTime == null)
		dr["LH_StartTime"] = DBNull.Value;
		else
		dr["LH_StartTime"] = LHStartTime;
		
		if (LHEndTime == null)
		dr["LH_EndTime"] = DBNull.Value;
		else
		dr["LH_EndTime"] = LHEndTime;
		
		if (LHAddedById == null)
		dr["LH_AddedById"] = DBNull.Value;
		else
		dr["LH_AddedById"] = LHAddedById;
		
		if (LHDate == null)
		dr["LH_Date"] = DBNull.Value;
		else
		dr["LH_Date"] = LHDate;
		
		if (LHStatus == null)
		dr["LH_Status"] = DBNull.Value;
		else
		dr["LH_Status"] = LHStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		LHHistoryId = dr["LH_HistoryId"] != DBNull.Value ? Convert.ToInt64(dr["LH_HistoryId"]) : LHHistoryId = null;
		LHFacultyLoginId = dr["LH_FacultyLoginId"] != DBNull.Value ? Convert.ToInt64(dr["LH_FacultyLoginId"]) : LHFacultyLoginId = null;
		LHLoginType = dr["LH_LoginType"] != DBNull.Value ? Convert.ToString(dr["LH_LoginType"]) : LHLoginType = null;
		LHLogType = dr["LH_LogType"] != DBNull.Value ? Convert.ToString(dr["LH_LogType"]) : LHLogType = null;
		LHActivityDo = dr["LH_ActivityDo"] != DBNull.Value ? Convert.ToString(dr["LH_ActivityDo"]) : LHActivityDo = null;
		LHStartTime = dr["LH_StartTime"] != DBNull.Value ? Convert.ToDateTime(dr["LH_StartTime"]) : LHStartTime = null;
		LHEndTime = dr["LH_EndTime"] != DBNull.Value ? Convert.ToDateTime(dr["LH_EndTime"]) : LHEndTime = null;
		LHAddedById = dr["LH_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["LH_AddedById"]) : LHAddedById = null;
		LHDate = dr["LH_Date"] != DBNull.Value ? Convert.ToDateTime(dr["LH_Date"]) : LHDate = null;
		LHStatus = dr["LH_Status"] != DBNull.Value ? Convert.ToInt32(dr["LH_Status"]) : LHStatus = null;
	}
	
	public static TMSLogHistory[] MapFrom(DataSet ds)
	{
		List<TMSLogHistory> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSLogHistory>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_LogHistory] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_LogHistory] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSLogHistory instance = new TMSLogHistory();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLogHistory Get(System.Int64 lhHistoryId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSLogHistory instance;
		
		
		instance = new TMSLogHistory();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLogHistory_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, lhHistoryId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSLogHistory ID:" + lhHistoryId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? lhFacultyLoginId, System.String lhLoginType, System.String lhLogType, System.String lhActivityDo, System.DateTime? lhStartTime, System.DateTime? lhEndTime, System.Int64? lhAddedById, System.DateTime? lhDate, System.Int32? lhStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLogHistory_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, lhFacultyLoginId, lhLoginType, lhLogType, lhActivityDo, lhStartTime, lhEndTime, lhAddedById, lhDate, lhStatus);
		
		if (transaction == null)
		this.LHHistoryId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.LHHistoryId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? lhFacultyLoginId, System.String lhLoginType, System.String lhLogType, System.String lhActivityDo, System.DateTime? lhStartTime, System.DateTime? lhEndTime, System.Int64? lhAddedById, System.DateTime? lhDate, System.Int32? lhStatus)
	{
		Insert(lhFacultyLoginId, lhLoginType, lhLogType, lhActivityDo, lhStartTime, lhEndTime, lhAddedById, lhDate, lhStatus, null);
	}
	/// <summary>
	/// Insert current TMSLogHistory to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(LHFacultyLoginId, LHLoginType, LHLogType, LHActivityDo, LHStartTime, LHEndTime, LHAddedById, LHDate, LHStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSLogHistory to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? lhHistoryId, System.Int64? lhFacultyLoginId, System.String lhLoginType, System.String lhLogType, System.String lhActivityDo, System.DateTime? lhStartTime, System.DateTime? lhEndTime, System.Int64? lhAddedById, System.DateTime? lhDate, System.Int32? lhStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLogHistory_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@lhHistoryId"].Value = lhHistoryId;
		dbCommand.Parameters["@lhFacultyLoginId"].Value = lhFacultyLoginId;
		dbCommand.Parameters["@lhLoginType"].Value = lhLoginType;
		dbCommand.Parameters["@lhLogType"].Value = lhLogType;
		dbCommand.Parameters["@lhActivityDo"].Value = lhActivityDo;
		dbCommand.Parameters["@lhStartTime"].Value = lhStartTime;
		dbCommand.Parameters["@lhEndTime"].Value = lhEndTime;
		dbCommand.Parameters["@lhAddedById"].Value = lhAddedById;
		dbCommand.Parameters["@lhDate"].Value = lhDate;
		dbCommand.Parameters["@lhStatus"].Value = lhStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? lhHistoryId, System.Int64? lhFacultyLoginId, System.String lhLoginType, System.String lhLogType, System.String lhActivityDo, System.DateTime? lhStartTime, System.DateTime? lhEndTime, System.Int64? lhAddedById, System.DateTime? lhDate, System.Int32? lhStatus)
	{
		Update(lhHistoryId, lhFacultyLoginId, lhLoginType, lhLogType, lhActivityDo, lhStartTime, lhEndTime, lhAddedById, lhDate, lhStatus, null);
	}
	
	public static void Update(TMSLogHistory tMSLogHistory)
	{
		tMSLogHistory.Update();
	}
	
	public static void Update(TMSLogHistory tMSLogHistory, DbTransaction transaction)
	{
		tMSLogHistory.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSLogHistory_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@lhHistoryId"].SourceColumn = "LH_HistoryId";
		dbCommand.Parameters["@lhFacultyLoginId"].SourceColumn = "LH_FacultyLoginId";
		dbCommand.Parameters["@lhLoginType"].SourceColumn = "LH_LoginType";
		dbCommand.Parameters["@lhLogType"].SourceColumn = "LH_LogType";
		dbCommand.Parameters["@lhActivityDo"].SourceColumn = "LH_ActivityDo";
		dbCommand.Parameters["@lhStartTime"].SourceColumn = "LH_StartTime";
		dbCommand.Parameters["@lhEndTime"].SourceColumn = "LH_EndTime";
		dbCommand.Parameters["@lhAddedById"].SourceColumn = "LH_AddedById";
		dbCommand.Parameters["@lhDate"].SourceColumn = "LH_Date";
		dbCommand.Parameters["@lhStatus"].SourceColumn = "LH_Status";
		
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
	public static void Delete(System.Int64? lhHistoryId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLogHistory_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, lhHistoryId);
		
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
	public static void Delete(System.Int64? lhHistoryId)
	{
		Delete(
		lhHistoryId);
	}
	
	/// <summary>
	/// Delete current TMSLogHistory from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLogHistory_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, LHHistoryId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.LHHistoryId = null;
	}
	
	/// <summary>
	/// Delete current TMSLogHistory from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLogHistory[] Search(System.Int64? lhHistoryId, System.Int64? lhFacultyLoginId, System.String lhLoginType, System.String lhLogType, System.String lhActivityDo, System.DateTime? lhStartTime, System.DateTime? lhEndTime, System.Int64? lhAddedById, System.DateTime? lhDate, System.Int32? lhStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLogHistory_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, lhHistoryId, lhFacultyLoginId, lhLoginType, lhLogType, lhActivityDo, lhStartTime, lhEndTime, lhAddedById, lhDate, lhStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSLogHistory.MapFrom(ds);
	}
	
	
	public static TMSLogHistory[] Search(TMSLogHistory searchObject)
	{
		return Search ( searchObject.LHHistoryId, searchObject.LHFacultyLoginId, searchObject.LHLoginType, searchObject.LHLogType, searchObject.LHActivityDo, searchObject.LHStartTime, searchObject.LHEndTime, searchObject.LHAddedById, searchObject.LHDate, searchObject.LHStatus);
	}
	
	/// <summary>
	/// Returns all TMSLogHistory objects.
	/// </summary>
	/// <returns>List of all TMSLogHistory objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSLogHistory[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

