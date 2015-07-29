/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/30/2012 12:31:20 PM                                    */
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
public partial class TMSBusDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_BusDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _bdBusDetailsId;
	private System.String _bdBusId;
	private System.String _bdBusType;
	private System.Int64? _bdTransportManagerID;
	private System.String _bdBusName;
	private System.String _bdBusNumber;
	private System.String _bdTotalNoOfSeats;
	private System.String _bdBusKMTravels;
	private System.String _bdMiledge;
	private System.String _bdCost;
	private System.String _bdMonthlyMaintanceCost;
	private System.String _bdFuel;
	private System.String _bdServicing;
	private System.String _bdOtherBusParts;
	private System.String _bdCostNeeded;
	private System.String _bdTransport;
	private System.String _bdDescription;
	private System.String _bdVia;
	private System.String _bdPrbFacing;
	private System.String _bdAddedBy;
	private System.DateTime? _bdDate;
	private System.Int32? _bdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? BDBusDetailsId
	{
		get
		{
			return _bdBusDetailsId;
		}
		set
		{
			_bdBusDetailsId = value;
		}
	}
	
	public System.String BDBusId
	{
		get
		{
			return _bdBusId;
		}
		set
		{
			_bdBusId = value;
		}
	}
	
	public System.String BDBusType
	{
		get
		{
			return _bdBusType;
		}
		set
		{
			_bdBusType = value;
		}
	}
	
	public System.Int64? BDTransportManagerID
	{
		get
		{
			return _bdTransportManagerID;
		}
		set
		{
			_bdTransportManagerID = value;
		}
	}
	
	public System.String BDBusName
	{
		get
		{
			return _bdBusName;
		}
		set
		{
			_bdBusName = value;
		}
	}
	
	public System.String BDBusNumber
	{
		get
		{
			return _bdBusNumber;
		}
		set
		{
			_bdBusNumber = value;
		}
	}
	
	public System.String BDTotalNoOfSeats
	{
		get
		{
			return _bdTotalNoOfSeats;
		}
		set
		{
			_bdTotalNoOfSeats = value;
		}
	}
	
	public System.String BDBusKMTravels
	{
		get
		{
			return _bdBusKMTravels;
		}
		set
		{
			_bdBusKMTravels = value;
		}
	}
	
	public System.String BDMiledge
	{
		get
		{
			return _bdMiledge;
		}
		set
		{
			_bdMiledge = value;
		}
	}
	
	public System.String BDCost
	{
		get
		{
			return _bdCost;
		}
		set
		{
			_bdCost = value;
		}
	}
	
	public System.String BDMonthlyMaintanceCost
	{
		get
		{
			return _bdMonthlyMaintanceCost;
		}
		set
		{
			_bdMonthlyMaintanceCost = value;
		}
	}
	
	public System.String BDFuel
	{
		get
		{
			return _bdFuel;
		}
		set
		{
			_bdFuel = value;
		}
	}
	
	public System.String BDServicing
	{
		get
		{
			return _bdServicing;
		}
		set
		{
			_bdServicing = value;
		}
	}
	
	public System.String BDOtherBusParts
	{
		get
		{
			return _bdOtherBusParts;
		}
		set
		{
			_bdOtherBusParts = value;
		}
	}
	
	public System.String BDCostNeeded
	{
		get
		{
			return _bdCostNeeded;
		}
		set
		{
			_bdCostNeeded = value;
		}
	}
	
	public System.String BDTransport
	{
		get
		{
			return _bdTransport;
		}
		set
		{
			_bdTransport = value;
		}
	}
	
	public System.String BDDescription
	{
		get
		{
			return _bdDescription;
		}
		set
		{
			_bdDescription = value;
		}
	}
	
	public System.String BDVia
	{
		get
		{
			return _bdVia;
		}
		set
		{
			_bdVia = value;
		}
	}
	
	public System.String BDPrbFacing
	{
		get
		{
			return _bdPrbFacing;
		}
		set
		{
			_bdPrbFacing = value;
		}
	}
	
	public System.String BDAddedBy
	{
		get
		{
			return _bdAddedBy;
		}
		set
		{
			_bdAddedBy = value;
		}
	}
	
	public System.DateTime? BDDate
	{
		get
		{
			return _bdDate;
		}
		set
		{
			_bdDate = value;
		}
	}
	
	public System.Int32? BDStatus
	{
		get
		{
			return _bdStatus;
		}
		set
		{
			_bdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("BD_BusDetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_BusId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_BusType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_TransportManagerID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_BusName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_BusNumber", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_TotalNoOfSeats", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_BusKMTravels", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Miledge", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Cost", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_MonthlyMaintanceCost", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Fuel", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Servicing", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_OtherBusParts", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_CostNeeded", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Transport", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Via", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_PrbFacing", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_AddedBy", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (BDBusDetailsId == null)
		dr["BD_BusDetailsId"] = DBNull.Value;
		else
		dr["BD_BusDetailsId"] = BDBusDetailsId;
		
		if (BDBusId == null)
		dr["BD_BusId"] = DBNull.Value;
		else
		dr["BD_BusId"] = BDBusId;
		
		if (BDBusType == null)
		dr["BD_BusType"] = DBNull.Value;
		else
		dr["BD_BusType"] = BDBusType;
		
		if (BDTransportManagerID == null)
		dr["BD_TransportManagerID"] = DBNull.Value;
		else
		dr["BD_TransportManagerID"] = BDTransportManagerID;
		
		if (BDBusName == null)
		dr["BD_BusName"] = DBNull.Value;
		else
		dr["BD_BusName"] = BDBusName;
		
		if (BDBusNumber == null)
		dr["BD_BusNumber"] = DBNull.Value;
		else
		dr["BD_BusNumber"] = BDBusNumber;
		
		if (BDTotalNoOfSeats == null)
		dr["BD_TotalNoOfSeats"] = DBNull.Value;
		else
		dr["BD_TotalNoOfSeats"] = BDTotalNoOfSeats;
		
		if (BDBusKMTravels == null)
		dr["BD_BusKMTravels"] = DBNull.Value;
		else
		dr["BD_BusKMTravels"] = BDBusKMTravels;
		
		if (BDMiledge == null)
		dr["BD_Miledge"] = DBNull.Value;
		else
		dr["BD_Miledge"] = BDMiledge;
		
		if (BDCost == null)
		dr["BD_Cost"] = DBNull.Value;
		else
		dr["BD_Cost"] = BDCost;
		
		if (BDMonthlyMaintanceCost == null)
		dr["BD_MonthlyMaintanceCost"] = DBNull.Value;
		else
		dr["BD_MonthlyMaintanceCost"] = BDMonthlyMaintanceCost;
		
		if (BDFuel == null)
		dr["BD_Fuel"] = DBNull.Value;
		else
		dr["BD_Fuel"] = BDFuel;
		
		if (BDServicing == null)
		dr["BD_Servicing"] = DBNull.Value;
		else
		dr["BD_Servicing"] = BDServicing;
		
		if (BDOtherBusParts == null)
		dr["BD_OtherBusParts"] = DBNull.Value;
		else
		dr["BD_OtherBusParts"] = BDOtherBusParts;
		
		if (BDCostNeeded == null)
		dr["BD_CostNeeded"] = DBNull.Value;
		else
		dr["BD_CostNeeded"] = BDCostNeeded;
		
		if (BDTransport == null)
		dr["BD_Transport"] = DBNull.Value;
		else
		dr["BD_Transport"] = BDTransport;
		
		if (BDDescription == null)
		dr["BD_Description"] = DBNull.Value;
		else
		dr["BD_Description"] = BDDescription;
		
		if (BDVia == null)
		dr["BD_Via"] = DBNull.Value;
		else
		dr["BD_Via"] = BDVia;
		
		if (BDPrbFacing == null)
		dr["BD_PrbFacing"] = DBNull.Value;
		else
		dr["BD_PrbFacing"] = BDPrbFacing;
		
		if (BDAddedBy == null)
		dr["BD_AddedBy"] = DBNull.Value;
		else
		dr["BD_AddedBy"] = BDAddedBy;
		
		if (BDDate == null)
		dr["BD_Date"] = DBNull.Value;
		else
		dr["BD_Date"] = BDDate;
		
		if (BDStatus == null)
		dr["BD_Status"] = DBNull.Value;
		else
		dr["BD_Status"] = BDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		BDBusDetailsId = dr["BD_BusDetailsId"] != DBNull.Value ? Convert.ToInt64(dr["BD_BusDetailsId"]) : BDBusDetailsId = null;
		BDBusId = dr["BD_BusId"] != DBNull.Value ? Convert.ToString(dr["BD_BusId"]) : BDBusId = null;
		BDBusType = dr["BD_BusType"] != DBNull.Value ? Convert.ToString(dr["BD_BusType"]) : BDBusType = null;
		BDTransportManagerID = dr["BD_TransportManagerID"] != DBNull.Value ? Convert.ToInt64(dr["BD_TransportManagerID"]) : BDTransportManagerID = null;
		BDBusName = dr["BD_BusName"] != DBNull.Value ? Convert.ToString(dr["BD_BusName"]) : BDBusName = null;
		BDBusNumber = dr["BD_BusNumber"] != DBNull.Value ? Convert.ToString(dr["BD_BusNumber"]) : BDBusNumber = null;
		BDTotalNoOfSeats = dr["BD_TotalNoOfSeats"] != DBNull.Value ? Convert.ToString(dr["BD_TotalNoOfSeats"]) : BDTotalNoOfSeats = null;
		BDBusKMTravels = dr["BD_BusKMTravels"] != DBNull.Value ? Convert.ToString(dr["BD_BusKMTravels"]) : BDBusKMTravels = null;
		BDMiledge = dr["BD_Miledge"] != DBNull.Value ? Convert.ToString(dr["BD_Miledge"]) : BDMiledge = null;
		BDCost = dr["BD_Cost"] != DBNull.Value ? Convert.ToString(dr["BD_Cost"]) : BDCost = null;
		BDMonthlyMaintanceCost = dr["BD_MonthlyMaintanceCost"] != DBNull.Value ? Convert.ToString(dr["BD_MonthlyMaintanceCost"]) : BDMonthlyMaintanceCost = null;
		BDFuel = dr["BD_Fuel"] != DBNull.Value ? Convert.ToString(dr["BD_Fuel"]) : BDFuel = null;
		BDServicing = dr["BD_Servicing"] != DBNull.Value ? Convert.ToString(dr["BD_Servicing"]) : BDServicing = null;
		BDOtherBusParts = dr["BD_OtherBusParts"] != DBNull.Value ? Convert.ToString(dr["BD_OtherBusParts"]) : BDOtherBusParts = null;
		BDCostNeeded = dr["BD_CostNeeded"] != DBNull.Value ? Convert.ToString(dr["BD_CostNeeded"]) : BDCostNeeded = null;
		BDTransport = dr["BD_Transport"] != DBNull.Value ? Convert.ToString(dr["BD_Transport"]) : BDTransport = null;
		BDDescription = dr["BD_Description"] != DBNull.Value ? Convert.ToString(dr["BD_Description"]) : BDDescription = null;
		BDVia = dr["BD_Via"] != DBNull.Value ? Convert.ToString(dr["BD_Via"]) : BDVia = null;
		BDPrbFacing = dr["BD_PrbFacing"] != DBNull.Value ? Convert.ToString(dr["BD_PrbFacing"]) : BDPrbFacing = null;
		BDAddedBy = dr["BD_AddedBy"] != DBNull.Value ? Convert.ToString(dr["BD_AddedBy"]) : BDAddedBy = null;
		BDDate = dr["BD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["BD_Date"]) : BDDate = null;
		BDStatus = dr["BD_Status"] != DBNull.Value ? Convert.ToInt32(dr["BD_Status"]) : BDStatus = null;
	}
	
	public static TMSBusDetails[] MapFrom(DataSet ds)
	{
		List<TMSBusDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSBusDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_BusDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_BusDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSBusDetails instance = new TMSBusDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusDetails Get(System.Int64 bdBusDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSBusDetails instance;
		
		
		instance = new TMSBusDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bdBusDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSBusDetails ID:" + bdBusDetailsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String bdBusType, System.Int64? bdTransportManagerID, System.String bdBusName, System.String bdBusNumber, System.String bdTotalNoOfSeats, System.String bdBusKMTravels, System.String bdMiledge, System.String bdCost, System.String bdMonthlyMaintanceCost, System.String bdFuel, System.String bdServicing, System.String bdOtherBusParts, System.String bdCostNeeded, System.String bdTransport, System.String bdDescription, System.String bdVia, System.String bdPrbFacing, System.String bdAddedBy, System.DateTime? bdDate, System.Int32? bdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bdBusType, bdTransportManagerID, bdBusName, bdBusNumber, bdTotalNoOfSeats, bdBusKMTravels, bdMiledge, bdCost, bdMonthlyMaintanceCost, bdFuel, bdServicing, bdOtherBusParts, bdCostNeeded, bdTransport, bdDescription, bdVia, bdPrbFacing, bdAddedBy, bdDate, bdStatus);
		
		if (transaction == null)
		this.BDBusDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.BDBusDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String bdBusType, System.Int64? bdTransportManagerID, System.String bdBusName, System.String bdBusNumber, System.String bdTotalNoOfSeats, System.String bdBusKMTravels, System.String bdMiledge, System.String bdCost, System.String bdMonthlyMaintanceCost, System.String bdFuel, System.String bdServicing, System.String bdOtherBusParts, System.String bdCostNeeded, System.String bdTransport, System.String bdDescription, System.String bdVia, System.String bdPrbFacing, System.String bdAddedBy, System.DateTime? bdDate, System.Int32? bdStatus)
	{
		Insert(bdBusType, bdTransportManagerID, bdBusName, bdBusNumber, bdTotalNoOfSeats, bdBusKMTravels, bdMiledge, bdCost, bdMonthlyMaintanceCost, bdFuel, bdServicing, bdOtherBusParts, bdCostNeeded, bdTransport, bdDescription, bdVia, bdPrbFacing, bdAddedBy, bdDate, bdStatus, null);
	}
	/// <summary>
	/// Insert current TMSBusDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(BDBusType, BDTransportManagerID, BDBusName, BDBusNumber, BDTotalNoOfSeats, BDBusKMTravels, BDMiledge, BDCost, BDMonthlyMaintanceCost, BDFuel, BDServicing, BDOtherBusParts, BDCostNeeded, BDTransport, BDDescription, BDVia, BDPrbFacing, BDAddedBy, BDDate, BDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSBusDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? bdBusDetailsId, System.String bdBusId, System.String bdBusType, System.Int64? bdTransportManagerID, System.String bdBusName, System.String bdBusNumber, System.String bdTotalNoOfSeats, System.String bdBusKMTravels, System.String bdMiledge, System.String bdCost, System.String bdMonthlyMaintanceCost, System.String bdFuel, System.String bdServicing, System.String bdOtherBusParts, System.String bdCostNeeded, System.String bdTransport, System.String bdDescription, System.String bdVia, System.String bdPrbFacing, System.String bdAddedBy, System.DateTime? bdDate, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bdBusDetailsId"].Value = bdBusDetailsId;
		dbCommand.Parameters["@bdBusType"].Value = bdBusId;
		dbCommand.Parameters["@bdTransportManagerID"].Value = bdBusType;
		dbCommand.Parameters["@bdBusName"].Value = bdTransportManagerID;
		dbCommand.Parameters["@bdBusNumber"].Value = bdBusName;
		dbCommand.Parameters["@bdTotalNoOfSeats"].Value = bdBusNumber;
		dbCommand.Parameters["@bdBusKMTravels"].Value = bdTotalNoOfSeats;
		dbCommand.Parameters["@bdMiledge"].Value = bdBusKMTravels;
		dbCommand.Parameters["@bdCost"].Value = bdMiledge;
		dbCommand.Parameters["@bdMonthlyMaintanceCost"].Value = bdCost;
		dbCommand.Parameters["@bdFuel"].Value = bdMonthlyMaintanceCost;
		dbCommand.Parameters["@bdServicing"].Value = bdFuel;
		dbCommand.Parameters["@bdOtherBusParts"].Value = bdServicing;
		dbCommand.Parameters["@bdCostNeeded"].Value = bdOtherBusParts;
		dbCommand.Parameters["@bdTransport"].Value = bdCostNeeded;
		dbCommand.Parameters["@bdDescription"].Value = bdTransport;
		dbCommand.Parameters["@bdVia"].Value = bdDescription;
		dbCommand.Parameters["@bdPrbFacing"].Value = bdVia;
		dbCommand.Parameters["@bdAddedBy"].Value = bdPrbFacing;
		dbCommand.Parameters["@bdDate"].Value = bdAddedBy;
		dbCommand.Parameters["@bdStatus"].Value = bdDate;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? bdBusDetailsId, System.String bdBusId, System.String bdBusType, System.Int64? bdTransportManagerID, System.String bdBusName, System.String bdBusNumber, System.String bdTotalNoOfSeats, System.String bdBusKMTravels, System.String bdMiledge, System.String bdCost, System.String bdMonthlyMaintanceCost, System.String bdFuel, System.String bdServicing, System.String bdOtherBusParts, System.String bdCostNeeded, System.String bdTransport, System.String bdDescription, System.String bdVia, System.String bdPrbFacing, System.String bdAddedBy, System.DateTime? bdDate)
	{
		Update(bdBusDetailsId, bdBusId, bdBusType, bdTransportManagerID, bdBusName, bdBusNumber, bdTotalNoOfSeats, bdBusKMTravels, bdMiledge, bdCost, bdMonthlyMaintanceCost, bdFuel, bdServicing, bdOtherBusParts, bdCostNeeded, bdTransport, bdDescription, bdVia, bdPrbFacing, bdAddedBy, bdDate, null);
	}
	
	public static void Update(TMSBusDetails tMSBusDetails)
	{
		tMSBusDetails.Update();
	}
	
	public static void Update(TMSBusDetails tMSBusDetails, DbTransaction transaction)
	{
		tMSBusDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSBusDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bdBusDetailsId"].SourceColumn = "BD_BusDetailsId";
		dbCommand.Parameters["@bdBusType"].SourceColumn = "BD_BusType";
		dbCommand.Parameters["@bdTransportManagerID"].SourceColumn = "BD_TransportManagerID";
		dbCommand.Parameters["@bdBusName"].SourceColumn = "BD_BusName";
		dbCommand.Parameters["@bdBusNumber"].SourceColumn = "BD_BusNumber";
		dbCommand.Parameters["@bdTotalNoOfSeats"].SourceColumn = "BD_TotalNoOfSeats";
		dbCommand.Parameters["@bdBusKMTravels"].SourceColumn = "BD_BusKMTravels";
		dbCommand.Parameters["@bdMiledge"].SourceColumn = "BD_Miledge";
		dbCommand.Parameters["@bdCost"].SourceColumn = "BD_Cost";
		dbCommand.Parameters["@bdMonthlyMaintanceCost"].SourceColumn = "BD_MonthlyMaintanceCost";
		dbCommand.Parameters["@bdFuel"].SourceColumn = "BD_Fuel";
		dbCommand.Parameters["@bdServicing"].SourceColumn = "BD_Servicing";
		dbCommand.Parameters["@bdOtherBusParts"].SourceColumn = "BD_OtherBusParts";
		dbCommand.Parameters["@bdCostNeeded"].SourceColumn = "BD_CostNeeded";
		dbCommand.Parameters["@bdTransport"].SourceColumn = "BD_Transport";
		dbCommand.Parameters["@bdDescription"].SourceColumn = "BD_Description";
		dbCommand.Parameters["@bdVia"].SourceColumn = "BD_Via";
		dbCommand.Parameters["@bdPrbFacing"].SourceColumn = "BD_PrbFacing";
		dbCommand.Parameters["@bdAddedBy"].SourceColumn = "BD_AddedBy";
		dbCommand.Parameters["@bdDate"].SourceColumn = "BD_Date";
		dbCommand.Parameters["@bdStatus"].SourceColumn = "BD_Status";
		
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
	public static void Delete(System.Int64? bdBusDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bdBusDetailsId);
		
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
	public static void Delete(System.Int64? bdBusDetailsId)
	{
		Delete(
		bdBusDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSBusDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, BDBusDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.BDBusDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSBusDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusDetails[] Search(System.Int64? bdBusDetailsId, System.String bdBusId, System.String bdBusType, System.Int64? bdTransportManagerID, System.String bdBusName, System.String bdBusNumber, System.String bdTotalNoOfSeats, System.String bdBusKMTravels, System.String bdMiledge, System.String bdCost, System.String bdMonthlyMaintanceCost, System.String bdFuel, System.String bdServicing, System.String bdOtherBusParts, System.String bdCostNeeded, System.String bdTransport, System.String bdDescription, System.String bdVia, System.String bdPrbFacing, System.String bdAddedBy, System.DateTime? bdDate, System.Int32? bdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bdBusDetailsId, bdBusId, bdBusType, bdTransportManagerID, bdBusName, bdBusNumber, bdTotalNoOfSeats, bdBusKMTravels, bdMiledge, bdCost, bdMonthlyMaintanceCost, bdFuel, bdServicing, bdOtherBusParts, bdCostNeeded, bdTransport, bdDescription, bdVia, bdPrbFacing, bdAddedBy, bdDate, bdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSBusDetails.MapFrom(ds);
	}
	
	
	public static TMSBusDetails[] Search(TMSBusDetails searchObject)
	{
		return Search ( searchObject.BDBusDetailsId, searchObject.BDBusId, searchObject.BDBusType, searchObject.BDTransportManagerID, searchObject.BDBusName, searchObject.BDBusNumber, searchObject.BDTotalNoOfSeats, searchObject.BDBusKMTravels, searchObject.BDMiledge, searchObject.BDCost, searchObject.BDMonthlyMaintanceCost, searchObject.BDFuel, searchObject.BDServicing, searchObject.BDOtherBusParts, searchObject.BDCostNeeded, searchObject.BDTransport, searchObject.BDDescription, searchObject.BDVia, searchObject.BDPrbFacing, searchObject.BDAddedBy, searchObject.BDDate, searchObject.BDStatus);
	}
	
	/// <summary>
	/// Returns all TMSBusDetails objects.
	/// </summary>
	/// <returns>List of all TMSBusDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSBusDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

