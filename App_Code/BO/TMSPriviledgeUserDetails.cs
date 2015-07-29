using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSPriviledgeUserDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? pudUserId, System.Int64? pudUserLoginId, System.String pudUserLoginType, System.String pudTitle, System.String pudFirstName, System.String pudMiddleName, System.String pudLastName, System.String pudHighestDegreeCompletd, System.String pudEmailId, System.String pudMobileNo, System.String pudAddress, System.Int64? pudCountryId, System.Int64? pudStateId, System.Int64? pudCityId, System.Int64? pudAddedById, System.String pudAddedByType, System.String pudUserType, System.DateTime? pudDate, System.Int32? pudStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSPriviledgeUserDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, pudUserId, pudUserLoginId, pudUserLoginType, pudTitle, pudFirstName, pudMiddleName, pudLastName, pudHighestDegreeCompletd, pudEmailId, pudMobileNo, pudAddress, pudCountryId, pudStateId, pudCityId, pudAddedById, pudAddedByType, pudUserType, pudDate, pudStatus);

        return db.ExecuteDataSet(dbCommand);
    }
    public static DataSet GetSearch(TMSPriviledgeUserDetails searchObject)
    {
        return GetSearch(searchObject.PUDUserId, searchObject.PUDUserLoginId, searchObject.PUDUserLoginType, searchObject.PUDTitle, searchObject.PUDFirstName, searchObject.PUDMiddleName, searchObject.PUDLastName, searchObject.PUDHighestDegreeCompletd, searchObject.PUDEmailId, searchObject.PUDMobileNo, searchObject.PUDAddress, searchObject.PUDCountryId, searchObject.PUDStateId, searchObject.PUDCityId, searchObject.PUDAddedById, searchObject.PUDAddedByType, searchObject.PUDUserType, searchObject.PUDDate, searchObject.PUDStatus);
    }

    /// <summary>
    /// Returns all TMSPriviledgeUserDetails objects.
    /// </summary>
    /// <returns>List of all TMSPriviledgeUserDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    public static DataSet SearchPriviledgeUserDetails(System.Int64? UserId,System.Int64? UserLoginId,System.String UserType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSSearch_UserPriviledgeDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, UserId, UserLoginId, UserType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
}

