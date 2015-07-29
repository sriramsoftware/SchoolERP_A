using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSEventsPhoto
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? phId, System.Int64? phGlid, System.String phTitle, System.String phImagePath, System.Int32? phStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSEventsPhoto_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, phId, phGlid, phTitle, phImagePath, phStatus);

       return ds = db.ExecuteDataSet(dbCommand);
        
    }


    public static DataSet GetSearch(TMSEventsPhoto searchObject)
    {
        return GetSearch(searchObject.PhId, searchObject.PhGlid, searchObject.PHTitle, searchObject.PHImagePath, searchObject.PHStatus);
    }

    /// <summary>
    /// Returns all TMSEventsPhoto objects.
    /// </summary>
    /// <returns>List of all TMSEventsPhoto objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null);
    }

    #endregion
}

