using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSExamTestDetails
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? etdExamDetailsId, System.String etdExamCode, System.Int64? etdFacultyLoginId, System.Int64? etdSchoolId, System.Int64? etdSchoolSubId, System.Int64? etdSubjectId, System.Int64? etdDepartmentID, System.String etdExamType, System.String etdTitle, System.String etdDescription, System.String etdExtra1, System.DateTime? etdExamDate, System.String etdExamFees, System.String etdTotalMarks, System.String etdPassingMarks, System.DateTime? etdDate, System.Int32? etdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSExamTestDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, etdExamDetailsId, etdExamCode, etdFacultyLoginId, etdSchoolId, etdSchoolSubId, etdSubjectId, etdDepartmentID, etdExamType, etdTitle, etdDescription, etdExtra1, etdExamDate, etdExamFees, etdTotalMarks, etdPassingMarks, etdDate, etdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        ds.Tables[0].TableName = TABLE_NAME;
        return ds;
    }


    public static DataSet GetSearch(TMSExamTestDetails searchObject)
    {
        return GetSearch(searchObject.ETDExamDetailsId, searchObject.ETDExamCode, searchObject.ETDFacultyLoginId, searchObject.ETDSchoolId, searchObject.ETDSchoolSubId, searchObject.ETDSubjectId, searchObject.ETDDepartmentID, searchObject.ETDExamType, searchObject.ETDTitle, searchObject.ETDDescription, searchObject.ETDExtra1, searchObject.ETDExamDate, searchObject.ETDExamFees, searchObject.ETDTotalMarks, searchObject.ETDPassingMarks, searchObject.ETDDate, searchObject.ETDStatus);
    }

    /// <summary>
    /// Returns all TMSExamTestDetails objects.
    /// </summary>
    /// <returns>List of all TMSExamTestDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
    public static DataSet GetExamTestDetails()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrGetExamTestdetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet BindExamResultData(System.Int64? FacultyLginId, System.Int64? standard, System.Int64? division, System.Int64? subject, System.String examtype, System.String schooltype)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspClassExamResult_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyLginId, standard, division, subject, examtype, schooltype);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet BindSearchExamTestdetails(System.String Title, System.Int64? standard, System.Int64? subject, System.String examtype)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetSearchExamTestdetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Title, standard, subject, examtype);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet SearchTestWiseStudentSubjectAndMarksDetails(System.String examType, System.String testName, System.Int64? facultyLoginId, System.Int64? studentLoginId, System.Int64? schoolId, System.Int64? subSchoolId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSSearchTestWiseStudentSubjectMarksDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, examType, testName, facultyLoginId, studentLoginId, schoolId, subSchoolId);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet SearchSetExamination(System.Int64? assignId, System.Int64? schoolId, System.String schoolType, System.Int64? subjectId, System.String subjectName, System.Int64? departmentId, System.String examType, System.String examTestName, System.String InsertType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMSSearchSetExamination]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, assignId, schoolId, schoolType, subjectId, subjectName, departmentId, examType, examTestName, InsertType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet SearchSetExaminationTimeTable(System.Int64? assignId, System.Int64? schoolId, System.String schoolType, System.Int64? subjectId, System.String subjectName, System.Int64? departmentId, System.String examType, System.String examTestName, System.String InsertType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMSSearchSetExaminationTimeTable]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, assignId, schoolId, schoolType, subjectId, subjectName, departmentId, examType, examTestName, InsertType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet SearchStudentSubjectProgressTimeline(System.String examType, System.String testName, System.Int64? schoolId, System.Int64? studentLoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMSSearchStudentSubjectProgressTimeline]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, examType, testName, schoolId, studentLoginId);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet SearchTestBindChartStudentProgressTimeline(System.String examType, System.Int64? schoolId, System.Int64? studentLoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMSSearchTestBindStudentProgressTimeline]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, examType, schoolId, studentLoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetClassTestSubjectList(System.Int64? LoginID, System.String examType, System.Int64? schoolId, System.Int64? Division)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrGetClassTestWiseSubject]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginID, examType, schoolId, Division);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet SearchClassTestWiseStudentSubjectMarksDetails(System.String examType, System.Int64? SubjectID, System.Int64? studentLoginId, System.Int64? Standard, System.Int64? Division)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSSearchClassTestWiseStudentSubjectMarksDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, examType, SubjectID, studentLoginId, Standard, Division);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    //public static DataSet BindFillExamTestdetails(System.Int64? SchoolID, System.Int64? Subject, System.Int64? DepartMent, System.String Type)
    //{
    //    DataSet ds;
    //    Database db;
    //    string sqlCommand;
    //    DbCommand dbCommand;
    //    db = DatabaseFactory.CreateDatabase();
    //    sqlCommand = "[dbo].gspTMSrFillExamTestdetails";
    //    dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolID, Subject, DepartMent, Type);
    //    ds = db.ExecuteDataSet(dbCommand);
    //}


    public static DataSet BindFillExamTestdetails(System.Int64? SchoolID, System.Int64? Subject, System.Int64? DepartMent, System.String Type)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillExamTestdetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolID, Subject, DepartMent, Type);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet BindFillExamTimeTabledetails(System.Int64? SchoolID, System.Int64? Subject, System.Int64? DepartMentID, System.String Type1)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillExamTimeTabledetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolID, Subject, DepartMentID, Type1);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
}





