using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSElectricity
{


    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? elEbillID, System.Double? elBillAmount, System.Double? elLateFees, System.String elMonth, System.String elYear, System.DateTime? elLastDate, System.DateTime? elBillPaidDate, System.Double? elTotalAmount, System.String elPaidStatus, System.String elbIllno, System.String elBillFile, System.String elExtra1, System.String elExtra2, System.DateTime? elDate, System.Int32? elStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSElectricity_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, elEbillID, elBillAmount, elLateFees, elMonth, elYear, elLastDate, elBillPaidDate, elTotalAmount, elPaidStatus, elbIllno, elBillFile, elExtra1, elExtra2, elDate, elStatus);

        ds = db.ExecuteDataSet(dbCommand);
       
        return ds;
    }


    public static DataSet GetSearch (TMSElectricity searchObject)
    {
        return GetSearch(searchObject.ElEbillID, searchObject.ELBillAmount, searchObject.ELLateFees, searchObject.ELMonth, searchObject.ElYear, searchObject.ElLastDate, searchObject.ElBillPaidDate, searchObject.ELTotalAmount, searchObject.ELPaidStatus, searchObject.ELBIllno, searchObject.ELBillFile, searchObject.ELExtra1, searchObject.ELExtra2, searchObject.ELDate, searchObject.ELStatus);
    }

    /// <summary>
    /// Returns all TMSElectricity objects.
    /// </summary>
    /// <returns>List of all TMSElectricity objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    public static DataSet GetElectricitySEARCH(System.Int64? elEbillID, System.Double? elBillAmount, System.Double? elLateFees, System.String elMonth, System.String elYear, System.DateTime? elLastDate, System.DateTime? elBillPaidDate, System.Double? elTotalAmount, System.String elPaidStatus, System.String elExtra1)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSElectricitySEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, elEbillID, elBillAmount, elLateFees, elMonth, elYear, elLastDate, elBillPaidDate, elTotalAmount, elPaidStatus, elExtra1);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet BindAlredyexistElectricity(System.Int64? elEbillID, System.Double? elBillAmount, System.Double? elLateFees, System.String elMonth, System.String elYear, System.DateTime? elLastDate, System.DateTime? elBillPaidDate, System.Double? elTotalAmount, System.String elPaidStatus, System.String elExtra1)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAlredyexistElectricitySEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, elEbillID, elBillAmount, elLateFees, elMonth, elYear, elLastDate, elBillPaidDate, elTotalAmount, elPaidStatus, elExtra1);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    
    public static DataSet GetDistinctYear(System.String Type)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGetDistinctYear";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Type);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

   
}

