using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSPhotoGalleryTitles
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? glId, System.String glTitle, System.String glImagePath, System.DateTime? glEventDate, System.Int32? glStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSPhotoGalleryTitles_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, glId, glTitle, glImagePath, glEventDate, glStatus);

    return    ds = db.ExecuteDataSet(dbCommand);
       
    }


    public static DataSet GetSearch(TMSPhotoGalleryTitles searchObject)
    {
        return GetSearch(searchObject.GlId, searchObject.GLTitle, searchObject.GLImagePath, searchObject.GLEventDate, searchObject.GLStatus);
    }

    /// <summary>
    /// Returns all TMSPhotoGalleryTitles objects.
    /// </summary>
    /// <returns>List of all TMSPhotoGalleryTitles objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null);
    }

    #endregion

    #region  Delete SubThumnails

    public static DataSet DeleteSubThumbNails(System.Int64? ThumNailId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSEventsSubThumbNailDelete]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ThumNailId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }

    #endregion

}

