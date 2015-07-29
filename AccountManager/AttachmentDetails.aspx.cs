using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class TMSchoolMgmt_AccountManager_AttachmentDetails : System.Web.UI.Page
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
                BindTeacherDetails();
                if ((Session["AccountID"] != null) && (Session["type"] != null))
                {
                    string types = Session["type"].ToString();

                    if (types == "Teacher")
                    {
                        aTeachersDetaitls.Attributes.Add("class", "active");
                        aStaffDetails.Attributes.Add("class", "");
                       // aPrincipalDetails.Attributes.Add("class", "");
                    }
                    else
                    {
                        aTeachersDetaitls.Attributes.Add("class", "");
                        aStaffDetails.Attributes.Add("class", "active");
                        //aPrincipalDetails.Attributes.Add("class", "");

                    }
                }

            }
        }

    }

    protected void BindTeacherDetails()
    {
        try
        {
            if ((Session["AccountID"] != null) && (Session["FacultyType"] != null))
            {

                Int64 UserId = Convert.ToInt64(Session["AccountID"]);
                DataTable dtFaculty = TMSFacultyDetails.GetStaffFacultyDetails(null, Convert.ToInt64(Session["FacultyType"]), UserId).Tables[0];
                if (dtFaculty.Rows.Count > 0)
                {

                    if (dtFaculty.Rows[0]["FD_AgeProof"].ToString() != "AGEPROOF")
                    {
                        string[] dd = dtFaculty.Rows[0]["FD_AgeProof"].ToString().Split('/');
                        hyperAge.Text = dd[2].ToString();
                        hyperAge.NavigateUrl = dtFaculty.Rows[0]["FD_AgeProof"].ToString();
                    }
                    else
                    {

                        hyperAge.Text = dtFaculty.Rows[0]["FD_AgeProof"].ToString();
                    }
                    if (dtFaculty.Rows[0]["FD_Image"] != null)
                    {
                        string[] dd = dtFaculty.Rows[0]["FD_Image"].ToString().Split('/');
                        hyperPassphoto.Text = dd[3].ToString();
                        hyperPassphoto.NavigateUrl = dtFaculty.Rows[0]["FD_Image"].ToString();
                    }


                    if (dtFaculty.Rows[0]["FD_ReleavingLetter"].ToString() != "ReleavingLetter")
                    {
                        string[] dd = dtFaculty.Rows[0]["FD_ReleavingLetter"].ToString().Split('/');
                        hyperOleavingSchoolSertificate.Text = dd[2].ToString();
                        hyperOleavingSchoolSertificate.NavigateUrl = dtFaculty.Rows[0]["FD_ReleavingLetter"].ToString();
                    }
                    else
                    {
                        hyperOleavingSchoolSertificate.Text = dtFaculty.Rows[0]["FD_ReleavingLetter"].ToString();
                    }
                }

            }
        }
        catch (Exception ex) { }

    }
}