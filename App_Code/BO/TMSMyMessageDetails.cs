using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSMyMessageDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? mmdMessageId, System.Int64? mmdLoginId, System.Int64? mmdSenderId, System.Int64? mmdReceivedId, System.Int64? mmdReplyId, System.String mmdMessageType, System.String mmdMessageTitle, System.String mmdMessageSubject, System.String mmdDescription, System.String mmdMessageText, System.String mmdMessageRemarks, System.Int32? mmdReadStatus, System.DateTime? mmdSendDate, System.DateTime? mmdDate, System.String mmdAddedByType, System.Int32? mmdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSMyMessageDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, mmdMessageId, mmdLoginId, mmdSenderId, mmdReceivedId, mmdReplyId, mmdMessageType, mmdMessageTitle, mmdMessageSubject, mmdDescription, mmdMessageText, mmdMessageRemarks, mmdReadStatus, mmdSendDate, mmdDate, mmdAddedByType, mmdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSMyMessageDetails searchObject)
    {
        return GetSearch(searchObject.MMDMessageId, searchObject.MMDLoginId, searchObject.MMDSenderId, searchObject.MMDReceivedId, searchObject.MMDReplyId, searchObject.MMDMessageType, searchObject.MMDMessageTitle, searchObject.MMDMessageSubject, searchObject.MMDDescription, searchObject.MMDMessageText, searchObject.MMDMessageRemarks, searchObject.MMDReadStatus, searchObject.MMDSendDate, searchObject.MMDDate, searchObject.MMDAddedByType, searchObject.MMDStatus);
    }

    /// <summary>
    /// Returns all TMSMyMessageDetails objects.
    /// </summary>
    /// <returns>List of all TMSMyMessageDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet GetSearchAllSendMyMessageData()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchAllCommunicationData";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetMyMessageInboxDetails(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchMyMessageInboxDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand,LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetMySentMessageDetails(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchMySentMessageDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static int GetInboxCount(System.Int64? userId)
    {

        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMSMyMessageDetails_GetInboxCount]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, userId);
        return Convert.ToInt32(db.ExecuteScalar(dbCommand));
    }

    public static DataSet GetCommunicationDetails(System.Int64? messageId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchCommunicationDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, messageId);
       ds = db.ExecuteDataSet(dbCommand);
       return ds;
    }

    public static DataSet GetMessageDetailsFilterWise(System.Int64? MessageId, System.Int64? LoginId, System.Int64? SenderId, System.Int64? ReceivedId, System.Int64? ReplyId, System.Int32? ReadStatus, System.String AddedType, System.DateTime? SendDate, System.DateTime? Date, System.String MessageType, System.String MessageRemark)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSMyMessageDetails_SearchFilterWise]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, MessageId, LoginId, SenderId, ReceivedId, ReplyId, ReadStatus, AddedType, SendDate, Date, MessageType, MessageRemark);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    } 
}

