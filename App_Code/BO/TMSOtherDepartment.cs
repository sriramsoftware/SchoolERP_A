using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSOtherDepartment
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? dpscDepartmentId, System.String dpScDepartmentName, System.String dpScDepartmentType, System.DateTime? dpDate, System.Int32? dpStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSOtherDepartment_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, dpscDepartmentId, dpScDepartmentName, dpScDepartmentType, dpDate, dpStatus);

        return db.ExecuteDataSet(dbCommand);
        
    }


    public static DataSet GetSearch(TMSOtherDepartment searchObject)
    {
        return GetSearch(searchObject.DPSCDepartmentId, searchObject.DPScDepartmentName, searchObject.DPScDepartmentType, searchObject.DPDate, searchObject.DpStatus);
    }

    /// <summary>
    /// Returns all TMSOtherDepartment objects.
    /// </summary>
    /// <returns>List of all TMSOtherDepartment objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null);
    }

    #endregion
}

