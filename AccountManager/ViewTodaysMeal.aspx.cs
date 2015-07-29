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

public partial class Teacher_ViewTodaysMeal : System.Web.UI.Page
{
    string ObjectList = string.Empty;
    static int str111 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }
        else
        {
            if (Request["msg"] != null)
            {
                dvMsg.Visible = true;
                lblMessage.Text = Convert.ToString(Request["msg"]);
                dvMsg.Attributes.Add("class", "warring_msg");
            }
            if (!IsPostBack)
            {
                BindApplication();
            }
        }
    }
    protected void BindApplication()
    {
        try
        {
            DataTable dtApplication = TMSTodaysMealDetails.GetSearch(null, null,null,DateTime.Now, null,null,null,null,1).Tables[0];
            if (dtApplication.Rows.Count > 0)
            {
                lstApplication.DataSource = dtApplication;
                lstApplication.DataBind();
            }
            else
            {
                lstApplication.DataSource = null;
                lstApplication.DataBind();
            }
        }
        catch (Exception ex) { }

    }
    protected void lstApplication_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        try
        {    
            Label lblThumbnailName = (Label)e.Item.FindControl("lblThumbnailName");
            ImageButton imgbtnThum = (ImageButton)e.Item.FindControl("imgbtnThum");
            if (string.IsNullOrEmpty(lblThumbnailName.Text))
            {
                imgbtnThum.ImageUrl = "../UploadImages/NewsImages/NoImage.jpg";
            }
            else
            {
                imgbtnThum.ImageUrl = "../UploadImages/NewsImages/" + lblThumbnailName.Text;
            }
        }
        catch (Exception ex) { }
    }
    protected void DataPagerTrip_PreRender(object sender, EventArgs e)
    {
        try
        {
            BindApplication();
        }
        catch (Exception) { }
    }
    protected void btnimgbtnThum_Click(object sender, EventArgs e)
    {
        try
        {
           
        }
        catch (Exception ex) { }
    }
}
