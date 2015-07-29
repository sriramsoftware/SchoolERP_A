/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/21/2012 11:57:18 AM                                    */
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
public partial class TMSStudentDetails
{


    #region Constants
    private static readonly string TABLE_NAME = "[dbo].[TMS_StudentDetails]";

    #endregion


    #region Fields
    private System.Int64? _sdStudentDetailsId;
    private System.Int64? _sdApplicationId;
    private System.Int64? _sdLoginId;
    private System.Int64? _sdParentId;
    private System.String _sdStudentPNRId;
    private System.String _sdStudentClassId;
    private System.String _sdFormNo;
    private System.String _sdFirstName;
    private System.String _sdMiddleName;
    private System.String _sdLastName;
    private System.DateTime? _sdDateOfBirth;
    private System.String _sdPlaceOfBirth;
    private System.String _sdAcadamicYear;
    private System.String _sdBloodGroup;
    private System.String _sdStudentImage;
    private System.String _sdNationality;
    private System.String _sdGender;
    private System.String _sdCaste;
    private System.String _sdSubCaste;
    private System.DateTime? _sdDateOfAdmission;
    private System.String _sdMotherTongue;
    private System.Int64? _sdSchoolCategoryId;
    private System.Int64? _sdSchoolSubCatId;
    private System.String _sdTransportStatus;
    private System.String _sdMedicalProblem;
    private System.String _sdLastSchoolAttended;
    private System.String _sdLastClassAttended;
    private System.String _sdLastClassPer;
    private System.Int64? _sdAddressId;
    private System.String _sdAgeProof;
    private System.String _sdLastProgressReportCard;
    private System.String _sdOriginalSchoolLC;
    private System.String _sdPassportAndVisa;
    private System.String _sdRegistrationLetter;
    private System.Int32? _sdStatus;

    #endregion


    #region Properties
    public System.Int64? SDStudentDetailsId
    {
        get
        {
            return _sdStudentDetailsId;
        }
        set
        {
            _sdStudentDetailsId = value;
        }
    }

    public System.Int64? SDApplicationId
    {
        get
        {
            return _sdApplicationId;
        }
        set
        {
            _sdApplicationId = value;
        }
    }

    public System.Int64? SDLoginId
    {
        get
        {
            return _sdLoginId;
        }
        set
        {
            _sdLoginId = value;
        }
    }

    public System.Int64? SDParentId
    {
        get
        {
            return _sdParentId;
        }
        set
        {
            _sdParentId = value;
        }
    }

    public System.String SDStudentPNRId
    {
        get
        {
            return _sdStudentPNRId;
        }
        set
        {
            _sdStudentPNRId = value;
        }
    }

    public System.String SDStudentClassId
    {
        get
        {
            return _sdStudentClassId;
        }
        set
        {
            _sdStudentClassId = value;
        }
    }

    public System.String SDFormNo
    {
        get
        {
            return _sdFormNo;
        }
        set
        {
            _sdFormNo = value;
        }
    }

    public System.String SDFirstName
    {
        get
        {
            return _sdFirstName;
        }
        set
        {
            _sdFirstName = value;
        }
    }

    public System.String SDMiddleName
    {
        get
        {
            return _sdMiddleName;
        }
        set
        {
            _sdMiddleName = value;
        }
    }

    public System.String SDLastName
    {
        get
        {
            return _sdLastName;
        }
        set
        {
            _sdLastName = value;
        }
    }

    public System.DateTime? SDDateOfBirth
    {
        get
        {
            return _sdDateOfBirth;
        }
        set
        {
            _sdDateOfBirth = value;
        }
    }

    public System.String SDPlaceOfBirth
    {
        get
        {
            return _sdPlaceOfBirth;
        }
        set
        {
            _sdPlaceOfBirth = value;
        }
    }

    public System.String SDAcadamicYear
    {
        get
        {
            return _sdAcadamicYear;
        }
        set
        {
            _sdAcadamicYear = value;
        }
    }

    public System.String SDBloodGroup
    {
        get
        {
            return _sdBloodGroup;
        }
        set
        {
            _sdBloodGroup = value;
        }
    }

    public System.String SDStudentImage
    {
        get
        {
            return _sdStudentImage;
        }
        set
        {
            _sdStudentImage = value;
        }
    }

    public System.String SDNationality
    {
        get
        {
            return _sdNationality;
        }
        set
        {
            _sdNationality = value;
        }
    }

    public System.String SDGender
    {
        get
        {
            return _sdGender;
        }
        set
        {
            _sdGender = value;
        }
    }

    public System.String SDCaste
    {
        get
        {
            return _sdCaste;
        }
        set
        {
            _sdCaste = value;
        }
    }

    public System.String SDSubCaste
    {
        get
        {
            return _sdSubCaste;
        }
        set
        {
            _sdSubCaste = value;
        }
    }

    public System.DateTime? SDDateOfAdmission
    {
        get
        {
            return _sdDateOfAdmission;
        }
        set
        {
            _sdDateOfAdmission = value;
        }
    }

    public System.String SDMotherTongue
    {
        get
        {
            return _sdMotherTongue;
        }
        set
        {
            _sdMotherTongue = value;
        }
    }

    public System.Int64? SDSchoolCategoryId
    {
        get
        {
            return _sdSchoolCategoryId;
        }
        set
        {
            _sdSchoolCategoryId = value;
        }
    }

