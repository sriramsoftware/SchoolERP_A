using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSBusStaffDetails
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? bsdStaffId, System.Int64? bsdTransportManagerID, System.String bsdStaffType, System.String bsdStaffName, System.String bsdImage, System.Int64? bsdAddressId, System.DateTime? bsdDateOfJoining, System.String bsdLicenceNo, System.DateTime? bsdDate, System.Int32? bsdStatus, System.String bsdBusStaffId, System.String bsdBusLicenceImage)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBusStaffDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, bsdStaffId, bsdTransportManagerID, bsdStaffType, bsdStaffName, bsdImage, bsdAddressId, bsdDateOfJoining, bsdLicenceNo, bsdDate, bsdStatus, bsdBusStaffId, bsdBusLicenceImage);

        ds = db.ExecuteDataSet(dbCommand);
       
        return (ds);
    }


    public static DataSet GetSearch(TMSBusStaffDetails searchObject)
    {
        return GetSearch(searchObject.BSDStaffId, searchObject.BSDTransportManagerID, searchObject.BSDStaffType, searchObject.BSDStaffName, searchObject.BSDImage, searchObject.BSDAddressId, searchObject.BSDDateOfJoining, searchObject.BSDLicenceNo, searchObject.BSDDate, searchObject.BSDStatus, searchObject.BSDBusStaffId, searchObject.BSDBusLicenceImage);
    }

    /// <summary>
    /// Returns all TMSBusStaffDetails objects.
    /// </summary>
    /// <returns>List of all TMSBusStaffDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet GetTMSBusStaffDetailsSEARCH(System.Int64? bsdStaffId, System.String bsdBusStaffId, System.String bsdStaffType, System.String bsdStaffName)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBusStaffDetailsSEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, bsdStaffId, bsdBusStaffId, bsdStaffType, bsdStaffName);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetTransportStaffDetails(System.Int64? bsdStaffId, System.Int64? AddressID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSgetTransportStaffDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, bsdStaffId, AddressID);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


}

