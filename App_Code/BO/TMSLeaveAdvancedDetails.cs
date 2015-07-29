using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSLeaveAdvancedDetails
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ladDetailsId, System.Int64? ladLeaveDetailId, System.Int64? ladFacultyLoginId, System.String ladFacultyType, System.String ladLeaveType, System.Int32? ladJan, System.Int32? ladFeb, System.Int32? ladMar, System.Int32? ladApr, System.Int32? ladMay, System.Int32? ladJune, System.Int32? ladJuly, System.Int32? ladAug, System.Int32? ladSep, System.Int32? ladOct, System.Int32? ladNov, System.Int32? ladDec, System.DateTime? ladDate, System.Int32? ladStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSLeaveAdvancedDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ladDetailsId, ladLeaveDetailId, ladFacultyLoginId, ladFacultyType, ladLeaveType, ladJan, ladFeb, ladMar, ladApr, ladMay, ladJune, ladJuly, ladAug, ladSep, ladOct, ladNov, ladDec, ladDate, ladStatus);

        ds = db.ExecuteDataSet(dbCommand);
       
        return ds;
    }


    public static DataSet GetSearch(TMSLeaveAdvancedDetails searchObject)
    {
        return GetSearch(searchObject.LADDetailsId, searchObject.LADLeaveDetailId, searchObject.LADFacultyLoginId, searchObject.LADFacultyType, searchObject.LADLeaveType, searchObject.LADJan, searchObject.LADFeb, searchObject.LADMar, searchObject.LADApr, searchObject.LADMay, searchObject.LADJune, searchObject.LADJuly, searchObject.LADAug, searchObject.LADSep, searchObject.LADOct, searchObject.LADNov, searchObject.LADDec, searchObject.LADDate, searchObject.LADStatus);
    }

    /// <summary>
    /// Returns all TMSLeaveAdvancedDetails objects.
    /// </summary>
    /// <returns>List of all TMSLeaveAdvancedDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }



    public static DataSet NumGet(System.Int32? ladDetailsId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillAcoountddl";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ladDetailsId);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet FillAdvaceLeave(System.Int64? ladLeaveDetailId, System.Int64? FacultyID, System.String LeaveType, System.String FacultyType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillAdvaceLeave";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ladLeaveDetailId, FacultyID, LeaveType, FacultyType);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    

    #endregion
}

