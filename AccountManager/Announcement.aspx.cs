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

public partial class TMSchoolMgmt_AccountManager_Announcement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }

        else
        {
            BindAnnounceMent();
        }
    }


    protected void BindAnnounceMent()
    {
        try
        {
            DataTable dtAnn = TMSSpecialAnnouncement.GetSearch(null, null, null, null, null, null, 1).Tables[0];
            if (dtAnn.Rows.Count > 0)
            {
                lstAnnouncement.DataSource = dtAnn;
                lstAnnouncement.DataBind();

            }
            else
            {
                lstAnnouncement.DataSource = null;
                lstAnnouncement.DataBind();

            }

        }
        catch (Exception ex) { }

    }

    protected void lstAnnouncement_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        try
        {
            Label lblAnnouncementId = (Label)e.Item.FindControl("lblAnnouncementId");
            Label lblDays = (Label)e.Item.FindControl("lblDays");
            DataTable dtAnnce = TMSSpecialAnnouncement.GetSearch(Convert.ToInt64(lblAnnouncementId.Text), null, null, null, null, null, 1).Tables[0];
            if (dtAnnce.Rows.Count > 0)
            {
                string Day = Convert.ToString(dtAnnce.Rows[0]["Days"]);
                string Hour = Convert.ToString(dtAnnce.Rows[0]["Hour"]);
                string Minute = Convert.ToString(dtAnnce.Rows[0]["Minute"]);
                string Second = Convert.ToString(dtAnnce.Rows[0]["Second"]);

                if ((Day == "0") && (Hour == "0"))
                {
                    if (Minute == "0")
                    {
                        if (Second == "1")
                        {
                            lblDays.Text = Second + " " + "second ago";
                        }
                        else
                        {
                            lblDays.Text = Second + " " + "seconds ago";
                        }
                    }
                    else
                    {
                        if (Minute == "1")
                        {
                            lblDays.Text = Minute + " " + "minute ago";
                        }
                        else
                        {
                            lblDays.Text = Minute + " " + "minutes ago";
                        }
                    }
                }
                else if (Day == "0")
                {
                    if (Hour == "1")
                    {
                        lblDays.Text = Hour + " " + "hour ago";
                    }
                    else
                    {
                        lblDays.Text = Hour + " " + "hours ago";
                    }
                }
                else
                {
                    if (Day == "1")
                    {
                        lblDays.Text = Day + " " + "day ago";
                    }
                    else
                    {
                        lblDays.Text = Day + " " + "days ago";
                    }
                }
            }
        }
        catch (Exception ex) { }
    }
    protected void DataPagerTrip_PreRender(object sender, EventArgs e)
    {
        try
        {
            BindAnnounceMent();
        }
        catch (Exception) { }
    }

}
