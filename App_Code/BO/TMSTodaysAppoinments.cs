using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSTodaysAppoinments
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet  GetSearch(System.Int64? taId, System.Int64? taTitleType, System.String taTitle, System.String taWhomeTo, System.String taReason, System.String taPriority, System.DateTime? taAppointMentDate, System.String taTime, System.String taAppointMentStatus, System.String taExtra, System.DateTime? taDate, System.Int32? taStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSTodaysAppoinments_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, taId, taTitleType, taTitle, taWhomeTo, taReason, taPriority, taAppointMentDate, taTime, taAppointMentStatus, taExtra, taDate, taStatus);

        ds = db.ExecuteDataSet(dbCommand);
       
        return ds;
    }


    public static DataSet GetSearch(TMSTodaysAppoinments searchObject)
    {
        return GetSearch(searchObject.TaId, searchObject.TATitleType, searchObject.TATitle, searchObject.TAWhomeTo, searchObject.TAReason, searchObject.TAPriority, searchObject.TAAppointMentDate, searchObject.TATime, searchObject.TAAppointMentStatus, searchObject.TAExtra, searchObject.TADate, searchObject.TAStatus);
    }

    /// <summary>
    /// Returns all TMSTodaysAppoinments objects.
    /// </summary>
    /// <returns>List of all TMSTodaysAppoinments objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null);
    }



    public static DataSet FillTodaysAppointMent(System.DateTime? taDate)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillTodaysAppointMent";
        dbCommand = db.GetStoredProcCommand(sqlCommand,  taDate);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }




    public static DataSet BindTodaysAppoinmentsSEARCH(System.Int64? taId, System.String taTitle, System.String taWhomeTo, System.String taPriority, System.DateTime? taAppointMentDate, System.String taAppointMentStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrBindTodaysAppoinmentsSEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, taId, taTitle, taWhomeTo, taPriority, taAppointMentDate, taAppointMentStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
}

