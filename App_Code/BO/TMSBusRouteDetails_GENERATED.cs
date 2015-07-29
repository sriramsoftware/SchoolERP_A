/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/19/2012 12:17:14 PM                                    */
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
public partial class TMSBusRouteDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_BusRouteDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _brRouteId;
	private System.Int64? _brBusId;
	private System.String _brStartRoute;
	private System.String _brEndRoute;
	private System.String _brArrivalTime;
	private System.String _brDepartureTime;
	private System.String _brHalt;
	private System.String _brKm;
	private System.String _brMapImage;
	private System.DateTime? _brDate;
	private System.Int32? _brStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? BRRouteId
	{
		get
		{
			return _brRouteId;
		}
		set
		{
			_brRouteId = value;
		}
	}
	
	public System.Int64? BRBusId
	{
		get
		{
			return _brBusId;
		}
		set
		{
			_brBusId = value;
		}
	}
	
	public System.String BRStartRoute
	{
		get
		{
			return _brStartRoute;
		}
		set
		{
			_brStartRoute = value;
		}
	}
	
	public System.String BREndRoute
	{
		get
		{
			return _brEndRoute;
		}
		set
		{
			_brEndRoute = value;
		}
	}
	
	public System.String BRArrivalTime
	{
		get
		{
			return _brArrivalTime;
		}
		set
		{
			_brArrivalTime = value;
		}
	}
	
	public System.String BRDepartureTime
	{
		get
		{
			return _brDepartureTime;
		}
		set
		{
			_brDepartureTime = value;
		}
	}
	
	public System.String BRHalt
	{
		get
		{
			return _brHalt;
		}
		set
		{
			_brHalt = value;
		}
	}
	
	public System.String BrKm
	{
		get
		{
			return _brKm;
		}
		set
		{
			_brKm = value;
		}
	}
	
	public System.String BRMapImage
	{
		get
		{
			return _brMapImage;
		}
		set
		{
			_brMapImage = value;
		}
	}
	
	public System.DateTime? BRDate
	{
		get
		{
			return _brDate;
		}
		set
		{
			_brDate = value;
		}
	}
	
	public System.Int32? BRStatus
	{
		get
		{
			return _brStatus;
		}
		set
		{
			_brStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("BR_RouteId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BR_BusId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BR_StartRoute", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BR_EndRoute", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BR_ArrivalTime", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BR_DepartureTime", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BR_Halt", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BR_KM", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BR_MapImage", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BR_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BR_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (BRRouteId == null)
		dr["BR_RouteId"] = DBNull.Value;
		else
		dr["BR_RouteId"] = BRRouteId;
		
		if (BRBusId == null)
		dr["BR_BusId"] = DBNull.Value;
		else
		dr["BR_BusId"] = BRBusId;
		
		if (BRStartRoute == null)
		dr["BR_StartRoute"] = DBNull.Value;
		else
		dr["BR_StartRoute"] = BRStartRoute;
		
		if (BREndRoute == null)
		dr["BR_EndRoute"] = DBNull.Value;
		else
		dr["BR_EndRoute"] = BREndRoute;
		
		if (BRArrivalTime == null)
		dr["BR_ArrivalTime"] = DBNull.Value;
		else
		dr["BR_ArrivalTime"] = BRArrivalTime;
		
		if (BRDepartureTime == null)
		dr["BR_DepartureTime"] = DBNull.Value;
		else
		dr["BR_DepartureTime"] = BRDepartureTime;
		
		if (BRHalt == null)
		dr["BR_Halt"] = DBNull.Value;
		else
		dr["BR_Halt"] = BRHalt;
		
		if (BrKm == null)
		dr["BR_KM"] = DBNull.Value;
		else
		dr["BR_KM"] = BrKm;
		
		if (BRMapImage == null)
		dr["BR_MapImage"] = DBNull.Value;
		else
		dr["BR_MapImage"] = BRMapImage;
		
		if (BRDate == null)
		dr["BR_Date"] = DBNull.Value;
		else
		dr["BR_Date"] = BRDate;
		
		if (BRStatus == null)
		dr["BR_Status"] = DBNull.Value;
		else
		dr["BR_Status"] = BRStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		BRRouteId = dr["BR_RouteId"] != DBNull.Value ? Convert.ToInt64(dr["BR_RouteId"]) : BRRouteId = null;
		BRBusId = dr["BR_BusId"] != DBNull.Value ? Convert.ToInt64(dr["BR_BusId"]) : BRBusId = null;
		BRStartRoute = dr["BR_StartRoute"] != DBNull.Value ? Convert.ToString(dr["BR_StartRoute"]) : BRStartRoute = null;
		BREndRoute = dr["BR_EndRoute"] != DBNull.Value ? Convert.ToString(dr["BR_EndRoute"]) : BREndRoute = null;
		BRArrivalTime = dr["BR_ArrivalTime"] != DBNull.Value ? Convert.ToString(dr["BR_ArrivalTime"]) : BRArrivalTime = null;
		BRDepartureTime = dr["BR_DepartureTime"] != DBNull.Value ? Convert.ToString(dr["BR_DepartureTime"]) : BRDepartureTime = null;
		BRHalt = dr["BR_Halt"] != DBNull.Value ? Convert.ToString(dr["BR_Halt"]) : BRHalt = null;
		BrKm = dr["BR_KM"] != DBNull.Value ? Convert.ToString(dr["BR_KM"]) : BrKm = null;
		BRMapImage = dr["BR_MapImage"] != DBNull.Value ? Convert.ToString(dr["BR_MapImage"]) : BRMapImage = null;
		BRDate = dr["BR_Date"] != DBNull.Value ? Convert.ToDateTime(dr["BR_Date"]) : BRDate = null;
		BRStatus = dr["BR_Status"] != DBNull.Value ? Convert.ToInt32(dr["BR_Status"]) : BRStatus = null;
	}
	
	public static TMSBusRouteDetails[] MapFrom(DataSet ds)
	{
		List<TMSBusRouteDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSBusRouteDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_BusRouteDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_BusRouteDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSBusRouteDetails instance = new TMSBusRouteDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusRouteDetails Get(System.Int64 brRouteId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSBusRouteDetails instance;
		
		
		instance = new TMSBusRouteDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusRouteDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, brRouteId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSBusRouteDetails ID:" + brRouteId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? brBusId, System.String brStartRoute, System.String brEndRoute, System.String brArrivalTime, System.String brDepartureTime, System.String brHalt, System.String brKm, System.String brMapImage, System.DateTime? brDate, System.Int32? brStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusRouteDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, brBusId, brStartRoute, brEndRoute, brArrivalTime, brDepartureTime, brHalt, brKm, brMapImage, brDate, brStatus);
		
		if (transaction == null)
		this.BRRouteId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.BRRouteId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? brBusId, System.String brStartRoute, System.String brEndRoute, System.String brArrivalTime, System.String brDepartureTime, System.String brHalt, System.String brKm, System.String brMapImage, System.DateTime? brDate, System.Int32? brStatus)
	{
		Insert(brBusId, brStartRoute, brEndRoute, brArrivalTime, brDepartureTime, brHalt, brKm, brMapImage, brDate, brStatus, null);
	}
	/// <summary>
	/// Insert current TMSBusRouteDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(BRBusId, BRStartRoute, BREndRoute, BRArrivalTime, BRDepartureTime, BRHalt, BrKm, BRMapImage, BRDate, BRStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSBusRouteDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? brRouteId, System.Int64? brBusId, System.String brStartRoute, System.String brEndRoute, System.String brArrivalTime, System.String brDepartureTime, System.String brHalt, System.String brKm, System.String brMapImage, System.DateTime? brDate, System.Int32? brStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusRouteDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@brRouteId"].Value = brRouteId;
		dbCommand.Parameters["@brBusId"].Value = brBusId;
		dbCommand.Parameters["@brStartRoute"].Value = brStartRoute;
		dbCommand.Parameters["@brEndRoute"].Value = brEndRoute;
		dbCommand.Parameters["@brArrivalTime"].Value = brArrivalTime;
		dbCommand.Parameters["@brDepartureTime"].Value = brDepartureTime;
		dbCommand.Parameters["@brHalt"].Value = brHalt;
		dbCommand.Parameters["@brKm"].Value = brKm;
		dbCommand.Parameters["@brMapImage"].Value = brMapImage;
		dbCommand.Parameters["@brDate"].Value = brDate;
		dbCommand.Parameters["@brStatus"].Value = brStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? brRouteId, System.Int64? brBusId, System.String brStartRoute, System.String brEndRoute, System.String brArrivalTime, System.String brDepartureTime, System.String brHalt, System.String brKm, System.String brMapImage, System.DateTime? brDate, System.Int32? brStatus)
	{
		Update(brRouteId, brBusId, brStartRoute, brEndRoute, brArrivalTime, brDepartureTime, brHalt, brKm, brMapImage, brDate, brStatus, null);
	}
	
	public static void Update(TMSBusRouteDetails tMSBusRouteDetails)
	{
		tMSBusRouteDetails.Update();
	}
	
	public static void Update(TMSBusRouteDetails tMSBusRouteDetails, DbTransaction transaction)
	{
		tMSBusRouteDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSBusRouteDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@brRouteId"].SourceColumn = "BR_RouteId";
		dbCommand.Parameters["@brBusId"].SourceColumn = "BR_BusId";
		dbCommand.Parameters["@brStartRoute"].SourceColumn = "BR_StartRoute";
		dbCommand.Parameters["@brEndRoute"].SourceColumn = "BR_EndRoute";
		dbCommand.Parameters["@brArrivalTime"].SourceColumn = "BR_ArrivalTime";
		dbCommand.Parameters["@brDepartureTime"].SourceColumn = "BR_DepartureTime";
		dbCommand.Parameters["@brHalt"].SourceColumn = "BR_Halt";
		dbCommand.Parameters["@brKm"].SourceColumn = "BR_KM";
		dbCommand.Parameters["@brMapImage"].SourceColumn = "BR_MapImage";
		dbCommand.Parameters["@brDate"].SourceColumn = "BR_Date";
		dbCommand.Parameters["@brStatus"].SourceColumn = "BR_Status";
		
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
	public static void Delete(System.Int64? brRouteId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusRouteDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, brRouteId);
		
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
	public static void Delete(System.Int64? brRouteId)
	{
		Delete(
		brRouteId);
	}
	
	/// <summary>
	/// Delete current TMSBusRouteDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusRouteDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, BRRouteId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.BRRouteId = null;
	}
	
	/// <summary>
	/// Delete current TMSBusRouteDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusRouteDetails[] Search(System.Int64? brRouteId, System.Int64? brBusId, System.String brStartRoute, System.String brEndRoute, System.String brArrivalTime, System.String brDepartureTime, System.String brHalt, System.String brKm, System.String brMapImage, System.DateTime? brDate, System.Int32? brStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusRouteDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, brRouteId, brBusId, brStartRoute, brEndRoute, brArrivalTime, brDepartureTime, brHalt, brKm, brMapImage, brDate, brStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSBusRouteDetails.MapFrom(ds);
	}
	
	
	public static TMSBusRouteDetails[] Search(TMSBusRouteDetails searchObject)
	{
		return Search ( searchObject.BRRouteId, searchObject.BRBusId, searchObject.BRStartRoute, searchObject.BREndRoute, searchObject.BRArrivalTime, searchObject.BRDepartureTime, searchObject.BRHalt, searchObject.BrKm, searchObject.BRMapImage, searchObject.BRDate, searchObject.BRStatus);
	}
	
	/// <summary>
	/// Returns all TMSBusRouteDetails objects.
	/// </summary>
	/// <returns>List of all TMSBusRouteDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSBusRouteDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

