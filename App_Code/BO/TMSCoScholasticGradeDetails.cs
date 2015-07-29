using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSCoScholasticGradeDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? sgpGradeId, System.String sgpGradeName, System.Int32? sgpGradePoint, System.DateTime? sgpDate, System.Int32? sgpStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSCoScholasticGradeDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeId, sgpGradeName, sgpGradePoint, sgpDate, sgpStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSearch(TMSCoScholasticGradeDetails searchObject)
    {
        return GetSearch(searchObject.SGPGradeId, searchObject.SGPGradeName, searchObject.SGPGradePoint, searchObject.SGPDate, searchObject.SGPStatus);
    }

    /// <summary>
    /// Returns all TMSCoScholasticGradeDetails objects.
    /// </summary>
    /// <returns>List of all TMSCoScholasticGradeDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null);
    }

    #endregion


    public static DataSet ViewAllCoScholasticGradeDetails(System.Int64? sgpGradeId, System.String sgpGradeName, System.Int32? sgpGradePoint, System.DateTime? sgpDate, System.Int32? sgpStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspViewAll_COScholasticGradeDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeId, sgpGradeName, sgpGradePoint, sgpDate, sgpStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSearchIsPointExist(System.Int64? GradeId, System.Int32? GradePoint, System.String GradeName)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_CoScholasticGradeDetails_IsPointExist]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, GradeId, GradePoint, GradeName);
        return db.ExecuteDataSet(dbCommand);
    }
    public static DataSet CheckGradePoint_AlreadyExistsOrNot(System.Int32? GradePoint)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[CheckCoScholasticGradePointAlreadyExistsOrNot]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, GradePoint);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

