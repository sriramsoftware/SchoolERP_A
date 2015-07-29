/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 10/10/2012 12:09:43 PM                                    */
/*                                                                          */
/* www.CodeAuthor.org                                                       */
/****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

[DataObject]
[Serializable]
public partial class TMSAdminUser
{


    #region Constants
    private static readonly string TABLE_NAME = "[dbo].[TMS_AdminUser]";

    #endregion


    #region Fields
    private System.Int32? _adminId;
    private System.String _adminFirstName;
    private System.String _adminMiddleName;
    private System.String _adminLastName;
    private System.String _adminEmailId;
    private System.String _adminUserName;
    private System.String _adminPassword;
    private System.Int32? _adminType;
    private System.Int64? _adminFDLoginId;
    private System.Int64? _adminFDFacultyId;
    private System.String _adminTitle;
    private System.String _adminCaste;
    private System.String _adminSubCaste;
    private System.String _adminBirthPlace;
    private System.String _adminBloodGroup;
    private System.String _adminMotherTongue;
    private System.String _adminNationality;
    private System.String _adminTransportStatus;
    private System.String _adminMedicalProblem;
    private System.Int64? _adminSchoolCategoryId;
    private System.Int64? _adminSchoolSubCategoryId;
    private System.Int64? _adminSubjectId;
    private System.String _adminInterestPosition;
    private System.String _adminCertifiedSubject;
    private System.String _adminCertifiedAgeGroup;
    private System.String _adminFullTimeTeaching;
    private System.String _adminIndustryExpertise;
    private System.String _adminSpecificExpertise;
    private System.String _adminHighestDegreeCompletd;
    private System.String _adminFieldOfStudy;
    private System.String _adminUniversity;
    private System.String _adminCompletionDate;
    private System.Int64? _adminAddressId;
    private System.String _adminQualificationDetails;
    private System.String _adminExperienceFrom;
    private System.String _adminExperienceTo;
    private System.Int64? _adminExperienceInYrs;
    private System.String _adminImage;
    private System.DateTime? _adminJoiningDate;
    private System.DateTime? _adminBirthDate;
    private System.String _adminGender;
    private System.String _adminMarrialStatus;
    private System.String _adminAgeProof;
    private System.String _adminResume;
    private System.String _adminReleavingLetter;
    private System.DateTime? _adminRetiredOn;
    private System.String _adminExtraOne;
    private System.Int64? _adminCreatedBy;
    private System.String _adminLastSchoolwas;
    private System.DateTime? _adminLastSchoolFromDate;
    private System.DateTime? _adminLastSchoolToDate;
    private System.DateTime? _adminRegisteredDate;
    private System.Boolean? _adminStatus;
    private System.Boolean? _adminDeletedStatus;

    #endregion


    #region Properties
    public System.Int32? AdminId
    {
        get
        {
            return _adminId;
        }
        set
        {
            _adminId = value;
        }
    }

    public System.String AdminFirstName
    {
        get
        {
            return _adminFirstName;
        }
        set
        {
            _adminFirstName = value;
        }
    }

    public System.String AdminMiddleName
    {
        get
        {
            return _adminMiddleName;
        }
        set
        {
            _adminMiddleName = value;
        }
    }

    public System.String AdminLastName
    {
        get
        {
            return _adminLastName;
        }
        set
        {
            _adminLastName = value;
        }
    }

    public System.String AdminEmailId
    {
        get
        {
            return _adminEmailId;
        }
        set
        {
            _adminEmailId = value;
        }
    }

    public System.String AdminUserName
    {
        get
        {
            return _adminUserName;
        }
        set
        {
            _adminUserName = value;
        }
    }

    public System.String AdminPassword
    {
        get
        {
            return _adminPassword;
        }
        set
        {
            _adminPassword = value;
        }
    }

    public System.Int32? AdminType
    {
        get
        {
            return _adminType;
        }
        set
        {
            _adminType = value;
        }
    }

    public System.Int64? AdminFDLoginId
    {
        get
        {
            return _adminFDLoginId;
        }
        set
        {
            _adminFDLoginId = value;
        }
    }

    public System.Int64? AdminFDFacultyId
    {
        get
        {
            return _adminFDFacultyId;
        }
        set
        {
            _adminFDFacultyId = value;
        }
    }

    public System.String AdminTitle
    {
        get
        {
            return _adminTitle;
        }
        set
        {
            _adminTitle = value;
        }
    }

    public System.String AdminCaste
    {
        get
        {
            return _adminCaste;
        }
        set
        {
            _adminCaste = value;
        }
    }

    public System.String AdminSubCaste
    {
        get
        {
            return _adminSubCaste;
        }
        set
        {
            _adminSubCaste = value;
        }
    }

    public System.String AdminBirthPlace
    {
        get
        {
            return _adminBirthPlace;
        }
        set
        {
            _adminBirthPlace = value;
        }
    }

    public System.String AdminBloodGroup
    {
        get
        {
            return _adminBloodGroup;
        }
        set
        {
            _adminBloodGroup = value;
        }
    }

    public System.String AdminMotherTongue
    {
        get
        {
            return _adminMotherTongue;
        }
        set
        {
            _adminMotherTongue = value;
        }
    }

    public System.String AdminNationality
    {
        get
        {
            return _adminNationality;
        }
        set
        {
            _adminNationality = value;
        }
    }

    public System.String AdminTransportStatus
    {
        get
        {
            return _adminTransportStatus;
        }
        set
        {
            _adminTransportStatus = value;
        }
    }

    public System.String AdminMedicalProblem
    {
        get
        {
            return _adminMedicalProblem;
        }
        set
        {
            _adminMedicalProblem = value;
        }
    }

    public System.Int64? AdminSchoolCategoryId
    {
        get
        {
            return _adminSchoolCategoryId;
        }
        set
        {
            _adminSchoolCategoryId = value;
        }
    }

    public System.Int64? AdminSchoolSubCategoryId
    {
        get
        {
            return _adminSchoolSubCategoryId;
        }
        set
        {
            _adminSchoolSubCategoryId = value;
        }
    }

    public System.Int64? AdminSubjectId
    {
        get
        {
            return _adminSubjectId;
        }
        set
        {
            _adminSubjectId = value;
        }
    }

    public System.String AdminInterestPosition
    {
        get
        {
            return _adminInterestPosition;
        }
        set
        {
            _adminInterestPosition = value;
        }
    }

    public System.String AdminCertifiedSubject
    {
        get
        {
            return _adminCertifiedSubject;
        }
        set
        {
            _adminCertifiedSubject = value;
        }
    }

    public System.String AdminCertifiedAgeGroup
    {
        get
        {
            return _adminCertifiedAgeGroup;
        }
        set
        {
            _adminCertifiedAgeGroup = value;
        }
    }

    public System.String AdminFullTimeTeaching
    {
        get
        {
            return _adminFullTimeTeaching;
        }
        set
        {
            _adminFullTimeTeaching = value;
        }
    }

    public System.String AdminIndustryExpertise
    {
        get
        {
            return _adminIndustryExpertise;
        }
        set
        {
            _adminIndustryExpertise = value;
        }
    }

    public System.String AdminSpecificExpertise
    {
        get
        {
            return _adminSpecificExpertise;
        }
        set
        {
            _adminSpecificExpertise = value;
        }
    }

    public System.String AdminHighestDegreeCompletd
    {
        get
        {
            return _adminHighestDegreeCompletd;
        }
        set
        {
            _adminHighestDegreeCompletd = value;
        }
    }

    public System.String AdminFieldOfStudy
    {
        get
        {
            return _adminFieldOfStudy;
        }
        set
        {
            _adminFieldOfStudy = value;
        }
    }

    public System.String AdminUniversity
    {
        get
        {
            return _adminUniversity;
        }
        set
        {
            _adminUniversity = value;
        }
    }

    public System.String AdminCompletionDate
    {
        get
        {
            return _adminCompletionDate;
        }
        set
        {
            _adminCompletionDate = value;
        }
    }

    public System.Int64? AdminAddressId
    {
        get
        {
            return _adminAddressId;
        }
        set
        {
            _adminAddressId = value;
        }
    }

    public System.String AdminQualificationDetails
    {
        get
        {
            return _adminQualificationDetails;
        }
        set
        {
            _adminQualificationDetails = value;
        }
    }

    public System.String AdminExperienceFrom
    {
        get
        {
            return _adminExperienceFrom;
        }
        set
        {
            _adminExperienceFrom = value;
        }
    }

    public System.String AdminExperienceTo
    {
        get
        {
            return _adminExperienceTo;
        }
        set
        {
            _adminExperienceTo = value;
        }
    }

    public System.Int64? AdminExperienceInYrs
    {
        get
        {
            return _adminExperienceInYrs;
        }
        set
        {
            _adminExperienceInYrs = value;
        }
    }

    public System.String AdminImage
    {
        get
        {
            return _adminImage;
        }
        set
        {
            _adminImage = value;
        }
    }

    public System.DateTime? AdminJoiningDate
    {
        get
        {
            return _adminJoiningDate;
        }
        set
        {
            _adminJoiningDate = value;
        }
    }

    public System.DateTime? AdminBirthDate
    {
        get
        {
            return _adminBirthDate;
        }
        set
        {
            _adminBirthDate = value;
        }
    }

    public System.String AdminGender
    {
        get
        {
            return _adminGender;
        }
        set
        {
            _adminGender = value;
        }
    }

    public System.String AdminMarrialStatus
    {
        get
        {
            return _adminMarrialStatus;
        }
        set
        {
            _adminMarrialStatus = value;
        }
    }

    public System.String AdminAgeProof
    {
        get
        {
            return _adminAgeProof;
        }
        set
        {
            _adminAgeProof = value;
        }
    }

    public System.String AdminResume
    {
        get
        {
            return _adminResume;
        }
        set
        {
            _adminResume = value;
        }
    }

    public System.String AdminReleavingLetter
    {
        get
        {
            return _adminReleavingLetter;
        }
        set
        {
            _adminReleavingLetter = value;
        }
    }

    public System.DateTime? AdminRetiredOn
    {
        get
        {
            return _adminRetiredOn;
        }
        set
        {
            _adminRetiredOn = value;
        }
    }

    public System.String AdminExtraOne
    {
        get
        {
            return _adminExtraOne;
        }
        set
        {
            _adminExtraOne = value;
        }
    }

    public System.Int64? AdminCreatedBy
    {
        get
        {
            return _adminCreatedBy;
        }
        set
        {
            _adminCreatedBy = value;
        }
    }

    public System.String AdminLastSchoolwas
    {
        get
        {
            return _adminLastSchoolwas;
        }
        set
        {
            _adminLastSchoolwas = value;
        }
    }

    public System.DateTime? AdminLastSchoolFromDate
    {
        get
        {
            return _adminLastSchoolFromDate;
        }
        set
        {
            _adminLastSchoolFromDate = value;
        }
    }

    public System.DateTime? AdminLastSchoolToDate
    {
        get
        {
            return _adminLastSchoolToDate;
        }
        set
        {
            _adminLastSchoolToDate = value;
        }
    }

    public System.DateTime? AdminRegisteredDate
    {
        get
        {
            return _adminRegisteredDate;
        }
        set
        {
            _adminRegisteredDate = value;
        }
    }

    public System.Boolean? AdminStatus
    {
        get
        {
            return _adminStatus;
        }
        set
        {
            _adminStatus = value;
        }
    }

    public System.Boolean? AdminDeletedStatus
    {
        get
        {
            return _adminDeletedStatus;
        }
        set
        {
            _adminDeletedStatus = value;
        }
    }

    #endregion


    #region Methods


    #region Mapping Methods

    protected void MapTo(DataSet ds)
    {
        DataRow dr;


        if (ds == null)
            ds = new DataSet();

        if (ds.Tables["TABLE_NAME"] == null)
            ds.Tables.Add(TABLE_NAME);

        ds.Tables[TABLE_NAME].Columns.Add("Admin_Id", typeof(System.Int32));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_FirstName", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_MiddleName", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_LastName", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_EmailId", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_UserName", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_Password", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_Type", typeof(System.Int32));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_FDLoginId", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_FDFacultyId", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_Title", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_Caste", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_SubCaste", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_BirthPlace", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_BloodGroup", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_MotherTounge", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_Nationality", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_TransportStatus", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_MedicalProblem", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_SchoolCategoryId", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_SchoolSubCategoryId", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_SubjectId", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_InterestPosition", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_CertifiedSubject", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_CertifiedAgeGroup", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_FullTimeTeaching", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_IndustryExpertise", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_SpecificExpertise", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_HighestDegreeCompletd", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_FieldOfStudy", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_University", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_CompletionDate", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_AddressId", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_QualificationDetails", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_ExperienceFrom", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_ExperienceTo", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_ExperienceInYrs", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_Image", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_JoiningDate", typeof(System.DateTime));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_BirthDate", typeof(System.DateTime));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_Gender", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_MarrialStatus", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_AgeProof", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_Resume", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_ReleavingLetter", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_RetiredOn", typeof(System.DateTime));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_ExtraOne", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_CreatedBy", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_LastSchoolwas", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_LastSchoolFromDate", typeof(System.DateTime));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_LastSchoolToDate", typeof(System.DateTime));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_RegisteredDate", typeof(System.DateTime));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_Status", typeof(System.Boolean));
        ds.Tables[TABLE_NAME].Columns.Add("Admin_DeletedStatus", typeof(System.Boolean));

        dr = ds.Tables[TABLE_NAME].NewRow();

        if (AdminId == null)
            dr["Admin_Id"] = DBNull.Value;
        else
            dr["Admin_Id"] = AdminId;

        if (AdminFirstName == null)
            dr["Admin_FirstName"] = DBNull.Value;
        else
            dr["Admin_FirstName"] = AdminFirstName;

        if (AdminMiddleName == null)
            dr["Admin_MiddleName"] = DBNull.Value;
        else
            dr["Admin_MiddleName"] = AdminMiddleName;

        if (AdminLastName == null)
            dr["Admin_LastName"] = DBNull.Value;
        else
            dr["Admin_LastName"] = AdminLastName;

        if (AdminEmailId == null)
            dr["Admin_EmailId"] = DBNull.Value;
        else
            dr["Admin_EmailId"] = AdminEmailId;

        if (AdminUserName == null)
            dr["Admin_UserName"] = DBNull.Value;
        else
            dr["Admin_UserName"] = AdminUserName;

        if (AdminPassword == null)
            dr["Admin_Password"] = DBNull.Value;
        else
            dr["Admin_Password"] = AdminPassword;

        if (AdminType == null)
            dr["Admin_Type"] = DBNull.Value;
        else
            dr["Admin_Type"] = AdminType;

        if (AdminFDLoginId == null)
            dr["Admin_FDLoginId"] = DBNull.Value;
        else
            dr["Admin_FDLoginId"] = AdminFDLoginId;

        if (AdminFDFacultyId == null)
            dr["Admin_FDFacultyId"] = DBNull.Value;
        else
            dr["Admin_FDFacultyId"] = AdminFDFacultyId;

        if (AdminTitle == null)
            dr["Admin_Title"] = DBNull.Value;
        else
            dr["Admin_Title"] = AdminTitle;

        if (AdminCaste == null)
            dr["Admin_Caste"] = DBNull.Value;
        else
            dr["Admin_Caste"] = AdminCaste;

        if (AdminSubCaste == null)
            dr["Admin_SubCaste"] = DBNull.Value;
        else
            dr["Admin_SubCaste"] = AdminSubCaste;

        if (AdminBirthPlace == null)
            dr["Admin_BirthPlace"] = DBNull.Value;
        else
            dr["Admin_BirthPlace"] = AdminBirthPlace;

        if (AdminBloodGroup == null)
            dr["Admin_BloodGroup"] = DBNull.Value;
        else
            dr["Admin_BloodGroup"] = AdminBloodGroup;

        if (AdminMotherTongue == null)
            dr["Admin_MotherTounge"] = DBNull.Value;
        else
            dr["Admin_MotherTounge"] = AdminMotherTongue;

        if (AdminNationality == null)
            dr["Admin_Nationality"] = DBNull.Value;
        else
            dr["Admin_Nationality"] = AdminNationality;

        if (AdminTransportStatus == null)
            dr["Admin_TransportStatus"] = DBNull.Value;
        else
            dr["Admin_TransportStatus"] = AdminTransportStatus;

        if (AdminMedicalProblem == null)
            dr["Admin_MedicalProblem"] = DBNull.Value;
        else
            dr["Admin_MedicalProblem"] = AdminMedicalProblem;

        if (AdminSchoolCategoryId == null)
            dr["Admin_SchoolCategoryId"] = DBNull.Value;
        else
            dr["Admin_SchoolCategoryId"] = AdminSchoolCategoryId;

        if (AdminSchoolSubCategoryId == null)
            dr["Admin_SchoolSubCategoryId"] = DBNull.Value;
        else
            dr["Admin_SchoolSubCategoryId"] = AdminSchoolSubCategoryId;

        if (AdminSubjectId == null)
            dr["Admin_SubjectId"] = DBNull.Value;
        else
            dr["Admin_SubjectId"] = AdminSubjectId;

        if (AdminInterestPosition == null)
            dr["Admin_InterestPosition"] = DBNull.Value;
        else
            dr["Admin_InterestPosition"] = AdminInterestPosition;

        if (AdminCertifiedSubject == null)
            dr["Admin_CertifiedSubject"] = DBNull.Value;
        else
            dr["Admin_CertifiedSubject"] = AdminCertifiedSubject;

        if (AdminCertifiedAgeGroup == null)
            dr["Admin_CertifiedAgeGroup"] = DBNull.Value;
        else
            dr["Admin_CertifiedAgeGroup"] = AdminCertifiedAgeGroup;

        if (AdminFullTimeTeaching == null)
            dr["Admin_FullTimeTeaching"] = DBNull.Value;
        else
            dr["Admin_FullTimeTeaching"] = AdminFullTimeTeaching;

        if (AdminIndustryExpertise == null)
            dr["Admin_IndustryExpertise"] = DBNull.Value;
        else
            dr["Admin_IndustryExpertise"] = AdminIndustryExpertise;

        if (AdminSpecificExpertise == null)
            dr["Admin_SpecificExpertise"] = DBNull.Value;
        else
            dr["Admin_SpecificExpertise"] = AdminSpecificExpertise;

        if (AdminHighestDegreeCompletd == null)
            dr["Admin_HighestDegreeCompletd"] = DBNull.Value;
        else
            dr["Admin_HighestDegreeCompletd"] = AdminHighestDegreeCompletd;

        if (AdminFieldOfStudy == null)
            dr["Admin_FieldOfStudy"] = DBNull.Value;
        else
            dr["Admin_FieldOfStudy"] = AdminFieldOfStudy;

        if (AdminUniversity == null)
            dr["Admin_University"] = DBNull.Value;
        else
            dr["Admin_University"] = AdminUniversity;

        if (AdminCompletionDate == null)
            dr["Admin_CompletionDate"] = DBNull.Value;
        else
            dr["Admin_CompletionDate"] = AdminCompletionDate;

        if (AdminAddressId == null)
            dr["Admin_AddressId"] = DBNull.Value;
        else
            dr["Admin_AddressId"] = AdminAddressId;

        if (AdminQualificationDetails == null)
            dr["Admin_QualificationDetails"] = DBNull.Value;
        else
            dr["Admin_QualificationDetails"] = AdminQualificationDetails;

        if (AdminExperienceFrom == null)
            dr["Admin_ExperienceFrom"] = DBNull.Value;
        else
            dr["Admin_ExperienceFrom"] = AdminExperienceFrom;

        if (AdminExperienceTo == null)
            dr["Admin_ExperienceTo"] = DBNull.Value;
        else
            dr["Admin_ExperienceTo"] = AdminExperienceTo;

        if (AdminExperienceInYrs == null)
            dr["Admin_ExperienceInYrs"] = DBNull.Value;
        else
            dr["Admin_ExperienceInYrs"] = AdminExperienceInYrs;

        if (AdminImage == null)
            dr["Admin_Image"] = DBNull.Value;
        else
            dr["Admin_Image"] = AdminImage;

        if (AdminJoiningDate == null)
            dr["Admin_JoiningDate"] = DBNull.Value;
        else
            dr["Admin_JoiningDate"] = AdminJoiningDate;

        if (AdminBirthDate == null)
            dr["Admin_BirthDate"] = DBNull.Value;
        else
            dr["Admin_BirthDate"] = AdminBirthDate;

        if (AdminGender == null)
            dr["Admin_Gender"] = DBNull.Value;
        else
            dr["Admin_Gender"] = AdminGender;

        if (AdminMarrialStatus == null)
            dr["Admin_MarrialStatus"] = DBNull.Value;
        else
            dr["Admin_MarrialStatus"] = AdminMarrialStatus;

        if (AdminAgeProof == null)
            dr["Admin_AgeProof"] = DBNull.Value;
        else
            dr["Admin_AgeProof"] = AdminAgeProof;

        if (AdminResume == null)
            dr["Admin_Resume"] = DBNull.Value;
        else
            dr["Admin_Resume"] = AdminResume;

        if (AdminReleavingLetter == null)
            dr["Admin_ReleavingLetter"] = DBNull.Value;
        else
            dr["Admin_ReleavingLetter"] = AdminReleavingLetter;

        if (AdminRetiredOn == null)
            dr["Admin_RetiredOn"] = DBNull.Value;
        else
            dr["Admin_RetiredOn"] = AdminRetiredOn;

        if (AdminExtraOne == null)
            dr["Admin_ExtraOne"] = DBNull.Value;
        else
            dr["Admin_ExtraOne"] = AdminExtraOne;

        if (AdminCreatedBy == null)
            dr["Admin_CreatedBy"] = DBNull.Value;
        else
            dr["Admin_CreatedBy"] = AdminCreatedBy;

        if (AdminLastSchoolwas == null)
            dr["Admin_LastSchoolwas"] = DBNull.Value;
        else
            dr["Admin_LastSchoolwas"] = AdminLastSchoolwas;

        if (AdminLastSchoolFromDate == null)
            dr["Admin_LastSchoolFromDate"] = DBNull.Value;
        else
            dr["Admin_LastSchoolFromDate"] = AdminLastSchoolFromDate;

        if (AdminLastSchoolToDate == null)
            dr["Admin_LastSchoolToDate"] = DBNull.Value;
        else
            dr["Admin_LastSchoolToDate"] = AdminLastSchoolToDate;

        if (AdminRegisteredDate == null)
            dr["Admin_RegisteredDate"] = DBNull.Value;
        else
            dr["Admin_RegisteredDate"] = AdminRegisteredDate;

        if (AdminStatus == null)
            dr["Admin_Status"] = DBNull.Value;
        else
            dr["Admin_Status"] = AdminStatus;

        if (AdminDeletedStatus == null)
            dr["Admin_DeletedStatus"] = DBNull.Value;
        else
            dr["Admin_DeletedStatus"] = AdminDeletedStatus;


        ds.Tables[TABLE_NAME].Rows.Add(dr);

    }

    protected void MapFrom(DataRow dr)
    {
        AdminId = dr["Admin_Id"] != DBNull.Value ? Convert.ToInt32(dr["Admin_Id"]) : AdminId = null;
        AdminFirstName = dr["Admin_FirstName"] != DBNull.Value ? Convert.ToString(dr["Admin_FirstName"]) : AdminFirstName = null;
        AdminMiddleName = dr["Admin_MiddleName"] != DBNull.Value ? Convert.ToString(dr["Admin_MiddleName"]) : AdminMiddleName = null;
        AdminLastName = dr["Admin_LastName"] != DBNull.Value ? Convert.ToString(dr["Admin_LastName"]) : AdminLastName = null;
        AdminEmailId = dr["Admin_EmailId"] != DBNull.Value ? Convert.ToString(dr["Admin_EmailId"]) : AdminEmailId = null;
        AdminUserName = dr["Admin_UserName"] != DBNull.Value ? Convert.ToString(dr["Admin_UserName"]) : AdminUserName = null;
        AdminPassword = dr["Admin_Password"] != DBNull.Value ? Convert.ToString(dr["Admin_Password"]) : AdminPassword = null;
        AdminType = dr["Admin_Type"] != DBNull.Value ? Convert.ToInt32(dr["Admin_Type"]) : AdminType = null;
        AdminFDLoginId = dr["Admin_FDLoginId"] != DBNull.Value ? Convert.ToInt64(dr["Admin_FDLoginId"]) : AdminFDLoginId = null;
        AdminFDFacultyId = dr["Admin_FDFacultyId"] != DBNull.Value ? Convert.ToInt64(dr["Admin_FDFacultyId"]) : AdminFDFacultyId = null;
        AdminTitle = dr["Admin_Title"] != DBNull.Value ? Convert.ToString(dr["Admin_Title"]) : AdminTitle = null;
        AdminCaste = dr["Admin_Caste"] != DBNull.Value ? Convert.ToString(dr["Admin_Caste"]) : AdminCaste = null;
        AdminSubCaste = dr["Admin_SubCaste"] != DBNull.Value ? Convert.ToString(dr["Admin_SubCaste"]) : AdminSubCaste = null;
        AdminBirthPlace = dr["Admin_BirthPlace"] != DBNull.Value ? Convert.ToString(dr["Admin_BirthPlace"]) : AdminBirthPlace = null;
        AdminBloodGroup = dr["Admin_BloodGroup"] != DBNull.Value ? Convert.ToString(dr["Admin_BloodGroup"]) : AdminBloodGroup = null;
        AdminMotherTongue = dr["Admin_MotherTounge"] != DBNull.Value ? Convert.ToString(dr["Admin_MotherTounge"]) : AdminMotherTongue = null;
        AdminNationality = dr["Admin_Nationality"] != DBNull.Value ? Convert.ToString(dr["Admin_Nationality"]) : AdminNationality = null;
        AdminTransportStatus = dr["Admin_TransportStatus"] != DBNull.Value ? Convert.ToString(dr["Admin_TransportStatus"]) : AdminTransportStatus = null;
        AdminMedicalProblem = dr["Admin_MedicalProblem"] != DBNull.Value ? Convert.ToString(dr["Admin_MedicalProblem"]) : AdminMedicalProblem = null;
        AdminSchoolCategoryId = dr["Admin_SchoolCategoryId"] != DBNull.Value ? Convert.ToInt64(dr["Admin_SchoolCategoryId"]) : AdminSchoolCategoryId = null;
        AdminSchoolSubCategoryId = dr["Admin_SchoolSubCategoryId"] != DBNull.Value ? Convert.ToInt64(dr["Admin_SchoolSubCategoryId"]) : AdminSchoolSubCategoryId = null;
        AdminSubjectId = dr["Admin_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["Admin_SubjectId"]) : AdminSubjectId = null;
        AdminInterestPosition = dr["Admin_InterestPosition"] != DBNull.Value ? Convert.ToString(dr["Admin_InterestPosition"]) : AdminInterestPosition = null;
        AdminCertifiedSubject = dr["Admin_CertifiedSubject"] != DBNull.Value ? Convert.ToString(dr["Admin_CertifiedSubject"]) : AdminCertifiedSubject = null;
        AdminCertifiedAgeGroup = dr["Admin_CertifiedAgeGroup"] != DBNull.Value ? Convert.ToString(dr["Admin_CertifiedAgeGroup"]) : AdminCertifiedAgeGroup = null;
        AdminFullTimeTeaching = dr["Admin_FullTimeTeaching"] != DBNull.Value ? Convert.ToString(dr["Admin_FullTimeTeaching"]) : AdminFullTimeTeaching = null;
        AdminIndustryExpertise = dr["Admin_IndustryExpertise"] != DBNull.Value ? Convert.ToString(dr["Admin_IndustryExpertise"]) : AdminIndustryExpertise = null;
        AdminSpecificExpertise = dr["Admin_SpecificExpertise"] != DBNull.Value ? Convert.ToString(dr["Admin_SpecificExpertise"]) : AdminSpecificExpertise = null;
        AdminHighestDegreeCompletd = dr["Admin_HighestDegreeCompletd"] != DBNull.Value ? Convert.ToString(dr["Admin_HighestDegreeCompletd"]) : AdminHighestDegreeCompletd = null;
        AdminFieldOfStudy = dr["Admin_FieldOfStudy"] != DBNull.Value ? Convert.ToString(dr["Admin_FieldOfStudy"]) : AdminFieldOfStudy = null;
        AdminUniversity = dr["Admin_University"] != DBNull.Value ? Convert.ToString(dr["Admin_University"]) : AdminUniversity = null;
        AdminCompletionDate = dr["Admin_CompletionDate"] != DBNull.Value ? Convert.ToString(dr["Admin_CompletionDate"]) : AdminCompletionDate = null;
        AdminAddressId = dr["Admin_AddressId"] != DBNull.Value ? Convert.ToInt64(dr["Admin_AddressId"]) : AdminAddressId = null;
        AdminQualificationDetails = dr["Admin_QualificationDetails"] != DBNull.Value ? Convert.ToString(dr["Admin_QualificationDetails"]) : AdminQualificationDetails = null;
        AdminExperienceFrom = dr["Admin_ExperienceFrom"] != DBNull.Value ? Convert.ToString(dr["Admin_ExperienceFrom"]) : AdminExperienceFrom = null;
        AdminExperienceTo = dr["Admin_ExperienceTo"] != DBNull.Value ? Convert.ToString(dr["Admin_ExperienceTo"]) : AdminExperienceTo = null;
        AdminExperienceInYrs = dr["Admin_ExperienceInYrs"] != DBNull.Value ? Convert.ToInt64(dr["Admin_ExperienceInYrs"]) : AdminExperienceInYrs = null;
        AdminImage = dr["Admin_Image"] != DBNull.Value ? Convert.ToString(dr["Admin_Image"]) : AdminImage = null;
        AdminJoiningDate = dr["Admin_JoiningDate"] != DBNull.Value ? Convert.ToDateTime(dr["Admin_JoiningDate"]) : AdminJoiningDate = null;
        AdminBirthDate = dr["Admin_BirthDate"] != DBNull.Value ? Convert.ToDateTime(dr["Admin_BirthDate"]) : AdminBirthDate = null;
        AdminGender = dr["Admin_Gender"] != DBNull.Value ? Convert.ToString(dr["Admin_Gender"]) : AdminGender = null;
        AdminMarrialStatus = dr["Admin_MarrialStatus"] != DBNull.Value ? Convert.ToString(dr["Admin_MarrialStatus"]) : AdminMarrialStatus = null;
        AdminAgeProof = dr["Admin_AgeProof"] != DBNull.Value ? Convert.ToString(dr["Admin_AgeProof"]) : AdminAgeProof = null;
        AdminResume = dr["Admin_Resume"] != DBNull.Value ? Convert.ToString(dr["Admin_Resume"]) : AdminResume = null;
        AdminReleavingLetter = dr["Admin_ReleavingLetter"] != DBNull.Value ? Convert.ToString(dr["Admin_ReleavingLetter"]) : AdminReleavingLetter = null;
        AdminRetiredOn = dr["Admin_RetiredOn"] != DBNull.Value ? Convert.ToDateTime(dr["Admin_RetiredOn"]) : AdminRetiredOn = null;
        AdminExtraOne = dr["Admin_ExtraOne"] != DBNull.Value ? Convert.ToString(dr["Admin_ExtraOne"]) : AdminExtraOne = null;
        AdminCreatedBy = dr["Admin_CreatedBy"] != DBNull.Value ? Convert.ToInt64(dr["Admin_CreatedBy"]) : AdminCreatedBy = null;
        AdminLastSchoolwas = dr["Admin_LastSchoolwas"] != DBNull.Value ? Convert.ToString(dr["Admin_LastSchoolwas"]) : AdminLastSchoolwas = null;
        AdminLastSchoolFromDate = dr["Admin_LastSchoolFromDate"] != DBNull.Value ? Convert.ToDateTime(dr["Admin_LastSchoolFromDate"]) : AdminLastSchoolFromDate = null;
        AdminLastSchoolToDate = dr["Admin_LastSchoolToDate"] != DBNull.Value ? Convert.ToDateTime(dr["Admin_LastSchoolToDate"]) : AdminLastSchoolToDate = null;
        AdminRegisteredDate = dr["Admin_RegisteredDate"] != DBNull.Value ? Convert.ToDateTime(dr["Admin_RegisteredDate"]) : AdminRegisteredDate = null;
        AdminStatus = dr["Admin_Status"] != DBNull.Value ? Convert.ToBoolean(dr["Admin_Status"]) : AdminStatus = null;
        AdminDeletedStatus = dr["Admin_DeletedStatus"] != DBNull.Value ? Convert.ToBoolean(dr["Admin_DeletedStatus"]) : AdminDeletedStatus = null;
    }

    public static TMSAdminUser[] MapFrom(DataSet ds)
    {
        List<TMSAdminUser> objects;


        // Initialise Collection.
        objects = new List<TMSAdminUser>();

        // Validation.
        if (ds == null)
            throw new ApplicationException("Cannot map to dataset null.");
        else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
            return objects.ToArray();

        if (ds.Tables[TABLE_NAME] == null)
            throw new ApplicationException("Cannot find table [dbo].[TMS_AdminUser] in DataSet.");

        if (ds.Tables[TABLE_NAME].Rows.Count < 1)
            throw new ApplicationException("Table [dbo].[TMS_AdminUser] is empty.");

        // Map DataSet to Instance.
        foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
        {
            TMSAdminUser instance = new TMSAdminUser();
            instance.MapFrom(dr);
            objects.Add(instance);
        }

        // Return collection.
        return objects.ToArray();
    }


    #endregion



    #region CRUD Methods

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static TMSAdminUser Get(System.Int32 adminId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        TMSAdminUser instance;


        instance = new TMSAdminUser();

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminUser_SELECT";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminId);

        // Get results.
        ds = db.ExecuteDataSet(dbCommand);
        // Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSAdminUser ID:" + adminId.ToString()+ " from Database.");
            // Return results.
            return null;
        ds.Tables[0].TableName = TABLE_NAME;

        instance.MapFrom(ds.Tables[0].Rows[0]);
        return instance;
    }

    #region INSERT
    public void Insert(System.String adminFirstName, System.String adminMiddleName, System.String adminLastName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.Int64? adminFDLoginId, System.Int64? adminFDFacultyId, System.String adminTitle, System.String adminCaste, System.String adminSubCaste, System.String adminBirthPlace, System.String adminBloodGroup, System.String adminMotherTongue, System.String adminNationality, System.String adminTransportStatus, System.String adminMedicalProblem, System.Int64? adminSchoolCategoryId, System.Int64? adminSchoolSubCategoryId, System.Int64? adminSubjectId, System.String adminInterestPosition, System.String adminCertifiedSubject, System.String adminCertifiedAgeGroup, System.String adminFullTimeTeaching, System.String adminIndustryExpertise, System.String adminSpecificExpertise, System.String adminHighestDegreeCompletd, System.String adminFieldOfStudy, System.String adminUniversity, System.String adminCompletionDate, System.Int64? adminAddressId, System.String adminQualificationDetails, System.String adminExperienceFrom, System.String adminExperienceTo, System.Int64? adminExperienceInYrs, System.String adminImage, System.DateTime? adminJoiningDate, System.DateTime? adminBirthDate, System.String adminGender, System.String adminMarrialStatus, System.String adminAgeProof, System.String adminResume, System.String adminReleavingLetter, System.DateTime? adminRetiredOn, System.String adminExtraOne, System.Int64? adminCreatedBy, System.String adminLastSchoolwas, System.DateTime? adminLastSchoolFromDate, System.DateTime? adminLastSchoolToDate, System.DateTime? adminRegisteredDate, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus, DbTransaction transaction)
    {
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminUser_INSERT";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminFirstName, adminMiddleName, adminLastName, adminEmailId, adminUserName, adminPassword, adminType, adminFDLoginId, adminFDFacultyId, adminTitle, adminCaste, adminSubCaste, adminBirthPlace, adminBloodGroup, adminMotherTongue, adminNationality, adminTransportStatus, adminMedicalProblem, adminSchoolCategoryId, adminSchoolSubCategoryId, adminSubjectId, adminInterestPosition, adminCertifiedSubject, adminCertifiedAgeGroup, adminFullTimeTeaching, adminIndustryExpertise, adminSpecificExpertise, adminHighestDegreeCompletd, adminFieldOfStudy, adminUniversity, adminCompletionDate, adminAddressId, adminQualificationDetails, adminExperienceFrom, adminExperienceTo, adminExperienceInYrs, adminImage, adminJoiningDate, adminBirthDate, adminGender, adminMarrialStatus, adminAgeProof, adminResume, adminReleavingLetter, adminRetiredOn, adminExtraOne, adminCreatedBy, adminLastSchoolwas, adminLastSchoolFromDate, adminLastSchoolToDate, adminRegisteredDate, adminStatus, adminDeletedStatus);

        if (transaction == null)
            this.AdminId = Convert.ToInt32(db.ExecuteScalar(dbCommand));
        else
            this.AdminId = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
        return;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
    public void Insert(System.String adminFirstName, System.String adminMiddleName, System.String adminLastName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.Int64? adminFDLoginId, System.Int64? adminFDFacultyId, System.String adminTitle, System.String adminCaste, System.String adminSubCaste, System.String adminBirthPlace, System.String adminBloodGroup, System.String adminMotherTongue, System.String adminNationality, System.String adminTransportStatus, System.String adminMedicalProblem, System.Int64? adminSchoolCategoryId, System.Int64? adminSchoolSubCategoryId, System.Int64? adminSubjectId, System.String adminInterestPosition, System.String adminCertifiedSubject, System.String adminCertifiedAgeGroup, System.String adminFullTimeTeaching, System.String adminIndustryExpertise, System.String adminSpecificExpertise, System.String adminHighestDegreeCompletd, System.String adminFieldOfStudy, System.String adminUniversity, System.String adminCompletionDate, System.Int64? adminAddressId, System.String adminQualificationDetails, System.String adminExperienceFrom, System.String adminExperienceTo, System.Int64? adminExperienceInYrs, System.String adminImage, System.DateTime? adminJoiningDate, System.DateTime? adminBirthDate, System.String adminGender, System.String adminMarrialStatus, System.String adminAgeProof, System.String adminResume, System.String adminReleavingLetter, System.DateTime? adminRetiredOn, System.String adminExtraOne, System.Int64? adminCreatedBy, System.String adminLastSchoolwas, System.DateTime? adminLastSchoolFromDate, System.DateTime? adminLastSchoolToDate, System.DateTime? adminRegisteredDate, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus)
    {
        Insert(adminFirstName, adminMiddleName, adminLastName, adminEmailId, adminUserName, adminPassword, adminType, adminFDLoginId, adminFDFacultyId, adminTitle, adminCaste, adminSubCaste, adminBirthPlace, adminBloodGroup, adminMotherTongue, adminNationality, adminTransportStatus, adminMedicalProblem, adminSchoolCategoryId, adminSchoolSubCategoryId, adminSubjectId, adminInterestPosition, adminCertifiedSubject, adminCertifiedAgeGroup, adminFullTimeTeaching, adminIndustryExpertise, adminSpecificExpertise, adminHighestDegreeCompletd, adminFieldOfStudy, adminUniversity, adminCompletionDate, adminAddressId, adminQualificationDetails, adminExperienceFrom, adminExperienceTo, adminExperienceInYrs, adminImage, adminJoiningDate, adminBirthDate, adminGender, adminMarrialStatus, adminAgeProof, adminResume, adminReleavingLetter, adminRetiredOn, adminExtraOne, adminCreatedBy, adminLastSchoolwas, adminLastSchoolFromDate, adminLastSchoolToDate, adminRegisteredDate, adminStatus, adminDeletedStatus, null);
    }
    /// <summary>
    /// Insert current TMSAdminUser to database.
    /// </summary>
    /// <param name="transaction">optional SQL Transaction</param>
    public void Insert(DbTransaction transaction)
    {
        Insert(AdminFirstName, AdminMiddleName, AdminLastName, AdminEmailId, AdminUserName, AdminPassword, AdminType, AdminFDLoginId, AdminFDFacultyId, AdminTitle, AdminCaste, AdminSubCaste, AdminBirthPlace, AdminBloodGroup, AdminMotherTongue, AdminNationality, AdminTransportStatus, AdminMedicalProblem, AdminSchoolCategoryId, AdminSchoolSubCategoryId, AdminSubjectId, AdminInterestPosition, AdminCertifiedSubject, AdminCertifiedAgeGroup, AdminFullTimeTeaching, AdminIndustryExpertise, AdminSpecificExpertise, AdminHighestDegreeCompletd, AdminFieldOfStudy, AdminUniversity, AdminCompletionDate, AdminAddressId, AdminQualificationDetails, AdminExperienceFrom, AdminExperienceTo, AdminExperienceInYrs, AdminImage, AdminJoiningDate, AdminBirthDate, AdminGender, AdminMarrialStatus, AdminAgeProof, AdminResume, AdminReleavingLetter, AdminRetiredOn, AdminExtraOne, AdminCreatedBy, AdminLastSchoolwas, AdminLastSchoolFromDate, AdminLastSchoolToDate, AdminRegisteredDate, AdminStatus, AdminDeletedStatus, transaction);
    }

    /// <summary>
    /// Insert current TMSAdminUser to database.
    /// </summary>
    public void Insert()
    {
        this.Insert((DbTransaction)null);
    }
    #endregion


    #region UPDATE
    public static void Update(System.Int32? adminId, System.String adminFirstName, System.String adminMiddleName, System.String adminLastName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.Int64? adminFDLoginId, System.Int64? adminFDFacultyId, System.String adminTitle, System.String adminCaste, System.String adminSubCaste, System.String adminBirthPlace, System.String adminBloodGroup, System.String adminMotherTongue, System.String adminNationality, System.String adminTransportStatus, System.String adminMedicalProblem, System.Int64? adminSchoolCategoryId, System.Int64? adminSchoolSubCategoryId, System.Int64? adminSubjectId, System.String adminInterestPosition, System.String adminCertifiedSubject, System.String adminCertifiedAgeGroup, System.String adminFullTimeTeaching, System.String adminIndustryExpertise, System.String adminSpecificExpertise, System.String adminHighestDegreeCompletd, System.String adminFieldOfStudy, System.String adminUniversity, System.String adminCompletionDate, System.Int64? adminAddressId, System.String adminQualificationDetails, System.String adminExperienceFrom, System.String adminExperienceTo, System.Int64? adminExperienceInYrs, System.String adminImage, System.DateTime? adminJoiningDate, System.DateTime? adminBirthDate, System.String adminGender, System.String adminMarrialStatus, System.String adminAgeProof, System.String adminResume, System.String adminReleavingLetter, System.DateTime? adminRetiredOn, System.String adminExtraOne, System.Int64? adminCreatedBy, System.String adminLastSchoolwas, System.DateTime? adminLastSchoolFromDate, System.DateTime? adminLastSchoolToDate, System.DateTime? adminRegisteredDate, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus, DbTransaction transaction)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminUser_UPDATE";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        db.DiscoverParameters(dbCommand);
        dbCommand.Parameters["@adminId"].Value = adminId;
        dbCommand.Parameters["@adminFirstName"].Value = adminFirstName;
        dbCommand.Parameters["@adminMiddleName"].Value = adminMiddleName;
        dbCommand.Parameters["@adminLastName"].Value = adminLastName;
        dbCommand.Parameters["@adminEmailId"].Value = adminEmailId;
        dbCommand.Parameters["@adminUserName"].Value = adminUserName;
        dbCommand.Parameters["@adminPassword"].Value = adminPassword;
        dbCommand.Parameters["@adminType"].Value = adminType;
        dbCommand.Parameters["@adminFDLoginId"].Value = adminFDLoginId;
        dbCommand.Parameters["@adminFDFacultyId"].Value = adminFDFacultyId;
        dbCommand.Parameters["@adminTitle"].Value = adminTitle;
        dbCommand.Parameters["@adminCaste"].Value = adminCaste;
        dbCommand.Parameters["@adminSubCaste"].Value = adminSubCaste;
        dbCommand.Parameters["@adminBirthPlace"].Value = adminBirthPlace;
        dbCommand.Parameters["@adminBloodGroup"].Value = adminBloodGroup;
        dbCommand.Parameters["@adminMotherTounge"].Value = adminMotherTongue;
        dbCommand.Parameters["@adminNationality"].Value = adminNationality;
        dbCommand.Parameters["@adminTransportStatus"].Value = adminTransportStatus;
        dbCommand.Parameters["@adminMedicalProblem"].Value = adminMedicalProblem;
        dbCommand.Parameters["@adminSchoolCategoryId"].Value = adminSchoolCategoryId;
        dbCommand.Parameters["@adminSchoolSubCategoryId"].Value = adminSchoolSubCategoryId;
        dbCommand.Parameters["@adminSubjectId"].Value = adminSubjectId;
        dbCommand.Parameters["@adminInterestPosition"].Value = adminInterestPosition;
        dbCommand.Parameters["@adminCertifiedSubject"].Value = adminCertifiedSubject;
        dbCommand.Parameters["@adminCertifiedAgeGroup"].Value = adminCertifiedAgeGroup;
        dbCommand.Parameters["@adminFullTimeTeaching"].Value = adminFullTimeTeaching;
        dbCommand.Parameters["@adminIndustryExpertise"].Value = adminIndustryExpertise;
        dbCommand.Parameters["@adminSpecificExpertise"].Value = adminSpecificExpertise;
        dbCommand.Parameters["@adminHighestDegreeCompletd"].Value = adminHighestDegreeCompletd;
        dbCommand.Parameters["@adminFieldOfStudy"].Value = adminFieldOfStudy;
        dbCommand.Parameters["@adminUniversity"].Value = adminUniversity;
        dbCommand.Parameters["@adminCompletionDate"].Value = adminCompletionDate;
        dbCommand.Parameters["@adminAddressId"].Value = adminAddressId;
        dbCommand.Parameters["@adminQualificationDetails"].Value = adminQualificationDetails;
        dbCommand.Parameters["@adminExperienceFrom"].Value = adminExperienceFrom;
        dbCommand.Parameters["@adminExperienceTo"].Value = adminExperienceTo;
        dbCommand.Parameters["@adminExperienceInYrs"].Value = adminExperienceInYrs;
        dbCommand.Parameters["@adminImage"].Value = adminImage;
        dbCommand.Parameters["@adminJoiningDate"].Value = adminJoiningDate;
        dbCommand.Parameters["@adminBirthDate"].Value = adminBirthDate;
        dbCommand.Parameters["@adminGender"].Value = adminGender;
        dbCommand.Parameters["@adminMarrialStatus"].Value = adminMarrialStatus;
        dbCommand.Parameters["@adminAgeProof"].Value = adminAgeProof;
        dbCommand.Parameters["@adminResume"].Value = adminResume;
        dbCommand.Parameters["@adminReleavingLetter"].Value = adminReleavingLetter;
        dbCommand.Parameters["@adminRetiredOn"].Value = adminRetiredOn;
        dbCommand.Parameters["@adminExtraOne"].Value = adminExtraOne;
        dbCommand.Parameters["@adminCreatedBy"].Value = adminCreatedBy;
        dbCommand.Parameters["@adminLastSchoolwas"].Value = adminLastSchoolwas;
        dbCommand.Parameters["@adminLastSchoolFromDate"].Value = adminLastSchoolFromDate;
        dbCommand.Parameters["@adminLastSchoolToDate"].Value = adminLastSchoolToDate;
        dbCommand.Parameters["@adminRegisteredDate"].Value = adminRegisteredDate;
        dbCommand.Parameters["@adminStatus"].Value = adminStatus;
        dbCommand.Parameters["@adminDeletedStatus"].Value = adminDeletedStatus;

        if (transaction == null)
            db.ExecuteNonQuery(dbCommand);
        else
            db.ExecuteNonQuery(dbCommand, transaction);
        return;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
    public static void Update(System.Int32? adminId, System.String adminFirstName, System.String adminMiddleName, System.String adminLastName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.Int64? adminFDLoginId, System.Int64? adminFDFacultyId, System.String adminTitle, System.String adminCaste, System.String adminSubCaste, System.String adminBirthPlace, System.String adminBloodGroup, System.String adminMotherTongue, System.String adminNationality, System.String adminTransportStatus, System.String adminMedicalProblem, System.Int64? adminSchoolCategoryId, System.Int64? adminSchoolSubCategoryId, System.Int64? adminSubjectId, System.String adminInterestPosition, System.String adminCertifiedSubject, System.String adminCertifiedAgeGroup, System.String adminFullTimeTeaching, System.String adminIndustryExpertise, System.String adminSpecificExpertise, System.String adminHighestDegreeCompletd, System.String adminFieldOfStudy, System.String adminUniversity, System.String adminCompletionDate, System.Int64? adminAddressId, System.String adminQualificationDetails, System.String adminExperienceFrom, System.String adminExperienceTo, System.Int64? adminExperienceInYrs, System.String adminImage, System.DateTime? adminJoiningDate, System.DateTime? adminBirthDate, System.String adminGender, System.String adminMarrialStatus, System.String adminAgeProof, System.String adminResume, System.String adminReleavingLetter, System.DateTime? adminRetiredOn, System.String adminExtraOne, System.Int64? adminCreatedBy, System.String adminLastSchoolwas, System.DateTime? adminLastSchoolFromDate, System.DateTime? adminLastSchoolToDate, System.DateTime? adminRegisteredDate, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus)
    {
        Update(adminId, adminFirstName, adminMiddleName, adminLastName, adminEmailId, adminUserName, adminPassword, adminType, adminFDLoginId, adminFDFacultyId, adminTitle, adminCaste, adminSubCaste, adminBirthPlace, adminBloodGroup, adminMotherTongue, adminNationality, adminTransportStatus, adminMedicalProblem, adminSchoolCategoryId, adminSchoolSubCategoryId, adminSubjectId, adminInterestPosition, adminCertifiedSubject, adminCertifiedAgeGroup, adminFullTimeTeaching, adminIndustryExpertise, adminSpecificExpertise, adminHighestDegreeCompletd, adminFieldOfStudy, adminUniversity, adminCompletionDate, adminAddressId, adminQualificationDetails, adminExperienceFrom, adminExperienceTo, adminExperienceInYrs, adminImage, adminJoiningDate, adminBirthDate, adminGender, adminMarrialStatus, adminAgeProof, adminResume, adminReleavingLetter, adminRetiredOn, adminExtraOne, adminCreatedBy, adminLastSchoolwas, adminLastSchoolFromDate, adminLastSchoolToDate, adminRegisteredDate, adminStatus, adminDeletedStatus, null);
    }

    public static void Update(TMSAdminUser tMSAdminUser)
    {
        tMSAdminUser.Update();
    }

    public static void Update(TMSAdminUser tMSAdminUser, DbTransaction transaction)
    {
        tMSAdminUser.Update(transaction);
    }

    /// <summary>
    /// Updates changes to the database.
    /// </summary>
    /// <param name="transaction">optional SQL Transaction</param>
    public void Update(DbTransaction transaction)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminUser_UPDATE";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        db.DiscoverParameters(dbCommand);
        dbCommand.Parameters["@adminId"].SourceColumn = "Admin_Id";
        dbCommand.Parameters["@adminFirstName"].SourceColumn = "Admin_FirstName";
        dbCommand.Parameters["@adminMiddleName"].SourceColumn = "Admin_MiddleName";
        dbCommand.Parameters["@adminLastName"].SourceColumn = "Admin_LastName";
        dbCommand.Parameters["@adminEmailId"].SourceColumn = "Admin_EmailId";
        dbCommand.Parameters["@adminUserName"].SourceColumn = "Admin_UserName";
        dbCommand.Parameters["@adminPassword"].SourceColumn = "Admin_Password";
        dbCommand.Parameters["@adminType"].SourceColumn = "Admin_Type";
        dbCommand.Parameters["@adminFDLoginId"].SourceColumn = "Admin_FDLoginId";
        dbCommand.Parameters["@adminFDFacultyId"].SourceColumn = "Admin_FDFacultyId";
        dbCommand.Parameters["@adminTitle"].SourceColumn = "Admin_Title";
        dbCommand.Parameters["@adminCaste"].SourceColumn = "Admin_Caste";
        dbCommand.Parameters["@adminSubCaste"].SourceColumn = "Admin_SubCaste";
        dbCommand.Parameters["@adminBirthPlace"].SourceColumn = "Admin_BirthPlace";
        dbCommand.Parameters["@adminBloodGroup"].SourceColumn = "Admin_BloodGroup";
        dbCommand.Parameters["@adminMotherTounge"].SourceColumn = "Admin_MotherTounge";
        dbCommand.Parameters["@adminNationality"].SourceColumn = "Admin_Nationality";
        dbCommand.Parameters["@adminTransportStatus"].SourceColumn = "Admin_TransportStatus";
        dbCommand.Parameters["@adminMedicalProblem"].SourceColumn = "Admin_MedicalProblem";
        dbCommand.Parameters["@adminSchoolCategoryId"].SourceColumn = "Admin_SchoolCategoryId";
        dbCommand.Parameters["@adminSchoolSubCategoryId"].SourceColumn = "Admin_SchoolSubCategoryId";
        dbCommand.Parameters["@adminSubjectId"].SourceColumn = "Admin_SubjectId";
        dbCommand.Parameters["@adminInterestPosition"].SourceColumn = "Admin_InterestPosition";
        dbCommand.Parameters["@adminCertifiedSubject"].SourceColumn = "Admin_CertifiedSubject";
        dbCommand.Parameters["@adminCertifiedAgeGroup"].SourceColumn = "Admin_CertifiedAgeGroup";
        dbCommand.Parameters["@adminFullTimeTeaching"].SourceColumn = "Admin_FullTimeTeaching";
        dbCommand.Parameters["@adminIndustryExpertise"].SourceColumn = "Admin_IndustryExpertise";
        dbCommand.Parameters["@adminSpecificExpertise"].SourceColumn = "Admin_SpecificExpertise";
        dbCommand.Parameters["@adminHighestDegreeCompletd"].SourceColumn = "Admin_HighestDegreeCompletd";
        dbCommand.Parameters["@adminFieldOfStudy"].SourceColumn = "Admin_FieldOfStudy";
        dbCommand.Parameters["@adminUniversity"].SourceColumn = "Admin_University";
        dbCommand.Parameters["@adminCompletionDate"].SourceColumn = "Admin_CompletionDate";
        dbCommand.Parameters["@adminAddressId"].SourceColumn = "Admin_AddressId";
        dbCommand.Parameters["@adminQualificationDetails"].SourceColumn = "Admin_QualificationDetails";
        dbCommand.Parameters["@adminExperienceFrom"].SourceColumn = "Admin_ExperienceFrom";
        dbCommand.Parameters["@adminExperienceTo"].SourceColumn = "Admin_ExperienceTo";
        dbCommand.Parameters["@adminExperienceInYrs"].SourceColumn = "Admin_ExperienceInYrs";
        dbCommand.Parameters["@adminImage"].SourceColumn = "Admin_Image";
        dbCommand.Parameters["@adminJoiningDate"].SourceColumn = "Admin_JoiningDate";
        dbCommand.Parameters["@adminBirthDate"].SourceColumn = "Admin_BirthDate";
        dbCommand.Parameters["@adminGender"].SourceColumn = "Admin_Gender";
        dbCommand.Parameters["@adminMarrialStatus"].SourceColumn = "Admin_MarrialStatus";
        dbCommand.Parameters["@adminAgeProof"].SourceColumn = "Admin_AgeProof";
        dbCommand.Parameters["@adminResume"].SourceColumn = "Admin_Resume";
        dbCommand.Parameters["@adminReleavingLetter"].SourceColumn = "Admin_ReleavingLetter";
        dbCommand.Parameters["@adminRetiredOn"].SourceColumn = "Admin_RetiredOn";
        dbCommand.Parameters["@adminExtraOne"].SourceColumn = "Admin_ExtraOne";
        dbCommand.Parameters["@adminCreatedBy"].SourceColumn = "Admin_CreatedBy";
        dbCommand.Parameters["@adminLastSchoolwas"].SourceColumn = "Admin_LastSchoolwas";
        dbCommand.Parameters["@adminLastSchoolFromDate"].SourceColumn = "Admin_LastSchoolFromDate";
        dbCommand.Parameters["@adminLastSchoolToDate"].SourceColumn = "Admin_LastSchoolToDate";
        dbCommand.Parameters["@adminRegisteredDate"].SourceColumn = "Admin_RegisteredDate";
        dbCommand.Parameters["@adminStatus"].SourceColumn = "Admin_Status";
        dbCommand.Parameters["@adminDeletedStatus"].SourceColumn = "Admin_DeletedStatus";

        ds = new DataSet();
        this.MapTo(ds);
        ds.AcceptChanges();
        ds.Tables[0].Rows[0].SetModified();
        if (transaction == null)
            db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, UpdateBehavior.Standard);
        else
            db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, transaction);
        return;
    }

    /// <summary>
    /// Updates changes to the database.
    /// </summary>
    public void Update()
    {
        this.Update((DbTransaction)null);
    }
    #endregion


    #region DELETE
    [DataObjectMethodAttribute(DataObjectMethodType.Delete, false)]
    public static void Delete(System.Int32? adminId, DbTransaction transaction)
    {
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminUser_DELETE";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminId);

        // Execute.
        if (transaction != null)
        {
            db.ExecuteNonQuery(dbCommand, transaction);
        }
        else
        {
            db.ExecuteNonQuery(dbCommand);
        }
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static void Delete(System.Int32? adminId)
    {
        Delete(
        adminId);
    }

    /// <summary>
    /// Delete current TMSAdminUser from database.
    /// </summary>
    /// <param name="transaction">optional SQL Transaction</param>
    public void Delete(DbTransaction transaction)
    {
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminUser_DELETE";
        dbCommand = db.GetStoredProcCommand(sqlCommand, AdminId);

        // Execute.
        if (transaction != null)
        {
            db.ExecuteNonQuery(dbCommand, transaction);
        }
        else
        {
            db.ExecuteNonQuery(dbCommand);
        }
        this.AdminId = null;
    }

    /// <summary>
    /// Delete current TMSAdminUser from database.
    /// </summary>
    public void Delete()
    {
        this.Delete((DbTransaction)null);
    }

    #endregion


    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static TMSAdminUser[] Search(System.Int32? adminId, System.String adminFirstName, System.String adminMiddleName, System.String adminLastName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.Int64? adminFDLoginId, System.Int64? adminFDFacultyId, System.String adminTitle, System.String adminCaste, System.String adminSubCaste, System.String adminBirthPlace, System.String adminBloodGroup, System.String adminMotherTongue, System.String adminNationality, System.String adminTransportStatus, System.String adminMedicalProblem, System.Int64? adminSchoolCategoryId, System.Int64? adminSchoolSubCategoryId, System.Int64? adminSubjectId, System.String adminInterestPosition, System.String adminCertifiedSubject, System.String adminCertifiedAgeGroup, System.String adminFullTimeTeaching, System.String adminIndustryExpertise, System.String adminSpecificExpertise, System.String adminHighestDegreeCompletd, System.String adminFieldOfStudy, System.String adminUniversity, System.String adminCompletionDate, System.Int64? adminAddressId, System.String adminQualificationDetails, System.String adminExperienceFrom, System.String adminExperienceTo, System.Int64? adminExperienceInYrs, System.String adminImage, System.DateTime? adminJoiningDate, System.DateTime? adminBirthDate, System.String adminGender, System.String adminMarrialStatus, System.String adminAgeProof, System.String adminResume, System.String adminReleavingLetter, System.DateTime? adminRetiredOn, System.String adminExtraOne, System.Int64? adminCreatedBy, System.String adminLastSchoolwas, System.DateTime? adminLastSchoolFromDate, System.DateTime? adminLastSchoolToDate, System.DateTime? adminRegisteredDate, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAdminUser_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adminId, adminFirstName, adminMiddleName, adminLastName, adminEmailId, adminUserName, adminPassword, adminType, adminFDLoginId, adminFDFacultyId, adminTitle, adminCaste, adminSubCaste, adminBirthPlace, adminBloodGroup, adminMotherTongue, adminNationality, adminTransportStatus, adminMedicalProblem, adminSchoolCategoryId, adminSchoolSubCategoryId, adminSubjectId, adminInterestPosition, adminCertifiedSubject, adminCertifiedAgeGroup, adminFullTimeTeaching, adminIndustryExpertise, adminSpecificExpertise, adminHighestDegreeCompletd, adminFieldOfStudy, adminUniversity, adminCompletionDate, adminAddressId, adminQualificationDetails, adminExperienceFrom, adminExperienceTo, adminExperienceInYrs, adminImage, adminJoiningDate, adminBirthDate, adminGender, adminMarrialStatus, adminAgeProof, adminResume, adminReleavingLetter, adminRetiredOn, adminExtraOne, adminCreatedBy, adminLastSchoolwas, adminLastSchoolFromDate, adminLastSchoolToDate, adminRegisteredDate, adminStatus, adminDeletedStatus);

        ds = db.ExecuteDataSet(dbCommand);
        ds.Tables[0].TableName = TABLE_NAME;
        return TMSAdminUser.MapFrom(ds);
    }


    public static TMSAdminUser[] Search(TMSAdminUser searchObject)
    {
        return Search(searchObject.AdminId, searchObject.AdminFirstName, searchObject.AdminMiddleName, searchObject.AdminLastName, searchObject.AdminEmailId, searchObject.AdminUserName, searchObject.AdminPassword, searchObject.AdminType, searchObject.AdminFDLoginId, searchObject.AdminFDFacultyId, searchObject.AdminTitle, searchObject.AdminCaste, searchObject.AdminSubCaste, searchObject.AdminBirthPlace, searchObject.AdminBloodGroup, searchObject.AdminMotherTongue, searchObject.AdminNationality, searchObject.AdminTransportStatus, searchObject.AdminMedicalProblem, searchObject.AdminSchoolCategoryId, searchObject.AdminSchoolSubCategoryId, searchObject.AdminSubjectId, searchObject.AdminInterestPosition, searchObject.AdminCertifiedSubject, searchObject.AdminCertifiedAgeGroup, searchObject.AdminFullTimeTeaching, searchObject.AdminIndustryExpertise, searchObject.AdminSpecificExpertise, searchObject.AdminHighestDegreeCompletd, searchObject.AdminFieldOfStudy, searchObject.AdminUniversity, searchObject.AdminCompletionDate, searchObject.AdminAddressId, searchObject.AdminQualificationDetails, searchObject.AdminExperienceFrom, searchObject.AdminExperienceTo, searchObject.AdminExperienceInYrs, searchObject.AdminImage, searchObject.AdminJoiningDate, searchObject.AdminBirthDate, searchObject.AdminGender, searchObject.AdminMarrialStatus, searchObject.AdminAgeProof, searchObject.AdminResume, searchObject.AdminReleavingLetter, searchObject.AdminRetiredOn, searchObject.AdminExtraOne, searchObject.AdminCreatedBy, searchObject.AdminLastSchoolwas, searchObject.AdminLastSchoolFromDate, searchObject.AdminLastSchoolToDate, searchObject.AdminRegisteredDate, searchObject.AdminStatus, searchObject.AdminDeletedStatus);
    }

    /// <summary>
    /// Returns all TMSAdminUser objects.
    /// </summary>
    /// <returns>List of all TMSAdminUser objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static TMSAdminUser[] Search()
    {
        return Search(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    #endregion


    #endregion


}

