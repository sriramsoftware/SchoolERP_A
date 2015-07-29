using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSSalaryStaffDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? siDetailsId, System.Int64? siFacultyLoginId, System.Int64? siStaffManagerId, System.String siFacultyType, System.String siSalaryType, System.Double? siBasicSalary, System.Double? siGrossSalary, System.Int32? siLeaveCount, System.Double? siLeaveDeductionAmount, System.String siMonth, System.String siYear, System.DateTime? siDate, System.String siAddedByRemarks, System.Int64? siAddedById, System.String siOtherRemarks, System.Int32? siStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSalaryStaffDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, siDetailsId, siFacultyLoginId, siStaffManagerId, siFacultyType, siSalaryType, siBasicSalary, siGrossSalary, siLeaveCount, siLeaveDeductionAmount, siMonth, siYear, siDate, siAddedByRemarks, siAddedById, siOtherRemarks, siStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSSalaryStaffDetails searchObject)
    {
        return GetSearch(searchObject.SIDetailsId, searchObject.SIFacultyLoginId, searchObject.SIStaffManagerId, searchObject.SIFacultyType, searchObject.SISalaryType, searchObject.SIBasicSalary, searchObject.SIGrossSalary, searchObject.SILeaveCount, searchObject.SILeaveDeductionAmount, searchObject.SIMonth, searchObject.SIYear, searchObject.SIDate, searchObject.SIAddedByRemarks, searchObject.SIAddedById, searchObject.SIOtherRemarks, searchObject.SIStatus);
    }

    /// <summary>
    /// Returns all TMSSalaryStaffDetails objects.
    /// </summary>
    /// <returns>List of all TMSSalaryStaffDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion



    #region Check Salary Is Alraedy Added Or Not For Particular Month Or Use This Sp to Get Filter wise Record
    public static DataSet GetBusStaffSalaryDetails(System.Int64? SalaryDetailsId, System.Int64? TransportManagerId, System.Int64? BusStaffLoginId, System.String SalaryType, System.String Month, System.String Year)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspViewBusStaffSalaryDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SalaryDetailsId, TransportManagerId, BusStaffLoginId, SalaryType, Month, Year);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion


    #region View Diver & Supporter Salary Details
    public static DataSet GetBusDriver_And_BusSupporter_SalaryDetails(System.Int64? TrnasportManagerId, System.Int64? BussStaffLoginId, System.String Month, System.String Year)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspViewBusDriver_AndBusSupporter_SalaryDetails_MonthWise]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, TrnasportManagerId, BussStaffLoginId, Month, Year);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
}

