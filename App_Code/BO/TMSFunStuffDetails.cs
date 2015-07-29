using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSFunStuffDetails
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? fsdFunStuffId, System.Int64? fsdFacultyId, System.Int64? fsdStudentId, System.Int64? fsdSchoolID, System.Int64? fsdSchoolSubId, System.String fsdFunStuffType, System.String fsdFunStuffSubType, System.String fsdLanguage, System.String fsdQuestion, System.String fsdAnswer, System.String fsdTitle, System.String fsdDescription, System.String fsdDescription1, System.String fsdImage, System.String fsdAuthorName, System.Int64? fsdAddedbyId, System.String fsdExtra, System.String fsdPuzzleCategory, System.String fsdPuzzlePlayersType, System.String fsdGameLink, System.String fsdVideoUploadName, System.DateTime? fsdDate, System.Int32? fsdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFunStuffDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, fsdFunStuffId, fsdFacultyId, fsdStudentId, fsdSchoolID, fsdSchoolSubId, fsdFunStuffType, fsdFunStuffSubType, fsdLanguage, fsdQuestion, fsdAnswer, fsdTitle, fsdDescription, fsdDescription1, fsdImage, fsdAuthorName, fsdAddedbyId, fsdExtra, fsdPuzzleCategory, fsdPuzzlePlayersType, fsdGameLink, fsdVideoUploadName, fsdDate, fsdStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetSearch(TMSFunStuffDetails searchObject)
    {
        return GetSearch(searchObject.FSDFunStuffId, searchObject.FSDFacultyId, searchObject.FSDStudentId, searchObject.FSDSchoolID, searchObject.FSDSchoolSubId, searchObject.FSDFunStuffType, searchObject.FSDFunStuffSubType, searchObject.FSDLanguage, searchObject.FSDQuestion, searchObject.FSDAnswer, searchObject.FSDTitle, searchObject.FSDDescription, searchObject.FSDDescription1, searchObject.FSDImage, searchObject.FSDAuthorName, searchObject.FSDAddedbyId, searchObject.FSDExtra, searchObject.FSDPuzzleCategory, searchObject.FSDPuzzlePlayersType, searchObject.FSDGameLink, searchObject.FSDVideoUploadName, searchObject.FSDDate, searchObject.FSDStatus);
    }

    /// <summary>
    /// Returns all TMSFunStuffDetails objects.
    /// </summary>
    /// <returns>List of all TMSFunStuffDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }
    public static DataSet GetStories(System.Int64? loginID, System.String Type)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetStories";
        dbCommand = db.GetStoredProcCommand(sqlCommand, loginID, Type);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

    #region Get 
    public static DataSet GetSearch_WithoutJustJoking(System.Int64? fsdFunStuffId, System.Int64? fsdFacultyId, System.Int64? fsdStudentId, System.Int64? fsdSchoolID, System.Int64? fsdSchoolSubId, System.String fsdFunStuffType, System.String fsdFunStuffSubType, System.String fsdLanguage, System.String fsdQuestion, System.String fsdAnswer, System.String fsdTitle, System.String fsdDescription, System.String fsdDescription1, System.String fsdImage, System.String fsdAuthorName, System.Int64? fsdAddedbyId, System.String fsdExtra, System.String fsdPuzzleCategory, System.String fsdPuzzlePlayersType, System.String fsdGameLink, System.String fsdVideoUploadName, System.DateTime? fsdDate, System.Int32? fsdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFunStuffDetails_SEARCH_WithoutJustJoking";
        dbCommand = db.GetStoredProcCommand(sqlCommand, fsdFunStuffId, fsdFacultyId, fsdStudentId, fsdSchoolID, fsdSchoolSubId, fsdFunStuffType, fsdFunStuffSubType, fsdLanguage, fsdQuestion, fsdAnswer, fsdTitle, fsdDescription, fsdDescription1, fsdImage, fsdAuthorName, fsdAddedbyId, fsdExtra, fsdPuzzleCategory, fsdPuzzlePlayersType, fsdGameLink, fsdVideoUploadName, fsdDate, fsdStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }

    #endregion

}

