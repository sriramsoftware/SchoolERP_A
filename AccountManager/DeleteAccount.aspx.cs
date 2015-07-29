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

public partial class TMSchoolMgmt_AccountManager_DeleteAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ((System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("Account")).Attributes.Add("class", "Liactive");
        ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("ListMyAccount")).Style.Add("display", "block");

        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }
    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        try
        {
            int status = TMSFacultyDetails.DeleteAccount(Convert.ToInt64(Session["UserId"]));
            if (status.ToString() == "-1")
            {
                Response.Redirect("../Default.aspx?var=Logout");
            }
        }
        catch (Exception ex) { }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccountManagerDashboard.aspx");
    }
}
