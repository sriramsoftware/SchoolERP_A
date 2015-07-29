using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


public partial class TMSSubjectDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? sdSubjectId, System.String sdSubjectName, System.DateTime? sdDate, System.Int32? sdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSubjectDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sdSubjectId, sdSubjectName, sdDate, sdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }


    public static DataSet GetSearch(TMSSubjectDetails searchObject)
    {
        return GetSearch(searchObject.SDSubjectId, searchObject.SDSubjectName, searchObject.SDDate, searchObject.SDStatus);
    }

    /// <summary>
    /// Returns all TMSSubjectDetails objects.
    /// </summary>
    /// <returns>List of all TMSSubjectDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }
    public static DataSet Getsubject(System.Int64? FacultyId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillSubject";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }



    #endregion

    public static DataSet GetSearchSchoolSubjectWiseTeacher(System.Int64? sdSubjectId, System.String sdSubjectName, System.Int64? facultyId, System.Int64? facultyLoginId, System.Int64? SchoolId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchSubjectSchoolWiseTeacher";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sdSubjectId, sdSubjectName, facultyId,facultyLoginId, SchoolId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
  

    public static DataSet GetfacultyAccordingtodepartment(System.Int64? sdSubjectId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFetchFacultyaccordingtodepartment";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sdSubjectId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
}

