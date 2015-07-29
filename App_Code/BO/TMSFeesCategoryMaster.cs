using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSFeesCategoryMaster
{
    static DataSet ds;
    static Database db;
    static string sqlCommand;
    static DbCommand dbCommand;

    public static DataSet GetAllFeesCategory()
    {
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetAllFeesCategory";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet FilterFeesCategories(string filter)
    {
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_FilterFeesCategories";
        dbCommand = db.GetStoredProcCommand(sqlCommand,filter);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

