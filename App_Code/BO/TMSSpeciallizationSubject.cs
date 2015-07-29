using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSSpeciallizationSubject
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? sbSubjectId, System.String sbSubjectName, System.DateTime? sbDate, System.Int32? sbStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSpeciallizationSubject_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sbSubjectId, sbSubjectName, sbDate, sbStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSSpeciallizationSubject searchObject)
    {
        return GetSearch(searchObject.SBSubjectId, searchObject.SBSubjectName, searchObject.SBDate, searchObject.SBStatus);
    }

    /// <summary>
    /// Returns all TMSSpeciallizationSubject objects.
    /// </summary>
    /// <returns>List of all TMSSpeciallizationSubject objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null);
    }

    #endregion
}

