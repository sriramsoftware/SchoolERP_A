using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSExtraActivityDetails
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? eadTimelineId, System.Int64? eadFacultyLoginId, System.Int64? eadStudentLoginId, System.String eadProgressType, System.Int64? eadExtraActivityId, System.Int64? eadSchoolId, System.Int64? eadSchoolSubId, System.String eadExamTerm, System.String eadExtraActivity1, System.String eadExtraActivity2, System.String eadRemarks, System.String eadAddeByType, System.Int64? eadAddedById, System.DateTime? eadDate, System.Int32? eadStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSExtraActivityDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, eadTimelineId, eadFacultyLoginId, eadStudentLoginId, eadProgressType, eadExtraActivityId, eadSchoolId, eadSchoolSubId, eadExamTerm, eadExtraActivity1, eadExtraActivity2, eadRemarks, eadAddeByType, eadAddedById, eadDate, eadStatus);

        ds = db.ExecuteDataSet(dbCommand);
      
        return  ds;
    }


    public static DataSet GetSearch(TMSExtraActivityDetails searchObject)
    {
        return GetSearch(searchObject.EADTimelineId, searchObject.EADFacultyLoginId, searchObject.EADStudentLoginId, searchObject.EADProgressType, searchObject.EADExtraActivityId, searchObject.EADSchoolId, searchObject.EADSchoolSubId, searchObject.EADExamTerm, searchObject.EADExtraActivity1, searchObject.EADExtraActivity2, searchObject.EADRemarks, searchObject.EADAddeByType, searchObject.EADAddedById, searchObject.EADDate, searchObject.EADStatus);
    }

    /// <summary>
    /// Returns all TMSExtraActivityDetails objects.
    /// </summary>
    /// <returns>List of all TMSExtraActivityDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


}

