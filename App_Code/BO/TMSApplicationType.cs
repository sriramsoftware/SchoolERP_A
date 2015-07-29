using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


public partial class TMSApplicationType
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? adApplicationTypeId, System.String adApplicationType, System.DateTime? adApplicationTypeDate, System.Int32? adApplicationTypeStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSApplicationType_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adApplicationTypeId, adApplicationType, adApplicationTypeDate, adApplicationTypeStatus);

        return db.ExecuteDataSet(dbCommand);
        
    }


    public static DataSet GetSearch(TMSApplicationType searchObject)
    {
        return GetSearch(searchObject.ADApplicationTypeId, searchObject.ADApplicationType, searchObject.ADApplicationTypeDate, searchObject.ADApplicationTypeStatus);
    }

    /// <summary>
    /// Returns all TMSApplicationType objects.
    /// </summary>
    /// <returns>List of all TMSApplicationType objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }

    #endregion

}

