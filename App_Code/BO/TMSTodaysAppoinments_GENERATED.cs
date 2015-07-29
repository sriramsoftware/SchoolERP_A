/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/31/2012 12:24:16 PM                                    */
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
public partial class TMSTodaysAppoinments
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_TodaysAppoinments]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _taId;
	private System.Int64? _taTitleType;
	private System.String _taTitle;
	private System.String _taWhomeTo;
	private System.String _taReason;
	private System.String _taPriority;
	private System.DateTime? _taAppointMentDate;
	private System.String _taTime;
	private System.String _taAppointMentStatus;
	private System.String _taExtra;
	private System.DateTime? _taDate;
	private System.Int32? _taStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? TaId
	{
		get
		{
			return _taId;
		}
		set
		{
			_taId = value;
		}
	}
	
	public System.Int64? TATitleType
	{
		get
		{
			return _taTitleType;
		}
		set
		{
			_taTitleType = value;
		}
	}
	
	public System.String TATitle
	{
		get
		{
			return _taTitle;
		}
		set
		{
			_taTitle = value;
		}
	}
	
	public System.String TAWhomeTo
	{
		get
		{
			return _taWhomeTo;
		}
		set
		{
			_taWhomeTo = value;
		}
	}
	
	public System.String TAReason
	{
		get
		{
			return _taReason;
		}
		set
		{
			_taReason = value;
		}
	}
	
	public System.String TAPriority
	{
		get
		{
			return _taPriority;
		}
		set
		{
			_taPriority = value;
		}
	}
	
	public System.DateTime? TAAppointMentDate
	{
		get
		{
			return _taAppointMentDate;
		}
		set
		{
			_taAppointMentDate = value;
		}
	}
	
	public System.String TATime
	{
		get
		{
			return _taTime;
		}
		set
		{
			_taTime = value;
		}
	}
	
	public System.String TAAppointMentStatus
	{
		get
		{
			return _taAppointMentStatus;
		}
		set
		{
			_taAppointMentStatus = value;
		}
	}
	
	public System.String TAExtra
	{
		get
		{
			return _taExtra;
		}
		set
		{
			_taExtra = value;
		}
	}
	
	public System.DateTime? TADate
	{
		get
		{
			return _taDate;
		}
		set
		{
			_taDate = value;
		}
	}
	
	public System.Int32? TAStatus
	{
		get
		{
			return _taStatus;
		}
		set
		{
			_taStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("TA_ID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TA_TitleType", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TA_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TA_WhomeTo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TA_Reason", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TA_Priority", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TA_AppointMentDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("TA_Time", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TA_AppointMentStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TA_Extra", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TA_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("TA_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (TaId == null)
		dr["TA_ID"] = DBNull.Value;
		else
		dr["TA_ID"] = TaId;
		
		if (TATitleType == null)
		dr["TA_TitleType"] = DBNull.Value;
		else
		dr["TA_TitleType"] = TATitleType;
		
		if (TATitle == null)
		dr["TA_Title"] = DBNull.Value;
		else
		dr["TA_Title"] = TATitle;
		
		if (TAWhomeTo == null)
		dr["TA_WhomeTo"] = DBNull.Value;
		else
		dr["TA_WhomeTo"] = TAWhomeTo;
		
		if (TAReason == null)
		dr["TA_Reason"] = DBNull.Value;
		else
		dr["TA_Reason"] = TAReason;
		
		if (TAPriority == null)
		dr["TA_Priority"] = DBNull.Value;
		else
		dr["TA_Priority"] = TAPriority;
		
		if (TAAppointMentDate == null)
		dr["TA_AppointMentDate"] = DBNull.Value;
		else
		dr["TA_AppointMentDate"] = TAAppointMentDate;
		
		if (TATime == null)
		dr["TA_Time"] = DBNull.Value;
		else
		dr["TA_Time"] = TATime;
		
		if (TAAppointMentStatus == null)
		dr["TA_AppointMentStatus"] = DBNull.Value;
		else
		dr["TA_AppointMentStatus"] = TAAppointMentStatus;
		
		if (TAExtra == null)
		dr["TA_Extra"] = DBNull.Value;
		else
		dr["TA_Extra"] = TAExtra;
		
		if (TADate == null)
		dr["TA_Date"] = DBNull.Value;
		else
		dr["TA_Date"] = TADate;
		
		if (TAStatus == null)
		dr["TA_Status"] = DBNull.Value;
		else
		dr["TA_Status"] = TAStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		TaId = dr["TA_ID"] != DBNull.Value ? Convert.ToInt64(dr["TA_ID"]) : TaId = null;
		TATitleType = dr["TA_TitleType"] != DBNull.Value ? Convert.ToInt64(dr["TA_TitleType"]) : TATitleType = null;
		TATitle = dr["TA_Title"] != DBNull.Value ? Convert.ToString(dr["TA_Title"]) : TATitle = null;
		TAWhomeTo = dr["TA_WhomeTo"] != DBNull.Value ? Convert.ToString(dr["TA_WhomeTo"]) : TAWhomeTo = null;
		TAReason = dr["TA_Reason"] != DBNull.Value ? Convert.ToString(dr["TA_Reason"]) : TAReason = null;
		TAPriority = dr["TA_Priority"] != DBNull.Value ? Convert.ToString(dr["TA_Priority"]) : TAPriority = null;
		TAAppointMentDate = dr["TA_AppointMentDate"] != DBNull.Value ? Convert.ToDateTime(dr["TA_AppointMentDate"]) : TAAppointMentDate = null;
		TATime = dr["TA_Time"] != DBNull.Value ? Convert.ToString(dr["TA_Time"]) : TATime = null;
		TAAppointMentStatus = dr["TA_AppointMentStatus"] != DBNull.Value ? Convert.ToString(dr["TA_AppointMentStatus"]) : TAAppointMentStatus = null;
		TAExtra = dr["TA_Extra"] != DBNull.Value ? Convert.ToString(dr["TA_Extra"]) : TAExtra = null;
		TADate = dr["TA_Date"] != DBNull.Value ? Convert.ToDateTime(dr["TA_Date"]) : TADate = null;
		TAStatus = dr["TA_Status"] != DBNull.Value ? Convert.ToInt32(dr["TA_Status"]) : TAStatus = null;
	}
	
	public static TMSTodaysAppoinments[] MapFrom(DataSet ds)
	{
		List<TMSTodaysAppoinments> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSTodaysAppoinments>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_TodaysAppoinments] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_TodaysAppoinments] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSTodaysAppoinments instance = new TMSTodaysAppoinments();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTodaysAppoinments Get(System.Int64 taId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSTodaysAppoinments instance;
		
		
		instance = new TMSTodaysAppoinments();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTodaysAppoinments_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, taId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSTodaysAppoinments ID:" + taId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? taTitleType, System.String taTitle, System.String taWhomeTo, System.String taReason, System.String taPriority, System.DateTime? taAppointMentDate, System.String taTime, System.String taAppointMentStatus, System.String taExtra, System.DateTime? taDate, System.Int32? taStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTodaysAppoinments_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, taTitleType, taTitle, taWhomeTo, taReason, taPriority, taAppointMentDate, taTime, taAppointMentStatus, taExtra, taDate, taStatus);
		
		if (transaction == null)
		this.TaId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.TaId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? taTitleType, System.String taTitle, System.String taWhomeTo, System.String taReason, System.String taPriority, System.DateTime? taAppointMentDate, System.String taTime, System.String taAppointMentStatus, System.String taExtra, System.DateTime? taDate, System.Int32? taStatus)
	{
		Insert(taTitleType, taTitle, taWhomeTo, taReason, taPriority, taAppointMentDate, taTime, taAppointMentStatus, taExtra, taDate, taStatus, null);
	}
	/// <summary>
	/// Insert current TMSTodaysAppoinments to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(TATitleType, TATitle, TAWhomeTo, TAReason, TAPriority, TAAppointMentDate, TATime, TAAppointMentStatus, TAExtra, TADate, TAStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSTodaysAppoinments to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? taId, System.Int64? taTitleType, System.String taTitle, System.String taWhomeTo, System.String taReason, System.String taPriority, System.DateTime? taAppointMentDate, System.String taTime, System.String taAppointMentStatus, System.String taExtra, System.DateTime? taDate, System.Int32? taStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTodaysAppoinments_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@taId"].Value = taId;
		dbCommand.Parameters["@taTitleType"].Value = taTitleType;
		dbCommand.Parameters["@taTitle"].Value = taTitle;
		dbCommand.Parameters["@taWhomeTo"].Value = taWhomeTo;
		dbCommand.Parameters["@taReason"].Value = taReason;
		dbCommand.Parameters["@taPriority"].Value = taPriority;
		dbCommand.Parameters["@taAppointMentDate"].Value = taAppointMentDate;
		dbCommand.Parameters["@taTime"].Value = taTime;
		dbCommand.Parameters["@taAppointMentStatus"].Value = taAppointMentStatus;
		dbCommand.Parameters["@taExtra"].Value = taExtra;
		dbCommand.Parameters["@taDate"].Value = taDate;
		dbCommand.Parameters["@taStatus"].Value = taStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? taId, System.Int64? taTitleType, System.String taTitle, System.String taWhomeTo, System.String taReason, System.String taPriority, System.DateTime? taAppointMentDate, System.String taTime, System.String taAppointMentStatus, System.String taExtra, System.DateTime? taDate, System.Int32? taStatus)
	{
		Update(taId, taTitleType, taTitle, taWhomeTo, taReason, taPriority, taAppointMentDate, taTime, taAppointMentStatus, taExtra, taDate, taStatus, null);
	}
	
	public static void Update(TMSTodaysAppoinments tMSTodaysAppoinments)
	{
		tMSTodaysAppoinments.Update();
	}
	
	public static void Update(TMSTodaysAppoinments tMSTodaysAppoinments, DbTransaction transaction)
	{
		tMSTodaysAppoinments.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSTodaysAppoinments_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@taId"].SourceColumn = "TA_ID";
		dbCommand.Parameters["@taTitleType"].SourceColumn = "TA_TitleType";
		dbCommand.Parameters["@taTitle"].SourceColumn = "TA_Title";
		dbCommand.Parameters["@taWhomeTo"].SourceColumn = "TA_WhomeTo";
		dbCommand.Parameters["@taReason"].SourceColumn = "TA_Reason";
		dbCommand.Parameters["@taPriority"].SourceColumn = "TA_Priority";
		dbCommand.Parameters["@taAppointMentDate"].SourceColumn = "TA_AppointMentDate";
		dbCommand.Parameters["@taTime"].SourceColumn = "TA_Time";
		dbCommand.Parameters["@taAppointMentStatus"].SourceColumn = "TA_AppointMentStatus";
		dbCommand.Parameters["@taExtra"].SourceColumn = "TA_Extra";
		dbCommand.Parameters["@taDate"].SourceColumn = "TA_Date";
		dbCommand.Parameters["@taStatus"].SourceColumn = "TA_Status";
		
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
	public static void Delete(System.Int64? taId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTodaysAppoinments_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, taId);
		
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
	public static void Delete(System.Int64? taId)
	{
		Delete(
		taId);
	}
	
	/// <summary>
	/// Delete current TMSTodaysAppoinments from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTodaysAppoinments_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, TaId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.TaId = null;
	}
	
	/// <summary>
	/// Delete current TMSTodaysAppoinments from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTodaysAppoinments[] Search(System.Int64? taId, System.Int64? taTitleType, System.String taTitle, System.String taWhomeTo, System.String taReason, System.String taPriority, System.DateTime? taAppointMentDate, System.String taTime, System.String taAppointMentStatus, System.String taExtra, System.DateTime? taDate, System.Int32? taStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTodaysAppoinments_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, taId, taTitleType, taTitle, taWhomeTo, taReason, taPriority, taAppointMentDate, taTime, taAppointMentStatus, taExtra, taDate, taStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSTodaysAppoinments.MapFrom(ds);
	}
	
	
	public static TMSTodaysAppoinments[] Search(TMSTodaysAppoinments searchObject)
	{
		return Search ( searchObject.TaId, searchObject.TATitleType, searchObject.TATitle, searchObject.TAWhomeTo, searchObject.TAReason, searchObject.TAPriority, searchObject.TAAppointMentDate, searchObject.TATime, searchObject.TAAppointMentStatus, searchObject.TAExtra, searchObject.TADate, searchObject.TAStatus);
	}
	
	/// <summary>
	/// Returns all TMSTodaysAppoinments objects.
	/// </summary>
	/// <returns>List of all TMSTodaysAppoinments objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSTodaysAppoinments[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

