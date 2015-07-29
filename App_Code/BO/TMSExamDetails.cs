using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


public partial class TMSExamDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? edExamDetailsId, System.String edExamCode, System.Int64? edFacultyId, System.Int64? edFacultyLoginId, System.String edExamType, System.Int64? edUnitTestId, System.Int64? edSchoolId, System.Int64? edSchoolSubId, System.Int64? edSubjectId, System.Int64? edConductFacultyId, System.Int64? edDepartmentID, System.String edExtraDescription, System.String edClasstestTitle, System.String edExtra1, System.DateTime? edExamDate, System.String edStartTime, System.String edEndTime, System.String edExamFees, System.String edTotalMarks, System.String edPassingMarks, System.DateTime? edDate, System.Int32? edStatus, System.String edTitle, System.String edTitle1)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSExamDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, edExamDetailsId, edExamCode, edFacultyId, edFacultyLoginId, edExamType, edUnitTestId, edSchoolId, edSchoolSubId, edSubjectId, edConductFacultyId, edDepartmentID, edExtraDescription, edClasstestTitle, edExtra1, edExamDate, edStartTime, edEndTime, edExamFees, edTotalMarks, edPassingMarks, edDate, edStatus, edTitle, edTitle1);

        return db.ExecuteDataSet(dbCommand);
       
    }


    public static DataSet GetSearch(TMSExamDetails searchObject)
    {
        return GetSearch(searchObject.EDExamDetailsId, searchObject.EDExamCode, searchObject.EDFacultyId, searchObject.EDFacultyLoginId, searchObject.EDExamType, searchObject.EDUnitTestId, searchObject.EDSchoolId, searchObject.EDSchoolSubId, searchObject.EDSubjectId, searchObject.EDConductFacultyId, searchObject.EDDepartmentID, searchObject.EDExtraDescription, searchObject.EDClasstestTitle, searchObject.EDExtra1, searchObject.EDExamDate, searchObject.EDStartTime, searchObject.EDEndTime, searchObject.EDExamFees, searchObject.EDTotalMarks, searchObject.EDPassingMarks, searchObject.EDDate, searchObject.EDStatus, searchObject.EDTitle, searchObject.EDTitle1);
    }

    /// <summary>
    /// Returns all TMSExamDetails objects.
    /// </summary>
    /// <returns>List of all TMSExamDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    
    public static DataSet GetExamDetails()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetExamdetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetUnittestDetails(System.Int64? edExamDetailsId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gsmTMSrGetUnittestAccordingtoExamID";
        dbCommand = db.GetStoredProcCommand(sqlCommand, edExamDetailsId);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }




    public static DataSet GetCurricularexamDetails(System.Int64? edExamDetailsId, System.Int64? standerdId, System.Int64? unittestId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrCurricularExamDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, edExamDetailsId, standerdId, unittestId);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }



    public static DataSet GetMonthCalendar(System.Int32? month, System.Int32? year)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].spGetMonthCalendar";
        dbCommand = db.GetStoredProcCommand(sqlCommand, month, year);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet FIllClasstestDetails(System.Int32? month, System.Int32? year, System.Int64? subjectID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFIllClasstest";
        dbCommand = db.GetStoredProcCommand(sqlCommand, month, year, subjectID);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    
    public static DataSet FIllsubjectwisedetails(System.Int64? Faculty, System.Int64? standard, System.Int64? division, System.Int64? subject, System.Int32? month, System.Int32? year)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSfetchSubjectWisetest";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Faculty, standard, division, subject, month, year);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet Fill_ExtraCurriculardetails(System.String Title, System.Int64? standerd)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFill_ExtraCurriculardetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Title, standerd);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet Fill_SubjectAccordingToStandard(System.Int64? standerd)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFill_SubjectAccordingToStandard";
        dbCommand = db.GetStoredProcCommand(sqlCommand, standerd);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet BindExamData(System.Int64? FacultyId, System.Int64? standard, System.Int64? division, System.Int64? subject, System.String examtype, System.String schooltype)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspClassResult_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyId, standard, division, subject, examtype, schooltype);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }



    public static DataSet SearchExamsFilterWise(System.String examtype, System.String schooltype, System.Int64? standardId, System.Int64? divisionId, System.Int64? subjectId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetExamdetails_FilterWise";
        dbCommand = db.GetStoredProcCommand(sqlCommand, examtype, schooltype, standardId, divisionId, subjectId);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


}