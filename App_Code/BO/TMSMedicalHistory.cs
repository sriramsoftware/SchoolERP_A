using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSMedicalHistory
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? mhHistoryId, System.Int64? mhFacultyId, System.Int64? mhSudentId, System.Int64? mhParentId, System.Int32? mhAsthamaLungProblem, System.Int32? mhCancer, System.Int32? mhCardiacDisease, System.Int32? mhDiabetes, System.Int32? mhHistoryOfBackPain, System.Int32? mhHypertension, System.Int32? mhSymptomsAllergy, System.Int32? mhSymptomsCardiovascularChestPain, System.Int32? mhSymptomsConnectiveTiessue, System.Int32? mhSymptomsDiabetes, System.Int32? mhSymptomsWeightGainLoss, System.Int32? mhSymptomsNeurological, System.String mhMedicationAllergiesList, System.String mhMedicationAllergiesCurrentList, System.String mhRiskFallsInjuries, System.String mhExtra1, System.String mhExtra2, System.String mhExtra3, System.DateTime? mhDate, System.Int32? mhStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSMedicalHistory_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, mhHistoryId, mhFacultyId, mhSudentId, mhParentId, mhAsthamaLungProblem, mhCancer, mhCardiacDisease, mhDiabetes, mhHistoryOfBackPain, mhHypertension, mhSymptomsAllergy, mhSymptomsCardiovascularChestPain, mhSymptomsConnectiveTiessue, mhSymptomsDiabetes, mhSymptomsWeightGainLoss, mhSymptomsNeurological, mhMedicationAllergiesList, mhMedicationAllergiesCurrentList, mhRiskFallsInjuries, mhExtra1, mhExtra2, mhExtra3, mhDate, mhStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSMedicalHistory searchObject)
    {
        return GetSearch(searchObject.MHHistoryId, searchObject.MHFacultyId, searchObject.MHSudentId, searchObject.MHParentId, searchObject.MHAsthamaLungProblem, searchObject.MHCancer, searchObject.MHCardiacDisease, searchObject.MHDiabetes, searchObject.MHHistoryOfBackPain, searchObject.MHHypertension, searchObject.MHSymptomsAllergy, searchObject.MHSymptomsCardiovascularChestPain, searchObject.MHSymptomsConnectiveTiessue, searchObject.MHSymptomsDiabetes, searchObject.MHSymptomsWeightGainLoss, searchObject.MHSymptomsNeurological, searchObject.MHMedicationAllergiesList, searchObject.MHMedicationAllergiesCurrentList, searchObject.MHRiskFallsInjuries, searchObject.MHExtra1, searchObject.MHExtra2, searchObject.MHExtra3, searchObject.MHDate, searchObject.MHStatus);
    }

    /// <summary>
    /// Returns all TMSMedicalHistory objects.
    /// </summary>
    /// <returns>List of all TMSMedicalHistory objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

