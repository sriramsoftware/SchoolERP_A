using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSLeactureTimeDetails
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ltdTimeId, System.String ltdStartTime, System.String ltdEndTime, System.Int64? ltdSchoolCatId, System.Int64? ltdSubCategoryId, System.DateTime? ltdDate, System.Int32? ltdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSLeactureTimeDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ltdTimeId, ltdStartTime, ltdEndTime, ltdSchoolCatId, ltdSubCategoryId, ltdDate, ltdStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }


    public static DataSet GetSearch(TMSLeactureTimeDetails searchObject)
    {
        return GetSearch(searchObject.LTDTimeId, searchObject.LTDStartTime, searchObject.LTDEndTime, searchObject.LTDSchoolCatId, searchObject.LTDSubCategoryId, searchObject.LTDDate, searchObject.LTDStatus);
    }

    /// <summary>
    /// Returns all TMSLeactureTimeDetails objects.
    /// </summary>
    /// <returns>List of all TMSLeactureTimeDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet Getlecturartimedata(System.Int64? SchoolCatId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMTLecturerTimetable";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolCatId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetlecturarTimeperiode(System.Int64? SchoolCatId, System.Int64? SubCategoryId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFill_LectureTime";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolCatId, SubCategoryId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetSchoolWiseTimeTable(System.Int64? SchoolCatId, System.Int64? SubCategoryId, System.Int64? TimeId, System.String StartTime, System.String EndTime, System.String BothTime)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchTimeFromSchoolID";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolCatId, SubCategoryId, TimeId, StartTime, EndTime, BothTime);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #region Teacher Time-Table
    public static DataSet GetSearchTeacherTimeTable(System.Int64? facultyId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchFacultyTimeTableDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, facultyId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

    #region Student Time-Table
    public static DataSet GetSearchStudentTimeTable(System.Int64? studentId, System.Int64? studentLoginId, System.Int64? schoolId, System.Int64? schoolSubId, System.String days)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchStudentTimeTableDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, studentId, studentLoginId,schoolId, schoolSubId, days);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
}
