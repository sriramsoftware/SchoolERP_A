using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSTelephoneBillDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? tbdBillId, System.Int64? tbdTelephoneId, System.String tbdMonth, System.String tbdYear, System.Double? tbdBillAmount, System.DateTime? tbdDate, System.Int64? tbdAddedById, System.String tbdAddedByRemark, System.String tbdPaidStatus, System.Int32? tbdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSTelephoneBillDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, tbdBillId, tbdTelephoneId, tbdMonth, tbdYear, tbdBillAmount, tbdDate, tbdAddedById, tbdAddedByRemark, tbdPaidStatus, tbdStatus);

        return db.ExecuteDataSet(dbCommand);
      
    }


    public static DataSet GetSearch(TMSTelephoneBillDetails searchObject)
    {
        return GetSearch(searchObject.TBDBillId, searchObject.TBDTelephoneId, searchObject.TBDMonth, searchObject.TBDYear, searchObject.TBDBillAmount, searchObject.TBDDate, searchObject.TBDAddedById, searchObject.TBDAddedByRemark, searchObject.TBDPaidStatus, searchObject.TBDStatus);
    }

    /// <summary>
    /// Returns all TMSTelephoneBillDetails objects.
    /// </summary>
    /// <returns>List of all TMSTelephoneBillDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet BindTelePhoneBillDetails(System.Int64? AccountManagerLoginId, System.Int64? TelephoneId, System.String Month, System.String Year, System.String DepartmentName)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSTelephoneBillDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, AccountManagerLoginId, TelephoneId, Month, Year, DepartmentName);
        return db.ExecuteDataSet(dbCommand);
    }

    public static DataSet GetBillDetails_MonthandYearWise(System.String Year)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSTelephoneBillDetails_MonthandYearWise";
        dbCommand = db.GetStoredProcCommand(sqlCommand,Year);
        return db.ExecuteDataSet(dbCommand);
    }

    public static DataSet UpdateBillStatus_MonthandYearWise(System.Int64? AccountManagerLoginId, System.String Month, System.String Year)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspUpdateBillStatus_MonthandYearWise]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, AccountManagerLoginId, Month, Year);
       // return ds;
        return db.ExecuteDataSet(dbCommand);
    }
}

