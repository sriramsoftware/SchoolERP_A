using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSExamTimeTable
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ettExamId, System.String ettExamCode, System.Int64? ettFacultyLoginId, System.String ettExamType, System.Int64? ettExamTestId, System.Int64? ettSchoolId, System.Int64? ettSchoolSubId, System.Int64? ettSubjectId, System.Int64? ettDepartmentID, System.String ettExtra1, System.DateTime? ettExamDate, System.String ettStartTime, System.String ettEndTime, System.Int64? ettAddedById, System.String ettAddedType, System.DateTime? ettDate, System.Int32? ettStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSExamTimeTable_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ettExamId, ettExamCode, ettFacultyLoginId, ettExamType, ettExamTestId, ettSchoolId, ettSchoolSubId, ettSubjectId, ettDepartmentID, ettExtra1, ettExamDate, ettStartTime, ettEndTime, ettAddedById, ettAddedType, ettDate, ettStatus);

        return  db.ExecuteDataSet(dbCommand);
        
    }


    public static DataSet GetSearch(TMSExamTimeTable searchObject)
    {
        return GetSearch(searchObject.ETTExamId, searchObject.ETTExamCode, searchObject.ETTFacultyLoginId, searchObject.ETTExamType, searchObject.ETTExamTestId, searchObject.ETTSchoolId, searchObject.ETTSchoolSubId, searchObject.ETTSubjectId, searchObject.ETTDepartmentID, searchObject.ETTExtra1, searchObject.ETTExamDate, searchObject.ETTStartTime, searchObject.ETTEndTime, searchObject.ETTAddedById, searchObject.ETTAddedType, searchObject.ETTDate, searchObject.ETTStatus);
    }

    /// <summary>
    /// Returns all TMSExamTimeTable objects.
    /// </summary>
    /// <returns>List of all TMSExamTimeTable objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    public static DataSet BindExamTests(System.Int64? facultyLoginId, System.Int64? schoolId, System.Int64? subSchoolId, System.Int64? subjectId ,System.Int64? departmentId, System.String examType, System.String schoolType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_BindExamTests]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, facultyLoginId, schoolId, subSchoolId, subjectId, departmentId, examType, schoolType);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet BindExamTestData(System.Int64? facultyLoginId, System.Int64? schoolId, System.Int64? subSchoolId, System.Int64? subjectId, System.Int64? departmentId, System.String examType, System.String schoolType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_BindExamTestData]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, facultyLoginId, schoolId, subSchoolId, subjectId, departmentId, examType, schoolType);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet BindAllTestandTime()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_BindAllTestandTime]";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet BindTimeTableAccordingToTest(System.Int64? facultyLoginId, System.Int64? schoolId, System.Int64? subSchoolId, System.Int64? subjectId, System.Int64? departmentId, System.String examType, System.Int64? addedby, System.String addedType, System.Int32? month, System.Int32? year)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_BindTimeTableAccordingToTest]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, facultyLoginId, schoolId, subSchoolId, subjectId, departmentId, examType,addedby,addedType,month,year);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet BindExamTimeTableForStudents(System.Int64? facultyLoginId, System.Int64? ExamTestId, System.Int64? schoolId, System.Int64? subSchoolId, System.Int64? subjectId, System.Int64? departmentId, System.String examType, System.Int64? addedby, System.String addedType, System.Int32? month, System.Int32? year)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_BindExamTimeTableForStudents]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, facultyLoginId, ExamTestId, schoolId, subSchoolId, subjectId, departmentId, examType, addedby, addedType, month, year);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet FillExaminationTime(System.String examType, System.Int64? Standard, System.Int64? Subject, System.Int64? UnitTest)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrFillExaminationTime]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, examType, Standard, Subject, UnitTest);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }

    public static DataSet BindGetSearchExamTimedetails(System.String Title, System.Int64? standard, System.Int64? subject, System.String examtype)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetSearchExamTimedetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Title, standard,subject, examtype);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
   
}

