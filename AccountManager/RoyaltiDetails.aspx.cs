using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AccountManager_RoyaltiDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("../Default.aspx?var=Logout");
            }
            if (Request.QueryString["msg"] != null)
            {

                dvMsg.Visible = true;
                lblMessage.Text = Request.QueryString["msg"];
                dvMsg.Attributes.Add("class", "warring_msg");
            }
            if (!IsPostBack)
            {
                BindOneTimeRoyalty();
            }
        }
        catch (Exception)
        { }
    }

    private void BindOneTimeRoyalty()
    {
        DataTable dtOneTimeRoyalty = TMSRoyaltyOneTimeCharges.GetSearch().Tables[0];
        grdOneTimeRoyaltyDetails.DataSource = dtOneTimeRoyalty;
        grdOneTimeRoyaltyDetails.DataBind();
    }
    protected void OneTimeRoyalty(object sender, EventArgs e)
    {
        try
        {
            secOneTimeRoyalty.Style.Add("display", "block");
            secAddOneTimeRoyalty.Style.Add("display", "none");
            secViewOneTimeRoyalty.Style.Add("display", "block");
            secMonthlyRoyalty.Style.Add("display", "none");
            liOneTimeRoy.Attributes.Add("class", "ui-state-default ui-corner-top ui-tabs-selected ui-state-active");
            liMonthlyRoy.Attributes.Add("class", "");
            secAddMonthlyRoyalty.Style.Add("display", "none");
            secViewMonthlyRoyalty.Style.Add("display", "none");
            dvMsg.Visible = false;
        }
        catch (Exception)
        { }
    }
    protected void MonthlyRoyalty(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            secOneTimeRoyalty.Style.Add("display", "none");
            secMonthlyRoyalty.Style.Add("display", "block");
            secAddOneTimeRoyalty.Style.Add("display", "none");
            secViewOneTimeRoyalty.Style.Add("display", "none");
            secAddMonthlyRoyalty.Style.Add("display", "none");
            secViewMonthlyRoyalty.Style.Add("display", "block");
            liOneTimeRoy.Attributes.Add("class", "");
            liMonthlyRoy.Attributes.Add("class", "ui-state-default ui-corner-top ui-tabs-selected ui-state-active");
            BindMonthlyRoyalty();
        }
        catch (Exception)
        { }
    }

    private void BindMonthlyRoyalty()
    {
        try
        {
            DataTable dtMonthRoyalty = null;
            if (ddlMonthlyRoyaltyYear.SelectedItem.Value == "-1")
            {
                dtMonthRoyalty = TMSRoyaltyMonthlyCharges.GetSearchMonthlyRoyalty(null, null).Tables[0];
            }
            else
            {
                dtMonthRoyalty = TMSRoyaltyMonthlyCharges.GetSearchMonthlyRoyalty(null, ddlMonthlyRoyaltyYear.SelectedItem.Value).Tables[0];
            }
            grdMontlyRoyalty.DataSource = dtMonthRoyalty;
            grdMontlyRoyalty.DataBind();
        }
        catch (Exception)
        { }
    }
    protected void ddlMonthlyRoyaltyYear_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            BindMonthlyRoyalty();
        }
        catch (Exception)
        { }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            TMSRoyaltyOneTimeCharges objOneTimeRoyalty = new TMSRoyaltyOneTimeCharges();
            objOneTimeRoyalty.RDAdmissionCharges = txtAdmissionCharges.Text;
            objOneTimeRoyalty.RDAnnualCharges = txtAnnualCharges.Text;
            objOneTimeRoyalty.RDAnnualDayCharges = txtAnnualDayCharges.Text;
            objOneTimeRoyalty.RDMixExpensesCharges = txtMisExpenses.Text;
            objOneTimeRoyalty.RDPortfolioCharges = txtPortfolioCharges.Text;
            objOneTimeRoyalty.RDRegistrationCharges = txtRegistrationCharges.Text;
            //objOneTimeRoyalty.RDRoyaltiMonth = txtAdmissionCharges.Text;
            //objOneTimeRoyalty.RDRoyaltyYear = txtRCharges.Text;
            objOneTimeRoyalty.RDSportDayCharges = txtSportDayCharges.Text;
            objOneTimeRoyalty.RDStudentKitCharges = txtStudentKitsCharges.Text;
            objOneTimeRoyalty.RDUniformCharges = txtUniformsCharges.Text;
            objOneTimeRoyalty.RDStatus = 1;
            objOneTimeRoyalty.RDDate = DateTime.Now;
            objOneTimeRoyalty.RDAddedByType = "Account Manager";
            objOneTimeRoyalty.RDAddedById = Convert.ToInt64(Session["UserID"]);
            objOneTimeRoyalty.Insert();
            OneTimeControlClear();
            dvMsg.Visible = true;
            lblMessage.Text = "Your One Time Royalty Added Successfully!!!.";
            dvMsg.Attributes.Add("class", "warring_msg");
           
            secOneTimeRoyalty.Style.Add("display", "block");
            secAddOneTimeRoyalty.Style.Add("display", "none");
            secViewOneTimeRoyalty.Style.Add("display", "block");
            secMonthlyRoyalty.Style.Add("display", "none");
            liOneTimeRoy.Attributes.Add("class", "ui-state-default ui-corner-top ui-tabs-selected ui-state-active");
            liMonthlyRoy.Attributes.Add("class", "");
            secAddMonthlyRoyalty.Style.Add("display", "none");
            secViewMonthlyRoyalty.Style.Add("display", "none");
            BindOneTimeRoyalty();
            // Response.Redirect("RoyaltiDetails.aspx?msg=Your One Time Royalty Added Successfully!!!.");
        }
        catch (Exception)
        { }
    }
    private void OneTimeControlClear()
    {
        txtAdmissionCharges.Text = "0";
        txtAnnualCharges.Text = "0";
        txtAnnualDayCharges.Text = "0";
        txtMisExpenses.Text = "0";
        txtPortfolioCharges.Text = "0";
        txtRegistrationCharges.Text = "0";
      
        txtSportDayCharges.Text = "0";
        txtStudentKitsCharges.Text = "0";
        txtUniformsCharges.Text = "0";
    }
    protected void btnMonthlySubmit_Click(object sender, EventArgs e)
    {
        try
        {
            TMSRoyaltyMonthlyCharges objMonthlyRoyalty = new TMSRoyaltyMonthlyCharges();
            objMonthlyRoyalty.RDActivityCharges = txtActivityCharges.Text;
            objMonthlyRoyalty.RDCTETCoaching = txtCTETCharges.Text;
            objMonthlyRoyalty.RDDayCareCharges = txtDayCareCharges.Text;
            objMonthlyRoyalty.RDForeignLanFees = txtForeignLanFees.Text;
            objMonthlyRoyalty.RDMealCharges = txtMealCharges.Text;
            objMonthlyRoyalty.RDMisExpenses = txtMisMonthlyExpenses.Text;
            objMonthlyRoyalty.RDMonth = ddlMonth.SelectedItem.Text;
            objMonthlyRoyalty.RDYear = ddlYear.SelectedItem.Text;
            objMonthlyRoyalty.RDNTTFees = txtNTTCharges.Text;
            objMonthlyRoyalty.RDTransportationCharges = txtTransportationCharges.Text;
            objMonthlyRoyalty.RDTutionFees = txtTutionFees.Text;
            objMonthlyRoyalty.RDStatus = 1;
            objMonthlyRoyalty.RDDate = DateTime.Now;
            objMonthlyRoyalty.RDAddedByType = "Account Manager";
            objMonthlyRoyalty.RDAddedById = Convert.ToInt64(Session["UserID"]);
            objMonthlyRoyalty.Insert();
            MonthlyControlClear();

            dvMsg.Visible = true;
            lblMessage.Text = "Your Monthly Royalty Added Successfully!!!.";
            dvMsg.Attributes.Add("class", "warring_msg");

            secOneTimeRoyalty.Style.Add("display", "none");
            secMonthlyRoyalty.Style.Add("display", "block");
            secAddOneTimeRoyalty.Style.Add("display", "none");
            secViewOneTimeRoyalty.Style.Add("display", "none");
            secAddMonthlyRoyalty.Style.Add("display", "none");
            secViewMonthlyRoyalty.Style.Add("display", "block");
            liOneTimeRoy.Attributes.Add("class", "");
            liMonthlyRoy.Attributes.Add("class", "ui-state-default ui-corner-top ui-tabs-selected ui-state-active");
            BindMonthlyRoyalty();
            // Response.Redirect("RoyaltiDetails.aspx?msg=Your Monthly Royalty Added Successfully!!!.");
        }
        catch (Exception)
        { }
    }

    private void MonthlyControlClear()
    {
        txtActivityCharges.Text = "0";
        txtCTETCharges.Text = "0";
        txtDayCareCharges.Text = "0";
        txtForeignLanFees.Text = "0";
        txtMealCharges.Text = "0";
        txtMisMonthlyExpenses.Text = "0";
        ddlMonth.SelectedValue = "June";
        ddlYear.SelectedIndex = 2012;
        txtNTTCharges.Text = "0";
        txtTransportationCharges.Text = "0";
        txtTutionFees.Text = "0";
    }
    protected void btnAddOneTimeRoyalty_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            secAddOneTimeRoyalty.Style.Add("display", "block");
            secViewOneTimeRoyalty.Style.Add("display", "none");
        }
        catch (Exception)
        { }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            secAddOneTimeRoyalty.Style.Add("display", "none");
            secViewOneTimeRoyalty.Style.Add("display", "block");
            BindOneTimeRoyalty();
        }
        catch (Exception)
        { }
    }
    protected void btnMonthlyRoyalty_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            secAddMonthlyRoyalty.Style.Add("display", "block");
            secViewMonthlyRoyalty.Style.Add("display", "none");
        }
        catch (Exception)
        { }
    }
    protected void btnMonthlyCancel_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            secAddMonthlyRoyalty.Style.Add("display", "none");
            secViewMonthlyRoyalty.Style.Add("display", "block");
            BindMonthlyRoyalty();
        }
        catch (Exception)
        { }
    }
    protected void grdOneTimeRoyaltyDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dvMsg.Visible = false;
        grdOneTimeRoyaltyDetails.PageIndex = e.NewPageIndex;
        BindOneTimeRoyalty();
    }
    protected void grdMontlyRoyalty_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dvMsg.Visible = false;
        grdMontlyRoyalty.PageIndex = e.NewPageIndex;
        BindMonthlyRoyalty();
    }
}