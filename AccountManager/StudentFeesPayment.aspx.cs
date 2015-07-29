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

public partial class AccountManager_StudentFeesPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }
        else
        {
            if (!IsPostBack)
            {
                HiddenType.Value = "All";
                BindSchoolStandard();
                BindStudents();

            }
        }
    }

    protected void ddlSchoolType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            BindSchoolStandard();
        }
        catch (Exception) { }
    }

    protected void ddlStandard_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            BindDivision();

        }
        catch (Exception) { }
    }

    protected void BindSchoolStandard()
    {
        try
        {
            string schooltype = null;
            //if (ddlSchoolType.SelectedItem.Text == "Select Type")
            //{
            //    schooltype = null;
            //}
            //else
            //{
            //    schooltype = ddlSchoolType.SelectedItem.Text;
            //}
            DataTable dtStandard = TMSSchoolCategory.GetSearch(null, null, null, null, 1).Tables[0];
            if (dtStandard.Rows.Count > 0)
            {
                ddlStandard.DataSource = dtStandard;
                ddlStandard.DataValueField = "SC_CategoryId";
                ddlStandard.DataTextField = "SC_CategoryName";
                ddlStandard.DataBind();
                ddlStandard.Items.Insert(0, new ListItem("Select Standard", "-1"));
                ddlDivision.Items.Insert(0, new ListItem("Select Division", "-1"));
            }
        }
        catch (Exception ex) { }
    }
    protected void BindDivision()
    {
        try
        {
            Int64? schooltype = null;
            if (ddlStandard.SelectedItem.Text == "Select Standard")
            {
                schooltype = null;
                ddlDivision.Items.Clear();
            }
            else
            {
                schooltype = Convert.ToInt64(ddlStandard.SelectedValue);
            }
            DataTable dtDivision = TMSSchoolSubCategory.GetSearch(null, schooltype, null, null, 1).Tables[0];
            if (dtDivision.Rows.Count > 0)
            {
                ddlDivision.DataSource = dtDivision;
                ddlDivision.DataValueField = "SSC_SubCategoryId";
                ddlDivision.DataTextField = "SSC_SubCategoryName";
                ddlDivision.DataBind();
                ddlDivision.Items.Insert(0, new ListItem("Select Division", "-1"));
            }
        }
        catch (Exception ex) { }
    }
    //protected void btnSort_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        HiddenType.Value = "";

    //        BindStudents();

    //    }


    //    catch { }

    //}
    protected void btnall_Click(object sender, EventArgs e)
    {
        try
        {

            HiddenType.Value = "All";
            BindStudents();

        }


        catch { }

    }
    protected void BindStudents()
    {
        try
        {


            Int64? Standard = null;
            Int64? Division = null;
            string month = null, year = null;
            if (ddlStandard.SelectedValue != "-1")
            {
                Standard = Convert.ToInt64(ddlStandard.SelectedValue);
            }
            if (ddlDivision.SelectedValue != "-1")
            {
                Division = Convert.ToInt64(ddlDivision.SelectedValue);
            }
            if (ddlMonth.SelectedValue != "-1")
            {
                month = ddlMonth.SelectedValue;
            }

            if (ddlYear.SelectedValue != "-1")
            {
                year = ddlYear.SelectedValue;
            }
            if (HiddenType.Value == "All")
            {
                DataTable DtFeesDetails = TMSFeesAndPaymentDetails.GetStudentFeesDetails(null, Standard, Division, null, month, year, null).Tables[0];
                grdFeesPayment.DataSource = DtFeesDetails;
                grdFeesPayment.DataBind();
            }

            else
            {
                DataTable DtFeesDetails = TMSFeesAndPaymentDetails.GetStudentFeesDetails(null, Standard, Division, null, month, year, "ViewType").Tables[0];
                grdFeesPayment.DataSource = DtFeesDetails;
                grdFeesPayment.DataBind();
            }




        }
        catch (Exception ex) { }
    }
    protected void grdFeesPayment_EditRow(object sender, GridViewEditEventArgs e)
    {

        grdFeesPayment.EditIndex = e.NewEditIndex;
        BindStudents();


    }
    protected void grdFeesPayment_UpdateRow(object sendedr, GridViewUpdateEventArgs e)
    {
        try
        {
            // Int64 SD_loginId = Convert.ToInt64(grdFeesPayment.DataKeys[e.RowIndex].Value);

            GridViewRow row = grdFeesPayment.Rows[e.RowIndex] as GridViewRow;

            Label lblStudentLoginId = row.FindControl("lblStudentLoginId") as Label;
            Label ldlStudentDivisionId = row.FindControl("ldlStudentDivisionId") as Label;
            Label ldlStudentStandardId = row.FindControl("ldlStudentStandardId") as Label;
            Label lblDetailsId = row.FindControl("lblDetailsId") as Label;
            TextBox txtTotalFees = row.FindControl("txtTotalFees") as TextBox;
            TextBox txtFeesPaid = row.FindControl("txtFeesPaid") as TextBox;

            if (lblDetailsId.Text != "0")
            {
                TMSFeesAndPaymentDetails objfeesdetails = TMSFeesAndPaymentDetails.Get(Convert.ToInt64(lblDetailsId.Text));

                objfeesdetails.SFPStudentLoginId = Convert.ToInt64(lblStudentLoginId.Text);
                objfeesdetails.SFTPaidFees = Convert.ToDouble(txtFeesPaid.Text);
                objfeesdetails.SFPTotalFees = Convert.ToDouble(txtTotalFees.Text);
                objfeesdetails.SFPRemainingFees = Convert.ToDouble(Convert.ToDouble(txtTotalFees.Text) - Convert.ToDouble(txtFeesPaid.Text));
                objfeesdetails.Update();


            }

            else
            {
                TMSFeesAndPaymentDetails objfees = new TMSFeesAndPaymentDetails();

                objfees.SFPStudentLoginId = Convert.ToInt64(lblStudentLoginId.Text);
                if (ldlStudentStandardId.Text != "")
                {
                    objfees.SFPStandardId = Convert.ToInt64(ldlStudentStandardId.Text);
                }
                if (ldlStudentDivisionId.Text != "")
                {
                    objfees.SFPDivisionId = Convert.ToInt64(ldlStudentDivisionId.Text);
                }
                objfees.SFPTotalFees = Convert.ToDouble(txtTotalFees.Text);
                objfees.SFTPaidFees = Convert.ToDouble(txtFeesPaid.Text);
                objfees.SFPAddedById = Convert.ToInt64(Session["UserId"]);
                objfees.SFPRemainingFees = Convert.ToDouble(Convert.ToDouble(txtTotalFees.Text) - Convert.ToDouble(txtFeesPaid.Text));
                objfees.SFPMonth = ddlMonth.SelectedValue;
                objfees.SFPYear = ddlYear.SelectedValue;
                objfees.SFPAddedByRemark = "Student Fees";
                objfees.SFPTransactionDate = DateTime.Now;
                objfees.SFPStatus = 1;
                objfees.Insert();
            }

            grdFeesPayment.EditIndex = -1;
            BindStudents();





        }
        catch (Exception ex) { }

    }
    protected void grdFeesPayment_CancelEditRow(object sender, GridViewCancelEditEventArgs e)
    {

        grdFeesPayment.EditIndex = -1;
        BindStudents();

    }
    protected void grdFeesPayment_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdFeesPayment.PageIndex = e.NewPageIndex;

        BindStudents();
    }
}
