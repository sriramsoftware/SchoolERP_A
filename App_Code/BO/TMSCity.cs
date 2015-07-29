using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSCity
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ctId, System.Int64? ctStateID, System.String ctCity, System.Int32? ctStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSCity_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ctId, ctStateID, ctCity, ctStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSCity searchObject)
    {
        return GetSearch(searchObject.CTId, searchObject.CTStateID, searchObject.CTCity, searchObject.CTStatus);
    }

    /// <summary>
    /// Returns all TMSCity objects.
    /// </summary>
    /// <returns>List of all TMSCity objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }



    public static DataSet GetTMSCityDetails(System.Int64? ctId, System.Int64? ctStateID, System.String ctCity, System.Int32? ctStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSCityDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ctId, ctStateID, ctCity, ctStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    #endregion
}

