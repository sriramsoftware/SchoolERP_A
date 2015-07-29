using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSNews
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? nwId, System.String ndHeading, System.String ndImagePath, System.String ndDescription, System.DateTime? ndCreatedDate, System.Int32? ndStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSNews_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, nwId, ndHeading, ndImagePath, ndDescription, ndCreatedDate, ndStatus);

        return ds = db.ExecuteDataSet(dbCommand);

    }
    public static DataSet GetLatestNews(System.Int64? nwId, System.String ndHeading, System.String ndImagePath, System.String ndDescription, System.DateTime? ndCreatedDate, System.Int32? ndStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSNews_GetLatestNews_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, nwId, ndHeading, ndImagePath, ndDescription, ndCreatedDate, ndStatus);

        return ds = db.ExecuteDataSet(dbCommand);

    }


    public static DataSet GetSearch(TMSNews searchObject)
    {
        return GetSearch(searchObject.NwId, searchObject.NDHeading, searchObject.NDImagePath, searchObject.NDDescription, searchObject.NDCreatedDate, searchObject.NDStatus);
    }

    /// <summary>
    /// Returns all TMSNews objects.
    /// </summary>
    /// <returns>List of all TMSNews objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null);
    }


    public static DataSet GettopNews()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMTopSNews";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        return ds = db.ExecuteDataSet(dbCommand);

    }

    #endregion
}

