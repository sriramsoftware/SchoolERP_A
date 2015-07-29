/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/24/2012 6:08:15 PM                                    */
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
public partial class TMSFacultyDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FacultyDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _fdFacultyDetailsId;
	private System.Int64? _fdLoginId;
	private System.Int64? _fdFacultyId;
	private System.Int64? _fdSchoolCatgoryId;
	private System.String _fdTitle;
	private System.String _fdFirstName;
	private System.String _fdMiddleName;
	private System.String _fdLastName;
	private System.DateTime? _fdDate;
	private System.String _fdCaste;
	private System.String _fdSubCaste;
	private System.String _fdBirthPlace;
	private System.String _fdBloodGroup;
	private System.String _fdMotherTongue;
	private System.String _fdNationality;
	private System.String _fdTransportStatus;
	private System.String _fdMedicalProblem;
	private System.Int64? _fdSchoolCategoryId;
	private System.Int64? _fdSchoolSubCategoryId;
	private System.Int64? _fdSubjectId;
	private System.String _fdInterestPosition;
	private System.String _fdCertifiedSubject;
	private System.String _fdCertifiedAgeGroup;
	private System.String _fdFullTimeTeaching;
	private System.String _fdIndustryExpertise;
	private System.String _fdSpecificExpertise;
	private System.String _fdHighestDegreeCompletd;
	private System.String _fdFieldOfStudy;
	private System.String _fdUniversity;
	private System.String _fdCompletionDate;
	private System.Int64? _fdAddressId;
	private System.String _fdQualificationDetails;
	private System.String _fdExperienceFrom;
	private System.String _fdExperienceTo;
	private System.Int64? _fdExperienceInYrs;
	private System.String _fdImage;
	private System.DateTime? _fdJoiningDate;
	private System.DateTime? _fdBirthDate;
	private System.String _fdGender;
	private System.String _fdMarrialStatus;
	private System.String _fdAgeProof;
	private System.String _fdResume;
	private System.String _fdReleavingLetter;
	private System.DateTime? _fdRetiredOn;
	private System.String _fdExtraOne;
	private System.Int64? _fdCreatedBy;
	private System.String _fdLastSchoolwas;
	private System.DateTime? _fdLastSchoolFromDate;
	private System.DateTime? _fdLastSchoolToDate;
	private System.Int32? _fdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? FDFacultyDetailsId
	{
		get
		{
			return _fdFacultyDetailsId;
		}
		set
		{
			_fdFacultyDetailsId = value;
		}
	}
	
	public System.Int64? FDLoginId
	{
		get
		{
			return _fdLoginId;
		}
		set
		{
			_fdLoginId = value;
		}
	}
	
	public System.Int64? FDFacultyId
	{
		get
		{
			return _fdFacultyId;
		}
		set
		{
			_fdFacultyId = value;
		}
	}
	
	public System.Int64? FDSchoolCatgoryId
	{
		get
		{
			return _fdSchoolCatgoryId;
		}
		set
		{
			_fdSchoolCatgoryId = value;
		}
	}
	
	public System.String FDTitle
	{
		get
		{
			return _fdTitle;
		}
		set
		{
			_fdTitle = value;
		}
	}
	
	public System.String FDFirstName
	{
		get
		{
			return _fdFirstName;
		}
		set
		{
			_fdFirstName = value;
		}
	}
	
	public System.String FDMiddleName
	{
		get
		{
			return _fdMiddleName;
		}
		set
		{
			_fdMiddleName = value;
		}
	}
	
	public System.String FDLastName
	{
		get
		{
			return _fdLastName;
		}
		set
		{
			_fdLastName = value;
		}
	}
	
	public System.DateTime? FDDate
	{
		get
		{
			return _fdDate;
		}
		set
		{
			_fdDate = value;
		}
	}
	
	public System.String FDCaste
	{
		get
		{
			return _fdCaste;
		}
		set
		{
			_fdCaste = value;
		}
	}
	
	public System.String FDSubCaste
	{
		get
		{
			return _fdSubCaste;
		}
		set
		{
			_fdSubCaste = value;
		}
	}
	
	public System.String FDBirthPlace
	{
		get
		{
			return _fdBirthPlace;
		}
		set
		{
			_fdBirthPlace = value;
		}
	}
	
	public System.String FDBloodGroup
	{
		get
		{
			return _fdBloodGroup;
		}
		set
		{
			_fdBloodGroup = value;
		}
	}
	
	public System.String FDMotherTongue
	{
		get
		{
			return _fdMotherTongue;
		}
		set
		{
			_fdMotherTongue = value;
		}
	}
	
	public System.String FDNationality
	{
		get
		{
			return _fdNationality;
		}
		set
		{
			_fdNationality = value;
		}
	}
	
	public System.String FDTransportStatus
	{
		get
		{
			return _fdTransportStatus;
		}
		set
		{
			_fdTransportStatus = value;
		}
	}
	
	public System.String FDMedicalProblem
	{
		get
		{
			return _fdMedicalProblem;
		}
		set
		{
			_fdMedicalProblem = value;
		}
	}
	
	public System.Int64? FDSchoolCategoryId
	{
		get
		{
			return _fdSchoolCategoryId;
		}
		set
		{
			_fdSchoolCategoryId = value;
		}
	}
	
	public System.Int64? FDSchoolSubCategoryId
	{
		get
		{
			return _fdSchoolSubCategoryId;
		}
		set
		{
			_fdSchoolSubCategoryId = value;
		}
	}
	
	public System.Int64? FDSubjectId
	{
		get
		{
			return _fdSubjectId;
		}
		set
		{
			_fdSubjectId = value;
		}
	}
	
	public System.String FDInterestPosition
	{
		get
		{
			return _fdInterestPosition;
		}
		set
		{
			_fdInterestPosition = value;
		}
	}
	
	public System.String FDCertifiedSubject
	{
		get
		{
			return _fdCertifiedSubject;
		}
		set
		{
			_fdCertifiedSubject = value;
		}
	}
	
	public System.String FDCertifiedAgeGroup
	{
		get
		{
			return _fdCertifiedAgeGroup;
		}
		set
		{
			_fdCertifiedAgeGroup = value;
		}
	}
	
	public System.String FDFullTimeTeaching
	{
		get
		{
			return _fdFullTimeTeaching;
		}
		set
		{
			_fdFullTimeTeaching = value;
		}
	}
	
	public System.String FDIndustryExpertise
	{
		get
		{
			return _fdIndustryExpertise;
		}
		set
		{
			_fdIndustryExpertise = value;
		}
	}
	
	public System.String FDSpecificExpertise
	{
		get
		{
			return _fdSpecificExpertise;
		}
		set
		{
			_fdSpecificExpertise = value;
		}
	}
	
	public System.String FDHighestDegreeCompletd
	{
		get
		{
			return _fdHighestDegreeCompletd;
		}
		set
		{
			_fdHighestDegreeCompletd = value;
		}
	}
	
	public System.String FDFieldOfStudy
	{
		get
		{
			return _fdFieldOfStudy;
		}
		set
		{
			_fdFieldOfStudy = value;
		}
	}
	
	public System.String FDUniversity
	{
		get
		{
			return _fdUniversity;
		}
		set
		{
			_fdUniversity = value;
		}
	}
	
	public System.String FDCompletionDate
	{
		get
		{
			return _fdCompletionDate;
		}
		set
		{
			_fdCompletionDate = value;
		}
	}
	
	public System.Int64? FDAddressId
	{
		get
		{
			return _fdAddressId;
		}
		set
		{
			_fdAddressId = value;
		}
	}
	
	public System.String FDQualificationDetails
	{
		get
		{
			return _fdQualificationDetails;
		}
		set
		{
			_fdQualificationDetails = value;
		}
	}
	
	public System.String FDExperienceFrom
	{
		get
		{
			return _fdExperienceFrom;
		}
		set
		{
			_fdExperienceFrom = value;
		}
	}
	
	public System.String FDExperienceTo
	{
		get
		{
			return _fdExperienceTo;
		}
		set
		{
			_fdExperienceTo = value;
		}
	}
	
	public System.Int64? FDExperienceInYrs
	{
		get
		{
			return _fdExperienceInYrs;
		}
		set
		{
			_fdExperienceInYrs = value;
		}
	}
	
	public System.String FDImage
	{
		get
		{
			return _fdImage;
		}
		set
		{
			_fdImage = value;
		}
	}
	
	public System.DateTime? FDJoiningDate
	{
		get
		{
			return _fdJoiningDate;
		}
		set
		{
			_fdJoiningDate = value;
		}
	}
	
	public System.DateTime? FDBirthDate
	{
		get
		{
			return _fdBirthDate;
		}
		set
		{
			_fdBirthDate = value;
		}
	}
	
	public System.String FDGender
	{
		get
		{
			return _fdGender;
		}
		set
		{
			_fdGender = value;
		}
	}
	
	public System.String FDMarrialStatus
	{
		get
		{
			return _fdMarrialStatus;
		}
		set
		{
			_fdMarrialStatus = value;
		}
	}
	
	public System.String FDAgeProof
	{
		get
		{
			return _fdAgeProof;
		}
		set
		{
			_fdAgeProof = value;
		}
	}
	
	public System.String FDResume
	{
		get
		{
			return _fdResume;
		}
		set
		{
			_fdResume = value;
		}
	}
	
	public System.String FDReleavingLetter
	{
		get
		{
			return _fdReleavingLetter;
		}
		set
		{
			_fdReleavingLetter = value;
		}
	}
	
	public System.DateTime? FDRetiredOn
	{
		get
		{
			return _fdRetiredOn;
		}
		set
		{
			_fdRetiredOn = value;
		}
	}
	
	public System.String FDExtraOne
	{
		get
		{
			return _fdExtraOne;
		}
		set
		{
			_fdExtraOne = value;
		}
	}
	
	public System.Int64? FDCreatedBy
	{
		get
		{
			return _fdCreatedBy;
		}
		set
		{
			_fdCreatedBy = value;
		}
	}
	
	public System.String FDLastSchoolwas
	{
		get
		{
			return _fdLastSchoolwas;
		}
		set
		{
			_fdLastSchoolwas = value;
		}
	}
	
	public System.DateTime? FDLastSchoolFromDate
	{
		get
		{
			return _fdLastSchoolFromDate;
		}
		set
		{
			_fdLastSchoolFromDate = value;
		}
	}
	
	public System.DateTime? FDLastSchoolToDate
	{
		get
		{
			return _fdLastSchoolToDate;
		}
		set
		{
			_fdLastSchoolToDate = value;
		}
	}
	
	public System.Int32? FDStatus
	{
		get
		{
			return _fdStatus;
		}
		set
		{
			_fdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FD_FacultyDetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_LoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_SchoolCatgoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_FirstName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_MiddleName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_LastName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_Caste", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_SubCaste", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_BirthPlace", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_BloodGroup", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_MotherTounge", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_Nationality", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_TransportStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_MedicalProblem", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_SchoolCategoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_SchoolSubCategoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_InterestPosition", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_CertifiedSubject", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_CertifiedAgeGroup", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_FullTimeTeaching", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_IndustryExpertise", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_SpecificExpertise", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_HighestDegreeCompletd", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_FieldOfStudy", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_University", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_CompletionDate", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_AddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_QualificationDetails", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_ExperienceFrom", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_ExperienceTo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_ExperienceInYrs", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_Image", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_JoiningDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_BirthDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_Gender", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_MarrialStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_AgeProof", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_Resume", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_ReleavingLetter", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_RetiredOn", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_ExtraOne", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_CreatedBy", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_LastSchoolwas", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_LastSchoolFromDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_LastSchoolToDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FDFacultyDetailsId == null)
		dr["FD_FacultyDetailsId"] = DBNull.Value;
		else
		dr["FD_FacultyDetailsId"] = FDFacultyDetailsId;
		
		if (FDLoginId == null)
		dr["FD_LoginId"] = DBNull.Value;
		else
		dr["FD_LoginId"] = FDLoginId;
		
		if (FDFacultyId == null)
		dr["FD_FacultyId"] = DBNull.Value;
		else
		dr["FD_FacultyId"] = FDFacultyId;
		
		if (FDSchoolCatgoryId == null)
		dr["FD_SchoolCatgoryId"] = DBNull.Value;
		else
		dr["FD_SchoolCatgoryId"] = FDSchoolCatgoryId;
		
		if (FDTitle == null)
		dr["FD_Title"] = DBNull.Value;
		else
		dr["FD_Title"] = FDTitle;
		
		if (FDFirstName == null)
		dr["FD_FirstName"] = DBNull.Value;
		else
		dr["FD_FirstName"] = FDFirstName;
		
		if (FDMiddleName == null)
		dr["FD_MiddleName"] = DBNull.Value;
		else
		dr["FD_MiddleName"] = FDMiddleName;
		
		if (FDLastName == null)
		dr["FD_LastName"] = DBNull.Value;
		else
		dr["FD_LastName"] = FDLastName;
		
		if (FDDate == null)
		dr["FD_Date"] = DBNull.Value;
		else
		dr["FD_Date"] = FDDate;
		
		if (FDCaste == null)
		dr["FD_Caste"] = DBNull.Value;
		else
		dr["FD_Caste"] = FDCaste;
		
		if (FDSubCaste == null)
		dr["FD_SubCaste"] = DBNull.Value;
		else
		dr["FD_SubCaste"] = FDSubCaste;
		
		if (FDBirthPlace == null)
		dr["FD_BirthPlace"] = DBNull.Value;
		else
		dr["FD_BirthPlace"] = FDBirthPlace;
		
		if (FDBloodGroup == null)
		dr["FD_BloodGroup"] = DBNull.Value;
		else
		dr["FD_BloodGroup"] = FDBloodGroup;
		
		if (FDMotherTongue == null)
		dr["FD_MotherTounge"] = DBNull.Value;
		else
		dr["FD_MotherTounge"] = FDMotherTongue;
		
		if (FDNationality == null)
		dr["FD_Nationality"] = DBNull.Value;
		else
		dr["FD_Nationality"] = FDNationality;
		
		if (FDTransportStatus == null)
		dr["FD_TransportStatus"] = DBNull.Value;
		else
		dr["FD_TransportStatus"] = FDTransportStatus;
		
		if (FDMedicalProblem == null)
		dr["FD_MedicalProblem"] = DBNull.Value;
		else
		dr["FD_MedicalProblem"] = FDMedicalProblem;
		
		if (FDSchoolCategoryId == null)
		dr["FD_SchoolCategoryId"] = DBNull.Value;
		else
		dr["FD_SchoolCategoryId"] = FDSchoolCategoryId;
		
		if (FDSchoolSubCategoryId == null)
		dr["FD_SchoolSubCategoryId"] = DBNull.Value;
		else
		dr["FD_SchoolSubCategoryId"] = FDSchoolSubCategoryId;
		
		if (FDSubjectId == null)
		dr["FD_SubjectId"] = DBNull.Value;
		else
		dr["FD_SubjectId"] = FDSubjectId;
		
		if (FDInterestPosition == null)
		dr["FD_InterestPosition"] = DBNull.Value;
		else
		dr["FD_InterestPosition"] = FDInterestPosition;
		
		if (FDCertifiedSubject == null)
		dr["FD_CertifiedSubject"] = DBNull.Value;
		else
		dr["FD_CertifiedSubject"] = FDCertifiedSubject;
		
		if (FDCertifiedAgeGroup == null)
		dr["FD_CertifiedAgeGroup"] = DBNull.Value;
		else
		dr["FD_CertifiedAgeGroup"] = FDCertifiedAgeGroup;
		
		if (FDFullTimeTeaching == null)
		dr["FD_FullTimeTeaching"] = DBNull.Value;
		else
		dr["FD_FullTimeTeaching"] = FDFullTimeTeaching;
		
		if (FDIndustryExpertise == null)
		dr["FD_IndustryExpertise"] = DBNull.Value;
		else
		dr["FD_IndustryExpertise"] = FDIndustryExpertise;
		
		if (FDSpecificExpertise == null)
		dr["FD_SpecificExpertise"] = DBNull.Value;
		else
		dr["FD_SpecificExpertise"] = FDSpecificExpertise;
		
		if (FDHighestDegreeCompletd == null)
		dr["FD_HighestDegreeCompletd"] = DBNull.Value;
		else
		dr["FD_HighestDegreeCompletd"] = FDHighestDegreeCompletd;
		
		if (FDFieldOfStudy == null)
		dr["FD_FieldOfStudy"] = DBNull.Value;
		else
		dr["FD_FieldOfStudy"] = FDFieldOfStudy;
		
		if (FDUniversity == null)
		dr["FD_University"] = DBNull.Value;
		else
		dr["FD_University"] = FDUniversity;
		
		if (FDCompletionDate == null)
		dr["FD_CompletionDate"] = DBNull.Value;
		else
		dr["FD_CompletionDate"] = FDCompletionDate;
		
		if (FDAddressId == null)
		dr["FD_AddressId"] = DBNull.Value;
		else
		dr["FD_AddressId"] = FDAddressId;
		
		if (FDQualificationDetails == null)
		dr["FD_QualificationDetails"] = DBNull.Value;
		else
		dr["FD_QualificationDetails"] = FDQualificationDetails;
		
		if (FDExperienceFrom == null)
		dr["FD_ExperienceFrom"] = DBNull.Value;
		else
		dr["FD_ExperienceFrom"] = FDExperienceFrom;
		
		if (FDExperienceTo == null)
		dr["FD_ExperienceTo"] = DBNull.Value;
		else
		dr["FD_ExperienceTo"] = FDExperienceTo;
		
		if (FDExperienceInYrs == null)
		dr["FD_ExperienceInYrs"] = DBNull.Value;
		else
		dr["FD_ExperienceInYrs"] = FDExperienceInYrs;
		
		if (FDImage == null)
		dr["FD_Image"] = DBNull.Value;
		else
		dr["FD_Image"] = FDImage;
		
		if (FDJoiningDate == null)
		dr["FD_JoiningDate"] = DBNull.Value;
		else
		dr["FD_JoiningDate"] = FDJoiningDate;
		
		if (FDBirthDate == null)
		dr["FD_BirthDate"] = DBNull.Value;
		else
		dr["FD_BirthDate"] = FDBirthDate;
		
		if (FDGender == null)
		dr["FD_Gender"] = DBNull.Value;
		else
		dr["FD_Gender"] = FDGender;
		
		if (FDMarrialStatus == null)
		dr["FD_MarrialStatus"] = DBNull.Value;
		else
		dr["FD_MarrialStatus"] = FDMarrialStatus;
		
		if (FDAgeProof == null)
		dr["FD_AgeProof"] = DBNull.Value;
		else
		dr["FD_AgeProof"] = FDAgeProof;
		
		if (FDResume == null)
		dr["FD_Resume"] = DBNull.Value;
		else
		dr["FD_Resume"] = FDResume;
		
		if (FDReleavingLetter == null)
		dr["FD_ReleavingLetter"] = DBNull.Value;
		else
		dr["FD_ReleavingLetter"] = FDReleavingLetter;
		
		if (FDRetiredOn == null)
		dr["FD_RetiredOn"] = DBNull.Value;
		else
		dr["FD_RetiredOn"] = FDRetiredOn;
		
		if (FDExtraOne == null)
		dr["FD_ExtraOne"] = DBNull.Value;
		else
		dr["FD_ExtraOne"] = FDExtraOne;
		
		if (FDCreatedBy == null)
		dr["FD_CreatedBy"] = DBNull.Value;
		else
		dr["FD_CreatedBy"] = FDCreatedBy;
		
		if (FDLastSchoolwas == null)
		dr["FD_LastSchoolwas"] = DBNull.Value;
		else
		dr["FD_LastSchoolwas"] = FDLastSchoolwas;
		
		if (FDLastSchoolFromDate == null)
		dr["FD_LastSchoolFromDate"] = DBNull.Value;
		else
		dr["FD_LastSchoolFromDate"] = FDLastSchoolFromDate;
		
		if (FDLastSchoolToDate == null)
		dr["FD_LastSchoolToDate"] = DBNull.Value;
		else
		dr["FD_LastSchoolToDate"] = FDLastSchoolToDate;
		
		if (FDStatus == null)
		dr["FD_Status"] = DBNull.Value;
		else
		dr["FD_Status"] = FDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FDFacultyDetailsId = dr["FD_FacultyDetailsId"] != DBNull.Value ? Convert.ToInt64(dr["FD_FacultyDetailsId"]) : FDFacultyDetailsId = null;
		FDLoginId = dr["FD_LoginId"] != DBNull.Value ? Convert.ToInt64(dr["FD_LoginId"]) : FDLoginId = null;
		FDFacultyId = dr["FD_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["FD_FacultyId"]) : FDFacultyId = null;
		FDSchoolCatgoryId = dr["FD_SchoolCatgoryId"] != DBNull.Value ? Convert.ToInt64(dr["FD_SchoolCatgoryId"]) : FDSchoolCatgoryId = null;
		FDTitle = dr["FD_Title"] != DBNull.Value ? Convert.ToString(dr["FD_Title"]) : FDTitle = null;
		FDFirstName = dr["FD_FirstName"] != DBNull.Value ? Convert.ToString(dr["FD_FirstName"]) : FDFirstName = null;
		FDMiddleName = dr["FD_MiddleName"] != DBNull.Value ? Convert.ToString(dr["FD_MiddleName"]) : FDMiddleName = null;
		FDLastName = dr["FD_LastName"] != DBNull.Value ? Convert.ToString(dr["FD_LastName"]) : FDLastName = null;
		FDDate = dr["FD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["FD_Date"]) : FDDate = null;
		FDCaste = dr["FD_Caste"] != DBNull.Value ? Convert.ToString(dr["FD_Caste"]) : FDCaste = null;
		FDSubCaste = dr["FD_SubCaste"] != DBNull.Value ? Convert.ToString(dr["FD_SubCaste"]) : FDSubCaste = null;
		FDBirthPlace = dr["FD_BirthPlace"] != DBNull.Value ? Convert.ToString(dr["FD_BirthPlace"]) : FDBirthPlace = null;
		FDBloodGroup = dr["FD_BloodGroup"] != DBNull.Value ? Convert.ToString(dr["FD_BloodGroup"]) : FDBloodGroup = null;
		FDMotherTongue = dr["FD_MotherTounge"] != DBNull.Value ? Convert.ToString(dr["FD_MotherTounge"]) : FDMotherTongue = null;
		FDNationality = dr["FD_Nationality"] != DBNull.Value ? Convert.ToString(dr["FD_Nationality"]) : FDNationality = null;
		FDTransportStatus = dr["FD_TransportStatus"] != DBNull.Value ? Convert.ToString(dr["FD_TransportStatus"]) : FDTransportStatus = null;
		FDMedicalProblem = dr["FD_MedicalProblem"] != DBNull.Value ? Convert.ToString(dr["FD_MedicalProblem"]) : FDMedicalProblem = null;
		FDSchoolCategoryId = dr["FD_SchoolCategoryId"] != DBNull.Value ? Convert.ToInt64(dr["FD_SchoolCategoryId"]) : FDSchoolCategoryId = null;
		FDSchoolSubCategoryId = dr["FD_SchoolSubCategoryId"] != DBNull.Value ? Convert.ToInt64(dr["FD_SchoolSubCategoryId"]) : FDSchoolSubCategoryId = null;
		FDSubjectId = dr["FD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["FD_SubjectId"]) : FDSubjectId = null;
		FDInterestPosition = dr["FD_InterestPosition"] != DBNull.Value ? Convert.ToString(dr["FD_InterestPosition"]) : FDInterestPosition = null;
		FDCertifiedSubject = dr["FD_CertifiedSubject"] != DBNull.Value ? Convert.ToString(dr["FD_CertifiedSubject"]) : FDCertifiedSubject = null;
		FDCertifiedAgeGroup = dr["FD_CertifiedAgeGroup"] != DBNull.Value ? Convert.ToString(dr["FD_CertifiedAgeGroup"]) : FDCertifiedAgeGroup = null;
		FDFullTimeTeaching = dr["FD_FullTimeTeaching"] != DBNull.Value ? Convert.ToString(dr["FD_FullTimeTeaching"]) : FDFullTimeTeaching = null;
		FDIndustryExpertise = dr["FD_IndustryExpertise"] != DBNull.Value ? Convert.ToString(dr["FD_IndustryExpertise"]) : FDIndustryExpertise = null;
		FDSpecificExpertise = dr["FD_SpecificExpertise"] != DBNull.Value ? Convert.ToString(dr["FD_SpecificExpertise"]) : FDSpecificExpertise = null;
		FDHighestDegreeCompletd = dr["FD_HighestDegreeCompletd"] != DBNull.Value ? Convert.ToString(dr["FD_HighestDegreeCompletd"]) : FDHighestDegreeCompletd = null;
		FDFieldOfStudy = dr["FD_FieldOfStudy"] != DBNull.Value ? Convert.ToString(dr["FD_FieldOfStudy"]) : FDFieldOfStudy = null;
		FDUniversity = dr["FD_University"] != DBNull.Value ? Convert.ToString(dr["FD_University"]) : FDUniversity = null;
		FDCompletionDate = dr["FD_CompletionDate"] != DBNull.Value ? Convert.ToString(dr["FD_CompletionDate"]) : FDCompletionDate = null;
		FDAddressId = dr["FD_AddressId"] != DBNull.Value ? Convert.ToInt64(dr["FD_AddressId"]) : FDAddressId = null;
		FDQualificationDetails = dr["FD_QualificationDetails"] != DBNull.Value ? Convert.ToString(dr["FD_QualificationDetails"]) : FDQualificationDetails = null;
		FDExperienceFrom = dr["FD_ExperienceFrom"] != DBNull.Value ? Convert.ToString(dr["FD_ExperienceFrom"]) : FDExperienceFrom = null;
		FDExperienceTo = dr["FD_ExperienceTo"] != DBNull.Value ? Convert.ToString(dr["FD_ExperienceTo"]) : FDExperienceTo = null;
		FDExperienceInYrs = dr["FD_ExperienceInYrs"] != DBNull.Value ? Convert.ToInt64(dr["FD_ExperienceInYrs"]) : FDExperienceInYrs = null;
		FDImage = dr["FD_Image"] != DBNull.Value ? Convert.ToString(dr["FD_Image"]) : FDImage = null;
		FDJoiningDate = dr["FD_JoiningDate"] != DBNull.Value ? Convert.ToDateTime(dr["FD_JoiningDate"]) : FDJoiningDate = null;
		FDBirthDate = dr["FD_BirthDate"] != DBNull.Value ? Convert.ToDateTime(dr["FD_BirthDate"]) : FDBirthDate = null;
		FDGender = dr["FD_Gender"] != DBNull.Value ? Convert.ToString(dr["FD_Gender"]) : FDGender = null;
		FDMarrialStatus = dr["FD_MarrialStatus"] != DBNull.Value ? Convert.ToString(dr["FD_MarrialStatus"]) : FDMarrialStatus = null;
		FDAgeProof = dr["FD_AgeProof"] != DBNull.Value ? Convert.ToString(dr["FD_AgeProof"]) : FDAgeProof = null;
		FDResume = dr["FD_Resume"] != DBNull.Value ? Convert.ToString(dr["FD_Resume"]) : FDResume = null;
		FDReleavingLetter = dr["FD_ReleavingLetter"] != DBNull.Value ? Convert.ToString(dr["FD_ReleavingLetter"]) : FDReleavingLetter = null;
		FDRetiredOn = dr["FD_RetiredOn"] != DBNull.Value ? Convert.ToDateTime(dr["FD_RetiredOn"]) : FDRetiredOn = null;
		FDExtraOne = dr["FD_ExtraOne"] != DBNull.Value ? Convert.ToString(dr["FD_ExtraOne"]) : FDExtraOne = null;
		FDCreatedBy = dr["FD_CreatedBy"] != DBNull.Value ? Convert.ToInt64(dr["FD_CreatedBy"]) : FDCreatedBy = null;
		FDLastSchoolwas = dr["FD_LastSchoolwas"] != DBNull.Value ? Convert.ToString(dr["FD_LastSchoolwas"]) : FDLastSchoolwas = null;
		FDLastSchoolFromDate = dr["FD_LastSchoolFromDate"] != DBNull.Value ? Convert.ToDateTime(dr["FD_LastSchoolFromDate"]) : FDLastSchoolFromDate = null;
		FDLastSchoolToDate = dr["FD_LastSchoolToDate"] != DBNull.Value ? Convert.ToDateTime(dr["FD_LastSchoolToDate"]) : FDLastSchoolToDate = null;
		FDStatus = dr["FD_Status"] != DBNull.Value ? Convert.ToInt32(dr["FD_Status"]) : FDStatus = null;
	}
	
	public static TMSFacultyDetails[] MapFrom(DataSet ds)
	{
		List<TMSFacultyDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFacultyDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FacultyDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FacultyDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFacultyDetails instance = new TMSFacultyDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFacultyDetails Get(System.Int64 fdFacultyDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFacultyDetails instance;
		
		
		instance = new TMSFacultyDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFacultyDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fdFacultyDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSFacultyDetails ID:" + fdFacultyDetailsId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? fdLoginId, System.Int64? fdFacultyId, System.Int64? fdSchoolCatgoryId, System.String fdTitle, System.String fdFirstName, System.String fdMiddleName, System.String fdLastName, System.DateTime? fdDate, System.String fdCaste, System.String fdSubCaste, System.String fdBirthPlace, System.String fdBloodGroup, System.String fdMotherTongue, System.String fdNationality, System.String fdTransportStatus, System.String fdMedicalProblem, System.Int64? fdSchoolCategoryId, System.Int64? fdSchoolSubCategoryId, System.Int64? fdSubjectId, System.String fdInterestPosition, System.String fdCertifiedSubject, System.String fdCertifiedAgeGroup, System.String fdFullTimeTeaching, System.String fdIndustryExpertise, System.String fdSpecificExpertise, System.String fdHighestDegreeCompletd, System.String fdFieldOfStudy, System.String fdUniversity, System.String fdCompletionDate, System.Int64? fdAddressId, System.String fdQualificationDetails, System.String fdExperienceFrom, System.String fdExperienceTo, System.Int64? fdExperienceInYrs, System.String fdImage, System.DateTime? fdJoiningDate, System.DateTime? fdBirthDate, System.String fdGender, System.String fdMarrialStatus, System.String fdAgeProof, System.String fdResume, System.String fdReleavingLetter, System.DateTime? fdRetiredOn, System.String fdExtraOne, System.Int64? fdCreatedBy, System.String fdLastSchoolwas, System.DateTime? fdLastSchoolFromDate, System.DateTime? fdLastSchoolToDate, System.Int32? fdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFacultyDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fdLoginId, fdFacultyId, fdSchoolCatgoryId, fdTitle, fdFirstName, fdMiddleName, fdLastName, fdDate, fdCaste, fdSubCaste, fdBirthPlace, fdBloodGroup, fdMotherTongue, fdNationality, fdTransportStatus, fdMedicalProblem, fdSchoolCategoryId, fdSchoolSubCategoryId, fdSubjectId, fdInterestPosition, fdCertifiedSubject, fdCertifiedAgeGroup, fdFullTimeTeaching, fdIndustryExpertise, fdSpecificExpertise, fdHighestDegreeCompletd, fdFieldOfStudy, fdUniversity, fdCompletionDate, fdAddressId, fdQualificationDetails, fdExperienceFrom, fdExperienceTo, fdExperienceInYrs, fdImage, fdJoiningDate, fdBirthDate, fdGender, fdMarrialStatus, fdAgeProof, fdResume, fdReleavingLetter, fdRetiredOn, fdExtraOne, fdCreatedBy, fdLastSchoolwas, fdLastSchoolFromDate, fdLastSchoolToDate, fdStatus);
		
		if (transaction == null)
		this.FDFacultyDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.FDFacultyDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? fdLoginId, System.Int64? fdFacultyId, System.Int64? fdSchoolCatgoryId, System.String fdTitle, System.String fdFirstName, System.String fdMiddleName, System.String fdLastName, System.DateTime? fdDate, System.String fdCaste, System.String fdSubCaste, System.String fdBirthPlace, System.String fdBloodGroup, System.String fdMotherTongue, System.String fdNationality, System.String fdTransportStatus, System.String fdMedicalProblem, System.Int64? fdSchoolCategoryId, System.Int64? fdSchoolSubCategoryId, System.Int64? fdSubjectId, System.String fdInterestPosition, System.String fdCertifiedSubject, System.String fdCertifiedAgeGroup, System.String fdFullTimeTeaching, System.String fdIndustryExpertise, System.String fdSpecificExpertise, System.String fdHighestDegreeCompletd, System.String fdFieldOfStudy, System.String fdUniversity, System.String fdCompletionDate, System.Int64? fdAddressId, System.String fdQualificationDetails, System.String fdExperienceFrom, System.String fdExperienceTo, System.Int64? fdExperienceInYrs, System.String fdImage, System.DateTime? fdJoiningDate, System.DateTime? fdBirthDate, System.String fdGender, System.String fdMarrialStatus, System.String fdAgeProof, System.String fdResume, System.String fdReleavingLetter, System.DateTime? fdRetiredOn, System.String fdExtraOne, System.Int64? fdCreatedBy, System.String fdLastSchoolwas, System.DateTime? fdLastSchoolFromDate, System.DateTime? fdLastSchoolToDate, System.Int32? fdStatus)
	{
		Insert(fdLoginId, fdFacultyId, fdSchoolCatgoryId, fdTitle, fdFirstName, fdMiddleName, fdLastName, fdDate, fdCaste, fdSubCaste, fdBirthPlace, fdBloodGroup, fdMotherTongue, fdNationality, fdTransportStatus, fdMedicalProblem, fdSchoolCategoryId, fdSchoolSubCategoryId, fdSubjectId, fdInterestPosition, fdCertifiedSubject, fdCertifiedAgeGroup, fdFullTimeTeaching, fdIndustryExpertise, fdSpecificExpertise, fdHighestDegreeCompletd, fdFieldOfStudy, fdUniversity, fdCompletionDate, fdAddressId, fdQualificationDetails, fdExperienceFrom, fdExperienceTo, fdExperienceInYrs, fdImage, fdJoiningDate, fdBirthDate, fdGender, fdMarrialStatus, fdAgeProof, fdResume, fdReleavingLetter, fdRetiredOn, fdExtraOne, fdCreatedBy, fdLastSchoolwas, fdLastSchoolFromDate, fdLastSchoolToDate, fdStatus, null);
	}
	/// <summary>
	/// Insert current TMSFacultyDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FDLoginId, FDFacultyId, FDSchoolCatgoryId, FDTitle, FDFirstName, FDMiddleName, FDLastName, FDDate, FDCaste, FDSubCaste, FDBirthPlace, FDBloodGroup, FDMotherTongue, FDNationality, FDTransportStatus, FDMedicalProblem, FDSchoolCategoryId, FDSchoolSubCategoryId, FDSubjectId, FDInterestPosition, FDCertifiedSubject, FDCertifiedAgeGroup, FDFullTimeTeaching, FDIndustryExpertise, FDSpecificExpertise, FDHighestDegreeCompletd, FDFieldOfStudy, FDUniversity, FDCompletionDate, FDAddressId, FDQualificationDetails, FDExperienceFrom, FDExperienceTo, FDExperienceInYrs, FDImage, FDJoiningDate, FDBirthDate, FDGender, FDMarrialStatus, FDAgeProof, FDResume, FDReleavingLetter, FDRetiredOn, FDExtraOne, FDCreatedBy, FDLastSchoolwas, FDLastSchoolFromDate, FDLastSchoolToDate, FDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFacultyDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? fdFacultyDetailsId, System.Int64? fdLoginId, System.Int64? fdFacultyId, System.Int64? fdSchoolCatgoryId, System.String fdTitle, System.String fdFirstName, System.String fdMiddleName, System.String fdLastName, System.DateTime? fdDate, System.String fdCaste, System.String fdSubCaste, System.String fdBirthPlace, System.String fdBloodGroup, System.String fdMotherTongue, System.String fdNationality, System.String fdTransportStatus, System.String fdMedicalProblem, System.Int64? fdSchoolCategoryId, System.Int64? fdSchoolSubCategoryId, System.Int64? fdSubjectId, System.String fdInterestPosition, System.String fdCertifiedSubject, System.String fdCertifiedAgeGroup, System.String fdFullTimeTeaching, System.String fdIndustryExpertise, System.String fdSpecificExpertise, System.String fdHighestDegreeCompletd, System.String fdFieldOfStudy, System.String fdUniversity, System.String fdCompletionDate, System.Int64? fdAddressId, System.String fdQualificationDetails, System.String fdExperienceFrom, System.String fdExperienceTo, System.Int64? fdExperienceInYrs, System.String fdImage, System.DateTime? fdJoiningDate, System.DateTime? fdBirthDate, System.String fdGender, System.String fdMarrialStatus, System.String fdAgeProof, System.String fdResume, System.String fdReleavingLetter, System.DateTime? fdRetiredOn, System.String fdExtraOne, System.Int64? fdCreatedBy, System.String fdLastSchoolwas, System.DateTime? fdLastSchoolFromDate, System.DateTime? fdLastSchoolToDate, System.Int32? fdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFacultyDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fdFacultyDetailsId"].Value = fdFacultyDetailsId;
		dbCommand.Parameters["@fdLoginId"].Value = fdLoginId;
		dbCommand.Parameters["@fdFacultyId"].Value = fdFacultyId;
		dbCommand.Parameters["@fdSchoolCatgoryId"].Value = fdSchoolCatgoryId;
		dbCommand.Parameters["@fdTitle"].Value = fdTitle;
		dbCommand.Parameters["@fdFirstName"].Value = fdFirstName;
		dbCommand.Parameters["@fdMiddleName"].Value = fdMiddleName;
		dbCommand.Parameters["@fdLastName"].Value = fdLastName;
		dbCommand.Parameters["@fdDate"].Value = fdDate;
		dbCommand.Parameters["@fdCaste"].Value = fdCaste;
		dbCommand.Parameters["@fdSubCaste"].Value = fdSubCaste;
		dbCommand.Parameters["@fdBirthPlace"].Value = fdBirthPlace;
		dbCommand.Parameters["@fdBloodGroup"].Value = fdBloodGroup;
		dbCommand.Parameters["@fdMotherTounge"].Value = fdMotherTongue;
		dbCommand.Parameters["@fdNationality"].Value = fdNationality;
		dbCommand.Parameters["@fdTransportStatus"].Value = fdTransportStatus;
		dbCommand.Parameters["@fdMedicalProblem"].Value = fdMedicalProblem;
		dbCommand.Parameters["@fdSchoolCategoryId"].Value = fdSchoolCategoryId;
		dbCommand.Parameters["@fdSchoolSubCategoryId"].Value = fdSchoolSubCategoryId;
		dbCommand.Parameters["@fdSubjectId"].Value = fdSubjectId;
		dbCommand.Parameters["@fdInterestPosition"].Value = fdInterestPosition;
		dbCommand.Parameters["@fdCertifiedSubject"].Value = fdCertifiedSubject;
		dbCommand.Parameters["@fdCertifiedAgeGroup"].Value = fdCertifiedAgeGroup;
		dbCommand.Parameters["@fdFullTimeTeaching"].Value = fdFullTimeTeaching;
		dbCommand.Parameters["@fdIndustryExpertise"].Value = fdIndustryExpertise;
		dbCommand.Parameters["@fdSpecificExpertise"].Value = fdSpecificExpertise;
		dbCommand.Parameters["@fdHighestDegreeCompletd"].Value = fdHighestDegreeCompletd;
		dbCommand.Parameters["@fdFieldOfStudy"].Value = fdFieldOfStudy;
		dbCommand.Parameters["@fdUniversity"].Value = fdUniversity;
		dbCommand.Parameters["@fdCompletionDate"].Value = fdCompletionDate;
		dbCommand.Parameters["@fdAddressId"].Value = fdAddressId;
		dbCommand.Parameters["@fdQualificationDetails"].Value = fdQualificationDetails;
		dbCommand.Parameters["@fdExperienceFrom"].Value = fdExperienceFrom;
		dbCommand.Parameters["@fdExperienceTo"].Value = fdExperienceTo;
		dbCommand.Parameters["@fdExperienceInYrs"].Value = fdExperienceInYrs;
		dbCommand.Parameters["@fdImage"].Value = fdImage;
		dbCommand.Parameters["@fdJoiningDate"].Value = fdJoiningDate;
		dbCommand.Parameters["@fdBirthDate"].Value = fdBirthDate;
		dbCommand.Parameters["@fdGender"].Value = fdGender;
		dbCommand.Parameters["@fdMarrialStatus"].Value = fdMarrialStatus;
		dbCommand.Parameters["@fdAgeProof"].Value = fdAgeProof;
		dbCommand.Parameters["@fdResume"].Value = fdResume;
		dbCommand.Parameters["@fdReleavingLetter"].Value = fdReleavingLetter;
		dbCommand.Parameters["@fdRetiredOn"].Value = fdRetiredOn;
		dbCommand.Parameters["@fdExtraOne"].Value = fdExtraOne;
		dbCommand.Parameters["@fdCreatedBy"].Value = fdCreatedBy;
		dbCommand.Parameters["@fdLastSchoolwas"].Value = fdLastSchoolwas;
		dbCommand.Parameters["@fdLastSchoolFromDate"].Value = fdLastSchoolFromDate;
		dbCommand.Parameters["@fdLastSchoolToDate"].Value = fdLastSchoolToDate;
		dbCommand.Parameters["@fdStatus"].Value = fdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? fdFacultyDetailsId, System.Int64? fdLoginId, System.Int64? fdFacultyId, System.Int64? fdSchoolCatgoryId, System.String fdTitle, System.String fdFirstName, System.String fdMiddleName, System.String fdLastName, System.DateTime? fdDate, System.String fdCaste, System.String fdSubCaste, System.String fdBirthPlace, System.String fdBloodGroup, System.String fdMotherTongue, System.String fdNationality, System.String fdTransportStatus, System.String fdMedicalProblem, System.Int64? fdSchoolCategoryId, System.Int64? fdSchoolSubCategoryId, System.Int64? fdSubjectId, System.String fdInterestPosition, System.String fdCertifiedSubject, System.String fdCertifiedAgeGroup, System.String fdFullTimeTeaching, System.String fdIndustryExpertise, System.String fdSpecificExpertise, System.String fdHighestDegreeCompletd, System.String fdFieldOfStudy, System.String fdUniversity, System.String fdCompletionDate, System.Int64? fdAddressId, System.String fdQualificationDetails, System.String fdExperienceFrom, System.String fdExperienceTo, System.Int64? fdExperienceInYrs, System.String fdImage, System.DateTime? fdJoiningDate, System.DateTime? fdBirthDate, System.String fdGender, System.String fdMarrialStatus, System.String fdAgeProof, System.String fdResume, System.String fdReleavingLetter, System.DateTime? fdRetiredOn, System.String fdExtraOne, System.Int64? fdCreatedBy, System.String fdLastSchoolwas, System.DateTime? fdLastSchoolFromDate, System.DateTime? fdLastSchoolToDate, System.Int32? fdStatus)
	{
		Update(fdFacultyDetailsId, fdLoginId, fdFacultyId, fdSchoolCatgoryId, fdTitle, fdFirstName, fdMiddleName, fdLastName, fdDate, fdCaste, fdSubCaste, fdBirthPlace, fdBloodGroup, fdMotherTongue, fdNationality, fdTransportStatus, fdMedicalProblem, fdSchoolCategoryId, fdSchoolSubCategoryId, fdSubjectId, fdInterestPosition, fdCertifiedSubject, fdCertifiedAgeGroup, fdFullTimeTeaching, fdIndustryExpertise, fdSpecificExpertise, fdHighestDegreeCompletd, fdFieldOfStudy, fdUniversity, fdCompletionDate, fdAddressId, fdQualificationDetails, fdExperienceFrom, fdExperienceTo, fdExperienceInYrs, fdImage, fdJoiningDate, fdBirthDate, fdGender, fdMarrialStatus, fdAgeProof, fdResume, fdReleavingLetter, fdRetiredOn, fdExtraOne, fdCreatedBy, fdLastSchoolwas, fdLastSchoolFromDate, fdLastSchoolToDate, fdStatus, null);
	}
	
	public static void Update(TMSFacultyDetails tMSFacultyDetails)
	{
		tMSFacultyDetails.Update();
	}
	
	public static void Update(TMSFacultyDetails tMSFacultyDetails, DbTransaction transaction)
	{
		tMSFacultyDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFacultyDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fdFacultyDetailsId"].SourceColumn = "FD_FacultyDetailsId";
		dbCommand.Parameters["@fdLoginId"].SourceColumn = "FD_LoginId";
		dbCommand.Parameters["@fdFacultyId"].SourceColumn = "FD_FacultyId";
		dbCommand.Parameters["@fdSchoolCatgoryId"].SourceColumn = "FD_SchoolCatgoryId";
		dbCommand.Parameters["@fdTitle"].SourceColumn = "FD_Title";
		dbCommand.Parameters["@fdFirstName"].SourceColumn = "FD_FirstName";
		dbCommand.Parameters["@fdMiddleName"].SourceColumn = "FD_MiddleName";
		dbCommand.Parameters["@fdLastName"].SourceColumn = "FD_LastName";
		dbCommand.Parameters["@fdDate"].SourceColumn = "FD_Date";
		dbCommand.Parameters["@fdCaste"].SourceColumn = "FD_Caste";
		dbCommand.Parameters["@fdSubCaste"].SourceColumn = "FD_SubCaste";
		dbCommand.Parameters["@fdBirthPlace"].SourceColumn = "FD_BirthPlace";
		dbCommand.Parameters["@fdBloodGroup"].SourceColumn = "FD_BloodGroup";
		dbCommand.Parameters["@fdMotherTounge"].SourceColumn = "FD_MotherTounge";
		dbCommand.Parameters["@fdNationality"].SourceColumn = "FD_Nationality";
		dbCommand.Parameters["@fdTransportStatus"].SourceColumn = "FD_TransportStatus";
		dbCommand.Parameters["@fdMedicalProblem"].SourceColumn = "FD_MedicalProblem";
		dbCommand.Parameters["@fdSchoolCategoryId"].SourceColumn = "FD_SchoolCategoryId";
		dbCommand.Parameters["@fdSchoolSubCategoryId"].SourceColumn = "FD_SchoolSubCategoryId";
		dbCommand.Parameters["@fdSubjectId"].SourceColumn = "FD_SubjectId";
		dbCommand.Parameters["@fdInterestPosition"].SourceColumn = "FD_InterestPosition";
		dbCommand.Parameters["@fdCertifiedSubject"].SourceColumn = "FD_CertifiedSubject";
		dbCommand.Parameters["@fdCertifiedAgeGroup"].SourceColumn = "FD_CertifiedAgeGroup";
		dbCommand.Parameters["@fdFullTimeTeaching"].SourceColumn = "FD_FullTimeTeaching";
		dbCommand.Parameters["@fdIndustryExpertise"].SourceColumn = "FD_IndustryExpertise";
		dbCommand.Parameters["@fdSpecificExpertise"].SourceColumn = "FD_SpecificExpertise";
		dbCommand.Parameters["@fdHighestDegreeCompletd"].SourceColumn = "FD_HighestDegreeCompletd";
		dbCommand.Parameters["@fdFieldOfStudy"].SourceColumn = "FD_FieldOfStudy";
		dbCommand.Parameters["@fdUniversity"].SourceColumn = "FD_University";
		dbCommand.Parameters["@fdCompletionDate"].SourceColumn = "FD_CompletionDate";
		dbCommand.Parameters["@fdAddressId"].SourceColumn = "FD_AddressId";
		dbCommand.Parameters["@fdQualificationDetails"].SourceColumn = "FD_QualificationDetails";
		dbCommand.Parameters["@fdExperienceFrom"].SourceColumn = "FD_ExperienceFrom";
		dbCommand.Parameters["@fdExperienceTo"].SourceColumn = "FD_ExperienceTo";
		dbCommand.Parameters["@fdExperienceInYrs"].SourceColumn = "FD_ExperienceInYrs";
		dbCommand.Parameters["@fdImage"].SourceColumn = "FD_Image";
		dbCommand.Parameters["@fdJoiningDate"].SourceColumn = "FD_JoiningDate";
		dbCommand.Parameters["@fdBirthDate"].SourceColumn = "FD_BirthDate";
		dbCommand.Parameters["@fdGender"].SourceColumn = "FD_Gender";
		dbCommand.Parameters["@fdMarrialStatus"].SourceColumn = "FD_MarrialStatus";
		dbCommand.Parameters["@fdAgeProof"].SourceColumn = "FD_AgeProof";
		dbCommand.Parameters["@fdResume"].SourceColumn = "FD_Resume";
		dbCommand.Parameters["@fdReleavingLetter"].SourceColumn = "FD_ReleavingLetter";
		dbCommand.Parameters["@fdRetiredOn"].SourceColumn = "FD_RetiredOn";
		dbCommand.Parameters["@fdExtraOne"].SourceColumn = "FD_ExtraOne";
		dbCommand.Parameters["@fdCreatedBy"].SourceColumn = "FD_CreatedBy";
		dbCommand.Parameters["@fdLastSchoolwas"].SourceColumn = "FD_LastSchoolwas";
		dbCommand.Parameters["@fdLastSchoolFromDate"].SourceColumn = "FD_LastSchoolFromDate";
		dbCommand.Parameters["@fdLastSchoolToDate"].SourceColumn = "FD_LastSchoolToDate";
		dbCommand.Parameters["@fdStatus"].SourceColumn = "FD_Status";
		
		ds = new DataSet();
		this.MapTo( ds );
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
	public static void Delete(System.Int64? fdFacultyDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFacultyDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fdFacultyDetailsId);
		
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
	public static void Delete(System.Int64? fdFacultyDetailsId)
	{
		Delete(
		fdFacultyDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSFacultyDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFacultyDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FDFacultyDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FDFacultyDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSFacultyDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFacultyDetails[] Search(System.Int64? fdFacultyDetailsId, System.Int64? fdLoginId, System.Int64? fdFacultyId, System.Int64? fdSchoolCatgoryId, System.String fdTitle, System.String fdFirstName, System.String fdMiddleName, System.String fdLastName, System.DateTime? fdDate, System.String fdCaste, System.String fdSubCaste, System.String fdBirthPlace, System.String fdBloodGroup, System.String fdMotherTongue, System.String fdNationality, System.String fdTransportStatus, System.String fdMedicalProblem, System.Int64? fdSchoolCategoryId, System.Int64? fdSchoolSubCategoryId, System.Int64? fdSubjectId, System.String fdInterestPosition, System.String fdCertifiedSubject, System.String fdCertifiedAgeGroup, System.String fdFullTimeTeaching, System.String fdIndustryExpertise, System.String fdSpecificExpertise, System.String fdHighestDegreeCompletd, System.String fdFieldOfStudy, System.String fdUniversity, System.String fdCompletionDate, System.Int64? fdAddressId, System.String fdQualificationDetails, System.String fdExperienceFrom, System.String fdExperienceTo, System.Int64? fdExperienceInYrs, System.String fdImage, System.DateTime? fdJoiningDate, System.DateTime? fdBirthDate, System.String fdGender, System.String fdMarrialStatus, System.String fdAgeProof, System.String fdResume, System.String fdReleavingLetter, System.DateTime? fdRetiredOn, System.String fdExtraOne, System.Int64? fdCreatedBy, System.String fdLastSchoolwas, System.DateTime? fdLastSchoolFromDate, System.DateTime? fdLastSchoolToDate, System.Int32? fdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFacultyDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fdFacultyDetailsId, fdLoginId, fdFacultyId, fdSchoolCatgoryId, fdTitle, fdFirstName, fdMiddleName, fdLastName, fdDate, fdCaste, fdSubCaste, fdBirthPlace, fdBloodGroup, fdMotherTongue, fdNationality, fdTransportStatus, fdMedicalProblem, fdSchoolCategoryId, fdSchoolSubCategoryId, fdSubjectId, fdInterestPosition, fdCertifiedSubject, fdCertifiedAgeGroup, fdFullTimeTeaching, fdIndustryExpertise, fdSpecificExpertise, fdHighestDegreeCompletd, fdFieldOfStudy, fdUniversity, fdCompletionDate, fdAddressId, fdQualificationDetails, fdExperienceFrom, fdExperienceTo, fdExperienceInYrs, fdImage, fdJoiningDate, fdBirthDate, fdGender, fdMarrialStatus, fdAgeProof, fdResume, fdReleavingLetter, fdRetiredOn, fdExtraOne, fdCreatedBy, fdLastSchoolwas, fdLastSchoolFromDate, fdLastSchoolToDate, fdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFacultyDetails.MapFrom(ds);
	}
	
	
	public static TMSFacultyDetails[] Search(TMSFacultyDetails searchObject)
	{
		return Search ( searchObject.FDFacultyDetailsId, searchObject.FDLoginId, searchObject.FDFacultyId, searchObject.FDSchoolCatgoryId, searchObject.FDTitle, searchObject.FDFirstName, searchObject.FDMiddleName, searchObject.FDLastName, searchObject.FDDate, searchObject.FDCaste, searchObject.FDSubCaste, searchObject.FDBirthPlace, searchObject.FDBloodGroup, searchObject.FDMotherTongue, searchObject.FDNationality, searchObject.FDTransportStatus, searchObject.FDMedicalProblem, searchObject.FDSchoolCategoryId, searchObject.FDSchoolSubCategoryId, searchObject.FDSubjectId, searchObject.FDInterestPosition, searchObject.FDCertifiedSubject, searchObject.FDCertifiedAgeGroup, searchObject.FDFullTimeTeaching, searchObject.FDIndustryExpertise, searchObject.FDSpecificExpertise, searchObject.FDHighestDegreeCompletd, searchObject.FDFieldOfStudy, searchObject.FDUniversity, searchObject.FDCompletionDate, searchObject.FDAddressId, searchObject.FDQualificationDetails, searchObject.FDExperienceFrom, searchObject.FDExperienceTo, searchObject.FDExperienceInYrs, searchObject.FDImage, searchObject.FDJoiningDate, searchObject.FDBirthDate, searchObject.FDGender, searchObject.FDMarrialStatus, searchObject.FDAgeProof, searchObject.FDResume, searchObject.FDReleavingLetter, searchObject.FDRetiredOn, searchObject.FDExtraOne, searchObject.FDCreatedBy, searchObject.FDLastSchoolwas, searchObject.FDLastSchoolFromDate, searchObject.FDLastSchoolToDate, searchObject.FDStatus);
	}
	
	/// <summary>
	/// Returns all TMSFacultyDetails objects.
	/// </summary>
	/// <returns>List of all TMSFacultyDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFacultyDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

