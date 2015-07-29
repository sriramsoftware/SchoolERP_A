using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSPrivilegeLink
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? plLinkId, System.String plLinkType, System.String plLinkName, System.String plSubLinkName, System.DateTime? plDate, System.Int32? plStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSPrivilegeLink_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, plLinkId, plLinkType, plLinkName, plSubLinkName, plDate, plStatus);

        return db.ExecuteDataSet(dbCommand);
      
    }


    public static DataSet GetSearch(TMSPrivilegeLink searchObject)
    {
        return GetSearch(searchObject.PLLinkId, searchObject.PLLinkType, searchObject.PLLinkName, searchObject.PLSubLinkName, searchObject.PLDate, searchObject.PLStatus);
    }

    /// <summary>
    /// Returns all TMSPrivilegeLink objects.
    /// </summary>
    /// <returns>List of all TMSPrivilegeLink objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null);
    }

    #endregion

    public static DataSet GetSearchIsExist(System.Int64? LinkId, System.String LinkType, System.String LinkName)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSPriviledge_IsLinkExistSEARCH]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LinkId,LinkType,LinkName);
        return db.ExecuteDataSet(dbCommand);
    }
}

