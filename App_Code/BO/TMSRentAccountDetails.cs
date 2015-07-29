using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSRentAccountDetails
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? racRentId, System.String racMonth, System.String racYear, System.Double? racTotalAmount, System.Double? racPaidAmount, System.Double? racAnyDues, System.Int64? racAddedById, System.String racPaidStatus, System.DateTime? racTransactionDate, System.DateTime? racDate, System.Int32? racStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSRentAccountDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, racRentId, racMonth, racYear, racTotalAmount, racPaidAmount, racAnyDues, racAddedById, racPaidStatus, racTransactionDate, racDate, racStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSRentAccountDetails searchObject)
    {
        return GetSearch(searchObject.RACRentId, searchObject.RACMonth, searchObject.RACYear, searchObject.RACTotalAmount, searchObject.RACPaidAmount, searchObject.RACAnyDues, searchObject.RACAddedById, searchObject.RACPaidStatus, searchObject.RACTransactionDate, searchObject.RACDate, searchObject.RacStatus);
    }

    /// <summary>
    /// Returns all TMSRentAccountDetails objects.
    /// </summary>
    /// <returns>List of all TMSRentAccountDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    public static DataSet GetAllRentAccountDetails(System.Int64? racRentId, System.String racMonth, System.String racYear,System.String     racPaidStatus, System.DateTime? racTransactionDate)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSRentAccount_GetAllRentAccountDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, racRentId, racMonth, racYear, racPaidStatus, racTransactionDate);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

