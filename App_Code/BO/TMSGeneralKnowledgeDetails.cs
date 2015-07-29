using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSGeneralKnowledgeDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? gkKnowledgeId, System.Int64? gkFacultyId, System.Int64? gkStudentId, System.Int64? gkSchoolId, System.Int64? gkSchoolSubId, System.String gkQuestionType, System.String gkQuestion, System.String gkAnswer, System.String gkOption1, System.String gkOption2, System.String gkOption3, System.String gkOption4, System.String gkOption5, System.String gkQuestionFor, System.Int64? gkAddedById, System.DateTime? gkTestDate, System.DateTime? gkDate, System.Int32? gkStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGeneralKnowledgeDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, gkKnowledgeId, gkFacultyId, gkStudentId, gkSchoolId, gkSchoolSubId, gkQuestionType, gkQuestion, gkAnswer, gkOption1, gkOption2, gkOption3, gkOption4, gkOption5, gkQuestionFor, gkAddedById, gkTestDate, gkDate, gkStatus);

        ds = db.ExecuteDataSet(dbCommand);
        //ds.Tables[0].TableName = TABLE_NAME;
        return ds;
    }


    public static DataSet GetSearch(TMSGeneralKnowledgeDetails searchObject)
    {
        return GetSearch(searchObject.GKKnowledgeId, searchObject.GKFacultyId, searchObject.GKStudentId, searchObject.GKSchoolId, searchObject.GKSchoolSubId, searchObject.GKQuestionType, searchObject.GKQuestion, searchObject.GKAnswer, searchObject.GKOption1, searchObject.GKOption2, searchObject.GKOption3, searchObject.GKOption4, searchObject.GKOption5, searchObject.GKQuestionFor, searchObject.GKAddedById, searchObject.GKTestDate, searchObject.GKDate, searchObject.GKStatus);
    }

    /// <summary>
    /// Returns all TMSGeneralKnowledgeDetails objects.
    /// </summary>
    /// <returns>List of all TMSGeneralKnowledgeDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    #region Search GK 
    public static DataSet GetSearchGK(System.Int64? gkKnowledgeId, System.Int64? gkFacultyId, System.Int64? gkStudentId, System.Int64? gkSchoolId, System.Int64? gkSchoolSubId, System.String gkQuestionType, System.String gkQuestion, System.String gkAnswer,System.String gkQuestionFor, System.Int64? gkAddedById, System.DateTime? gkTestDate, System.DateTime? gkDate, System.Int32? gkStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGeneralKnowledgeDetails_SEARCH_New";
        dbCommand = db.GetStoredProcCommand(sqlCommand, gkKnowledgeId, gkFacultyId, gkStudentId, gkSchoolId, gkSchoolSubId, gkQuestionType, gkQuestion, gkAnswer, gkQuestionFor, gkAddedById, gkTestDate, gkDate, gkStatus);

        ds = db.ExecuteDataSet(dbCommand);
        //ds.Tables[0].TableName = TABLE_NAME;
        return ds;
    }
    #endregion
}

