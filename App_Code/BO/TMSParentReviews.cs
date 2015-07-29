using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSParentReviews
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? prReviewsId, System.Int64? prLoginId, System.Int64? prSenderId, System.Int64? prReceivedId, System.Int64? prReplyId, System.Int64? prReviewCount, System.String prReviewType, System.String prReviewTitle, System.String prReviewSubject, System.String prDescription, System.String prReviewText, System.String prReviewRemarks, System.Int32? prReadStatus, System.DateTime? prSendDate, System.DateTime? prDate, System.Int32? prStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSParentReviews_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, prReviewsId, prLoginId, prSenderId, prReceivedId, prReplyId, prReviewCount, prReviewType, prReviewTitle, prReviewSubject, prDescription, prReviewText, prReviewRemarks, prReadStatus, prSendDate, prDate, prStatus);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetSearch(TMSParentReviews searchObject)
    {
        return GetSearch(searchObject.PRReviewsId, searchObject.PRLoginId, searchObject.PRSenderId, searchObject.PRReceivedId, searchObject.PRReplyId, searchObject.PRReviewCount, searchObject.PRReviewType, searchObject.PRReviewTitle, searchObject.PRReviewSubject, searchObject.PRDescription, searchObject.PRReviewText, searchObject.PRReviewRemarks, searchObject.PRReadStatus, searchObject.PRSendDate, searchObject.PRDate, searchObject.PRStatus);
    }

    /// <summary>
    /// Returns all TMSParentReviews objects.
    /// </summary>
    /// <returns>List of all TMSParentReviews objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion



    public static DataSet GetSearchAllReviewData()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchAllReviewData";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetMyReviewsInboxDetails(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchReviewsInboxDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }





    public static DataSet GetMySentReviewsDetails(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchReviewDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }



    public static DataSet GetAllReviewsDetailForPrincipal(System.Int64? ReviewsId, System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].GetAllPrincipalReviews";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ReviewsId, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }




    public static DataSet GetReviewStatusDetails(System.Int64? LoginId,System.String prReviewTitle)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGetReviewStatus";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId, prReviewTitle);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

}

