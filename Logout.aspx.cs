﻿using System;
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

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["var"] != "" && Request.QueryString["var"] != null)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("Default.aspx?var=Logout", false);
        }
        else
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("Default.aspx?var=Expire", false);
        }
    }
}
