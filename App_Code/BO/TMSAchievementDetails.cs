using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSAchievementDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? adAchievementId, System.Int64? adStudentId, System.Int64? adFacultyId, System.Int64? adSchoolId, System.Int64? adSchoolSubId, System.String adTitle, System.String adDescription, System.String adImage, System.DateTime? adAchievementDate, System.DateTime? adDate, System.Int32? adStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAchievementDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adAchievementId, adStudentId, adFacultyId, adSchoolId, adSchoolSubId, adTitle, adDescription, adImage, adAchievementDate, adDate, adStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSearch(TMSAchievementDetails searchObject)
    {
        return GetSearch(searchObject.ADAchievementId, searchObject.ADStudentId, searchObject.ADFacultyId, searchObject.ADSchoolId, searchObject.ADSchoolSubId, searchObject.ADTitle, searchObject.ADDescription, searchObject.ADImage, searchObject.ADAchievementDate, searchObject.ADDate, searchObject.ADStatus);
    }

    /// <summary>
    /// Returns all TMSAchievementDetails objects.
    /// </summary>
    /// <returns>List of all TMSAchievementDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet GetAchievementDetails(System.Int64? adAchievementId, System.String adTitle, System.Int64? adStudentLoginId, System.String studentName, System.Int64? adFacultyLoginId, System.Int64? adSchoolId, System.Int64? adSchoolSubId, System.String adSchoolType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchAchievementDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adAchievementId, adTitle, adStudentLoginId, studentName, adFacultyLoginId, adSchoolId, adSchoolSubId, adSchoolType);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

