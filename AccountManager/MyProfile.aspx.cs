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
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Web.Services;

public partial class TMSchoolMgmt_AccountManager_MyProfile : System.Web.UI.Page
{
    Helper help = new Helper();
    protected void Page_Load(object sender, EventArgs e)
    {
        ((System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("MyProfile")).Attributes.Add("class", "Liactive");
        ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("ListMyAccount")).Style.Add("display","block");
        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }
        else
        {
            if (!IsPostBack)
            {
                SectionEditProfile.Visible = false;
                SectionViewProfile.Visible = true;
                fillCountry();
                BindState();
                BindCity();
               // fillQualification();
                fillCompletedYear();
                BindAccountManagerDetails();
            }
        }
    }
    protected void BindAccountManagerDetails()
    {
        try
        {
            Int64 UserId = Convert.ToInt64(Session["UserId"]);
            DataTable dtFaculty = TMSFacultyDetails.GetStaffFacultyDetails(null, 7, UserId).Tables[0];
            if (dtFaculty.Rows.Count > 0)
            {
                Int64 FacultyId = Convert.ToInt64(dtFaculty.Rows[0]["FD_FacultyDetailsId"]);
                DataTable dtAccount = TMSFacultyDetails.GetStaffFacultyDetails(FacultyId, 7, UserId).Tables[0];

                if (dtAccount.Rows.Count > 0)
                {
                    lblFullName.Text = dtAccount.Rows[0]["FD_FirstName"].ToString() + " " + dtAccount.Rows[0]["FD_MiddleName"].ToString() + " " + dtAccount.Rows[0]["FD_LastName"].ToString();
                    Image1.ImageUrl = dtAccount.Rows[0]["FD_Image"].ToString();
                    lblDOB.Text = String.Format("{0:dd MMM yyyy}", dtAccount.Rows[0]["FD_BirthDate"]);// (Convert.ToString(objstudappl.StdaDob))("MM/dd/yyyy"); 
                    lblNationality.Text = dtAccount.Rows[0]["FD_Nationality"].ToString();
                    lblGender.Text = dtAccount.Rows[0]["FD_Gender"].ToString();
                    lblMotherTongue.Text = dtAccount.Rows[0]["FD_MotherTounge"].ToString();
                    lblMedicalproblems.Text = dtAccount.Rows[0]["FD_MedicalProblem"].ToString();
                    lblBithPlace.Text = dtAccount.Rows[0]["FD_BirthPlace"].ToString();
                    lblBloodGroup.Text = dtAccount.Rows[0]["FD_BloodGroup"].ToString();
                    lblCaste.Text = dtAccount.Rows[0]["FD_Caste"].ToString();
                    lblSubcaste.Text = dtAccount.Rows[0]["FD_SubCaste"].ToString();
                    lblDOJ.Text = String.Format("{0:dd MMM yyyy}", dtAccount.Rows[0]["FD_JoiningDate"]);
                    lblHihestDegree.Text = dtAccount.Rows[0]["FD_HighestDegreeCompletd"].ToString();
                    lblCopleteYear.Text = dtAccount.Rows[0]["FD_CompletionDate"].ToString();
                    lblUniversity.Text = dtAccount.Rows[0]["FD_University"].ToString();
                    lblLastSchoolWas.Text = dtAccount.Rows[0]["FD_LastSchoolwas"].ToString();
                    lblLastSchoolFrom.Text = dtAccount.Rows[0]["FD_LastSchoolFromDate"].ToString();
                    if (lblLastSchoolFrom.Text != "")
                    {
                        string[] s = lblLastSchoolFrom.Text.Split(' ');
                        lblLastSchoolFrom.Text = String.Format("{0:dd MMM yyyy}", Convert.ToDateTime(s[0]));
                    }
                    lblLastSchoolTo.Text = dtAccount.Rows[0]["FD_LastSchoolToDate"].ToString();
                    if (lblLastSchoolTo.Text != "")
                    {
                        string[] s = lblLastSchoolTo.Text.Split(' ');
                        lblLastSchoolTo.Text = String.Format("{0:dd MMM yyyy}", Convert.ToDateTime(s[0]));
                    }
                    lblTotalExpInMonth.Text = dtAccount.Rows[0]["FD_ExperienceFrom"].ToString();
                    lblTotalExpInYear.Text = dtAccount.Rows[0]["FD_ExperienceTo"].ToString();
                    lblSpecialization.Text = dtAccount.Rows[0]["FD_SpecificExpertise"].ToString();
                    //***Mother Details
                    //***Residance Details
                    lblAddress.Text = dtAccount.Rows[0]["FacultyPerAdd"].ToString();
                    lblmobileNo.Text = dtAccount.Rows[0]["FacultyMobNo"].ToString();
                    lblResidencePhone.Text = dtAccount.Rows[0]["FacultyResNo"].ToString();
                    lblEmailID.Text = dtAccount.Rows[0]["FacultyEmailId"].ToString();
                    lblCountry.Text = dtAccount.Rows[0]["FacultyCountry"].ToString();
                    lblState.Text = dtAccount.Rows[0]["FacultyState"].ToString();
                    lblCity.Text = dtAccount.Rows[0]["FacultyCity"].ToString();
                    lblPin.Text = dtAccount.Rows[0]["FacultyPinCode"].ToString();
                    //***Residance Details
                }
            }
        }
        catch (Exception ex) { }
    }
    protected void fillCountry()
    {
        try
        {
            DataTable Dtaable = TMSCountry.GetSearch(null, null, null).Tables[0];
            DataView Dv = new DataView(Dtaable);
            Dv.Sort = ("CNTR_Country ASC");
            ddlCountry.DataSource = Dtaable;
            ddlCountry.DataTextField = "CNTR_Country";
            ddlCountry.DataValueField = "CNTR_Id";
            ddlCountry.DataBind();
            ddlCountry.Items.Insert(0, new ListItem("Select", "-1"));
            DataTable dtSubject = TMSSpeciallizationSubject.GetSearch(null, null, null, 1).Tables[0];
            DataView Dv1 = new DataView(dtSubject);
            Dv1.Sort = ("SB_SubjectName ASC");
            ddlSpeciallization.DataSource = dtSubject;
            ddlSpeciallization.DataTextField = "SB_SubjectName";
            ddlSpeciallization.DataValueField = "SB_SubjectId";
            ddlSpeciallization.DataBind();
            ddlSpeciallization.Items.Insert(0, new ListItem("Select", "Select"));
            //ddlSpeciallization.Items.Add(new ListItem("Select", "-1"));
        }
        catch (Exception ex) { }
    }
    //protected void fillQualification()
    //{
    //    try
    //    {
    //        DataTable Dtaable = TMSQualification.GetSearch(null, null, 1).Tables[0];
    //        DataView Dv = new DataView(Dtaable);
    //        Dv.Sort = ("QUAL_Qualification ASC");
    //        ddlHighestDegree.DataSource = Dv;
    //        ddlHighestDegree.DataTextField = "QUAL_Qualification";
    //        ddlHighestDegree.DataValueField = "QUAL_Qualification";
    //        ddlHighestDegree.DataBind();
    //        ddlHighestDegree.Items.Insert(0, new ListItem("Select", "-1"));
    //    }
    //    catch (Exception ex)
    //    { }
    //}
    protected void fillCompletedYear()
    {
        ddlCompletedYear.Items.Clear();
        ddlCompletedYear.Items.Add("Select");
        for (int i = DateTime.Today.Year; i >= 1950; i--)
        {
            ddlCompletedYear.Items.Add(i.ToString());
        }
    }
    protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            BindState();
        }
        catch (Exception ex) { }
    }
    protected void BindState()
    {
        try
        {
            string country = null;
            if (ddlCountry.SelectedValue != "-1")
            {
                DataTable Dtaable = TMSState.GetSearch(null, Convert.ToInt32(ddlCountry.SelectedValue), null, 1).Tables[0];
                DataView Dv = new DataView(Dtaable);
                Dv.Sort = ("ST_State ASC");
                ddlState.DataSource = Dtaable;
                ddlState.DataTextField = "ST_State";
                ddlState.DataValueField = "ST_Id";
                ddlState.DataBind();
                ddlState.Items.Insert(0, new ListItem("Select", "0"));
            }
            else
            {
                DataTable Dtaable = TMSState.GetSearch(null, Convert.ToInt32(country), null, 1).Tables[0];
                DataView Dv = new DataView(Dtaable);
                Dv.Sort = ("ST_State ASC");
                ddlState.DataSource = Dtaable;
                ddlState.DataTextField = "ST_State";
                ddlState.DataValueField = "ST_Id";
                ddlState.DataBind();
                ddlState.Items.Insert(0, new ListItem("Select", "0"));
            }
        }
        catch (Exception ex) { }
    }
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            BindCity();
        }
        catch (Exception ex) { }
    }
    protected void BindCity()
    {
        try
        {
            string state = null;
            if (ddlState.SelectedValue != "-1")
            {
                DataTable Dtaable = TMSCity.GetSearch(null, Convert.ToInt32(ddlState.SelectedValue), null, 1).Tables[0];
                DataView Dv = new DataView(Dtaable);
                Dv.Sort = ("CT_City ASC");
                ddlCity.DataSource = Dtaable;
                ddlCity.DataTextField = "CT_City";
                ddlCity.DataValueField = "CT_Id";
                ddlCity.DataBind();
                ddlCity.Items.Insert(0, new ListItem("Select", "0"));
            }
            else
            {
                DataTable Dtaable = TMSCity.GetSearch(null, Convert.ToInt32(state), null, 1).Tables[0];
                DataView Dv = new DataView(Dtaable);
                Dv.Sort = ("CT_City ASC");
                ddlCity.DataSource = Dtaable;
                ddlCity.DataTextField = "CT_City";
                ddlCity.DataValueField = "CT_Id";
                ddlCity.DataBind();
                ddlCity.Items.Insert(0, new ListItem("Select", "0"));
            }
        }
        catch (Exception ex) { }

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            string ImageE = EditGetImage();
            if (ImageE == "Ext")
            {
                dvMsg.Visible = true;
                lblMessage.Text = "InValid File Format";
                dvMsg.Attributes.Add("class", "error_msg");
            }
            else
            {

                Int64 UserId = Convert.ToInt64(Session["UserId"]);
                DataTable dtFaculty = TMSFacultyDetails.GetStaffFacultyDetails(null, 7, UserId).Tables[0];
                if (dtFaculty.Rows.Count > 0)
                {
                    Int64 FacultyId = Convert.ToInt64(dtFaculty.Rows[0]["FD_FacultyDetailsId"]);
                    TMSFacultyDetails objFaculty = TMSFacultyDetails.Get(FacultyId);
                    if (objFaculty != null)
                    {
                        objFaculty.FDFirstName = txtFullName.Text;
                        objFaculty.FDBirthPlace = txtBithPlace.Text;
                        objFaculty.FDBirthDate = Convert.ToDateTime(txtDOB.Text);
                        objFaculty.FDBloodGroup = ddlBloddGroup.SelectedValue;
                        objFaculty.FDNationality = txtNationality.Text;
                        objFaculty.FDCaste = txtCaste.Text;
                        objFaculty.FDSubCaste = txtSubcaste.Text;
                        objFaculty.FDGender = ddlGender.SelectedValue;
                        objFaculty.FDMotherTongue = txtMotherTongue.Text;
                        objFaculty.FDMedicalProblem = txtMedicalproblems.Text;
                        if (txtDOJ.Text != "")
                        {
                            objFaculty.FDJoiningDate = Convert.ToDateTime(txtDOJ.Text);
                        }
                        else
                        {
                            objFaculty.FDJoiningDate = null;
                        }
                        //objFaculty.FDHighestDegreeCompletd = ddlHighestDegree.SelectedValue;
                        objFaculty.FDHighestDegreeCompletd = txtHeighestDegree.Text;
                        objFaculty.FDSpecificExpertise = ddlSpeciallization.SelectedItem.Text;
                        objFaculty.FDCompletionDate = ddlCompletedYear.SelectedValue;
                        objFaculty.FDUniversity = txtUniversity.Text;
                        objFaculty.FDLastSchoolwas = txtLastSchoolWas.Text;
                        if (txtLastSchoolFrom.Text != "")
                        {
                            objFaculty.FDLastSchoolFromDate = Convert.ToDateTime(txtLastSchoolFrom.Text);
                        }
                        if (txtLastSchoolTo.Text != "")
                        {
                            objFaculty.FDLastSchoolToDate = Convert.ToDateTime(txtLastSchoolTo.Text);
                        }
                        objFaculty.FDExperienceTo = txtTotalExpInYear.Text;
                        objFaculty.FDExperienceFrom = txtTotalExpInMonth.Text;
                        objFaculty.FDImage = ImageE;
                        objFaculty.Update();
                        Int64 AddressId = Convert.ToInt64(objFaculty.FDAddressId);
                        TMSAddressDetails objAddressDetails = TMSAddressDetails.Get(AddressId);
                        if (objAddressDetails != null)
                        {
                            objAddressDetails.ADPermanentAddress = txtAddress.Text.Trim();
                            if (!string.IsNullOrEmpty(ddlCity.SelectedValue))
                            {
                                objAddressDetails.ADCityId = Convert.ToInt64(ddlCity.SelectedValue);
                            }
                            if (!string.IsNullOrEmpty(ddlCountry.SelectedValue))
                            {
                                objAddressDetails.ADCountryId = Convert.ToInt64(ddlCountry.SelectedValue);
                            }
                            if (!string.IsNullOrEmpty(ddlState.SelectedValue))
                            {
                                objAddressDetails.ADStateId = Convert.ToInt64(ddlState.SelectedValue);
                            }
                            objAddressDetails.ADEmailId = txtEmailID.Text.Trim();
                            objAddressDetails.ADMobileNo = txtmobileNo.Text.Trim();
                            objAddressDetails.ADPinCode = txtPin.Text.Trim();
                            objAddressDetails.ADLandLineNo = txtResidencePhone.Text;
                            objAddressDetails.Update();
                        }
                        TMSUserLogin objLogin = TMSUserLogin.Get(Convert.ToInt64(Session["UserId"]));
                        if (objLogin != null)
                        {
                           //objLogin.ULUserName = txtEmailID.Text.Trim();
                            objLogin.ULEmailId = txtEmailID.Text.Trim();
                            objLogin.Update();
                        }
                        BindAccountManagerDetails();
                        SectionEditProfile.Visible = false;
                        SectionViewProfile.Visible = true;
                        dvMsg.Visible = true;
                        lblMessage.Text = "Profile Is Updated Successfully";
                        dvMsg.Attributes.Add("class", "warring_msg");
                    }
                }
            }
        }
        catch (Exception ex) { }
    }
    protected void btnCancelOne_Click(object sender, EventArgs e)
    {
        // Response.Redirect("DashboardTeacher.aspx");
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        try
        {
            btnSave.Text = "Update";
            SectionEditProfile.Visible = true;
            SectionViewProfile.Visible = false;
            fillCountry();
            BindState();
            BindCity();
            //fillQualification();
            fillCompletedYear();
            Int64 UserId = Convert.ToInt64(Session["UserId"]);
            DataTable dtFaculty = TMSFacultyDetails.GetStaffFacultyDetails(null, 7, UserId).Tables[0];
            if (dtFaculty.Rows.Count > 0)
            {
                Int64 FacultyId = Convert.ToInt64(dtFaculty.Rows[0]["FD_FacultyDetailsId"]);
                TMSFacultyDetails objFaculty = TMSFacultyDetails.Get(FacultyId);
                if (objFaculty != null)
                {
                    txtFullName.Text = objFaculty.FDFirstName ;
                    txtMiddleName.Text = objFaculty.FDMiddleName;
                    txtLatName.Text=objFaculty.FDLastName;
                    txtBithPlace.Text = objFaculty.FDBirthPlace;
                    txtDOB.Text = String.Format("{0:MM/dd/yyyy}", objFaculty.FDBirthDate);
                    ddlBloddGroup.SelectedValue = Convert.ToString(objFaculty.FDBloodGroup);
                    txtNationality.Text = objFaculty.FDNationality;
                    txtCaste.Text = objFaculty.FDCaste;
                    txtSubcaste.Text = objFaculty.FDSubCaste;
                    ddlGender.SelectedValue = objFaculty.FDGender;
                    txtMotherTongue.Text = objFaculty.FDMotherTongue;
                    txtMedicalproblems.Text = objFaculty.FDMedicalProblem;
                    if (objFaculty.FDJoiningDate != null)
                    {
                        txtDOJ.Text = String.Format("{0:MM/dd/yyyy}", objFaculty.FDJoiningDate);
                    }
                    if (objFaculty.FDHighestDegreeCompletd != null)
                    {
                        //ddlHighestDegree.SelectedValue = objFaculty.FDHighestDegreeCompletd;
                        txtHeighestDegree.Text = objFaculty.FDHighestDegreeCompletd.ToString(); ;
                    }
                    if (objFaculty.FDSpecificExpertise != "")
                    {
                        ddlSpeciallization.SelectedItem.Text = objFaculty.FDSpecificExpertise;
                    }
                    if (objFaculty.FDCompletionDate != "")
                    {
                        ddlCompletedYear.SelectedValue = objFaculty.FDCompletionDate;
                    }
                    txtUniversity.Text = objFaculty.FDUniversity;

                    txtLastSchoolWas.Text = objFaculty.FDLastSchoolwas;

                    if (objFaculty.FDLastSchoolFromDate != null)
                    {
                        txtLastSchoolFrom.Text = String.Format("{0:MM/dd/yyyy}", objFaculty.FDLastSchoolFromDate);
                    }
                    if (objFaculty.FDLastSchoolToDate != null)
                    {
                        txtLastSchoolTo.Text = String.Format("{0:MM/dd/yyyy}", objFaculty.FDLastSchoolToDate);
                    }
                    txtTotalExpInYear.Text = objFaculty.FDExperienceTo;
                    txtTotalExpInMonth.Text = objFaculty.FDExperienceFrom;

                    Int64 AddressId = Convert.ToInt64(objFaculty.FDAddressId);
                    TMSAddressDetails objAddress = TMSAddressDetails.Get(AddressId);
                    if (objAddress != null)
                    {
                        txtAddress.Text = objAddress.ADPermanentAddress;
                        txtmobileNo.Text = objAddress.ADMobileNo;
                        txtResidencePhone.Text = objAddress.ADLandLineNo;
                        txtPin.Text = objAddress.ADPinCode;
                        txtEmailID.Text = objAddress.ADEmailId;
                        ddlCountry.SelectedValue = objAddress.ADCountryId.ToString();
                        BindState();
                        ddlState.SelectedValue = objAddress.ADStateId.ToString();
                        BindCity();
                        ddlCity.SelectedValue = objAddress.ADCityId.ToString();
                    }
                    Image2.Visible = true;
                    Image2.ImageUrl = objFaculty.FDImage;
                    Session["Image"] = objFaculty.FDImage;
                }
            }
        }
        catch (Exception ex) { }
    }
    public string EditGetImage()
    {
        string fileExist;
        string FilePath = "";
        string LogoPath = "";
        FileUpload img = FileUpload1;
        // FileUpload file_name = FileUpload1;
        string strFileNameWithPath = FileUpload1.PostedFile.FileName;
        string strExtensionName = System.IO.Path.GetExtension(strFileNameWithPath);
        string OldImage = Session["Image"].ToString();
        string strFileName = System.IO.Path.GetFileName(strFileNameWithPath).Replace(OldImage, strFileNameWithPath);
        if (strFileName.Equals(""))
        {
            if (strFileNameWithPath == "")
            {
                FilePath = OldImage;
                return FilePath;
            }
            else
            {
                FilePath = strFileNameWithPath;
                return FilePath;
            }
        }
        else
        {
            strExtensionName = strExtensionName.ToLower();
            if (strExtensionName.Equals(".jpg") || strExtensionName.Equals(".jpeg") || strExtensionName.Equals(".bmp") || strExtensionName.Equals(".png") || strExtensionName.Equals(".gif"))
            {
                if (!Directory.Exists(Server.MapPath(@"..\\UploadImages\\FacultyPhoto\\")))
                {
                    Directory.CreateDirectory(Server.MapPath(@"..\\UploadImages\\FacultyPhoto\\"));
                }
                fileExist = "../UploadImages/FacultyPhoto/" + strFileName;
                if (File.Exists(Server.MapPath(fileExist)))
                {
                    strFileName = "../UploadImages/FacultyPhoto/" + "User" + DateTime.Now.ToString("dd.MM.yyyy hh.ss.mm") + strExtensionName;
                    FileUpload1.PostedFile.SaveAs(Server.MapPath(strFileName));
                    FilePath = strFileName;
                    return FilePath;
                }
                else
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath(fileExist));
                    FilePath = fileExist;
                    return FilePath;
                }
                //FileUpload1.PostedFile.SaveAs(Server.MapPath(@"..\\UploadImages\\NewsImages\\" + strFileName));
                //FileUpload1.PostedFile.SaveAs(Server.MapPath(strFileName));
                //FilePath = strFileName;
                //return FilePath;
            }
            else
                return "Ext";
        }
    }
}
