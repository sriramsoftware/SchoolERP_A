using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSNewsLetterDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ndNewsDetailsId, System.String ndTitle, System.String ndSubject, System.String ndDescription, System.String ndExtra, System.DateTime? ndDate, System.Int32? ndStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSNewsLetterDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ndNewsDetailsId, ndTitle, ndSubject, ndDescription, ndExtra, ndDate, ndStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSearch(TMSNewsLetterDetails searchObject)
    {
        return GetSearch(searchObject.NDNewsDetailsId, searchObject.NDTitle, searchObject.NDSubject, searchObject.NDDescription, searchObject.NDExtra, searchObject.NDDate, searchObject.NDStatus);
    }

    /// <summary>
    /// Returns all TMSNewsLetterDetails objects.
    /// </summary>
    /// <returns>List of all TMSNewsLetterDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null);
    }

    #endregion
}

