
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSLeacturedDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ldLeacturedDetailsId, System.Int64? ldSubjectId, System.Int64? ldFacultyId, System.Int64? ldSchoolCatId, System.Int64? ldSubSchoolCatId, System.String ldWeekDays, System.Int64? ldLeactureTimeId, System.String ldExtra1, System.DateTime? ldDate, System.Int32? ldStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSLeacturedDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ldLeacturedDetailsId, ldSubjectId, ldFacultyId, ldSchoolCatId, ldSubSchoolCatId, ldWeekDays, ldLeactureTimeId, ldExtra1, ldDate, ldStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetSearch(TMSLeacturedDetails searchObject)
    {
        return GetSearch(searchObject.LDLeacturedDetailsId, searchObject.LDSubjectId, searchObject.LDFacultyId, searchObject.LDSchoolCatId, searchObject.LDSubSchoolCatId, searchObject.LDWeekDays, searchObject.LDLeactureTimeId, searchObject.LDExtra1, searchObject.LDDate, searchObject.LDStatus);
    }

    /// <summary>
    /// Returns all TMSLeacturedDetails objects.
    /// </summary>
    /// <returns>List of all TMSLeacturedDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null);
    }



    public static DataSet GetTimetableData()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFillManagetimetable";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetTime()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gsptmsGetstatrendtimeFortimetable";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearchTimeTableDetails(System.Int64? schoolId, System.Int64? subSchoolId, System.String ldWeekDays)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchTimeTableDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, schoolId, subSchoolId, ldWeekDays);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetSearchTimeTableDetailsNew(System.Int64? schoolId, System.Int64? subSchoolId, System.String ldWeekDays,System.String SchoolType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchTimeTableDetailsNew]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, schoolId, subSchoolId, ldWeekDays, SchoolType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetSearchSubjectWIthTeacherDetails(System.Int64? schoolId, System.Int64? subSchoolId, System.String subjectWithTeacher, System.Int64? facultyId, System.Int64? facultyLoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchSubjectWithTeacherDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, schoolId,subSchoolId, subjectWithTeacher, facultyId, facultyLoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetTimetableSerch(System.Int64? schoolId, System.Int64? subSchoolId, System.Int64? facultyId, System.Int64? SubjectID, System.String days)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillTimetableSerch";
        dbCommand = db.GetStoredProcCommand(sqlCommand, schoolId, subSchoolId, facultyId, SubjectID, days);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
}

