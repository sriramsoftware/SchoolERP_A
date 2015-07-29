using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSState
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? stId, System.Int64? stCountryID, System.String stState, System.Int32? stStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSState_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, stId, stCountryID, stState, stStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSState searchObject)
    {
        return GetSearch(searchObject.STId, searchObject.STCountryID, searchObject.STState, searchObject.STStatus);
    }

    /// <summary>
    /// Returns all TMSState objects.
    /// </summary>
    /// <returns>List of all TMSState objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }


    public static DataSet GetStatedetails(System.Int64? stId, System.Int64? stCountryID, System.String stState, System.Int32? stStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStatedetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, stId, stCountryID, stState, stStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    #endregion
}

