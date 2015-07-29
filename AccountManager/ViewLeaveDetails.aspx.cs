using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class TMSchoolMgmt_AccountManager_ViewLeaveDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }
        if (!IsPostBack)
        {


            if ((Session["AccountID"] != null) && (Session["type"] != null))
            {
                string types = Session["type"].ToString();

                if (types == "Teacher")
                {
                    aTeachersDetaitls.Attributes.Add("class", "active");
                    aStaffDetails.Attributes.Add("class", "");
                }
                else
                {
                    aTeachersDetaitls.Attributes.Add("class", "");
                    aStaffDetails.Attributes.Add("class", "active");
                }
                ChecKAccount();
            }


        }
    }


    protected void ChecKAccount()
    {

        DataTable dt = TMSLeaveDetails.GetSearch(null, Convert.ToInt64(Session["AccountID"]), Session["type"].ToString(), null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1).Tables[0];
        if (dt.Rows.Count > 0)
        {
            Int64 ID = Convert.ToInt64(dt.Rows[0]["LD_LeaveDetailsId"]);
            hiddLeaveID.Value = dt.Rows[0]["LD_LeaveDetailsId"].ToString();
            btnsave.Text = "Update";
            TMSLeaveDetails objleave = TMSLeaveDetails.Get(ID);
            txtCLLeave.Text = objleave.LDCasualLeave.ToString();
            txtPLLeave.Text = objleave.LDPaidLeave.ToString();
            txtSLLeave.Text = objleave.LDSickLeave.ToString();
            txtELLeave.Text = objleave.LDEarnedLeave.ToString();
            txtOLLeave.Text = objleave.LDOtherLeave.ToString();
            txtMaritalLeave.Text = objleave.LDMartialLeave.ToString();
            txtMaternityLeave.Text = objleave.LDMartinityLeave.ToString();
            DataTable dtCL = TMSLeaveAdvancedDetails.FillAdvaceLeave(ID, Convert.ToInt64(Session["AccountID"]), "CL", Session["type"].ToString()).Tables[0];
            if (dtCL.Rows.Count > 0)
            {

                hiddenClID.Value = dtCL.Rows[0]["LAD_DetailsId"].ToString();
                txtCLJan.Text = dtCL.Rows[0]["LAD_Jan"].ToString();
                txtCLFeb.Text = dtCL.Rows[0]["LAD_Feb"].ToString();
                txtCLMar.Text = dtCL.Rows[0]["LAD_Mar"].ToString();
                txtCLApr.Text = dtCL.Rows[0]["LAD_Apr"].ToString();
                txtCLMay.Text = dtCL.Rows[0]["LAD_May"].ToString();
                txtCLJun.Text = dtCL.Rows[0]["LAD_June"].ToString();
                txtCLJul.Text = dtCL.Rows[0]["LAD_July"].ToString();
                txtCLAug.Text = dtCL.Rows[0]["LAD_Aug"].ToString();
                txtCLSep.Text = dtCL.Rows[0]["LAD_Sep"].ToString();
                txtCLOct.Text = dtCL.Rows[0]["LAD_Oct"].ToString();
                txtCLNov.Text = dtCL.Rows[0]["LAD_Nov"].ToString();
                txtCLDec.Text = dtCL.Rows[0]["LAD_Dec"].ToString();
            }

            DataTable dtPL = TMSLeaveAdvancedDetails.FillAdvaceLeave(ID, Convert.ToInt64(Session["AccountID"]), "PL", Session["type"].ToString()).Tables[0];
            if (dtPL.Rows.Count > 0)
            {
                hiddPLID.Value = dtPL.Rows[0]["LAD_DetailsId"].ToString();
                txtPLJan.Text = dtPL.Rows[0]["LAD_Jan"].ToString();
                txtPLFeb.Text = dtPL.Rows[0]["LAD_Feb"].ToString();
                txtPLMar.Text = dtPL.Rows[0]["LAD_Mar"].ToString();
                txtPLApr.Text = dtPL.Rows[0]["LAD_Apr"].ToString();
                txtPLMay.Text = dtPL.Rows[0]["LAD_May"].ToString();
                txtPLJun.Text = dtPL.Rows[0]["LAD_June"].ToString();
                txtPLJul.Text = dtPL.Rows[0]["LAD_July"].ToString();
                txtPLAug.Text = dtPL.Rows[0]["LAD_Aug"].ToString();
                txtPLSep.Text = dtPL.Rows[0]["LAD_Sep"].ToString();
                txtPLOct.Text = dtPL.Rows[0]["LAD_Oct"].ToString();
                txtPLNov.Text = dtPL.Rows[0]["LAD_Nov"].ToString();
                txtPLDec.Text = dtPL.Rows[0]["LAD_Dec"].ToString();
            }



            DataTable dtSL = TMSLeaveAdvancedDetails.FillAdvaceLeave(ID, Convert.ToInt64(Session["AccountID"]), "SL", Session["type"].ToString()).Tables[0];
            if (dtSL.Rows.Count > 0)
            {

                hiddSLID.Value = dtSL.Rows[0]["LAD_DetailsId"].ToString();
                txtSLJan.Text = dtSL.Rows[0]["LAD_Jan"].ToString();
                txtSLFeb.Text = dtSL.Rows[0]["LAD_Feb"].ToString();
                txtSLMar.Text = dtSL.Rows[0]["LAD_Mar"].ToString();
                txtSLApr.Text = dtSL.Rows[0]["LAD_Apr"].ToString();
                txtSLMay.Text = dtSL.Rows[0]["LAD_May"].ToString();
                txtSLJun.Text = dtSL.Rows[0]["LAD_June"].ToString();
                txtSLJul.Text = dtSL.Rows[0]["LAD_July"].ToString();
                txtSLAug.Text = dtSL.Rows[0]["LAD_Aug"].ToString();
                txtSLSep.Text = dtSL.Rows[0]["LAD_Sep"].ToString();
                txtSLOct.Text = dtSL.Rows[0]["LAD_Oct"].ToString();
                txtSLNov.Text = dtSL.Rows[0]["LAD_Nov"].ToString();
                txtSLDec.Text = dtSL.Rows[0]["LAD_Dec"].ToString();
            }

            DataTable dtEL = TMSLeaveAdvancedDetails.FillAdvaceLeave(ID, Convert.ToInt64(Session["AccountID"]), "EL", Session["type"].ToString()).Tables[0];
            if (dtEL.Rows.Count > 0)
            {
                hiddELID.Value = dtEL.Rows[0]["LAD_DetailsId"].ToString();
                txtELJan.Text = dtEL.Rows[0]["LAD_Jan"].ToString();
                txtELFeb.Text = dtEL.Rows[0]["LAD_Feb"].ToString();
                txtELMar.Text = dtEL.Rows[0]["LAD_Mar"].ToString();
                txtELApr.Text = dtEL.Rows[0]["LAD_Apr"].ToString();
                txtELMay.Text = dtEL.Rows[0]["LAD_May"].ToString();
                txtELJun.Text = dtEL.Rows[0]["LAD_June"].ToString();
                txtELJul.Text = dtEL.Rows[0]["LAD_July"].ToString();
                txtELAug.Text = dtEL.Rows[0]["LAD_Aug"].ToString();
                txtELSep.Text = dtEL.Rows[0]["LAD_Sep"].ToString();
                txtELOct.Text = dtEL.Rows[0]["LAD_Oct"].ToString();
                txtELNov.Text = dtEL.Rows[0]["LAD_Nov"].ToString();
                txtELDec.Text = dtEL.Rows[0]["LAD_Dec"].ToString();
            }

        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {

            if (btnsave.Text == "Update")
            {

                TMSLeaveDetails objleave = TMSLeaveDetails.Get(Convert.ToInt64(hiddLeaveID.Value));
                objleave.LDCasualLeave = Convert.ToInt32(txtCLLeave.Text);
                objleave.LDPaidLeave = Convert.ToInt32(txtPLLeave.Text);
                objleave.LDSickLeave = Convert.ToInt32(txtSLLeave.Text);
                objleave.LDEarnedLeave = Convert.ToInt32(txtELLeave.Text);
                objleave.LDOtherLeave = Convert.ToInt32(txtOLLeave.Text);
                objleave.LDMartialLeave = Convert.ToInt32(txtMaritalLeave.Text);
                objleave.LDMartinityLeave = Convert.ToInt32(txtMaternityLeave.Text);
                objleave.LDFacultyLoginId = Convert.ToInt64(Session["AccountID"]);
                objleave.LDFacultyType = Session["type"].ToString();
                objleave.LDAddedById = Convert.ToInt64(Session["UserId"]);
                objleave.LDDate = DateTime.Now;
                // objleave.LDYear = DateTime.Now.Yearn.ToString ();
                objleave.LDStatus = 1;
                objleave.Insert();



                TMSLeaveAdvancedDetails objadv = TMSLeaveAdvancedDetails.Get(Convert.ToInt64(hiddenClID.Value));
                objadv.LADLeaveDetailId = Convert.ToInt64(hiddLeaveID.Value);
                objadv.LADLeaveType = "CL";
                objadv.LADJan = Convert.ToInt32(txtCLJan.Text);
                objadv.LADFeb = Convert.ToInt32(txtCLFeb.Text);
                objadv.LADMar = Convert.ToInt32(txtCLMar.Text);
                objadv.LADApr = Convert.ToInt32(txtCLApr.Text);
                objadv.LADMay = Convert.ToInt32(txtCLMay.Text);
                objadv.LADJune = Convert.ToInt32(txtCLJun.Text);
                objadv.LADJuly = Convert.ToInt32(txtCLJul.Text);
                objadv.LADAug = Convert.ToInt32(txtCLAug.Text);
                objadv.LADSep = Convert.ToInt32(txtCLSep.Text);
                objadv.LADOct = Convert.ToInt32(txtCLOct.Text);
                objadv.LADNov = Convert.ToInt32(txtCLNov.Text);
                objadv.LADDec = Convert.ToInt32(txtCLDec.Text);
                objadv.LADFacultyLoginId = Convert.ToInt64(Session["AccountID"]);
                objadv.LADFacultyType = Session["type"].ToString();
                objadv.LADDate = DateTime.Now;
                objadv.LADStatus = 1;
                objadv.Update();


                TMSLeaveAdvancedDetails objadv2 = TMSLeaveAdvancedDetails.Get(Convert.ToInt64(hiddPLID.Value));
                objadv2.LADLeaveDetailId = Convert.ToInt64(hiddLeaveID.Value);
                objadv2.LADLeaveType = "PL";
                objadv2.LADJan = Convert.ToInt32(txtPLJan.Text);
                objadv2.LADFeb = Convert.ToInt32(txtPLFeb.Text);
                objadv2.LADMar = Convert.ToInt32(txtPLMar.Text);
                objadv2.LADApr = Convert.ToInt32(txtPLApr.Text);
                objadv2.LADMay = Convert.ToInt32(txtPLMay.Text);
                objadv2.LADJune = Convert.ToInt32(txtPLJun.Text);
                objadv2.LADJuly = Convert.ToInt32(txtPLJul.Text);
                objadv2.LADAug = Convert.ToInt32(txtPLAug.Text);
                objadv2.LADSep = Convert.ToInt32(txtPLSep.Text);
                objadv2.LADOct = Convert.ToInt32(txtPLOct.Text);
                objadv2.LADNov = Convert.ToInt32(txtPLNov.Text);
                objadv2.LADDec = Convert.ToInt32(txtPLDec.Text);
                objadv2.LADFacultyLoginId = Convert.ToInt64(Session["AccountID"]);
                objadv2.LADFacultyType = Session["type"].ToString();
                objadv2.LADDate = DateTime.Now;
                objadv2.LADStatus = 1;
                objadv2.Update();

                TMSLeaveAdvancedDetails objadv3 = TMSLeaveAdvancedDetails.Get(Convert.ToInt64(hiddSLID.Value));
                objadv3.LADLeaveDetailId = Convert.ToInt64(hiddLeaveID.Value);
                objadv3.LADLeaveType = "SL";
                objadv3.LADJan = Convert.ToInt32(txtSLJan.Text);
                objadv3.LADFeb = Convert.ToInt32(txtSLFeb.Text);
                objadv3.LADMar = Convert.ToInt32(txtSLMar.Text);
                objadv3.LADApr = Convert.ToInt32(txtSLApr.Text);
                objadv3.LADMay = Convert.ToInt32(txtSLMay.Text);
                objadv3.LADJune = Convert.ToInt32(txtSLJun.Text);
                objadv3.LADJuly = Convert.ToInt32(txtSLJul.Text);
                objadv3.LADAug = Convert.ToInt32(txtSLAug.Text);
                objadv3.LADSep = Convert.ToInt32(txtSLSep.Text);
                objadv3.LADOct = Convert.ToInt32(txtSLOct.Text);
                objadv3.LADNov = Convert.ToInt32(txtSLNov.Text);
                objadv3.LADDec = Convert.ToInt32(txtSLDec.Text);
                objadv3.LADFacultyLoginId = Convert.ToInt64(Session["AccountID"]);
                objadv3.LADFacultyType = Session["type"].ToString();
                objadv3.LADDate = DateTime.Now;
                objadv3.LADStatus = 1;
                objadv3.Update();
                TMSLeaveAdvancedDetails objadv4 = TMSLeaveAdvancedDetails.Get(Convert.ToInt64(hiddELID.Value));
                objadv4.LADLeaveDetailId = Convert.ToInt64(hiddLeaveID.Value);
                objadv4.LADLeaveType = "EL";
                objadv4.LADJan = Convert.ToInt32(txtELJan.Text);
                objadv4.LADFeb = Convert.ToInt32(txtELFeb.Text);
                objadv4.LADMar = Convert.ToInt32(txtELMar.Text);
                objadv4.LADApr = Convert.ToInt32(txtELApr.Text);
                objadv4.LADMay = Convert.ToInt32(txtELMay.Text);
                objadv4.LADJune = Convert.ToInt32(txtELJun.Text);
                objadv4.LADJuly = Convert.ToInt32(txtELJul.Text);
                objadv4.LADAug = Convert.ToInt32(txtELAug.Text);
                objadv4.LADSep = Convert.ToInt32(txtELSep.Text);
                objadv4.LADOct = Convert.ToInt32(txtELOct.Text);
                objadv4.LADNov = Convert.ToInt32(txtELNov.Text);
                objadv4.LADDec = Convert.ToInt32(txtELDec.Text);
                objadv4.LADFacultyLoginId = Convert.ToInt64(Session["AccountID"]);
                objadv4.LADFacultyType = Session["type"].ToString();
                objadv4.LADDate = DateTime.Now;
                objadv4.LADStatus = 1;
                objadv4.Update();

                dvMsg.Visible = true;
                lblMessage.Text = "Leave Account  Updated Successfully !";
                dvMsg.Attributes.Add("class", "warring_msg");

            }

            else
            {


                TMSLeaveDetails objleave = new TMSLeaveDetails();
                objleave.LDCasualLeave = Convert.ToInt32(txtCLLeave.Text);
                objleave.LDPaidLeave = Convert.ToInt32(txtPLLeave.Text);
                objleave.LDSickLeave = Convert.ToInt32(txtSLLeave.Text);
                objleave.LDEarnedLeave = Convert.ToInt32(txtELLeave.Text);
                objleave.LDOtherLeave = Convert.ToInt32(txtOLLeave.Text);
                objleave.LDMartialLeave = Convert.ToInt32(txtMaritalLeave.Text);
                objleave.LDMartinityLeave = Convert.ToInt32(txtMaternityLeave.Text);
                objleave.LDFacultyLoginId = Convert.ToInt64(Session["AccountID"]);
                objleave.LDFacultyType = Session["type"].ToString();
                objleave.LDAddedById = Convert.ToInt64(Session["UserId"]);
                objleave.LDDate = DateTime.Now;
                // objleave.LDYear = DateTime.Now.Yearn.ToString ();
                objleave.LDStatus = 1;
                objleave.Insert();



                TMSLeaveAdvancedDetails objadv = new TMSLeaveAdvancedDetails();

                objadv.LADLeaveType = "CL";
                objadv.LADLeaveDetailId = objleave.LDLeaveDetailsId;
                objadv.LADJan = Convert.ToInt32(txtCLJan.Text);
                objadv.LADFeb = Convert.ToInt32(txtCLFeb.Text);
                objadv.LADMar = Convert.ToInt32(txtCLMar.Text);
                objadv.LADApr = Convert.ToInt32(txtCLApr.Text);
                objadv.LADMay = Convert.ToInt32(txtCLMay.Text);
                objadv.LADJune = Convert.ToInt32(txtCLJun.Text);
                objadv.LADJuly = Convert.ToInt32(txtCLJul.Text);
                objadv.LADAug = Convert.ToInt32(txtCLAug.Text);
                objadv.LADSep = Convert.ToInt32(txtCLSep.Text);
                objadv.LADOct = Convert.ToInt32(txtCLOct.Text);
                objadv.LADNov = Convert.ToInt32(txtCLNov.Text);
                objadv.LADDec = Convert.ToInt32(txtCLDec.Text);
                objadv.LADFacultyLoginId = Convert.ToInt64(Session["AccountID"]);
                objadv.LADFacultyType = Session["type"].ToString();
                objadv.LADDate = DateTime.Now;
                objadv.LADStatus = 1;
                objadv.Insert();


                objadv.LADLeaveType = "PL";
                objadv.LADLeaveDetailId = objleave.LDLeaveDetailsId;
                objadv.LADJan = Convert.ToInt32(txtPLJan.Text);
                objadv.LADFeb = Convert.ToInt32(txtPLFeb.Text);
                objadv.LADMar = Convert.ToInt32(txtPLMar.Text);
                objadv.LADApr = Convert.ToInt32(txtPLApr.Text);
                objadv.LADMay = Convert.ToInt32(txtPLMay.Text);
                objadv.LADJune = Convert.ToInt32(txtPLJun.Text);
                objadv.LADJuly = Convert.ToInt32(txtPLJul.Text);
                objadv.LADAug = Convert.ToInt32(txtPLAug.Text);
                objadv.LADSep = Convert.ToInt32(txtPLSep.Text);
                objadv.LADOct = Convert.ToInt32(txtPLOct.Text);
                objadv.LADNov = Convert.ToInt32(txtPLNov.Text);
                objadv.LADDec = Convert.ToInt32(txtPLDec.Text);
                objadv.LADFacultyLoginId = Convert.ToInt64(Session["AccountID"]);
                objadv.LADFacultyType = Session["type"].ToString();
                objadv.LADDate = DateTime.Now;
                objadv.LADStatus = 1;
                objadv.Insert();


                objadv.LADLeaveType = "SL";
                objadv.LADLeaveDetailId = objleave.LDLeaveDetailsId;
                objadv.LADJan = Convert.ToInt32(txtSLJan.Text);
                objadv.LADFeb = Convert.ToInt32(txtSLFeb.Text);
                objadv.LADMar = Convert.ToInt32(txtSLMar.Text);
                objadv.LADApr = Convert.ToInt32(txtSLApr.Text);
                objadv.LADMay = Convert.ToInt32(txtSLMay.Text);
                objadv.LADJune = Convert.ToInt32(txtSLJun.Text);
                objadv.LADJuly = Convert.ToInt32(txtSLJul.Text);
                objadv.LADAug = Convert.ToInt32(txtSLAug.Text);
                objadv.LADSep = Convert.ToInt32(txtSLSep.Text);
                objadv.LADOct = Convert.ToInt32(txtSLOct.Text);
                objadv.LADNov = Convert.ToInt32(txtSLNov.Text);
                objadv.LADDec = Convert.ToInt32(txtSLDec.Text);
                objadv.LADFacultyLoginId = Convert.ToInt64(Session["AccountID"]);
                objadv.LADFacultyType = Session["type"].ToString();
                objadv.LADDate = DateTime.Now;
                objadv.LADStatus = 1;
                objadv.Insert();

                objadv.LADLeaveType = "EL";
                objadv.LADLeaveDetailId = objleave.LDLeaveDetailsId;
                objadv.LADJan = Convert.ToInt32(txtELJan.Text);
                objadv.LADFeb = Convert.ToInt32(txtELFeb.Text);
                objadv.LADMar = Convert.ToInt32(txtELMar.Text);
                objadv.LADApr = Convert.ToInt32(txtELApr.Text);
                objadv.LADMay = Convert.ToInt32(txtELMay.Text);
                objadv.LADJune = Convert.ToInt32(txtELJun.Text);
                objadv.LADJuly = Convert.ToInt32(txtELJul.Text);
                objadv.LADAug = Convert.ToInt32(txtELAug.Text);
                objadv.LADSep = Convert.ToInt32(txtELSep.Text);
                objadv.LADOct = Convert.ToInt32(txtELOct.Text);
                objadv.LADNov = Convert.ToInt32(txtELNov.Text);
                objadv.LADDec = Convert.ToInt32(txtELDec.Text);
                objadv.LADFacultyLoginId = Convert.ToInt64(Session["AccountID"]);
                objadv.LADFacultyType = Session["type"].ToString();
                objadv.LADDate = DateTime.Now;
                objadv.LADStatus = 1;
                objadv.Insert();

                dvMsg.Visible = true;
                lblMessage.Text = "Leave Account  Added Successfully !";
                dvMsg.Attributes.Add("class", "warring_msg");

            }
        }

        catch { }
    }
}