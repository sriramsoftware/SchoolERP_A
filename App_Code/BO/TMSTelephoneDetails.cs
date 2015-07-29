using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSTelephoneDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? tdTelephoneId, System.String tdTelephoneDepartment, System.String tdTelephoneNumber, System.DateTime? tdDate, System.Int32? tdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSTelephoneDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, tdTelephoneId, tdTelephoneDepartment, tdTelephoneNumber, tdDate, tdStatus);

        return db.ExecuteDataSet(dbCommand);
      
    }
    public static DataSet GetSearch(TMSTelephoneDetails searchObject)
    {
        return GetSearch(searchObject.TDTelephoneId, searchObject.TDTelephoneDepartment, searchObject.TDTelephoneNumber, searchObject.TDDate, searchObject.TDStatus);
    }
    /// <summary>
    /// Returns all TMSTelephoneDetails objects.
    /// </summary>
    /// <returns>List of all TMSTelephoneDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null);
    }

    #endregion

    public static DataSet CheckIsTelephoneNuber_AlreadyExistsAtUpdate(System.Int64? tdTelephoneId, System.String tdTelephoneDepartment, System.String tdTelephoneNumber)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSTelephoneDetails_IsAlreadyExists";
        dbCommand = db.GetStoredProcCommand(sqlCommand, tdTelephoneId, tdTelephoneDepartment, tdTelephoneNumber);

        return db.ExecuteDataSet(dbCommand);

    }
}

