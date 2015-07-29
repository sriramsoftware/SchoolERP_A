using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSSubMenu
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int32? subId, System.Int32? subParentId, System.String subContent, System.String subUrl)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSubMenu_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, subId, subParentId, subContent, subUrl);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSSubMenu searchObject)
    {
        return GetSearch(searchObject.SubId, searchObject.SubParentId, searchObject.SubContent, searchObject.SubUrl);
    }

    /// <summary>
    /// Returns all TMSSubMenu objects.
    /// </summary>
    /// <returns>List of all TMSSubMenu objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }

    #endregion
}

