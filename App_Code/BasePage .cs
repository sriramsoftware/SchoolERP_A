using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for BasePage
/// </summary>
public class BasePage : System.Web.UI.Page 
{
	public BasePage()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    protected override void OnInit(EventArgs e)
    {
        if (Session["UserId"] == null)
        {
            //Response.Redirect("~/Login.aspx");
         //  Response.Redirect("~/Admin/Login.aspx", false);
          Response.Redirect("~/Default.aspx",false ); 
        }
    }
}
