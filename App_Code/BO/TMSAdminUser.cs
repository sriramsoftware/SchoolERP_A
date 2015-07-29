using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSAdminUser
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int32? adminId, System.String adminFirstName, System.String adminMiddleName, System.String adminLastName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.Int64? adminFDLoginId, System.Int64? adminFDFacultyId, System.String adminTitle, System.String adminCaste, System.String adminSubCaste, System.String adminBirthPlace, System.String adminBloodGroup, System.String adminMotherTongue, System.String adminNationality, System.String adminTransportStatus, System.String adminMedicalProblem, System.Int64? adminSchoolCategoryId, System.Int64? adminSchoolSubCategoryId, System.Int64? adminSubjectId, System.String adminInterestPosition, System.String adminCertifiedSubject, System.String adminCertifiedAgeGroup, System.String adminFullTimeTeaching, System.String adminIndustryExpertise, System.String adminSpecificExpertise, System.String adminHighestDegreeCompletd, System.String adminFieldOfStudy, System.String adminUniversity, System.String adminCompletionDate, System.Int64? adminAddressId, System.String adminQualificationDetails, System.String adminExperienceFrom, System.String adminExperienceTo, System.Int64? adminExperienceInYrs, System.String adminImage, System.DateTime? adminJoiningDate, System.DateTime? adminBirthDate, System.String adminGender, System.String adminMarrialStatus, System.String adminAgeProof, System.String adminResume, System.String adminReleavingLetter, System.DateTime? adminRetiredOn, System.String adminExtraOne, System.Int64? adminCreatedBy, System.String adminLastSchoolwas, System.DateTime? adminLastSchoolFromDate, System.DateTime? adminLastSchoolToDate, System.DateTime? adminRegisteredDate, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminUser_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminId, adminFirstName, adminMiddleName, adminLastName, adminEmailId, adminUserName, adminPassword, adminType, adminFDLoginId, adminFDFacultyId, adminTitle, adminCaste, adminSubCaste, adminBirthPlace, adminBloodGroup, adminMotherTongue, adminNationality, adminTransportStatus, adminMedicalProblem, adminSchoolCategoryId, adminSchoolSubCategoryId, adminSubjectId, adminInterestPosition, adminCertifiedSubject, adminCertifiedAgeGroup, adminFullTimeTeaching, adminIndustryExpertise, adminSpecificExpertise, adminHighestDegreeCompletd, adminFieldOfStudy, adminUniversity, adminCompletionDate, adminAddressId, adminQualificationDetails, adminExperienceFrom, adminExperienceTo, adminExperienceInYrs, adminImage, adminJoiningDate, adminBirthDate, adminGender, adminMarrialStatus, adminAgeProof, adminResume, adminReleavingLetter, adminRetiredOn, adminExtraOne, adminCreatedBy, adminLastSchoolwas, adminLastSchoolFromDate, adminLastSchoolToDate, adminRegisteredDate, adminStatus, adminDeletedStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSAdminUser searchObject)
    {
        return GetSearch(searchObject.AdminId, searchObject.AdminFirstName, searchObject.AdminMiddleName, searchObject.AdminLastName, searchObject.AdminEmailId, searchObject.AdminUserName, searchObject.AdminPassword, searchObject.AdminType, searchObject.AdminFDLoginId, searchObject.AdminFDFacultyId, searchObject.AdminTitle, searchObject.AdminCaste, searchObject.AdminSubCaste, searchObject.AdminBirthPlace, searchObject.AdminBloodGroup, searchObject.AdminMotherTongue, searchObject.AdminNationality, searchObject.AdminTransportStatus, searchObject.AdminMedicalProblem, searchObject.AdminSchoolCategoryId, searchObject.AdminSchoolSubCategoryId, searchObject.AdminSubjectId, searchObject.AdminInterestPosition, searchObject.AdminCertifiedSubject, searchObject.AdminCertifiedAgeGroup, searchObject.AdminFullTimeTeaching, searchObject.AdminIndustryExpertise, searchObject.AdminSpecificExpertise, searchObject.AdminHighestDegreeCompletd, searchObject.AdminFieldOfStudy, searchObject.AdminUniversity, searchObject.AdminCompletionDate, searchObject.AdminAddressId, searchObject.AdminQualificationDetails, searchObject.AdminExperienceFrom, searchObject.AdminExperienceTo, searchObject.AdminExperienceInYrs, searchObject.AdminImage, searchObject.AdminJoiningDate, searchObject.AdminBirthDate, searchObject.AdminGender, searchObject.AdminMarrialStatus, searchObject.AdminAgeProof, searchObject.AdminResume, searchObject.AdminReleavingLetter, searchObject.AdminRetiredOn, searchObject.AdminExtraOne, searchObject.AdminCreatedBy, searchObject.AdminLastSchoolwas, searchObject.AdminLastSchoolFromDate, searchObject.AdminLastSchoolToDate, searchObject.AdminRegisteredDate, searchObject.AdminStatus, searchObject.AdminDeletedStatus);
    }

    /// <summary>
    /// Returns all TMSAdminUser objects.
    /// </summary>
    /// <returns>List of all TMSAdminUser objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    #region Get Admin EmailId Details At Update
    public static DataSet GetAdminUserEmailIdDetails(System.String adminEmailId, System.Int32? adminId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSAdminUser_CheckEmailId_IsExistsOrNotAtUpdate";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminEmailId, adminId);

        return db.ExecuteDataSet(dbCommand);

    }
    #endregion

    #region Get Admin UserName Details At Update
    public static DataSet GetAdminUserNameDetails(System.String adminUserName, System.Int32? adminId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSAdminUser_CheckUserName_IsExistsOrNotAtUpdate";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminUserName, adminId);

        return db.ExecuteDataSet(dbCommand);

    }
    #endregion

    public static DataSet GetAdminUserDetails(System.Int32? adminId, System.String adminFirstName, System.String adminMiddleName, System.String adminLastName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.Int64? adminFDLoginId, System.Int64? adminFDFacultyId, System.Int64? adminSchoolCategoryId, System.Int64? adminSchoolSubCategoryId, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminUserSEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminId, adminFirstName, adminMiddleName, adminLastName, adminEmailId, adminUserName, adminPassword, adminType, adminFDLoginId, adminFDFacultyId, adminSchoolCategoryId, adminSchoolSubCategoryId, adminStatus, adminDeletedStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }

    public static DataSet GetAdminUserInformation(System.Int32? adminId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminUserInformation";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminId);
        return db.ExecuteDataSet(dbCommand);

    }

    #region Get Admin DashBoard Quick Statustics
    public static DataSet GetAdminDashBoardQuickStatistics()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSSearchQuickStatistics";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        return db.ExecuteDataSet(dbCommand);
    }
    #endregion


    #region View All AdminUsers
    public static DataSet ViewAllAdminUsers(System.Int32? adminId, System.String adminFirstName, System.String adminMiddleName, System.String adminLastName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.Int64? adminFDLoginId, System.Int64? adminFDFacultyId, System.Int64? adminSchoolCategoryId, System.Int64? adminSchoolSubCategoryId, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSViewAllAdminUsers";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminId, adminFirstName, adminMiddleName, adminLastName, adminEmailId, adminUserName, adminPassword, adminType, adminFDLoginId, adminFDFacultyId, adminSchoolCategoryId, adminSchoolSubCategoryId, adminStatus, adminDeletedStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    #endregion


    public static DataSet BindAdminUsersForDropdown(System.Int32? adminId, System.String adminFirstName, System.String adminMiddleName, System.String adminLastName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.Int64? adminFDLoginId, System.Int64? adminFDFacultyId, System.Int64? adminSchoolCategoryId, System.Int64? adminSchoolSubCategoryId, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSBindAdminUsers]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminId, adminFirstName, adminMiddleName, adminLastName, adminEmailId, adminUserName, adminPassword, adminType, adminFDLoginId, adminFDFacultyId, adminSchoolCategoryId, adminSchoolSubCategoryId, adminStatus, adminDeletedStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
}

