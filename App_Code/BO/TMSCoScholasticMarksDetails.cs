using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSCoScholasticMarksDetails
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? mdMarksDetailsId, System.Int64? mdSkillTypeId, System.Int64? mdSkillTitleId, System.Int64? mdSchoolId, System.Int64? mdSchoolSubId, System.Int64? mdStudentLoginId, System.Int64? mdGradeId, System.Int32? mdGradePoint, System.String mdGradeName, System.String mdObtainMarks, System.String mdTotalMarks, System.String mdDescription, System.DateTime? mdDate, System.Int64? mdAddedById, System.String mdAddedByType, System.Int32? mdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSCoScholasticMarksDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, mdMarksDetailsId, mdSkillTypeId, mdSkillTitleId, mdSchoolId, mdSchoolSubId, mdStudentLoginId, mdGradeId, mdGradePoint, mdGradeName, mdObtainMarks, mdTotalMarks, mdDescription, mdDate, mdAddedById, mdAddedByType, mdStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSearch(TMSCoScholasticMarksDetails searchObject)
    {
        return GetSearch(searchObject.MDMarksDetailsId, searchObject.MDSkillTypeId, searchObject.MDSkillTitleId, searchObject.MDSchoolId, searchObject.MDSchoolSubId, searchObject.MDStudentLoginId, searchObject.MDGradeId, searchObject.MDGradePoint, searchObject.MDGradeName, searchObject.MDObtainMarks, searchObject.MDTotalMarks, searchObject.MDDescription, searchObject.MDDate, searchObject.MDAddedById, searchObject.MDAddedByType, searchObject.MDStatus);
    }

    /// <summary>
    /// Returns all TMSCoScholasticMarksDetails objects.
    /// </summary>
    /// <returns>List of all TMSCoScholasticMarksDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

