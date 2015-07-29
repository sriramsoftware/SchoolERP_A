using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSStudentApplication
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? saApplicationId, System.String saStudentPNRId, System.String saFirstName, System.String saMiddleName, System.String saLastName, System.DateTime? saDateOfBirth, System.String saPlaceOfBirth, System.String saAcadamicYear, System.String saBloodGroup, System.String saStudentImage, System.String saNationality, System.String saGender, System.String saCaste, System.String saSubCaste, System.DateTime? saDateOfApplication, System.String saMotherTongue, System.Int64? saSchoolCategoryId, System.String saTransportStatus, System.String saMedicalProblem, System.String saLastSchoolAttended, System.String saLastClassAttended, System.String saLastClassPer, System.String saFatherFullName, System.String saFatherPhoto, System.String saFatherEduQualification, System.String saFatherOccupation, System.Int64? saFatherAddressId, System.String saFatherOrgName, System.String saFatherDsgtName, System.String saMotherFullName, System.String saMotherPhoto, System.String saMotherEduQualification, System.String saMotherOccupation, System.Int64? saMotherAddressId, System.String saMotherOrgName, System.String saMotherDsgtName, System.Int64? saAddressId, System.String saAgeProof, System.String saLastProgressReportCard, System.String saOriginalSchoolLC, System.String saPassportAndVisa, System.String saRegistrationLetter, System.String saApplicationStatus, System.Int32? saStatus, System.String saFormNo)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudentApplication_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, saApplicationId, saStudentPNRId, saFirstName, saMiddleName, saLastName, saDateOfBirth, saPlaceOfBirth, saAcadamicYear, saBloodGroup, saStudentImage, saNationality, saGender, saCaste, saSubCaste, saDateOfApplication, saMotherTongue, saSchoolCategoryId, saTransportStatus, saMedicalProblem, saLastSchoolAttended, saLastClassAttended, saLastClassPer, saFatherFullName, saFatherPhoto, saFatherEduQualification, saFatherOccupation, saFatherAddressId, saFatherOrgName, saFatherDsgtName, saMotherFullName, saMotherPhoto, saMotherEduQualification, saMotherOccupation, saMotherAddressId, saMotherOrgName, saMotherDsgtName, saAddressId, saAgeProof, saLastProgressReportCard, saOriginalSchoolLC, saPassportAndVisa, saRegistrationLetter, saApplicationStatus, saStatus, saFormNo);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSStudentApplication searchObject)
    {
        return GetSearch(searchObject.SAApplicationId, searchObject.SAStudentPNRId, searchObject.SAFirstName, searchObject.SAMiddleName, searchObject.SALastName, searchObject.SADateOfBirth, searchObject.SAPlaceOfBirth, searchObject.SAAcadamicYear, searchObject.SABloodGroup, searchObject.SAStudentImage, searchObject.SANationality, searchObject.SAGender, searchObject.SACaste, searchObject.SASubCaste, searchObject.SADateOfApplication, searchObject.SAMotherTongue, searchObject.SASchoolCategoryId, searchObject.SATransportStatus, searchObject.SAMedicalProblem, searchObject.SALastSchoolAttended, searchObject.SALastClassAttended, searchObject.SALastClassPer, searchObject.SAFatherFullName, searchObject.SAFatherPhoto, searchObject.SAFatherEduQualification, searchObject.SAFatherOccupation, searchObject.SAFatherAddressId, searchObject.SAFatherOrgName, searchObject.SAFatherDsgtName, searchObject.SAMotherFullName, searchObject.SAMotherPhoto, searchObject.SAMotherEduQualification, searchObject.SAMotherOccupation, searchObject.SAMotherAddressId, searchObject.SAMotherOrgName, searchObject.SAMotherDsgtName, searchObject.SAAddressId, searchObject.SAAgeProof, searchObject.SALastProgressReportCard, searchObject.SAOriginalSchoolLC, searchObject.SAPassportAndVisa, searchObject.SARegistrationLetter, searchObject.SAApplicationStatus, searchObject.SAStatus, searchObject.SAFormNo);
    }

    /// <summary>
    /// Returns all TMSStudentApplication objects.
    /// </summary>
    /// <returns>List of all TMSStudentApplication objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
    #region Student Application Details
    public static DataSet GetStudentApplicationDetails(System.String ApplicationStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudentApplicationDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ApplicationStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
    #region Student Application Details
    public static DataSet GetStudentApplicationDetailsSearch(System.Int64? StudentAppId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSStudentApplicationDetailsSearch]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentAppId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

    public static DataSet BindStudentApplicationDetailsSearch(System.Int64? SatandardID, System.DateTime? saDate, System.String ApplicationStatus, System.String ApplicationPercentTo, System.String ApplicationPercentFrom, System.String Status)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudentApplicationDetailsSort";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SatandardID, saDate, ApplicationStatus, ApplicationPercentTo, ApplicationPercentFrom, Status);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet FillStudentApplication()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillStudentApplication";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet FillArticleCommen()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillArticleComment";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet FillStudentDetails()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillStudentDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet FillExamTypeDetails()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillExamTypeDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

