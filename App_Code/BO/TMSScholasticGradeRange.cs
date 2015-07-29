using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSScholasticGradeRange
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? sgpGradeId, System.Int64? sgpScholasticGradeId, System.Int32? sgpGradeStartRange, System.Int32? sgpGradeEndRange, System.DateTime? sgpDate, System.Int32? sgpStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSScholasticGradeRange_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeId, sgpScholasticGradeId, sgpGradeStartRange, sgpGradeEndRange, sgpDate, sgpStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSScholasticGradeRange searchObject)
    {
        return GetSearch(searchObject.SGPGradeId, searchObject.SGPScholasticGradeId, searchObject.SGPGradeStartRange, searchObject.SGPGradeEndRange, searchObject.SGPDate, searchObject.SGPStatus);
    }

    /// <summary>
    /// Returns all TMSScholasticGradeRange objects.
    /// </summary>
    /// <returns>List of all TMSScholasticGradeRange objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null);
    }

    #endregion


    public static DataSet ViewAllScholasticGradeMarksRange(System.Int64? sgpGradeId, System.Int64? sgpScholasticGradeId, System.Int32? sgpGradeStartRange, System.Int32? sgpGradeEndRange, System.DateTime? sgpDate, System.Int32? sgpStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspViewAllScholasticGradeMarksRange]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeId, sgpScholasticGradeId, sgpGradeStartRange, sgpGradeEndRange, sgpDate, sgpStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSearchIsExist(System.Int64? GradeId, System.Int64? ScholasticGradeId, System.Int32? GradeStartRange, System.Int32? GradeEndRange)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_ScholasticGradeRange_IsGradeRangeExist]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, GradeId, ScholasticGradeId, GradeStartRange, GradeEndRange);
        return db.ExecuteDataSet(dbCommand);
    }

    public static DataSet CheckGradeMarksRange_AlreadyExistsOrNot()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[CheckScholasticGradeMarkRange_AlreadyExistsOrNot]";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

}

