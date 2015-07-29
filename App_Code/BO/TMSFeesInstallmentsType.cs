using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSFeesInstallmentsType
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? fitTypeId, System.String fitTypeName, System.String fitExtra1, System.DateTime? fitDate, System.Int32? fitStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFeesInstallmentsType_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, fitTypeId, fitTypeName, fitExtra1, fitDate, fitStatus);

        ds = db.ExecuteDataSet(dbCommand);
      
        return ds;
    }


    public static DataSet GetSearch (TMSFeesInstallmentsType searchObject)
    {
        return GetSearch(searchObject.FITTypeId, searchObject.FITTypeName, searchObject.FITExtra1, searchObject.FITDate, searchObject.FITStatus);
    }

    /// <summary>
    /// Returns all TMSFeesInstallmentsType objects.
    /// </summary>
    /// <returns>List of all TMSFeesInstallmentsType objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch ()
    {
        return GetSearch(null, null, null, null, null);
    }

    #endregion

}

