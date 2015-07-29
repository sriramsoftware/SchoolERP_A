/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 9/4/2012 12:31:56 PM                                    */
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
public partial class TMSExtraActivity
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ExtraActivity]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _exActivityID;
	private System.Int64? _exActyvityType;
	private System.String _exActivity;
	private System.String _exAddedBy;
	private System.DateTime? _exDate;
	private System.Int32? _exStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ExActivityID
	{
		get
		{
			return _exActivityID;
		}
		set
		{
			_exActivityID = value;
		}
	}
	
	public System.Int64? EXActyvityType
	{
		get
		{
			return _exActyvityType;
		}
		set
		{
			_exActyvityType = value;
		}
	}
	
	public System.String EXActivity
	{
		get
		{
			return _exActivity;
		}
		set
		{
			_exActivity = value;
		}
	}
	
	public System.String EXAddedBy
	{
		get
		{
			return _exAddedBy;
		}
		set
		{
			_exAddedBy = value;
		}
	}
	
	public System.DateTime? EXDate
	{
		get
		{
			return _exDate;
		}
		set
		{
			_exDate = value;
		}
	}
	
	public System.Int32? EXStatus
	{
		get
		{
			return _exStatus;
		}
		set
		{
			_exStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("Ex_ActivityID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EX_ActyvityType", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EX_Activity", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EX_AddedBy", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EX_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("EX_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ExActivityID == null)
		dr["Ex_ActivityID"] = DBNull.Value;
		else
		dr["Ex_ActivityID"] = ExActivityID;
		
		if (EXActyvityType == null)
		dr["EX_ActyvityType"] = DBNull.Value;
		else
		dr["EX_ActyvityType"] = EXActyvityType;
		
		if (EXActivity == null)
		dr["EX_Activity"] = DBNull.Value;
		else
		dr["EX_Activity"] = EXActivity;
		
		if (EXAddedBy == null)
		dr["EX_AddedBy"] = DBNull.Value;
		else
		dr["EX_AddedBy"] = EXAddedBy;
		
		if (EXDate == null)
		dr["EX_Date"] = DBNull.Value;
		else
		dr["EX_Date"] = EXDate;
		
		if (EXStatus == null)
		dr["EX_Status"] = DBNull.Value;
		else
		dr["EX_Status"] = EXStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ExActivityID = dr["Ex_ActivityID"] != DBNull.Value ? Convert.ToInt64(dr["Ex_ActivityID"]) : ExActivityID = null;
		EXActyvityType = dr["EX_ActyvityType"] != DBNull.Value ? Convert.ToInt64(dr["EX_ActyvityType"]) : EXActyvityType = null;
		EXActivity = dr["EX_Activity"] != DBNull.Value ? Convert.ToString(dr["EX_Activity"]) : EXActivity = null;
		EXAddedBy = dr["EX_AddedBy"] != DBNull.Value ? Convert.ToString(dr["EX_AddedBy"]) : EXAddedBy = null;
		EXDate = dr["EX_Date"] != DBNull.Value ? Convert.ToDateTime(dr["EX_Date"]) : EXDate = null;
		EXStatus = dr["EX_Status"] != DBNull.Value ? Convert.ToInt32(dr["EX_Status"]) : EXStatus = null;
	}
	
	public static TMSExtraActivity[] MapFrom(DataSet ds)
	{
		List<TMSExtraActivity> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSExtraActivity>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ExtraActivity] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ExtraActivity] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSExtraActivity instance = new TMSExtraActivity();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSExtraActivity Get(System.Int64 exActivityID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSExtraActivity instance;
		
		
		instance = new TMSExtraActivity();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivity_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, exActivityID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSExtraActivity ID:" + exActivityID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? exActyvityType, System.String exActivity, System.String exAddedBy, System.DateTime? exDate, System.Int32? exStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivity_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, exActyvityType, exActivity, exAddedBy, exDate, exStatus);
		
		if (transaction == null)
		this.ExActivityID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ExActivityID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? exActyvityType, System.String exActivity, System.String exAddedBy, System.DateTime? exDate, System.Int32? exStatus)
	{
		Insert(exActyvityType, exActivity, exAddedBy, exDate, exStatus, null);
	}
	/// <summary>
	/// Insert current TMSExtraActivity to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(EXActyvityType, EXActivity, EXAddedBy, EXDate, EXStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSExtraActivity to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? exActivityID, System.Int64? exActyvityType, System.String exActivity, System.String exAddedBy, System.DateTime? exDate, System.Int32? exStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivity_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@exActivityID"].Value = exActivityID;
		dbCommand.Parameters["@exActyvityType"].Value = exActyvityType;
		dbCommand.Parameters["@exActivity"].Value = exActivity;
		dbCommand.Parameters["@exAddedBy"].Value = exAddedBy;
		dbCommand.Parameters["@exDate"].Value = exDate;
		dbCommand.Parameters["@exStatus"].Value = exStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? exActivityID, System.Int64? exActyvityType, System.String exActivity, System.String exAddedBy, System.DateTime? exDate, System.Int32? exStatus)
	{
		Update(exActivityID, exActyvityType, exActivity, exAddedBy, exDate, exStatus, null);
	}
	
	public static void Update(TMSExtraActivity tMSExtraActivity)
	{
		tMSExtraActivity.Update();
	}
	
	public static void Update(TMSExtraActivity tMSExtraActivity, DbTransaction transaction)
	{
		tMSExtraActivity.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSExtraActivity_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@exActivityID"].SourceColumn = "Ex_ActivityID";
		dbCommand.Parameters["@exActyvityType"].SourceColumn = "EX_ActyvityType";
		dbCommand.Parameters["@exActivity"].SourceColumn = "EX_Activity";
		dbCommand.Parameters["@exAddedBy"].SourceColumn = "EX_AddedBy";
		dbCommand.Parameters["@exDate"].SourceColumn = "EX_Date";
		dbCommand.Parameters["@exStatus"].SourceColumn = "EX_Status";
		
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
	public static void Delete(System.Int64? exActivityID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivity_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, exActivityID);
		
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
	public static void Delete(System.Int64? exActivityID)
	{
		Delete(
		exActivityID);
	}
	
	/// <summary>
	/// Delete current TMSExtraActivity from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivity_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ExActivityID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ExActivityID = null;
	}
	
	/// <summary>
	/// Delete current TMSExtraActivity from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSExtraActivity[] Search(System.Int64? exActivityID, System.Int64? exActyvityType, System.String exActivity, System.String exAddedBy, System.DateTime? exDate, System.Int32? exStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivity_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, exActivityID, exActyvityType, exActivity, exAddedBy, exDate, exStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSExtraActivity.MapFrom(ds);
	}
	
	
	public static TMSExtraActivity[] Search(TMSExtraActivity searchObject)
	{
		return Search ( searchObject.ExActivityID, searchObject.EXActyvityType, searchObject.EXActivity, searchObject.EXAddedBy, searchObject.EXDate, searchObject.EXStatus);
	}
	
	/// <summary>
	/// Returns all TMSExtraActivity objects.
	/// </summary>
	/// <returns>List of all TMSExtraActivity objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSExtraActivity[] Search()
	{
		return Search ( null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

