using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSBusDetails
{


   #region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static DataSet GetSearch(System.Int64? bdBusDetailsId, System.String bdBusId, System.String bdBusType, System.Int64? bdTransportManagerID, System.String bdBusName, System.String bdBusNumber, System.String bdTotalNoOfSeats, System.String bdBusKMTravels, System.String bdMiledge, System.String bdCost, System.String bdMonthlyMaintanceCost, System.String bdFuel, System.String bdServicing, System.String bdOtherBusParts, System.String bdCostNeeded, System.String bdTransport, System.String bdDescription, System.String bdVia, System.String bdPrbFacing, System.String bdAddedBy, System.DateTime? bdDate, System.Int32? bdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bdBusDetailsId, bdBusId, bdBusType, bdTransportManagerID, bdBusName, bdBusNumber, bdTotalNoOfSeats, bdBusKMTravels, bdMiledge, bdCost, bdMonthlyMaintanceCost, bdFuel, bdServicing, bdOtherBusParts, bdCostNeeded, bdTransport, bdDescription, bdVia, bdPrbFacing, bdAddedBy, bdDate, bdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		
		return ds;
	}


    public static DataSet GetSearch (TMSBusDetails searchObject)
	{
        return GetSearch(searchObject.BDBusDetailsId, searchObject.BDBusId, searchObject.BDBusType, searchObject.BDTransportManagerID, searchObject.BDBusName, searchObject.BDBusNumber, searchObject.BDTotalNoOfSeats, searchObject.BDBusKMTravels, searchObject.BDMiledge, searchObject.BDCost, searchObject.BDMonthlyMaintanceCost, searchObject.BDFuel, searchObject.BDServicing, searchObject.BDOtherBusParts, searchObject.BDCostNeeded, searchObject.BDTransport, searchObject.BDDescription, searchObject.BDVia, searchObject.BDPrbFacing, searchObject.BDAddedBy, searchObject.BDDate, searchObject.BDStatus);
	}
	
	/// <summary>
	/// Returns all TMSBusDetails objects.
	/// </summary>
	/// <returns>List of all TMSBusDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
	{
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	

    public static DataSet GetTransportCount(System.String bdTransport)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillTransportCount";
        dbCommand = db.GetStoredProcCommand(sqlCommand, bdTransport);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet FillBusDetails()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrGetBusrootDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetBusCountDetails(System.Int32? badcount)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetbusseatcount";
        dbCommand = db.GetStoredProcCommand(sqlCommand, badcount);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet FillBusTimetables(System.String bdTransport)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrFillBustimetable]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, bdTransport);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    #endregion
    public static DataSet TMSBusDetailsSEARCH(System.Int64? bdBusDetailsId, System.String bdBusId, System.String bdBusName, System.String bdBusNumber, System.String bdTotalNoOfSeats)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBusDetailsSEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, bdBusDetailsId, bdBusId, bdBusName, bdBusNumber, bdTotalNoOfSeats);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetBusMeintananceDetail(System.Int64? BusID, System.Int64? RootID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBusMeintananceDetail";
        dbCommand = db.GetStoredProcCommand(sqlCommand, BusID, RootID);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetTransportDetails_AccodingTo_TransportManager(System.Int64? TransportManagerId, System.String bdTransport)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGetTransportDetails_AccodingTo_TransportManager";
        dbCommand = db.GetStoredProcCommand(sqlCommand, TransportManagerId, bdTransport);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


}

