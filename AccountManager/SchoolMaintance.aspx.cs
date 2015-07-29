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

public partial class TMSchoolMgmt_AccountManager_SchoolMaintance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }
        if (Request.QueryString["msg"] != null)
        {
            dvMsg.Visible = true;
            lblMessage.Text = Request.QueryString["msg"];
            dvMsg.Style.Add("class", "warring_msg");
        }
        if (!IsPostBack)
        {
            SectionMaintenanceDetails.Style.Add("display", "block");
            SectionAddBill.Style.Add("display", "none");
            SectionTelephonePopUp.Style.Add("display", "none");
            BindTelephoneBill();
        }
        ddlYear1.Visible = true;
    }
    protected void BindTelephoneBill()
    {
        try
        {
            DataTable dtPhoneBill = TMSTelephoneBillDetails.GetBillDetails_MonthandYearWise(ddlYear1.SelectedValue).Tables[0];
            if (dtPhoneBill.Rows.Count > 0)
            {
                grdTelephoneBill.DataSource = dtPhoneBill;
                grdTelephoneBill.DataBind();
            }
            else
            {
                grdTelephoneBill.DataSource = null;
                grdTelephoneBill.DataBind();
            }
        }
        catch (Exception ex) { }
    }
    protected void grdTelephoneBill_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lnkStatus = (LinkButton)e.Row.FindControl("lnkStatus");
                Label lblPaidStatus = (Label)e.Row.FindControl("lblPaidStatus");

                if (lblPaidStatus.Text == "UnPaid")
                {
                    lnkStatus.Visible = true;
                    lblPaidStatus.Visible = false;
                }
                else
                {
                    lnkStatus.Visible = false;
                    lblPaidStatus.Visible = true;
                }
            }
        }
        catch (Exception ex) { }
    }
    protected void grdTelephoneBill_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            grdTelephoneBill.PageIndex = e.NewPageIndex;
            BindTelephoneBill();
        }
        catch (Exception ex) { }
    }
    protected void lblLibraryBill_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            LinkButton lnk = (LinkButton)sender;
            GridViewRow grd = (GridViewRow)lnk.NamingContainer;
            LinkButton lblLibraryBill = grd.FindControl("lblLibraryBill") as LinkButton;
            BindPopUp(Convert.ToString(lnk.CommandArgument), Convert.ToString(lnk.CommandName));
            SectionTelephonePopUp.Style.Add("display", "block");
            PopUpMaintenanace.Show();
        }
        catch (Exception ex) { }
    }
   
    protected void lblCanteenBill_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            LinkButton lnk = (LinkButton)sender;
            GridViewRow grd = (GridViewRow)lnk.NamingContainer;
            LinkButton lblCanteenBill = grd.FindControl("lblCanteenBill") as LinkButton;
            BindPopUp(Convert.ToString(lnk.CommandArgument), Convert.ToString(lnk.CommandName));
            SectionTelephonePopUp.Style.Add("display", "block");
            PopUpMaintenanace.Show(); 
        }
        catch (Exception ex) { }
    }
    protected void lblStaffBill_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            LinkButton lnk = (LinkButton)sender;
            GridViewRow grd = (GridViewRow)lnk.NamingContainer;
            LinkButton lblStaffBill = grd.FindControl("lblStaffBill") as LinkButton;
            BindPopUp(Convert.ToString(lnk.CommandArgument), Convert.ToString(lnk.CommandName));
            SectionTelephonePopUp.Style.Add("display", "block");
            PopUpMaintenanace.Show(); 
        }
        catch (Exception ex) { }
    }
    protected void lblAccountsBill_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            LinkButton lnk = (LinkButton)sender;
            GridViewRow grd = (GridViewRow)lnk.NamingContainer;
            LinkButton lblAccountsBill = grd.FindControl("lblAccountsBill") as LinkButton;
            BindPopUp(Convert.ToString(lnk.CommandArgument), Convert.ToString(lnk.CommandName));
            SectionTelephonePopUp.Style.Add("display", "block");
            PopUpMaintenanace.Show(); 
        }
        catch (Exception ex) { }
    }
    private void BindPopUp(string MonthName, string Type)
    {
        try
        {
            string Month = MonthName;
            string DeptName = Type;

            DataTable dtBillDetails = TMSTelephoneBillDetails.BindTelePhoneBillDetails(Convert.ToInt64(Session["UserId"]), null, Month, ddlYear1.SelectedValue, DeptName).Tables[0];
            if (dtBillDetails.Rows.Count > 0)
            {
                lstPhone.DataSource = dtBillDetails;
                lstPhone.DataBind();
            }
            else
            {
                lstPhone.DataSource = null;
                lstPhone.DataBind();
            }
        }
        catch (Exception ex) { }
    }
    protected void lnkStatus_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            LinkButton lnk = (LinkButton)sender;
            GridViewRow grd = (GridViewRow)lnk.NamingContainer;
            LinkButton lnkStatus = grd.FindControl("lnkStatuss") as LinkButton;
            TMSTelephoneBillDetails.UpdateBillStatus_MonthandYearWise(Convert.ToInt64(Session["UserId"]), Convert.ToString(lnk.CommandArgument), ddlYear1.SelectedValue);
            BindTelephoneBill();
        }
        catch (Exception ex) { }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dtTest = TMSTelephoneBillDetails.GetSearch(null, Convert.ToInt64(ddlPhone.SelectedValue), ddlMonth.SelectedValue,null,null,null,null,null,null,1).Tables[0];
            if (dtTest.Rows.Count > 0)
            {
                dvMsg.Visible = true;
                lblMessage.Text = "Details Are Already added for this Telephone Number!!!";
                dvMsg.Attributes.Add("class", "error_msg");
            }
            else
            {
                TMSTelephoneBillDetails objBill = new TMSTelephoneBillDetails();
                objBill.TBDBillAmount = Convert.ToInt64(txtBill.Text);
                objBill.TBDMonth = ddlMonth.SelectedValue;
                objBill.TBDYear = ddlYear.SelectedValue;
                objBill.TBDTelephoneId = Convert.ToInt64(ddlPhone.SelectedValue);
                objBill.TBDAddedById = Convert.ToInt64(Session["UserId"]);
                objBill.TBDDate = DateTime.Now;
                objBill.TBDAddedByRemark = "Account Manger";
                objBill.TBDStatus = 1;
                objBill.TBDPaidStatus = "UnPaid";
                objBill.Insert();
                txtBill.Text = "";
                dvMsg.Visible = true;
                lblMessage.Text = "Telephone Bill Details added Successfully!!!";
                dvMsg.Attributes.Add("class", "warring_msg");

                BindBillGridview();
            }
        }
        catch (Exception ex) { }
    }
    protected void btnAddBill_Clikck(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlYear1.Visible = false;
            grdBillDetails.Visible = true;
            SectionMaintenanceDetails.Style.Add("display", "none");
            SectionAddBill.Style.Add("display", "block");
            SectionTelephonePopUp.Style.Add("display", "none");
            grdTelephoneBill.Visible = false;
            BindTelephoneNo();
            BindBillGridview();
        }
        catch (Exception ex) { }
    }
    protected void BindTelephoneNo()
    {
        try
        {
            DataTable dtPhoneNumber = TMSTelephoneDetails.GetSearch(null, ddlType.SelectedValue, null, null, 1).Tables[0];
            if (dtPhoneNumber.Rows.Count > 0)
            {
                ddlPhone.DataSource = dtPhoneNumber;
                ddlPhone.DataTextField = "TD_TelephoneNumber";
                ddlPhone.DataValueField = "TD_TelephoneId";
                ddlPhone.DataBind();
            }
            else
            {
                ddlPhone.Items.Clear();
                ddlPhone.Items.Insert(0, new ListItem("Select", "-1"));
            }
        }
        catch (Exception ex) { }
    }
    protected void BindBillGridview()
    {
        try
        {
            DataTable dtPhoneBillDetails = TMSTelephoneBillDetails.BindTelePhoneBillDetails(Convert.ToInt64(Session["UserId"]), null, null, null, null).Tables[0];
            if (dtPhoneBillDetails.Rows.Count > 0)
            {
                grdBillDetails.DataSource = dtPhoneBillDetails;
                grdBillDetails.DataBind();
            }
            else
            {
                grdBillDetails.DataSource = null;
                grdBillDetails.DataBind();
            }
        }
        catch (Exception ex) { }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            Response.Redirect("SchoolMaintance.aspx");
        }
        catch (Exception ex) { }
    }
    protected void lnkClose_Click(object sender, EventArgs e)
    {
        try
        {
            //SectionTelephonePopUp.Visible = false;
            dvMsg.Visible = false;
            SectionTelephonePopUp.Style.Add("display","none");

        }
        catch (Exception ex) { }
    }
    protected void ddlYear1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            BindTelephoneBill();
        }
        catch (Exception) { }
    }
    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlYear1.Visible = false;
            BindTelephoneNo();
        }
        catch (Exception) { }
    }
    protected void grdBillDetails_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
            }
        }
        catch (Exception ex) { }
    }
    protected void grdBillDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlYear1.Visible = false;
            grdBillDetails.PageIndex = e.NewPageIndex;
            BindBillGridview();
        }
        catch (Exception ex) { }
    }
    protected void grdBillDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            string cmdName = e.CommandName.ToString();
            if (cmdName == "Edit1")
            {
                Int64 BillId = Convert.ToInt64(e.CommandArgument);
                grdBillDetails.Visible = false;
                fieldsetAddBill.Visible = true;
                btnSave.Text = "Update";

                TMSTelephoneBillDetails objBillDetails = TMSTelephoneBillDetails.Get(BillId);
                if (objBillDetails != null)
                {
                    Int64 TelephoneId = Convert.ToInt64(objBillDetails.TBDTelephoneId);
                    TMSTelephoneDetails obj = TMSTelephoneDetails.Get(TelephoneId);
                    if (obj != null)
                    {
                        ddlType.SelectedValue = obj.TDTelephoneDepartment;
                        BindTelephoneNo();
                    }
                    ddlPhone.SelectedValue = Convert.ToString(objBillDetails.TBDTelephoneId);
                    txtBill.Text = Convert.ToString(objBillDetails.TBDBillAmount);
                    ddlMonth.SelectedValue=objBillDetails.TBDMonth;
                    ddlYear.SelectedValue = objBillDetails.TBDYear;
                    objBillDetails.Update();
                }
            }
        }
        catch (Exception ex) { }
    }
    protected void grdBillDetails_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlYear1.Visible = false;
            grdBillDetails.EditIndex = e.NewEditIndex;
            BindBillGridview();
        }
        catch (Exception ex) { }
    }
    protected void grdBillDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlYear1.Visible = false;
            grdBillDetails.EditIndex = -1;
            BindBillGridview();
        }
        catch (Exception ex) { }
    }
    protected void grdBillDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlYear1.Visible = false;
            GridViewRow row = grdBillDetails.Rows[e.RowIndex];

            TextBox txtBillAmount = (TextBox)row.FindControl("txtBillAmount");
            Label lblBillId = (Label)row.FindControl("lblBillId");
            Int64 BillId = Convert.ToInt64(lblBillId.Text);

            TMSTelephoneBillDetails objBillDetails = TMSTelephoneBillDetails.Get(BillId);
            if (objBillDetails != null)
            {
                objBillDetails.TBDBillAmount = Convert.ToInt64(txtBillAmount.Text);
                objBillDetails.Update();
                BindBillGridview();
                grdBillDetails.EditIndex = -1;
                dvMsg.Visible = true;
                lblMessage.Text = "Record Updated Successfully";
                dvMsg.Attributes.Add("class", "warring_msg");
                BindBillGridview();
            }
        }
        catch (Exception ex) { }
    }
    protected void lstPhone_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        try
        {
        }
        catch (Exception ex) { }
    }
    protected void lstPhone_ChangePage(object sender, PagePropertiesChangingEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlYear1.Visible = false;
            DataPagerTrip.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
        }
        catch (Exception ex) { }
    }


}