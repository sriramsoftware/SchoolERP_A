using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSFeesInstallment
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? fiInstallmentId, System.Int64? fiStudentLoginId, System.Int64? fiSchoolId, System.Int64? fiSchoolSubId, System.Int64? fiPaymentId, System.String fiInstallmentType, System.String fiAmount, System.String fiInstallmentStatus, System.DateTime? fiLastDate, System.String fiLateFeesPerDay, System.String fiTotalFees, System.DateTime? fiDate, System.Int32? fiStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFeesInstallment_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, fiInstallmentId, fiStudentLoginId, fiSchoolId, fiSchoolSubId, fiPaymentId, fiInstallmentType, fiAmount, fiInstallmentStatus, fiLastDate, fiLateFeesPerDay, fiTotalFees, fiDate, fiStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetSearch(TMSFeesInstallment searchObject)
    {
        return GetSearch(searchObject.FIInstallmentId, searchObject.FIStudentLoginId, searchObject.FISchoolId, searchObject.FISchoolSubId, searchObject.FIPaymentId, searchObject.FIInstallmentType, searchObject.FIAmount, searchObject.FIInstallmentStatus, searchObject.FILastDate, searchObject.FILateFeesPerDay, searchObject.FITotalFees, searchObject.FIDate, searchObject.FIStatus);
    }

    /// <summary>
    /// Returns all TMSFeesInstallment objects.
    /// </summary>
    /// <returns>List of all TMSFeesInstallment objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
    public static DataSet GetFeesDetails()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFeesDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet FillStudentFeesDetails(System.Int64? StanderdID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillStudentFeesDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StanderdID);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet BindFeesInstallmentSEARCH(System.Int64? fiSchoolId, System.String fiInstallmentType, System.DateTime? fiLastDate)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrBindFeesInstallmentSEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, fiSchoolId, fiInstallmentType, fiLastDate);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    
}

