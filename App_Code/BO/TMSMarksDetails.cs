using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSMarksDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? mdMarksDetailsId, System.Int64? mdSchoolId, System.Int64? mdSchoolSubId, System.Int64? mdStudentLoginId, System.Int64? mdSubjectId, System.Int64? mdExamTestId, System.String mdObtainMarks, System.String mdGraceMarks, System.String mdTotalMarks, System.DateTime? mdDate, System.Int64? mdAddedById, System.String mdAddedType, System.Int32? mdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSMarksDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, mdMarksDetailsId, mdSchoolId, mdSchoolSubId, mdStudentLoginId, mdSubjectId, mdExamTestId, mdObtainMarks, mdGraceMarks, mdTotalMarks, mdDate, mdAddedById, mdAddedType, mdStatus);

        return db.ExecuteDataSet(dbCommand);

    }


    public static DataSet GetSearch(TMSMarksDetails searchObject)
    {
        return GetSearch(searchObject.MDMarksDetailsId, searchObject.MDSchoolId, searchObject.MDSchoolSubId, searchObject.MDStudentLoginId, searchObject.MDSubjectId, searchObject.MDExamTestId, searchObject.MDObtainMarks, searchObject.MDGraceMarks, searchObject.MDTotalMarks, searchObject.MDDate, searchObject.MDAddedById, searchObject.MDAddedType, searchObject.MDStatus);
    }

    /// <summary>
    /// Returns all TMSMarksDetails objects.
    /// </summary>
    /// <returns>List of all TMSMarksDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet GetStudentTopperDetails(System.Int64? schoolId, System.Int64? studentId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchTopperStudentDetailsWithPercentage";
        dbCommand = db.GetStoredProcCommand(sqlCommand, schoolId, studentId);
        return ds = db.ExecuteDataSet(dbCommand);
    }
    public static DataSet GetPassoutStudentDetails(System.Int64? studentLoginId, System.Int64? schoolId, System.Int64? schoolSubId, System.String result)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMSSearchPassoutStudent]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, studentLoginId, schoolId, schoolSubId, result);
        return ds = db.ExecuteDataSet(dbCommand);
    }
    public static int GetPassoutStudentInsertNextStandard(System.Int64? studentDetailId, System.String resultText, System.Int64? schoolId, System.String resultYear,System.Decimal? Marks)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSSearchNextStandardInsert";
        dbCommand = db.GetStoredProcCommand(sqlCommand, studentDetailId, resultText, schoolId, resultYear,Marks);
        return db.ExecuteNonQuery(dbCommand);
    }
}

