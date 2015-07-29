using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSSchoolType
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? stTypeId, System.String ststTypeName, System.Int32? stStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSchoolType_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, stTypeId, ststTypeName, stStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSSchoolType searchObject)
    {
        return GetSearch(searchObject.STTypeId, searchObject.STSTTypeName, searchObject.STStatus);
    }

    /// <summary>
    /// Returns all TMSSchoolType objects.
    /// </summary>
    /// <returns>List of all TMSSchoolType objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null);
    }

    #endregion




    public static DataSet GetAlreadySearchSearch(System.Int64? stTypeId, System.String ststTypeName, System.Int32? stStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSchoolTypeAlredyExist_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, stTypeId, ststTypeName, stStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

}

