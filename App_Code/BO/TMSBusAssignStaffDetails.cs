
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSBusAssignStaffDetails
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? badAssignId, System.Int64? badBusId, System.Int64? badBusDriverId, System.Int64? badBusConductorId, System.DateTime? badDate, System.Int32? badStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBusAssignStaffDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, badAssignId, badBusId, badBusDriverId, badBusConductorId, badDate, badStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetSearch(TMSBusAssignStaffDetails searchObject)
    {
        return GetSearch(searchObject.BADAssignId, searchObject.BADBusId, searchObject.BADBusDriverId, searchObject.BADBusConductorId, searchObject.BADDate, searchObject.BADStatus);
    }

    /// <summary>
    /// Returns all TMSBusAssignStaffDetails objects.
    /// </summary>
    /// <returns>List of all TMSBusAssignStaffDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null);
    }


    public static DataSet FillStaffAsignToBus(System.String DriverName, System.String Supportername, System.String busname, System.String type)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillStaffAsignTIbus";
        dbCommand = db.GetStoredProcCommand(sqlCommand, DriverName, Supportername, busname, type);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }





    public static DataSet DriverSupporterDetails(System.String data, System.Int64? TransportManagerId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrDriverSupporterDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, data, TransportManagerId);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }

    public static DataSet FillDriverSupporterBusDetails(System.Int64? badBusDriverId, System.Int64? badBusConductorId, System.Int64? Busid)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillDriverSupporterBusDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, badBusDriverId, badBusConductorId, Busid);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet FillDriverAccountDetails(System.Int64? DriverID, System.Int64? SupporterID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrFillDriverAccountDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, DriverID, SupporterID);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    #endregion



    public static DataSet GetBusDiver_And_BusSupporterDetails(System.Int64? BusStaffId, System.Int64? TransportManagerId, System.String UserName, System.String UserType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSBusDriver_And_BusSupporterDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, BusStaffId, TransportManagerId, UserName, UserType);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }

}

