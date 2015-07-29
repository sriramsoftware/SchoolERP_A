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

public partial class TMSchoolMgmt_AccountManager_Leavedetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ((System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("LeaveDetails")).Attributes.Add("class", "Liactive");
        ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("ListMyAccount")).Style.Add("display", "block");
        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }
        if (!IsPostBack)
        {

            GetLeaveDetails();
        }
    }

    protected void GetLeaveDetails()
    {
        try
        {

            DataTable dt = TMSLeaveDetails.GetLeaveDetailsBytype(Convert.ToInt64(Session["UserId"]), "Staff").Tables[0];

            if (dt.Rows.Count > 0)
            {
                
                if (dt.Rows[0]["LD_CasualLeave"].ToString() != "")
                {
                    lblcasualLeave.Text = dt.Rows[0]["LD_CasualLeave"].ToString();

                }

                if (dt.Rows[0]["LD_EarnedLeave"].ToString() != "")
                {
                    lblEarnedLeave.Text = dt.Rows[0]["LD_EarnedLeave"].ToString();

                }

                if (dt.Rows[0]["LD_PaidLeave"].ToString() != "")
                {
                    lblPaidLeave.Text = dt.Rows[0]["LD_PaidLeave"].ToString();

                }

                if (dt.Rows[0]["LD_SickLeave"].ToString() != "")
                {
                    lblseakleave.Text = dt.Rows[0]["LD_SickLeave"].ToString();

                }
                if (dt.Rows[0]["LD_MartialLeave"].ToString() != "")
                {
                    lblMaritalLeave.Text = dt.Rows[0]["LD_MartialLeave"].ToString();

                }

                if (dt.Rows[0]["LD_MartinityLeave"].ToString() != "")
                {
                    lblMaternityLeave.Text = dt.Rows[0]["LD_MartinityLeave"].ToString();

                }


            }
        }
        catch { }
    }
}
