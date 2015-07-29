using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSTodaysMealDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? tmdMealId, System.Int64? tmdSchooId, System.Int64? tmdSchoolSubId, System.DateTime? tmdMealDate, System.String tmdMealImage, System.String tmdMealMenu, System.String tmdMealDescription, System.DateTime? tmdDate, System.Int32? tmdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSTodaysMealDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, tmdMealId, tmdSchooId, tmdSchoolSubId, tmdMealDate, tmdMealImage, tmdMealMenu, tmdMealDescription, tmdDate, tmdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSTodaysMealDetails searchObject)
    {
        return GetSearch(searchObject.TMDMealId, searchObject.TMDSchooId, searchObject.TMDSchoolSubId, searchObject.TMDMealDate, searchObject.TMDMealImage, searchObject.TMDMealMenu, searchObject.TMDMealDescription, searchObject.TMDDate, searchObject.TMDStatus);
    }

    /// <summary>
    /// Returns all TMSTodaysMealDetails objects.
    /// </summary>
    /// <returns>List of all TMSTodaysMealDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

