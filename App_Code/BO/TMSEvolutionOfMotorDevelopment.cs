using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSEvolutionOfMotorDevelopment
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? emdDevelopmentId, System.Int64? emdSchoolId, System.Int64? emdSchoolSubId, System.Int64? emdStudentLoginId, System.String emdAlertandRemeber, System.String emdKickThrowBall, System.String emdHopJumpRun, System.String emdKeenObserver, System.String emdCommunicateClearly, System.String emdGripWithPencil, System.String emdMyBalanceHandEye, System.String emdPicesOfPuzzle, System.String emdAddedByType, System.Int64? emdAddedByLoginId, System.DateTime? emdDate, System.Int32? emdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSEvolutionOfMotorDevelopment_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, emdDevelopmentId, emdSchoolId, emdSchoolSubId, emdStudentLoginId, emdAlertandRemeber, emdKickThrowBall, emdHopJumpRun, emdKeenObserver, emdCommunicateClearly, emdGripWithPencil, emdMyBalanceHandEye, emdPicesOfPuzzle, emdAddedByType, emdAddedByLoginId, emdDate, emdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSEvolutionOfMotorDevelopment searchObject)
    {
        return GetSearch(searchObject.EMDDevelopmentId, searchObject.EMDSchoolId, searchObject.EMDSchoolSubId, searchObject.EMDStudentLoginId, searchObject.EMDAlertandRemeber, searchObject.EMDKickThrowBall, searchObject.EMDHopJumpRun, searchObject.EMDKeenObserver, searchObject.EMDCommunicateClearly, searchObject.EMDGripWithPencil, searchObject.EMDMyBalanceHandEye, searchObject.EMDPicesOfPuzzle, searchObject.EMDAddedByType, searchObject.EMDAddedByLoginId, searchObject.EMDDate, searchObject.EMDStatus);
    }

    /// <summary>
    /// Returns all TMSEvolutionOfMotorDevelopment objects.
    /// </summary>
    /// <returns>List of all TMSEvolutionOfMotorDevelopment objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

