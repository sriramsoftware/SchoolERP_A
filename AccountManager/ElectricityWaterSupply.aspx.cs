using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class TMSchoolMgmt_AccountManager_ElectricityWaterSupply : System.Web.UI.Page
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

                BindEYear();
                BindElecricity();
            }
        }
    }
    protected void BindElecricity()
    {
        string Eyear = null;

        if (DdlElecricity.SelectedValue != "-1")
        {
            Eyear = DdlElecricity.SelectedValue;
        }
        else
        {
            Eyear = null;
        }

        DataTable DT = TMSElectricity.GetElectricitySEARCH(null, null, null, null, Eyear, null, null, null, null, null).Tables[0];

        if (DT.Rows.Count > 0)
        {
            HiddPaud.Value = DT.Rows[0]["EL_PaidStatus"].ToString();
            sortsection.Visible = true;
        }
        else
        {
            sortsection.Visible = false;
        }

        GrdElecricity.DataSource = DT;
        GrdElecricity.DataBind();
    }
    protected void BindEYear()
    {
        DataTable Dt = TMSElectricity.GetDistinctYear("Elecricity").Tables[0];
        DdlElecricity.DataSource = Dt;
        DdlElecricity.DataValueField = "DistYear";
        DdlElecricity.DataTextField = "DistYear";
        DdlElecricity.DataBind();
        DdlElecricity.Items.Insert(0, new ListItem("Select", "-1"));
    }
    protected void BindWYear()
    {
        DataTable Dt = TMSElectricity.GetDistinctYear("sdf").Tables[0];
        ddlwater.DataSource = Dt;
        ddlwater.DataValueField = "DistYear";
        ddlwater.DataTextField = "DistYear";
        ddlwater.DataBind();
        ddlwater.Items.Insert(0, new ListItem("Select", "-1"));
    }
    protected void BindWaterSupply()
    {
        try
        {
            string wyear = null;

            if (ddlwater.SelectedValue != "-1")
            {
                wyear = ddlwater.SelectedValue;
            }
            else
            {
                wyear = null;
            }

            DataTable dtGriedViewWater = TMSWatersupply.GetWatersupplySEARCH(null, null, null, null, wyear, null, null, null, null, null, null).Tables[0];
            if (dtGriedViewWater.Rows.Count > 0)
            {
                sectionSortWater.Visible = true;
            }
            else
            {
                sectionSortWater.Visible = false;
            }
            GrdWaterSupply.DataSource = dtGriedViewWater;
            GrdWaterSupply.DataBind();

        }
        catch (Exception ex) { }
    }
    protected void GriedViewWater_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            Label lblPaidStatus = e.Row.FindControl("lblPaidStatus") as Label;
            Label lblEl_EbillID = e.Row.FindControl("lblEl_EbillID") as Label;
            Label lblDiff = e.Row.FindControl("lblDiff") as Label;
            Label lblEL_BillAmount = e.Row.FindControl("lblBillAmount") as Label;
            Label lblTotalCost = e.Row.FindControl("lblTotalCost") as Label;
            Label lblEL_LateFees = e.Row.FindControl("lblLateFees") as Label;
            Label lblEl_BillPaidDate = e.Row.FindControl("lblEl_BillPaidDate") as Label;
            Label lblELLateFees = e.Row.FindControl("lblEL_LateFees") as Label;
            Label lblEL_LateFees1 = (Label)e.Row.FindControl("lblEL_LateFees1");

            if (lblPaidStatus != null)
            {

                if (lblPaidStatus.Text == "Unpaid")
                {
                    lblEl_BillPaidDate.Text = "";

                }
            }


            //if (Convert.ToInt32(lblDiff.Text) > 0)
            //{
            //    Double SS = (Convert.ToDouble(lblEL_LateFees.Text) * Convert.ToDouble(lblDiff.Text));

            //    lblTotalCost.Text = (Convert.ToDouble(lblEL_BillAmount.Text) + SS).ToString();


            //    if (lblELLateFees != null)
            //    {
            //        lblELLateFees.Text = lblDiff.Text + "  " + "x" + "  " + lblEL_LateFees.Text;
            //    }
            //    else
            //    {
            //        lblEL_LateFees1.Text = lblDiff.Text + "  " + "x" + "  " + lblEL_LateFees.Text;
            //    }
            //}
            //else
            //{
            lblTotalCost.Text = (Convert.ToInt64(lblEL_BillAmount.Text) + Convert.ToInt64(lblEL_LateFees.Text)).ToString();
            //if (lblELLateFees != null)
            //{
            //   // lblELLateFees.Text = "0" + "  " + "x" + "  " + lblEL_LateFees.Text;
            //}
            //else
            //{
            //   // lblEL_LateFees1.Text = "0" + "  " + "x" + "  " + lblEL_LateFees.Text; ;
            //}


        }
    }
    protected void aElectricSupply_Click(object sender, EventArgs e)
    {
        dvMsg.Visible = false;
        SElecricity.Visible = true;
        SWater.Visible = false;
        Addelecricity.Visible = false;
        AddwaterSupply.Visible = false;
        BindEYear();
        BindElecricity();
        aElectricSupply.Attributes.Add("class", "active");
        awaterSupply.Attributes.Add("class", "");
    }
    protected void awaterSupply_Click(object sender, EventArgs e)
    {
        dvMsg.Visible = false;
        BindWaterSupply();
        BindWYear();
        SElecricity.Visible = false;
        SWater.Visible = true;
        Addelecricity.Visible = false;
        AddwaterSupply.Visible = false;
        aElectricSupply.Attributes.Add("class", "");
        awaterSupply.Attributes.Add("class", "active");
    }
    protected void GriedViewWater_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdWaterSupply.PageIndex = e.NewPageIndex;
        BindWaterSupply();

    }
    protected void linkelectricity_Click(object sender, EventArgs e)
    {
        dvMsg.Visible = false;
        BindElecricity();
    }
    protected void linkwater_Click(object sender, EventArgs e)
    {
        dvMsg.Visible = false;
        BindWaterSupply();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {

            if (btnSubmit.Text == "Update")
            {


                Int64 EbillID = Convert.ToInt64(hiddElectricID.Value);


                DataTable Dt = TMSElectricity.BindAlredyexistElectricity(EbillID, null, null, ddlMonth.SelectedValue, ddlyear.SelectedValue, null, null, null, null, null).Tables[0];
                if (Dt.Rows.Count > 0)
                {
                    dvMsg.Visible = true;
                    lblMessage.Text = "record already exists for entered month and year";
                    dvMsg.Attributes.Add("class", "error_msg");
                    return;
                }

                else
                {

                    TMSElectricity objelectricity = TMSElectricity.Get(EbillID);
                    if (objelectricity != null)
                    {
                        objelectricity.ELBillAmount = Convert.ToDouble(txtBillAmount.Text);
                        objelectricity.ELLateFees = Convert.ToDouble(txtLateFees.Text);
                        objelectricity.ELBIllno = txtBillNumber.Text;
                        objelectricity.ElLastDate = txtDate1.SelectedDate;
                        objelectricity.ELMonth = ddlMonth.SelectedValue;
                        objelectricity.ElYear = ddlyear.SelectedValue;

                        if (HidduploadeFile.Value == "")
                        {
                            if (UploadFile.FileName != "")
                            {

                                string strFatherFileNameWithPath2 = UploadFile.FileName;
                                string strFatherExtensionName2 = System.IO.Path.GetExtension(strFatherFileNameWithPath2).ToLower();
                                string strFatherFileName2 = System.IO.Path.GetFileName(strFatherFileNameWithPath2).Replace(" ", "_");
                                if (strFatherExtensionName2.Equals(".jpg") || strFatherExtensionName2.Equals(".gif") || strFatherExtensionName2.Equals(".png") || strFatherExtensionName2.Equals(".jpeg") || strFatherExtensionName2.Equals(".bmp"))
                                {

                                    string[] Name2 = strFatherFileName2.Split('.');
                                    string Fname2 = Name2[0];
                                    string ReplacFileName2 = Fname2 + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + strFatherExtensionName2;
                                    UploadFile.PostedFile.SaveAs(Server.MapPath(@"..\\Files\\" + ReplacFileName2));
                                    objelectricity.ELBillFile = "../Files/" + ReplacFileName2;
                                    // string ImgPath = "../Files/" + ReplacFileName2;

                                }
                                else
                                {
                                    dvMsg.Visible = true;
                                    lblMessage.Text = "Please Upload .jpg,.gif,.png,.jpeg,.bmp File Only";
                                    dvMsg.Attributes.Add("class", "error_msg");
                                    return;
                                }

                            }

                        }
                        objelectricity.ELPaidStatus = ddlpaidstatus.SelectedValue;
                        if (HiddPaud.Value == "Paid")
                        {
                            if (ddlpaidstatus.SelectedValue == "Unpaid")
                            {
                                //objelectricity.ElBillPaidDate = "";
                            }

                        }
                        else
                        {
                            if (ddlpaidstatus.SelectedValue == "Paid")
                            {

                                if (Convert.ToDateTime(objelectricity.ElLastDate) < DateTime.Now)
                                {
                                    DateTime myDate1 = DateTime.Now;
                                    DateTime myDate2 = Convert.ToDateTime(objelectricity.ElLastDate);
                                    TimeSpan difference = myDate1.Subtract(myDate2);

                                    Double totalDays = Convert.ToDouble(difference.TotalDays);
                                    string ss = totalDays.ToString();
                                    string[] one = ss.Split('.');

                                    if (totalDays > 0)
                                    {
                                        Double SS = (Convert.ToDouble(objelectricity.ELLateFees) * Convert.ToDouble(one[0]));

                                        objelectricity.ELTotalAmount = Convert.ToDouble(Convert.ToDouble(objelectricity.ELBillAmount) + SS);

                                        objelectricity.ElBillPaidDate = DateTime.Now;

                                    }

                                }

                                else
                                {

                                    objelectricity.ELTotalAmount = Convert.ToDouble(objelectricity.ELBillAmount);
                                    objelectricity.ElBillPaidDate = DateTime.Now;
                                }

                            }
                        }
                        objelectricity.ELDate = DateTime.Now;
                        objelectricity.ELStatus = 1;
                        objelectricity.Update();

                        SElecricity.Visible = true;
                        SWater.Visible = false;
                        Addelecricity.Visible = false;
                        AddwaterSupply.Visible = false;
                        BindEYear();
                        BindElecricity();
                        aElectricSupply.Attributes.Add("class", "active");
                        awaterSupply.Attributes.Add("class", "");
                        dvMsg.Visible = true;
                        lblMessage.Text = "Electricity Bill Updated Successfully";
                        dvMsg.Attributes.Add("class", "warring_msg");
                        //  Response.Redirect("ManageElectricity.aspx?msg=Electricity Updated Successfully");

                    }

                }
            }


            else
            {



                TMSElectricity objelectricity = new TMSElectricity();


                objelectricity.ELMonth = ddlMonth.SelectedValue;
                objelectricity.ElYear = ddlyear.SelectedValue;

                DataTable DtElectricity = TMSElectricity.GetSearch(objelectricity).Tables[0];


                if (DtElectricity.Rows.Count > 0)
                {
                    dvMsg.Visible = true;
                    lblMessage.Text = "record already exist For entered month And year";
                    dvMsg.Attributes.Add("class", "error_msg");
                    return;
                }

                else
                {
                    objelectricity.ElLastDate = txtDate1.SelectedDate;
                    objelectricity.ELBillAmount = Convert.ToDouble(txtBillAmount.Text);
                    objelectricity.ELLateFees = Convert.ToDouble(txtLateFees.Text);
                    objelectricity.ELBIllno = txtBillNumber.Text;

                    objelectricity.ELPaidStatus = "Unpaid";
                    objelectricity.ELDate = DateTime.Now;
                    objelectricity.ELStatus = 1;

                    if (UploadFile.FileName != "")
                    {

                        string strFatherFileNameWithPath2 = UploadFile.FileName;
                        string strFatherExtensionName2 = System.IO.Path.GetExtension(strFatherFileNameWithPath2).ToLower();
                        string strFatherFileName2 = System.IO.Path.GetFileName(strFatherFileNameWithPath2).Replace(" ", "_");
                        if (strFatherExtensionName2.Equals(".jpg") || strFatherExtensionName2.Equals(".gif") || strFatherExtensionName2.Equals(".png") || strFatherExtensionName2.Equals(".jpeg") || strFatherExtensionName2.Equals(".bmp"))
                        {

                            string[] Name2 = strFatherFileName2.Split('.');
                            string Fname2 = Name2[0];
                            string ReplacFileName2 = Fname2 + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + strFatherExtensionName2;
                            UploadFile.PostedFile.SaveAs(Server.MapPath(@"..\\Files\\" + ReplacFileName2));
                            objelectricity.ELBillFile = "../Files/" + ReplacFileName2;
                            //string ImgPath = "../Files/" + ReplacFileName2;

                        }
                        else
                        {
                            dvMsg.Visible = true;
                            lblMessage.Text = "Please Upload .jpg,.gif,.png,.jpeg,.bmp File Only";
                            dvMsg.Attributes.Add("class", "error_msg");
                            return;
                        }

                    }



                    objelectricity.Insert();
                    SElecricity.Visible = true;
                    SWater.Visible = false;
                    Addelecricity.Visible = false;
                    AddwaterSupply.Visible = false;
                    BindEYear();
                    BindElecricity();
                    aElectricSupply.Attributes.Add("class", "active");
                    awaterSupply.Attributes.Add("class", "");
                    dvMsg.Visible = true;
                    lblMessage.Text = "Electricity Bill Added Successfully";
                    dvMsg.Attributes.Add("class", "warring_msg");

                }
            }



        }
        catch (Exception ex)
        {

        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("ElectricityWaterSupply.aspx", false);
        }
        catch (Exception ex) { }
    }
    protected void AddElecricity_Click(object sender, EventArgs e)
    {

        lbladd.Text = "Add";
        dvMsg.Visible = false;
        ClearElecricity();
        SElecricity.Visible = false;
        SWater.Visible = false;
        Addelecricity.Visible = true;
        AddwaterSupply.Visible = false;
        aElectricSupply.Attributes.Add("class", "active");
        awaterSupply.Attributes.Add("class", "");
    }
    protected void ElecricityEdit_Click(object sender, EventArgs e)
    {
        dvMsg.Visible = false;
        lbladd.Text = "Edit";
        SElecricity.Visible = false;
        SWater.Visible = false;
        Addelecricity.Visible = true;
        AddwaterSupply.Visible = false;
        aElectricSupply.Attributes.Add("class", "active");
        awaterSupply.Attributes.Add("class", "");
        RequiredFieldValidator4.Visible = false;
        LinkButton lnkedite = (LinkButton)sender;

        GridViewRow Grd = (GridViewRow)lnkedite.NamingContainer;

        Label lblEl_EbillID = Grd.FindControl("lblEl_EbillID") as Label;

        //lblHead.Text = "Edit Electicity";
        btnSubmit.Text = "Update";
        liUnpaid.Visible = true;
        Int64 EbillID = Convert.ToInt64(lblEl_EbillID.Text);
        hiddElectricID.Value = lblEl_EbillID.Text;
        TMSElectricity objelectricity = TMSElectricity.Get(EbillID);
        if (objelectricity != null)
        {
            txtBillAmount.Text = objelectricity.ELBillAmount.ToString();
            txtLateFees.Text = objelectricity.ELLateFees.ToString();
            txtBillNumber.Text = objelectricity.ELBIllno;
            if (objelectricity.ElLastDate != null)
            {
                txtDate1.SelectedDate = objelectricity.ElLastDate;

            }
            ddlMonth.SelectedValue = objelectricity.ELMonth;
            ddlyear.SelectedValue = objelectricity.ElYear;
            ddlpaidstatus.SelectedValue = objelectricity.ELPaidStatus;
            HidduploadeFile.Value = "";
            if (objelectricity.ELBillFile != null)
            {
                Hylblfilename.Visible = true;
                Hylblfilename.NavigateUrl = objelectricity.ELBillFile;
                RequiredFieldValidator4.Visible = false;
                HidduploadeFile.Value = objelectricity.ELBillFile;
            }
            else
            {
                Hylblfilename.Visible = false;
            }
            HiddPaud.Value = objelectricity.ELPaidStatus;

        }




    }
    protected void GriedElecricSuppy_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            Label lblPaidStatus = e.Row.FindControl("lblPaidStatus") as Label;
            Label lblEl_EbillID = e.Row.FindControl("lblEl_EbillID") as Label;
            Label lblDiff = e.Row.FindControl("lblDiff") as Label;
            Label lblEL_BillAmount = e.Row.FindControl("lbEL_BillAmount") as Label;
            Label lblTotalCost = e.Row.FindControl("lblTotalCost") as Label;
            Label lblEL_LateFees = e.Row.FindControl("lbEL_LateFees") as Label;
            Label lblEl_BillPaidDate = e.Row.FindControl("lblEl_BillPaidDate") as Label;
            if (lblPaidStatus.Text == "Unpaid")
            {
                lblEl_BillPaidDate.Text = "";

            }
            //if (Convert.ToInt32(lblDiff.Text) > 0)
            //{
            // Double SS = (Convert.ToDouble(lblEL_LateFees.Text) * Convert.ToDouble(lblDiff.Text));
            //lblTotalCost.Text = (Convert.ToDouble(lblEL_BillAmount.Text) + SS).ToString();
            //lblEL_LateFees.Text = lblDiff.Text + "  " + "x" + "  " + lblEL_LateFees.Text;
            //}
            //else
            //{
            lblTotalCost.Text = (Convert.ToDouble(lblEL_BillAmount.Text) + Convert.ToDouble(lblEL_LateFees.Text)).ToString();
            //    lblEL_LateFees.Text = "0" + "  " + "x" + "  " + lblEL_LateFees.Text;
            //}
        }
    }
    protected void GrdElecricity_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            GrdElecricity.PageIndex = e.NewPageIndex;
            BindElecricity();
        }
        catch (Exception ex) { }
    }
    protected void WaterSupply_Click(object sender, EventArgs e)
    {
        dvMsg.Visible = false;
        ClearWater();
        SElecricity.Visible = false;
        SWater.Visible = false;
        Addelecricity.Visible = false;
        AddwaterSupply.Visible = true;
        aElectricSupply.Attributes.Add("class", "");
        awaterSupply.Attributes.Add("class", "active");
        lbladdw .Text = "Add";
    }
    protected void WaterEdit_Click(object sender, EventArgs e)
    {
        dvMsg.Visible = false;
        SElecricity.Visible = false;
        SWater.Visible = false;
        Addelecricity.Visible = false;
        AddwaterSupply.Visible = true;
        aElectricSupply.Attributes.Add("class", "");
        awaterSupply.Attributes.Add("class", "active");
        RequiredFieldValidator9.Visible = false;
        LinkButton lnkedite = (LinkButton)sender;
        lbladdw.Text = "Edit";
        GridViewRow Grd = (GridViewRow)lnkedite.NamingContainer;

        Label lblWS_WSID = Grd.FindControl("lblWS_WSID") as Label;

        bensubmitClick.Text = "Update";
        liWater1.Visible = true;
        Int64 WS_WSID = Convert.ToInt64(lblWS_WSID.Text);
        HiddwaterID.Value = lblWS_WSID.Text;
        TMSWatersupply objelectricity = TMSWatersupply.Get(WS_WSID);
        if (objelectricity != null)
        {
            txtwbillamount.Text = objelectricity.WSBillAmount.ToString();
            txtwlatefee.Text = objelectricity.WSLateFees.ToString();
            txtwbillno.Text = objelectricity.WSBillNumber;

            if (objelectricity.WSLastDate != null)
            {
                txtDate2.SelectedDate = objelectricity.WSLastDate;

            }
            ddlmonthw.SelectedValue = objelectricity.WSMonth;
            ddlyearw.SelectedValue = objelectricity.WSYear;
            ddlpaidstatuswater.SelectedValue = objelectricity.WSPaidStatus;


            HidduploadeFile.Value = "";
            if (objelectricity.WSExtra1 != null)
            {
                Hyperwater.Visible = true;
                Hyperwater.NavigateUrl = objelectricity.WSExtra1;
                RequiredFieldValidator9.Visible = false;
                HidduploadeFile.Value = objelectricity.WSExtra1;
            }
            else
            {
                Hyperwater.Visible = false;
            }
            HiddPaud.Value = objelectricity.WSPaidStatus;

        }



    }
    protected void GrdWaterSupply_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            Label lblPaidStatus = e.Row.FindControl("lbEL_PaidStatus") as Label;
            Label lblEl_EbillID = e.Row.FindControl("lblWS_WSID") as Label;
            Label lblDiff = e.Row.FindControl("lblDiff") as Label;
            Label lblEL_BillAmount = e.Row.FindControl("lbEL_BillAmount") as Label;
            Label lblTotalCost = e.Row.FindControl("lblTotalCost") as Label;
            Label lblEL_LateFees = e.Row.FindControl("lbEL_LateFees") as Label;
            Label lblEl_BillPaidDate = e.Row.FindControl("lblEl_BillPaidDate") as Label;

            if (lblPaidStatus.Text == "Unpaid")
            {
                lblEl_BillPaidDate.Text = "";

            }
            //else
            //{

            //if (Convert.ToInt32(lblDiff.Text) > 0)
            //{
            //    Double SS = (Convert.ToDouble(lblEL_LateFees.Text) * Convert.ToDouble(lblDiff.Text));

            //    lblTotalCost.Text = (Convert.ToDouble(lblEL_BillAmount.Text) + SS).ToString();

            //    lblEL_LateFees.Text = lblDiff.Text + "  " + "x" + "  " + lblEL_LateFees.Text;
            //}
            //else
            //{
            lblTotalCost.Text = (Convert.ToDouble(lblEL_BillAmount.Text) + Convert.ToDouble(lblEL_LateFees.Text)).ToString();

            // lblEL_LateFees.Text = "0" + "  " + "x" + "  " + lblEL_LateFees.Text;
            // }


        }

    }
    protected void GrdWaterSupply_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            GrdWaterSupply.PageIndex = e.NewPageIndex;
            BindWaterSupply();
        }
        catch (Exception ex) { }
    }
    protected void bensubmitClick_Click(object sender, EventArgs e)
    {
        try
        {

            if (bensubmitClick.Text == "Update")
            {




                Int64 WSID = Convert.ToInt64(HiddwaterID.Value);
                DataTable Dt = TMSWatersupply.GetalredyexistWatersupply(WSID, null, null, ddlmonthw.SelectedValue, ddlyearw.SelectedValue, null, null, null, null, null, null, null, null).Tables[0];


                if (Dt.Rows.Count > 0)
                {
                    dvMsg.Visible = true;
                    lblMessage.Text = "record already exists for entered month and year";
                    dvMsg.Attributes.Add("class", "error_msg");
                    return;
                }

                else
                {

                    TMSWatersupply objelectricity = TMSWatersupply.Get(WSID);
                    if (objelectricity != null)
                    {

                        objelectricity.WSBillAmount = Convert.ToDouble(txtwbillamount.Text);
                        objelectricity.WSLateFees = Convert.ToDouble(txtwlatefee.Text);
                        objelectricity.WSBillNumber = txtwbillno.Text;
                        objelectricity.WSLastDate = txtDate2.SelectedDate;
                        objelectricity.WSMonth = ddlmonthw.SelectedValue;
                        objelectricity.WSYear = ddlyearw.SelectedValue;


                        if (HidduploadeFile.Value == "")
                        {
                            if (FileuploadWater.FileName != "")
                            {
                                bool isExist2 = false;
                                string strFatherFileNameWithPath2 = FileuploadWater.FileName;
                                string strFatherExtensionName2 = System.IO.Path.GetExtension(strFatherFileNameWithPath2).ToLower();
                                string strFatherFileName2 = System.IO.Path.GetFileName(strFatherFileNameWithPath2).Replace(" ", "_");
                                if (strFatherExtensionName2.Equals(".jpg") || strFatherExtensionName2.Equals(".gif") || strFatherExtensionName2.Equals(".png") || strFatherExtensionName2.Equals(".jpeg") || strFatherExtensionName2.Equals(".bmp"))
                                {

                                    string[] Name2 = strFatherFileName2.Split('.');
                                    string Fname2 = Name2[0];
                                    string ReplacFileName2 = Fname2 + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + strFatherExtensionName2;
                                    FileuploadWater.PostedFile.SaveAs(Server.MapPath(@"..\\Files\\" + ReplacFileName2));
                                    objelectricity.WSExtra1 = "../Files/" + ReplacFileName2;
                                }
                                else
                                {
                                    dvMsg.Visible = true;
                                    lblMessage.Text = "Please Upload .jpg,.gif,.png,.jpeg,.bmp File Only";
                                    dvMsg.Attributes.Add("class", "error_msg");
                                    return;
                                }

                            }

                        }



                        objelectricity.WSPaidStatus = ddlpaidstatuswater.SelectedValue;
                        if (HiddPaud.Value == "Paid")
                        {
                            if (ddlpaidstatuswater.SelectedValue == "Unpaid")
                            {

                            }

                        }
                        else
                        {
                            if (ddlpaidstatuswater.SelectedValue == "Paid")
                            {

                                if (Convert.ToDateTime(objelectricity.WSLastDate) < DateTime.Now)
                                {
                                    DateTime myDate1 = DateTime.Now;
                                    DateTime myDate2 = Convert.ToDateTime(objelectricity.WSLastDate);
                                    TimeSpan difference = myDate1.Subtract(myDate2);

                                    Double totalDays = Convert.ToDouble(difference.TotalDays);
                                    string ss = totalDays.ToString();
                                    string[] one = ss.Split('.');

                                    if (totalDays > 0)
                                    {
                                        Double SS = (Convert.ToDouble(objelectricity.WSLateFees) * Convert.ToDouble(one[0]));

                                        objelectricity.WSTotalAmount = (Convert.ToDouble(objelectricity.WSBillAmount) + SS);

                                        objelectricity.WSBillPaidDate = DateTime.Now;

                                    }

                                }

                                else
                                {

                                    objelectricity.WSTotalAmount = Convert.ToDouble(objelectricity.WSBillAmount);
                                    objelectricity.WSBillPaidDate = DateTime.Now;
                                }

                            }
                        }


                        objelectricity.WSDate = DateTime.Now;
                        objelectricity.WSStatus = 1;
                        objelectricity.Update();
                        BindWaterSupply();
                        BindWYear();
                        SElecricity.Visible = false;
                        SWater.Visible = true;
                        Addelecricity.Visible = false;
                        AddwaterSupply.Visible = false;
                        aElectricSupply.Attributes.Add("class", "");
                        awaterSupply.Attributes.Add("class", "active");
                        dvMsg.Visible = true;
                        lblMessage.Text = "Watrer Supply Bill Updated Successfully";
                        dvMsg.Attributes.Add("class", "warring_msg");

                    }

                }
            }


            else
            {



                TMSWatersupply objelectricity = new TMSWatersupply();

                objelectricity.WSMonth = ddlmonthw.SelectedValue;
                objelectricity.WSYear = ddlyearw.SelectedValue;

                DataTable DtTMSWatersupply = TMSWatersupply.GetSearch(objelectricity).Tables[0];
                if (DtTMSWatersupply.Rows.Count > 0)
                {
                    dvMsg.Visible = true;
                    lblMessage.Text = "record already exist For entered month and year";
                    dvMsg.Attributes.Add("class", "error_msg");
                    return;
                }

                else
                {

                    objelectricity.WSBillAmount = Convert.ToDouble(txtwbillamount.Text);
                    objelectricity.WSLateFees = Convert.ToDouble(txtwlatefee.Text);
                    objelectricity.WSBillNumber = txtwbillno.Text;
                    objelectricity.WSLastDate = txtDate2.SelectedDate;

                    objelectricity.WSPaidStatus = "Unpaid";
                    objelectricity.WSDate = DateTime.Now;
                    objelectricity.WSStatus = 1;

                    if (FileuploadWater.FileName != "")
                    {
                        bool isExist2 = false;
                        string strFatherFileNameWithPath2 = FileuploadWater.FileName;
                        string strFatherExtensionName2 = System.IO.Path.GetExtension(strFatherFileNameWithPath2).ToLower();
                        string strFatherFileName2 = System.IO.Path.GetFileName(strFatherFileNameWithPath2).Replace(" ", "_");
                        if (strFatherExtensionName2.Equals(".jpg") || strFatherExtensionName2.Equals(".gif") || strFatherExtensionName2.Equals(".png") || strFatherExtensionName2.Equals(".jpeg") || strFatherExtensionName2.Equals(".bmp"))
                        {

                            string[] Name2 = strFatherFileName2.Split('.');
                            string Fname2 = Name2[0];
                            string ReplacFileName2 = Fname2 + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + strFatherExtensionName2;
                            FileuploadWater.PostedFile.SaveAs(Server.MapPath(@"..\\Files\\" + ReplacFileName2));
                            objelectricity.WSExtra1 = "../Files/" + ReplacFileName2;
                        }
                        else
                        {
                            dvMsg.Visible = true;
                            lblMessage.Text = "Please Upload .jpg,.gif,.png,.jpeg,.bmp File Only";
                            dvMsg.Attributes.Add("class", "error_msg");
                            return;
                        }

                    }

                    objelectricity.Insert();
                    BindWaterSupply();
                    BindWYear();
                    SElecricity.Visible = false;
                    SWater.Visible = true;
                    Addelecricity.Visible = false;
                    AddwaterSupply.Visible = false;
                    aElectricSupply.Attributes.Add("class", "");
                    awaterSupply.Attributes.Add("class", "active");

                    dvMsg.Visible = true;
                    lblMessage.Text = "Watrer Supply Bill Added Successfully";
                    dvMsg.Attributes.Add("class", "warring_msg");

                }
            }

        }
        catch (Exception ex)
        {

        }
    }
    protected void benCancelClick_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("ElectricityWaterSupply.aspx", false);
        }
        catch (Exception ex) { }
    }
    protected void ClearElecricity()
    {

        txtBillAmount.Text = "";
        txtLateFees.Text = "";
        txtBillNumber.Text = "";
        HidduploadeFile.Value = "";
        Hylblfilename.Visible = false;
        txtDate1.SelectedDate = null;

        liUnpaid.Visible = false;
    }
    protected void ClearWater()
    {

        txtwbillamount.Text = "";
        txtwlatefee.Text = "";
        txtwbillno.Text = "";
        HidduploadeFile.Value = "";
        Hyperwater.Visible = false;
        txtDate2.SelectedDate = null;

        liWater1.Visible = false;
    }
}