using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AccountManager_FeesCategories : System.Web.UI.Page
{
    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindFeesCategory();
        }
    }

    protected void btnSearchFeeCategory_Click(object sender, EventArgs e)
    {
        txtFeesCategorySearch.Text = string.Empty;
        grdFeesCategory.EditIndex = -1;
        BindFeesCategory();
    }

    protected void btnClearSearch_Click(object sender, EventArgs e)
    {
        var dsFeesCategory = TMSFeesCategoryMaster.FilterFeesCategories(txtFeesCategorySearch.Text);
        grdFeesCategory.DataSource = dsFeesCategory.Tables[0];
        grdFeesCategory.DataBind();
    }

    #endregion

    #region GridView Events

    protected void grdFeesCategory_EditRow(object sender, GridViewEditEventArgs e)
    {

        grdFeesCategory.EditIndex = e.NewEditIndex;
        BindFeesCategory();


    }

    protected void grdFeesCategory_UpdateRow(object sendedr, GridViewUpdateEventArgs e)
    {
        int feesCategoryID = Convert.ToInt32(grdFeesCategory.DataKeys[e.RowIndex].Value.ToString());
        GridViewRow row = grdFeesCategory.Rows[e.RowIndex] as GridViewRow;

        if (feesCategoryID != 0)
        {
            TMSFeesCategoryMaster objFeesCategory = TMSFeesCategoryMaster.Get(feesCategoryID);
            objFeesCategory.FeeCategoryName = (row.FindControl("txtFeeCategoryName") as TextBox).Text;
            objFeesCategory.Update();
        }

        grdFeesCategory.EditIndex = -1;
        BindFeesCategory();

    }

    protected void grdFeesCategory_CancelEditRow(object sender, GridViewCancelEditEventArgs e)
    {

        grdFeesCategory.EditIndex = -1;
        BindFeesCategory();

    }

    protected void grdFeesCategory_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdFeesCategory.PageIndex = e.NewPageIndex;

        BindFeesCategory();
    }

    protected void grdFeesCategory_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("AddNew"))
        {
            TMSFeesCategoryMaster objFeesCategory = new TMSFeesCategoryMaster();
            objFeesCategory.FeeCategoryName = ((TextBox)grdFeesCategory.FooterRow.FindControl("txtNewFeeCategoryName")).Text;
            objFeesCategory.CreatedDate = DateTime.Now;
            objFeesCategory.IsDelete = false;
            objFeesCategory.Insert();
            grdFeesCategory.EditIndex = -1;
            BindFeesCategory();
        }
    }

    protected void grdFeesCategory_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int feesCategoryID = Convert.ToInt32(grdFeesCategory.DataKeys[e.RowIndex].Value.ToString());
        if (feesCategoryID != 0)
        {
            TMSFeesCategoryMaster objFeesCategory = TMSFeesCategoryMaster.Get(feesCategoryID);
            objFeesCategory.IsDelete = true;
            objFeesCategory.Update();
        }

        grdFeesCategory.EditIndex = -1;
        BindFeesCategory();
    } 

    #endregion

    #region Private Methods

    private void BindFeesCategory()
    {


        var dsFeesCategory = TMSFeesCategoryMaster.GetAllFeesCategory();
        if (dsFeesCategory.Tables[0].Rows.Count < 1)
        {
            DataRow rw = dsFeesCategory.Tables[0].NewRow();
            rw["FeeCategoryName"] =  "";
            rw["FeeCategoryID"] = 0;
            dsFeesCategory.Tables[0].Rows.InsertAt(rw, 0);
            grdFeesCategory.DataSource = dsFeesCategory.Tables[0];
            grdFeesCategory.DataBind();
            grdFeesCategory.Rows[0].Visible = false;
        }
        else
        {
            grdFeesCategory.DataSource = dsFeesCategory.Tables[0];
            grdFeesCategory.DataBind();
        }
    } 

    #endregion
}