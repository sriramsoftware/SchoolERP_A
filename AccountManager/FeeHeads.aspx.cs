using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AccountManager_FeeHeads : System.Web.UI.Page
{
    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindFeeHeads();
        }
    }

    protected void btnClearSearch_Click(object sender, EventArgs e)
    {
        txtFeeHeadsSearch.Text = string.Empty;
        grdFeeHeads.EditIndex = -1;
        BindFeeHeads();
    }

    protected void btnSearchFeeHeads_Click(object sender, EventArgs e)
    {
        var dsFeesCategory = TMSFeesHeadMaster.FilterFeeHeads(txtFeeHeadsSearch.Text);
        grdFeeHeads.DataSource = dsFeesCategory.Tables[0];
        grdFeeHeads.DataBind();
    }

    #endregion

    #region GridView Events

    protected void grdFeeHeads_EditRow(object sender, GridViewEditEventArgs e)
    {

        grdFeeHeads.EditIndex = e.NewEditIndex;
        BindFeeHeads();


    }

    protected void grdFeeHeads_UpdateRow(object sendedr, GridViewUpdateEventArgs e)
    {
        int feeHeadID = Convert.ToInt32(grdFeeHeads.DataKeys[e.RowIndex].Value.ToString());
        GridViewRow row = grdFeeHeads.Rows[e.RowIndex] as GridViewRow;

        if (feeHeadID != 0)
        {
            TMSFeesHeadMaster objFeeHead = TMSFeesHeadMaster.Get(feeHeadID);
            objFeeHead.FeeHeadName = (row.FindControl("txtFeeHeadName") as TextBox).Text;
            objFeeHead.FeeCategoryID = Convert.ToInt32((row.FindControl("drpFeeCategoryName") as DropDownList).SelectedValue);
            objFeeHead.Update();
        }

        grdFeeHeads.EditIndex = -1;
        BindFeeHeads();

    }

    protected void grdFeeHeads_CancelEditRow(object sender, GridViewCancelEditEventArgs e)
    {

        grdFeeHeads.EditIndex = -1;
        BindFeeHeads();

    }

    protected void grdFeeHeads_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdFeeHeads.PageIndex = e.NewPageIndex;

        BindFeeHeads();
    }

    protected void grdFeeHeads_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("AddNew"))
        {
            TMSFeesHeadMaster objFeeHead = new TMSFeesHeadMaster();
            objFeeHead.FeeHeadName = ((TextBox)grdFeeHeads.FooterRow.FindControl("txtNewFeeHeadName")).Text;
            objFeeHead.FeeCategoryID = Convert.ToInt32(((DropDownList)grdFeeHeads.FooterRow.FindControl("drpNewFeeCategoryName")).SelectedValue);
            objFeeHead.CreatedDate = DateTime.Now;
            objFeeHead.IsDelete = false;
            objFeeHead.Insert();
            grdFeeHeads.EditIndex = -1;
            BindFeeHeads();
        }
    }

    protected void grdFeeHeads_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int feeHeadID = Convert.ToInt32(grdFeeHeads.DataKeys[e.RowIndex].Value.ToString());
        if (feeHeadID != 0)
        {
            TMSFeesHeadMaster objFeeHead = TMSFeesHeadMaster.Get(feeHeadID);
            objFeeHead.IsDelete = true;
            objFeeHead.Update();
        }

        grdFeeHeads.EditIndex = -1;
        BindFeeHeads();
    }


    #endregion

    #region Private Methods

    private void BindFeeHeads()
    {
        var dsFeeHead = TMSFeesHeadMaster.GetAllFeeHeads();
        if (dsFeeHead.Tables[0].Rows.Count < 1)
        {
            DataRow rw = dsFeeHead.Tables[0].NewRow();
            rw["FeeCategoryName"] = rw["FeeHeadName"] = "";
            rw["FeeCategoryID"] = rw["FeeHeadID"] = 0;
            dsFeeHead.Tables[0].Rows.InsertAt(rw, 0);
            grdFeeHeads.DataSource = dsFeeHead.Tables[0];
            grdFeeHeads.DataBind();
            grdFeeHeads.Rows[0].Visible = false;
        }
        else
        {
            grdFeeHeads.DataSource = dsFeeHead.Tables[0];
            grdFeeHeads.DataBind();
        }
    }

    protected DataSet GetFeeCategoryNames()
    {
        var dsFeeHead = TMSFeesCategoryMaster.GetAllFeesCategory();
        DataRow rw = dsFeeHead.Tables[0].NewRow();
        rw["FeeCategoryID"] = "0";
        rw["FeeCategoryName"] = "Select";
        dsFeeHead.Tables[0].Rows.InsertAt(rw, 0);
        return dsFeeHead;
    }

    #endregion

}