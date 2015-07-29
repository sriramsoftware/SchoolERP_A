using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSFeesHeadMaster
{
    static DataSet ds;
    static Database db;
    static string sqlCommand;
    static DbCommand dbCommand;

    public static DataSet GetAllFeeHeads()
    {
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetAllFeesHeads";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet FilterFeeHeads(string filter)
    {
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_FilterFeesHeads";
        dbCommand = db.GetStoredProcCommand(sqlCommand,filter);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

