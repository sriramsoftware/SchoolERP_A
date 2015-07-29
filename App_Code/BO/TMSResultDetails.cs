using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


public partial class TMSResultDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? rdResultId, System.Int64? rdSchoolId, System.Int64? rdSchoolSubId, System.Int64? rdStudentId, System.Int64? rdSubjectId, System.String rdExamType, System.Int64? rdExamId, System.String rdExamName, System.String rdResultText, System.Int32? rdMarks, System.String rdGrade, System.DateTime? rdResultDate, System.Int64? rdResultAddedBy, System.String rdResultStatus, System.DateTime? rdDate, System.Int32? rdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSResultDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, rdResultId, rdSchoolId, rdSchoolSubId, rdStudentId, rdSubjectId, rdExamType, rdExamId, rdExamName, rdResultText, rdMarks, rdGrade, rdResultDate, rdResultAddedBy, rdResultStatus, rdDate, rdStatus);

        return db.ExecuteDataSet(dbCommand);
       
    }


    public static DataSet GetSearch(TMSResultDetails searchObject)
    {
        return GetSearch(searchObject.RDResultId, searchObject.RDSchoolId, searchObject.RDSchoolSubId, searchObject.RDStudentId, searchObject.RDSubjectId, searchObject.RDExamType, searchObject.RDExamId, searchObject.RDExamName, searchObject.RDResultText, searchObject.RDMarks, searchObject.RDGrade, searchObject.RDResultDate, searchObject.RDResultAddedBy, searchObject.RDResultStatus, searchObject.RDDate, searchObject.RDStatus);
    }

    /// <summary>
    /// Returns all TMSResultDetails objects.
    /// </summary>
    /// <returns>List of all TMSResultDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    public static DataSet ViewResultOfStudent_SubjectWise(System.Int64? StudentId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspViewStudent_SubjectWiseResult";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
}

