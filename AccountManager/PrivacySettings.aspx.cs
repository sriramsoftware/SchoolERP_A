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

public partial class TMSchoolMgmt_AccountManager_PrivacySettings : System.Web.UI.Page
{
     protected void Page_Load(object sender, EventArgs e)
    {
        ((System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("Settings")).Attributes.Add("class", "Liactive");
        ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("ListMyAccount")).Style.Add("display", "block");

        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }
        if (!IsPostBack)
        {
            if (Request["msg"] != null)
            {
                dvMsg.Visible = true;
                lblMessage.Text = Convert.ToString(Request["msg"]);
                dvMsg.Attributes.Add("class", "warring_msg");
            }
            BindPrivacyDetails();
        }
    }
    protected void BindPrivacyDetails()
    {
        try
        {
            DataTable dtPrivacy = TMSPrivacySettings.GetSearch(null, Convert.ToInt64(Session["UserId"]), null, null, null, null, null, null, null, null, null, null, null, 1).Tables[0];
            if (dtPrivacy.Rows.Count > 0)
            {
                if (dtPrivacy.Rows[0]["PS_DisplayPhoto"].ToString() == "Yes")
                {
                    rdbPhotoOne.Checked = true;
                    rdbPhotoTwo.Checked = false;
                }
                else
                {
                    rdbPhotoOne.Checked = false;
                    rdbPhotoTwo.Checked = true;
                }
                if (dtPrivacy.Rows[0]["PS_DisplayEducation"].ToString() == "Yes")
                {
                    rdbEducatioOne.Checked = true;
                    rdbEducatioTwo.Checked = false;
                }
                else
                {
                    rdbEducatioOne.Checked = false;
                    rdbEducatioTwo.Checked = true;
                }
                if (dtPrivacy.Rows[0]["PS_DisplayConatctDetails"].ToString() == "Yes")
                {

                    rdbContactOne.Checked = true;
                    rdbContactTwo.Checked = false;
                }
                else
                {
                    rdbContactOne.Checked = false;
                    rdbContactTwo.Checked = true;
                }
                if (dtPrivacy.Rows[0]["PS_DisplayLocation"].ToString() == "Yes")
                {
                    rdbLocationOne.Checked = true;
                    rdbLocationTwo.Checked = false;
                }
                else
                {
                    rdbLocationOne.Checked = false;
                    rdbLocationTwo.Checked = true;
                }

                ViewState["PrivacySettingsId"] = Convert.ToInt64(dtPrivacy.Rows[0]["PS_PrivacyId"]);
            }
            else
            {
                ViewState["PrivacySettingsId"] = null;
            }
        }
        catch (Exception ex) { }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            string Image = null;
            string Contact = null;
            string Education = null;
            string Location = null;
            if (rdbLocationOne.Checked == true)
            {
                Location = "Yes";
            }
            if (rdbLocationTwo.Checked == true)
            {
                Location = "No";
            }
            if (rdbPhotoOne.Checked == true)
            {
                Image = "Yes";
            }
            if (rdbPhotoTwo.Checked == true)
            {
                Image = "No";
            }
            if (rdbEducatioOne.Checked == true)
            {
                Education = "Yes";
            }
            if (rdbEducatioTwo.Checked == true)
            {
                Education = "No";
            }
            if (rdbContactOne.Checked == true)
            {
                Contact = "Yes";
            }
            if (rdbContactTwo.Checked == true)
            {
                Contact = "No";
            }
            if (ViewState["PrivacySettingsId"] != null)
            {
                TMSPrivacySettings objPrivacy = TMSPrivacySettings.Get(Convert.ToInt64(ViewState["PrivacySettingsId"]));
                if (objPrivacy != null)
                {

                    objPrivacy.PSDisplayLocation = Location;
                    objPrivacy.PSDisplayPhoto = Image;
                    objPrivacy.PSDisplayEducation = Education;
                    objPrivacy.PSDisplayConatctDetails = Contact;
                    objPrivacy.PSDate = DateTime.Now;
                    objPrivacy.Update();
                    Response.Redirect("PrivacySettings.aspx?msg=Privacy Settings Updated Successfully...!!");
                }
            }
            else
            {
                TMSPrivacySettings objPrivacy = new TMSPrivacySettings();
                objPrivacy.PSFacultyLoginId = Convert.ToInt64(Session["UserId"]);
                objPrivacy.PSFacultyType = "Principal";
                objPrivacy.PSFacultyTypeId = 1;
                objPrivacy.PSDisplayLocation = Location;
                objPrivacy.PSDisplayPhoto = Image;
                objPrivacy.PSDisplayEducation = Education;
                objPrivacy.PSDisplayConatctDetails = Contact;
                objPrivacy.PSDate = DateTime.Now;
                objPrivacy.PSStatus = 1;
                objPrivacy.Insert();
                Response.Redirect("PrivacySettings.aspx?msg=Privacy Settings Added Successfully...!!");
            }
        }
        catch (Exception ex) { }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccountManagerDashBoard.aspx", false);
    }
}

