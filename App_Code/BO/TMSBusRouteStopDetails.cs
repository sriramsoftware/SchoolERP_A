using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSBusRouteStopDetails
{


    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? brsdStopId, System.Int64? brsdBusId, System.Int64? brsdRouteId, System.String brsdStopName, System.String brsdArrivalTime, System.String brsdDepartureTime, System.String brsdHalt, System.String brsdKm, System.DateTime? brsdDate, System.Int32? brsdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBusRouteStopDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, brsdStopId, brsdBusId, brsdRouteId, brsdStopName, brsdArrivalTime, brsdDepartureTime, brsdHalt, brsdKm, brsdDate, brsdStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetSearch(TMSBusRouteStopDetails searchObject)
    {
        return GetSearch(searchObject.BRSDStopId, searchObject.BRSDBusId, searchObject.BRSDRouteId, searchObject.BRSDStopName, searchObject.BRSDArrivalTime, searchObject.BRSDDepartureTime, searchObject.BRSDHalt, searchObject.BrsdKm, searchObject.BRSDDate, searchObject.BRSDStatus);
    }

    /// <summary>
    /// Returns all TMSBusRouteStopDetails objects.
    /// </summary>
    /// <returns>List of all TMSBusRouteStopDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null);
    }
    public static DataSet GetFillBusStartStop()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillBusStartStop";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetBusRootDetailAccordingtoBusID(System.Int64? busId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGetBusRootDetailAccordingtoBusID";
        dbCommand = db.GetStoredProcCommand(sqlCommand, busId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    
    public static DataSet GetSearchBusStopDetails(System.Int64? busId, System.Int64? busRouteId, System.Int64? busStopId, System.String busName, System.String busRouteStartName, System.String busRouteEndName, System.String busRouteStopName,System.String ArrivalTime, System.String DepartureTime)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSSearchBusRouteStopDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, busId, busRouteId, busStopId, busName, busRouteStartName, busRouteEndName, busRouteStopName, ArrivalTime,DepartureTime);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSearchAvailableBusDetails()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSSearchAvailableSeatsInBus";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet Search_AvailableSeatsInBus_AccordingToTransportManager(System.Int64? TransportManagerId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSSearch_AvailableSeatsInBus_AccordingToTransport";
        dbCommand = db.GetStoredProcCommand(sqlCommand, TransportManagerId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetBusAvailableSeatsInBus_AccordingToTransport(System.Int64? TransportManagerId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].GetBusAvailableSeatsInBus_AccordingToTransport";
        dbCommand = db.GetStoredProcCommand(sqlCommand, TransportManagerId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion


}

