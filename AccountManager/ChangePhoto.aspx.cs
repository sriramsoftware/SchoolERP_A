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
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Web.Services;

public partial class Principal_ChangePhoto : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }

        if (Request.QueryString["msg"] != null)
        {
            dvMsg.Visible = true;
            lblMessage.Text = Request.QueryString["msg"];
            dvMsg.Attributes.Add("class", "warring_msg");
        }

        if (!IsPostBack)
        {
            {
                //image1.ImageUrl = Session["Imageurlt"].ToString();
                BindAcountManagerPhoto();
            }
        }
       
    }

    protected void BindAcountManagerPhoto()
    {
        try
        {
            Int64 UserId = Convert.ToInt64(Session["UserId"]);
            DataTable dtFaculty = TMSFacultyDetails.GetStaffFacultyDetails(null, 7, UserId).Tables[0];
            if (dtFaculty.Rows.Count > 0)
            {
                image1.ImageUrl = dtFaculty.Rows[0]["FD_Image"].ToString();
            }
        }
        catch (Exception ex) { }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
           
                 Int64 UserId = Convert.ToInt64(Session["UserId"]);

                  //DataTable dtFaculty = TMSFacultyDetails.GetSearch(null, UserId, 1, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1).Tables[0];
                  DataTable dtFaculty = TMSFacultyDetails.GetStaffFacultyDetails(null, 7, UserId).Tables[0];
                  if (dtFaculty.Rows.Count > 0)
                  { 
                      Int64 FacultyId = Convert.ToInt64(dtFaculty.Rows[0]["FD_FacultyDetailsId"]);
                      TMSFacultyDetails objFaculty = TMSFacultyDetails.Get(FacultyId);
                    if (objFaculty != null)
                    {
                        //objFaculty.FDImage = ImageE;

                        if (FileUpload1.PostedFile.FileName != "")
                        {
                            bool isExist = false;
                            string strFatherFileNameWithPath = FileUpload1.PostedFile.FileName;
                            string strFatherExtensionName = System.IO.Path.GetExtension(strFatherFileNameWithPath);
                            string strFatherFileName = System.IO.Path.GetFileName(strFatherFileNameWithPath).Replace(" ", "_");

                            if (strFatherExtensionName.Equals(".jpg") || strFatherExtensionName.Equals(".gif") || strFatherExtensionName.Equals(".png") || strFatherExtensionName.Equals(".jpeg") || strFatherExtensionName.Equals(".bmp"))
                            {
                                isExist = File.Exists(Server.MapPath(@"~\\UploadImages\\FacultyPhoto\\" + strFatherFileName));

                                string[] Name = strFatherFileName.Split('.');
                                string Fname = Name[0];
                                string ReplacFileName = Fname + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + strFatherExtensionName;
                                FileUpload1.PostedFile.SaveAs(Server.MapPath(@"..\\UploadImages\\FacultyPhoto\\" + ReplacFileName));
                                objFaculty.FDImage = "../UploadImages/FacultyPhoto/" + ReplacFileName;


                            }
                            else
                            {
                                dvMsg.Visible = true;
                                lblMessage.Text = "Please Upload .jpg,.gif,.jpeg,.bmp File Only !";
                                dvMsg.Attributes.Add("class", "error_msg");
                                return;
                            }
                        }

                        objFaculty.Update();
                        Response.Redirect("ChangePhoto.aspx?msg=Photo is updated Successfully");
                    }
                  
                  }
           
        }
        catch (Exception ex) { }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccountManagerDashboard.aspx");
    }


    //public string EditGetImage()
    //{

    //    string fileExist;
    //    string FilePath = "";
    //    string LogoPath = "";
    //    FileUpload img = FileUpload1;
    //    // FileUpload file_name = FileUpload1;
    //    string strFileNameWithPath = FileUpload1.PostedFile.FileName;
    //    string strExtensionName = System.IO.Path.GetExtension(strFileNameWithPath);
    //    string OldImage = Session["Imageurlt"].ToString();
    //    string strFileName = System.IO.Path.GetFileName(strFileNameWithPath).Replace(OldImage, strFileNameWithPath);
    //    if (strFileName.Equals(""))
    //    {
    //        if (strFileNameWithPath == "")
    //        {
    //            FilePath = OldImage;
    //            return FilePath;

    //        }
    //        else
    //        {
    //            FilePath = strFileNameWithPath;
    //            return FilePath;

    //        }
    //    }

    //    else
    //    {
    //        strExtensionName = strExtensionName.ToLower();
    //        if (strExtensionName.Equals(".jpg") || strExtensionName.Equals(".jpeg") || strExtensionName.Equals(".bmp") || strExtensionName.Equals(".png") || strExtensionName.Equals(".gif"))
    //        {
    //            if (!Directory.Exists(Server.MapPath(@"..\\UploadImages\\FacultyPhoto\\")))
    //            {
    //                Directory.CreateDirectory(Server.MapPath(@"..\\UploadImages\\FacultyPhoto\\"));
    //            }
    //            fileExist = "../UploadImages/FacultyPhoto/" + strFileName;
    //            if (File.Exists(Server.MapPath(fileExist)))
    //            {
    //                strFileName = "../UploadImages/FacultyPhoto/" + "User" + DateTime.Now.ToString("dd.MM.yyyy hh.ss.mm") + strExtensionName;
    //                FileUpload1.PostedFile.SaveAs(Server.MapPath(strFileName));
    //                FilePath = strFileName;
    //                return FilePath;
    //            }

    //            else
    //            {
    //                FileUpload1.PostedFile.SaveAs(Server.MapPath(fileExist));
    //                FilePath = fileExist;
    //                return FilePath;
    //            }
    //            //FileUpload1.PostedFile.SaveAs(Server.MapPath(@"..\\UploadImages\\NewsImages\\" + strFileName));
    //            //FileUpload1.PostedFile.SaveAs(Server.MapPath(strFileName));
    //            //FilePath = strFileName;
    //            //return FilePath;
    //        }
    //        else
    //            return "Ext";

    //    }

    //}
}
