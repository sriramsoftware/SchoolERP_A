using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSClassMonitorDetails
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? cmdMonitorId, System.Int64? cmdStudentId, System.Int64? cmdFacultyId, System.Int64? cmdSchoolId, System.Int64? cmdSchoolSubId, System.String cmdMonthName, System.String cmdYear, System.String cmdMonitorType, System.DateTime? cmdDate, System.Int32? cmdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSClassMonitorDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, cmdMonitorId, cmdStudentId, cmdFacultyId, cmdSchoolId, cmdSchoolSubId, cmdMonthName, cmdYear, cmdMonitorType, cmdDate, cmdStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetSearch(TMSClassMonitorDetails searchObject)
    {
        return GetSearch(searchObject.CMDMonitorId, searchObject.CMDStudentId, searchObject.CMDFacultyId, searchObject.CMDSchoolId, searchObject.CMDSchoolSubId, searchObject.CMDMonthName, searchObject.CMDYear, searchObject.CMDMonitorType, searchObject.CMDDate, searchObject.CMDStatus);
    }

    /// <summary>
    /// Returns all TMSClassMonitorDetails objects.
    /// </summary>
    /// <returns>List of all TMSClassMonitorDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null);
    }




    public static DataSet getmonitordetails(System.Int64? cmdSchoolId, System.Int64? cmdSchoolSubId, System.Int64? cmdFacultyId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchClassMonitors";
        dbCommand = db.GetStoredProcCommand(sqlCommand, cmdSchoolId, cmdSchoolSubId, cmdFacultyId);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }

    #endregion

    #region MonitorDetails
    public static DataSet GetSerachMonitorDetails(System.String month, System.String year, System.Int64? cmdSchoolId, System.Int64? cmdSchoolSubId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSSearchMonitorDetailsPerMonth";
        dbCommand = db.GetStoredProcCommand(sqlCommand,month,year, cmdSchoolId, cmdSchoolSubId);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    #endregion

    #region MonitorTypeDetails
    public static DataSet GetSerachClassMonitorTypeDetails(System.String month, System.String year, System.String monitorType, System.Int64? cmdSchoolId, System.Int64? cmdSchoolSubId, System.Int64? studentLoginId, System.Int64? facultyLoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSSearchClassMonitorTypeData";
        dbCommand = db.GetStoredProcCommand(sqlCommand, month, year,monitorType, cmdSchoolId, cmdSchoolSubId,studentLoginId,facultyLoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

}

