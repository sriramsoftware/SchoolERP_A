using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSHolidayCalender
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? hcHolidayID, System.String hcName, System.String hcDscription, System.String hcDescription1, System.String hcType, System.DateTime? hcDate, System.String hcYear, System.String hcAddedby, System.DateTime? hcAdddate, System.Int64? hcSchoolCatId, System.Int64? hcSchoolSubCatID, System.Int32? hcStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSHolidayCalender_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, hcHolidayID, hcName, hcDscription, hcDescription1, hcType, hcDate, hcYear, hcAddedby, hcAdddate, hcSchoolCatId, hcSchoolSubCatID, hcStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSHolidayCalender searchObject)
    {
        return GetSearch(searchObject.HCHolidayID, searchObject.HCName, searchObject.HCDscription, searchObject.HCDescription1, searchObject.HCType, searchObject.HCDate, searchObject.HCYear, searchObject.HCAddedby, searchObject.HCAdddate, searchObject.HCSchoolCatId, searchObject.HCSchoolSubCatID, searchObject.HCStatus);
    }

    /// <summary>
    /// Returns all TMSHolidayCalender objects.
    /// </summary>
    /// <returns>List of all TMSHolidayCalender objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion






    public static DataSet Getholidaydata()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSHoliday_Gatedata";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet Getprincipalholidaydata()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSHolidayPrincipal_Gatedata";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

}

