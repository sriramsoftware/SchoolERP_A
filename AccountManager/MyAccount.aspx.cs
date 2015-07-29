using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class TMSchoolMgmt_AccountManager_MyAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }
        else
        {


            if (!IsPostBack)
            {


                if ((Session["AccountID"] != null) && (Session["type"] != null))
                {
                    string types = Session["type"].ToString();

                    if (types == "Teacher")
                    {
                        aTeachersDetaitls.Attributes.Add("class", "active");
                        aStaffDetails.Attributes.Add("class", "");
                        //aPrincipalDetails.Attributes.Add("class", "");
                    }
                    else
                    {
                        aTeachersDetaitls.Attributes.Add("class", "");
                        aStaffDetails.Attributes.Add("class", "active");
                       // aPrincipalDetails.Attributes.Add("class", "");
                        general.Visible = false;
                        totalexp.Visible = false;
                        dlfx.Visible = false;

                    }
                }

                BindTeacherDetails();
            }
        }
    }


    protected void BindTeacherDetails()
    {
        try
        {
            Int64 UserId = Convert.ToInt64(Session["AccountID"]);
            DataTable dtFaculty = TMSFacultyDetails.GetStaffFacultyDetails(null, Convert.ToInt64(Session["FacultyType"]), UserId).Tables[0];
            if (dtFaculty.Rows.Count > 0)
            {
                lblFullName.Text = dtFaculty.Rows[0]["FD_FirstName"].ToString() + " " + dtFaculty.Rows[0]["FD_MiddleName"].ToString() + " " + dtFaculty.Rows[0]["FD_LastName"].ToString();
                if (dtFaculty.Rows[0]["FD_Image"] != null)
                {
                    imasdfdsg.ImageUrl = dtFaculty.Rows[0]["FD_Image"].ToString();
                }
                lblEduDetail.Text = dtFaculty.Rows[0]["FD_HighestDegreeCompletd"].ToString() + "-" + dtFaculty.Rows[0]["FD_SpecificExpertise"].ToString() + " " + dtFaculty.Rows[0]["FD_CompletionDate"].ToString();
                lblAddress.Text = dtFaculty.Rows[0]["FacultyPerAdd"].ToString();
                lblnationality.Text = dtFaculty.Rows[0]["FD_Nationality"].ToString();
                lblgender.Text = dtFaculty.Rows[0]["FD_Gender"].ToString();
                lblmotherLong.Text = dtFaculty.Rows[0]["FD_MotherTounge"].ToString();
                lblmedicolprm.Text = dtFaculty.Rows[0]["FD_MedicalProblem"].ToString();
                lblbirthPlace.Text = dtFaculty.Rows[0]["FD_BirthPlace"].ToString();
                lblbloodgroup.Text = dtFaculty.Rows[0]["FD_BloodGroup"].ToString();
                lblcast.Text = dtFaculty.Rows[0]["FD_Caste"].ToString();
                lblsubcast.Text = dtFaculty.Rows[0]["FD_SubCaste"].ToString();
                if (dtFaculty.Rows[0]["FD_HighestDegreeCompletd"].ToString() != "-1")
                {
                    lblhighestDegree.Text = dtFaculty.Rows[0]["FD_HighestDegreeCompletd"].ToString();
                }
                if (dtFaculty.Rows[0]["FD_CompletionDate"].ToString() != "Select")
                {
                    lblcomplicationDateofHigherDegree.Text = dtFaculty.Rows[0]["FD_CompletionDate"].ToString();
                }
                lbluniversity.Text = dtFaculty.Rows[0]["FD_University"].ToString();
                if ((dtFaculty.Rows[0]["FD_ExperienceFrom"] != null) && (dtFaculty.Rows[0]["FD_ExperienceTo"] != null))
                {
                    lblexpyears.Text = dtFaculty.Rows[0]["FD_ExperienceTo"].ToString() + "  Year";
                    lblexperience.Text = dtFaculty.Rows[0]["FD_ExperienceTo"].ToString() + "  Year" + "  " + dtFaculty.Rows[0]["FD_ExperienceFrom"].ToString() + "   Month";
                }
                else if ((dtFaculty.Rows[0]["FD_ExperienceFrom"] != null) && (dtFaculty.Rows[0]["FD_ExperienceTo"] == null))
                {
                    lblexperience.Text = dtFaculty.Rows[0]["FD_ExperienceFrom"].ToString() + "  Year";
                    lblexpyears.Text = dtFaculty.Rows[0]["FD_ExperienceFrom"].ToString() + "  Year";
                }
              //  lblspeciolisation.Text = dtFaculty.Rows[0]["FD_SpecificExpertise"].ToString();
                if (dtFaculty.Rows[0]["ClassName"] != null)
                {
                    string Classname = dtFaculty.Rows[0]["ClassName"].ToString();

                    if (Classname != "")
                    {
                        lblstandard.Text = Classname.Remove(Classname.Length - 1, 1);
                    }
                }

                if (dtFaculty.Rows[0]["SubjectName"] != null)
                {
                    string SubjectName = dtFaculty.Rows[0]["SubjectName"].ToString();
                    if (SubjectName != "")
                    {
                        lblsubject.Text = SubjectName.Remove(SubjectName.Length - 1, 1);
                    }

                }
             //   lblusingtransport.Text = dtFaculty.Rows[0]["FD_TransportStatus"].ToString();


            }

        }
        catch (Exception ex) { }

    }
}