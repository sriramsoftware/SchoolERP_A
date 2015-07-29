using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSStudentDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? sdStudentDetailsId, System.Int64? sdApplicationId, System.Int64? sdLoginId, System.Int64? sdParentId, System.String sdStudentPNRId, System.String sdStudentClassId, System.String sdFormNo, System.String sdFirstName, System.String sdMiddleName, System.String sdLastName, System.DateTime? sdDateOfBirth, System.String sdPlaceOfBirth, System.String sdAcadamicYear, System.String sdBloodGroup, System.String sdStudentImage, System.String sdNationality, System.String sdGender, System.String sdCaste, System.String sdSubCaste, System.DateTime? sdDateOfAdmission, System.String sdMotherTongue, System.Int64? sdSchoolCategoryId, System.Int64? sdSchoolSubCatId, System.String sdTransportStatus, System.String sdMedicalProblem, System.String sdLastSchoolAttended, System.String sdLastClassAttended, System.String sdLastClassPer, System.Int64? sdAddressId, System.String sdAgeProof, System.String sdLastProgressReportCard, System.String sdOriginalSchoolLC, System.String sdPassportAndVisa, System.String sdRegistrationLetter, System.Int32? sdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudentDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sdStudentDetailsId, sdApplicationId, sdLoginId, sdParentId, sdStudentPNRId, sdStudentClassId, sdFormNo, sdFirstName, sdMiddleName, sdLastName, sdDateOfBirth, sdPlaceOfBirth, sdAcadamicYear, sdBloodGroup, sdStudentImage, sdNationality, sdGender, sdCaste, sdSubCaste, sdDateOfAdmission, sdMotherTongue, sdSchoolCategoryId, sdSchoolSubCatId, sdTransportStatus, sdMedicalProblem, sdLastSchoolAttended, sdLastClassAttended, sdLastClassPer, sdAddressId, sdAgeProof, sdLastProgressReportCard, sdOriginalSchoolLC, sdPassportAndVisa, sdRegistrationLetter, sdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSStudentDetails searchObject)
    {
        return GetSearch(searchObject.SDStudentDetailsId, searchObject.SDApplicationId, searchObject.SDLoginId, searchObject.SDParentId, searchObject.SDStudentPNRId, searchObject.SDStudentClassId, searchObject.SDFormNo, searchObject.SDFirstName, searchObject.SDMiddleName, searchObject.SDLastName, searchObject.SDDateOfBirth, searchObject.SDPlaceOfBirth, searchObject.SDAcadamicYear, searchObject.SDBloodGroup, searchObject.SDStudentImage, searchObject.SDNationality, searchObject.SDGender, searchObject.SDCaste, searchObject.SDSubCaste, searchObject.SDDateOfAdmission, searchObject.SDMotherTongue, searchObject.SDSchoolCategoryId, searchObject.SDSchoolSubCatId, searchObject.SDTransportStatus, searchObject.SDMedicalProblem, searchObject.SDLastSchoolAttended, searchObject.SDLastClassAttended, searchObject.SDLastClassPer, searchObject.SDAddressId, searchObject.SDAgeProof, searchObject.SDLastProgressReportCard, searchObject.SDOriginalSchoolLC, searchObject.SDPassportAndVisa, searchObject.SDRegistrationLetter, searchObject.SDStatus);
    }

    /// <summary>
    /// Returns all TMSStudentDetails objects.
    /// </summary>
    /// <returns>List of all TMSStudentDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
    public static DataSet GETParentDAta(System.Int64? sdParentId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudentDetails_GetParentDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sdParentId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetStudentAddress(System.Int64? StudentID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudentDetails_GetStudentDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentID);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetStudentClassMatesDetails(System.Int64? StudentID, System.String studentName, System.String parentName, System.Int64? parentId, System.Int64? loginId, System.String sortType, System.String schoolType, System.Int64? schoolId, System.Int64? subschoolId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSMyClassMatesDetailsSearch]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentID, studentName, parentName, parentId, loginId, sortType, schoolType, schoolId, subschoolId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetAllStudentDetails(System.String sortType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSPrincipalStudentDetailsSearch]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sortType);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetStudentBirthdaydetails(System.Int64? StandardID, System.Int64? DivisionID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudent_BirthdayData";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StandardID, DivisionID);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet getstudentList(System.Int64? standard, System.Int64? division)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrStudentList_Monitor";
        dbCommand = db.GetStoredProcCommand(sqlCommand, standard, division);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet BindStudentTransportList(System.Int64? standard, System.Int64? division)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrStudentTransportList";
        dbCommand = db.GetStoredProcCommand(sqlCommand, standard, division);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet SearchClassTeacherStudentDetails(System.Int64? schoolId, System.Int64? schoolSubId, System.Int64? facultyLoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[SearchStudentForInsertAttendance]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, schoolId, schoolSubId, facultyLoginId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetStudentName(System.Int64? StudentLoginID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchStudentName]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentLoginID);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetParentName(System.Int64? ParentLoginID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchParentName]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ParentLoginID);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetStudentdetailsaccordingtoid(System.Int64? StudentID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetstudentDetaisAccordingTOStudentID";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentID);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetStudentDetails_FilterWise(System.Int64? StudentID, System.String studentName, System.String parentName, System.Int64? parentId, System.Int64? loginId, System.String schoolType, System.Int64? schoolId, System.Int64? subschoolId,System.String pnrId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSSearchStudents_FilterWise]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentID, studentName, parentName, parentId, loginId, schoolType, schoolId, subschoolId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetStudentAdmissionDetails(System.Int64? StudentID, System.String studentName, System.String parentName, System.Int64? parentId, System.Int64? loginId, System.String sortType, System.String schoolType, System.Int64? schoolId, System.Int64? subschoolId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrAdmissionDetailsSearch]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentID, studentName, parentName, parentId, loginId, sortType, schoolType, schoolId, subschoolId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetStudentList_Fordivision(System.Int64? standardID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrStudentList_Fordivision";
        dbCommand = db.GetStoredProcCommand(sqlCommand, standardID);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static int DeleteAccount(System.Int64? LoginId, System.String type)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrStudentDeleteAccount]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LoginId, type);
        int Status = db.ExecuteNonQuery(dbCommand);
        return Status;

    }


    public static DataSet GetStudentListStandardWise(System.Int64? schoolId, System.Int64? subschoolId, System.Int64? ExamTestId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSStudentListStandardWise]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, schoolId, subschoolId,ExamTestId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetStudentDetails(System.Int64? facultyLoginId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMSSearchStudentDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand,facultyLoginId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet CheckRollNumber(System.String RollNumber, System.Int64? Standard, System.Int64? Division)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        int result;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSCheckRollNumber]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, RollNumber, Standard, Division);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #region SearchPNRId Details
    public static DataSet GetSerachStudentPNRId(System.String StudentPNRId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSSearchStudentPNRDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentPNRId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
    #region Search Student Exist Details
    public static DataSet GetSerachStudentExistsDetails(System.Int64? StudentDetailId,System.Int64? StudentApplicationId,System.Int64? StudentLoginId,System.Int64? StudentParentId,System.String StudentPNRId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSStudentApplicationDetails1";
        dbCommand = db.GetStoredProcCommand(sqlCommand,StudentDetailId,StudentApplicationId,StudentLoginId,StudentParentId, StudentPNRId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

    #region student class at the time of admission for tc
    public static DataSet GetStudAdmissionClass(System.Int64? StudentLoginId, System.String AcademicYear)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetStudentAdmissionClass";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentLoginId, AcademicYear);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

    #region student last attendended class  for tc
    public static DataSet GetStudentLastAttendendedClass(System.Int64? StudentLoginId, System.String AcademicYear)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetStudentLastAttendendedClass";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentLoginId, AcademicYear);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion



    #region Get Total Number Of Working Days
    public static DataSet GetTotalNumberOfWorkingDays(DateTime StartDate, DateTime EndDate)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetTotal_NumberofWorkingDays_InYear";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StartDate, EndDate);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

    #region Get Total Number Of Present Days
    public static DataSet GetTotalNumberOfPresentDays(System.Int64? StudentLoginId, System.String AcademicYear)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetTotal_NumberofPresentDays_InYear";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentLoginId, AcademicYear);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion



    public static DataSet GetStudentDetails_ForPromotingTo_NextStandard(System.Int64? StudentID, System.String studentName, System.String parentName, System.Int64? parentId, System.Int64? StudentloginId, System.String schoolType, System.Int64? schoolId, System.Int64? subschoolId, System.String pnrId, System.String AcademicYear, System.String Result)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSSearchStudents_ForPromoting_ToNextStandard]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentID, studentName, parentName, parentId, StudentloginId, schoolType, schoolId, subschoolId, pnrId, AcademicYear, Result);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }



    public static int InsertStudentToNextStandard(System.Int64? studentDetailId, System.String resultText, System.Int64? schoolId, System.Int64? subSchoolId, System.String CurrentResultYear, System.String NextAcademicYear, System.Decimal? Marks)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_PromoteStudent_To_NextStandard";
        dbCommand = db.GetStoredProcCommand(sqlCommand, studentDetailId, resultText, schoolId, subSchoolId, CurrentResultYear, NextAcademicYear, Marks);
        return db.ExecuteNonQuery(dbCommand);
    }
    
}