    public System.Int64? SDSchoolSubCatId
    {
        get
        {
            return _sdSchoolSubCatId;
        }
        set
        {
            _sdSchoolSubCatId = value;
        }
    }

    public System.String SDTransportStatus
    {
        get
        {
            return _sdTransportStatus;
        }
        set
        {
            _sdTransportStatus = value;
        }
    }

    public System.String SDMedicalProblem
    {
        get
        {
            return _sdMedicalProblem;
        }
        set
        {
            _sdMedicalProblem = value;
        }
    }

    public System.String SDLastSchoolAttended
    {
        get
        {
            return _sdLastSchoolAttended;
        }
        set
        {
            _sdLastSchoolAttended = value;
        }
    }

    public System.String SDLastClassAttended
    {
        get
        {
            return _sdLastClassAttended;
        }
        set
        {
            _sdLastClassAttended = value;
        }
    }

    public System.String SDLastClassPer
    {
        get
        {
            return _sdLastClassPer;
        }
        set
        {
            _sdLastClassPer = value;
        }
    }

    public System.Int64? SDAddressId
    {
        get
        {
            return _sdAddressId;
        }
        set
        {
            _sdAddressId = value;
        }
    }

    public System.String SDAgeProof
    {
        get
        {
            return _sdAgeProof;
        }
        set
        {
            _sdAgeProof = value;
        }
    }

    public System.String SDLastProgressReportCard
    {
        get
        {
            return _sdLastProgressReportCard;
        }
        set
        {
            _sdLastProgressReportCard = value;
        }
    }

    public System.String SDOriginalSchoolLC
    {
        get
        {
            return _sdOriginalSchoolLC;
        }
        set
        {
            _sdOriginalSchoolLC = value;
        }
    }

    public System.String SDPassportAndVisa
    {
        get
        {
            return _sdPassportAndVisa;
        }
        set
        {
            _sdPassportAndVisa = value;
        }
    }

    public System.String SDRegistrationLetter
    {
        get
        {
            return _sdRegistrationLetter;
        }
        set
        {
            _sdRegistrationLetter = value;
        }
    }

