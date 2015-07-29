using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSAdminRole
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int32? arId, System.String arRole, System.Boolean? arStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminRole_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, arId, arRole, arStatus);

        return db.ExecuteDataSet(dbCommand);
        
    }

    public static DataSet GetSearch(TMSAdminRole searchObject)
    {
        return GetSearch(searchObject.ARId, searchObject.ARRole, searchObject.ARStatus);
    }
    /// <summary>
    /// Returns all TMSAdminRole objects.
    /// </summary>
    /// <returns>List of all TMSAdminRole objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null);
    }

    #endregion
}

