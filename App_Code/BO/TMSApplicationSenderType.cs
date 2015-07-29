using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSApplicationSenderType
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? asSenderId, System.String asSenderType, System.String asApplicationType, System.DateTime? asDate, System.Int32? asStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSApplicationSenderType_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, asSenderId, asSenderType, asApplicationType, asDate, asStatus);

        return db.ExecuteDataSet(dbCommand);
       
    }


    public static DataSet GetSearch(TMSApplicationSenderType searchObject)
    {
        return GetSearch(searchObject.ASSenderId, searchObject.ASSenderType, searchObject.ASApplicationType, searchObject.ASDate, searchObject.ASStatus);
    }

    /// <summary>
    /// Returns all TMSApplicationSenderType objects.
    /// </summary>
    /// <returns>List of all TMSApplicationSenderType objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null);
    }

    #endregion
}

