using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSClassAssignFacultyDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? cafdAssignId, System.Int64? cafdFacultyId, System.Int64? cafdSchoolId, System.Int64? cafdSchoolSubCategoryId, System.Int64? cafdDepartmentId, System.Int64? cafdSubjectId, System.String cafdAssignType, System.DateTime? cafdDate, System.Int32? cafdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSClassAssignFacultyDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, cafdAssignId, cafdFacultyId, cafdSchoolId, cafdSchoolSubCategoryId, cafdDepartmentId, cafdSubjectId, cafdAssignType, cafdDate, cafdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSClassAssignFacultyDetails searchObject)
    {
        return GetSearch(searchObject.CAFDAssignId, searchObject.CAFDFacultyId, searchObject.CAFDSchoolId, searchObject.CAFDSchoolSubCategoryId, searchObject.CAFDDepartmentId, searchObject.CAFDSubjectId, searchObject.CAFDAssignType, searchObject.CAFDDate, searchObject.CAFDStatus);
    }

    /// <summary>
    /// Returns all TMSClassAssignFacultyDetails objects.
    /// </summary>
    /// <returns>List of all TMSClassAssignFacultyDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet FiillClaasAssignToTeacherDetails(System.String SchoolType, System.Int64? StandardID, System.String name)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrClaasAssignToTeacherDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolType, StandardID, name);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet BindClassAssignTeacher(System.Int64? safdClassId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchClassAssignFaculty]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, safdClassId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSearchClassAssignTeacherDetails(System.Int64? safdClassId, System.Int64? safdSubClassId, System.Int64? safdFacultyId, System.String safdFacultyTitle, System.String safdClassType, System.Int32? safdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchClassAssignDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, safdClassId, safdSubClassId, safdFacultyId, safdFacultyTitle, safdClassType, safdStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSearchClassAssignTeacherDetails1(System.Int64? safdClassId, System.Int64? safdSubClassId, System.Int64? safdFacultyId, System.String safdFacultyTitle, System.String safdClassType, System.Int32? safdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchFacultyClassAssignDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, safdClassId, safdSubClassId, safdFacultyId, safdFacultyTitle, safdClassType, safdStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet FiillDivisioninTeacher(System.Int64? FaculltyID, System.Int64? StandardID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrFillDivision_InTeacher]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FaculltyID, StandardID);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet BindOthreTeachers(System.Int64? ClassId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_UpdateClassTeacher]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ClassId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

}

