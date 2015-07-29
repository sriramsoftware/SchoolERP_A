using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSEvolutionOfLiteraryAbilities
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? elaAbilityId, System.Int64? elaSchoolId, System.Int64? elaSchoolSubId, System.Int64? elaStudentLoginId, System.String elaAllLetters, System.String elaNumbers, System.String elaColours, System.String elaShape, System.String elaVegetableFruits, System.String elaAnimalBirds, System.String elaMeansOfTransport, System.String elaCoomonArticleSchoolHome, System.String elaMyNamePrint, System.String elaLikeComeToSchool, System.String elaArticulateWell, System.String elaRecite, System.String elaStoryTell, System.String elaExpressIdeas, System.String elaDevelopeNewWords, System.String elaConverseFairlyWell, System.String elaFormLetters, System.String elaMakeSimplePattern, System.String elaAddedByType, System.Int64? elaAddedByLoginId, System.DateTime? elaDate, System.Int32? elaStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSEvolutionOfLiteraryAbilities_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, elaAbilityId, elaSchoolId, elaSchoolSubId, elaStudentLoginId, elaAllLetters, elaNumbers, elaColours, elaShape, elaVegetableFruits, elaAnimalBirds, elaMeansOfTransport, elaCoomonArticleSchoolHome, elaMyNamePrint, elaLikeComeToSchool, elaArticulateWell, elaRecite, elaStoryTell, elaExpressIdeas, elaDevelopeNewWords, elaConverseFairlyWell, elaFormLetters, elaMakeSimplePattern, elaAddedByType, elaAddedByLoginId, elaDate, elaStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSEvolutionOfLiteraryAbilities searchObject)
    {
        return GetSearch(searchObject.ELAAbilityId, searchObject.ELASchoolId, searchObject.ELASchoolSubId, searchObject.ELAStudentLoginId, searchObject.ELAAllLetters, searchObject.ELANumbers, searchObject.ELAColours, searchObject.ELAShape, searchObject.ELAVegetableFruits, searchObject.ELAAnimalBirds, searchObject.ELAMeansOfTransport, searchObject.ELACoomonArticleSchoolHome, searchObject.ELAMyNamePrint, searchObject.ELALikeComeToSchool, searchObject.ELAArticulateWell, searchObject.ELARecite, searchObject.ELAStoryTell, searchObject.ELAExpressIdeas, searchObject.ELADevelopeNewWords, searchObject.ELAConverseFairlyWell, searchObject.ELAFormLetters, searchObject.ELAMakeSimplePattern, searchObject.ELAAddedByType, searchObject.ELAAddedByLoginId, searchObject.ELADate, searchObject.ELAStatus);
    }

    /// <summary>
    /// Returns all TMSEvolutionOfLiteraryAbilities objects.
    /// </summary>
    /// <returns>List of all TMSEvolutionOfLiteraryAbilities objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

