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

public partial class TMSchoolMgmt_AccountManager_StaffDetails : System.Web.UI.Page
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
                HiddenID.Value = "4";
                aTransportation.Attributes.Add("class", "active");
                aVendor.Attributes.Add("class", "");
                aAccountant.Attributes.Add("class", "");
                aManagement.Attributes.Add("class", "");
                BindStaffDetails();

            }
        }
    }

    protected void Transportation_Click(object sender, EventArgs e)
    {
        HiddenID.Value = "4";
        BindStaffDetails();
        aTransportation.Attributes.Add("class", "active");
        aLibrarian.Attributes.Add("class", "");
        aVendor.Attributes.Add("class", "");
        aAccountant.Attributes.Add("class", "");
        aManagement.Attributes.Add("class", "");
    }

    protected void Librarian_Click(object sender, EventArgs e)
    {
        HiddenID.Value = "6";
        BindStaffDetails();
        aLibrarian.Attributes.Add("class", "active");
        aTransportation.Attributes.Add("class", "");
        aVendor.Attributes.Add("class", "");
        aAccountant.Attributes.Add("class", "");
        aManagement.Attributes.Add("class", "");
    }

    protected void Vendor_Click(object sender, EventArgs e)
    {
        HiddenID.Value = "5";
        BindStaffDetails();
        aTransportation.Attributes.Add("class", "");
        aLibrarian.Attributes.Add("class", "");
        aVendor.Attributes.Add("class", "active");
        aAccountant.Attributes.Add("class", "");
        aManagement.Attributes.Add("class", "active");

    }
    protected void Accountant_Click(object sender, EventArgs e)
    {
        HiddenID.Value = "7";
        BindStaffDetails();
        aTransportation.Attributes.Add("class", "");
        aLibrarian.Attributes.Add("class", "");
        aVendor.Attributes.Add("class", "");
        aAccountant.Attributes.Add("class", "active");
        aManagement.Attributes.Add("class", "");
    }

    protected void Management_Click(object sender, EventArgs e)
    {
        HiddenID.Value = "1";
        BindPrincipalDetails();
        aTransportation.Attributes.Add("class", "");
        aLibrarian.Attributes.Add("class", "");
        aVendor.Attributes.Add("class", "");
        aAccountant.Attributes.Add("class", "");
        aManagement.Attributes.Add("class", "active");
    }

    protected void BindStaffDetails()
    {
        DataTable dtstaffDetails = TMSFacultyDetails.GetSearchStaffFacultyDetails(null, null, "Staff", Convert.ToInt64(HiddenID.Value)).Tables[0];
        ListStaff.DataSource = dtstaffDetails;
        ListStaff.DataBind();

    }

    protected void BindPrincipalDetails()
    {
        try
        {
            DataTable dt = null;

            dt = TMSFacultyDetails.GetStaffFacultyDetails(null, 1, null).Tables[0];

            if (dt.Rows.Count > 0)
            {
                ListStaff.DataSource = dt;
                ListStaff.DataBind();
            }
            else
            {
                ListStaff.DataSource = null;
                ListStaff.DataBind();
            }
        }
        catch { }
    }
    protected void ListStaff_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        try
        {
            Label lblCompleteYear = (Label)e.Item.FindControl("lblCompleteYear");
            if (lblCompleteYear.Text != "")
            {
                lblCompleteYear.Text = "-(" + lblCompleteYear .Text+ ")";
            }

        }
        catch (Exception) { }
    }
}
