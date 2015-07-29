using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


public partial class TMSBasicAdvanceModule
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? adModuleID, System.String adText, System.String adType, System.String adDescription, System.DateTime? adDate, System.Int32? adStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBasicAdvanceModule_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adModuleID, adText, adType, adDescription, adDate, adStatus);

        ds = db.ExecuteDataSet(dbCommand);
     
        return ds;
    }


    public static DataSet GetSearch(TMSBasicAdvanceModule searchObject)
    {
        return GetSearch(searchObject.ADModuleID, searchObject.ADText, searchObject.ADType, searchObject.ADDescription, searchObject.ADDate, searchObject.ADStatus);
    }

    /// <summary>
    /// Returns all TMSBasicAdvanceModule objects.
    /// </summary>
    /// <returns>List of all TMSBasicAdvanceModule objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null);
    }

    #endregion
}

