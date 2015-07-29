using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSScholasticExamTestDetails
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? etdExamDetailsId, System.String etdExamCode, System.Int64? etdSchoolId, System.Int64? etdSubjectId, System.String etdExamType, System.String etdTitle, System.String etdDescription, System.String etdExtra1, System.String etdTotalMarks, System.String etdPassingMarks, System.DateTime? etdDate, System.Int64? etdAddedById, System.String etdAddedByType, System.Int32? etdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSScholasticExamTestDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, etdExamDetailsId, etdExamCode, etdSchoolId, etdSubjectId, etdExamType, etdTitle, etdDescription, etdExtra1, etdTotalMarks, etdPassingMarks, etdDate, etdAddedById, etdAddedByType, etdStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetSearch(TMSScholasticExamTestDetails searchObject)
    {
        return GetSearch(searchObject.ETDExamDetailsId, searchObject.ETDExamCode, searchObject.ETDSchoolId, searchObject.ETDSubjectId, searchObject.ETDExamType, searchObject.ETDTitle, searchObject.ETDDescription, searchObject.ETDExtra1, searchObject.ETDTotalMarks, searchObject.ETDPassingMarks, searchObject.ETDDate, searchObject.ETDAddedById, searchObject.ETDAddedByType, searchObject.ETDStatus);
    }

    /// <summary>
    /// Returns all TMSScholasticExamTestDetails objects.
    /// </summary>
    /// <returns>List of all TMSScholasticExamTestDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }
    #endregion

    public static DataSet BindSearchScholasticExam(System.String Title, System.Int64? standard, System.Int64? subject, System.String examtype, System.Int64? ExamDetailID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSScholasticGetExamTestdetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Title, standard, subject, examtype, ExamDetailID);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }

    public static DataSet SearchScholasticExamination(System.Int64? assignId, System.Int64? schoolId, System.String schoolType, System.Int64? subjectId, System.String subjectName, System.Int64? departmentId, System.String examType, System.String examTestName, System.String InsertType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMSSearchScholasticExamination]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, assignId, schoolId, schoolType, subjectId, subjectName, departmentId, examType, examTestName, InsertType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSubjectDetails(System.Int64? schoolId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSGetSubjectDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, schoolId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet CheckExistExamTest(System.Int64? StudentID, System.Int64? MarksDetailsId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSCheckExistScholastic]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentID, MarksDetailsId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

