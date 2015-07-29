/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/16/2012 5:07:42 PM                                    */
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
public partial class TMSBusRouteStopDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_BusRouteStopDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _brsdStopId;
	private System.Int64? _brsdBusId;
	private System.Int64? _brsdRouteId;
	private System.String _brsdStopName;
	private System.String _brsdArrivalTime;
	private System.String _brsdDepartureTime;
	private System.String _brsdHalt;
	private System.String _brsdKm;
	private System.DateTime? _brsdDate;
	private System.Int32? _brsdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? BRSDStopId
	{
		get
		{
			return _brsdStopId;
		}
		set
		{
			_brsdStopId = value;
		}
	}
	
	public System.Int64? BRSDBusId
	{
		get
		{
			return _brsdBusId;
		}
		set
		{
			_brsdBusId = value;
		}
	}
	
	public System.Int64? BRSDRouteId
	{
		get
		{
			return _brsdRouteId;
		}
		set
		{
			_brsdRouteId = value;
		}
	}
	
	public System.String BRSDStopName
	{
		get
		{
			return _brsdStopName;
		}
		set
		{
			_brsdStopName = value;
		}
	}
	
	public System.String BRSDArrivalTime
	{
		get
		{
			return _brsdArrivalTime;
		}
		set
		{
			_brsdArrivalTime = value;
		}
	}
	
	public System.String BRSDDepartureTime
	{
		get
		{
			return _brsdDepartureTime;
		}
		set
		{
			_brsdDepartureTime = value;
		}
	}
	
	public System.String BRSDHalt
	{
		get
		{
			return _brsdHalt;
		}
		set
		{
			_brsdHalt = value;
		}
	}
	
	public System.String BrsdKm
	{
		get
		{
			return _brsdKm;
		}
		set
		{
			_brsdKm = value;
		}
	}
	
	public System.DateTime? BRSDDate
	{
		get
		{
			return _brsdDate;
		}
		set
		{
			_brsdDate = value;
		}
	}
	
	public System.Int32? BRSDStatus
	{
		get
		{
			return _brsdStatus;
		}
		set
		{
			_brsdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("BRSD_StopId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BRSD_BusId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BRSD_RouteId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BRSD_StopName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BRSD_ArrivalTime", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BRSD_DepartureTime", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BRSD_Halt", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BRSD_KM", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BRSD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BRSD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (BRSDStopId == null)
		dr["BRSD_StopId"] = DBNull.Value;
		else
		dr["BRSD_StopId"] = BRSDStopId;
		
		if (BRSDBusId == null)
		dr["BRSD_BusId"] = DBNull.Value;
		else
		dr["BRSD_BusId"] = BRSDBusId;
		
		if (BRSDRouteId == null)
		dr["BRSD_RouteId"] = DBNull.Value;
		else
		dr["BRSD_RouteId"] = BRSDRouteId;
		
		if (BRSDStopName == null)
		dr["BRSD_StopName"] = DBNull.Value;
		else
		dr["BRSD_StopName"] = BRSDStopName;
		
		if (BRSDArrivalTime == null)
		dr["BRSD_ArrivalTime"] = DBNull.Value;
		else
		dr["BRSD_ArrivalTime"] = BRSDArrivalTime;
		
		if (BRSDDepartureTime == null)
		dr["BRSD_DepartureTime"] = DBNull.Value;
		else
		dr["BRSD_DepartureTime"] = BRSDDepartureTime;
		
		if (BRSDHalt == null)
		dr["BRSD_Halt"] = DBNull.Value;
		else
		dr["BRSD_Halt"] = BRSDHalt;
		
		if (BrsdKm == null)
		dr["BRSD_KM"] = DBNull.Value;
		else
		dr["BRSD_KM"] = BrsdKm;
		
		if (BRSDDate == null)
		dr["BRSD_Date"] = DBNull.Value;
		else
		dr["BRSD_Date"] = BRSDDate;
		
		if (BRSDStatus == null)
		dr["BRSD_Status"] = DBNull.Value;
		else
		dr["BRSD_Status"] = BRSDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		BRSDStopId = dr["BRSD_StopId"] != DBNull.Value ? Convert.ToInt64(dr["BRSD_StopId"]) : BRSDStopId = null;
		BRSDBusId = dr["BRSD_BusId"] != DBNull.Value ? Convert.ToInt64(dr["BRSD_BusId"]) : BRSDBusId = null;
		BRSDRouteId = dr["BRSD_RouteId"] != DBNull.Value ? Convert.ToInt64(dr["BRSD_RouteId"]) : BRSDRouteId = null;
		BRSDStopName = dr["BRSD_StopName"] != DBNull.Value ? Convert.ToString(dr["BRSD_StopName"]) : BRSDStopName = null;
		BRSDArrivalTime = dr["BRSD_ArrivalTime"] != DBNull.Value ? Convert.ToString(dr["BRSD_ArrivalTime"]) : BRSDArrivalTime = null;
		BRSDDepartureTime = dr["BRSD_DepartureTime"] != DBNull.Value ? Convert.ToString(dr["BRSD_DepartureTime"]) : BRSDDepartureTime = null;
		BRSDHalt = dr["BRSD_Halt"] != DBNull.Value ? Convert.ToString(dr["BRSD_Halt"]) : BRSDHalt = null;
		BrsdKm = dr["BRSD_KM"] != DBNull.Value ? Convert.ToString(dr["BRSD_KM"]) : BrsdKm = null;
		BRSDDate = dr["BRSD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["BRSD_Date"]) : BRSDDate = null;
		BRSDStatus = dr["BRSD_Status"] != DBNull.Value ? Convert.ToInt32(dr["BRSD_Status"]) : BRSDStatus = null;
	}
	
	public static TMSBusRouteStopDetails[] MapFrom(DataSet ds)
	{
		List<TMSBusRouteStopDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSBusRouteStopDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_BusRouteStopDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_BusRouteStopDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSBusRouteStopDetails instance = new TMSBusRouteStopDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusRouteStopDetails Get(System.Int64 brsdStopId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSBusRouteStopDetails instance;
		
		
		instance = new TMSBusRouteStopDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusRouteStopDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, brsdStopId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSBusRouteStopDetails ID:" + brsdStopId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? brsdBusId, System.Int64? brsdRouteId, System.String brsdStopName, System.String brsdArrivalTime, System.String brsdDepartureTime, System.String brsdHalt, System.String brsdKm, System.DateTime? brsdDate, System.Int32? brsdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusRouteStopDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, brsdBusId, brsdRouteId, brsdStopName, brsdArrivalTime, brsdDepartureTime, brsdHalt, brsdKm, brsdDate, brsdStatus);
		
		if (transaction == null)
		this.BRSDStopId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.BRSDStopId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? brsdBusId, System.Int64? brsdRouteId, System.String brsdStopName, System.String brsdArrivalTime, System.String brsdDepartureTime, System.String brsdHalt, System.String brsdKm, System.DateTime? brsdDate, System.Int32? brsdStatus)
	{
		Insert(brsdBusId, brsdRouteId, brsdStopName, brsdArrivalTime, brsdDepartureTime, brsdHalt, brsdKm, brsdDate, brsdStatus, null);
	}
	/// <summary>
	/// Insert current TMSBusRouteStopDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(BRSDBusId, BRSDRouteId, BRSDStopName, BRSDArrivalTime, BRSDDepartureTime, BRSDHalt, BrsdKm, BRSDDate, BRSDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSBusRouteStopDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? brsdStopId, System.Int64? brsdBusId, System.Int64? brsdRouteId, System.String brsdStopName, System.String brsdArrivalTime, System.String brsdDepartureTime, System.String brsdHalt, System.String brsdKm, System.DateTime? brsdDate, System.Int32? brsdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusRouteStopDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@brsdStopId"].Value = brsdStopId;
		dbCommand.Parameters["@brsdBusId"].Value = brsdBusId;
		dbCommand.Parameters["@brsdRouteId"].Value = brsdRouteId;
		dbCommand.Parameters["@brsdStopName"].Value = brsdStopName;
		dbCommand.Parameters["@brsdArrivalTime"].Value = brsdArrivalTime;
		dbCommand.Parameters["@brsdDepartureTime"].Value = brsdDepartureTime;
		dbCommand.Parameters["@brsdHalt"].Value = brsdHalt;
		dbCommand.Parameters["@brsdKm"].Value = brsdKm;
		dbCommand.Parameters["@brsdDate"].Value = brsdDate;
		dbCommand.Parameters["@brsdStatus"].Value = brsdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? brsdStopId, System.Int64? brsdBusId, System.Int64? brsdRouteId, System.String brsdStopName, System.String brsdArrivalTime, System.String brsdDepartureTime, System.String brsdHalt, System.String brsdKm, System.DateTime? brsdDate, System.Int32? brsdStatus)
	{
		Update(brsdStopId, brsdBusId, brsdRouteId, brsdStopName, brsdArrivalTime, brsdDepartureTime, brsdHalt, brsdKm, brsdDate, brsdStatus, null);
	}
	
	public static void Update(TMSBusRouteStopDetails tMSBusRouteStopDetails)
	{
		tMSBusRouteStopDetails.Update();
	}
	
	public static void Update(TMSBusRouteStopDetails tMSBusRouteStopDetails, DbTransaction transaction)
	{
		tMSBusRouteStopDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSBusRouteStopDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@brsdStopId"].SourceColumn = "BRSD_StopId";
		dbCommand.Parameters["@brsdBusId"].SourceColumn = "BRSD_BusId";
		dbCommand.Parameters["@brsdRouteId"].SourceColumn = "BRSD_RouteId";
		dbCommand.Parameters["@brsdStopName"].SourceColumn = "BRSD_StopName";
		dbCommand.Parameters["@brsdArrivalTime"].SourceColumn = "BRSD_ArrivalTime";
		dbCommand.Parameters["@brsdDepartureTime"].SourceColumn = "BRSD_DepartureTime";
		dbCommand.Parameters["@brsdHalt"].SourceColumn = "BRSD_Halt";
		dbCommand.Parameters["@brsdKm"].SourceColumn = "BRSD_KM";
		dbCommand.Parameters["@brsdDate"].SourceColumn = "BRSD_Date";
		dbCommand.Parameters["@brsdStatus"].SourceColumn = "BRSD_Status";
		
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
	public static void Delete(System.Int64? brsdStopId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusRouteStopDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, brsdStopId);
		
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
	public static void Delete(System.Int64? brsdStopId)
	{
		Delete(
		brsdStopId);
	}
	
	/// <summary>
	/// Delete current TMSBusRouteStopDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusRouteStopDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, BRSDStopId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.BRSDStopId = null;
	}
	
	/// <summary>
	/// Delete current TMSBusRouteStopDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusRouteStopDetails[] Search(System.Int64? brsdStopId, System.Int64? brsdBusId, System.Int64? brsdRouteId, System.String brsdStopName, System.String brsdArrivalTime, System.String brsdDepartureTime, System.String brsdHalt, System.String brsdKm, System.DateTime? brsdDate, System.Int32? brsdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusRouteStopDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, brsdStopId, brsdBusId, brsdRouteId, brsdStopName, brsdArrivalTime, brsdDepartureTime, brsdHalt, brsdKm, brsdDate, brsdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSBusRouteStopDetails.MapFrom(ds);
	}
	
	
	public static TMSBusRouteStopDetails[] Search(TMSBusRouteStopDetails searchObject)
	{
		return Search ( searchObject.BRSDStopId, searchObject.BRSDBusId, searchObject.BRSDRouteId, searchObject.BRSDStopName, searchObject.BRSDArrivalTime, searchObject.BRSDDepartureTime, searchObject.BRSDHalt, searchObject.BrsdKm, searchObject.BRSDDate, searchObject.BRSDStatus);
	}
	
	/// <summary>
	/// Returns all TMSBusRouteStopDetails objects.
	/// </summary>
	/// <returns>List of all TMSBusRouteStopDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSBusRouteStopDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

