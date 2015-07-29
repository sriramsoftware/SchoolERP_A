using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSPrivacySettings
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? psPrivacyId, System.Int64? psFacultyLoginId, System.Int64? psFacultyTypeId, System.String psFacultyType, System.String psDisplayPhoto, System.String psDisplayEducation, System.String psDisplayConatctDetails, System.String psDisplayLocation, System.String psExtraOne, System.String psExtraTwo, System.String psExtraThree, System.String psExtraFour, System.DateTime? psDate, System.Int32? psStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSPrivacySettings_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, psPrivacyId, psFacultyLoginId, psFacultyTypeId, psFacultyType, psDisplayPhoto, psDisplayEducation, psDisplayConatctDetails, psDisplayLocation, psExtraOne, psExtraTwo, psExtraThree, psExtraFour, psDate, psStatus);

        return db.ExecuteDataSet(dbCommand);
        
    }


    public static DataSet GetSearch(TMSPrivacySettings searchObject)
    {
        return GetSearch(searchObject.PSPrivacyId, searchObject.PSFacultyLoginId, searchObject.PSFacultyTypeId, searchObject.PSFacultyType, searchObject.PSDisplayPhoto, searchObject.PSDisplayEducation, searchObject.PSDisplayConatctDetails, searchObject.PSDisplayLocation, searchObject.PSExtraOne, searchObject.PSExtraTwo, searchObject.PSExtraThree, searchObject.PSExtraFour, searchObject.PSDate, searchObject.PSStatus);
    }

    /// <summary>
    /// Returns all TMSPrivacySettings objects.
    /// </summary>
    /// <returns>List of all TMSPrivacySettings objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

