using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSEvolutionOfCompetitiveness
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ecdCompetitiveId, System.Int64? ecdSchoolId, System.Int64? ecdSchoolSubId, System.Int64? ecdStudentLoginId, System.String ecdSelfIntroduction, System.String ecdRhymesRecitation, System.String ecdFancyDress, System.String ecdSongAndDance, System.String ecdColouring, System.String ecdArtAndCraft, System.String ecdAnnualDay, System.String ecdSportsDay, System.String ecdOtherEvents, System.String ecdAddedByType, System.Int64? ecdAddedByLoginId, System.DateTime? ecdDate, System.Int32? ecdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSEvolutionOfCompetitiveness_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ecdCompetitiveId, ecdSchoolId, ecdSchoolSubId, ecdStudentLoginId, ecdSelfIntroduction, ecdRhymesRecitation, ecdFancyDress, ecdSongAndDance, ecdColouring, ecdArtAndCraft, ecdAnnualDay, ecdSportsDay, ecdOtherEvents, ecdAddedByType, ecdAddedByLoginId, ecdDate, ecdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSEvolutionOfCompetitiveness searchObject)
    {
        return GetSearch(searchObject.ECDCompetitiveId, searchObject.ECDSchoolId, searchObject.ECDSchoolSubId, searchObject.ECDStudentLoginId, searchObject.ECDSelfIntroduction, searchObject.ECDRhymesRecitation, searchObject.ECDFancyDress, searchObject.ECDSongAndDance, searchObject.ECDColouring, searchObject.ECDArtAndCraft, searchObject.ECDAnnualDay, searchObject.ECDSportsDay, searchObject.ECDOtherEvents, searchObject.ECDAddedByType, searchObject.ECDAddedByLoginId, searchObject.ECDDate, searchObject.ECDStatus);
    }

    /// <summary>
    /// Returns all TMSEvolutionOfCompetitiveness objects.
    /// </summary>
    /// <returns>List of all TMSEvolutionOfCompetitiveness objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

