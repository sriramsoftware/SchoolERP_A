using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSFacultyDetails
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? fdFacultyDetailsId, System.Int64? fdLoginId, System.Int64? fdFacultyId, System.Int64? fdSchoolCatgoryId, System.String fdTitle, System.String fdFirstName, System.String fdMiddleName, System.String fdLastName, System.DateTime? fdDate, System.String fdCaste, System.String fdSubCaste, System.String fdBirthPlace, System.String fdBloodGroup, System.String fdMotherTongue, System.String fdNationality, System.String fdTransportStatus, System.String fdMedicalProblem, System.Int64? fdSchoolCategoryId, System.Int64? fdSchoolSubCategoryId, System.Int64? fdSubjectId, System.String fdInterestPosition, System.String fdCertifiedSubject, System.String fdCertifiedAgeGroup, System.String fdFullTimeTeaching, System.String fdIndustryExpertise, System.String fdSpecificExpertise, System.String fdHighestDegreeCompletd, System.String fdFieldOfStudy, System.String fdUniversity, System.String fdCompletionDate, System.Int64? fdAddressId, System.String fdQualificationDetails, System.String fdExperienceFrom, System.String fdExperienceTo, System.Int64? fdExperienceInYrs, System.String fdImage, System.DateTime? fdJoiningDate, System.DateTime? fdBirthDate, System.String fdGender, System.String fdMarrialStatus, System.String fdAgeProof, System.String fdResume, System.String fdReleavingLetter, System.DateTime? fdRetiredOn, System.String fdExtraOne, System.Int64? fdCreatedBy, System.String fdLastSchoolwas, System.DateTime? fdLastSchoolFromDate, System.DateTime? fdLastSchoolToDate, System.Int32? fdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFacultyDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, fdFacultyDetailsId, fdLoginId, fdFacultyId, fdSchoolCatgoryId, fdTitle, fdFirstName, fdMiddleName, fdLastName, fdDate, fdCaste, fdSubCaste, fdBirthPlace, fdBloodGroup, fdMotherTongue, fdNationality, fdTransportStatus, fdMedicalProblem, fdSchoolCategoryId, fdSchoolSubCategoryId, fdSubjectId, fdInterestPosition, fdCertifiedSubject, fdCertifiedAgeGroup, fdFullTimeTeaching, fdIndustryExpertise, fdSpecificExpertise, fdHighestDegreeCompletd, fdFieldOfStudy, fdUniversity, fdCompletionDate, fdAddressId, fdQualificationDetails, fdExperienceFrom, fdExperienceTo, fdExperienceInYrs, fdImage, fdJoiningDate, fdBirthDate, fdGender, fdMarrialStatus, fdAgeProof, fdResume, fdReleavingLetter, fdRetiredOn, fdExtraOne, fdCreatedBy, fdLastSchoolwas, fdLastSchoolFromDate, fdLastSchoolToDate, fdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }


    public static DataSet GetSearch(TMSFacultyDetails searchObject)
    {
        return GetSearch(searchObject.FDFacultyDetailsId, searchObject.FDLoginId, searchObject.FDFacultyId, searchObject.FDSchoolCatgoryId, searchObject.FDTitle, searchObject.FDFirstName, searchObject.FDMiddleName, searchObject.FDLastName, searchObject.FDDate, searchObject.FDCaste, searchObject.FDSubCaste, searchObject.FDBirthPlace, searchObject.FDBloodGroup, searchObject.FDMotherTongue, searchObject.FDNationality, searchObject.FDTransportStatus, searchObject.FDMedicalProblem, searchObject.FDSchoolCategoryId, searchObject.FDSchoolSubCategoryId, searchObject.FDSubjectId, searchObject.FDInterestPosition, searchObject.FDCertifiedSubject, searchObject.FDCertifiedAgeGroup, searchObject.FDFullTimeTeaching, searchObject.FDIndustryExpertise, searchObject.FDSpecificExpertise, searchObject.FDHighestDegreeCompletd, searchObject.FDFieldOfStudy, searchObject.FDUniversity, searchObject.FDCompletionDate, searchObject.FDAddressId, searchObject.FDQualificationDetails, searchObject.FDExperienceFrom, searchObject.FDExperienceTo, searchObject.FDExperienceInYrs, searchObject.FDImage, searchObject.FDJoiningDate, searchObject.FDBirthDate, searchObject.FDGender, searchObject.FDMarrialStatus, searchObject.FDAgeProof, searchObject.FDResume, searchObject.FDReleavingLetter, searchObject.FDRetiredOn, searchObject.FDExtraOne, searchObject.FDCreatedBy, searchObject.FDLastSchoolwas, searchObject.FDLastSchoolFromDate, searchObject.FDLastSchoolToDate, searchObject.FDStatus);
    }

    /// <summary>
    /// Returns all TMSFacultyDetails objects.
    /// </summary>
    /// <returns>List of all TMSFacultyDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    #region
    public static DataSet GetParentDetails(System.Int64? StudentDetailsId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSParentDetailsSearch]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentDetailsId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    public static DataSet GetSearchParentDetails(System.Int64? StudentDetailsId, System.Int64? ParentDetailsId, System.Int64? SchoolId, System.Int64? SchoolSubId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMS_ParentDetailsSearch]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentDetailsId, ParentDetailsId, SchoolId, SchoolSubId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    #endregion



    #region
    public static DataSet GetTeacherDetails(System.Int64? TEacherDetailsId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSteacher_details]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, TEacherDetailsId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    #endregion
    #region
    public static DataSet GetAccountManagerDetails(System.Int64? TEacherDetailsId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSAccountManger_details]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, TEacherDetailsId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    #endregion
    #region
    public static DataSet GetFacultyDetails(System.Int64? FacultyDetailsId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSFacultyDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    #endregion

    #region
    public static DataSet GetStaffFacultyDetails(System.Int64? FacultyDetailsId, System.Int64? FacultyTypeId, System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSStaffFacultyDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, FacultyTypeId, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    #endregion

    public static DataSet GetTransportStaffFacultyDetails(System.Int64? FacultyDetailsId, System.Int64? FacultyTypeId, System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSTransportStaffFacultyDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, FacultyTypeId, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }

    #region
    public static DataSet GetPricipalDetails(System.Int64? PrincipalId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSPricipal_details]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, PrincipalId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    #endregion
    #region
    public static DataSet GetStaffDetails(System.Int64? staffId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSFacultyDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, staffId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    #endregion

    #region
    public static DataSet GetPrincipalDetails(System.Int64? staffId, System.Int64? principalId, System.Int64? vicePrincipalId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSFacultyPrincipalDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, staffId, principalId, vicePrincipalId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    #endregion


    public static DataSet GetCurrentStaffFacultyDetails(System.Int64? FacultyDetailsId, System.Int64? FacultyTypeId, System.Int64? LoginId, System.String SchoolType, System.Int64? SchoolId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSCurrentStaffFacultyDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, FacultyTypeId, LoginId, SchoolType, SchoolId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }


    public static DataSet GetNewStaffFacultyDetails(System.Int64? FacultyDetailsId, System.Int64? FacultyTypeId, System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSNewStaffFacultyDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, FacultyTypeId, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }

    public static DataSet GetStaffFacultyTeacherDetails(System.Int64? FacultyDetailsId, System.Int64? FacultyTypeId, System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSStaffFacultyTeacherDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, FacultyTypeId, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }



    public static DataSet GetNewStaffFacultyDetailsFilterWise(System.Int64? FacultyDetailsId, System.Int64? FacultyTypeId, System.Int64? LoginId, System.String SchoolType, System.Int64? SchoolId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSNewStaffFacultyDetailsFilterWise]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, FacultyTypeId, LoginId, SchoolType, SchoolId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }




    public static DataSet GetEXStaffFacultyDetails(System.Int64? FacultyDetailsId, System.Int64? FacultyTypeId, System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSEXStaffFacultyDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, FacultyTypeId, LoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }


    public static DataSet GetEXStaffFacultyDetailsFilterWise(System.Int64? FacultyDetailsId, System.Int64? FacultyTypeId, System.Int64? LoginId, System.String SchoolType, System.Int64? SchoolId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSEXStaffFacultyDetailsFilterWise]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, FacultyTypeId, LoginId, SchoolType, SchoolId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }

    public static DataSet FillStandardBy_Teacher(System.Int64? staffId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrFillStandardBy_Teacher]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, staffId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    #region
    public static DataSet GetSearchOtherDeptStaffFacultyDetails(System.Int64? FacultyDetailsId, System.String FacultyName, System.String FacultyType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchOtherStaffDepartment]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, FacultyName, FacultyType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
    #region
    public static DataSet GetSearchFacultyAssignClassSubjectDetails(System.Int64? FacultyDetailsId, System.Int64? FacultyLoginId, System.Int64? SubjectId, System.Int64? SchoolId, System.String FacultyName, System.String SubjectName)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchTeacherAssignClassSubjectDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, FacultyLoginId, SubjectId, SchoolId, FacultyName, SubjectName);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion


    public static DataSet FillSubject_AccordingToteacher(System.Int64? teacherId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrgetsubjectAccordingToteacherID]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, teacherId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }


    public static DataSet GetAllFaculty()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSFacultyDetails_GetAllFaculty]";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }


    public static DataSet GetTeacher_SchoolType_and_StandaradWise(System.Int64? SchoolId, System.String SchoolType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchSchoolTypeWiseAssignTeacher]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolId, SchoolType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }




    public static DataSet FindStandardDivisionSubjectOfTeacher(System.Int64? FacultyDetailsId, System.Int64? FacultyLoginId, System.Int64? SubjectId, System.Int64? SchoolId, System.String SchoolType, System.String FacultyName, System.String SubjectName)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[Search_TeacherSchoolStandardDivision]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, FacultyLoginId, SubjectId, SchoolId, SchoolType, FacultyName, SubjectName);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet FindSubjectAccordingToStandard(System.Int64? SchoolId, System.Int64? FacultyId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSFindSubject_AccordingToStandard]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolId, FacultyId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetSearchStaffFacultyDetails(System.String name, System.String SchoolType, System.String type, System.Int64? FacultytypeID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrSearchByNametypeTeacher]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, name, SchoolType, type, FacultytypeID);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }



    public static DataSet GetFacultyDetails_FilterWise(System.Int64? FacultyDetailsId, System.Int64? FacultyTypeId, System.Int64? LoginId, System.String SchoolType, System.Int64? SchoolId, System.String Name,System.String Status)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSFacultyDetails_FilterWise]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, FacultyTypeId, LoginId, SchoolType, SchoolId, Name, Status);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }

   public static int DeleteAccount(System.Int64? LoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrDeleteAccount]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId);
        int Status = db.ExecuteNonQuery(dbCommand);
        return Status;

    }
    public static DataSet GetTeacherAccordingToSchoolType(System.String SchoolType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrGetTeacherAccordingToSchoolType]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SchoolType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    public static DataSet GetFacultyDetailsSerching(System.Int64? FacultyDetailsId, System.String name, System.DateTime? fromdate, System.DateTime? Todate)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrFacultyDetailsSerching]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, name, fromdate, Todate);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }

    public static DataSet FillTeacherDetailsSearch(System.String fathername, System.String Mothername, System.String StudentName, System.Int64? ID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrFillTeacherDetailsSearch]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, fathername, Mothername, StudentName, ID);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    #region
    public static DataSet GetFacultyDetailsNew(System.Int64? staffId, System.Int64? facultyType1, System.Int64? facultyType2, System.String facultyType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSFacultyPrincipalDetailsNew]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, staffId, facultyType1, facultyType2, facultyType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    #endregion

    public static DataSet FillStaffSearchDetails(System.String Names, System.DateTime? Dates, System.Int64? TypeID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrFillStaffSearchDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Names, Dates, TypeID);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    public static DataSet GetTeacherDetailsSerching(System.Int64? FacultyDetailsId, System.String name, System.DateTime? fromdate, System.DateTime? Todate)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrteacher_details]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, name, fromdate, Todate);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }

    #region
    public static DataSet GetStaffFacultyStatusDetails(System.Int64? FacultyDetailsId, System.Int64? FacultyTypeId, System.Int64? LoginId, System.Int32? Status)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSStaffFacultyStatusDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, FacultyTypeId, LoginId, Status);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    #endregion


    public static DataSet GetSchoolStaffDetailsSerching(System.Int64? FacultyDetailsId, System.String name, System.Int64? Typeid)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrSchoolStaffDetailsSerching]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, FacultyDetailsId, name, Typeid);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
}

