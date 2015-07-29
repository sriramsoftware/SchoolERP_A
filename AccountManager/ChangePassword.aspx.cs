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

public partial class TMSchoolMgmt_AccountManager_ChangePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ((System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("Password")).Attributes.Add("class", "Liactive");
        ((System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("ListMyAccount")).Style.Add("display", "block");
        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }
        if (Request["msg"] != null)
        {
            dvMsg.Visible = true;
            lblMessage.Text = Convert.ToString(Request["msg"]);
            dvMsg.Attributes.Add("class", "warring_msg");
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["UserId"] != null)
            {
                Int64 UserId = Convert.ToInt32(Session["UserId"]);
                DataTable dtUser = new DataTable();
                TMSUserLogin objUser = new TMSUserLogin();
                dtUser = TMSUserLogin.GetSearch(UserId, null, null, null, null, null, null, null, null, null, 1).Tables[0];
                if (dtUser.Rows.Count > 0)
                {
                    string password = dtUser.Rows[0]["UL_UserPassword"].ToString();
                    string decryptPass = decryptPassword(password);
                    if (txtCurrentPassword.Text == decryptPass)
                    {
                        TMSUserLogin objLogin = TMSUserLogin.Get(UserId);
                        string password2 = txtNewPassword.Text;
                        string encryptPass = encrypPassword(password2);
                        objLogin.ULUserPassword = encryptPass;
                        objLogin.Update();
                        dvMsg.Visible = true;
                        lblMessage.Text = "Password Changed Successfully...!";
                        dvMsg.Attributes.Add("class", "warring_msg");
                    }
                    else
                    {
                        dvMsg.Visible = true;
                        lblMessage.Text = "Current Password is Wrong  Please Try Again....!";
                        dvMsg.Attributes.Add("class", "error_msg");

                    }
                }
                else
                {
                    dvMsg.Visible = true;
                    lblMessage.Visible = true;
                    lblMessage.Text = "No Records Found";
                }
            }
        }
        catch (Exception ex) { }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccountManagerDashBoard.aspx", false);
    }
    public string encrypPassword(string sData)
    {
        string encodedData = "";
        try
        {
            byte[] encData_byte = new byte[sData.Length];
            encData_byte = System.Text.Encoding.UTF8.GetBytes(sData);
            encodedData = Convert.ToBase64String(encData_byte);
        }
        catch (Exception ex)
        {
            throw new Exception("Error in base64Encode" + ex.Message);
        }
        return encodedData;
    }
    public string decryptPassword(string sData)
    {
        string result = "";
        try
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(sData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            result = new string(decoded_char);
        }
        catch
        {
        }
        return result;
    }
}
