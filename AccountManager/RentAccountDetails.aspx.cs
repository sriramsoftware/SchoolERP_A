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

public partial class AccountManager_RentAccountDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dvMsg.Visible = false;
        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }

        if (!IsPostBack)
           
        {
            BindRentAccountDetails();
        }

    }

    protected void BindRentAccountDetails()
    {
        try
        {
            DataSet dtRent=new DataSet ();
            dtRent = TMSRentAccountDetails.GetAllRentAccountDetails(null, null, null, null, null);
            
            if (dtRent.Tables[0].Rows.Count>0)
            {
                gvDetails.DataSource = dtRent;
                gvDetails.DataBind();
            }
            else
            {
                dtRent.Tables[0].Rows.Add(dtRent.Tables[0].NewRow());
                gvDetails.DataSource = dtRent;
                gvDetails.DataBind();
                int columncount = gvDetails.Rows[0].Cells.Count;
                gvDetails.Rows[0].Cells.Clear();
                gvDetails.Rows[0].Cells.Add(new TableCell());
                gvDetails.Rows[0].Cells[0].ColumnSpan = columncount;
                gvDetails.Rows[0].Cells[0].Text = "No Record Found!!!.";
            }

        }
        catch (Exception ex) { }
    }
    protected void gvDetails_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            gvDetails.EditIndex = e.NewEditIndex;
            BindRentAccountDetails();
        }
        catch (Exception ex) { }
    }
    protected void gvDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            Int64 RentId = Convert.ToInt64(gvDetails.DataKeys[e.RowIndex].Value.ToString());

            TextBox txtTotalAmount = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("txtTotalAmount");
            TextBox txtPaidAmount = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("txtPaidAmount");
            TextBox txtDues = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("txtDues");
            TextBox txtTranDate = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("txtTranDate");
            DropDownList ddlPaidStatus = (DropDownList)gvDetails.Rows[e.RowIndex].FindControl("ddlPaidStatus");
            DropDownList ddlMonth = (DropDownList)gvDetails.Rows[e.RowIndex].FindControl("ddlMonth");
            DropDownList ddlYear = (DropDownList)gvDetails.Rows[e.RowIndex].FindControl("ddlYear");
          

            TMSRentAccountDetails objRent = TMSRentAccountDetails.Get(RentId);
            if (objRent != null)
            {
                objRent.RACTotalAmount = Convert.ToDouble(txtTotalAmount.Text);
                objRent.RACPaidAmount = Convert.ToDouble(txtPaidAmount.Text);
                objRent.RACAnyDues = Convert.ToDouble(txtTotalAmount.Text) - Convert.ToDouble(txtPaidAmount.Text);
                objRent.RACPaidStatus = ddlPaidStatus.SelectedItem.Text; ;
                objRent.RACTransactionDate = Convert.ToDateTime(txtTranDate.Text);
                objRent.RACMonth = ddlMonth.SelectedItem.Text;
                objRent.RACYear = ddlYear.SelectedItem.Text;
                objRent.Update();

                dvMsg.Visible = true;
                lblMessage.Text = "Record Is Updated Successfully";
                dvMsg.Attributes.Add("class", "warring_msg");
            }
            gvDetails.EditIndex = -1;
            BindRentAccountDetails();
        }
        catch (Exception ex) { }
    }
    protected void gvDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            gvDetails.EditIndex = -1;
            BindRentAccountDetails();
        }
        catch (Exception ex) { }
    }
    protected void gvDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dvMsg.Visible = false;
        gvDetails.PageIndex = e.NewPageIndex;
        BindRentAccountDetails();
    }
    protected void gvDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            Int64 RentId = Convert.ToInt64(gvDetails.DataKeys[e.RowIndex].Value.ToString());
            TMSRentAccountDetails.Delete(RentId, null);

            dvMsg.Visible = true;
            lblMessage.Text = "Record Is Deleted Successfully";
            dvMsg.Attributes.Add("class", "warring_msg");
            BindRentAccountDetails();
        }
        catch (Exception ex) { }
       
    }
    protected void gvDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {

            if (e.CommandName.Equals("AddNew"))
            {

                TextBox txtfTotalAmount = (TextBox)gvDetails.FooterRow.FindControl("txtfTotalAmount");
                TextBox txtfPaidAmount = (TextBox)gvDetails.FooterRow.FindControl("txtfPaidAmount");
                TextBox txtfDues = (TextBox)gvDetails.FooterRow.FindControl("txtfDues");
                TextBox txtfTranDate = (TextBox)gvDetails.FooterRow.FindControl("txtfTranDate");
                DropDownList ddlfPaidStatus = (DropDownList)gvDetails.FooterRow.FindControl("ddlfPaidStatus");
                DropDownList ddlfMonth = (DropDownList)gvDetails.FooterRow.FindControl("ddlfMonth");
                DropDownList ddlfYear = (DropDownList)gvDetails.FooterRow.FindControl("ddlfYear");

                TMSRentAccountDetails objRent = new TMSRentAccountDetails();
                objRent.RACTotalAmount = Convert.ToDouble(txtfTotalAmount.Text);
                objRent.RACPaidAmount = Convert.ToDouble(txtfPaidAmount.Text);
                objRent.RACAnyDues = Convert.ToDouble(txtfTotalAmount.Text) - Convert.ToDouble(txtfPaidAmount.Text); ;
                objRent.RACPaidStatus = ddlfPaidStatus.SelectedItem.Text;
                objRent.RACTransactionDate =Convert.ToDateTime(txtfTranDate.Text);
                objRent.RACMonth = ddlfMonth.SelectedItem.Text;
                objRent.RACYear = ddlfYear.SelectedItem.Text;
                objRent.RACAddedById = Convert.ToInt64(Session["UserId"]);
                objRent.RACDate = DateTime.Now;
                objRent.RacStatus = 1;
                objRent.Insert();

                dvMsg.Visible = true;
                lblMessage.Text = "Record Is Added Successfully";
                dvMsg.Attributes.Add("class","warring_msg");
                BindRentAccountDetails();
            }
        }
        catch (Exception ex) { }
    }
}
