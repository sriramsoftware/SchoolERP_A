using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSEvolutionOfAsthenticSensiblePhysicalGrowth
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? egdGrowthId, System.Int64? egdSchoolId, System.Int64? egdSchoolSubId, System.Int64? egdStudentLoginId, System.String egdMudAndSandPlay, System.String egdSplashPool, System.String egdLikeColourPainting, System.String egdPatternWriting, System.String egdPaperTearingPastingCraftWork, System.String egdInterestArtActivites, System.String egdInterestMusicDramaActivites, System.String egdInterestPhysicalActivites, System.String egdAddedByType, System.Int64? egdAddedByLoginId, System.DateTime? egdDate, System.Int32? egdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSEvolutionOfAsthenticSensiblePhysicalGrowth_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, egdGrowthId, egdSchoolId, egdSchoolSubId, egdStudentLoginId, egdMudAndSandPlay, egdSplashPool, egdLikeColourPainting, egdPatternWriting, egdPaperTearingPastingCraftWork, egdInterestArtActivites, egdInterestMusicDramaActivites, egdInterestPhysicalActivites, egdAddedByType, egdAddedByLoginId, egdDate, egdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSEvolutionOfAsthenticSensiblePhysicalGrowth searchObject)
    {
        return GetSearch(searchObject.EGDGrowthId, searchObject.EGDSchoolId, searchObject.EGDSchoolSubId, searchObject.EGDStudentLoginId, searchObject.EGDMudAndSandPlay, searchObject.EGDSplashPool, searchObject.EGDLikeColourPainting, searchObject.EGDPatternWriting, searchObject.EGDPaperTearingPastingCraftWork, searchObject.EGDInterestArtActivites, searchObject.EGDInterestMusicDramaActivites, searchObject.EGDInterestPhysicalActivites, searchObject.EGDAddedByType, searchObject.EGDAddedByLoginId, searchObject.EGDDate, searchObject.EGDStatus);
    }

    /// <summary>
    /// Returns all TMSEvolutionOfAsthenticSensiblePhysicalGrowth objects.
    /// </summary>
    /// <returns>List of all TMSEvolutionOfAsthenticSensiblePhysicalGrowth objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

