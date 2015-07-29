using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AccountManager_FeesTerm : System.Web.UI.Page
{
    #region Events

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindFeeCategoryNames();
        }
    }

    


    protected void drpFeesCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindFeesTerm();
    } 

    #endregion

    #region GridView Events

    protected void grdFeesTerm_EditRow(object sender, GridViewEditEventArgs e)
    {
        grdFeesTerm.EditIndex = e.NewEditIndex;
        BindFeesTerm();
    }

    protected void grdFeesTerm_UpdateRow(object sender, GridViewUpdateEventArgs e)
    {
        int monthID = Convert.ToInt32(grdFeesTerm.DataKeys[e.RowIndex].Value.ToString());
        int feeCategoryID = Convert.ToInt32(drpFeesCategory.SelectedValue);
        var dt = TMSFeesTerm.GetFeesTermbyMonthIDAndFeeCategoryID(feeCategoryID,monthID).Tables[0];
        GridViewRow row = grdFeesTerm.Rows[e.RowIndex];
        if (dt.Rows.Count>0)    //Update existing
        {
            TMSFeesTerm objFeesTerm = TMSFeesTerm.Get(Convert.ToInt64(dt.Rows[0]["FeesTermID"]));
            objFeesTerm.FeesTerm = ((TextBox)row.FindControl("txtFeesTerm")).Text;
            objFeesTerm.Update();
        }
        else                   //Insert new
        {
            TMSFeesTerm objFeesTerm = new TMSFeesTerm();
            objFeesTerm.Month = monthID;
            objFeesTerm.FeeCategoryID = feeCategoryID;
            objFeesTerm.FeesTerm = ((TextBox)row.FindControl("txtFeesTerm")).Text;
            objFeesTerm.Insert();
        }
        grdFeesTerm.EditIndex = -1;
        BindFeesTerm();
    }

    protected void grdFeesTerm_CancelEditRow(object sender, GridViewCancelEditEventArgs e)
    {
        grdFeesTerm.EditIndex = -1;
        BindFeesTerm();
    }


    #endregion

    #region Private Methods

    protected void  BindFeeCategoryNames()
    {
        var dsFeesCategory = TMSFeesCategoryMaster.GetAllFeesCategory();
        DataRow rw = dsFeesCategory.Tables[0].NewRow();
        rw["FeeCategoryID"] = "0";
        rw["FeeCategoryName"] = "Select";
        dsFeesCategory.Tables[0].Rows.InsertAt(rw, 0);
        drpFeesCategory.DataSource = dsFeesCategory.Tables[0];
        drpFeesCategory.DataTextField = "FeeCategoryName";
        drpFeesCategory.DataValueField = "FeeCategoryID";
        drpFeesCategory.DataBind();
    }

    private void BindFeesTerm()
    {
        var dtFeesTerm = TMSFeesTerm.GetFeesTermbyFeeCategoryID(Convert.ToInt32(drpFeesCategory.SelectedValue)).Tables[0];
        DataTable dt = new DataTable();
        dt.Columns.Add("MonthID");
        dt.Columns.Add("Month");
        dt.Columns.Add("FeesTerm");


        for (int i = 1; i < 13; i++)
        {
            DataRow dr = dt.NewRow();
            dr["MonthID"] = i;
            dr["Month"] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
            var dv = new DataView(dtFeesTerm) { RowFilter = "Month=" + i };

            dr["FeesTerm"] = dv.ToTable().Rows.Count > 0 ? dv.ToTable().Rows[0]["FeesTerm"] : "";
            dt.Rows.Add(dr);
            dt.AcceptChanges();
        }
        grdFeesTerm.DataSource = dt;
        grdFeesTerm.DataBind();
    }

    #endregion
}