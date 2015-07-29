using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSArticleDetails
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? adDetailId, System.Int64? adLoginId, System.String adLoginType, System.String adTitle, System.String adSubTitle, System.String adImage, System.String adDescription, System.Int64? adAddedById, System.String adAddedByType, System.DateTime? adDate, System.Int32? adStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSArticleDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adDetailId, adLoginId, adLoginType, adTitle, adSubTitle, adImage, adDescription, adAddedById, adAddedByType, adDate, adStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetSearch(TMSArticleDetails searchObject)
    {
        return GetSearch(searchObject.ADDetailId, searchObject.ADLoginId, searchObject.ADLoginType, searchObject.ADTitle, searchObject.ADSubTitle, searchObject.ADImage, searchObject.ADDescription, searchObject.ADAddedById, searchObject.ADAddedByType, searchObject.ADDate, searchObject.ADStatus);
    }

    /// <summary>
    /// Returns all TMSArticleDetails objects.
    /// </summary>
    /// <returns>List of all TMSArticleDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

