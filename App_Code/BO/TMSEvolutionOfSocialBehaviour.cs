using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSEvolutionOfSocialBehaviour
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? esbBehaviourId, System.Int64? esbSchoolId, System.Int64? esbSchoolSubId, System.Int64? esbStudentLoginId, System.String esbCommonVoluntarily, System.String esbMyPears, System.String esbMyToysWithFriends, System.String esbNeatAndTidy, System.String esbReponsibleAndCareful, System.String esbFollowTeacherInstruction, System.String esbWorkInTimeFrame, System.String esbFollowSchoolNorms, System.String esbLikeComeToSchool, System.String esbParticipateGroupGameActivities, System.String esbAddedByType, System.Int64? esbAddedByLoginId, System.DateTime? esbDate, System.Int32? esbStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSEvolutionOfSocialBehaviour_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, esbBehaviourId, esbSchoolId, esbSchoolSubId, esbStudentLoginId, esbCommonVoluntarily, esbMyPears, esbMyToysWithFriends, esbNeatAndTidy, esbReponsibleAndCareful, esbFollowTeacherInstruction, esbWorkInTimeFrame, esbFollowSchoolNorms, esbLikeComeToSchool, esbParticipateGroupGameActivities, esbAddedByType, esbAddedByLoginId, esbDate, esbStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSEvolutionOfSocialBehaviour searchObject)
    {
        return GetSearch(searchObject.ESBBehaviourId, searchObject.ESBSchoolId, searchObject.ESBSchoolSubId, searchObject.ESBStudentLoginId, searchObject.ESBCommonVoluntarily, searchObject.ESBMyPears, searchObject.ESBMyToysWithFriends, searchObject.ESBNeatAndTidy, searchObject.ESBReponsibleAndCareful, searchObject.ESBFollowTeacherInstruction, searchObject.ESBWorkInTimeFrame, searchObject.ESBFollowSchoolNorms, searchObject.ESBLikeComeToSchool, searchObject.ESBParticipateGroupGameActivities, searchObject.ESBAddedByType, searchObject.ESBAddedByLoginId, searchObject.ESBDate, searchObject.ESBStatus);
    }

    /// <summary>
    /// Returns all TMSEvolutionOfSocialBehaviour objects.
    /// </summary>
    /// <returns>List of all TMSEvolutionOfSocialBehaviour objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

