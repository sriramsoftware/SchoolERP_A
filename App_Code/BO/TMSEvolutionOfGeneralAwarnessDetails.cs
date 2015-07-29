using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSEvolutionOfGeneralAwarnessDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? egadAwarnessId, System.Int64? egadSchoolId, System.Int64? egadSchoolSubId, System.Int64? egadStudentLoginId, System.String egadMySurrounding, System.String egadMyMotherName, System.String egadMyFatherName, System.String egadMyHomeAddress, System.String egadMyPhoneNumber, System.String egadMySchoolName, System.String egadAddedByType, System.Int64? egadAddedByLoginId, System.DateTime? egadDate, System.Int32? egadStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSEvolutionOfGeneralAwarnessDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, egadAwarnessId, egadSchoolId, egadSchoolSubId, egadStudentLoginId, egadMySurrounding, egadMyMotherName, egadMyFatherName, egadMyHomeAddress, egadMyPhoneNumber, egadMySchoolName, egadAddedByType, egadAddedByLoginId, egadDate, egadStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSEvolutionOfGeneralAwarnessDetails searchObject)
    {
        return GetSearch(searchObject.EGADAwarnessId, searchObject.EGADSchoolId, searchObject.EGADSchoolSubId, searchObject.EGADStudentLoginId, searchObject.EGADMySurrounding, searchObject.EGADMyMotherName, searchObject.EGADMyFatherName, searchObject.EGADMyHomeAddress, searchObject.EGADMyPhoneNumber, searchObject.EGADMySchoolName, searchObject.EGADAddedByType, searchObject.EGADAddedByLoginId, searchObject.EGADDate, searchObject.EGADStatus);
    }

    /// <summary>
    /// Returns all TMSEvolutionOfGeneralAwarnessDetails objects.
    /// </summary>
    /// <returns>List of all TMSEvolutionOfGeneralAwarnessDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
    #region Search EvolutionReport
    public static DataSet GetSearchEvolutionReport(System.Int64? studentLoginId, System.Int64? schoolId, System.Int64? schoolSubId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSSearchEvolutionReport";
        dbCommand = db.GetStoredProcCommand(sqlCommand, studentLoginId, schoolId, schoolSubId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
}

