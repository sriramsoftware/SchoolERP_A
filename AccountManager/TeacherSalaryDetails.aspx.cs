using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class TMSchoolMgmt_AccountManager_TeacherSalaryDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }
        if (!IsPostBack)
        {
            ViewState["Sort"] = null;
            BindTeacterDetails();
        }
    }
    
    protected void BindTeacterDetails()
    {
        try
        {
            string SchoolType = null;
            string Name = null;
            SchoolType = "Pre-Primary";

            if (txtName.Text != "")
            {
                Name = txtName.Text;
            }
            else
            {
                Name = null;
            }
            DataTable dt = null;
            if (ViewState["Sort"] != null)
            {
                dt = TMSFacultyDetails.GetSearchStaffFacultyDetails(Name, SchoolType, "Teacher", null).Tables[0];
            }
            else
            {
                 dt = TMSFacultyDetails.GetSearchStaffFacultyDetails(null, SchoolType, "Teacher", null).Tables[0];
            }

            if (dt.Rows.Count > 0)
            {
                ListTeacher.DataSource = dt;
                ListTeacher.DataBind();
            }
            else
            {
                ListTeacher.DataSource = null;
                ListTeacher.DataBind();
            }
        }
        catch { }
    }
    protected void btnsort_Click(object sender, EventArgs e)
    {
        ViewState["Sort"] = "Sort";
        BindTeacterDetails();
    }
}