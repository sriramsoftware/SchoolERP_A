using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSExtraActivityType
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? etActivityTypeID, System.String etActivityType, System.DateTime? etDate, System.Int32? etStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSExtraActivityType_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, etActivityTypeID, etActivityType, etDate, etStatus);

        ds = db.ExecuteDataSet(dbCommand);
       
        return  ds;
    }


    public static DataSet GetSearch(TMSExtraActivityType searchObject)
    {
        return GetSearch(searchObject.ETActivityTypeID, searchObject.ETActivityType, searchObject.ETDate, searchObject.ETStatus);
    }

    /// <summary>
    /// Returns all TMSExtraActivityType objects.
    /// </summary>
    /// <returns>List of all TMSExtraActivityType objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }

    #endregion
}

