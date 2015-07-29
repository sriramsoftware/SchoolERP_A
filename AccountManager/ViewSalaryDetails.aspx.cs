using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class TMSchoolMgmt_AccountManager_ViewSalaryDetails : System.Web.UI.Page
{
    string facultytype = "2";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }
        if (!IsPostBack)
        {
            ViewState["Sort"] = null;

            if (!string.IsNullOrEmpty(Request.QueryString["msg"]))
            {
                dvMsg.Visible = true;
                lblMessage.Text = Convert.ToString(Request.QueryString["msg"]);
                dvMsg.Attributes.Add("class", "warring_msg");
            }
            if (!string.IsNullOrEmpty(Request.QueryString["LoginId"]))
            {
                Session["AccountID"] = Request.QueryString["LoginId"];
                Session["Type"] = Request.QueryString["type"];
                Session["FacultyType"] = Request.QueryString["FacultyType"];
            }

            if ((Session["AccountID"] != null) && (Session["type"] != null))
            {
                string types = Session["type"].ToString();

                if ((types == "Teacher") && (Request.QueryString["var"] == null))
                {
                    aTeachersDetaitls.Attributes.Add("class", "active");
                    aStaffDetails.Attributes.Add("class", "");
                    //aPrincipalDetails.Attributes.Add("class", "");
                    BindSalryDetailsMonthWise();
                    btnAdd.Visible = true;
                }

                else if ((types == "Staff") && (Request.QueryString["var"] == null))
                {
                    aTeachersDetaitls.Attributes.Add("class", "");
                    //aPrincipalDetails.Attributes.Add("class", "");
                    aStaffDetails.Attributes.Add("class", "active");
                    BindSalryDetailsMonthWise();
                    btnAdd.Visible = true;
                }
                else if ((Request.QueryString["var"] == "edit") && (types == "Teacher"))
                {
                    aTeachersDetaitls.Attributes.Add("class", "active");
                    aStaffDetails.Attributes.Add("class", "");
                    Checksalary();
                    SectionViewSalary.Visible = false;
                    SectionAddSalary.Visible = true;
                    btnAdd.Visible = false;
                }
                else if ((Request.QueryString["var"] == "edit") && (types == "Staff"))
                {
                    aTeachersDetaitls.Attributes.Add("class", "");
                    aStaffDetails.Attributes.Add("class", "active");
                    Checksalary();
                    SectionViewSalary.Visible = false;
                    SectionAddSalary.Visible = true;
                    btnAdd.Visible = false;
                }
            }
        }
    }
    protected void BindSalryDetailsMonthWise()
    {
        try
        {
            string Month = null;
            string Year = null;

            if (ddlMonth1.SelectedIndex <= 0)
            {
                Month = null;
            }
            else
            {
                Month = Convert.ToString(ddlMonth1.SelectedItem.Text);
            }

            if (ddlYear1.SelectedIndex <= 0)
            {
                Year = null;
            }
            else
            {
                Year = Convert.ToString(ddlYear1.SelectedItem.Text);
            }

            DataTable dtSalary = null;

            if (ViewState["Sort"] != null)
            {
                dtSalary = TMSSalaryDetails.GetFacultyAndStaffSalaryDetails(Convert.ToInt64(Session["AccountID"]), Month, Year).Tables[0];
            }
            else
            {
                dtSalary = TMSSalaryDetails.GetFacultyAndStaffSalaryDetails(Convert.ToInt64(Session["AccountID"]), null, null).Tables[0];
            }

            if (dtSalary.Rows.Count > 0)
            {
                grdSalary.DataSource = dtSalary;
                grdSalary.DataBind();
                SectionViewSalary.Visible = true;
                SectionAddSalary.Visible = false;
            }
            else
            {
                grdSalary.DataSource = null;
                grdSalary.DataBind();
                SectionViewSalary.Visible = true;
                SectionAddSalary.Visible = false;
            }
        }
        catch (Exception ex) { }

    }
    protected void Checksalary()
    {
        try
        {
            btnsave.Text = "Update";
            HiddenSalaryId.Value = Request.QueryString["SI_DetailsId"];
            Int64 SalaryDetailsId = Convert.ToInt64(Request.QueryString["SI_DetailsId"]);

            TMSSalaryDetails obj = TMSSalaryDetails.Get(Convert.ToInt64(SalaryDetailsId));

            if (obj.SISalaryType != null)
            {
                if (obj.SISalaryType == "Monthly")
                {
                    rbtmonth.Checked = true;
                }
                else
                {
                    rbtYear.Checked = true;
                }
            }
            // txtBasicSalary.Text = obj.SIBasicSalary.ToString();
            txtGrossSalary.Text = obj.SIGrossSalary.ToString();
            txtLeaveCount.Text = obj.SILeaveCount.ToString();
            txtDeductionAmt.Text = obj.SILeaveDeductionAmount.ToString();
            ddlMonth.SelectedValue = obj.SIMonth.ToString();
            ddlYear.SelectedValue = obj.SIYear.ToString();
            ddlSalaryStatus.SelectedValue = obj.SIAddedByRemarks.ToString();
        }
        catch (Exception ex) { }

    }

    protected void btncancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccountManagerDashboard.aspx");
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            Int64 FacultyTypeId = Convert.ToInt64(Session["FacultyType"]);
            TMSFacultyType objType = TMSFacultyType.Get(FacultyTypeId);
            string FacultyType = null;
            if (objType != null)
            {
                FacultyType = objType.FTFacultyName;
            }

            if (btnsave.Text == "Update")
            {

                TMSSalaryDetails objSalary = TMSSalaryDetails.Get(Convert.ToInt64(HiddenSalaryId.Value));
                objSalary.SIFacultyLoginId = Convert.ToInt64(Session["AccountID"]);
                if (rbtmonth.Checked == true)
                {
                    objSalary.SISalaryType = "Monthly";
                }
                else if (rbtYear.Checked == true)
                {
                    objSalary.SISalaryType = "Yearly";
                }
                objSalary.SIFacultyType = Session["FacultyType"].ToString();
                objSalary.SIFacultyType = Session["FacultyType"].ToString();
                // 
                objSalary.SIGrossSalary = float.Parse(txtGrossSalary.Text);
                objSalary.SILeaveCount = Convert.ToInt32(txtLeaveCount.Text);
                objSalary.SILeaveDeductionAmount = float.Parse(txtDeductionAmt.Text);
                objSalary.SIMonth = ddlMonth.SelectedItem.Text;
                objSalary.SIYear = ddlYear.SelectedItem.Text;
                objSalary.SIAddedByRemarks = ddlSalaryStatus.SelectedItem.Text;
                objSalary.SIOtherRemarks = FacultyType + " " + "Salary";
                objSalary.SIAddedById = Convert.ToInt64(Session["UserId"]);
                objSalary.SIDate = DateTime.Now;

                if (txtDeductionAmt.Text != "")
                {
                    objSalary.SIBasicSalary = float.Parse(txtGrossSalary.Text) - float.Parse(txtDeductionAmt.Text);
                }

                else
                {
                    objSalary.SIBasicSalary = float.Parse(txtGrossSalary.Text);
                }
                objSalary.Update();
                if (FacultyType == "Teacher")
                {
                    Response.Redirect("ViewSalaryDetails.aspx?msg=Teacher Salary Details  Updated Successfully !");
                }
                else
                {
                    Response.Redirect("ViewSalaryDetails.aspx?msg=Staff Salary Details  Updated Successfully !");
                }
                //  Response.Redirect("ViewSalaryDetails.aspx?msg=Salary Details  Updated Successfully !");
            }

            else
            {
                DataTable dt = TMSSalaryDetails.GetSalaryDetails(null, Convert.ToInt64(Session["AccountID"]), Session["FacultyType"].ToString(), null, ddlMonth.SelectedItem.Text, ddlYear.SelectedItem.Text).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    dvMsg.Visible = true;
                    lblMessage.Text = "Salary Details Already Added for this Month and Year !";
                    dvMsg.Attributes.Add("class", "error_msg");
                    return;
                }
                else
                {


                    TMSSalaryDetails objSalary = new TMSSalaryDetails();
                    objSalary.SIFacultyLoginId = Convert.ToInt64(Session["AccountID"]);
                    if (rbtmonth.Checked == true)
                    {
                        objSalary.SISalaryType = "Monthly";
                    }
                    else if (rbtYear.Checked == true)
                    {
                        objSalary.SISalaryType = "Yearly";
                    }
                    objSalary.SIFacultyType = Session["FacultyType"].ToString();

                    objSalary.SIGrossSalary = float.Parse(txtGrossSalary.Text);
                    objSalary.SILeaveCount = Convert.ToInt32(txtLeaveCount.Text);
                    objSalary.SILeaveDeductionAmount = float.Parse(txtDeductionAmt.Text);

                    if (txtDeductionAmt.Text != "")
                    {
                        objSalary.SIBasicSalary = float.Parse(txtGrossSalary.Text) - float.Parse(txtDeductionAmt.Text);
                    }

                    else
                    {
                        objSalary.SIBasicSalary = float.Parse(txtGrossSalary.Text);
                    }
                    objSalary.SIMonth = ddlMonth.SelectedItem.Text;
                    objSalary.SIYear = ddlYear.SelectedItem.Text;
                    objSalary.SIAddedByRemarks = ddlSalaryStatus.SelectedItem.Text;
                    objSalary.SIOtherRemarks = FacultyType + " " + "Salary";
                    objSalary.SIAddedById = Convert.ToInt64(Session["UserId"]);
                    objSalary.SIDate = DateTime.Now;
                    objSalary.SIStatus = 1;
                    objSalary.Insert();
                    if (FacultyType == "Teacher")
                    {
                        Response.Redirect("ViewSalaryDetails.aspx?msg=Teacher Salary Details  Added Successfully !");
                    }
                    else
                    {
                        Response.Redirect("ViewSalaryDetails.aspx?msg=Staff Salary Details  Added Successfully !");
                    }
                }
            }
        }
        catch (Exception ex) { }
        {

        }
    }

    protected void btnAddSalary_Click(object sender, EventArgs e)
    {
        if ((Session["AccountID"] != null) && (Session["type"] != null))
        {
            string types = Session["type"].ToString();

            if (types == "Teacher")
            {
                SectionViewSalary.Visible = false;
                SectionAddSalary.Visible = true;
                aTeachersDetaitls.Attributes.Add("class", "active");
                aStaffDetails.Attributes.Add("class", "");
            }
            else
            {
                SectionViewSalary.Visible = false;
                SectionAddSalary.Visible = true;
                aTeachersDetaitls.Attributes.Add("class", "");
                aStaffDetails.Attributes.Add("class", "active");
            }
        }
    }

    protected void btnViewSalary_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            btnAdd.Visible = true;
            ViewState["Sort"] = "Sort";
            BindSalryDetailsMonthWise();
        }
        catch (Exception ex) { }
    }

    protected void grdSalary_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

            }
        }
        catch (Exception ex) { }
    }
    protected void grdSalary_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            grdSalary.PageIndex = -e.NewPageIndex;
            BindSalryDetailsMonthWise();
        }
        catch (Exception ex) { }
    }
    protected void grdSalary_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        ViewState["Sort"] = null;
        Label lblSalaryDetailsId = grdSalary.Rows[e.RowIndex].FindControl("lblSalaryDetailsId") as Label;
        TMSSalaryDetails.Delete(Convert.ToInt64(lblSalaryDetailsId.Text), null);
        BindSalryDetailsMonthWise();
        dvMsg.Visible = true;
        lblMessage.Text = "Record Is Deleted Successfully";
        dvMsg.Attributes.Add("class", "warring_msg");

    }
}