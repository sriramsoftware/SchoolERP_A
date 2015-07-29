using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSHomeWorkDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? hwdHomeWorkId, System.Int64? hwdFacultyId, System.Int64? hwdFacultyLoginId, System.Int64? hwdSchoolId, System.Int64? hwdSchoolSubId, System.Int64? hwdSubjectId, System.String hwdTitle, System.String hwdDescription, System.DateTime? hwdSubmitDate, System.DateTime? hwdDate, System.Int32? hwdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSHomeWorkDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, hwdHomeWorkId, hwdFacultyId, hwdFacultyLoginId, hwdSchoolId, hwdSchoolSubId, hwdSubjectId, hwdTitle, hwdDescription, hwdSubmitDate, hwdDate, hwdStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSearch(TMSHomeWorkDetails searchObject)
    {
        return GetSearch(searchObject.HWDHomeWorkId, searchObject.HWDFacultyId, searchObject.HWDFacultyLoginId, searchObject.HWDSchoolId, searchObject.HWDSchoolSubId, searchObject.HWDSubjectId, searchObject.HWDTitle, searchObject.HWDDescription, searchObject.HWDSubmitDate, searchObject.HWDDate, searchObject.HWDStatus);
    }

    /// <summary>
    /// Returns all TMSHomeWorkDetails objects.
    /// </summary>
    /// <returns>List of all TMSHomeWorkDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    #region Search HomeWork Details For Teacher
    public static DataSet GetSearchHomeWorkDetails(System.Int64? hwdHomeWorkId, System.Int64? hwdFacultyId, System.Int64? hwdFacultyLoginId, System.Int64? hwdSubjectId, System.Int64? hwdSchoolId, System.Int64? hwdSchoolSubId, System.String hwdFacultyName, System.String hwdSubjectName, System.DateTime? hwdAssignFromDate, System.DateTime? hwdAssignToDate, System.DateTime? hwdSubmitFromDate, System.DateTime? hwdSubmitToDate)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchHomeWorkDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, hwdHomeWorkId, hwdFacultyId, hwdFacultyLoginId, hwdSubjectId, hwdSchoolId, hwdSchoolSubId, hwdFacultyName, hwdSubjectName, hwdAssignFromDate, hwdAssignToDate, hwdSubmitFromDate, hwdSubmitToDate);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

    #region Search HomeWork Details StandardWise
    public static DataSet SearchHomeWorkDetailsStandardWise(System.Int64? hwdSubjectId, System.Int64? hwdSchoolId, System.Int64? hwdSchoolSubId, System.DateTime? hwdAssignFromDate, System.DateTime? hwdAssignToDate, System.DateTime? hwdSubmitFromDate, System.DateTime? hwdSubmitToDate)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_HomeWorkDetails_StandardWise";
        dbCommand = db.GetStoredProcCommand(sqlCommand,hwdSubjectId,hwdSchoolId,hwdSchoolSubId,hwdAssignFromDate,hwdAssignToDate,hwdSubmitFromDate,hwdSubmitToDate);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
}

