using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSCoScholasticSkillTitle
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? stSkillTitleId, System.Int64? stSkillId, System.String stTitleName, System.String stTitleDescription, System.String stExtra, System.DateTime? stDate, System.Int32? stStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSCoScholasticSkillTitle_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, stSkillTitleId, stSkillId, stTitleName, stTitleDescription, stExtra, stDate, stStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSCoScholasticSkillTitle searchObject)
    {
        return GetSearch(searchObject.STSkillTitleId, searchObject.STSkillId, searchObject.STTitleName, searchObject.STTitleDescription, searchObject.STExtra, searchObject.STDate, searchObject.STStatus);
    }

    /// <summary>
    /// Returns all TMSCoScholasticSkillTitle objects.
    /// </summary>
    /// <returns>List of all TMSCoScholasticSkillTitle objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null);
    }



    public static DataSet GetCoScholasticSkillTitle(System.Int64? stSkillTitleId, System.Int64? stSkillId,System.String StSkillName, System.Int64? SchoolID, System.String stTitleName)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGetCoScholasticSkillTitle";
        dbCommand = db.GetStoredProcCommand(sqlCommand, stSkillTitleId, stSkillId,StSkillName, SchoolID, stTitleName);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    #endregion
}

