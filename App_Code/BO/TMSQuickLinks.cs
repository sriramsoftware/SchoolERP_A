using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSQuickLinks
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int32? qlId, System.String qlRole, System.String qlImage, System.String qlPageName, System.Boolean? qlStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSQuickLinks_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, qlId, qlRole, qlImage, qlPageName, qlStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSQuickLinks searchObject)
    {
        return GetSearch(searchObject.QLId, searchObject.QLRole, searchObject.QLImage, searchObject.QLPageName, searchObject.QLStatus);
    }

    /// <summary>
    /// Returns all TMSQuickLinks objects.
    /// </summary>
    /// <returns>List of all TMSQuickLinks objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null);
    }

    #endregion
}

