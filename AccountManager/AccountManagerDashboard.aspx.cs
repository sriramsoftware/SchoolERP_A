using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class TMSchoolMgmt_AccountManager_AccountManagerDashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("../Default.aspx?var=Logout");
            }
            else
            {
                //HtmlGenericControl tb = (HtmlGenericControl)Master.FindControl("sprite1");
                //tb.Visible = false;
                //HtmlGenericControl tb2 = (HtmlGenericControl)Master.FindControl("sprite2");
                //tb2.Visible = false;
                getdetails();               
            }
        }
    }  
    public void getdetails()
    {
        if (Session["UserId"] != null)
        {
            try
            {
                DataSet ds = TMSFacultyDetails.GetAccountManagerDetails(Convert.ToInt32(Session["UserId"].ToString()));
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblschoolname.Text = ds.Tables[0].Rows[0]["FD_LastSchoolwas"].ToString();
                    lblteachername.Text = ds.Tables[0].Rows[0]["FD_FirstName"].ToString() + " " + ds.Tables[0].Rows[0]["FD_LastName"].ToString();
                    lblteacherQualification.Text = ds.Tables[0].Rows[0]["FD_HighestDegreeCompletd"].ToString() + " " + ds.Tables[0].Rows[0]["FD_SpecificExpertise"].ToString() + "(" + (Convert.ToInt64(ds.Tables[0].Rows[0]["FD_CompletionDate"].ToString()) - 1) + "-" + ds.Tables[0].Rows[0]["FD_CompletionDate"].ToString() + ")";
                    if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0]["FD_ExperienceTo"].ToString()))
                    {
                        //lblexperience.Text = ds.Tables[0].Rows[0]["FD_ExperienceTo"].ToString();
                    }
                    else
                    {
                        //lblexperience.Text ="0";
                    }
                    lbladdressNuber.Text = ds.Tables[0].Rows[0]["AD_PermanentAddress"].ToString();
                    lblcontactNumber.Text = ds.Tables[0].Rows[0]["AD_MobileNo"].ToString();
                    lblemailID.Text = ds.Tables[0].Rows[0]["AD_EmailId"].ToString();
                    if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0]["FD_LastSchoolFromDate"].ToString()) && !string.IsNullOrEmpty(ds.Tables[0].Rows[0]["FD_LastSchoolToDate"].ToString()))
                    {
                        DateTime dtf = Convert.ToDateTime(ds.Tables[0].Rows[0]["FD_LastSchoolFromDate"].ToString());
                        DateTime dtto = Convert.ToDateTime(ds.Tables[0].Rows[0]["FD_LastSchoolToDate"].ToString());
                        string monthfrom = dtf.ToString("MMM");
                        string monthto = dtto.ToString("MMM");
                        string FromDate = dtf.Year.ToString();
                        string Todate = dtto.Year.ToString();
                        int totalpastyear = (Convert.ToInt32(Todate)) - (Convert.ToInt32(FromDate));
                        lblpasttime.Text = monthfrom + " " + FromDate + "_" + monthto + " " + Todate;
                        lblpastexpyear.Text = "("+totalpastyear.ToString() + "years)";
                    }
                }
            }
            catch(Exception){}
        }
    }
}