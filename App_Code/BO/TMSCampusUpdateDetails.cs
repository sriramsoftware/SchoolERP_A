using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSCampusUpdateDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? cudCampusId, System.Int64? cudFacultyLoginId, System.Int64? cudSchoolId, System.Int64? cudSchoolSubId, System.String cudTitle, System.String cudDescription, System.String cudImageName1, System.String cudImageName2, System.String cudExtra, System.DateTime? cudCampusDate, System.DateTime? cudDate, System.Int32? cudStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSCampusUpdateDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, cudCampusId, cudFacultyLoginId, cudSchoolId, cudSchoolSubId, cudTitle, cudDescription, cudImageName1, cudImageName2, cudExtra, cudCampusDate, cudDate, cudStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSCampusUpdateDetails searchObject)
    {
        return GetSearch(searchObject.CUDCampusId, searchObject.CUDFacultyLoginId, searchObject.CUDSchoolId, searchObject.CUDSchoolSubId, searchObject.CUDTitle, searchObject.CUDDescription, searchObject.CUDImageName1, searchObject.CUDImageName2, searchObject.CUDExtra, searchObject.CUDCampusDate, searchObject.CUDDate, searchObject.CUDStatus);
    }

    /// <summary>
    /// Returns all TMSCampusUpdateDetails objects.
    /// </summary>
    /// <returns>List of all TMSCampusUpdateDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

