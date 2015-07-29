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

public partial class AccountManager_Accountdriver : System.Web.UI.Page
{
    int totalDriver = 0;
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
                FillBusDriverSalaryDetails();
            }
        }
    }


    protected void Redio_Bus(object sender, EventArgs e)
    {

        Response.Redirect("Account.aspx");
    }
    protected void Redio_Driver(object sender, EventArgs e)
    {

        Response.Redirect("Accountdriver.aspx");
    }
    protected void Redio_Supporter(object sender, EventArgs e)
    {
        Response.Redirect("AccountSuppoprt.aspx");
    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccountDriveredit.aspx");
    }
    protected void btnedit1_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeacherSalaryDetails.aspx");
    }
    protected void lnkBtnGetCode_Click(object sender, EventArgs e)
    {

    }


    protected void FillBusDriverSalaryDetails()
    {
        string Month = null;
        string Year = null;
        if (ddlMonth.SelectedValue != "-1")
        {
            Month = ddlMonth.SelectedValue;
        }
        if (ddlYear.SelectedValue != "-1")
        {
            Year = ddlYear.SelectedValue;
        }
        DataTable dt = TMSBusMaintananceDetails.GetStaffSalaryDetails(null, Convert.ToInt64(Session["UserId"]), "Driver", null, Month, Year, "4").Tables[0];
        GriedViewDriver.DataSource = dt;
        GriedViewDriver.DataBind();

    }

    protected void GriedViewDriver_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            Label lbBSM_MonthlyMaintenancecost = (Label)e.Row.FindControl("lbSI_BasicSalary");
            totalDriver += Convert.ToInt32(lbBSM_MonthlyMaintenancecost.Text);
            // lblDriverTotalAmount.Text = totalDriver.ToString();
        }
        if (e.Row.RowType == DataControlRowType.Footer)
        {
            Label lblamount = (Label)e.Row.FindControl("lblTotal");
            lblamount.Text = totalDriver.ToString();
        }


    }
    protected void GriedViewDriver_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            GriedViewDriver.PageIndex = e.NewPageIndex;
            FillBusDriverSalaryDetails();
        }
        catch (Exception ex) { }
    }

    protected void btnSort_Click(object sender, EventArgs e)
    {
        FillBusDriverSalaryDetails();
    }

    protected void lnkViewSalarySlip_Details(object sender, EventArgs e)
    {
        try
        {
            PanSalarySection.Visible = true;
            LinkButton lnk = (LinkButton)sender;
            GridViewRow lml = (GridViewRow)lnk.NamingContainer;
            Label lblSalaryDetailsId = lml.FindControl("lblsalDetailsId") as Label;
            DataTable dt = TMSBusMaintananceDetails.GetStaffSalaryDetails(Convert.ToInt64(lblSalaryDetailsId.Text), Convert.ToInt64(Session["UserId"]), "Driver", null, null, null, "4").Tables[0];

            // TMSSalaryDetails objSalary = TMSSalaryDetails.Get(SalaryDetailsId);
            if (dt.Rows.Count > 0)
            {
                lblMonthName.Text = dt.Rows[0]["SI_Month"].ToString();
                lblYearName.Text = dt.Rows[0]["SI_Year"].ToString();
                Decimal GrossSalary = Convert.ToDecimal(dt.Rows[0]["SI_GrossSalary"].ToString());
                Decimal DeductionAmt = Convert.ToDecimal(dt.Rows[0]["SI_LeaveDeductionAmount"].ToString());
                Decimal NetSal = GrossSalary - DeductionAmt;
                lblNetSalary.Text = Convert.ToString(NetSal);
                lblNetSalWord.Text = NumberToWords(Convert.ToInt32(lblNetSalary.Text)).ToUpper();




                grdSalarySlip.DataSource = dt;
                grdSalarySlip.DataBind();



                lblEmployeeNmae.Text = Convert.ToString(dt.Rows[0]["BSD_StaffName"].ToString());
                lblJoiningDtae.Text = String.Format("{0:dd MMM yyyy}", dt.Rows[0]["BSD_DateOfJoining"]);
                //lblDept.Text = Convert.ToString(dtFacultyDetails.Rows[0]["FD_SpecificExpertise"]);
                lblDesignation.Text = Convert.ToString(dt.Rows[0]["BSD_StaffType"]);
                //lblEmpCode.Text = Convert.ToString(dtFacultyDetails.Rows[0][""]);
                //lblLocation.Text = Convert.ToString(dtFacultyDetails.Rows[0]["FacultyCity"]);

            }


            Control p = lnk.Parent;
            AjaxControlToolkit.ModalPopupExtender SalarySlipPopUp = (AjaxControlToolkit.ModalPopupExtender)p.FindControl("SalarySlipPopUp");
            SalarySlipPopUp.Show();
        }
        catch (Exception ex) { }
    }

    protected void click_lnkClose(object sender, EventArgs e)
    {
        try
        {
            PanSalarySection.Visible = false;
        }
        catch (Exception Ex)
        {
        }
    }

    public static string NumberToWords(int number)
    {

        if (number == 0)

            return "zero";



        if (number < 0)

            return "minus " + NumberToWords(Math.Abs(number));



        string words = "";



        if ((number / 1000000) > 0)
        {

            words += NumberToWords(number / 1000000) + " million ";

            number %= 1000000;

        }



        if ((number / 1000) > 0)
        {

            words += NumberToWords(number / 1000) + " thousand ";

            number %= 1000;

        }



        if ((number / 100) > 0)
        {

            words += NumberToWords(number / 100) + " hundred ";

            number %= 100;

        }



        if (number > 0)
        {

            if (words != "")

                words += "and ";



            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };



            if (number < 20)

                words += unitsMap[number];

            else
            {

                words += tensMap[number / 10];

                if ((number % 10) > 0)

                    words += "-" + unitsMap[number % 10];

            }

        }



        return words;

    }

   
}
