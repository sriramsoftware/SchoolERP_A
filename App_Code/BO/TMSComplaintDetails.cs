using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSComplaintDetails
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? cdComplaintId, System.Int64? cdSenderId, System.Int64? cdReceivedId, System.Int64? cdReplyID, System.String cdComplaintFor, System.String cdSubject, System.String cdDescription, System.Int64? cdStudentID, System.String cdSentTo, System.String cdExtra1, System.String cdExtra2, System.DateTime? cdDate, System.Int32? cdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSComplaintDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, cdComplaintId, cdSenderId, cdReceivedId, cdReplyID, cdComplaintFor, cdSubject, cdDescription, cdStudentID, cdSentTo, cdExtra1, cdExtra2, cdDate, cdStatus);

        ds = db.ExecuteDataSet(dbCommand);
       
        return  ds;
    }


    public static DataSet GetSearch(TMSComplaintDetails searchObject)
    {
        return GetSearch(searchObject.CDComplaintId, searchObject.CDSenderId, searchObject.CDReceivedId, searchObject.CDReplyID, searchObject.CDComplaintFor, searchObject.CDSubject, searchObject.CDDescription, searchObject.CDStudentID, searchObject.CDSentTo, searchObject.CDExtra1, searchObject.CDExtra2, searchObject.CDDate, searchObject.CDStatus);
    }

    /// <summary>
    /// Returns all TMSComplaintDetails objects.
    /// </summary>
    /// <returns>List of all TMSComplaintDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null);
    }



    public static DataSet FillParentsentApplication(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrParentComplaintSending";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet ParentComplaintInbox(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrParentComplaintInbox";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetCommunicationDetails(System.Int64? SenderID, System.Int64? ReceiverID, System.Int64? messageId)
    {

        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrComplaintThread]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SenderID, ReceiverID, messageId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }



    public static DataSet FillPrincipalComplaintInbox(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrPrincipalComplaintInbox";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }



    public static DataSet PrincipalComplaintSending(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrPrincipalComplaintSending";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetMyMessageParentInboxDetails(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrParentApplicationInbox";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetPriorityCount(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTmsrFillComplaintPriorityCount";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    #endregion
}

