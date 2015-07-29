
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSApplicationDetails
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? adApplicationId, System.Int64? adSenderId, System.Int64? adReceivedId, System.Int64? adReplyID, System.String adApplicationFor, System.String adSubject, System.String adDescription, System.DateTime? adLeaveFromDate, System.DateTime? adLeaveToDate, System.DateTime? adDate, System.Int32? adStatus, System.Int64? adMinitorID, System.String adSentTo, System.String adExtra1, System.String adExtra2, System.String adCasualLeave, System.String adPaidLeave, System.String adSickLeave, System.String adEarnedLeave, System.String adOtherLeave, System.String adApproveStatus, System.Int64? adApproveByID, System.String adApproveByType, System.DateTime? adApproveDate)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSApplicationDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adApplicationId, adSenderId, adReceivedId, adReplyID, adApplicationFor, adSubject, adDescription, adLeaveFromDate, adLeaveToDate, adDate, adStatus, adMinitorID, adSentTo, adExtra1, adExtra2, adCasualLeave, adPaidLeave, adSickLeave, adEarnedLeave, adOtherLeave, adApproveStatus, adApproveByID, adApproveByType, adApproveDate);

        ds = db.ExecuteDataSet(dbCommand);
       
        return  ds;
    }


    public static DataSet GetSearch(TMSApplicationDetails searchObject)
    {
        return GetSearch(searchObject.ADApplicationId, searchObject.ADSenderId, searchObject.ADReceivedId, searchObject.ADReplyID, searchObject.ADApplicationFor, searchObject.ADSubject, searchObject.ADDescription, searchObject.ADLeaveFromDate, searchObject.ADLeaveToDate, searchObject.ADDate, searchObject.ADStatus, searchObject.ADMinitorID, searchObject.ADSentTo, searchObject.ADExtra1, searchObject.ADExtra2, searchObject.ADCasualLeave, searchObject.ADPaidLeave, searchObject.ADSickLeave, searchObject.ADEarnedLeave, searchObject.ADOtherLeave, searchObject.ADApproveStatus, searchObject.ADApproveByID, searchObject.ADApproveByType, searchObject.ADApproveDate);
    }

    /// <summary>
    /// Returns all TMSApplicationDetails objects.
    /// </summary>
    /// <returns>List of all TMSApplicationDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    public static DataSet GetMyMessageInboxDetails(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrTeacherApplicationInbox";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
     public static DataSet GetMyMessageStaffInboxDetails(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrStaffApplicationInbox";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    

    public static DataSet GetMyMessageStudentInboxDetails(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrstudentApplicationInbox";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetMyMessagePrincipalInboxDetails(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrprincipalApplicationInbox";
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
        sqlCommand = "[dbo].[gspTMSrApplicationThread]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SenderID, ReceiverID, messageId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet FillsentApplication(System.Int64? ID, System.String adSubject)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillsentApplication";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ID, adSubject);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    //public static int ContactUS(System.String Name, System.String Email, System.String Phone, System.String Subject, System.String Comment)
    //{
    //    int result;
    //    DataSet ds;
    //    Database db;
    //    string sqlCommand;
    //    DbCommand dbCommand;
    //    db = DatabaseFactory.CreateDatabase();
    //    sqlCommand = "[dbo].TMS_InsertContactUsDetails";
    //    dbCommand = db.GetStoredProcCommand(sqlCommand, Name, Email, Phone, Subject, Comment);
    //    return result = db.ExecuteDataSet(dbCommand);
    //    //ds = db.ExecuteDataSet(dbCommand);
    //    //return ds;
    //}




    public static DataSet GetApplicationDetailsSearch(System.Int64? adApplicationId, System.Int64? adSenderId, System.Int64? adReceivedId, System.Int64? adReplyID, System.String adApplicationFor, System.String adSubject, System.String adSentTo, System.String adExtra1, System.String adExtra2, System.String adApproveStatus, System.Int64? adApproveByID, System.String adApproveByType, System.DateTime? adApproveDate)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSeApplicationDetailsSearch";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adApplicationId, adSenderId, adReceivedId, adReplyID, adApplicationFor, adSubject,adSentTo, adExtra1, adExtra2, adApproveStatus, adApproveByID, adApproveByType, adApproveDate);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }

    public static DataSet FillLeaveStatusDetails(System.String Types, System.String Extra1)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillLeaveStatusDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Types, Extra1);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet GetFacultySTDLeaveDetails(System.Int64? LoginId, System.String TYpes)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillFacultySTDLeaveDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId, TYpes);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    } 

    #endregion

    public static int GetApplicationCount()
    {

        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMSApplicationDetails_ApplicationCount]";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        return Convert.ToInt32(db.ExecuteScalar(dbCommand));
    }
    public static DataSet GetFillRecivedApplicationCount(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillRecivedApplicationCount";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }



    public static DataSet GetSercheReceivedByType(System.String SentFrom, System.String Sentto, System.Int64? SenderID, System.String Type, System.String sentRecivedtype, System.Int64? ReceveryID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMStSercheReceivedByType";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SentFrom, Sentto, SenderID, Type, sentRecivedtype, ReceveryID);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

}

