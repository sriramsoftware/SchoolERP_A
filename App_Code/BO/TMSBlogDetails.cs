using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSBlogDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? bdBlogId, System.Int64? bdParentLoginId, System.Int64? bdFacultyLoginId, System.String bdTitle, System.String bdDescription, System.String bdImage, System.Int64? bdReplyId, System.DateTime? bdDate, System.Int32? bdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBlogDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, bdBlogId, bdParentLoginId, bdFacultyLoginId, bdTitle, bdDescription, bdImage, bdReplyId, bdDate, bdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSBlogDetails searchObject)
    {
        return GetSearch(searchObject.BDBlogId, searchObject.BDParentLoginId, searchObject.BDFacultyLoginId, searchObject.BDTitle, searchObject.BDDescription, searchObject.BDImage, searchObject.BDReplyId, searchObject.BDDate, searchObject.BDStatus);
    }

    /// <summary>
    /// Returns all TMSBlogDetails objects.
    /// </summary>
    /// <returns>List of all TMSBlogDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet GetMyBlogDetails(System.Int64? facultyLoginId, System.Int64? parentLoginId, System.Int64? replyId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchMyBlogDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, facultyLoginId,parentLoginId,replyId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetMyBlogReplyDetails(System.Int64? facultyLoginId, System.Int64? parentLoginId, System.Int64? replyId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchMyBlogReplyDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, facultyLoginId, parentLoginId, replyId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

}

