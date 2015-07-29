using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSSubjectAssignSchoolDetails
{
    #region GetSearch
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? sasdAssignId, System.Int64? sasdSchoolId, System.Int64? sasdSchoolSubId, System.Int64? sasdSubjectId, System.Int64? sasdDepartmentId, System.String sasdAssignType, System.DateTime? sasdDate, System.Int32? sasdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSubjectAssignSchoolDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sasdAssignId, sasdSchoolId, sasdSchoolSubId, sasdSubjectId, sasdDepartmentId, sasdAssignType, sasdDate, sasdStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    
    public static DataSet GetSearch(TMSSubjectAssignSchoolDetails searchObject)
    {
        return GetSearch(searchObject.SASDAssignId, searchObject.SASDSchoolId, searchObject.SASDSchoolSubId, searchObject.SASDSubjectId, searchObject.SASDDepartmentId, searchObject.SASDAssignType, searchObject.SASDDate, searchObject.SASDStatus);
    }

    /// <summary>
    /// Returns all TMSSubjectAssignSchoolDetails objects.
    /// </summary>
    /// <returns>List of all TMSSubjectAssignSchoolDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet GetSearchSubjectAssignDetails(System.Int64? sasdAssignId, System.Int64? sasdSchoolId, System.String sasdSchoolType, System.Int64? sasdSubjectId, System.String sasdSubjecName, System.Int64? sasdDepartmentId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchSubjectAssignToClass";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sasdAssignId, sasdSchoolId, sasdSchoolType, sasdSubjectId, sasdSubjecName,sasdDepartmentId);
        ds = db.ExecuteDataSet(dbCommand);       
        return ds;
    }


    public static DataSet GetSubjectAccordingToSchool(System.Int64? sasdSchoolId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrSubjectAccordingToSchool";
        dbCommand = db.GetStoredProcCommand(sqlCommand,sasdSchoolId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

