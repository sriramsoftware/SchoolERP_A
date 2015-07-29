/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/16/2012 1:04:15 PM                                    */
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
public partial class TMSBusAssignStaffDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_BusAssignStaffDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _badAssignId;
	private System.Int64? _badBusId;
	private System.Int64? _badBusDriverId;
	private System.Int64? _badBusConductorId;
	private System.DateTime? _badDate;
	private System.Int32? _badStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? BADAssignId
	{
		get
		{
			return _badAssignId;
		}
		set
		{
			_badAssignId = value;
		}
	}
	
	public System.Int64? BADBusId
	{
		get
		{
			return _badBusId;
		}
		set
		{
			_badBusId = value;
		}
	}
	
	public System.Int64? BADBusDriverId
	{
		get
		{
			return _badBusDriverId;
		}
		set
		{
			_badBusDriverId = value;
		}
	}
	
	public System.Int64? BADBusConductorId
	{
		get
		{
			return _badBusConductorId;
		}
		set
		{
			_badBusConductorId = value;
		}
	}
	
	public System.DateTime? BADDate
	{
		get
		{
			return _badDate;
		}
		set
		{
			_badDate = value;
		}
	}
	
	public System.Int32? BADStatus
	{
		get
		{
			return _badStatus;
		}
		set
		{
			_badStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("BAD_AssignId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BAD_BusId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BAD_BusDriverId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BAD_BusConductorId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BAD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BAD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (BADAssignId == null)
		dr["BAD_AssignId"] = DBNull.Value;
		else
		dr["BAD_AssignId"] = BADAssignId;
		
		if (BADBusId == null)
		dr["BAD_BusId"] = DBNull.Value;
		else
		dr["BAD_BusId"] = BADBusId;
		
		if (BADBusDriverId == null)
		dr["BAD_BusDriverId"] = DBNull.Value;
		else
		dr["BAD_BusDriverId"] = BADBusDriverId;
		
		if (BADBusConductorId == null)
		dr["BAD_BusConductorId"] = DBNull.Value;
		else
		dr["BAD_BusConductorId"] = BADBusConductorId;
		
		if (BADDate == null)
		dr["BAD_Date"] = DBNull.Value;
		else
		dr["BAD_Date"] = BADDate;
		
		if (BADStatus == null)
		dr["BAD_Status"] = DBNull.Value;
		else
		dr["BAD_Status"] = BADStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		BADAssignId = dr["BAD_AssignId"] != DBNull.Value ? Convert.ToInt64(dr["BAD_AssignId"]) : BADAssignId = null;
		BADBusId = dr["BAD_BusId"] != DBNull.Value ? Convert.ToInt64(dr["BAD_BusId"]) : BADBusId = null;
		BADBusDriverId = dr["BAD_BusDriverId"] != DBNull.Value ? Convert.ToInt64(dr["BAD_BusDriverId"]) : BADBusDriverId = null;
		BADBusConductorId = dr["BAD_BusConductorId"] != DBNull.Value ? Convert.ToInt64(dr["BAD_BusConductorId"]) : BADBusConductorId = null;
		BADDate = dr["BAD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["BAD_Date"]) : BADDate = null;
		BADStatus = dr["BAD_Status"] != DBNull.Value ? Convert.ToInt32(dr["BAD_Status"]) : BADStatus = null;
	}
	
	public static TMSBusAssignStaffDetails[] MapFrom(DataSet ds)
	{
		List<TMSBusAssignStaffDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSBusAssignStaffDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_BusAssignStaffDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_BusAssignStaffDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSBusAssignStaffDetails instance = new TMSBusAssignStaffDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusAssignStaffDetails Get(System.Int64 badAssignId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSBusAssignStaffDetails instance;
		
		
		instance = new TMSBusAssignStaffDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusAssignStaffDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, badAssignId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSBusAssignStaffDetails ID:" + badAssignId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? badBusId, System.Int64? badBusDriverId, System.Int64? badBusConductorId, System.DateTime? badDate, System.Int32? badStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusAssignStaffDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, badBusId, badBusDriverId, badBusConductorId, badDate, badStatus);
		
		if (transaction == null)
		this.BADAssignId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.BADAssignId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? badBusId, System.Int64? badBusDriverId, System.Int64? badBusConductorId, System.DateTime? badDate, System.Int32? badStatus)
	{
		Insert(badBusId, badBusDriverId, badBusConductorId, badDate, badStatus, null);
	}
	/// <summary>
	/// Insert current TMSBusAssignStaffDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(BADBusId, BADBusDriverId, BADBusConductorId, BADDate, BADStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSBusAssignStaffDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? badAssignId, System.Int64? badBusId, System.Int64? badBusDriverId, System.Int64? badBusConductorId, System.DateTime? badDate, System.Int32? badStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusAssignStaffDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@badAssignId"].Value = badAssignId;
		dbCommand.Parameters["@badBusId"].Value = badBusId;
		dbCommand.Parameters["@badBusDriverId"].Value = badBusDriverId;
		dbCommand.Parameters["@badBusConductorId"].Value = badBusConductorId;
		dbCommand.Parameters["@badDate"].Value = badDate;
		dbCommand.Parameters["@badStatus"].Value = badStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? badAssignId, System.Int64? badBusId, System.Int64? badBusDriverId, System.Int64? badBusConductorId, System.DateTime? badDate, System.Int32? badStatus)
	{
		Update(badAssignId, badBusId, badBusDriverId, badBusConductorId, badDate, badStatus, null);
	}
	
	public static void Update(TMSBusAssignStaffDetails tMSBusAssignStaffDetails)
	{
		tMSBusAssignStaffDetails.Update();
	}
	
	public static void Update(TMSBusAssignStaffDetails tMSBusAssignStaffDetails, DbTransaction transaction)
	{
		tMSBusAssignStaffDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSBusAssignStaffDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@badAssignId"].SourceColumn = "BAD_AssignId";
		dbCommand.Parameters["@badBusId"].SourceColumn = "BAD_BusId";
		dbCommand.Parameters["@badBusDriverId"].SourceColumn = "BAD_BusDriverId";
		dbCommand.Parameters["@badBusConductorId"].SourceColumn = "BAD_BusConductorId";
		dbCommand.Parameters["@badDate"].SourceColumn = "BAD_Date";
		dbCommand.Parameters["@badStatus"].SourceColumn = "BAD_Status";
		
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
	public static void Delete(System.Int64? badAssignId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusAssignStaffDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, badAssignId);
		
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
	public static void Delete(System.Int64? badAssignId)
	{
		Delete(
		badAssignId);
	}
	
	/// <summary>
	/// Delete current TMSBusAssignStaffDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusAssignStaffDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, BADAssignId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.BADAssignId = null;
	}
	
	/// <summary>
	/// Delete current TMSBusAssignStaffDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusAssignStaffDetails[] Search(System.Int64? badAssignId, System.Int64? badBusId, System.Int64? badBusDriverId, System.Int64? badBusConductorId, System.DateTime? badDate, System.Int32? badStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusAssignStaffDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, badAssignId, badBusId, badBusDriverId, badBusConductorId, badDate, badStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSBusAssignStaffDetails.MapFrom(ds);
	}
	
	
	public static TMSBusAssignStaffDetails[] Search(TMSBusAssignStaffDetails searchObject)
	{
		return Search ( searchObject.BADAssignId, searchObject.BADBusId, searchObject.BADBusDriverId, searchObject.BADBusConductorId, searchObject.BADDate, searchObject.BADStatus);
	}
	
	/// <summary>
	/// Returns all TMSBusAssignStaffDetails objects.
	/// </summary>
	/// <returns>List of all TMSBusAssignStaffDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSBusAssignStaffDetails[] Search()
	{
		return Search ( null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

