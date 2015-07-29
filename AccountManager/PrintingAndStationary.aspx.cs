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


public partial class AccountManager_PrintingAndStationary : System.Web.UI.Page
{
    int Total = 0;

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
            ViewState["Sort"] = null;
            ddlYear1.Visible = true;
            ddlMonth1.Visible = true;
            btnAddPrintingAndStationary.Visible = true;
            btnVieW.Visible = true;
            SectionMaintenanceDetails.Style.Add("display", "block");
            SectionAddBill.Style.Add("display", "none");
            SectionStationaryPrinting.Style.Add("display", "none");
            BindStationaryPrinting_ExpenseMonthWise();
        }
        
    }
    protected void BindStationaryPrinting_ExpenseMonthWise()
    {
        try
        {
            DataTable dtExpensesDetails = null;
            if (ViewState["Sort"] != null)
            {
                 dtExpensesDetails = TMSOtherExpensesDetails.GetExpenseDetailsMonthAndYearWise(Convert.ToInt64(Session["UserId"]), null, ddlMonth1.SelectedItem.Text, ddlYear1.SelectedItem.Text).Tables[0];
            }
            else
            {
                dtExpensesDetails = TMSOtherExpensesDetails.GetExpenseDetailsMonthAndYearWise(Convert.ToInt64(Session["UserId"]), null,null,null).Tables[0];
            
            }
            if (dtExpensesDetails.Rows.Count > 0)
            {
                grdPrintingStationary.DataSource = dtExpensesDetails;
                grdPrintingStationary.DataBind();
            }
            else
            {
                grdPrintingStationary.DataSource = null;
                grdPrintingStationary.DataBind();
            }
        }
        catch (Exception ex) { }
    }
    protected void grdPrintingStationary_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                
            }
        }
        catch (Exception ex) { }
    }
    protected void grdPrintingStationary_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            grdPrintingStationary.PageIndex = e.NewPageIndex;
            BindStationaryPrinting_ExpenseMonthWise();
            
        }
        catch (Exception ex) { }
    }
    protected void lblStationaryExpense_Click(object sender, EventArgs e)
    {
        try
        {
            string Month = null;
            string Year = null;
            dvMsg.Visible = false;
            LinkButton lnk = (LinkButton)sender;
            GridViewRow grd = (GridViewRow)lnk.NamingContainer;
            LinkButton lblStationaryExpense = grd.FindControl("lblStationaryExpense") as LinkButton;


            string[] arg = new string[2];
            arg = lnk.CommandArgument.ToString().Split(';');
            Month = arg[0];
            Year= arg[1];


            ViewPopUp(Convert.ToString(lnk.CommandName),Convert.ToString(arg[0]),Convert.ToString(arg[1]));
            SectionStationaryPrinting.Style.Add("display", "block");
            lblType.Text = Convert.ToString(lnk.CommandName);
            PopUpOtherExpenses.Show();
        }
        catch (Exception ex) { }
    }

    protected void lblPrintingExpense_Click(object sender, EventArgs e)
    {
        try
        {
            string Month = null;
            string Year = null;

            dvMsg.Visible = false;
            LinkButton lnk = (LinkButton)sender;
            GridViewRow grd = (GridViewRow)lnk.NamingContainer;
            LinkButton lblPrintingExpense = grd.FindControl("lblPrintingExpense") as LinkButton;

            string[] arg = new string[2];
            arg = lnk.CommandArgument.ToString().Split(';');
            Month = arg[0];
            Year = arg[1];

            ViewPopUp(Convert.ToString(lnk.CommandName), Convert.ToString(arg[0]), Convert.ToString(arg[1]));
            SectionStationaryPrinting.Style.Add("display", "block");
            lblType.Text = Convert.ToString(lnk.CommandName);
            PopUpOtherExpenses.Show();
        }
        catch (Exception ex) { }
    }
    private void ViewPopUp(string Type, string MonthName,string CurrentYear)
    {
        try
        {
            string ExpenseType = Type;
            string Month = MonthName;
            string Year = CurrentYear;


            DataTable dtExpensePopUp = TMSOtherExpensesDetails.ViewPopUpDetailsMonthAndYearWise(Convert.ToInt64(Session["UserId"]), ExpenseType, Month, Year).Tables[0];
            if (dtExpensePopUp.Rows.Count > 0)
            {
                grdExpensePopUp.DataSource = dtExpensePopUp;
                grdExpensePopUp.DataBind();
            }
            else
            {
                grdExpensePopUp.DataSource = null;
                grdExpensePopUp.DataBind();
            }
        }
        catch (Exception ex) { }
    }
   
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dtAlreadyExists = TMSOtherExpensesDetails.GetAllExpensesDetails(null, "Printing And Stationary", Convert.ToString(txtItemName.Text), Convert.ToString(ddlType.SelectedItem.Text), null, Convert.ToString(ddlMonth.SelectedItem.Text), Convert.ToString(ddlYear.SelectedItem.Text), null, Convert.ToInt64(Session["UserId"]), null).Tables[0];
            if (dtAlreadyExists.Rows.Count > 0)
            {
                dvMsg.Visible = true;
                lblMessage.Text = "Details Are Already Added For This Month !!!";
                dvMsg.Attributes.Add("class", "error_msg");
            }
            else
            {
                TMSOtherExpensesDetails objExpense = new TMSOtherExpensesDetails();
                objExpense.SPOEType = ddlType.SelectedItem.Text;
                objExpense.SPOETitle = "Printing And Stationary";
                objExpense.SPOEItemName = txtItemName.Text;
                objExpense.SPOEQuantity = txtQuantity.Text;
                objExpense.SPOETotalAmount = Convert.ToDouble(txtCost.Text);
                objExpense.SPOEMonth = ddlMonth.SelectedItem.Text;
                objExpense.SPOEYear = ddlYear.SelectedItem.Text;
                objExpense.SPOEAddedById=Convert.ToInt64(Session["UserId"]);
                objExpense.SPOEAddedByRemark =ddlType.SelectedItem.Text +" "+ "Expense";
                objExpense.SPOEDate = DateTime.Now;
                objExpense.SPOEStatus = 1;
                objExpense.Insert();
                txtCost.Text = "";
                txtItemName.Text = "";
                txtQuantity.Text = "";
                ddlYear.SelectedValue = "2012";
                ddlMonth.SelectedValue = "June";
                ddlType.SelectedValue = "Stationary";
                dvMsg.Visible = true;
                lblMessage.Text = ddlType.SelectedItem.Text+" Bill Details added Successfully!!!";
                dvMsg.Attributes.Add("class", "warring_msg");
                BindEXpenseGridView();
            }
        }
        catch (Exception ex) { }
    }
    protected void btnPrintingAndStationary_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlMonth1.Visible = false;
            ddlYear1.Visible = false;
            btnAddPrintingAndStationary.Visible = false;
            btnVieW.Visible = false;
            grdExpensesDetails.Visible = true;
            SectionMaintenanceDetails.Style.Add("display", "none");
            SectionAddBill.Style.Add("display", "block");
            SectionStationaryPrinting.Style.Add("display", "none");
            grdPrintingStationary.Visible = false;
            BindEXpenseGridView();
        }
        catch (Exception ex) { }
    }


    protected void btnVieWExpenseDetails_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ViewState["Sort"] = "Sort";
            SectionMaintenanceDetails.Style.Add("display", "block");
            SectionAddBill.Style.Add("display", "none");
            SectionStationaryPrinting.Style.Add("display", "none");
            BindStationaryPrinting_ExpenseMonthWise();
        }
        catch (Exception ex) { }
    }
    
    
    protected void BindEXpenseGridView()
    {
        try
        {
            DataTable dtExpense = TMSOtherExpensesDetails.GetAllExpensesDetails(null, "Printing And Stationary", null, null, null, null, null, null, Convert.ToInt64(Session["UserId"]), null).Tables[0];
            if (dtExpense.Rows.Count > 0)
            {
                grdExpensesDetails.DataSource = dtExpense;
                grdExpensesDetails.DataBind();
            }
            else
            {
                grdExpensesDetails.DataSource = null;
                grdExpensesDetails.DataBind();
            }
        }
        catch (Exception ex) { }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            Response.Redirect("PrintingAndStationary.aspx");
         /*   string path = HttpContext.Current.Request.Url.AbsolutePath.ToString();

            string[] Pageurl = path.Split('/');
            if (Pageurl[4] == "PrintingAndStationary.aspx")
            {
                Response.Redirect("PrintingAndStationary.aspx");
            }
            else
            {
                Response.Redirect("PrintingAndStationary.aspx");
            } */
           
        }
        catch (Exception ex) { }
    }
    protected void lnkClose_Click(object sender, EventArgs e)
    {
        try
        {
            //SectionStationaryPrinting.Visible = false;
            dvMsg.Visible = false;
            SectionStationaryPrinting.Style.Add("display", "none");

        }
        catch (Exception ex) { }
    }
    protected void ddlYear1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            BindStationaryPrinting_ExpenseMonthWise();
        }
        catch (Exception) { }
    }
    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlYear1.Visible = false;
            ddlMonth1.Visible = false;
          
        }
        catch (Exception) { }
    }
    protected void grdExpensesDetails_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
            }
        }
        catch (Exception ex) { }
    }
    protected void grdExpensesDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlYear1.Visible = false;
            ddlMonth1.Visible = false;
            grdExpensesDetails.PageIndex = e.NewPageIndex;
            BindEXpenseGridView();
        }
        catch (Exception ex) { }
    }
    protected void grdExpensesDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            string cmdName = e.CommandName.ToString();
            if (cmdName == "Edit1")
            {
                Int64 ExpenseDetailsId = Convert.ToInt64(e.CommandArgument);
                grdExpensesDetails.Visible = false;
                fieldsetAddBill.Visible = true;
                btnSave.Text = "Update";

                TMSOtherExpensesDetails objExpenseDetails = TMSOtherExpensesDetails.Get(ExpenseDetailsId);
                if (objExpenseDetails != null)
                {
                   
                }
            }
        }
        catch (Exception ex) { }
    }
    protected void grdExpensesDetails_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlYear1.Visible = false;
            ddlMonth1.Visible = false;
            grdExpensesDetails.EditIndex = e.NewEditIndex;
            BindEXpenseGridView();
        }
        catch (Exception ex) { }
    }
    protected void grdExpensesDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlYear1.Visible = false;
            ddlMonth1.Visible = false;
            grdExpensesDetails.EditIndex = -1;
            BindEXpenseGridView();
        }
        catch (Exception ex) { }
    }
    protected void grdExpensesDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlYear1.Visible = false;
            ddlMonth1.Visible = false;
            GridViewRow row = grdExpensesDetails.Rows[e.RowIndex];

            TextBox txtTotalAmount = (TextBox)row.FindControl("txtTotalAmount");
            Label lblExpensesDetailsId = (Label)row.FindControl("lblExpensesDetailsId");
            Int64 ExpensesDetailsId = Convert.ToInt64(lblExpensesDetailsId.Text);

            TMSOtherExpensesDetails objExpenseDetails = TMSOtherExpensesDetails.Get(ExpensesDetailsId);
            if (objExpenseDetails != null)
            {
                objExpenseDetails.SPOETotalAmount = Convert.ToDouble(txtTotalAmount.Text);
                objExpenseDetails.Update();
                BindEXpenseGridView();
                grdExpensesDetails.EditIndex = -1;
                dvMsg.Visible = true;
                lblMessage.Text = "Record Updated Successfully";
                dvMsg.Attributes.Add("class", "warring_msg");
                BindEXpenseGridView();
            }
        }
        catch (Exception ex) { }
    }


    protected void grdExpensePopUp_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
           
            
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    Label lblTotalAmount1 = (Label)e.Row.FindControl("lblTotalAmount1");
                    Total += Convert.ToInt32(lblTotalAmount1.Text);
                }

                if (e.Row.RowType == DataControlRowType.Footer)
                {
                    Label lblTotal = (Label)e.Row.FindControl("lblTotal");
                    lblTotal.Text = Total.ToString();
                }
               
               
            
        }
        catch (Exception ex) { }
    }
    protected void grdExpensePopUp_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            ddlYear1.Visible = false;
            ddlMonth1.Visible = false;
            grdExpensePopUp.PageIndex = e.NewPageIndex;
            BindEXpenseGridView();
        }
        catch (Exception ex) { }
    }


}