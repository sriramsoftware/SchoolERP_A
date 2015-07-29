using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentTypes : System.Web.UI.Page
{
    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindStudentTypes();
        }
    }

    protected void btnClearSearch_Click(object sender, EventArgs e)
    {
        txtStudentTypeSearch.Text = string.Empty;
        grdStudentType.EditIndex = -1;
        BindStudentTypes();
    }

    protected void btnSearchStudentType_Click(object sender, EventArgs e)
    {
        var dsFeesCategory = TMSStudentTypeMaster.FilterStudentTypes(txtStudentTypeSearch.Text);
        grdStudentType.DataSource = dsFeesCategory.Tables[0];
        grdStudentType.DataBind();
    }

    #endregion

    #region GridView Events

    protected void grdStudentType_EditRow(object sender, GridViewEditEventArgs e)
    {

        grdStudentType.EditIndex = e.NewEditIndex;
        BindStudentTypes();
    }

    protected void grdStudentType_UpdateRow(object sendedr, GridViewUpdateEventArgs e)
    {
        int studentTypeID = Convert.ToInt32(grdStudentType.DataKeys[e.RowIndex].Value.ToString());
        GridViewRow row = grdStudentType.Rows[e.RowIndex] as GridViewRow;

        if (studentTypeID != 0)
        {
            TMSStudentTypeMaster objStudentType = TMSStudentTypeMaster.Get(studentTypeID);
            objStudentType.StudentTypeName = (row.FindControl("txtStudentTypeName") as TextBox).Text;
            objStudentType.FeeCategoryID = Convert.ToInt32((row.FindControl("drpFeeCategoryName") as DropDownList).SelectedValue);
            objStudentType.Update();
        }

        grdStudentType.EditIndex = -1;
        BindStudentTypes();

    }

    protected void grdStudentType_CancelEditRow(object sender, GridViewCancelEditEventArgs e)
    {

        grdStudentType.EditIndex = -1;
        BindStudentTypes();

    }

    protected void grdStudentType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdStudentType.PageIndex = e.NewPageIndex;

        BindStudentTypes();
    }

    protected void grdStudentType_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("AddNew"))
        {
            TMSStudentTypeMaster objStudentType = new TMSStudentTypeMaster();
            objStudentType.StudentTypeName = ((TextBox)grdStudentType.FooterRow.FindControl("txtNewStudentTypeName")).Text;
            objStudentType.FeeCategoryID = Convert.ToInt32(((DropDownList)grdStudentType.FooterRow.FindControl("drpNewFeeCategoryName")).SelectedValue);
            objStudentType.CreatedDate = DateTime.Now;
            objStudentType.IsDelete = false;
            objStudentType.Insert();
            grdStudentType.EditIndex = -1;
            BindStudentTypes();
        }
    }

    protected void grdStudentType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int studentTypeID = Convert.ToInt32(grdStudentType.DataKeys[e.RowIndex].Value.ToString());
        if (studentTypeID != 0)
        {
            TMSStudentTypeMaster objStudentType = TMSStudentTypeMaster.Get(studentTypeID);
            objStudentType.IsDelete = true;
            objStudentType.Update();
        }

        grdStudentType.EditIndex = -1;
        BindStudentTypes();
    }


    #endregion

    #region Private Methods

    private void BindStudentTypes()
    {
        var dsStudentTypes = TMSStudentTypeMaster.GetAllStudentTypes();
        if (dsStudentTypes.Tables[0].Rows.Count<1)
        {
            DataRow rw = dsStudentTypes.Tables[0].NewRow();
            rw["FeeCategoryName"] =  rw["StudentTypeName"] = "";
            rw["FeeCategoryID"] = rw["StudentTypeID"] = 0;
            dsStudentTypes.Tables[0].Rows.InsertAt(rw, 0);
            grdStudentType.DataSource = dsStudentTypes.Tables[0];
            grdStudentType.DataBind();
            grdStudentType.Rows[0].Visible = false;
        }
        else
        {
            grdStudentType.DataSource = dsStudentTypes.Tables[0];
            grdStudentType.DataBind();
        }
    }

    protected DataSet GetFeeCategoryNames()
    {
        var dsStudentTypes = TMSFeesCategoryMaster.GetAllFeesCategory();
        DataRow rw = dsStudentTypes.Tables[0].NewRow();
        rw["FeeCategoryID"] = "0";
        rw["FeeCategoryName"] = "Select";
        dsStudentTypes.Tables[0].Rows.InsertAt(rw, 0);
        return dsStudentTypes;
    }

    #endregion
}