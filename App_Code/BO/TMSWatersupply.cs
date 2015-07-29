using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSWatersupply
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? wsWsid, System.Double? wsBillAmount, System.Double? wsLateFees, System.String wsMonth, System.String wsYear, System.DateTime? wsLastDate, System.DateTime? wsBillPaidDate, System.Double? wsTotalAmount, System.String wsPaidStatus, System.String wsBillNumber, System.String wsExtra1, System.DateTime? wsDate, System.Int32? wsStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSWatersupply_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, wsWsid, wsBillAmount, wsLateFees, wsMonth, wsYear, wsLastDate, wsBillPaidDate, wsTotalAmount, wsPaidStatus, wsBillNumber, wsExtra1, wsDate, wsStatus);

        ds = db.ExecuteDataSet(dbCommand);
       
        return ds;
    }


    public static DataSet GetSearch (TMSWatersupply searchObject)
    {
        return GetSearch(searchObject.WsWsid, searchObject.WSBillAmount, searchObject.WSLateFees, searchObject.WSMonth, searchObject.WSYear, searchObject.WSLastDate, searchObject.WSBillPaidDate, searchObject.WSTotalAmount, searchObject.WSPaidStatus, searchObject.WSBillNumber, searchObject.WSExtra1, searchObject.WSDate, searchObject.WSStatus);
    }

    /// <summary>
    /// Returns all TMSWatersupply objects.
    /// </summary>
    /// <returns>List of all TMSWatersupply objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    public static DataSet GetWatersupplySEARCH(System.Int64? wsWsid, System.Double? wsBillAmount, System.Double? wsLateFees, System.String wsMonth, System.String wsYear, System.DateTime? wsLastDate, System.DateTime? wsBillPaidDate, System.Double? wsTotalAmount, System.String wsPaidStatus, System.String wsBillNumber, System.String wsExtra1)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSWatersupplySEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, wsWsid, wsBillAmount, wsLateFees, wsMonth, wsYear, wsLastDate, wsBillPaidDate, wsTotalAmount, wsPaidStatus, wsBillNumber, wsExtra1);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }



    public static DataSet GetalredyexistWatersupply(System.Int64? wsWsid, System.Double? wsBillAmount, System.Double? wsLateFees, System.String wsMonth, System.String wsYear, System.DateTime? wsLastDate, System.DateTime? wsBillPaidDate, System.Double? wsTotalAmount, System.String wsPaidStatus, System.String wsBillNumber, System.String wsExtra1, System.DateTime? wsDate, System.Int32? wsStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSalredyexistWatersupply";
        dbCommand = db.GetStoredProcCommand(sqlCommand, wsWsid, wsBillAmount, wsLateFees, wsMonth, wsYear, wsLastDate, wsBillPaidDate, wsTotalAmount, wsPaidStatus, wsBillNumber, wsExtra1, wsDate, wsStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    #endregion
}

