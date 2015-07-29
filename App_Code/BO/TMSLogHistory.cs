using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSLogHistory
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? lhHistoryId, System.Int64? lhFacultyLoginId, System.String lhLoginType, System.String lhLogType, System.String lhActivityDo, System.DateTime? lhStartTime, System.DateTime? lhEndTime, System.Int64? lhAddedById, System.DateTime? lhDate, System.Int32? lhStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSLogHistory_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, lhHistoryId, lhFacultyLoginId, lhLoginType, lhLogType, lhActivityDo, lhStartTime, lhEndTime, lhAddedById, lhDate, lhStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSLogHistory searchObject)
    {
        return GetSearch(searchObject.LHHistoryId, searchObject.LHFacultyLoginId, searchObject.LHLoginType, searchObject.LHLogType, searchObject.LHActivityDo, searchObject.LHStartTime, searchObject.LHEndTime, searchObject.LHAddedById, searchObject.LHDate, searchObject.LHStatus);
    }

    /// <summary>
    /// Returns all TMSLogHistory objects.
    /// </summary>
    /// <returns>List of all TMSLogHistory objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

