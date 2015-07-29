/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 11/29/2012 11:35:37 AM                                    */
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
public partial class TMSStudentApplication
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_StudentApplication]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _saApplicationId;
	private System.String _saStudentPNRId;
	private System.String _saFirstName;
	private System.String _saMiddleName;
	private System.String _saLastName;
	private System.DateTime? _saDateOfBirth;
	private System.String _saPlaceOfBirth;
	private System.String _saAcadamicYear;
	private System.String _saBloodGroup;
	private System.String _saStudentImage;
	private System.String _saNationality;
	private System.String _saGender;
	private System.String _saCaste;
	private System.String _saSubCaste;
	private System.DateTime? _saDateOfApplication;
	private System.String _saMotherTongue;
	private System.Int64? _saSchoolCategoryId;
	private System.String _saTransportStatus;
	private System.String _saMedicalProblem;
	private System.String _saLastSchoolAttended;
	private System.String _saLastClassAttended;
	private System.String _saLastClassPer;
	private System.String _saFatherFullName;
	private System.String _saFatherPhoto;
	private System.String _saFatherEduQualification;
	private System.String _saFatherOccupation;
	private System.Int64? _saFatherAddressId;
	private System.String _saFatherOrgName;
	private System.String _saFatherDsgtName;
	private System.String _saMotherFullName;
	private System.String _saMotherPhoto;
	private System.String _saMotherEduQualification;
	private System.String _saMotherOccupation;
	private System.Int64? _saMotherAddressId;
	private System.String _saMotherOrgName;
	private System.String _saMotherDsgtName;
	private System.Int64? _saAddressId;
	private System.String _saAgeProof;
	private System.String _saLastProgressReportCard;
	private System.String _saOriginalSchoolLC;
	private System.String _saPassportAndVisa;
	private System.String _saRegistrationLetter;
	private System.String _saApplicationStatus;
	private System.Int32? _saStatus;
	private System.String _saFormNo;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SAApplicationId
	{
		get
		{
			return _saApplicationId;
		}
		set
		{
			_saApplicationId = value;
		}
	}
	
	public System.String SAStudentPNRId
	{
		get
		{
			return _saStudentPNRId;
		}
		set
		{
			_saStudentPNRId = value;
		}
	}
	
	public System.String SAFirstName
	{
		get
		{
			return _saFirstName;
		}
		set
		{
			_saFirstName = value;
		}
	}
	
	public System.String SAMiddleName
	{
		get
		{
			return _saMiddleName;
		}
		set
		{
			_saMiddleName = value;
		}
	}
	
	public System.String SALastName
	{
		get
		{
			return _saLastName;
		}
		set
		{
			_saLastName = value;
		}
	}
	
	public System.DateTime? SADateOfBirth
	{
		get
		{
			return _saDateOfBirth;
		}
		set
		{
			_saDateOfBirth = value;
		}
	}
	
	public System.String SAPlaceOfBirth
	{
		get
		{
			return _saPlaceOfBirth;
		}
		set
		{
			_saPlaceOfBirth = value;
		}
	}
	
	public System.String SAAcadamicYear
	{
		get
		{
			return _saAcadamicYear;
		}
		set
		{
			_saAcadamicYear = value;
		}
	}
	
	public System.String SABloodGroup
	{
		get
		{
			return _saBloodGroup;
		}
		set
		{
			_saBloodGroup = value;
		}
	}
	
	public System.String SAStudentImage
	{
		get
		{
			return _saStudentImage;
		}
		set
		{
			_saStudentImage = value;
		}
	}
	
	public System.String SANationality
	{
		get
		{
			return _saNationality;
		}
		set
		{
			_saNationality = value;
		}
	}
	
	public System.String SAGender
	{
		get
		{
			return _saGender;
		}
		set
		{
			_saGender = value;
		}
	}
	
	public System.String SACaste
	{
		get
		{
			return _saCaste;
		}
		set
		{
			_saCaste = value;
		}
	}
	
	public System.String SASubCaste
	{
		get
		{
			return _saSubCaste;
		}
		set
		{
			_saSubCaste = value;
		}
	}
	
	public System.DateTime? SADateOfApplication
	{
		get
		{
			return _saDateOfApplication;
		}
		set
		{
			_saDateOfApplication = value;
		}
	}
	
	public System.String SAMotherTongue
	{
		get
		{
			return _saMotherTongue;
		}
		set
		{
			_saMotherTongue = value;
		}
	}
	
	public System.Int64? SASchoolCategoryId
	{
		get
		{
			return _saSchoolCategoryId;
		}
		set
		{
			_saSchoolCategoryId = value;
		}
	}
	
	public System.String SATransportStatus
	{
		get
		{
			return _saTransportStatus;
		}
		set
		{
			_saTransportStatus = value;
		}
	}
	
	public System.String SAMedicalProblem
	{
		get
		{
			return _saMedicalProblem;
		}
		set
		{
			_saMedicalProblem = value;
		}
	}
	
	public System.String SALastSchoolAttended
	{
		get
		{
			return _saLastSchoolAttended;
		}
		set
		{
			_saLastSchoolAttended = value;
		}
	}
	
	public System.String SALastClassAttended
	{
		get
		{
			return _saLastClassAttended;
		}
		set
		{
			_saLastClassAttended = value;
		}
	}
	
	public System.String SALastClassPer
	{
		get
		{
			return _saLastClassPer;
		}
		set
		{
			_saLastClassPer = value;
		}
	}
	
	public System.String SAFatherFullName
	{
		get
		{
			return _saFatherFullName;
		}
		set
		{
			_saFatherFullName = value;
		}
	}
	
	public System.String SAFatherPhoto
	{
		get
		{
			return _saFatherPhoto;
		}
		set
		{
			_saFatherPhoto = value;
		}
	}
	
	public System.String SAFatherEduQualification
	{
		get
		{
			return _saFatherEduQualification;
		}
		set
		{
			_saFatherEduQualification = value;
		}
	}
	
	public System.String SAFatherOccupation
	{
		get
		{
			return _saFatherOccupation;
		}
		set
		{
			_saFatherOccupation = value;
		}
	}
	
	public System.Int64? SAFatherAddressId
	{
		get
		{
			return _saFatherAddressId;
		}
		set
		{
			_saFatherAddressId = value;
		}
	}
	
	public System.String SAFatherOrgName
	{
		get
		{
			return _saFatherOrgName;
		}
		set
		{
			_saFatherOrgName = value;
		}
	}
	
	public System.String SAFatherDsgtName
	{
		get
		{
			return _saFatherDsgtName;
		}
		set
		{
			_saFatherDsgtName = value;
		}
	}
	
	public System.String SAMotherFullName
	{
		get
		{
			return _saMotherFullName;
		}
		set
		{
			_saMotherFullName = value;
		}
	}
	
	public System.String SAMotherPhoto
	{
		get
		{
			return _saMotherPhoto;
		}
		set
		{
			_saMotherPhoto = value;
		}
	}
	
	public System.String SAMotherEduQualification
	{
		get
		{
			return _saMotherEduQualification;
		}
		set
		{
			_saMotherEduQualification = value;
		}
	}
	
	public System.String SAMotherOccupation
	{
		get
		{
			return _saMotherOccupation;
		}
		set
		{
			_saMotherOccupation = value;
		}
	}
	
	public System.Int64? SAMotherAddressId
	{
		get
		{
			return _saMotherAddressId;
		}
		set
		{
			_saMotherAddressId = value;
		}
	}
	
	public System.String SAMotherOrgName
	{
		get
		{
			return _saMotherOrgName;
		}
		set
		{
			_saMotherOrgName = value;
		}
	}
	
	public System.String SAMotherDsgtName
	{
		get
		{
			return _saMotherDsgtName;
		}
		set
		{
			_saMotherDsgtName = value;
		}
	}
	
	public System.Int64? SAAddressId
	{
		get
		{
			return _saAddressId;
		}
		set
		{
			_saAddressId = value;
		}
	}
	
	public System.String SAAgeProof
	{
		get
		{
			return _saAgeProof;
		}
		set
		{
			_saAgeProof = value;
		}
	}
	
	public System.String SALastProgressReportCard
	{
		get
		{
			return _saLastProgressReportCard;
		}
		set
		{
			_saLastProgressReportCard = value;
		}
	}
	
	public System.String SAOriginalSchoolLC
	{
		get
		{
			return _saOriginalSchoolLC;
		}
		set
		{
			_saOriginalSchoolLC = value;
		}
	}
	
	public System.String SAPassportAndVisa
	{
		get
		{
			return _saPassportAndVisa;
		}
		set
		{
			_saPassportAndVisa = value;
		}
	}
	
	public System.String SARegistrationLetter
	{
		get
		{
			return _saRegistrationLetter;
		}
		set
		{
			_saRegistrationLetter = value;
		}
	}
	
	public System.String SAApplicationStatus
	{
		get
		{
			return _saApplicationStatus;
		}
		set
		{
			_saApplicationStatus = value;
		}
	}
	
	public System.Int32? SAStatus
	{
		get
		{
			return _saStatus;
		}
		set
		{
			_saStatus = value;
		}
	}
	
	public System.String SAFormNo
	{
		get
		{
			return _saFormNo;
		}
		set
		{
			_saFormNo = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SA_ApplicationId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_StudentPNRId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_FirstName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_MiddleName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_LastName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_DateOfBirth", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_PlaceOfBirth", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_AcadamicYear", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_BloodGroup", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_StudentImage", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_Nationality", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_Gender", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_Caste", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_SubCaste", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_DateOfApplication", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_MotherTounge", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_SchoolCategoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_TransportStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_MedicalProblem", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_LastSchoolAttended", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_LastClassAttended", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_LastClassPer", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_FatherFullName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_FatherPhoto", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_FatherEduQualification", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_FatherOccupation", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_FatherAddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_FatherOrgName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_FatherDsgtName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_MotherFullName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_MotherPhoto", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_MotherEduQualification", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_MotherOccupation", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_MotherAddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_MotherOrgName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_MotherDsgtName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_AddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_AgeProof", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_LastProgressReportCard", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_OriginalSchoolLC", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_PassportAndVisa", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_RegistrationLetter", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_ApplicationStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_Status", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_FormNo", typeof(System.String) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SAApplicationId == null)
		dr["SA_ApplicationId"] = DBNull.Value;
		else
		dr["SA_ApplicationId"] = SAApplicationId;
		
		if (SAStudentPNRId == null)
		dr["SA_StudentPNRId"] = DBNull.Value;
		else
		dr["SA_StudentPNRId"] = SAStudentPNRId;
		
		if (SAFirstName == null)
		dr["SA_FirstName"] = DBNull.Value;
		else
		dr["SA_FirstName"] = SAFirstName;
		
		if (SAMiddleName == null)
		dr["SA_MiddleName"] = DBNull.Value;
		else
		dr["SA_MiddleName"] = SAMiddleName;
		
		if (SALastName == null)
		dr["SA_LastName"] = DBNull.Value;
		else
		dr["SA_LastName"] = SALastName;
		
		if (SADateOfBirth == null)
		dr["SA_DateOfBirth"] = DBNull.Value;
		else
		dr["SA_DateOfBirth"] = SADateOfBirth;
		
		if (SAPlaceOfBirth == null)
		dr["SA_PlaceOfBirth"] = DBNull.Value;
		else
		dr["SA_PlaceOfBirth"] = SAPlaceOfBirth;
		
		if (SAAcadamicYear == null)
		dr["SA_AcadamicYear"] = DBNull.Value;
		else
		dr["SA_AcadamicYear"] = SAAcadamicYear;
		
		if (SABloodGroup == null)
		dr["SA_BloodGroup"] = DBNull.Value;
		else
		dr["SA_BloodGroup"] = SABloodGroup;
		
		if (SAStudentImage == null)
		dr["SA_StudentImage"] = DBNull.Value;
		else
		dr["SA_StudentImage"] = SAStudentImage;
		
		if (SANationality == null)
		dr["SA_Nationality"] = DBNull.Value;
		else
		dr["SA_Nationality"] = SANationality;
		
		if (SAGender == null)
		dr["SA_Gender"] = DBNull.Value;
		else
		dr["SA_Gender"] = SAGender;
		
		if (SACaste == null)
		dr["SA_Caste"] = DBNull.Value;
		else
		dr["SA_Caste"] = SACaste;
		
		if (SASubCaste == null)
		dr["SA_SubCaste"] = DBNull.Value;
		else
		dr["SA_SubCaste"] = SASubCaste;
		
		if (SADateOfApplication == null)
		dr["SA_DateOfApplication"] = DBNull.Value;
		else
		dr["SA_DateOfApplication"] = SADateOfApplication;
		
		if (SAMotherTongue == null)
		dr["SA_MotherTounge"] = DBNull.Value;
		else
		dr["SA_MotherTounge"] = SAMotherTongue;
		
		if (SASchoolCategoryId == null)
		dr["SA_SchoolCategoryId"] = DBNull.Value;
		else
		dr["SA_SchoolCategoryId"] = SASchoolCategoryId;
		
		if (SATransportStatus == null)
		dr["SA_TransportStatus"] = DBNull.Value;
		else
		dr["SA_TransportStatus"] = SATransportStatus;
		
		if (SAMedicalProblem == null)
		dr["SA_MedicalProblem"] = DBNull.Value;
		else
		dr["SA_MedicalProblem"] = SAMedicalProblem;
		
		if (SALastSchoolAttended == null)
		dr["SA_LastSchoolAttended"] = DBNull.Value;
		else
		dr["SA_LastSchoolAttended"] = SALastSchoolAttended;
		
		if (SALastClassAttended == null)
		dr["SA_LastClassAttended"] = DBNull.Value;
		else
		dr["SA_LastClassAttended"] = SALastClassAttended;
		
		if (SALastClassPer == null)
		dr["SA_LastClassPer"] = DBNull.Value;
		else
		dr["SA_LastClassPer"] = SALastClassPer;
		
		if (SAFatherFullName == null)
		dr["SA_FatherFullName"] = DBNull.Value;
		else
		dr["SA_FatherFullName"] = SAFatherFullName;
		
		if (SAFatherPhoto == null)
		dr["SA_FatherPhoto"] = DBNull.Value;
		else
		dr["SA_FatherPhoto"] = SAFatherPhoto;
		
		if (SAFatherEduQualification == null)
		dr["SA_FatherEduQualification"] = DBNull.Value;
		else
		dr["SA_FatherEduQualification"] = SAFatherEduQualification;
		
		if (SAFatherOccupation == null)
		dr["SA_FatherOccupation"] = DBNull.Value;
		else
		dr["SA_FatherOccupation"] = SAFatherOccupation;
		
		if (SAFatherAddressId == null)
		dr["SA_FatherAddressId"] = DBNull.Value;
		else
		dr["SA_FatherAddressId"] = SAFatherAddressId;
		
		if (SAFatherOrgName == null)
		dr["SA_FatherOrgName"] = DBNull.Value;
		else
		dr["SA_FatherOrgName"] = SAFatherOrgName;
		
		if (SAFatherDsgtName == null)
		dr["SA_FatherDsgtName"] = DBNull.Value;
		else
		dr["SA_FatherDsgtName"] = SAFatherDsgtName;
		
		if (SAMotherFullName == null)
		dr["SA_MotherFullName"] = DBNull.Value;
		else
		dr["SA_MotherFullName"] = SAMotherFullName;
		
		if (SAMotherPhoto == null)
		dr["SA_MotherPhoto"] = DBNull.Value;
		else
		dr["SA_MotherPhoto"] = SAMotherPhoto;
		
		if (SAMotherEduQualification == null)
		dr["SA_MotherEduQualification"] = DBNull.Value;
		else
		dr["SA_MotherEduQualification"] = SAMotherEduQualification;
		
		if (SAMotherOccupation == null)
		dr["SA_MotherOccupation"] = DBNull.Value;
		else
		dr["SA_MotherOccupation"] = SAMotherOccupation;
		
		if (SAMotherAddressId == null)
		dr["SA_MotherAddressId"] = DBNull.Value;
		else
		dr["SA_MotherAddressId"] = SAMotherAddressId;
		
		if (SAMotherOrgName == null)
		dr["SA_MotherOrgName"] = DBNull.Value;
		else
		dr["SA_MotherOrgName"] = SAMotherOrgName;
		
		if (SAMotherDsgtName == null)
		dr["SA_MotherDsgtName"] = DBNull.Value;
		else
		dr["SA_MotherDsgtName"] = SAMotherDsgtName;
		
		if (SAAddressId == null)
		dr["SA_AddressId"] = DBNull.Value;
		else
		dr["SA_AddressId"] = SAAddressId;
		
		if (SAAgeProof == null)
		dr["SA_AgeProof"] = DBNull.Value;
		else
		dr["SA_AgeProof"] = SAAgeProof;
		
		if (SALastProgressReportCard == null)
		dr["SA_LastProgressReportCard"] = DBNull.Value;
		else
		dr["SA_LastProgressReportCard"] = SALastProgressReportCard;
		
		if (SAOriginalSchoolLC == null)
		dr["SA_OriginalSchoolLC"] = DBNull.Value;
		else
		dr["SA_OriginalSchoolLC"] = SAOriginalSchoolLC;
		
		if (SAPassportAndVisa == null)
		dr["SA_PassportAndVisa"] = DBNull.Value;
		else
		dr["SA_PassportAndVisa"] = SAPassportAndVisa;
		
		if (SARegistrationLetter == null)
		dr["SA_RegistrationLetter"] = DBNull.Value;
		else
		dr["SA_RegistrationLetter"] = SARegistrationLetter;
		
		if (SAApplicationStatus == null)
		dr["SA_ApplicationStatus"] = DBNull.Value;
		else
		dr["SA_ApplicationStatus"] = SAApplicationStatus;
		
		if (SAStatus == null)
		dr["SA_Status"] = DBNull.Value;
		else
		dr["SA_Status"] = SAStatus;
		
		if (SAFormNo == null)
		dr["SA_FormNo"] = DBNull.Value;
		else
		dr["SA_FormNo"] = SAFormNo;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SAApplicationId = dr["SA_ApplicationId"] != DBNull.Value ? Convert.ToInt64(dr["SA_ApplicationId"]) : SAApplicationId = null;
		SAStudentPNRId = dr["SA_StudentPNRId"] != DBNull.Value ? Convert.ToString(dr["SA_StudentPNRId"]) : SAStudentPNRId = null;
		SAFirstName = dr["SA_FirstName"] != DBNull.Value ? Convert.ToString(dr["SA_FirstName"]) : SAFirstName = null;
		SAMiddleName = dr["SA_MiddleName"] != DBNull.Value ? Convert.ToString(dr["SA_MiddleName"]) : SAMiddleName = null;
		SALastName = dr["SA_LastName"] != DBNull.Value ? Convert.ToString(dr["SA_LastName"]) : SALastName = null;
		SADateOfBirth = dr["SA_DateOfBirth"] != DBNull.Value ? Convert.ToDateTime(dr["SA_DateOfBirth"]) : SADateOfBirth = null;
		SAPlaceOfBirth = dr["SA_PlaceOfBirth"] != DBNull.Value ? Convert.ToString(dr["SA_PlaceOfBirth"]) : SAPlaceOfBirth = null;
		SAAcadamicYear = dr["SA_AcadamicYear"] != DBNull.Value ? Convert.ToString(dr["SA_AcadamicYear"]) : SAAcadamicYear = null;
		SABloodGroup = dr["SA_BloodGroup"] != DBNull.Value ? Convert.ToString(dr["SA_BloodGroup"]) : SABloodGroup = null;
		SAStudentImage = dr["SA_StudentImage"] != DBNull.Value ? Convert.ToString(dr["SA_StudentImage"]) : SAStudentImage = null;
		SANationality = dr["SA_Nationality"] != DBNull.Value ? Convert.ToString(dr["SA_Nationality"]) : SANationality = null;
		SAGender = dr["SA_Gender"] != DBNull.Value ? Convert.ToString(dr["SA_Gender"]) : SAGender = null;
		SACaste = dr["SA_Caste"] != DBNull.Value ? Convert.ToString(dr["SA_Caste"]) : SACaste = null;
		SASubCaste = dr["SA_SubCaste"] != DBNull.Value ? Convert.ToString(dr["SA_SubCaste"]) : SASubCaste = null;
		SADateOfApplication = dr["SA_DateOfApplication"] != DBNull.Value ? Convert.ToDateTime(dr["SA_DateOfApplication"]) : SADateOfApplication = null;
		SAMotherTongue = dr["SA_MotherTounge"] != DBNull.Value ? Convert.ToString(dr["SA_MotherTounge"]) : SAMotherTongue = null;
		SASchoolCategoryId = dr["SA_SchoolCategoryId"] != DBNull.Value ? Convert.ToInt64(dr["SA_SchoolCategoryId"]) : SASchoolCategoryId = null;
		SATransportStatus = dr["SA_TransportStatus"] != DBNull.Value ? Convert.ToString(dr["SA_TransportStatus"]) : SATransportStatus = null;
		SAMedicalProblem = dr["SA_MedicalProblem"] != DBNull.Value ? Convert.ToString(dr["SA_MedicalProblem"]) : SAMedicalProblem = null;
		SALastSchoolAttended = dr["SA_LastSchoolAttended"] != DBNull.Value ? Convert.ToString(dr["SA_LastSchoolAttended"]) : SALastSchoolAttended = null;
		SALastClassAttended = dr["SA_LastClassAttended"] != DBNull.Value ? Convert.ToString(dr["SA_LastClassAttended"]) : SALastClassAttended = null;
		SALastClassPer = dr["SA_LastClassPer"] != DBNull.Value ? Convert.ToString(dr["SA_LastClassPer"]) : SALastClassPer = null;
		SAFatherFullName = dr["SA_FatherFullName"] != DBNull.Value ? Convert.ToString(dr["SA_FatherFullName"]) : SAFatherFullName = null;
		SAFatherPhoto = dr["SA_FatherPhoto"] != DBNull.Value ? Convert.ToString(dr["SA_FatherPhoto"]) : SAFatherPhoto = null;
		SAFatherEduQualification = dr["SA_FatherEduQualification"] != DBNull.Value ? Convert.ToString(dr["SA_FatherEduQualification"]) : SAFatherEduQualification = null;
		SAFatherOccupation = dr["SA_FatherOccupation"] != DBNull.Value ? Convert.ToString(dr["SA_FatherOccupation"]) : SAFatherOccupation = null;
		SAFatherAddressId = dr["SA_FatherAddressId"] != DBNull.Value ? Convert.ToInt64(dr["SA_FatherAddressId"]) : SAFatherAddressId = null;
		SAFatherOrgName = dr["SA_FatherOrgName"] != DBNull.Value ? Convert.ToString(dr["SA_FatherOrgName"]) : SAFatherOrgName = null;
		SAFatherDsgtName = dr["SA_FatherDsgtName"] != DBNull.Value ? Convert.ToString(dr["SA_FatherDsgtName"]) : SAFatherDsgtName = null;
		SAMotherFullName = dr["SA_MotherFullName"] != DBNull.Value ? Convert.ToString(dr["SA_MotherFullName"]) : SAMotherFullName = null;
		SAMotherPhoto = dr["SA_MotherPhoto"] != DBNull.Value ? Convert.ToString(dr["SA_MotherPhoto"]) : SAMotherPhoto = null;
		SAMotherEduQualification = dr["SA_MotherEduQualification"] != DBNull.Value ? Convert.ToString(dr["SA_MotherEduQualification"]) : SAMotherEduQualification = null;
		SAMotherOccupation = dr["SA_MotherOccupation"] != DBNull.Value ? Convert.ToString(dr["SA_MotherOccupation"]) : SAMotherOccupation = null;
		SAMotherAddressId = dr["SA_MotherAddressId"] != DBNull.Value ? Convert.ToInt64(dr["SA_MotherAddressId"]) : SAMotherAddressId = null;
		SAMotherOrgName = dr["SA_MotherOrgName"] != DBNull.Value ? Convert.ToString(dr["SA_MotherOrgName"]) : SAMotherOrgName = null;
		SAMotherDsgtName = dr["SA_MotherDsgtName"] != DBNull.Value ? Convert.ToString(dr["SA_MotherDsgtName"]) : SAMotherDsgtName = null;
		SAAddressId = dr["SA_AddressId"] != DBNull.Value ? Convert.ToInt64(dr["SA_AddressId"]) : SAAddressId = null;
		SAAgeProof = dr["SA_AgeProof"] != DBNull.Value ? Convert.ToString(dr["SA_AgeProof"]) : SAAgeProof = null;
		SALastProgressReportCard = dr["SA_LastProgressReportCard"] != DBNull.Value ? Convert.ToString(dr["SA_LastProgressReportCard"]) : SALastProgressReportCard = null;
		SAOriginalSchoolLC = dr["SA_OriginalSchoolLC"] != DBNull.Value ? Convert.ToString(dr["SA_OriginalSchoolLC"]) : SAOriginalSchoolLC = null;
		SAPassportAndVisa = dr["SA_PassportAndVisa"] != DBNull.Value ? Convert.ToString(dr["SA_PassportAndVisa"]) : SAPassportAndVisa = null;
		SARegistrationLetter = dr["SA_RegistrationLetter"] != DBNull.Value ? Convert.ToString(dr["SA_RegistrationLetter"]) : SARegistrationLetter = null;
		SAApplicationStatus = dr["SA_ApplicationStatus"] != DBNull.Value ? Convert.ToString(dr["SA_ApplicationStatus"]) : SAApplicationStatus = null;
		SAStatus = dr["SA_Status"] != DBNull.Value ? Convert.ToInt32(dr["SA_Status"]) : SAStatus = null;
		SAFormNo = dr["SA_FormNo"] != DBNull.Value ? Convert.ToString(dr["SA_FormNo"]) : SAFormNo = null;
	}
	
	public static TMSStudentApplication[] MapFrom(DataSet ds)
	{
		List<TMSStudentApplication> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSStudentApplication>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_StudentApplication] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_StudentApplication] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSStudentApplication instance = new TMSStudentApplication();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSStudentApplication Get(System.Int64 saApplicationId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSStudentApplication instance;
		
		
		instance = new TMSStudentApplication();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSStudentApplication_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, saApplicationId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSStudentApplication ID:" + saApplicationId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String saStudentPNRId, System.String saFirstName, System.String saMiddleName, System.String saLastName, System.DateTime? saDateOfBirth, System.String saPlaceOfBirth, System.String saAcadamicYear, System.String saBloodGroup, System.String saStudentImage, System.String saNationality, System.String saGender, System.String saCaste, System.String saSubCaste, System.DateTime? saDateOfApplication, System.String saMotherTongue, System.Int64? saSchoolCategoryId, System.String saTransportStatus, System.String saMedicalProblem, System.String saLastSchoolAttended, System.String saLastClassAttended, System.String saLastClassPer, System.String saFatherFullName, System.String saFatherPhoto, System.String saFatherEduQualification, System.String saFatherOccupation, System.Int64? saFatherAddressId, System.String saFatherOrgName, System.String saFatherDsgtName, System.String saMotherFullName, System.String saMotherPhoto, System.String saMotherEduQualification, System.String saMotherOccupation, System.Int64? saMotherAddressId, System.String saMotherOrgName, System.String saMotherDsgtName, System.Int64? saAddressId, System.String saAgeProof, System.String saLastProgressReportCard, System.String saOriginalSchoolLC, System.String saPassportAndVisa, System.String saRegistrationLetter, System.String saApplicationStatus, System.Int32? saStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSStudentApplication_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, saStudentPNRId, saFirstName, saMiddleName, saLastName, saDateOfBirth, saPlaceOfBirth, saAcadamicYear, saBloodGroup, saStudentImage, saNationality, saGender, saCaste, saSubCaste, saDateOfApplication, saMotherTongue, saSchoolCategoryId, saTransportStatus, saMedicalProblem, saLastSchoolAttended, saLastClassAttended, saLastClassPer, saFatherFullName, saFatherPhoto, saFatherEduQualification, saFatherOccupation, saFatherAddressId, saFatherOrgName, saFatherDsgtName, saMotherFullName, saMotherPhoto, saMotherEduQualification, saMotherOccupation, saMotherAddressId, saMotherOrgName, saMotherDsgtName, saAddressId, saAgeProof, saLastProgressReportCard, saOriginalSchoolLC, saPassportAndVisa, saRegistrationLetter, saApplicationStatus, saStatus);
		
		if (transaction == null)
		this.SAApplicationId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SAApplicationId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String saStudentPNRId, System.String saFirstName, System.String saMiddleName, System.String saLastName, System.DateTime? saDateOfBirth, System.String saPlaceOfBirth, System.String saAcadamicYear, System.String saBloodGroup, System.String saStudentImage, System.String saNationality, System.String saGender, System.String saCaste, System.String saSubCaste, System.DateTime? saDateOfApplication, System.String saMotherTongue, System.Int64? saSchoolCategoryId, System.String saTransportStatus, System.String saMedicalProblem, System.String saLastSchoolAttended, System.String saLastClassAttended, System.String saLastClassPer, System.String saFatherFullName, System.String saFatherPhoto, System.String saFatherEduQualification, System.String saFatherOccupation, System.Int64? saFatherAddressId, System.String saFatherOrgName, System.String saFatherDsgtName, System.String saMotherFullName, System.String saMotherPhoto, System.String saMotherEduQualification, System.String saMotherOccupation, System.Int64? saMotherAddressId, System.String saMotherOrgName, System.String saMotherDsgtName, System.Int64? saAddressId, System.String saAgeProof, System.String saLastProgressReportCard, System.String saOriginalSchoolLC, System.String saPassportAndVisa, System.String saRegistrationLetter, System.String saApplicationStatus, System.Int32? saStatus)
	{
		Insert(saStudentPNRId, saFirstName, saMiddleName, saLastName, saDateOfBirth, saPlaceOfBirth, saAcadamicYear, saBloodGroup, saStudentImage, saNationality, saGender, saCaste, saSubCaste, saDateOfApplication, saMotherTongue, saSchoolCategoryId, saTransportStatus, saMedicalProblem, saLastSchoolAttended, saLastClassAttended, saLastClassPer, saFatherFullName, saFatherPhoto, saFatherEduQualification, saFatherOccupation, saFatherAddressId, saFatherOrgName, saFatherDsgtName, saMotherFullName, saMotherPhoto, saMotherEduQualification, saMotherOccupation, saMotherAddressId, saMotherOrgName, saMotherDsgtName, saAddressId, saAgeProof, saLastProgressReportCard, saOriginalSchoolLC, saPassportAndVisa, saRegistrationLetter, saApplicationStatus, saStatus, null);
	}
	/// <summary>
	/// Insert current TMSStudentApplication to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SAStudentPNRId, SAFirstName, SAMiddleName, SALastName, SADateOfBirth, SAPlaceOfBirth, SAAcadamicYear, SABloodGroup, SAStudentImage, SANationality, SAGender, SACaste, SASubCaste, SADateOfApplication, SAMotherTongue, SASchoolCategoryId, SATransportStatus, SAMedicalProblem, SALastSchoolAttended, SALastClassAttended, SALastClassPer, SAFatherFullName, SAFatherPhoto, SAFatherEduQualification, SAFatherOccupation, SAFatherAddressId, SAFatherOrgName, SAFatherDsgtName, SAMotherFullName, SAMotherPhoto, SAMotherEduQualification, SAMotherOccupation, SAMotherAddressId, SAMotherOrgName, SAMotherDsgtName, SAAddressId, SAAgeProof, SALastProgressReportCard, SAOriginalSchoolLC, SAPassportAndVisa, SARegistrationLetter, SAApplicationStatus, SAStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSStudentApplication to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? saApplicationId, System.String saStudentPNRId, System.String saFirstName, System.String saMiddleName, System.String saLastName, System.DateTime? saDateOfBirth, System.String saPlaceOfBirth, System.String saAcadamicYear, System.String saBloodGroup, System.String saStudentImage, System.String saNationality, System.String saGender, System.String saCaste, System.String saSubCaste, System.DateTime? saDateOfApplication, System.String saMotherTongue, System.Int64? saSchoolCategoryId, System.String saTransportStatus, System.String saMedicalProblem, System.String saLastSchoolAttended, System.String saLastClassAttended, System.String saLastClassPer, System.String saFatherFullName, System.String saFatherPhoto, System.String saFatherEduQualification, System.String saFatherOccupation, System.Int64? saFatherAddressId, System.String saFatherOrgName, System.String saFatherDsgtName, System.String saMotherFullName, System.String saMotherPhoto, System.String saMotherEduQualification, System.String saMotherOccupation, System.Int64? saMotherAddressId, System.String saMotherOrgName, System.String saMotherDsgtName, System.Int64? saAddressId, System.String saAgeProof, System.String saLastProgressReportCard, System.String saOriginalSchoolLC, System.String saPassportAndVisa, System.String saRegistrationLetter, System.String saApplicationStatus, System.Int32? saStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSStudentApplication_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@saApplicationId"].Value = saApplicationId;
		dbCommand.Parameters["@saStudentPNRId"].Value = saStudentPNRId;
		dbCommand.Parameters["@saFirstName"].Value = saFirstName;
		dbCommand.Parameters["@saMiddleName"].Value = saMiddleName;
		dbCommand.Parameters["@saLastName"].Value = saLastName;
		dbCommand.Parameters["@saDateOfBirth"].Value = saDateOfBirth;
		dbCommand.Parameters["@saPlaceOfBirth"].Value = saPlaceOfBirth;
		dbCommand.Parameters["@saAcadamicYear"].Value = saAcadamicYear;
		dbCommand.Parameters["@saBloodGroup"].Value = saBloodGroup;
		dbCommand.Parameters["@saStudentImage"].Value = saStudentImage;
		dbCommand.Parameters["@saNationality"].Value = saNationality;
		dbCommand.Parameters["@saGender"].Value = saGender;
		dbCommand.Parameters["@saCaste"].Value = saCaste;
		dbCommand.Parameters["@saSubCaste"].Value = saSubCaste;
		dbCommand.Parameters["@saDateOfApplication"].Value = saDateOfApplication;
		dbCommand.Parameters["@saMotherTounge"].Value = saMotherTongue;
		dbCommand.Parameters["@saSchoolCategoryId"].Value = saSchoolCategoryId;
		dbCommand.Parameters["@saTransportStatus"].Value = saTransportStatus;
		dbCommand.Parameters["@saMedicalProblem"].Value = saMedicalProblem;
		dbCommand.Parameters["@saLastSchoolAttended"].Value = saLastSchoolAttended;
		dbCommand.Parameters["@saLastClassAttended"].Value = saLastClassAttended;
		dbCommand.Parameters["@saLastClassPer"].Value = saLastClassPer;
		dbCommand.Parameters["@saFatherFullName"].Value = saFatherFullName;
		dbCommand.Parameters["@saFatherPhoto"].Value = saFatherPhoto;
		dbCommand.Parameters["@saFatherEduQualification"].Value = saFatherEduQualification;
		dbCommand.Parameters["@saFatherOccupation"].Value = saFatherOccupation;
		dbCommand.Parameters["@saFatherAddressId"].Value = saFatherAddressId;
		dbCommand.Parameters["@saFatherOrgName"].Value = saFatherOrgName;
		dbCommand.Parameters["@saFatherDsgtName"].Value = saFatherDsgtName;
		dbCommand.Parameters["@saMotherFullName"].Value = saMotherFullName;
		dbCommand.Parameters["@saMotherPhoto"].Value = saMotherPhoto;
		dbCommand.Parameters["@saMotherEduQualification"].Value = saMotherEduQualification;
		dbCommand.Parameters["@saMotherOccupation"].Value = saMotherOccupation;
		dbCommand.Parameters["@saMotherAddressId"].Value = saMotherAddressId;
		dbCommand.Parameters["@saMotherOrgName"].Value = saMotherOrgName;
		dbCommand.Parameters["@saMotherDsgtName"].Value = saMotherDsgtName;
		dbCommand.Parameters["@saAddressId"].Value = saAddressId;
		dbCommand.Parameters["@saAgeProof"].Value = saAgeProof;
		dbCommand.Parameters["@saLastProgressReportCard"].Value = saLastProgressReportCard;
		dbCommand.Parameters["@saOriginalSchoolLC"].Value = saOriginalSchoolLC;
		dbCommand.Parameters["@saPassportAndVisa"].Value = saPassportAndVisa;
		dbCommand.Parameters["@saRegistrationLetter"].Value = saRegistrationLetter;
		dbCommand.Parameters["@saApplicationStatus"].Value = saApplicationStatus;
		dbCommand.Parameters["@saStatus"].Value = saStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? saApplicationId, System.String saStudentPNRId, System.String saFirstName, System.String saMiddleName, System.String saLastName, System.DateTime? saDateOfBirth, System.String saPlaceOfBirth, System.String saAcadamicYear, System.String saBloodGroup, System.String saStudentImage, System.String saNationality, System.String saGender, System.String saCaste, System.String saSubCaste, System.DateTime? saDateOfApplication, System.String saMotherTongue, System.Int64? saSchoolCategoryId, System.String saTransportStatus, System.String saMedicalProblem, System.String saLastSchoolAttended, System.String saLastClassAttended, System.String saLastClassPer, System.String saFatherFullName, System.String saFatherPhoto, System.String saFatherEduQualification, System.String saFatherOccupation, System.Int64? saFatherAddressId, System.String saFatherOrgName, System.String saFatherDsgtName, System.String saMotherFullName, System.String saMotherPhoto, System.String saMotherEduQualification, System.String saMotherOccupation, System.Int64? saMotherAddressId, System.String saMotherOrgName, System.String saMotherDsgtName, System.Int64? saAddressId, System.String saAgeProof, System.String saLastProgressReportCard, System.String saOriginalSchoolLC, System.String saPassportAndVisa, System.String saRegistrationLetter, System.String saApplicationStatus, System.Int32? saStatus)
	{
		Update(saApplicationId, saStudentPNRId, saFirstName, saMiddleName, saLastName, saDateOfBirth, saPlaceOfBirth, saAcadamicYear, saBloodGroup, saStudentImage, saNationality, saGender, saCaste, saSubCaste, saDateOfApplication, saMotherTongue, saSchoolCategoryId, saTransportStatus, saMedicalProblem, saLastSchoolAttended, saLastClassAttended, saLastClassPer, saFatherFullName, saFatherPhoto, saFatherEduQualification, saFatherOccupation, saFatherAddressId, saFatherOrgName, saFatherDsgtName, saMotherFullName, saMotherPhoto, saMotherEduQualification, saMotherOccupation, saMotherAddressId, saMotherOrgName, saMotherDsgtName, saAddressId, saAgeProof, saLastProgressReportCard, saOriginalSchoolLC, saPassportAndVisa, saRegistrationLetter, saApplicationStatus, saStatus, null);
	}
	
	public static void Update(TMSStudentApplication tMSStudentApplication)
	{
		tMSStudentApplication.Update();
	}
	
	public static void Update(TMSStudentApplication tMSStudentApplication, DbTransaction transaction)
	{
		tMSStudentApplication.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSStudentApplication_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@saApplicationId"].SourceColumn = "SA_ApplicationId";
		dbCommand.Parameters["@saStudentPNRId"].SourceColumn = "SA_StudentPNRId";
		dbCommand.Parameters["@saFirstName"].SourceColumn = "SA_FirstName";
		dbCommand.Parameters["@saMiddleName"].SourceColumn = "SA_MiddleName";
		dbCommand.Parameters["@saLastName"].SourceColumn = "SA_LastName";
		dbCommand.Parameters["@saDateOfBirth"].SourceColumn = "SA_DateOfBirth";
		dbCommand.Parameters["@saPlaceOfBirth"].SourceColumn = "SA_PlaceOfBirth";
		dbCommand.Parameters["@saAcadamicYear"].SourceColumn = "SA_AcadamicYear";
		dbCommand.Parameters["@saBloodGroup"].SourceColumn = "SA_BloodGroup";
		dbCommand.Parameters["@saStudentImage"].SourceColumn = "SA_StudentImage";
		dbCommand.Parameters["@saNationality"].SourceColumn = "SA_Nationality";
		dbCommand.Parameters["@saGender"].SourceColumn = "SA_Gender";
		dbCommand.Parameters["@saCaste"].SourceColumn = "SA_Caste";
		dbCommand.Parameters["@saSubCaste"].SourceColumn = "SA_SubCaste";
		dbCommand.Parameters["@saDateOfApplication"].SourceColumn = "SA_DateOfApplication";
		dbCommand.Parameters["@saMotherTounge"].SourceColumn = "SA_MotherTounge";
		dbCommand.Parameters["@saSchoolCategoryId"].SourceColumn = "SA_SchoolCategoryId";
		dbCommand.Parameters["@saTransportStatus"].SourceColumn = "SA_TransportStatus";
		dbCommand.Parameters["@saMedicalProblem"].SourceColumn = "SA_MedicalProblem";
		dbCommand.Parameters["@saLastSchoolAttended"].SourceColumn = "SA_LastSchoolAttended";
		dbCommand.Parameters["@saLastClassAttended"].SourceColumn = "SA_LastClassAttended";
		dbCommand.Parameters["@saLastClassPer"].SourceColumn = "SA_LastClassPer";
		dbCommand.Parameters["@saFatherFullName"].SourceColumn = "SA_FatherFullName";
		dbCommand.Parameters["@saFatherPhoto"].SourceColumn = "SA_FatherPhoto";
		dbCommand.Parameters["@saFatherEduQualification"].SourceColumn = "SA_FatherEduQualification";
		dbCommand.Parameters["@saFatherOccupation"].SourceColumn = "SA_FatherOccupation";
		dbCommand.Parameters["@saFatherAddressId"].SourceColumn = "SA_FatherAddressId";
		dbCommand.Parameters["@saFatherOrgName"].SourceColumn = "SA_FatherOrgName";
		dbCommand.Parameters["@saFatherDsgtName"].SourceColumn = "SA_FatherDsgtName";
		dbCommand.Parameters["@saMotherFullName"].SourceColumn = "SA_MotherFullName";
		dbCommand.Parameters["@saMotherPhoto"].SourceColumn = "SA_MotherPhoto";
		dbCommand.Parameters["@saMotherEduQualification"].SourceColumn = "SA_MotherEduQualification";
		dbCommand.Parameters["@saMotherOccupation"].SourceColumn = "SA_MotherOccupation";
		dbCommand.Parameters["@saMotherAddressId"].SourceColumn = "SA_MotherAddressId";
		dbCommand.Parameters["@saMotherOrgName"].SourceColumn = "SA_MotherOrgName";
		dbCommand.Parameters["@saMotherDsgtName"].SourceColumn = "SA_MotherDsgtName";
		dbCommand.Parameters["@saAddressId"].SourceColumn = "SA_AddressId";
		dbCommand.Parameters["@saAgeProof"].SourceColumn = "SA_AgeProof";
		dbCommand.Parameters["@saLastProgressReportCard"].SourceColumn = "SA_LastProgressReportCard";
		dbCommand.Parameters["@saOriginalSchoolLC"].SourceColumn = "SA_OriginalSchoolLC";
		dbCommand.Parameters["@saPassportAndVisa"].SourceColumn = "SA_PassportAndVisa";
		dbCommand.Parameters["@saRegistrationLetter"].SourceColumn = "SA_RegistrationLetter";
		dbCommand.Parameters["@saApplicationStatus"].SourceColumn = "SA_ApplicationStatus";
		dbCommand.Parameters["@saStatus"].SourceColumn = "SA_Status";
		
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
	public static void Delete(System.Int64? saApplicationId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSStudentApplication_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, saApplicationId);
		
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
	public static void Delete(System.Int64? saApplicationId)
	{
		Delete(
		saApplicationId);
	}
	
	/// <summary>
	/// Delete current TMSStudentApplication from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSStudentApplication_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SAApplicationId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SAApplicationId = null;
	}
	
	/// <summary>
	/// Delete current TMSStudentApplication from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSStudentApplication[] Search(System.Int64? saApplicationId, System.String saStudentPNRId, System.String saFirstName, System.String saMiddleName, System.String saLastName, System.DateTime? saDateOfBirth, System.String saPlaceOfBirth, System.String saAcadamicYear, System.String saBloodGroup, System.String saStudentImage, System.String saNationality, System.String saGender, System.String saCaste, System.String saSubCaste, System.DateTime? saDateOfApplication, System.String saMotherTongue, System.Int64? saSchoolCategoryId, System.String saTransportStatus, System.String saMedicalProblem, System.String saLastSchoolAttended, System.String saLastClassAttended, System.String saLastClassPer, System.String saFatherFullName, System.String saFatherPhoto, System.String saFatherEduQualification, System.String saFatherOccupation, System.Int64? saFatherAddressId, System.String saFatherOrgName, System.String saFatherDsgtName, System.String saMotherFullName, System.String saMotherPhoto, System.String saMotherEduQualification, System.String saMotherOccupation, System.Int64? saMotherAddressId, System.String saMotherOrgName, System.String saMotherDsgtName, System.Int64? saAddressId, System.String saAgeProof, System.String saLastProgressReportCard, System.String saOriginalSchoolLC, System.String saPassportAndVisa, System.String saRegistrationLetter, System.String saApplicationStatus, System.Int32? saStatus, System.String saFormNo)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSStudentApplication_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, saApplicationId, saStudentPNRId, saFirstName, saMiddleName, saLastName, saDateOfBirth, saPlaceOfBirth, saAcadamicYear, saBloodGroup, saStudentImage, saNationality, saGender, saCaste, saSubCaste, saDateOfApplication, saMotherTongue, saSchoolCategoryId, saTransportStatus, saMedicalProblem, saLastSchoolAttended, saLastClassAttended, saLastClassPer, saFatherFullName, saFatherPhoto, saFatherEduQualification, saFatherOccupation, saFatherAddressId, saFatherOrgName, saFatherDsgtName, saMotherFullName, saMotherPhoto, saMotherEduQualification, saMotherOccupation, saMotherAddressId, saMotherOrgName, saMotherDsgtName, saAddressId, saAgeProof, saLastProgressReportCard, saOriginalSchoolLC, saPassportAndVisa, saRegistrationLetter, saApplicationStatus, saStatus, saFormNo);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSStudentApplication.MapFrom(ds);
	}
	
	
	public static TMSStudentApplication[] Search(TMSStudentApplication searchObject)
	{
		return Search ( searchObject.SAApplicationId, searchObject.SAStudentPNRId, searchObject.SAFirstName, searchObject.SAMiddleName, searchObject.SALastName, searchObject.SADateOfBirth, searchObject.SAPlaceOfBirth, searchObject.SAAcadamicYear, searchObject.SABloodGroup, searchObject.SAStudentImage, searchObject.SANationality, searchObject.SAGender, searchObject.SACaste, searchObject.SASubCaste, searchObject.SADateOfApplication, searchObject.SAMotherTongue, searchObject.SASchoolCategoryId, searchObject.SATransportStatus, searchObject.SAMedicalProblem, searchObject.SALastSchoolAttended, searchObject.SALastClassAttended, searchObject.SALastClassPer, searchObject.SAFatherFullName, searchObject.SAFatherPhoto, searchObject.SAFatherEduQualification, searchObject.SAFatherOccupation, searchObject.SAFatherAddressId, searchObject.SAFatherOrgName, searchObject.SAFatherDsgtName, searchObject.SAMotherFullName, searchObject.SAMotherPhoto, searchObject.SAMotherEduQualification, searchObject.SAMotherOccupation, searchObject.SAMotherAddressId, searchObject.SAMotherOrgName, searchObject.SAMotherDsgtName, searchObject.SAAddressId, searchObject.SAAgeProof, searchObject.SALastProgressReportCard, searchObject.SAOriginalSchoolLC, searchObject.SAPassportAndVisa, searchObject.SARegistrationLetter, searchObject.SAApplicationStatus, searchObject.SAStatus, searchObject.SAFormNo);
	}
	
	/// <summary>
	/// Returns all TMSStudentApplication objects.
	/// </summary>
	/// <returns>List of all TMSStudentApplication objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSStudentApplication[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

