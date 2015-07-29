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

public partial class Teacher_holidaycalender : System.Web.UI.Page
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
                fillHolidayCalender();
            }
        }
    }
    protected void fillHolidayCalender()
    {
        try
        {
            DataTable dtable = new DataTable();
            dtable = TMSHolidayCalender.Getholidaydata().Tables[0];
            if (dtable.Rows.Count > 0)
            {
                if (dtable.Rows.Count > 0)
                {
                    lbllyear.Text = dtable.Rows[0]["HC_year"].ToString();
                    listHolidaycalender.DataSource = dtable;
                    listHolidaycalender.DataBind();
                }
            }

        }
        catch (Exception ex) { }
    }
}
