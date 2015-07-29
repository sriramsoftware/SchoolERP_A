using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSMonth
{


    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet  GetSearch(System.Int64? mhID, System.String mhName, System.DateTime? mhDate, System.Int32? mhStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSMonth_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, mhID, mhName, mhDate, mhStatus);

        ds = db.ExecuteDataSet(dbCommand);
      
        return ds;
    }


    public static DataSet GetSearch(TMSMonth searchObject)
    {
        return GetSearch (searchObject.MhID, searchObject.MhName, searchObject.MhDate, searchObject.MhStatus);
    }

    /// <summary>
    /// Returns all TMSMonth objects.
    /// </summary>
    /// <returns>List of all TMSMonth objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }

    #endregion
}

