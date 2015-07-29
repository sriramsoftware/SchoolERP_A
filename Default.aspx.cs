using System;
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
using log4net;
using log4net.Config;
public partial class _Default : System.Web.UI.Page
{
    int cnt = 0;
    Helper help = new Helper();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //   SetMenu1();
            //imgImage1.ImageUrl = "~/UploadImages/NewsImages/Blue_hills_20120525121555.jpg";
           // GetOwnVideo();
           // BindGallery();
            // BindLatestNews();
            BindLoginSection();
            string logOutStr = Convert.ToString(Request["var"]);
            if (logOutStr == "Logout")
            {
                dverror.Style.Add("display", "block");
                lblMessage.InnerHtml = "Logout Successfully !";
                txtUserName.Focus();
            }
            #region Bind From The Desk of Director CMS Done By Amey On 11-July-12

            //BindFromTheDeskofDirectorCMS();

            #endregion
        }
    }
    private void BindLoginSection()
    {
        if (Session["UserId"] != null)
        {
            secLogin.Style.Add("display", "none");
            secLogout.Style.Add("display", "block");
            DataTable dtLoginInfo = null;
            if (Convert.ToInt32(Session["UserType"]) == 1)
            {
                dtLoginInfo = TMSFacultyDetails.GetPricipalDetails(Convert.ToInt32(Session["UserId"])).Tables[0];
                if (dtLoginInfo.Rows.Count > 0)
                {
                    lblUser.Text = dtLoginInfo.Rows[0]["FD_FirstName"].ToString() + " " + dtLoginInfo.Rows[0]["FD_LastName"].ToString();
                    lblLoginType.Text = "Login as Principal";
                    hrefDashboard.HRef = "Principal/DashboardPrincipal.aspx";
                }
                // Response.Redirect("Principal/DashboardPrincipal.aspx", false);
            }
            else if (Convert.ToInt32(Session["UserType"]) == 2)
            {
                dtLoginInfo = TMSFacultyDetails.GetCurrentStaffFacultyDetails(null, 2, Convert.ToInt32(Session["UserId"]), null, null).Tables[0];
                if (dtLoginInfo.Rows.Count > 0)
                {
                    lblUser.Text = dtLoginInfo.Rows[0]["FD_FirstName"].ToString() + " " + dtLoginInfo.Rows[0]["FD_LastName"].ToString();
                    lblLoginType.Text = "Login as Teacher";
                    hrefDashboard.HRef = "Teacher/DashboardTeacher.aspx";
                }
                // Response.Redirect("Teacher/DashboardTeacher.aspx", false);
            }
            else if (Convert.ToInt32(Session["UserType"]) == 3)
            {
                dtLoginInfo = TMSStudentDetails.GetParentName(Convert.ToInt32(Session["UserId"])).Tables[0];// TMSFacultyDetails.GetCurrentStaffFacultyDetails(null, 3, Convert.ToInt32(Session["UserId"]), null, null).Tables[0];
                if (dtLoginInfo.Rows.Count > 0)
                {
                    lblUser.Text = dtLoginInfo.Rows[0]["UserName"].ToString();// +" " + dtLoginInfo.Rows[0]["FD_LastName"].ToString();
                    lblLoginType.Text = "Login as Parent";
                    hrefDashboard.HRef = "Parents/ParentDashboard.aspx";
                }
                //  Response.Redirect("Parents/ParentDashboard.aspx", false);
            }
            else if (Convert.ToInt32(Session["UserType"]) == 4)
            {
                dtLoginInfo = TMSStudentDetails.GetStudentName(Convert.ToInt32(Session["UserId"])).Tables[0];// TMSFacultyDetails.GetCurrentStaffFacultyDetails(null, 3, Convert.ToInt32(Session["UserId"]), null, null).Tables[0];
                if (dtLoginInfo.Rows.Count > 0)
                {
                    lblUser.Text = dtLoginInfo.Rows[0]["UserName"].ToString();// +" " + dtLoginInfo.Rows[0]["FD_LastName"].ToString();
                    lblLoginType.Text = "Login as Student";
                    hrefDashboard.HRef = "Student/Dashboard.aspx";
                }
                // Response.Redirect("Student/Dashboard.aspx", false);
            }
            else if (Convert.ToInt32(Session["UserType"]) == 5)
            {
                dtLoginInfo = TMSFacultyDetails.GetCurrentStaffFacultyDetails(null, 5, Convert.ToInt32(Session["UserId"]), null, null).Tables[0];
                if (dtLoginInfo.Rows.Count > 0)
                {
                    lblUser.Text = dtLoginInfo.Rows[0]["FD_FirstName"].ToString() + " " + dtLoginInfo.Rows[0]["FD_LastName"].ToString();
                    lblLoginType.Text = "Login as Vendor";
                    hrefDashboard.HRef = "Vendor/VendorDashboard.aspx";
                }
                // Response.Redirect("Vendor/VendorDashboard.aspx", false);
            }
            else if (Convert.ToInt32(Session["UserType"]) == 6)
            {
                dtLoginInfo = TMSFacultyDetails.GetCurrentStaffFacultyDetails(null, 4, Convert.ToInt32(Session["UserId"]), null, null).Tables[0];
                if (dtLoginInfo.Rows.Count > 0)
                {
                    lblUser.Text = dtLoginInfo.Rows[0]["FD_FirstName"].ToString() + " " + dtLoginInfo.Rows[0]["FD_LastName"].ToString();
                    lblLoginType.Text = "Login as Transpotation";
                    hrefDashboard.HRef = "Transpotation/transportdashboard.aspx";
                }
                // Response.Redirect("Transpotation/transportdashboard.aspx", false);
            }
            else if (Convert.ToInt32(Session["UserType"]) == 7)
            {
                dtLoginInfo = TMSFacultyDetails.GetCurrentStaffFacultyDetails(null, 6, Convert.ToInt32(Session["UserId"]), null, null).Tables[0];
                if (dtLoginInfo.Rows.Count > 0)
                {
                    lblUser.Text = dtLoginInfo.Rows[0]["FD_FirstName"].ToString() + " " + dtLoginInfo.Rows[0]["FD_LastName"].ToString();
                    lblLoginType.Text = "Login as Librarian";
                    hrefDashboard.HRef = "Librarian/Librariandashboard.aspx";
                }
                //  Response.Redirect("Librarian/Librariandashboard.aspx", false);
            }
        }
    }
    protected void Page_Init(object sender, EventArgs e)
    {
        try
        {
            //SetMenu();
            /// SetMenu1();
        }
        catch (Exception) { }
    }
    private void BindLatestNews()
    {
        /*  DataTable dtNews = TMSNews.GetLatestNews(null, null, null, null, null, null).Tables[0];
          if (dtNews.Rows.Count != 0)
          {
              //Condition for News1
              string Heading1 = dtNews.Rows[0]["ND_Heading"].ToString();

              imgImage1.ImageUrl = "UploadImages/NewsImages/" + dtNews.Rows[0]["ND_ImagePath"].ToString();
              Int64 News1Id = Convert.ToInt64(dtNews.Rows[0]["NW_ID"]);
              amoreNews1.HRef = "~/NewsDetails.aspx?News_Id=" + News1Id;

           Int64 News2Id = Convert.ToInt64(dtNews.Rows[1]["NW_ID"]);

              amoreNews2.HRef = "~/NewsDetails.aspx?News_Id=" + News2Id;

              //string Image2 = dtNews.Rows[1]["News_Image"].ToString();
              imgImage2.ImageUrl = "UploadImages/NewsImages/" + dtNews.Rows[1]["ND_ImagePath"].ToString();
              if (Heading1.Length > 26)
              {
                  Heading1 = Heading1.Substring(0, 26);
                  lblNewsHeading1.Text = Heading1;
              }
              else
              {
                  lblNewsHeading1.Text = Heading1;
              }
              string Desc1 = dtNews.Rows[0]["ND_Description"].ToString();
              if (Desc1.Length > 100)
              {
                  Desc1 = Desc1.Substring(0, 40);
                  lblDescription1.Text = Desc1 + "...";
              }
              else
              {
                  lblDescription1.Text = Desc1;
              }

              //Condition for News2
              string Heading2 = dtNews.Rows[1]["ND_Heading"].ToString();
              if (Heading2.Length > 26)
              {
                  Heading2 = Heading2.Substring(0, 26);
                  lblNewsHeading2.Text = Heading2;
              }
              else
              {
                  lblNewsHeading2.Text = Heading2;
              }

              string Desc2 = dtNews.Rows[1]["ND_Description"].ToString();
              if (Desc2.Length > 100)
              {
                  Desc2 = Desc2.Substring(0, 40);
                  lblDescription2.Text = Desc2 + "...";
              }
              else
              {
                  lblDescription2.Text = Desc2;
              }
          }*/
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (ddlLogintype.SelectedIndex != 0)
        {
            try
            {
              //  DataTable dtLogin = TMSUserLogin.CheckLoginDetails(txtUserName.Text.Trim(), "c3VtaXQx", Convert.ToInt32(ddlLogintype.SelectedValue)).Tables[0];
             DataTable dtLogin = TMSUserLogin.CheckLoginDetails(txtUserName.Text.Trim(), help.encryptPassword(txtPassword.Text.Trim()), Convert.ToInt32(ddlLogintype.SelectedValue)).Tables[0];
                if (dtLogin.Rows.Count > 0)
                {
                    if (Convert.ToInt32(dtLogin.Rows[0]["UL_Status"]) == 0)
                    {
                        dverror.Style.Add("display", "block");
                        lblMessage.InnerHtml = "Your Account has been disabled, Please contact Admin !";
                        txtUserName.Focus();
                    }
                    else
                    {
                        DataTable dtUserName = null;
                        Session["UserId"] = dtLogin.Rows[0]["UL_LoginId"];
                        Session["Username"] = txtUserName.Text.Trim();
                        Session["Password"] = txtPassword.Text.Trim();
                        Session["UserType"] = dtLogin.Rows[0]["UL_UserType"];
                        string Uname = txtUserName.Text;
                        string Psw = txtPassword.Text;
                        if (Convert.ToInt32(Session["UserType"]) == 1)
                        {
                            dtUserName = TMSFacultyDetails.GetCurrentStaffFacultyDetails(null, null, Convert.ToInt64(Session["UserId"]), null, null).Tables[0];
                            if (dtUserName.Rows.Count > 0)
                            {
                                string name = dtUserName.Rows[0]["UserName"].ToString();
                                Session["LoginName"] = name;
                                ILog logger = log4net.LogManager.GetLogger("" + name + "(Principal)");
                                logger.Info("Login Time,This is info message");
                                logger.Debug("Login Time,This is Debug message");
                                logger.Error("Login Time,This is Error message");
                                logger.Warn("Login Time,This is Warn message");
                                logger.Fatal("Login Time,This is Fatal message");
                            }
                            Response.Redirect("Principal/DashboardPrincipal.aspx", false);
                        }
                        else if (Convert.ToInt32(Session["UserType"]) == 2)
                        {
                            dtUserName = TMSFacultyDetails.GetCurrentStaffFacultyDetails(null, null, Convert.ToInt64(Session["UserId"]), null, null).Tables[0];
                            if (dtUserName.Rows.Count > 0)
                            {
                                string name = dtUserName.Rows[0]["UserName"].ToString();
                                Session["LoginName"] = name;
                                ILog logger = log4net.LogManager.GetLogger("" + name + "(Principal)");
                                logger.Info("Login Time,This is info message");
                                logger.Debug("Login Time,This is Debug message");
                                logger.Error("Login Time,This is Error message");
                                logger.Warn("Login Time,This is Warn message");
                                logger.Fatal("Login Time,This is Fatal message");
                            }

                            Response.Redirect("Teacher/DashboardTeacher.aspx", false);
                        }
                        else if (Convert.ToInt32(Session["UserType"]) == 3)
                        {
                            Response.Redirect("Parents/ParentDashboard.aspx", false);
                        }
                        else if (Convert.ToInt32(Session["UserType"]) == 4)
                        {
                            Response.Redirect("Student/Dashboard.aspx", false);
                        }
                        else if (Convert.ToInt32(Session["UserType"]) == 5)
                        {
                            Response.Redirect("Vendor/VendorDashboard.aspx", false);
                        }
                        else if (Convert.ToInt32(Session["UserType"]) == 6)
                        {
                            Response.Redirect("Transpotation/transportdashboard.aspx", false);
                        }
                        else if (Convert.ToInt32(Session["UserType"]) == 7)
                        {
                            Response.Redirect("Librarian/Librariandashboard.aspx", false);
                        }
                        else if (Convert.ToInt32(Session["UserType"]) == 8)
                        {
                            Response.Redirect("AccountManager/AccountManagerDashboard.aspx", false);
                        }
                    }
                }
                else
                {
                    //If password not found in DB, display mesg to user.
                    dverror.Style.Add("display", "block");
                    lblMessage.InnerHtml = "Incorrect Username or Password !";
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                //Response.Write(ex);
            }
        }
        else
        {
            dverror.Style.Add("display", "block");
            lblMessage.InnerHtml = "Please Select Login Type !";
            txtUserName.Focus();
        }
    }
   
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        try
        {
            Session.Abandon();
            Response.Redirect("Logout.aspx?var=Logout", false);
        }
        catch (Exception) { }
    }
}