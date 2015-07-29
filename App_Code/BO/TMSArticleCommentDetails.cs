using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSArticleCommentDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? acdCommentId, System.Int64? acdArticleId, System.Int64? acdLoginId, System.String acdLoginType, System.String acdCommentText, System.String acdMessage, System.Int64? acdReplyId, System.String acdApprovedStatus, System.Int64? acdApproveById, System.String acdApproveByType, System.DateTime? acdDate, System.Int32? acdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSArticleCommentDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, acdCommentId, acdArticleId, acdLoginId, acdLoginType, acdCommentText, acdMessage, acdReplyId, acdApprovedStatus, acdApproveById, acdApproveByType, acdDate, acdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSArticleCommentDetails searchObject)
    {
        return GetSearch(searchObject.ACDCommentId, searchObject.ACDArticleId, searchObject.ACDLoginId, searchObject.ACDLoginType, searchObject.ACDCommentText, searchObject.ACDMessage, searchObject.ACDReplyId, searchObject.ACDApprovedStatus, searchObject.ACDApproveById, searchObject.ACDApproveByType, searchObject.ACDDate, searchObject.ACDStatus);
    }

    /// <summary>
    /// Returns all TMSArticleCommentDetails objects.
    /// </summary>
    /// <returns>List of all TMSArticleCommentDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet GetSearchCommentDetails()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSSearchCommentDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

