/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/30/2012 10:49:48 AM                                    */
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
public partial class TMSWorkToDo
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_WorkToDo]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _wdId;
	private System.String _wdTitle;
	private System.String _wdReason;
	private System.String _wdPriority;
	private System.DateTime? _wdWorkDate;
	private System.String _wdTime;
	private System.String _wdWorkStatus;
	private System.String _wdExtra;
	private System.DateTime? _wdDate;
	private System.Int32? _wdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? WdId
	{
		get
		{
			return _wdId;
		}
		set
		{
			_wdId = value;
		}
	}
	
	public System.String WDTitle
	{
		get
		{
			return _wdTitle;
		}
		set
		{
			_wdTitle = value;
		}
	}
	
	public System.String WDReason
	{
		get
		{
			return _wdReason;
		}
		set
		{
			_wdReason = value;
		}
	}
	
	public System.String WDPriority
	{
		get
		{
			return _wdPriority;
		}
		set
		{
			_wdPriority = value;
		}
	}
	
	public System.DateTime? WDWorkDate
	{
		get
		{
			return _wdWorkDate;
		}
		set
		{
			_wdWorkDate = value;
		}
	}
	
	public System.String WDTime
	{
		get
		{
			return _wdTime;
		}
		set
		{
			_wdTime = value;
		}
	}
	
	public System.String WDWorkStatus
	{
		get
		{
			return _wdWorkStatus;
		}
		set
		{
			_wdWorkStatus = value;
		}
	}
	
	public System.String WDExtra
	{
		get
		{
			return _wdExtra;
		}
		set
		{
			_wdExtra = value;
		}
	}
	
	public System.DateTime? WDDate
	{
		get
		{
			return _wdDate;
		}
		set
		{
			_wdDate = value;
		}
	}
	
	public System.Int32? WDStatus
	{
		get
		{
			return _wdStatus;
		}
		set
		{
			_wdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("WD_ID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_Reason", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_Priority", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_WorkDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_Time", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_WorkStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_Extra", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (WdId == null)
		dr["WD_ID"] = DBNull.Value;
		else
		dr["WD_ID"] = WdId;
		
		if (WDTitle == null)
		dr["WD_Title"] = DBNull.Value;
		else
		dr["WD_Title"] = WDTitle;
		
		if (WDReason == null)
		dr["WD_Reason"] = DBNull.Value;
		else
		dr["WD_Reason"] = WDReason;
		
		if (WDPriority == null)
		dr["WD_Priority"] = DBNull.Value;
		else
		dr["WD_Priority"] = WDPriority;
		
		if (WDWorkDate == null)
		dr["WD_WorkDate"] = DBNull.Value;
		else
		dr["WD_WorkDate"] = WDWorkDate;
		
		if (WDTime == null)
		dr["WD_Time"] = DBNull.Value;
		else
		dr["WD_Time"] = WDTime;
		
		if (WDWorkStatus == null)
		dr["WD_WorkStatus"] = DBNull.Value;
		else
		dr["WD_WorkStatus"] = WDWorkStatus;
		
		if (WDExtra == null)
		dr["WD_Extra"] = DBNull.Value;
		else
		dr["WD_Extra"] = WDExtra;
		
		if (WDDate == null)
		dr["WD_Date"] = DBNull.Value;
		else
		dr["WD_Date"] = WDDate;
		
		if (WDStatus == null)
		dr["WD_Status"] = DBNull.Value;
		else
		dr["WD_Status"] = WDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		WdId = dr["WD_ID"] != DBNull.Value ? Convert.ToInt64(dr["WD_ID"]) : WdId = null;
		WDTitle = dr["WD_Title"] != DBNull.Value ? Convert.ToString(dr["WD_Title"]) : WDTitle = null;
		WDReason = dr["WD_Reason"] != DBNull.Value ? Convert.ToString(dr["WD_Reason"]) : WDReason = null;
		WDPriority = dr["WD_Priority"] != DBNull.Value ? Convert.ToString(dr["WD_Priority"]) : WDPriority = null;
		WDWorkDate = dr["WD_WorkDate"] != DBNull.Value ? Convert.ToDateTime(dr["WD_WorkDate"]) : WDWorkDate = null;
		WDTime = dr["WD_Time"] != DBNull.Value ? Convert.ToString(dr["WD_Time"]) : WDTime = null;
		WDWorkStatus = dr["WD_WorkStatus"] != DBNull.Value ? Convert.ToString(dr["WD_WorkStatus"]) : WDWorkStatus = null;
		WDExtra = dr["WD_Extra"] != DBNull.Value ? Convert.ToString(dr["WD_Extra"]) : WDExtra = null;
		WDDate = dr["WD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["WD_Date"]) : WDDate = null;
		WDStatus = dr["WD_Status"] != DBNull.Value ? Convert.ToInt32(dr["WD_Status"]) : WDStatus = null;
	}
	
	public static TMSWorkToDo[] MapFrom(DataSet ds)
	{
		List<TMSWorkToDo> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSWorkToDo>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_WorkToDo] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_WorkToDo] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSWorkToDo instance = new TMSWorkToDo();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSWorkToDo Get(System.Int64 wdId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSWorkToDo instance;
		
		
		instance = new TMSWorkToDo();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWorkToDo_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, wdId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSWorkToDo ID:" + wdId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String wdTitle, System.String wdReason, System.String wdPriority, System.DateTime? wdWorkDate, System.String wdTime, System.String wdWorkStatus, System.String wdExtra, System.DateTime? wdDate, System.Int32? wdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWorkToDo_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, wdTitle, wdReason, wdPriority, wdWorkDate, wdTime, wdWorkStatus, wdExtra, wdDate, wdStatus);
		
		if (transaction == null)
		this.WdId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.WdId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String wdTitle, System.String wdReason, System.String wdPriority, System.DateTime? wdWorkDate, System.String wdTime, System.String wdWorkStatus, System.String wdExtra, System.DateTime? wdDate, System.Int32? wdStatus)
	{
		Insert(wdTitle, wdReason, wdPriority, wdWorkDate, wdTime, wdWorkStatus, wdExtra, wdDate, wdStatus, null);
	}
	/// <summary>
	/// Insert current TMSWorkToDo to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(WDTitle, WDReason, WDPriority, WDWorkDate, WDTime, WDWorkStatus, WDExtra, WDDate, WDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSWorkToDo to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? wdId, System.String wdTitle, System.String wdReason, System.String wdPriority, System.DateTime? wdWorkDate, System.String wdTime, System.String wdWorkStatus, System.String wdExtra, System.DateTime? wdDate, System.Int32? wdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWorkToDo_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@wdId"].Value = wdId;
		dbCommand.Parameters["@wdTitle"].Value = wdTitle;
		dbCommand.Parameters["@wdReason"].Value = wdReason;
		dbCommand.Parameters["@wdPriority"].Value = wdPriority;
		dbCommand.Parameters["@wdWorkDate"].Value = wdWorkDate;
		dbCommand.Parameters["@wdTime"].Value = wdTime;
		dbCommand.Parameters["@wdWorkStatus"].Value = wdWorkStatus;
		dbCommand.Parameters["@wdExtra"].Value = wdExtra;
		dbCommand.Parameters["@wdDate"].Value = wdDate;
		dbCommand.Parameters["@wdStatus"].Value = wdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? wdId, System.String wdTitle, System.String wdReason, System.String wdPriority, System.DateTime? wdWorkDate, System.String wdTime, System.String wdWorkStatus, System.String wdExtra, System.DateTime? wdDate, System.Int32? wdStatus)
	{
		Update(wdId, wdTitle, wdReason, wdPriority, wdWorkDate, wdTime, wdWorkStatus, wdExtra, wdDate, wdStatus, null);
	}
	
	public static void Update(TMSWorkToDo tMSWorkToDo)
	{
		tMSWorkToDo.Update();
	}
	
	public static void Update(TMSWorkToDo tMSWorkToDo, DbTransaction transaction)
	{
		tMSWorkToDo.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSWorkToDo_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@wdId"].SourceColumn = "WD_ID";
		dbCommand.Parameters["@wdTitle"].SourceColumn = "WD_Title";
		dbCommand.Parameters["@wdReason"].SourceColumn = "WD_Reason";
		dbCommand.Parameters["@wdPriority"].SourceColumn = "WD_Priority";
		dbCommand.Parameters["@wdWorkDate"].SourceColumn = "WD_WorkDate";
		dbCommand.Parameters["@wdTime"].SourceColumn = "WD_Time";
		dbCommand.Parameters["@wdWorkStatus"].SourceColumn = "WD_WorkStatus";
		dbCommand.Parameters["@wdExtra"].SourceColumn = "WD_Extra";
		dbCommand.Parameters["@wdDate"].SourceColumn = "WD_Date";
		dbCommand.Parameters["@wdStatus"].SourceColumn = "WD_Status";
		
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
	public static void Delete(System.Int64? wdId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWorkToDo_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, wdId);
		
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
	public static void Delete(System.Int64? wdId)
	{
		Delete(
		wdId);
	}
	
	/// <summary>
	/// Delete current TMSWorkToDo from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWorkToDo_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, WdId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.WdId = null;
	}
	
	/// <summary>
	/// Delete current TMSWorkToDo from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSWorkToDo[] Search(System.Int64? wdId, System.String wdTitle, System.String wdReason, System.String wdPriority, System.DateTime? wdWorkDate, System.String wdTime, System.String wdWorkStatus, System.String wdExtra, System.DateTime? wdDate, System.Int32? wdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWorkToDo_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, wdId, wdTitle, wdReason, wdPriority, wdWorkDate, wdTime, wdWorkStatus, wdExtra, wdDate, wdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSWorkToDo.MapFrom(ds);
	}
	
	
	public static TMSWorkToDo[] Search(TMSWorkToDo searchObject)
	{
		return Search ( searchObject.WdId, searchObject.WDTitle, searchObject.WDReason, searchObject.WDPriority, searchObject.WDWorkDate, searchObject.WDTime, searchObject.WDWorkStatus, searchObject.WDExtra, searchObject.WDDate, searchObject.WDStatus);
	}
	
	/// <summary>
	/// Returns all TMSWorkToDo objects.
	/// </summary>
	/// <returns>List of all TMSWorkToDo objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSWorkToDo[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

