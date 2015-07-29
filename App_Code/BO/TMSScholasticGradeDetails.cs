using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSScholasticGradeDetails
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? sgpGradeId, System.String sgpGradeName, System.Int32? sgpGradePoint, System.DateTime? sgpDate, System.Int32? sgpStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSScholasticGradeDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeId, sgpGradeName, sgpGradePoint, sgpDate, sgpStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSScholasticGradeDetails searchObject)
    {
        return GetSearch(searchObject.SGPGradeId, searchObject.SGPGradeName, searchObject.SGPGradePoint, searchObject.SGPDate, searchObject.SGPStatus);
    }

    /// <summary>
    /// Returns all TMSScholasticGradeDetails objects.
    /// </summary>
    /// <returns>List of all TMSScholasticGradeDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null);
    }

    #endregion


    public static DataSet ViewAllScholasticGradeDetails(System.Int64? sgpGradeId, System.String sgpGradeName, System.Int32? sgpGradePoint, System.DateTime? sgpDate, System.Int32? sgpStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspViewAllScholasticGradeDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeId, sgpGradeName, sgpGradePoint, sgpDate, sgpStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSearchIsExist(System.Int64? GradeId, System.Int32? GradePoint, System.String GradeName)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_ScholasticGradeDetails_IsPointExist]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, GradeId, GradePoint, GradeName);
        return db.ExecuteDataSet(dbCommand);
    }
}

