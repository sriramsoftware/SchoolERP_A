using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSTitleType
{


    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ttTitleId, System.String ttTitleName, System.Int32? ttStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSTitleType_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ttTitleId, ttTitleName, ttStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetSearch(TMSTitleType searchObject)
    {
        return GetSearch(searchObject.TTTitleId, searchObject.TTTitleName, searchObject.TTStatus);
    }

    /// <summary>
    /// Returns all TMSTitleType objects.
    /// </summary>
    /// <returns>List of all TMSTitleType objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null);
    }

    #endregion

}

