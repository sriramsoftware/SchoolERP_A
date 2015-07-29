using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSDownloadBroucher
{

    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? dbBroucherID, System.String dbName, System.String dbContactno, System.String dbEmailID, System.String dbDescription, System.String dbSchoolName, System.String dbStaticID, System.String dbPhysicalID, System.String dbCountryName, System.String dbMiniBroucher, System.String dbExtra1, System.String dbExtra2, System.DateTime? dbDate, System.Int32? dbStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSDownloadBroucher_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, dbBroucherID, dbName, dbContactno, dbEmailID, dbDescription, dbSchoolName, dbStaticID, dbPhysicalID, dbCountryName, dbMiniBroucher, dbExtra1, dbExtra2, dbDate, dbStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSDownloadBroucher searchObject)
    {
        return GetSearch(searchObject.DBBroucherID, searchObject.DBName, searchObject.DBContactno, searchObject.DBEmailID, searchObject.DBDescription, searchObject.DBSchoolName, searchObject.DBStaticID, searchObject.DBPhysicalID, searchObject.DBCountryName, searchObject.DBMiniBroucher, searchObject.DBExtra1, searchObject.DBExtra2, searchObject.DBDate, searchObject.DBStatus);
    }

    /// <summary>
    /// Returns all TMSDownloadBroucher objects.
    /// </summary>
    /// <returns>List of all TMSDownloadBroucher objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet GetDownloadBroucherDetails(System.Int64? dbBroucherID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSGetDownloadBroucherDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, dbBroucherID);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
}

