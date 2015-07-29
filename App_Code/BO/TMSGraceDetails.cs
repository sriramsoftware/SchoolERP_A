using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSGraceDetails
{
    #region GetSearch
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? gdGraceId, System.Int64? gdSchoolId, System.Int64? sdSubjectId, System.String sdGraceMarks, System.DateTime? sdDate, System.Int32? sdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGraceDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, gdGraceId, gdSchoolId, sdSubjectId, sdGraceMarks, sdDate, sdStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetSearch(TMSGraceDetails searchObject)
    {
        return GetSearch(searchObject.GDGraceId, searchObject.GDSchoolId, searchObject.SDSubjectId, searchObject.SDGraceMarks, searchObject.SDDate, searchObject.SDStatus);
    }

    /// <summary>
    /// Returns all TMSGraceDetails objects.
    /// </summary>
    /// <returns>List of all TMSGraceDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null);
    }

    #endregion
}

