using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSSchoolCategory
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? scCategoryId, System.String scCategoryName, System.String scSchoolType, System.DateTime? scDate, System.Int32? scStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSchoolCategory_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, scCategoryId, scCategoryName, scSchoolType, scDate, scStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSSchoolCategory searchObject)
    {
        return GetSearch(searchObject.SCCategoryId, searchObject.SCCategoryName, searchObject.SCSchoolType, searchObject.SCDate, searchObject.SCStatus);
    }

    /// <summary>
    /// Returns all TMSSchoolCategory objects.
    /// </summary>
    /// <returns>List of all TMSSchoolCategory objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null);
    }



    public static DataSet FillStanderddivision()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFetch_StanderdDivisionCount";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet Filldivisiondetails(System.Int64? scCategoryId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillDivisionDetailBystanderd";
        dbCommand = db.GetStoredProcCommand(sqlCommand, scCategoryId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet FacultybyStandard(System.Int64? scCategoryId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gsprgetFacultybyStanderd";
        dbCommand = db.GetStoredProcCommand(sqlCommand, scCategoryId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet FillclassTeacher(System.Int64? scCategoryId, System.Int64? scSubCategoryId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFetchClassteacher";
        dbCommand = db.GetStoredProcCommand(sqlCommand, scCategoryId, scSubCategoryId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet FillSubjectAccordingTostandard(System.Int64? scCategoryId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillSubjectAccordingTostandard";
        dbCommand = db.GetStoredProcCommand(sqlCommand, scCategoryId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet StandardByFaculty(System.Int64? FacultyID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillStandardbyteacher";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyID);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

    public static DataSet SearchStandardAccordingToSchoolType( System.String SchoolType,System.Int32? Status)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSchoolCategory_AccordingtoType";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolType, Status);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetAllSchoolCategory()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetAllSchoolCategory";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


}

