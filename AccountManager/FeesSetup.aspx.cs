using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AccountManager_FeesSetup : System.Web.UI.Page
{
    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindFeesSetup();
        }
    }

    protected void CheckDuplicateUpdate(object source, ServerValidateEventArgs args)
    {

    }

    protected void CheckDuplicateInsert(object source, ServerValidateEventArgs args)
    {
        args.IsValid = false;
    }

    protected void drpSchoolCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList drpSchoolCategory = (DropDownList)sender;
        GridViewRow row = (GridViewRow)drpSchoolCategory.NamingContainer;
        DropDownList drpSchoolSubCategory = ((DropDownList)row.FindControl("drpSchoolSubCategoryName"));
        drpSchoolSubCategory.DataSource = TMSSchoolSubCategory.Search(null, Convert.ToInt64(drpSchoolCategory.SelectedValue), null, null, null);
        drpSchoolSubCategory.DataTextField = "SSCSubCategoryName";
        drpSchoolCategory.DataValueField = "SSCSubCategoryId";
        drpSchoolCategory.DataBind();
        drpSchoolCategory.Items.Insert(0, "Select");

    }

    protected void drpSchoolCategoryNew_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList drpSchoolCategoryNew = (DropDownList)sender;
        GridViewRow row = (GridViewRow)drpSchoolCategoryNew.NamingContainer;
        DropDownList drpNewSchoolSubCategoryName = ((DropDownList)row.FindControl("drpNewSchoolSubCategoryName"));
        drpNewSchoolSubCategoryName.DataSource = TMSSchoolSubCategory.Search(null, Convert.ToInt64(drpSchoolCategoryNew.SelectedValue), null, null, null);
        drpNewSchoolSubCategoryName.DataTextField = "SSCSubCategoryName";
        drpNewSchoolSubCategoryName.DataValueField = "SSCSubCategoryId";
        drpNewSchoolSubCategoryName.DataBind();
        drpNewSchoolSubCategoryName.Items.Insert(0, "Select");
    }

    protected void drpFeeCategoryName_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList drpFeeCategoryName = (DropDownList)sender;
        GridViewRow row = (GridViewRow)drpFeeCategoryName.NamingContainer;

        DropDownList drpFeeHeadName = ((DropDownList)row.FindControl("drpFeeHeadName"));
        drpFeeHeadName.DataSource = TMSFeesHeadMaster.Search(null, Convert.ToInt32(drpFeeCategoryName.SelectedValue), null, null, null);
        drpFeeHeadName.DataTextField = "FeeHeadName";
        drpFeeHeadName.DataValueField = "FeeHeadID";
        drpFeeHeadName.DataBind();
        drpFeeHeadName.Items.Insert(0, "Select");

        DropDownList drpFeeTerm = ((DropDownList)row.FindControl("drpFeeTerm"));
        drpFeeTerm.DataSource = TMSFeesTerm.Search(null, Convert.ToInt32(drpFeeCategoryName.SelectedValue), null, null);
        drpFeeTerm.DataTextField = "FeesTerm";
        drpFeeTerm.DataValueField = "FeesTermID";
        drpFeeTerm.DataBind();
        drpFeeTerm.Items.Insert(0, "Select");
    }

    protected void drpNewFeeCategoryName_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList drpNewFeeCategoryName = (DropDownList)sender;
        GridViewRow row = (GridViewRow)drpNewFeeCategoryName.NamingContainer;

        DropDownList drpNewFeeHeadName = ((DropDownList)row.FindControl("drpNewFeeHeadName"));
        drpNewFeeHeadName.DataSource = TMSFeesHeadMaster.Search(null, Convert.ToInt32(drpNewFeeCategoryName.SelectedValue), null, null, null);
        drpNewFeeHeadName.DataTextField = "FeeHeadName";
        drpNewFeeHeadName.DataValueField = "FeeHeadID";
        drpNewFeeHeadName.DataBind();
        drpNewFeeHeadName.Items.Insert(0, "Select");

        DropDownList drpNewFeeTerm = ((DropDownList)row.FindControl("drpNewFeeTerm"));
        drpNewFeeTerm.DataSource = TMSFeesTerm.Search(null, Convert.ToInt32(drpNewFeeCategoryName.SelectedValue), null, null);
        drpNewFeeTerm.DataTextField = "FeesTerm";
        drpNewFeeTerm.DataValueField = "FeesTermID";
        drpNewFeeTerm.DataBind();
        drpNewFeeTerm.Items.Insert(0, "Select");
    }
    
    #endregion

    #region GridView Events

    protected void grdFeesSetup_EditRow(object sender, GridViewEditEventArgs e)
    {

        grdFeesSetup.EditIndex = e.NewEditIndex;
        BindFeesSetup();
    }

    
    protected void grdFeesSetup_UpdateRow(object sendedr, GridViewUpdateEventArgs e)
    {
        int feeHeadID = Convert.ToInt32(grdFeesSetup.DataKeys[e.RowIndex].Value.ToString());
        GridViewRow row = grdFeesSetup.Rows[e.RowIndex] as GridViewRow;

        if (feeHeadID != 0)
        {
            TMSFeesHeadMaster objFeeHead = TMSFeesHeadMaster.Get(feeHeadID);
            objFeeHead.FeeHeadName = ((TextBox) row.FindControl("txtFeeHeadName")).Text;
            objFeeHead.FeeCategoryID = Convert.ToInt32((row.FindControl("drpFeeCategoryName") as DropDownList).SelectedValue);
            objFeeHead.Update();
        }

        grdFeesSetup.EditIndex = -1;
        BindFeesSetup();

    }

    protected void grdFeesSetup_CancelEditRow(object sender, GridViewCancelEditEventArgs e)
    {

        grdFeesSetup.EditIndex = -1;
        BindFeesSetup();

    }

    protected void grdFeesSetup_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdFeesSetup.PageIndex = e.NewPageIndex;

        BindFeesSetup();
    }

    protected void grdFeesSetup_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("AddNew"))
        {
            TMSFeesHeadMaster objFeeHead = new TMSFeesHeadMaster();
            objFeeHead.FeeHeadName = ((TextBox)grdFeesSetup.FooterRow.FindControl("txtNewFeeHeadName")).Text;
            objFeeHead.FeeCategoryID = Convert.ToInt32(((DropDownList)grdFeesSetup.FooterRow.FindControl("drpNewFeeCategoryName")).SelectedValue);
            objFeeHead.CreatedDate = DateTime.Now;
            objFeeHead.IsDelete = false;
            objFeeHead.Insert();
            grdFeesSetup.EditIndex = -1;
            BindFeesSetup();
        }
    }

    protected void grdFeesSetup_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int feeHeadID = Convert.ToInt32(grdFeesSetup.DataKeys[e.RowIndex].Value.ToString());
        if (feeHeadID != 0)
        {
            TMSFeesHeadMaster objFeeHead = TMSFeesHeadMaster.Get(feeHeadID);
            objFeeHead.IsDelete = true;
            objFeeHead.Update();
        }

        grdFeesSetup.EditIndex = -1;
        BindFeesSetup();
    }


    #endregion

    #region Methods

    private void BindFeesSetup()
    {
        var dsFeesSetup = TMSFeesSetup.GetAllFeesSetup();
        if (dsFeesSetup.Tables[0].Rows.Count < 1)
        {
            DataRow rw = dsFeesSetup.Tables[0].NewRow();
            rw["SC_CategoryName"] = rw["SSC_SubCategoryName"] = rw["FeeCategoryName"] = rw["FeeHeadName"] = rw["FeesTerm"] = "";
            rw["FeesHeadID"] = rw["FeesCategoryID"] = rw["SchoolCategoryID"] = 0;
            dsFeesSetup.Tables[0].Rows.InsertAt(rw, 0);
            grdFeesSetup.DataSource = dsFeesSetup.Tables[0];
            grdFeesSetup.DataBind();
            grdFeesSetup.Rows[0].Visible = false;
        }
        else
        {
            grdFeesSetup.DataSource = dsFeesSetup.Tables[0];
            grdFeesSetup.DataBind();
        }

    }

    protected DataSet GetSchoolCategory()
    {
        var dsSchoolCategory = TMSSchoolCategory.GetAllSchoolCategory();
        DataRow rw = dsSchoolCategory.Tables[0].NewRow();
        rw["SC_CategoryId"] = "0";
        rw["SC_CategoryName"] = "Select";
        dsSchoolCategory.Tables[0].Rows.InsertAt(rw, 0);
        return dsSchoolCategory;
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