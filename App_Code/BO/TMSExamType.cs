using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSExamType
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? etExamTypeId, System.String etExamTypeName, System.DateTime? etDate, System.Int32? etStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSExamType_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, etExamTypeId, etExamTypeName, etDate, etStatus);

        return db.ExecuteDataSet(dbCommand);
        
    }


    public static DataSet GetSearch(TMSExamType searchObject)
    {
        return GetSearch(searchObject.ETExamTypeId, searchObject.ETExamTypeName, searchObject.ETDate, searchObject.ETStatus);
    }

    /// <summary>
    /// Returns all TMSExamType objects.
    /// </summary>
    /// <returns>List of all TMSExamType objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }

    #endregion
}

