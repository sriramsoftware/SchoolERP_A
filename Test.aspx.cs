using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.Common;
using System.Data.SqlClient;

public partial class Test : System.Web.UI.Page
{



    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnSend_Click(object sender, EventArgs e)
    
    {
        //String strConnection = "Integrated Security=false;Persist Security Info=False;Data Source=SQL-SERVER;Initial Catalog=schoolerpsoft ;User ID=sa;Password=techmodi123";
        //String strConnection = "Integrated Security=false;Persist Security Info=False;Data Source=199.79.62.22;Initial Catalog=fashvash_inifdvashi ;User ID=inifd_user;Password=inifd!@#";
        //String strConnection = "Integrated Security=false;Persist Security Info=False;Data Source=TWS-ERPSERVER\\SQLEXPRESS;Initial Catalog=AsnASoftwaresolutionDB";
        String strConnection = "Integrated Security=SSPI;Persist Security Info=False;Data Source=TWS-ERPSERVER\\SQLEXPRESS;Initial Catalog=AsnASoftwaresolutionDB";
        //file upload path
        if (fileuploadExcel.HasFile)
        {
            string path = fileuploadExcel.PostedFile.FileName;
            path = Server.MapPath("~") + "/" + fileuploadExcel.PostedFile.FileName;
            fileuploadExcel.SaveAs(path);
            //Create connection string to Excel work book
            string excelConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;Persist Security Info=False";
            //Create Connection to Excel work book
            OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
            //Create OleDbCommand to fetch data from Excel

          //  OleDbCommand cmd = new OleDbCommand("Select [AD_AddressId],[AD_PermanentAddress],[AD_OfficeAddress] ,[AD_CommercialAddress] ,[AD_OptionalAddress],[AD_LandLineNo],[AD_OfficeNo],[AD_MobileNo],[AD_MobileOptionalNo],[AD_EmailId],[AD_PinCode],[AD_ZipCode],[AD_CountryId],[AD_StateId],[AD_CityId],[AD_AddressDate],[AD_Status] from [Sheet1$]", excelConnection);
           // OleDbCommand cmd = new OleDbCommand("Select [SA_ApplicationId],[SA_StudentPNRId],[SA_FirstName] ,[SA_MiddleName] ,[SA_LastName],[SA_DateOfBirth],[SA_PlaceOfBirth],[SA_AcadamicYear],[SA_BloodGroup],[SA_StudentImage],[SA_Nationality],[SA_Gender],[SA_Caste],[SA_SubCaste],[SA_DateOfApplication],[SA_MotherTounge],[SA_SchoolCategoryId] ,[SA_TransportStatus] ,[SA_MedicalProblem],[SA_LastSchoolAttended],[SA_LastClassAttended],[SA_LastClassPer],[SA_FatherFullName],[SA_FatherPhoto],[SA_FatherEduQualification],[SA_FatherOccupation],[SA_FatherAddressId],[SA_FatherOrgName],[SA_FatherDsgtName],[SA_MotherFullName],[SA_MotherPhoto],[SA_MotherEduQualification],[SA_MotherOccupation],[SA_MotherAddressId],[SA_MotherOrgName],[SA_MotherDsgtName] ,[SA_AddressId] ,[SA_AgeProof],[SA_LastProgressReportCard],[SA_OriginalSchoolLC],[SA_PassportAndVisa],[SA_RegistrationLetter],[SA_ApplicationStatus],[SA_Status] from [Sheet1$]", excelConnection);
            //OleDbCommand cmd = new OleDbCommand("Select [UL_LoginId],[UL_UserName],[UL_UserPassword],[UL_EmailId],[UL_UserType],[UL_CreatedBy],[UL_ModifiedBy],[UL_CreatedDate],[UL_ModifiedDate],[UL_LastLoginDate],[UL_Status] from [Sheet1$]", excelConnection);
            OleDbCommand cmd = new OleDbCommand("Select [FD_FacultyDetailsId],[FD_LoginId],[FD_FacultyId],[FD_SchoolCatgoryId],[FD_Title],[FD_FirstName],[FD_MiddleName],[FD_LastName],[FD_Date],[FD_Caste],[FD_SubCaste],[FD_BirthPlace],[FD_BloodGroup],[FD_MotherTounge],[FD_Nationality],[FD_TransportStatus],[FD_MedicalProblem],[FD_SchoolCategoryId],[FD_SchoolSubCategoryId],[FD_SubjectId],[FD_InterestPosition],[FD_CertifiedSubject],[FD_CertifiedAgeGroup],[FD_FullTimeTeaching],[FD_IndustryExpertise],[FD_SpecificExpertise],[FD_HighestDegreeCompletd],[FD_FieldOfStudy],[FD_University],[FD_CompletionDate],[FD_AddressId],[FD_QualificationDetails],[FD_ExperienceFrom],[FD_ExperienceTo],[FD_ExperienceInYrs],[FD_Image],[FD_JoiningDate],[FD_BirthDate],[FD_Gender],[FD_MarrialStatus],[FD_AgeProof],[FD_Resume],[FD_ReleavingLetter],[FD_RetiredOn],[FD_ExtraOne],[FD_CreatedBy],[FD_LastSchoolwas],[FD_LastSchoolFromDate],[FD_LastSchoolToDate],[FD_Status] from [Sheet1$]", excelConnection);
            excelConnection.Open();
            OleDbDataReader dReader;
            dReader = cmd.ExecuteReader();
            SqlBulkCopy sqlBulk = new SqlBulkCopy(strConnection);
            //Give your Destination table name
            //sqlBulk.DestinationTableName = "TMS_AddressDetails";
            sqlBulk.DestinationTableName = "TMS_FacultyDetails";
            //sqlBulk.DestinationTableName = "TMS_UserLogin";
            sqlBulk.WriteToServer(dReader);
            excelConnection.Close();
        }
    }
}
