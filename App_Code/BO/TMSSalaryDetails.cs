using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSSalaryDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? siDetailsId, System.Int64? siFacultyLoginId, System.String siFacultyType, System.String siSalaryType, System.Double? siBasicSalary, System.Double? siGrossSalary, System.Int32? siLeaveCount, System.Double? siLeaveDeductionAmount, System.String siMonth, System.String siYear, System.String siCurrency, System.Double? sipfRate, System.Double? sipfAmount, System.Double? siesiRate, System.Double? siesiAmount, System.Int32? siSetHalfDayHours, System.Int32? silcelFlexibleHours, System.Int32? silcelConvertedDays, System.Int32? silcelcOnvertHalfDay, System.Int32? silcelConvertFullDay, System.DateTime? siDate, System.String siAddedByRemarks, System.Int64? siAddedById, System.String siOtherRemarks, System.Int32? siStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSalaryDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, siDetailsId, siFacultyLoginId, siFacultyType, siSalaryType, siBasicSalary, siGrossSalary, siLeaveCount, siLeaveDeductionAmount, siMonth, siYear, siCurrency, sipfRate, sipfAmount, siesiRate, siesiAmount, siSetHalfDayHours, silcelFlexibleHours, silcelConvertedDays, silcelcOnvertHalfDay, silcelConvertFullDay, siDate, siAddedByRemarks, siAddedById, siOtherRemarks, siStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSSalaryDetails searchObject)
    {
        return GetSearch(searchObject.SIDetailsId, searchObject.SIFacultyLoginId, searchObject.SIFacultyType, searchObject.SISalaryType, searchObject.SIBasicSalary, searchObject.SIGrossSalary, searchObject.SILeaveCount, searchObject.SILeaveDeductionAmount, searchObject.SIMonth, searchObject.SIYear, searchObject.SICurrency, searchObject.SIPFRate, searchObject.SIPFAmount, searchObject.SIESIRate, searchObject.SIESIAmount, searchObject.SISetHalfDayHours, searchObject.SILCELFlexibleHours, searchObject.SILCELConvertedDays, searchObject.SILCELCOnvertHalfDay, searchObject.SILCELConvertFullDay, searchObject.SIDate, searchObject.SIAddedByRemarks, searchObject.SIAddedById, searchObject.SIOtherRemarks, searchObject.SIStatus);
    }

    /// <summary>
    /// Returns all TMSSalaryDetails objects.
    /// </summary>
    /// <returns>List of all TMSSalaryDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion



    #region View Teacher and Staff Details
    public static DataSet GetSalaryDetails(System.Int64? SalaryDetailsId, System.Int64? FacultyLoginId, System.String FacultyType, System.String SalaryType, System.String Month, System.String Year)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspViewSalaryDetails_FacultyWise";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SalaryDetailsId, FacultyLoginId, FacultyType, SalaryType,Month,Year);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion


    #region View Salary Details
    public static DataSet GetFacultyAndStaffSalaryDetails(System.Int64? FacultyLoginId, System.String Month, System.String Year)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspViewFacultyAndStaff_SalaryDetails_MonthWise]";
        dbCommand = db.GetStoredProcCommand(sqlCommand,FacultyLoginId, Month, Year);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion


    #region View Salary-Slip Details
    public static DataSet GetSalarySlipDetails(System.Int64? SalaryDetailsId, System.Int64? FacultyLoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SalaryDetails_ViewSalarySlip]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SalaryDetailsId, FacultyLoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

    #region View Monthly Details
    public static DataSet GetMonthlyExpenditureDetails(System.String Month, System.String Year)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMSSearchMonthlyReport]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Month, Year);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
}

