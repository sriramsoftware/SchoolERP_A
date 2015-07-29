using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSUserType
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int32? utTypeId, System.String utTypeName, System.DateTime? utDate, System.Int32? utStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSUserType_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, utTypeId, utTypeName, utDate, utStatus);

        return db.ExecuteDataSet(dbCommand);
        
    }
    public static DataSet GetSearch(TMSUserType searchObject)
    {
        return GetSearch(searchObject.UTTypeId, searchObject.UTTypeName, searchObject.UTDate, searchObject.UTStatus);
    }
    /// <summary>
    /// Returns all TMSUserType objects.
    /// </summary>
    /// <returns>List of all TMSUserType objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }
    #endregion
}

