using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSBusMaintananceDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? bsmMentananceID, System.String bsmBusID, System.Int64? bsmBusDetailsId, System.String bsmBusNumber, System.String bsmBusTravels, System.String bsmBusMilage, System.String bsmMonth, System.String bsmYear, System.Int64? bsmBusRootID, System.String bsmMonthlyMaintenancecost, System.String bsmStartPoint, System.String bsmEndPoint, System.String bsmExtra, System.DateTime? bsmDate, System.Int32? bsmStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBusMaintananceDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, bsmMentananceID, bsmBusID, bsmBusDetailsId, bsmBusNumber, bsmBusTravels, bsmBusMilage, bsmMonth, bsmYear, bsmBusRootID, bsmMonthlyMaintenancecost, bsmStartPoint, bsmEndPoint, bsmExtra, bsmDate, bsmStatus);

        ds = db.ExecuteDataSet(dbCommand);
     
        return ds;
    }


    public static DataSet GetSearch(TMSBusMaintananceDetails searchObject)
    {
        return GetSearch(searchObject.BSMMentananceID, searchObject.BSMBusID, searchObject.BSMBusDetailsId, searchObject.BSMBusNumber, searchObject.BSMBusTravels, searchObject.BSMBusMilage, searchObject.BSMMonth, searchObject.BSMYear, searchObject.BSMBusRootID, searchObject.BSMMonthlyMaintenancecost, searchObject.BSMStartPoint, searchObject.BSMEndPoint, searchObject.BSMExtra, searchObject.BSMDate, searchObject.BSMStatus);
    }

    /// <summary>
    /// Returns all TMSBusMaintananceDetails objects.
    /// </summary>
    /// <returns>List of all TMSBusMaintananceDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    public static DataSet GetStaffSalaryDetails(System.Int64? SalDetailID,System.Int64? ManagerID, System.String StaffType, System.Int64? StaffID, System.String Month, System.String Year, System.String Ftype)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;     

                db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGetStaffSalaryDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand,SalDetailID, ManagerID, StaffType, StaffID, Month, Year, Ftype);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }

    public static DataSet BindTMSBusMaintananceDetails(System.Int64? bsmMentananceID, System.Int64? bsmBusDetailsId, System.Int64? TransoportmanagerID, System.String bsmMonth, System.String bsmYear)

    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspBindTMSBusMaintananceDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, bsmMentananceID, bsmBusDetailsId, TransoportmanagerID, bsmMonth, bsmYear);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    #endregion
}

