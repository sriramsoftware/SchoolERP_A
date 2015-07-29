using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSRoyaltyOneTimeCharges
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? rdRoyaltyId, System.String rdRoyaltiMonth, System.String rdRoyaltyYear, System.String rdAdmissionCharges, System.String rdAnnualCharges, System.String rdRegistrationCharges, System.String rdStudentKitCharges, System.String rdUniformCharges, System.String rdAnnualDayCharges, System.String rdSportDayCharges, System.String rdPortfolioCharges, System.String rdMixExpensesCharges, System.Int64? rdAddedById, System.String rdAddedByType, System.DateTime? rdDate, System.Int32? rdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSRoyaltyOneTimeCharges_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, rdRoyaltyId, rdRoyaltiMonth, rdRoyaltyYear, rdAdmissionCharges, rdAnnualCharges, rdRegistrationCharges, rdStudentKitCharges, rdUniformCharges, rdAnnualDayCharges, rdSportDayCharges, rdPortfolioCharges, rdMixExpensesCharges, rdAddedById, rdAddedByType, rdDate, rdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSearch(TMSRoyaltyOneTimeCharges searchObject)
    {
        return GetSearch(searchObject.RDRoyaltyId, searchObject.RDRoyaltiMonth, searchObject.RDRoyaltyYear, searchObject.RDAdmissionCharges, searchObject.RDAnnualCharges, searchObject.RDRegistrationCharges, searchObject.RDStudentKitCharges, searchObject.RDUniformCharges, searchObject.RDAnnualDayCharges, searchObject.RDSportDayCharges, searchObject.RDPortfolioCharges, searchObject.RDMixExpensesCharges, searchObject.RDAddedById, searchObject.RDAddedByType, searchObject.RDDate, searchObject.RDStatus);
    }

    /// <summary>
    /// Returns all TMSRoyaltyOneTimeCharges objects.
    /// </summary>
    /// <returns>List of all TMSRoyaltyOneTimeCharges objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

