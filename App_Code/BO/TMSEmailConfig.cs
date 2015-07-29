using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSEmailConfig
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int32? econfigId, System.String econfigHost, System.String econfigUserName, System.String econfigPassword)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSEmailConfig_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, econfigId, econfigHost, econfigUserName, econfigPassword);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSEmailConfig searchObject)
    {
        return GetSearch(searchObject.EconfigId, searchObject.EconfigHost, searchObject.EconfigUserName, searchObject.EconfigPassword);
    }

    /// <summary>
    /// Returns all TMSEmailConfig objects.
    /// </summary>
    /// <returns>List of all TMSEmailConfig objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }

    #endregion
}

