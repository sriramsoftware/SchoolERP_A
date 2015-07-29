using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSManageBoard
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? scBoardId, System.String scBoardName, System.DateTime? scDate, System.Int32? scStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSManageBoard_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, scBoardId, scBoardName, scDate, scStatus);

        return db.ExecuteDataSet(dbCommand);
       
    }


    public static DataSet GetSearch(TMSManageBoard searchObject)
    {
        return GetSearch(searchObject.SCBoardId, searchObject.SCBoardName, searchObject.SCDate, searchObject.SCStatus);
    }

    /// <summary>
    /// Returns all TMSManageBoard objects.
    /// </summary>
    /// <returns>List of all TMSManageBoard objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }

    #endregion
}

