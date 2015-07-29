using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSAttendanceDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? sadAttendancedId, System.Int64? sadFacultyId, System.Int64? sadStudentId, System.Int64? sadSchoolId, System.Int64? sadSchoolSubId, System.Int64? sadSubjectId, System.String sadMonth, System.String sadYear, System.String sadOneDate, System.String sadTwoDate, System.String sadThreeDate, System.String sadFourDate, System.String sadFiveDate, System.String sadSixDate, System.String sadSevenDate, System.String sadEightDate, System.String sadNineDate, System.String sadTenDate, System.String sadElevenDate, System.String sadTewelDate, System.String sadThirteenDate, System.String sadFourteenDate, System.String sadFifteenDate, System.String sadSixteenDate, System.String sadSeventeenDate, System.String sadEighteenDate, System.String sadNineteenDate, System.String sadTwentyDate, System.String sadTwentyOneDate, System.String sadTwentyTwoDate, System.String sadTwentyThreeDate, System.String sadTwentyFourDate, System.String sadTwentyFiveDate, System.String sadTwentySixDate, System.String sadTwentySevenDate, System.String sadTwentyEightDate, System.String sadTwentyNineDate, System.String sadThirtyDate, System.String sadThirtyOneDate, System.String sadAttendanceRemark, System.Int64? sadAttendanceBy, System.DateTime? sadDate, System.Int32? sadStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAttendanceDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sadAttendancedId, sadFacultyId, sadStudentId, sadSchoolId, sadSchoolSubId, sadSubjectId, sadMonth, sadYear, sadOneDate, sadTwoDate, sadThreeDate, sadFourDate, sadFiveDate, sadSixDate, sadSevenDate, sadEightDate, sadNineDate, sadTenDate, sadElevenDate, sadTewelDate, sadThirteenDate, sadFourteenDate, sadFifteenDate, sadSixteenDate, sadSeventeenDate, sadEighteenDate, sadNineteenDate, sadTwentyDate, sadTwentyOneDate, sadTwentyTwoDate, sadTwentyThreeDate, sadTwentyFourDate, sadTwentyFiveDate, sadTwentySixDate, sadTwentySevenDate, sadTwentyEightDate, sadTwentyNineDate, sadThirtyDate, sadThirtyOneDate, sadAttendanceRemark, sadAttendanceBy, sadDate, sadStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSAttendanceDetails searchObject)
    {
        return GetSearch(searchObject.SADAttendancedId, searchObject.SADFacultyId, searchObject.SADStudentId, searchObject.SADSchoolId, searchObject.SADSchoolSubId, searchObject.SADSubjectId, searchObject.SADMonth, searchObject.SADYear, searchObject.SADOneDate, searchObject.SADTwoDate, searchObject.SADThreeDate, searchObject.SADFourDate, searchObject.SADFiveDate, searchObject.SADSixDate, searchObject.SADSevenDate, searchObject.SADEightDate, searchObject.SADNineDate, searchObject.SADTenDate, searchObject.SADElevenDate, searchObject.SADTewelDate, searchObject.SADThirteenDate, searchObject.SADFourteenDate, searchObject.SADFifteenDate, searchObject.SADSixteenDate, searchObject.SADSeventeenDate, searchObject.SADEighteenDate, searchObject.SADNineteenDate, searchObject.SADTwentyDate, searchObject.SADTwentyOneDate, searchObject.SADTwentyTwoDate, searchObject.SADTwentyThreeDate, searchObject.SADTwentyFourDate, searchObject.SADTwentyFiveDate, searchObject.SADTwentySixDate, searchObject.SADTwentySevenDate, searchObject.SADTwentyEightDate, searchObject.SADTwentyNineDate, searchObject.SADThirtyDate, searchObject.SADThirtyOneDate, searchObject.SADAttendanceRemark, searchObject.SADAttendanceBy, searchObject.SADDate, searchObject.SADStatus);
    }

    /// <summary>
    /// Returns all TMSAttendanceDetails objects.
    /// </summary>
    /// <returns>List of all TMSAttendanceDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    #region Insert Attendance
    public static int GetSearchInsertAttendance(System.Int64? sadSchoolId, System.Int64? sadSchoolSubId, System.Int64? sadStudentId, System.String attendanceRemarks, System.String sadMonth, System.String sadYear, System.Int64? sadFacultyId, System.Int32? day, System.String attendanceStatus)
    {
        int i;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchInsertAttendanceRecord";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sadSchoolId, sadSchoolSubId, sadStudentId, attendanceRemarks, sadMonth, sadYear, sadFacultyId, day, attendanceStatus);

        i = Convert.ToInt32(db.ExecuteScalar(dbCommand));
        return i;
    }
    #endregion

    #region Insert Staff Attendance
    public static int GetSearchInsertStaffAttendance(System.Int64? sadSchoolId, System.Int64? sadSchoolSubId, System.Int64? sadStudentId, System.String attendanceRemarks, System.String sadMonth, System.String sadYear, System.Int64? sadFacultyId, System.Int32? day, System.String attendanceStatus)
    {
        int i;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchInsertStaffAttendanceRecord]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sadSchoolId, sadSchoolSubId, sadStudentId, attendanceRemarks, sadMonth, sadYear, sadFacultyId, day, attendanceStatus);

        i = Convert.ToInt32(db.ExecuteScalar(dbCommand));
        return i;
    }
    #endregion

    #region Student Time-Table
    public static DataSet GetSearchStudentAttendance(System.String Day, System.String Month, System.String Year, System.Int64? sadSchoolId, System.Int64? sadSchoolSubId, System.Int64? sadStudentId, System.Int64? FacultyId,System.String AttendanceType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchStudentMonthlyTimeTable";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Day, Month, Year, sadSchoolId, sadSchoolSubId, sadStudentId, FacultyId, AttendanceType);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

    #region Get Month Calendar
    public static DataSet GetMonthCalendar(System.Int32? Month, System.Int32? Year)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].spGetMonthCalendar";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Month, Year);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion


    #region GetAbsenties Last 1,3 or 6 Month
    public static DataSet GetSearchLastAbsenties(System.Int32? Month, System.Int64? FacultyLoginId, System.Int64? StudentLoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchLastThreeOrSixMonthAbsenties";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Month, FacultyLoginId, StudentLoginId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

    #region Principal Insert Attendance
    public static int GetSearchPrincipalInsertAttendance(System.Int64? sadSchoolId, System.Int64? sadSchoolSubId, System.Int64? sadFacultyLoginId, System.String attendanceRemarks, System.String sadMonth, System.String sadYear, System.Int64? sadFacultyId, System.Int32? day, System.String attendanceStatus)
    {
        int i;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchPrincipalInsertAttendanceRecord]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sadSchoolId, sadSchoolSubId, sadFacultyLoginId, attendanceRemarks, sadMonth, sadYear, sadFacultyId, day, attendanceStatus);
        i = Convert.ToInt32(db.ExecuteScalar(dbCommand));
        return i;
    }
    #endregion


    #region principal Time-Table
    public static DataSet GetSearchFacultyAttendance(System.String Day, System.String Month, System.String Year, System.Int64? sadSchoolId, System.Int64? sadSchoolSubId, System.Int64? FacultyLoginId, System.Int64? FacultyType, System.String AttendanceType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchPrincipalMonthlyTimeTable]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Day, Month, Year, sadSchoolId, sadSchoolSubId, FacultyLoginId, FacultyType, AttendanceType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion


    public static DataSet GetTeacherStatusMonthWise(System.String Day, System.String Month, System.String Year,System.String sadSchoolType, System.Int64? sadSchoolId, System.Int64? sadSchoolSubId, System.Int64? FacultyId,System.String Statusone,System.String Statustwo,System.String AttendanceType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchTeacherStatus";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Day, Month, Year,sadSchoolType ,sadSchoolId, sadSchoolSubId, FacultyId,Statusone ,Statustwo,AttendanceType);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
   
}

