using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSFeesSetup
{
    static DataSet ds;
    static Database db;
    static string sqlCommand;
    static DbCommand dbCommand;

    public static DataSet GetAllFeesSetup()
    {
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetFeesSetup";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}


