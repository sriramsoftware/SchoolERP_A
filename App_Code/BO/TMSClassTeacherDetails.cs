using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSClassTeacherDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ctdClassTeacherId, System.Int64? ctdSchoolCatId, System.Int64? ctdSchoolSubCatId, System.Int64? ctdSubjectId, System.Int64? ctdFacultyId, System.String ctdAssignBy, System.DateTime? ctdDate, System.Int32? ctdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSClassTeacherDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ctdClassTeacherId, ctdSchoolCatId, ctdSchoolSubCatId, ctdSubjectId, ctdFacultyId, ctdAssignBy, ctdDate, ctdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSClassTeacherDetails searchObject)
    {
        return GetSearch(searchObject.CTDClassTeacherId, searchObject.CTDSchoolCatId, searchObject.CTDSchoolSubCatId, searchObject.CTDSubjectId, searchObject.CTDFacultyId, searchObject.CTDAssignBy, searchObject.CTDDate, searchObject.CTDStatus);
    }

    /// <summary>
    /// Returns all TMSClassTeacherDetails objects.
    /// </summary>
    /// <returns>List of all TMSClassTeacherDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null);
    }

    #endregion
    public static DataSet GetClassTeacherDeatils(System.Int64? ctdSchoolCatId, System.Int64? ctdSchoolSubCatId, System.Int64? ctdSubjectId, System.Int64? ctdFacultyId, System.String facultyTitle, System.String schoolType, System.Int32? ctdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchClassTeacherDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ctdSchoolCatId, ctdSchoolSubCatId, ctdSubjectId, ctdFacultyId, facultyTitle, schoolType, ctdStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
  
    public static DataSet BindClassTeacherClasswise(System.Int64? ctdSchoolCatId, System.Int64? ctdSchoolSubCatId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSBindClassTeacher]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ctdSchoolCatId, ctdSchoolSubCatId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet BindClassTeacherClasswisePre(System.Int64? ctdSchoolCatId, System.Int64? ctdSchoolSubCatId, System.String facultyname)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSBindClassTeacherPre]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ctdSchoolCatId, ctdSchoolSubCatId, facultyname);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet FillClassMinitorAccordingtostanderd(System.Int64? ctdSchoolCatId, System.Int64? ctdSchoolSubCatId, System.Int64? studentid, System.String facultyname)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrFillClassMinitorAccordingtostanderd]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ctdSchoolCatId, ctdSchoolSubCatId, studentid, facultyname);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}


