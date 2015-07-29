using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSBusRouteDetails
{


    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? brRouteId, System.Int64? brBusId, System.String brStartRoute, System.String brEndRoute, System.String brArrivalTime, System.String brDepartureTime, System.String brHalt, System.String brKm, System.String brMapImage, System.DateTime? brDate, System.Int32? brStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBusRouteDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, brRouteId, brBusId, brStartRoute, brEndRoute, brArrivalTime, brDepartureTime, brHalt, brKm, brMapImage, brDate, brStatus);

        ds = db.ExecuteDataSet(dbCommand);
     
        return ds;
    }


    public static DataSet GetSearch (TMSBusRouteDetails searchObject)
    {
        return GetSearch(searchObject.BRRouteId, searchObject.BRBusId, searchObject.BRStartRoute, searchObject.BREndRoute, searchObject.BRArrivalTime, searchObject.BRDepartureTime, searchObject.BRHalt, searchObject.BrKm, searchObject.BRMapImage, searchObject.BRDate, searchObject.BRStatus);
    }

    /// <summary>
    /// Returns all TMSBusRouteDetails objects.
    /// </summary>
    /// <returns>List of all TMSBusRouteDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null);
    }


        public static DataSet FillBusstartRoutDetails()
        {
            DataSet ds;
            Database db;
            string sqlCommand;
            DbCommand dbCommand;
            db = DatabaseFactory.CreateDatabase();
            sqlCommand = "[dbo].gspTMSrStartBusRoute";
            dbCommand = db.GetStoredProcCommand(sqlCommand);
            ds = db.ExecuteDataSet(dbCommand);
            return ds;
        }
        public static DataSet FillBusEndRoutDetails()
        {
            DataSet ds;
            Database db;
            string sqlCommand;
            DbCommand dbCommand;
            db = DatabaseFactory.CreateDatabase();
            sqlCommand = "[dbo].gspTMSrEndBusRoute";
            dbCommand = db.GetStoredProcCommand(sqlCommand);
            ds = db.ExecuteDataSet(dbCommand);
            return ds;
        }
           public static DataSet FillRoute(System.Int64? routeID)
            {
                DataSet ds;
                Database db;
                string sqlCommand;
                DbCommand dbCommand;
                db = DatabaseFactory.CreateDatabase();
                sqlCommand = "[dbo].gspTMSrFillRouteDetails";
                dbCommand = db.GetStoredProcCommand(sqlCommand, routeID);
                ds = db.ExecuteDataSet(dbCommand);
                return ds;
            }


    public static DataSet FillTMSrtransportSearchbyStudent(System.Int64? SchoolCategoryId, System.Int64? SchoolSubCatId, System.String FirstName, System.String BusNumber, System.String StartRoute)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrtransportSearchbyStudent";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolCategoryId, SchoolSubCatId, FirstName, BusNumber, StartRoute);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }

    public static DataSet FillTMSrtransportSearchbyBus(System.String StartRoute, System.String endroute, System.String busnumber)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillTransportbussearch";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StartRoute, endroute, busnumber);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }



    public static DataSet FillBusAvailables(System.String StartRoute)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrAvailableTransport";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StartRoute);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    #endregion


    public static DataSet GetBusRouteDetails(System.Int64? brRouteId, System.Int64? brBusId, System.String brStartRoute, System.String brEndRoute, System.String brArrivalTime, System.String brDepartureTime, System.String brHalt, System.String brKm, System.String brMapImage, System.DateTime? brDate, System.Int32? brStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBusRouteDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, brRouteId, brBusId, brStartRoute, brEndRoute, brArrivalTime, brDepartureTime, brHalt, brKm, brMapImage, brDate, brStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetStopName()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].GetStopName";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSBusDetails(System.String BusStopname)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMGetSBusDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, BusStopname);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    
}

