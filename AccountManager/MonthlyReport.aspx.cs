using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class TMSchoolMgmt_AccountManager_MonthlyReport : System.Web.UI.Page
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
            BindMonthlyDetails();
        }
    }

    private void BindMonthlyDetails()
    {
        string Month = null;
        string Year = null;

        if (ddlMonth.SelectedIndex <= 0)
        {
            Month = null;
        }
        else
        {
            Month = Convert.ToString(ddlMonth.SelectedItem.Text);
        }

        if (ddlYear.SelectedIndex <= 0)
        {
            Year = null;
        }
        else
        {
            Year = Convert.ToString(ddlYear.SelectedItem.Text);
        }

        DataTable dtMonthlyReport = TMSSalaryDetails.GetMonthlyExpenditureDetails(Month,Year).Tables[0];
        if (dtMonthlyReport.Rows.Count > 0)
        {
            lblEleAndWaterSupply.Text = dtMonthlyReport.Rows[0]["ElectricityAndWaterSupplyBill"].ToString();
            lblSalaryAmt.Text = dtMonthlyReport.Rows[0]["TeacherAndStaffSalary"].ToString();
            lblSchoolMaintance.Text = dtMonthlyReport.Rows[0]["SchoolMaintance"].ToString();
            lblTransportManagement.Text = dtMonthlyReport.Rows[0]["TransportManagement"].ToString();
            lblVendorManagement.Text = dtMonthlyReport.Rows[0]["VendorManagement"].ToString();

            if (lblEleAndWaterSupply.Text == "")
            {
                lblEleAndWaterSupply.Text = "0";
            }
            if (lblSalaryAmt.Text == "")
            {
                lblSalaryAmt.Text = "0";
            }
            if (lblSchoolMaintance.Text == "")
            {
                lblSchoolMaintance.Text = "0";
            }
            if (lblTransportManagement.Text == "")
            {
                lblTransportManagement.Text = "0";
            }
            if (lblVendorManagement.Text == "")
            {
                lblVendorManagement.Text = "0";
            }




            lblTotal.Text = Convert.ToString(Convert.ToInt64(lblEleAndWaterSupply.Text) + Convert.ToInt64(lblSalaryAmt.Text) + Convert.ToInt64(lblSchoolMaintance.Text) + Convert.ToInt64(lblTransportManagement.Text) + Convert.ToInt64(lblVendorManagement.Text));
        }
    }
    protected void btnSort_Click(object sender, EventArgs e)
    {
        try
        {
            ViewState["Sort"] = "Sort";
            BindMonthlyDetails();
        }
        catch (Exception ex) { }
    }
}