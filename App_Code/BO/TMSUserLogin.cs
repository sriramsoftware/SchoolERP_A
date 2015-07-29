using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSUserLogin
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ulLoginId, System.String ulUserName, System.String ulUserPassword, System.String ulEmailId, System.Int32? ulUserType, System.Int64? ulCreatedBy, System.Int64? ulModifiedBy, System.DateTime? ulCreatedDate, System.DateTime? ulModifiedDate, System.DateTime? ulLastLoginDate, System.Int32? ulStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSUserLogin_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ulLoginId, ulUserName, ulUserPassword, ulEmailId, ulUserType, ulCreatedBy, ulModifiedBy, ulCreatedDate, ulModifiedDate, ulLastLoginDate, ulStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetSearch(TMSUserLogin searchObject)
    {
        return GetSearch(searchObject.ULLoginId, searchObject.ULUserName, searchObject.ULUserPassword, searchObject.ULEmailId, searchObject.ULUserType, searchObject.ULCreatedBy, searchObject.ULModifiedBy, searchObject.ULCreatedDate, searchObject.ULModifiedDate, searchObject.ULLastLoginDate, searchObject.ULStatus);
    }
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null);
    }
    #endregion
    #region Login SP
    public static DataSet CheckLoginDetails(System.String UserId, System.String Password, System.Int32? UserType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSLoginInfoUser_SELECT_ValidUser]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, UserId, Password, UserType);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    #endregion
    #region chk login EmailId Exists or Not
    public static DataSet CheckEmailIdExistsOrNot(System.String EmailId, System.String EMailType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMSChkEmailIdExistsOrNot]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, EmailId, EMailType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    #endregion
    #region chk login EmailId Exists or Not For User Privilege Details
    public static DataSet CheckEmailIdExistsOrNotFor_UserPrivilgeDetails(System.String EmailId, System.Int32? UserType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMSNewChkEmailIdExistsOrNot]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, EmailId, UserType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    #endregion
    #region chk login EmailId Exists or Not At The Time Of Updating EamilId
    public static DataSet CheckEmailIdExistsOrNot_AtUpadteTime(System.Int64? UserLoginId, System.String EmailId, System.Int32? UserType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSUseEMailIdUpdate_CheckIsAlreadyExists]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, UserLoginId, EmailId, UserType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    #endregion
    #region Front User Forgot Password
    public static DataSet GetFrontUserDetails_ForgotPassword(System.String EmailId, System.Int64? UserType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMSGetFrontUserDetails_ForgotPassword]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, EmailId, UserType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    #endregion
    #region Front User Forgot Password
    public static DataSet GetChkEmailIdExists(System.String EmailId, System.Int64? UserType, System.String EmailType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSChkEmailIdExistsOrNotStaff";
        dbCommand = db.GetStoredProcCommand(sqlCommand, EmailId, UserType, EmailType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet CheckAlredyexistUsernamePassword(System.Int64? ulLoginId, System.String ulUserName, System.String ulUserPassword, System.String ulEmailId, System.Int64? ulUsertype, System.String Type)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSCheckAlredyexistUsernamePassword";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ulLoginId, ulUserName, ulUserPassword, ulEmailId, ulUsertype, Type);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
    #region Get parent EmailIds
    public static DataSet GetParentEmailIds()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[GetParentEmailIds]";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
}

