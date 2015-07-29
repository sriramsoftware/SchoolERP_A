using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


public partial class TMSAdminUserOne
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int32? adminId, System.String adminFName, System.String adminLName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.DateTime? adminRegisteredDate, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminUserOne_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminId, adminFName, adminLName, adminEmailId, adminUserName, adminPassword, adminType, adminRegisteredDate, adminStatus, adminDeletedStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSAdminUserOne searchObject)
    {
        return GetSearch(searchObject.AdminId, searchObject.AdminFName, searchObject.AdminLName, searchObject.AdminEmailId, searchObject.AdminUserName, searchObject.AdminPassword, searchObject.AdminType, searchObject.AdminRegisteredDate, searchObject.AdminStatus, searchObject.AdminDeletedStatus);
    }

    /// <summary>
    /// Returns all TMSAdminUserOne objects.
    /// </summary>
    /// <returns>List of all TMSAdminUserOne objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    #region Get Admin EmailId Details At Update
    public static DataSet GetAdminUserDetails(System.String adminEmailId, System.Int32? adminId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSAdminUserOne_CheckEmailId_IsExistsOrNotAtUpdate";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminEmailId, adminId);

        return db.ExecuteDataSet(dbCommand);

    }
    #endregion


    #region Get Admin EmailId Details At Update
    public static DataSet GetAdminUserNameDetails(System.String adminUserName, System.Int32? adminId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSAdminUserOne_CheckUserName_IsExistsOrNotAtUpdate";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminUserName, adminId);

        return db.ExecuteDataSet(dbCommand);

    }
    #endregion
}

