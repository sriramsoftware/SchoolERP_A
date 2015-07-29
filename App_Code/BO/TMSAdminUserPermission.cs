using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSAdminUserPermission
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int32? apId, System.Int32? apAdminId, System.String apPermission)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminUserPermission_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, apId, apAdminId, apPermission);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSAdminUserPermission searchObject)
    {
        return GetSearch(searchObject.APId, searchObject.APAdminId, searchObject.APPermission);
    }

    /// <summary>
    /// Returns all TMSAdminUserPermission objects.
    /// </summary>
    /// <returns>List of all TMSAdminUserPermission objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null);
    }

    #endregion
    #region Get Role Names
    public static DataSet GetRoleIdWise(string RoleId)
    {

        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminUserPermission_SEARCH_ByID";
        dbCommand = db.GetStoredProcCommand(sqlCommand, RoleId);

        return db.ExecuteDataSet(dbCommand);
    }
    #endregion
}

