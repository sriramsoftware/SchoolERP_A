using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSWorkToDo
{


    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? wdId, System.String wdTitle, System.String wdReason, System.String wdPriority, System.DateTime? wdWorkDate, System.String wdTime, System.String wdWorkStatus, System.String wdExtra, System.DateTime? wdDate, System.Int32? wdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSWorkToDo_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, wdId, wdTitle, wdReason, wdPriority, wdWorkDate, wdTime, wdWorkStatus, wdExtra, wdDate, wdStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetSearch(TMSWorkToDo searchObject)
    {
        return GetSearch(searchObject.WdId, searchObject.WDTitle, searchObject.WDReason, searchObject.WDPriority, searchObject.WDWorkDate, searchObject.WDTime, searchObject.WDWorkStatus, searchObject.WDExtra, searchObject.WDDate, searchObject.WDStatus);
    }
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