    public System.Int32? SDStatus
    {
        get
        {
            return _sdStatus;
        }
        set
        {
            _sdStatus = value;
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

        ds.Tables[TABLE_NAME].Columns.Add("SD_StudentDetailsId", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("SD_ApplicationId", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("SD_loginId", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("SD_ParentId", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("SD_StudentPNRId", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_StudentClassId", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_FormNo", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_FirstName", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_MiddleName", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_LastName", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_DateOfBirth", typeof(System.DateTime));
        ds.Tables[TABLE_NAME].Columns.Add("SD_PlaceOfBirth", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_AcadamicYear", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_BloodGroup", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_StudentImage", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_Nationality", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_Gender", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_Caste", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_SubCaste", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_DateOfAdmission", typeof(System.DateTime));
        ds.Tables[TABLE_NAME].Columns.Add("SD_MotherTounge", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_SchoolCategoryId", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("SD_SchoolSubCatId", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("SD_TransportStatus", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_MedicalProblem", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_LastSchoolAttended", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_LastClassAttended", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_LastClassPer", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_AddressId", typeof(System.Int64));
        ds.Tables[TABLE_NAME].Columns.Add("SD_AgeProof", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_LastProgressReportCard", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_OriginalSchoolLC", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_PassportAndVisa", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_RegistrationLetter", typeof(System.String));
        ds.Tables[TABLE_NAME].Columns.Add("SD_Status", typeof(System.Int32));

        dr = ds.Tables[TABLE_NAME].NewRow();

        if (SDStudentDetailsId == null)
            dr["SD_StudentDetailsId"] = DBNull.Value;
        else
            dr["SD_StudentDetailsId"] = SDStudentDetailsId;

        if (SDApplicationId == null)
            dr["SD_ApplicationId"] = DBNull.Value;
        else
            dr["SD_ApplicationId"] = SDApplicationId;

        if (SDLoginId == null)
            dr["SD_loginId"] = DBNull.Value;
        else
            dr["SD_loginId"] = SDLoginId;

        if (SDParentId == null)
            dr["SD_ParentId"] = DBNull.Value;
        else
            dr["SD_ParentId"] = SDParentId;

        if (SDStudentPNRId == null)
            dr["SD_StudentPNRId"] = DBNull.Value;
        else
            dr["SD_StudentPNRId"] = SDStudentPNRId;

        if (SDStudentClassId == null)
            dr["SD_StudentClassId"] = DBNull.Value;
        else
            dr["SD_StudentClassId"] = SDStudentClassId;

        if (SDFormNo == null)
            dr["SD_FormNo"] = DBNull.Value;
        else
            dr["SD_FormNo"] = SDFormNo;

        if (SDFirstName == null)
            dr["SD_FirstName"] = DBNull.Value;
        else
            dr["SD_FirstName"] = SDFirstName;

        if (SDMiddleName == null)
            dr["SD_MiddleName"] = DBNull.Value;
        else
            dr["SD_MiddleName"] = SDMiddleName;

        if (SDLastName == null)
            dr["SD_LastName"] = DBNull.Value;
        else
            dr["SD_LastName"] = SDLastName;

        if (SDDateOfBirth == null)
            dr["SD_DateOfBirth"] = DBNull.Value;
        else
            dr["SD_DateOfBirth"] = SDDateOfBirth;

        if (SDPlaceOfBirth == null)
            dr["SD_PlaceOfBirth"] = DBNull.Value;
        else
            dr["SD_PlaceOfBirth"] = SDPlaceOfBirth;

        if (SDAcadamicYear == null)
            dr["SD_AcadamicYear"] = DBNull.Value;
        else
            dr["SD_AcadamicYear"] = SDAcadamicYear;

        if (SDBloodGroup == null)
            dr["SD_BloodGroup"] = DBNull.Value;
        else
            dr["SD_BloodGroup"] = SDBloodGroup;

        if (SDStudentImage == null)
            dr["SD_StudentImage"] = DBNull.Value;
        else
            dr["SD_StudentImage"] = SDStudentImage;

        if (SDNationality == null)
            dr["SD_Nationality"] = DBNull.Value;
        else
            dr["SD_Nationality"] = SDNationality;

        if (SDGender == null)
            dr["SD_Gender"] = DBNull.Value;
        else
            dr["SD_Gender"] = SDGender;

        if (SDCaste == null)
            dr["SD_Caste"] = DBNull.Value;
        else
            dr["SD_Caste"] = SDCaste;

        if (SDSubCaste == null)
            dr["SD_SubCaste"] = DBNull.Value;
        else
            dr["SD_SubCaste"] = SDSubCaste;

        if (SDDateOfAdmission == null)
            dr["SD_DateOfAdmission"] = DBNull.Value;
        else
            dr["SD_DateOfAdmission"] = SDDateOfAdmission;

        if (SDMotherTongue == null)
            dr["SD_MotherTounge"] = DBNull.Value;
        else
            dr["SD_MotherTounge"] = SDMotherTongue;

        if (SDSchoolCategoryId == null)
            dr["SD_SchoolCategoryId"] = DBNull.Value;
        else
            dr["SD_SchoolCategoryId"] = SDSchoolCategoryId;

        if (SDSchoolSubCatId == null)
            dr["SD_SchoolSubCatId"] = DBNull.Value;
        else
            dr["SD_SchoolSubCatId"] = SDSchoolSubCatId;

        if (SDTransportStatus == null)
            dr["SD_TransportStatus"] = DBNull.Value;
        else
            dr["SD_TransportStatus"] = SDTransportStatus;

        if (SDMedicalProblem == null)
            dr["SD_MedicalProblem"] = DBNull.Value;
        else
            dr["SD_MedicalProblem"] = SDMedicalProblem;

        if (SDLastSchoolAttended == null)
            dr["SD_LastSchoolAttended"] = DBNull.Value;
        else
            dr["SD_LastSchoolAttended"] = SDLastSchoolAttended;

        if (SDLastClassAttended == null)
            dr["SD_LastClassAttended"] = DBNull.Value;
        else
            dr["SD_LastClassAttended"] = SDLastClassAttended;

        if (SDLastClassPer == null)
            dr["SD_LastClassPer"] = DBNull.Value;
        else
            dr["SD_LastClassPer"] = SDLastClassPer;

        if (SDAddressId == null)
            dr["SD_AddressId"] = DBNull.Value;
        else
            dr["SD_AddressId"] = SDAddressId;

        if (SDAgeProof == null)
            dr["SD_AgeProof"] = DBNull.Value;
        else
            dr["SD_AgeProof"] = SDAgeProof;

        if (SDLastProgressReportCard == null)
            dr["SD_LastProgressReportCard"] = DBNull.Value;
        else
            dr["SD_LastProgressReportCard"] = SDLastProgressReportCard;

        if (SDOriginalSchoolLC == null)
            dr["SD_OriginalSchoolLC"] = DBNull.Value;
        else
            dr["SD_OriginalSchoolLC"] = SDOriginalSchoolLC;

        if (SDPassportAndVisa == null)
            dr["SD_PassportAndVisa"] = DBNull.Value;
        else
            dr["SD_PassportAndVisa"] = SDPassportAndVisa;

        if (SDRegistrationLetter == null)
            dr["SD_RegistrationLetter"] = DBNull.Value;
        else
            dr["SD_RegistrationLetter"] = SDRegistrationLetter;

        if (SDStatus == null)
            dr["SD_Status"] = DBNull.Value;
        else
            dr["SD_Status"] = SDStatus;


        ds.Tables[TABLE_NAME].Rows.Add(dr);

    }

    protected void MapFrom(DataRow dr)
    {
        SDStudentDetailsId = dr["SD_StudentDetailsId"] != DBNull.Value ? Convert.ToInt64(dr["SD_StudentDetailsId"]) : SDStudentDetailsId = null;
        SDApplicationId = dr["SD_ApplicationId"] != DBNull.Value ? Convert.ToInt64(dr["SD_ApplicationId"]) : SDApplicationId = null;
        SDLoginId = dr["SD_loginId"] != DBNull.Value ? Convert.ToInt64(dr["SD_loginId"]) : SDLoginId = null;
        SDParentId = dr["SD_ParentId"] != DBNull.Value ? Convert.ToInt64(dr["SD_ParentId"]) : SDParentId = null;
        SDStudentPNRId = dr["SD_StudentPNRId"] != DBNull.Value ? Convert.ToString(dr["SD_StudentPNRId"]) : SDStudentPNRId = null;
        SDStudentClassId = dr["SD_StudentClassId"] != DBNull.Value ? Convert.ToString(dr["SD_StudentClassId"]) : SDStudentClassId = null;
        SDFormNo = dr["SD_FormNo"] != DBNull.Value ? Convert.ToString(dr["SD_FormNo"]) : SDFormNo = null;
        SDFirstName = dr["SD_FirstName"] != DBNull.Value ? Convert.ToString(dr["SD_FirstName"]) : SDFirstName = null;
        SDMiddleName = dr["SD_MiddleName"] != DBNull.Value ? Convert.ToString(dr["SD_MiddleName"]) : SDMiddleName = null;
        SDLastName = dr["SD_LastName"] != DBNull.Value ? Convert.ToString(dr["SD_LastName"]) : SDLastName = null;
        SDDateOfBirth = dr["SD_DateOfBirth"] != DBNull.Value ? Convert.ToDateTime(dr["SD_DateOfBirth"]) : SDDateOfBirth = null;
        SDPlaceOfBirth = dr["SD_PlaceOfBirth"] != DBNull.Value ? Convert.ToString(dr["SD_PlaceOfBirth"]) : SDPlaceOfBirth = null;
        SDAcadamicYear = dr["SD_AcadamicYear"] != DBNull.Value ? Convert.ToString(dr["SD_AcadamicYear"]) : SDAcadamicYear = null;
        SDBloodGroup = dr["SD_BloodGroup"] != DBNull.Value ? Convert.ToString(dr["SD_BloodGroup"]) : SDBloodGroup = null;
        SDStudentImage = dr["SD_StudentImage"] != DBNull.Value ? Convert.ToString(dr["SD_StudentImage"]) : SDStudentImage = null;
        SDNationality = dr["SD_Nationality"] != DBNull.Value ? Convert.ToString(dr["SD_Nationality"]) : SDNationality = null;
        SDGender = dr["SD_Gender"] != DBNull.Value ? Convert.ToString(dr["SD_Gender"]) : SDGender = null;
        SDCaste = dr["SD_Caste"] != DBNull.Value ? Convert.ToString(dr["SD_Caste"]) : SDCaste = null;
        SDSubCaste = dr["SD_SubCaste"] != DBNull.Value ? Convert.ToString(dr["SD_SubCaste"]) : SDSubCaste = null;
        SDDateOfAdmission = dr["SD_DateOfAdmission"] != DBNull.Value ? Convert.ToDateTime(dr["SD_DateOfAdmission"]) : SDDateOfAdmission = null;
        SDMotherTongue = dr["SD_MotherTounge"] != DBNull.Value ? Convert.ToString(dr["SD_MotherTounge"]) : SDMotherTongue = null;
        SDSchoolCategoryId = dr["SD_SchoolCategoryId"] != DBNull.Value ? Convert.ToInt64(dr["SD_SchoolCategoryId"]) : SDSchoolCategoryId = null;
        SDSchoolSubCatId = dr["SD_SchoolSubCatId"] != DBNull.Value ? Convert.ToInt64(dr["SD_SchoolSubCatId"]) : SDSchoolSubCatId = null;
        SDTransportStatus = dr["SD_TransportStatus"] != DBNull.Value ? Convert.ToString(dr["SD_TransportStatus"]) : SDTransportStatus = null;
        SDMedicalProblem = dr["SD_MedicalProblem"] != DBNull.Value ? Convert.ToString(dr["SD_MedicalProblem"]) : SDMedicalProblem = null;
        SDLastSchoolAttended = dr["SD_LastSchoolAttended"] != DBNull.Value ? Convert.ToString(dr["SD_LastSchoolAttended"]) : SDLastSchoolAttended = null;
        SDLastClassAttended = dr["SD_LastClassAttended"] != DBNull.Value ? Convert.ToString(dr["SD_LastClassAttended"]) : SDLastClassAttended = null;
        SDLastClassPer = dr["SD_LastClassPer"] != DBNull.Value ? Convert.ToString(dr["SD_LastClassPer"]) : SDLastClassPer = null;
        SDAddressId = dr["SD_AddressId"] != DBNull.Value ? Convert.ToInt64(dr["SD_AddressId"]) : SDAddressId = null;
        SDAgeProof = dr["SD_AgeProof"] != DBNull.Value ? Convert.ToString(dr["SD_AgeProof"]) : SDAgeProof = null;
        SDLastProgressReportCard = dr["SD_LastProgressReportCard"] != DBNull.Value ? Convert.ToString(dr["SD_LastProgressReportCard"]) : SDLastProgressReportCard = null;
        SDOriginalSchoolLC = dr["SD_OriginalSchoolLC"] != DBNull.Value ? Convert.ToString(dr["SD_OriginalSchoolLC"]) : SDOriginalSchoolLC = null;
        SDPassportAndVisa = dr["SD_PassportAndVisa"] != DBNull.Value ? Convert.ToString(dr["SD_PassportAndVisa"]) : SDPassportAndVisa = null;
        SDRegistrationLetter = dr["SD_RegistrationLetter"] != DBNull.Value ? Convert.ToString(dr["SD_RegistrationLetter"]) : SDRegistrationLetter = null;
        SDStatus = dr["SD_Status"] != DBNull.Value ? Convert.ToInt32(dr["SD_Status"]) : SDStatus = null;
    }

    public static TMSStudentDetails[] MapFrom(DataSet ds)
    {
        List<TMSStudentDetails> objects;


        // Initialise Collection.
        objects = new List<TMSStudentDetails>();

        // Validation.
        if (ds == null)
            throw new ApplicationException("Cannot map to dataset null.");
        else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
            return objects.ToArray();

        if (ds.Tables[TABLE_NAME] == null)
            throw new ApplicationException("Cannot find table [dbo].[TMS_StudentDetails] in DataSet.");

        if (ds.Tables[TABLE_NAME].Rows.Count < 1)
            throw new ApplicationException("Table [dbo].[TMS_StudentDetails] is empty.");

        // Map DataSet to Instance.
        foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
        {
            TMSStudentDetails instance = new TMSStudentDetails();
            instance.MapFrom(dr);
            objects.Add(instance);
        }

        // Return collection.
        return objects.ToArray();
    }


    #endregion


    #region CRUD Methods

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static TMSStudentDetails Get(System.Int64 sdStudentDetailsId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        TMSStudentDetails instance;


        instance = new TMSStudentDetails();

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudentDetails_SELECT";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sdStudentDetailsId);

        // Get results.
        ds = db.ExecuteDataSet(dbCommand);
        // Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSStudentDetails ID:" + sdStudentDetailsId.ToString() + " from Database.");
        // Return results.
        ds.Tables[0].TableName = TABLE_NAME;

        instance.MapFrom(ds.Tables[0].Rows[0]);
        return instance;
    }

    #region INSERT
    public void Insert(System.Int64? sdApplicationId, System.Int64? sdLoginId, System.Int64? sdParentId, System.String sdStudentClassId, System.String sdFormNo, System.String sdFirstName, System.String sdMiddleName, System.String sdLastName, System.DateTime? sdDateOfBirth, System.String sdPlaceOfBirth, System.String sdAcadamicYear, System.String sdBloodGroup, System.String sdStudentImage, System.String sdNationality, System.String sdGender, System.String sdCaste, System.String sdSubCaste, System.DateTime? sdDateOfAdmission, System.String sdMotherTongue, System.Int64? sdSchoolCategoryId, System.Int64? sdSchoolSubCatId, System.String sdTransportStatus, System.String sdMedicalProblem, System.String sdLastSchoolAttended, System.String sdLastClassAttended, System.String sdLastClassPer, System.Int64? sdAddressId, System.String sdAgeProof, System.String sdLastProgressReportCard, System.String sdOriginalSchoolLC, System.String sdPassportAndVisa, System.String sdRegistrationLetter, System.Int32? sdStatus, DbTransaction transaction)
    {
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudentDetails_INSERT";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sdApplicationId, sdLoginId, sdParentId, sdStudentClassId, sdFormNo, sdFirstName, sdMiddleName, sdLastName, sdDateOfBirth, sdPlaceOfBirth, sdAcadamicYear, sdBloodGroup, sdStudentImage, sdNationality, sdGender, sdCaste, sdSubCaste, sdDateOfAdmission, sdMotherTongue, sdSchoolCategoryId, sdSchoolSubCatId, sdTransportStatus, sdMedicalProblem, sdLastSchoolAttended, sdLastClassAttended, sdLastClassPer, sdAddressId, sdAgeProof, sdLastProgressReportCard, sdOriginalSchoolLC, sdPassportAndVisa, sdRegistrationLetter, sdStatus);

        if (transaction == null)
            this.SDStudentDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
        else
            this.SDStudentDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
        return;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
    public void Insert(System.Int64? sdApplicationId, System.Int64? sdLoginId, System.Int64? sdParentId, System.String sdStudentClassId, System.String sdFormNo, System.String sdFirstName, System.String sdMiddleName, System.String sdLastName, System.DateTime? sdDateOfBirth, System.String sdPlaceOfBirth, System.String sdAcadamicYear, System.String sdBloodGroup, System.String sdStudentImage, System.String sdNationality, System.String sdGender, System.String sdCaste, System.String sdSubCaste, System.DateTime? sdDateOfAdmission, System.String sdMotherTongue, System.Int64? sdSchoolCategoryId, System.Int64? sdSchoolSubCatId, System.String sdTransportStatus, System.String sdMedicalProblem, System.String sdLastSchoolAttended, System.String sdLastClassAttended, System.String sdLastClassPer, System.Int64? sdAddressId, System.String sdAgeProof, System.String sdLastProgressReportCard, System.String sdOriginalSchoolLC, System.String sdPassportAndVisa, System.String sdRegistrationLetter, System.Int32? sdStatus)
    {
        Insert(sdApplicationId, sdLoginId, sdParentId, sdStudentClassId, sdFormNo, sdFirstName, sdMiddleName, sdLastName, sdDateOfBirth, sdPlaceOfBirth, sdAcadamicYear, sdBloodGroup, sdStudentImage, sdNationality, sdGender, sdCaste, sdSubCaste, sdDateOfAdmission, sdMotherTongue, sdSchoolCategoryId, sdSchoolSubCatId, sdTransportStatus, sdMedicalProblem, sdLastSchoolAttended, sdLastClassAttended, sdLastClassPer, sdAddressId, sdAgeProof, sdLastProgressReportCard, sdOriginalSchoolLC, sdPassportAndVisa, sdRegistrationLetter, sdStatus, null);
    }
    /// <summary>
    /// Insert current TMSStudentDetails to database.
    /// </summary>
    /// <param name="transaction">optional SQL Transaction</param>
    public void Insert(DbTransaction transaction)
    {
        Insert(SDApplicationId, SDLoginId, SDParentId, SDStudentClassId, SDFormNo, SDFirstName, SDMiddleName, SDLastName, SDDateOfBirth, SDPlaceOfBirth, SDAcadamicYear, SDBloodGroup, SDStudentImage, SDNationality, SDGender, SDCaste, SDSubCaste, SDDateOfAdmission, SDMotherTongue, SDSchoolCategoryId, SDSchoolSubCatId, SDTransportStatus, SDMedicalProblem, SDLastSchoolAttended, SDLastClassAttended, SDLastClassPer, SDAddressId, SDAgeProof, SDLastProgressReportCard, SDOriginalSchoolLC, SDPassportAndVisa, SDRegistrationLetter, SDStatus, transaction);
    }

    /// <summary>
    /// Insert current TMSStudentDetails to database.
    /// </summary>
    public void Insert()
    {
        this.Insert((DbTransaction)null);
    }
    #endregion


    #region UPDATE
    public static void Update(System.Int64? sdStudentDetailsId, System.Int64? sdApplicationId, System.Int64? sdLoginId, System.Int64? sdParentId, System.String sdStudentPNRId, System.String sdStudentClassId, System.String sdFormNo, System.String sdFirstName, System.String sdMiddleName, System.String sdLastName, System.DateTime? sdDateOfBirth, System.String sdPlaceOfBirth, System.String sdAcadamicYear, System.String sdBloodGroup, System.String sdStudentImage, System.String sdNationality, System.String sdGender, System.String sdCaste, System.String sdSubCaste, System.DateTime? sdDateOfAdmission, System.String sdMotherTongue, System.Int64? sdSchoolCategoryId, System.Int64? sdSchoolSubCatId, System.String sdTransportStatus, System.String sdMedicalProblem, System.String sdLastSchoolAttended, System.String sdLastClassAttended, System.String sdLastClassPer, System.Int64? sdAddressId, System.String sdAgeProof, System.String sdLastProgressReportCard, System.String sdOriginalSchoolLC, System.String sdPassportAndVisa, System.String sdRegistrationLetter, DbTransaction transaction)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudentDetails_UPDATE";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        db.DiscoverParameters(dbCommand);
        dbCommand.Parameters["@sdStudentDetailsId"].Value = sdStudentDetailsId;
        dbCommand.Parameters["@sdApplicationId"].Value = sdApplicationId;
        dbCommand.Parameters["@sdLoginId"].Value = sdLoginId;
        dbCommand.Parameters["@sdParentId"].Value = sdParentId;
        dbCommand.Parameters["@sdStudentClassId"].Value = sdStudentPNRId;
        dbCommand.Parameters["@sdFormNo"].Value = sdStudentClassId;
        dbCommand.Parameters["@sdFirstName"].Value = sdFormNo;
        dbCommand.Parameters["@sdMiddleName"].Value = sdFirstName;
        dbCommand.Parameters["@sdLastName"].Value = sdMiddleName;
        dbCommand.Parameters["@sdDateOfBirth"].Value = sdLastName;
        dbCommand.Parameters["@sdPlaceOfBirth"].Value = sdDateOfBirth;
        dbCommand.Parameters["@sdAcadamicYear"].Value = sdPlaceOfBirth;
        dbCommand.Parameters["@sdBloodGroup"].Value = sdAcadamicYear;
        dbCommand.Parameters["@sdStudentImage"].Value = sdBloodGroup;
        dbCommand.Parameters["@sdNationality"].Value = sdStudentImage;
        dbCommand.Parameters["@sdGender"].Value = sdNationality;
        dbCommand.Parameters["@sdCaste"].Value = sdGender;
        dbCommand.Parameters["@sdSubCaste"].Value = sdCaste;
        dbCommand.Parameters["@sdDateOfAdmission"].Value = sdSubCaste;
        dbCommand.Parameters["@sdMotherTounge"].Value = sdDateOfAdmission;
        dbCommand.Parameters["@sdSchoolCategoryId"].Value = sdMotherTongue;
        dbCommand.Parameters["@sdSchoolSubCatId"].Value = sdSchoolCategoryId;
        dbCommand.Parameters["@sdTransportStatus"].Value = sdSchoolSubCatId;
        dbCommand.Parameters["@sdMedicalProblem"].Value = sdTransportStatus;
        dbCommand.Parameters["@sdLastSchoolAttended"].Value = sdMedicalProblem;
        dbCommand.Parameters["@sdLastClassAttended"].Value = sdLastSchoolAttended;
        dbCommand.Parameters["@sdLastClassPer"].Value = sdLastClassAttended;
        dbCommand.Parameters["@sdAddressId"].Value = sdLastClassPer;
        dbCommand.Parameters["@sdAgeProof"].Value = sdAddressId;
        dbCommand.Parameters["@sdLastProgressReportCard"].Value = sdAgeProof;
        dbCommand.Parameters["@sdOriginalSchoolLC"].Value = sdLastProgressReportCard;
        dbCommand.Parameters["@sdPassportAndVisa"].Value = sdOriginalSchoolLC;
        dbCommand.Parameters["@sdRegistrationLetter"].Value = sdPassportAndVisa;
        dbCommand.Parameters["@sdStatus"].Value = sdRegistrationLetter;

        if (transaction == null)
            db.ExecuteNonQuery(dbCommand);
        else
            db.ExecuteNonQuery(dbCommand, transaction);
        return;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
    public static void Update(System.Int64? sdStudentDetailsId, System.Int64? sdApplicationId, System.Int64? sdLoginId, System.Int64? sdParentId, System.String sdStudentPNRId, System.String sdStudentClassId, System.String sdFormNo, System.String sdFirstName, System.String sdMiddleName, System.String sdLastName, System.DateTime? sdDateOfBirth, System.String sdPlaceOfBirth, System.String sdAcadamicYear, System.String sdBloodGroup, System.String sdStudentImage, System.String sdNationality, System.String sdGender, System.String sdCaste, System.String sdSubCaste, System.DateTime? sdDateOfAdmission, System.String sdMotherTongue, System.Int64? sdSchoolCategoryId, System.Int64? sdSchoolSubCatId, System.String sdTransportStatus, System.String sdMedicalProblem, System.String sdLastSchoolAttended, System.String sdLastClassAttended, System.String sdLastClassPer, System.Int64? sdAddressId, System.String sdAgeProof, System.String sdLastProgressReportCard, System.String sdOriginalSchoolLC, System.String sdPassportAndVisa, System.String sdRegistrationLetter)
    {
        Update(sdStudentDetailsId, sdApplicationId, sdLoginId, sdParentId, sdStudentPNRId, sdStudentClassId, sdFormNo, sdFirstName, sdMiddleName, sdLastName, sdDateOfBirth, sdPlaceOfBirth, sdAcadamicYear, sdBloodGroup, sdStudentImage, sdNationality, sdGender, sdCaste, sdSubCaste, sdDateOfAdmission, sdMotherTongue, sdSchoolCategoryId, sdSchoolSubCatId, sdTransportStatus, sdMedicalProblem, sdLastSchoolAttended, sdLastClassAttended, sdLastClassPer, sdAddressId, sdAgeProof, sdLastProgressReportCard, sdOriginalSchoolLC, sdPassportAndVisa, sdRegistrationLetter, null);
    }

    public static void Update(TMSStudentDetails tMSStudentDetails)
    {
        tMSStudentDetails.Update();
    }

    public static void Update(TMSStudentDetails tMSStudentDetails, DbTransaction transaction)
    {
        tMSStudentDetails.Update(transaction);
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
        sqlCommand = "[dbo].gspTMSStudentDetails_UPDATE";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        db.DiscoverParameters(dbCommand);
        dbCommand.Parameters["@sdStudentDetailsId"].SourceColumn = "SD_StudentDetailsId";
        dbCommand.Parameters["@sdApplicationId"].SourceColumn = "SD_ApplicationId";
        dbCommand.Parameters["@sdLoginId"].SourceColumn = "SD_loginId";
        dbCommand.Parameters["@sdParentId"].SourceColumn = "SD_ParentId";
        dbCommand.Parameters["@sdStudentClassId"].SourceColumn = "SD_StudentClassId";
        dbCommand.Parameters["@sdFormNo"].SourceColumn = "SD_FormNo";
        dbCommand.Parameters["@sdFirstName"].SourceColumn = "SD_FirstName";
        dbCommand.Parameters["@sdMiddleName"].SourceColumn = "SD_MiddleName";
        dbCommand.Parameters["@sdLastName"].SourceColumn = "SD_LastName";
        dbCommand.Parameters["@sdDateOfBirth"].SourceColumn = "SD_DateOfBirth";
        dbCommand.Parameters["@sdPlaceOfBirth"].SourceColumn = "SD_PlaceOfBirth";
        dbCommand.Parameters["@sdAcadamicYear"].SourceColumn = "SD_AcadamicYear";
        dbCommand.Parameters["@sdBloodGroup"].SourceColumn = "SD_BloodGroup";
        dbCommand.Parameters["@sdStudentImage"].SourceColumn = "SD_StudentImage";
        dbCommand.Parameters["@sdNationality"].SourceColumn = "SD_Nationality";
        dbCommand.Parameters["@sdGender"].SourceColumn = "SD_Gender";
        dbCommand.Parameters["@sdCaste"].SourceColumn = "SD_Caste";
        dbCommand.Parameters["@sdSubCaste"].SourceColumn = "SD_SubCaste";
        dbCommand.Parameters["@sdDateOfAdmission"].SourceColumn = "SD_DateOfAdmission";
        dbCommand.Parameters["@sdMotherTounge"].SourceColumn = "SD_MotherTounge";
        dbCommand.Parameters["@sdSchoolCategoryId"].SourceColumn = "SD_SchoolCategoryId";
        dbCommand.Parameters["@sdSchoolSubCatId"].SourceColumn = "SD_SchoolSubCatId";
        dbCommand.Parameters["@sdTransportStatus"].SourceColumn = "SD_TransportStatus";
        dbCommand.Parameters["@sdMedicalProblem"].SourceColumn = "SD_MedicalProblem";
        dbCommand.Parameters["@sdLastSchoolAttended"].SourceColumn = "SD_LastSchoolAttended";
        dbCommand.Parameters["@sdLastClassAttended"].SourceColumn = "SD_LastClassAttended";
        dbCommand.Parameters["@sdLastClassPer"].SourceColumn = "SD_LastClassPer";
        dbCommand.Parameters["@sdAddressId"].SourceColumn = "SD_AddressId";
        dbCommand.Parameters["@sdAgeProof"].SourceColumn = "SD_AgeProof";
        dbCommand.Parameters["@sdLastProgressReportCard"].SourceColumn = "SD_LastProgressReportCard";
        dbCommand.Parameters["@sdOriginalSchoolLC"].SourceColumn = "SD_OriginalSchoolLC";
        dbCommand.Parameters["@sdPassportAndVisa"].SourceColumn = "SD_PassportAndVisa";
        dbCommand.Parameters["@sdRegistrationLetter"].SourceColumn = "SD_RegistrationLetter";
        dbCommand.Parameters["@sdStatus"].SourceColumn = "SD_Status";

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
    public static void Delete(System.Int64? sdStudentDetailsId, DbTransaction transaction)
    {
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudentDetails_DELETE";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sdStudentDetailsId);

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
    public static void Delete(System.Int64? sdStudentDetailsId)
    {
        Delete(
        sdStudentDetailsId);
    }

    /// <summary>
    /// Delete current TMSStudentDetails from database.
    /// </summary>
    /// <param name="transaction">optional SQL Transaction</param>
    public void Delete(DbTransaction transaction)
    {
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudentDetails_DELETE";
        dbCommand = db.GetStoredProcCommand(sqlCommand, SDStudentDetailsId);

        // Execute.
        if (transaction != null)
        {
            db.ExecuteNonQuery(dbCommand, transaction);
        }
        else
        {
            db.ExecuteNonQuery(dbCommand);
        }
        this.SDStudentDetailsId = null;
    }

    /// <summary>
    /// Delete current TMSStudentDetails from database.
    /// </summary>
    public void Delete()
    {
        this.Delete((DbTransaction)null);
    }

    #endregion


    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static TMSStudentDetails[] Search(System.Int64? sdStudentDetailsId, System.Int64? sdApplicationId, System.Int64? sdLoginId, System.Int64? sdParentId, System.String sdStudentPNRId, System.String sdStudentClassId, System.String sdFormNo, System.String sdFirstName, System.String sdMiddleName, System.String sdLastName, System.DateTime? sdDateOfBirth, System.String sdPlaceOfBirth, System.String sdAcadamicYear, System.String sdBloodGroup, System.String sdStudentImage, System.String sdNationality, System.String sdGender, System.String sdCaste, System.String sdSubCaste, System.DateTime? sdDateOfAdmission, System.String sdMotherTongue, System.Int64? sdSchoolCategoryId, System.Int64? sdSchoolSubCatId, System.String sdTransportStatus, System.String sdMedicalProblem, System.String sdLastSchoolAttended, System.String sdLastClassAttended, System.String sdLastClassPer, System.Int64? sdAddressId, System.String sdAgeProof, System.String sdLastProgressReportCard, System.String sdOriginalSchoolLC, System.String sdPassportAndVisa, System.String sdRegistrationLetter, System.Int32? sdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudentDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sdStudentDetailsId, sdApplicationId, sdLoginId, sdParentId, sdStudentPNRId, sdStudentClassId, sdFormNo, sdFirstName, sdMiddleName, sdLastName, sdDateOfBirth, sdPlaceOfBirth, sdAcadamicYear, sdBloodGroup, sdStudentImage, sdNationality, sdGender, sdCaste, sdSubCaste, sdDateOfAdmission, sdMotherTongue, sdSchoolCategoryId, sdSchoolSubCatId, sdTransportStatus, sdMedicalProblem, sdLastSchoolAttended, sdLastClassAttended, sdLastClassPer, sdAddressId, sdAgeProof, sdLastProgressReportCard, sdOriginalSchoolLC, sdPassportAndVisa, sdRegistrationLetter, sdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        ds.Tables[0].TableName = TABLE_NAME;
        return TMSStudentDetails.MapFrom(ds);
    }


    public static TMSStudentDetails[] Search(TMSStudentDetails searchObject)
    {
        return Search(searchObject.SDStudentDetailsId, searchObject.SDApplicationId, searchObject.SDLoginId, searchObject.SDParentId, searchObject.SDStudentPNRId, searchObject.SDStudentClassId, searchObject.SDFormNo, searchObject.SDFirstName, searchObject.SDMiddleName, searchObject.SDLastName, searchObject.SDDateOfBirth, searchObject.SDPlaceOfBirth, searchObject.SDAcadamicYear, searchObject.SDBloodGroup, searchObject.SDStudentImage, searchObject.SDNationality, searchObject.SDGender, searchObject.SDCaste, searchObject.SDSubCaste, searchObject.SDDateOfAdmission, searchObject.SDMotherTongue, searchObject.SDSchoolCategoryId, searchObject.SDSchoolSubCatId, searchObject.SDTransportStatus, searchObject.SDMedicalProblem, searchObject.SDLastSchoolAttended, searchObject.SDLastClassAttended, searchObject.SDLastClassPer, searchObject.SDAddressId, searchObject.SDAgeProof, searchObject.SDLastProgressReportCard, searchObject.SDOriginalSchoolLC, searchObject.SDPassportAndVisa, searchObject.SDRegistrationLetter, searchObject.SDStatus);
    }

    /// <summary>
    /// Returns all TMSStudentDetails objects.
    /// </summary>
    /// <returns>List of all TMSStudentDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static TMSStudentDetails[] Search()
    {
        return Search(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    #endregion


    #endregion


}

