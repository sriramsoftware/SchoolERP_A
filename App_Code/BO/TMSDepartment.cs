using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSDepartment
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? dpDepartmentId, System.String dpDepartmentName, System.DateTime? dpDate, System.Int32? dpStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSDepartment_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, dpDepartmentId, dpDepartmentName, dpDate, dpStatus);

      ds= db.ExecuteDataSet(dbCommand);
       return ds;
       
    }


    public static DataSet GetSearch(TMSDepartment searchObject)
    {
        return GetSearch(searchObject.DPDepartmentId, searchObject.DPDepartmentName, searchObject.DPDate, searchObject.DpStatus);
    }

    /// <summary>
    /// Returns all TMSDepartment objects.
    /// </summary>
    /// <returns>List of all TMSDepartment objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }

    #endregion
}

