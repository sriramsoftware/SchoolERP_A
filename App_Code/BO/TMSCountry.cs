using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSCountry
{
    #region GetSearch
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? cntrId, System.String cntrCountry, System.Int32? cntrStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSCountry_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, cntrId, cntrCountry, cntrStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSCountry searchObject)
    {
        return GetSearch(searchObject.CNTRId, searchObject.CNTRCountry, searchObject.CNTRStatus);
    }

    /// <summary>
    /// Returns all TMSCountry objects.
    /// </summary>
    /// <returns>List of all TMSCountry objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null);
    }

    public static DataSet GetCountryDetails(System.Int64? cntrId, System.String cntrCountry, System.Int32? cntrStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSCountryDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, cntrId, cntrCountry, cntrStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    #endregion
}

