
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSFeesTerm
{
    static DataSet ds;
    static Database db;
    static string sqlCommand;
    static DbCommand dbCommand;

    public static DataSet GetFeesTermbyFeeCategoryID(int FeeCategoryID)
    {
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetFeesTermbyFeeCategoryID";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FeeCategoryID);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetFeesTermbyMonthIDAndFeeCategoryID(int FeeCategoryID, int Month)
    {
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetFeesTermbyMonthIDAndFeeCategoryID";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FeeCategoryID,Month);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

}

