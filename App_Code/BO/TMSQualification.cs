using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSQualification
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? qualId, System.String qualQualification, System.Int32? qualStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSQualification_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, qualId, qualQualification, qualStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSQualification searchObject)
    {
        return GetSearch(searchObject.QUALId, searchObject.QUALQualification, searchObject.QUALStatus);
    }

    /// <summary>
    /// Returns all TMSQualification objects.
    /// </summary>
    /// <returns>List of all TMSQualification objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null);
    }

    #endregion
}

