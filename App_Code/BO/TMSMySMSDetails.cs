using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSMySMSDetails
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
        sqlCommand = "[dbo].gspTMSMySMSDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, mmdMessageId, mmdLoginId, mmdSenderId, mmdReceivedId, mmdReplyId, mmdMessageType, mmdMessageTitle, mmdMessageSubject, mmdDescription, mmdMessageText, mmdMessageRemarks, mmdReadStatus, mmdSendDate, mmdDate, mmdAddedByType, mmdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSMySMSDetails searchObject)
    {
        return GetSearch(searchObject.MMDMessageId, searchObject.MMDLoginId, searchObject.MMDSenderId, searchObject.MMDReceivedId, searchObject.MMDReplyId, searchObject.MMDMessageType, searchObject.MMDMessageTitle, searchObject.MMDMessageSubject, searchObject.MMDDescription, searchObject.MMDMessageText, searchObject.MMDMessageRemarks, searchObject.MMDReadStatus, searchObject.MMDSendDate, searchObject.MMDDate, searchObject.MMDAddedByType, searchObject.MMDStatus);
    }

    /// <summary>
    /// Returns all TMSMySMSDetails objects.
    /// </summary>
    /// <returns>List of all TMSMySMSDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet GetSearchAllSendMySMSData()
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
    public static DataSet GetFillViewSentSMS(System.String mmdMessageType, System.String MessageRemarks, System.String AddedByType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillViewSentSMS";
        dbCommand = db.GetStoredProcCommand(sqlCommand, mmdMessageType, MessageRemarks, AddedByType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetFillViewAllSentSMS(System.String mmdMessageType, System.String MessageRemarks, System.String AddedByType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillViewAllSentSMS";
        dbCommand = db.GetStoredProcCommand(sqlCommand, mmdMessageType, MessageRemarks, AddedByType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet FillSmsDetails(System.String Type)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillSmsDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Type);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

}

