using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;


public partial class TMSSchoolSubCategory
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? sscSubCategoryId, System.Int64? sscCategoryId, System.String sscSubCategoryName, System.DateTime? sscDate, System.Int32? sscStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSchoolSubCategory_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sscSubCategoryId, sscCategoryId, sscSubCategoryName, sscDate, sscStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }


    public static DataSet GetSearch(TMSSchoolSubCategory searchObject)
    {
        return GetSearch(searchObject.SSCSubCategoryId, searchObject.SSCCategoryId, searchObject.SSCSubCategoryName, searchObject.SSCDate, searchObject.SSCStatus);
    }

    /// <summary>
    /// Returns all TMSSchoolSubCategory objects.
    /// </summary>
    /// <returns>List of all TMSSchoolSubCategory objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null);
    }

    #endregion


    public static DataSet SearchDivisionAccordingToSchoolType(System.Int64? DivisionId, System.Int64? StandardId, System.String DivisionName, System.String StandardName, System.String SchoolType, System.Int32? Status)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSchoolSubCategory_AccordingtoType";
        dbCommand = db.GetStoredProcCommand(sqlCommand, DivisionId, StandardId, DivisionName, StandardName, SchoolType, Status);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


public static DataSet ChechAlredyDivisionExist(System.Int64? sscSubCategoryId, System.Int64? sscCategoryId, System.String sscSubCategoryName, System.String Type, System.Int32? sscStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].ChechAlredyDivisionExist";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sscSubCategoryId, sscCategoryId, sscSubCategoryName, Type, sscStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    

}

