using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSScholasticMarksDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? mdMarksDetailsId, System.Int64? mdExamTestId, System.Int64? mdSchoolId, System.Int64? mdSchoolSubId, System.Int64? mdStudentLoginId, System.Int64? mdSubjectId, System.String mdObtainMarks, System.String mdGraceMarks, System.String mdTotalMarks, System.DateTime? mdDate, System.Int64? mdAddedById, System.String mdAddedType, System.Int32? mdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSScholasticMarksDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, mdMarksDetailsId, mdExamTestId, mdSchoolId, mdSchoolSubId, mdStudentLoginId, mdSubjectId, mdObtainMarks, mdGraceMarks, mdTotalMarks, mdDate, mdAddedById, mdAddedType, mdStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSScholasticMarksDetails searchObject)
    {
        return GetSearch(searchObject.MDMarksDetailsId, searchObject.MDExamTestId, searchObject.MDSchoolId, searchObject.MDSchoolSubId, searchObject.MDStudentLoginId, searchObject.MDSubjectId, searchObject.MDObtainMarks, searchObject.MDGraceMarks, searchObject.MDTotalMarks, searchObject.MDDate, searchObject.MDAddedById, searchObject.MDAddedType, searchObject.MDStatus);
    }

    /// <summary>
    /// Returns all TMSScholasticMarksDetails objects.
    /// </summary>
    /// <returns>List of all TMSScholasticMarksDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null);
    }


    public static DataSet GetScholasticMarkDetails(System.Int64? SchoolID,System.Int64? Division, System.Int64? mdMarksDetailsId, System.Int64? mdSubjectId, System.Int64? mdExamTestId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetScholasticMarkDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolID, Division,mdMarksDetailsId, mdSubjectId, mdExamTestId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    #endregion
}

