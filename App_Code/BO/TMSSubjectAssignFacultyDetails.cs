using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


public partial class TMSSubjectAssignFacultyDetails
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? safdAssignId, System.Int64? safdFacultyId, System.Int64? safdSubjectId, System.Int64? safdDepartmentId, System.String safdAssignType, System.DateTime? safdDate, System.Int32? safdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSubjectAssignFacultyDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, safdAssignId, safdFacultyId, safdSubjectId, safdDepartmentId, safdAssignType, safdDate, safdStatus);

        return db.ExecuteDataSet(dbCommand);
      
    }


    public static DataSet GetSearch(TMSSubjectAssignFacultyDetails searchObject)
    {
        return GetSearch(searchObject.SAFDAssignId, searchObject.SAFDFacultyId, searchObject.SAFDSubjectId, searchObject.SAFDDepartmentId, searchObject.SAFDAssignType, searchObject.SAFDDate, searchObject.SAFDStatus);
    }

    /// <summary>
    /// Returns all TMSSubjectAssignFacultyDetails objects.
    /// </summary>
    /// <returns>List of all TMSSubjectAssignFacultyDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet BindSubjectTeeacher(System.Int64? safdSubjectId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchSubjectAssignFaculty";
        dbCommand = db.GetStoredProcCommand(sqlCommand, safdSubjectId);
        return db.ExecuteDataSet(dbCommand);

    }

    public static DataSet GetFacultyDetails(System.Int64? Subject)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFillfacultyListAccordingToSubjectID";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Subject);
        return db.ExecuteDataSet(dbCommand);

    }
    public static DataSet GetSubjectFacultyDetails()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchSubjectAssignTeacherDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        return db.ExecuteDataSet(dbCommand);

    }

    public static DataSet BindDepartmentTeacher(System.Int64? safdDepartmentId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchDepartmentAssignFaculty";
        dbCommand = db.GetStoredProcCommand(sqlCommand, safdDepartmentId);
        return db.ExecuteDataSet(dbCommand);

    }

    public static DataSet GetFaculty(System.Int64? SchoolId, System.Int64? SchoolSubCategoryId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFetchfaculty";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolId, SchoolSubCategoryId);
        return db.ExecuteDataSet(dbCommand);

    }

    public static DataSet BindSubjectsOfTeacherAccordingToClass(System.Int64? FacultyLoginId, System.Int64? SchoolId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspBindSubjectsOfTeacherAccordingToClass";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyLoginId, SchoolId);
        return db.ExecuteDataSet(dbCommand);

    }


    public static DataSet BindFacultyAssignSchoolDetailList(System.Int64? SchoolId, System.Int64? FacultyLoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFacultyAssignSchoolDetailList";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolId, FacultyLoginId);
        return db.ExecuteDataSet(dbCommand);

    }

}

