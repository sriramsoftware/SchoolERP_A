using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSScholasticGradePoint
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? sgpGradeId, System.Int32? sgpGradePoint, System.DateTime? sgpDate, System.Int32? sgpStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSScholasticGradePoint_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeId, sgpGradePoint, sgpDate, sgpStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSScholasticGradePoint searchObject)
    {
        return GetSearch(searchObject.SGPGradeId, searchObject.SGPGradePoint, searchObject.SGPDate, searchObject.SGPStatus);
    }

    /// <summary>
    /// Returns all TMSScholasticGradePoint objects.
    /// </summary>
    /// <returns>List of all TMSScholasticGradePoint objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }

    #endregion


    public static DataSet CheckGradePoint_AlreadyExistsOrNot()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[CheckGradePointAlreadyExistsOrNot]";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

