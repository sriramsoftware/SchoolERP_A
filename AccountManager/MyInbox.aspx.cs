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

public partial class TMSchoolMgmt_AccountManager_MyInbox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dvMsg.Visible = false;

        if (Session["UserId"] == null)
        {
            Response.Redirect("../Default.aspx?var=Logout");
        }

        ((System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("Inbox")).Attributes.Add("class", "Liactive");
        Label lblMsgUnReadCnt = this.Master.FindControl("lblMsgUnReadCnt") as Label;
        if (lblMsgUnReadCnt.Text != "")
        {
            lblMsgUnReadCnt.Text = "(" + TMSMyMessageDetails.GetInboxCount(Convert.ToInt32(Session["UserId"])).ToString() + ")";
        }
        if (Request.QueryString["msg"] != null)
        {
            dvMsg.Visible = true;
            lblMessage.Text = Request.QueryString["msg"];
            dvMsg.Attributes.Add("class", "warring_msg");
        }

        if (!IsPostBack)
        {
            SectionInbox.Visible = true;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;
            sendall.Visible = false;
            sendtech.Visible = false;
            sendpart.Visible = false;
            sendstaf.Visible = false;
            sendPrincipal.Visible = false;
            ToPrincipal.Attributes.Add("class", "");
            MyInBox.Attributes.Add("class", "tabsactive");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "");
            ToParents.Attributes.Add("class", "");
            ToStaff.Attributes.Add("class", "");
            BindInboxItemMessage();
        }
    }
    protected void lstMessage_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        try
        {
            Label Days = (Label)e.Item.FindControl("lblDays");
            Label Hours = (Label)e.Item.FindControl("lblHours");
            Label Mins = (Label)e.Item.FindControl("lblMins");
            Label Seconds = (Label)e.Item.FindControl("lblSeconds");
            Label lblReadStatus = (Label)e.Item.FindControl("lblReadStatus");
            Label lblAgo = (Label)e.Item.FindControl("lblAgo");
            HtmlAnchor aSenderName = ((HtmlAnchor)e.Item.FindControl("aSenderName"));
            HtmlGenericControl SectionViewThreadMsg = (HtmlGenericControl)e.Item.FindControl("SectionViewThreadMsg");

            if (Convert.ToInt32(Days.Text) == 0 && Convert.ToInt32(Hours.Text) == 0 && Convert.ToInt32(Mins.Text) == 0)
            {
                if (Convert.ToInt32(Seconds.Text) <= 60)
                {
                    if (Convert.ToInt32(Seconds.Text) == 1)
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Seconds.Text + " " + "second ago";
                    }
                    else
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Seconds.Text + " " + "seconds ago";
                    }
                }
            }
            else
            {
                if (Convert.ToInt32(Days.Text) != 0)
                {
                    if (Convert.ToInt32(Days.Text) == 1)
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Days.Text + " " + "day ago";
                    }
                    else
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Days.Text + " " + "days ago";
                    }

                }
                else if (Convert.ToInt32(Hours.Text) != 0)
                {
                    if (Convert.ToInt32(Hours.Text) == 1)
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Hours.Text + " " + "hour ago";
                    }
                    else
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Hours.Text + " " + "hours ago";
                    }
                }
                else if (Convert.ToInt32(Mins.Text) != 0)
                {
                    if (Convert.ToInt32(Mins.Text) == 1)
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Mins.Text + " " + "minute ago";
                    }
                    else
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Mins.Text + " " + "minutes ago";
                    }
                }
            }

            if (Convert.ToInt64(lblReadStatus.Text) == 0)
            {
                aSenderName.Style.Add("font-weight", "bold");
                aSenderName.Style.Add("color", "#0D8EB9");
                aSenderName.Style.Add("font-size", "14px");
            }
            else
            {
                aSenderName.Style.Add("color", "#0D8EB9");
                aSenderName.Style.Add("font-weight", "normal");
            }
        }
        catch (Exception ex) { }
    }


    protected void lstMessage_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "MsgDelete")
            {
                Int64 MsgId = Convert.ToInt64(e.CommandArgument);
                TMSMyMessageDetails.Delete(MsgId, null);

                BindInboxItemMessage();

                SectionInbox.Visible = true;
                SectionCompose.Visible = false;
                SectionSentMsg.Visible = false;
                sendall.Visible = false;
                sendtech.Visible = false;
                sendpart.Visible = false;
                sendstaf.Visible = false;
                sendPrincipal.Visible = false;

                MyInBox.Attributes.Add("class", "tabsactive");
                MySentMesseages.Attributes.Add("class", "");
                Toall.Attributes.Add("class", "");
                ToTeccher.Attributes.Add("class", "");
                ToParents.Attributes.Add("class", "");
                ToStaff.Attributes.Add("class", "");
                ToPrincipal.Attributes.Add("class", "");



                dvMsg.Visible = true;
                lblMessage.Text = "Record Is Deleted Successfully";
                dvMsg.Attributes.Add("class", "warring_msg");

            }

            else
            {



            }

        }
        catch (Exception ex) { }

    }

    protected void lstMessage_ChangePage(object sender, PagePropertiesChangingEventArgs e)
    {
        dvMsg.Visible = false;
        DataPagerTrip.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
        BindInboxItemMessage();

    }
    
    protected void lstSentMsg_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        try
        {
            Label Days = (Label)e.Item.FindControl("lblDays");
            Label Hours = (Label)e.Item.FindControl("lblHours");
            Label Mins = (Label)e.Item.FindControl("lblMins");
            Label Seconds = (Label)e.Item.FindControl("lblSeconds");
            Label lblReadStatus = (Label)e.Item.FindControl("lblReadStatus");
            Label lblAgo = (Label)e.Item.FindControl("lblAgo");

            if (Convert.ToInt32(Days.Text) == 0 && Convert.ToInt32(Hours.Text) == 0 && Convert.ToInt32(Mins.Text) == 0)
            {
                if (Convert.ToInt32(Seconds.Text) <= 60)
                {
                    if (Convert.ToInt32(Seconds.Text) == 1)
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Seconds.Text + " " + "second ago";
                    }
                    else
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Seconds.Text + " " + "seconds ago";
                    }
                }
            }
            else
            {
                if (Convert.ToInt32(Days.Text) != 0)
                {
                    if (Convert.ToInt32(Days.Text) == 1)
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Days.Text + " " + "day ago";
                    }
                    else
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Days.Text + " " + "days ago";
                    }
                }
                else if (Convert.ToInt32(Hours.Text) != 0)
                {
                    if (Convert.ToInt32(Hours.Text) == 1)
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Hours.Text + " " + "hour ago";
                    }
                    else
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Hours.Text + " " + "hours ago";
                    }
                }
                else if (Convert.ToInt32(Mins.Text) != 0)
                {
                    if (Convert.ToInt32(Mins.Text) == 1)
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Mins.Text + " " + "minute ago";
                    }
                    else
                    {
                        lblAgo.Visible = true;
                        lblAgo.Text = Mins.Text + " " + "minutes ago";
                    }
                }
            }
        }
        catch (Exception ex) { }
    }



    protected void lstSentMsg_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "MsgDelete")
            {
                Int64 MsgId = Convert.ToInt64(e.CommandArgument);
                TMSMyMessageDetails.Delete(MsgId, null);

                BindSentItemMessage();


                SectionInbox.Visible = false;
                SectionCompose.Visible = false;
                SectionSentMsg.Visible = true;
                sendall.Visible = false;
                sendtech.Visible = false;
                sendpart.Visible = false;
                sendstaf.Visible = false;
                sendPrincipal.Visible = false;

                MyInBox.Attributes.Add("class", "");
                MySentMesseages.Attributes.Add("class", "tabsactive");
                Toall.Attributes.Add("class", "");
                ToTeccher.Attributes.Add("class", "");
                ToParents.Attributes.Add("class", "");
                ToStaff.Attributes.Add("class", "");
                ToPrincipal.Attributes.Add("class", "");



                dvMsg.Visible = true;
                lblMessage.Text = "Record Is Deleted Successfully";
                dvMsg.Attributes.Add("class", "warring_msg");

            }



        }
        catch (Exception ex) { }

    }


    protected void DataPagerSentMsg_PreRender(object sender, EventArgs e)
    {
        try
        {
            BindSentItemMessage();
        }
        catch (Exception) { }
    }


    protected void lstSentMsg_ChangePage(object sender, PagePropertiesChangingEventArgs e)
    {
        dvMsg.Visible = false;
        DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
        BindSentItemMessage();

    }





    protected void InBox_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            SectionInbox.Visible = true;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;
            sendall.Visible = false;
            sendtech.Visible = false;
            sendpart.Visible = false;
            sendstaf.Visible = false;
            sendPrincipal.Visible = false;

            MyInBox.Attributes.Add("class", "tabsactive");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "");
            ToParents.Attributes.Add("class", "");
            ToStaff.Attributes.Add("class", "");
            ToPrincipal.Attributes.Add("class", "");

            rbtnInboxMessage.SelectedIndex = 0;
            BindInboxItemMessage();

        }
        catch (Exception ex) { }
    }

    protected void MySentMesseages_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            SectionInbox.Visible = false;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = true;
            sendall.Visible = false;
            sendtech.Visible = false;
            sendpart.Visible = false;
            sendstaf.Visible = false;
            sendPrincipal.Visible = false;

            MyInBox.Attributes.Add("class", "");
            MySentMesseages.Attributes.Add("class", "tabsactive");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "");
            ToParents.Attributes.Add("class", "");
            ToStaff.Attributes.Add("class", "");
            ToPrincipal.Attributes.Add("class", "");
            rbtnSentMessage.SelectedIndex = 0;
            BindSentItemMessage();
        }
        catch (Exception ex) { }
    }




    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            if (Convert.ToString(Session["MsgType"]) == "Send To Principal  From Teachers")
            {
                TMSMyMessageDetails ObjMessage = new TMSMyMessageDetails();

                ObjMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDReceivedId = Convert.ToInt64(Session["RecieverId"]);
                ObjMessage.MMDReplyId = Convert.ToInt64(Session["MessageId"]);
                ObjMessage.MMDMessageSubject = txtSubject.Text;
                ObjMessage.MMDDescription = txtDesc.Text;
                ObjMessage.MMDMessageType = "Send To Teachers From Principal";
                ObjMessage.MMDMessageRemarks = "Send To Teachers";
                ObjMessage.MMDSendDate = DateTime.Now;
                ObjMessage.MMDStatus = 1;
                ObjMessage.Insert();


                BindSentItemMessage();
                dvMsg.Visible = true;
                lblMessage.Text = "Your Message has been sent successfully";
                dvMsg.Attributes.Add("class", "warring_msg");

                SectionInbox.Visible = false;
                SectionCompose.Visible = false;
                SectionSentMsg.Visible = true;
                sendall.Visible = false;
                sendtech.Visible = false;
                sendpart.Visible = false;
                sendstaf.Visible = false;

                MyInBox.Attributes.Add("class", "");
                MySentMesseages.Attributes.Add("class", "tabsactive");
                Toall.Attributes.Add("class", "");
                ToTeccher.Attributes.Add("class", "");
                ToParents.Attributes.Add("class", "");
                ToStaff.Attributes.Add("class", "");
                /*  BindInboxMessage();
                   dvMsg.Visible = true;
                   lblMessage.Text = "Your Message has been sent successfully";
                   dvMsg.Attributes.Add("class", "warring_msg");
                   SectionInbox.Visible = true;
                   SectionCompose.Visible = false;
                   SectionSentMsg.Visible = false;
                   MyInBox.Attributes.Add("class", "tabsactive");
                   MySentMesseages.Attributes.Add("class", ""); */
            }

            else if (Convert.ToString(Session["MsgType"]) == "Send To Principal  From Parents")
            {
                TMSMyMessageDetails ObjMessage = new TMSMyMessageDetails();
                ObjMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDReceivedId = Convert.ToInt64(Session["RecieverId"]);
                ObjMessage.MMDReplyId = Convert.ToInt64(Session["MessageId"]);
                ObjMessage.MMDMessageSubject = txtSubject.Text;
                ObjMessage.MMDDescription = txtDesc.Text;
                ObjMessage.MMDMessageType = "Send To Parents From Principal";
                ObjMessage.MMDMessageRemarks = "Send To Parents";
                ObjMessage.MMDSendDate = DateTime.Now;
                ObjMessage.MMDStatus = 1;
                ObjMessage.Insert();


                BindSentItemMessage();
                dvMsg.Visible = true;
                lblMessage.Text = "Your Message has been sent successfully";
                dvMsg.Attributes.Add("class", "warring_msg");

                SectionInbox.Visible = false;
                SectionCompose.Visible = false;
                SectionSentMsg.Visible = true;
                sendall.Visible = false;
                sendtech.Visible = false;
                sendpart.Visible = false;
                sendstaf.Visible = false;

                MyInBox.Attributes.Add("class", "");
                MySentMesseages.Attributes.Add("class", "tabsactive");
                Toall.Attributes.Add("class", "");
                ToTeccher.Attributes.Add("class", "");
                ToParents.Attributes.Add("class", "");
                ToStaff.Attributes.Add("class", "");

                /*  BindInboxMessage();
                    dvMsg.Visible = true;
                    lblMessage.Text = "Your Message has been sent successfully";
                    dvMsg.Attributes.Add("class", "warring_msg");
                    SectionInbox.Visible = true;
                    SectionCompose.Visible = false;
                    SectionSentMsg.Visible = false;
                    MyInBox.Attributes.Add("class", "tabsactive");
                    MySentMesseages.Attributes.Add("class", ""); */

            }

            else if (Convert.ToString(Session["MsgType"]) == "Send To Principal From Staff")
            {
                TMSMyMessageDetails ObjMessage = new TMSMyMessageDetails();

                ObjMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDReceivedId = Convert.ToInt64(Session["RecieverId"]);
                ObjMessage.MMDReplyId = Convert.ToInt64(Session["MessageId"]);
                ObjMessage.MMDMessageSubject = txtSubject.Text;
                ObjMessage.MMDDescription = txtDesc.Text;
                ObjMessage.MMDMessageType = "Send To Staff From Principal";
                ObjMessage.MMDMessageRemarks = "Send To Staff";
                ObjMessage.MMDSendDate = DateTime.Now;
                ObjMessage.MMDStatus = 1;
                ObjMessage.Insert();

                BindSentItemMessage();
                dvMsg.Visible = true;
                lblMessage.Text = "Your Message has been sent successfully";
                dvMsg.Attributes.Add("class", "warring_msg");

                SectionInbox.Visible = false;
                SectionCompose.Visible = false;
                SectionSentMsg.Visible = true;
                sendall.Visible = false;
                sendtech.Visible = false;
                sendpart.Visible = false;
                sendstaf.Visible = false;

                MyInBox.Attributes.Add("class", "");
                MySentMesseages.Attributes.Add("class", "tabsactive");
                Toall.Attributes.Add("class", "");
                ToTeccher.Attributes.Add("class", "");
                ToParents.Attributes.Add("class", "");
                ToStaff.Attributes.Add("class", "");

                /*  BindInboxMessage();
                    dvMsg.Visible = true;
                   lblMessage.Text = "Your Message has been sent successfully";
                   dvMsg.Attributes.Add("class", "warring_msg");
                   SectionInbox.Visible = true;
                   SectionCompose.Visible = false;
                   SectionSentMsg.Visible = false;
                   MyInBox.Attributes.Add("class", "tabsactive");
                   MySentMesseages.Attributes.Add("class", ""); */

            }


        }
        catch (Exception ex) { }

    }


    protected void btnCancelOne_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccountManagerDashboard.aspx", false);
    }


    protected void btnAnswer_Click(object sender, EventArgs e)
    {

        //LinkButton lnkReply = (LinkButton)sender;

        Button btnSend = (Button)sender;
        ListViewDataItem Replybtn = (ListViewDataItem)btnSend.NamingContainer;
        Label lblMessageId = Replybtn.FindControl("lblMessageId") as Label;
        TextBox txtMessage = (TextBox)Replybtn.FindControl("txtMessage");


        Int64 MsgId = Convert.ToInt64(lblMessageId.Text);

        //Session["MessageId"] = MsgId;


        SectionInbox.Visible = true;
        SectionCompose.Visible = false;
        SectionSentMsg.Visible = false;
        sendall.Visible = false;
        sendtech.Visible = false;
        sendpart.Visible = false;
        sendstaf.Visible = false;
        sendPrincipal.Visible = false;

        MyInBox.Attributes.Add("class", "tabsactive");
        MySentMesseages.Attributes.Add("class", "");
        Toall.Attributes.Add("class", "");
        ToTeccher.Attributes.Add("class", "");
        ToParents.Attributes.Add("class", "");
        ToStaff.Attributes.Add("class", "");
        ToPrincipal.Attributes.Add("class", "");



        TMSMyMessageDetails ObjMess = TMSMyMessageDetails.Get(MsgId);
        if (ObjMess != null)
        {
            string MessageSubject = ObjMess.MMDMessageSubject;
            string MessageType = ObjMess.MMDMessageType;

            Int64 ReplyId = Convert.ToInt64(ObjMess.MMDReplyId);

            if (ReplyId == 0)
            {
                Session["MessageId"] = MsgId;
                // Session["MessageId"] = ReplyId;
            }

            else
            {
                Session["MessageId"] = ReplyId;
                // Session["MessageId"] = MsgId;

            }

            Int64 SenderId = Convert.ToInt64(ObjMess.MMDSenderId);

            Session["RecieverId"] = SenderId; // Use this at the time of reply
            Session["MsgType"] = MessageType;
            Session["MsgSubject"] = MessageSubject;


        }

        if (txtMessage.Text != "")
        {

            if (Convert.ToString(Session["MsgType"]) == "Send To Staff From Principal")
            {
                TMSMyMessageDetails ObjMessage = new TMSMyMessageDetails();

                ObjMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDReceivedId = Convert.ToInt64(Session["RecieverId"]);
                ObjMessage.MMDReplyId = Convert.ToInt64(Session["MessageId"]);
                ObjMessage.MMDMessageSubject = Convert.ToString(Session["MsgSubject"]);
                ObjMessage.MMDDescription = txtMessage.Text;
                ObjMessage.MMDMessageType = "Send To Principal From Staff";
                ObjMessage.MMDMessageRemarks = "Send To Principal";
                ObjMessage.MMDSendDate = DateTime.Now;
                ObjMessage.MMDAddedByType = "Account Manager";
                ObjMessage.MMDStatus = 1;
                ObjMessage.MMDReadStatus = 0;
                ObjMessage.Insert();


                BindSentItemMessage();
                dvMsg.Visible = true;
                lblMessage.Text = "Your Message has been sent successfully";
                dvMsg.Attributes.Add("class", "warring_msg");


                SectionInbox.Visible = false;
                SectionCompose.Visible = false;
                SectionSentMsg.Visible = true;
                sendall.Visible = false;
                sendtech.Visible = false;
                sendpart.Visible = false;
                sendstaf.Visible = false;

                MyInBox.Attributes.Add("class", "");
                MySentMesseages.Attributes.Add("class", "tabsactive");
                Toall.Attributes.Add("class", "");
                ToTeccher.Attributes.Add("class", "");
                ToParents.Attributes.Add("class", "");
                ToStaff.Attributes.Add("class", "");


                /* BindInboxItemMessage();
                   dvMsg.Visible = true;
                   lblMessage.Text = "Your Message has been sent successfully";
                   dvMsg.Attributes.Add("class", "warring_msg");
                   SectionInbox.Visible = true;
                   SectionCompose.Visible = false;
                   SectionSentMsg.Visible = false;

                   MyInBox.Attributes.Add("class", "tabsactive");
                   MySentMesseages.Attributes.Add("class", ""); */

            }

            else if (Convert.ToString(Session["MsgType"]) == "Send To Staff From Teachers")
            {
                TMSMyMessageDetails ObjMessage = new TMSMyMessageDetails();

                ObjMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDReceivedId = Convert.ToInt64(Session["RecieverId"]);
                ObjMessage.MMDReplyId = Convert.ToInt64(Session["MessageId"]);
                ObjMessage.MMDMessageSubject = Convert.ToString(Session["MsgSubject"]);
                ObjMessage.MMDDescription = txtMessage.Text;
                ObjMessage.MMDMessageType = "Send To Teachers From Staff";
                ObjMessage.MMDMessageRemarks = "Send To Teachers";
                ObjMessage.MMDAddedByType = "Account Manager";
                ObjMessage.MMDSendDate = DateTime.Now;
                ObjMessage.MMDStatus = 1;
                ObjMessage.MMDReadStatus = 0;
                ObjMessage.Insert();


                BindSentItemMessage();
                dvMsg.Visible = true;
                lblMessage.Text = "Your Message has been sent successfully";
                dvMsg.Attributes.Add("class", "warring_msg");


                SectionInbox.Visible = false;
                SectionCompose.Visible = false;
                SectionSentMsg.Visible = true;
                sendall.Visible = false;
                sendtech.Visible = false;
                sendpart.Visible = false;
                sendstaf.Visible = false;

                MyInBox.Attributes.Add("class", "");
                MySentMesseages.Attributes.Add("class", "tabsactive");
                Toall.Attributes.Add("class", "");
                ToTeccher.Attributes.Add("class", "");
                ToParents.Attributes.Add("class", "");
                ToStaff.Attributes.Add("class", "");


                /* BindInboxItemMessage();
                   dvMsg.Visible = true;
                   lblMessage.Text = "Your Message has been sent successfully";
                   dvMsg.Attributes.Add("class", "warring_msg");
                   SectionInbox.Visible = true;
                   SectionCompose.Visible = false;
                   SectionSentMsg.Visible = false;

                   MyInBox.Attributes.Add("class", "tabsactive");
                   MySentMesseages.Attributes.Add("class", ""); */

            }

            else if (Convert.ToString(Session["MsgType"]) == "Send To Staff From Parents")
            {
                TMSMyMessageDetails ObjMessage = new TMSMyMessageDetails();
                ObjMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDReceivedId = Convert.ToInt64(Session["RecieverId"]);
                ObjMessage.MMDReplyId = Convert.ToInt64(Session["MessageId"]);
                ObjMessage.MMDMessageSubject = Convert.ToString(Session["MsgSubject"]);
                ObjMessage.MMDDescription = txtMessage.Text;
                ObjMessage.MMDMessageType = "Send To Parents From Staff";
                ObjMessage.MMDMessageRemarks = "Send To Parents";
                ObjMessage.MMDAddedByType = "Account Manager";
                ObjMessage.MMDSendDate = DateTime.Now;
                ObjMessage.MMDStatus = 1;
                ObjMessage.MMDReadStatus = 0;
                ObjMessage.Insert();

                BindSentItemMessage();
                dvMsg.Visible = true;
                lblMessage.Text = "Your Message has been sent successfully";
                dvMsg.Attributes.Add("class", "warring_msg");

                SectionInbox.Visible = false;
                SectionCompose.Visible = false;
                SectionSentMsg.Visible = true;
                sendall.Visible = false;
                sendtech.Visible = false;
                sendpart.Visible = false;
                sendstaf.Visible = false;

                MyInBox.Attributes.Add("class", "");
                MySentMesseages.Attributes.Add("class", "tabsactive");
                Toall.Attributes.Add("class", "");
                ToTeccher.Attributes.Add("class", "");
                ToParents.Attributes.Add("class", "");
                ToStaff.Attributes.Add("class", "");



                /*  BindInboxItemMessage();
                   dvMsg.Visible = true;
                   lblMessage.Text = "Your Message has been sent successfully";
                   dvMsg.Attributes.Add("class", "warring_msg");
                   SectionInbox.Visible = true;
                   SectionCompose.Visible = false;
                   SectionSentMsg.Visible = false;

                   MyInBox.Attributes.Add("class", "tabsactive");
                   MySentMesseages.Attributes.Add("class", ""); */


            }

            else if (Convert.ToString(Session["MsgType"]) == "Send To OtherStaff From Staff")
            {
                TMSMyMessageDetails ObjMessage = new TMSMyMessageDetails();

                ObjMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDReceivedId = Convert.ToInt64(Session["RecieverId"]);
                ObjMessage.MMDReplyId = Convert.ToInt64(Session["MessageId"]);
                ObjMessage.MMDMessageSubject = Convert.ToString(Session["MsgSubject"]);
                ObjMessage.MMDDescription = txtMessage.Text;
                ObjMessage.MMDMessageType = "Send To OtherStaff From Staff";
                ObjMessage.MMDMessageRemarks = "Send To Staff";
                ObjMessage.MMDAddedByType = "Account Manager";
                ObjMessage.MMDSendDate = DateTime.Now;
                ObjMessage.MMDReadStatus = 0;
                ObjMessage.MMDStatus = 1;
                ObjMessage.Insert();

                BindSentItemMessage();
                dvMsg.Visible = true;
                lblMessage.Text = "Your Message has been sent successfully";
                dvMsg.Attributes.Add("class", "warring_msg");

                SectionInbox.Visible = false;
                SectionCompose.Visible = false;
                SectionSentMsg.Visible = true;
                sendall.Visible = false;
                sendtech.Visible = false;
                sendpart.Visible = false;
                sendstaf.Visible = false;

                MyInBox.Attributes.Add("class", "");
                MySentMesseages.Attributes.Add("class", "tabsactive");
                Toall.Attributes.Add("class", "");
                ToTeccher.Attributes.Add("class", "");
                ToParents.Attributes.Add("class", "");
                ToStaff.Attributes.Add("class", "");

                /*  BindInboxItemMessage();
                   dvMsg.Visible = true;
                   lblMessage.Text = "Your Message has been sent successfully";
                   dvMsg.Attributes.Add("class", "warring_msg");
                   SectionInbox.Visible = true;
                   SectionCompose.Visible = false;
                   SectionSentMsg.Visible = false;
                   MyInBox.Attributes.Add("class", "tabsactive");
                   MySentMesseages.Attributes.Add("class", ""); */

            }
            else if (Convert.ToString(Session["MsgType"]) == "Send To Staff From Admin")
            {
                TMSMyMessageDetails ObjMessage = new TMSMyMessageDetails();

                ObjMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                ObjMessage.MMDReceivedId = Convert.ToInt64(Session["RecieverId"]);
                ObjMessage.MMDReplyId = Convert.ToInt64(Session["MessageId"]);
                ObjMessage.MMDMessageSubject = Convert.ToString(Session["MsgSubject"]);
                ObjMessage.MMDDescription = txtMessage.Text;
                ObjMessage.MMDMessageType = "Send To Admin From Staff";
                ObjMessage.MMDMessageRemarks = "Send To Admin";
                ObjMessage.MMDAddedByType = "Account Manager";
                ObjMessage.MMDSendDate = DateTime.Now;
                ObjMessage.MMDReadStatus = 0;
                ObjMessage.MMDStatus = 1;
                ObjMessage.Insert();

                BindSentItemMessage();
                dvMsg.Visible = true;
                lblMessage.Text = "Your Message has been sent successfully";
                dvMsg.Attributes.Add("class", "warring_msg");

                SectionInbox.Visible = false;
                SectionCompose.Visible = false;
                SectionSentMsg.Visible = true;
                sendall.Visible = false;
                sendtech.Visible = false;
                sendpart.Visible = false;
                sendstaf.Visible = false;

                MyInBox.Attributes.Add("class", "");
                MySentMesseages.Attributes.Add("class", "tabsactive");
                Toall.Attributes.Add("class", "");
                ToTeccher.Attributes.Add("class", "");
                ToParents.Attributes.Add("class", "");
                ToStaff.Attributes.Add("class", "");

                /*  BindInboxItemMessage();
                   dvMsg.Visible = true;
                   lblMessage.Text = "Your Message has been sent successfully";
                   dvMsg.Attributes.Add("class", "warring_msg");
                   SectionInbox.Visible = true;
                   SectionCompose.Visible = false;
                   SectionSentMsg.Visible = false;
                   MyInBox.Attributes.Add("class", "tabsactive");
                   MySentMesseages.Attributes.Add("class", ""); */

            }
        }
        else
        {

            SectionInbox.Visible = true;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;
            sendall.Visible = false;
            sendtech.Visible = false;
            sendpart.Visible = false;
            sendstaf.Visible = false;

            MyInBox.Attributes.Add("class", "tabsactive");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "");
            ToParents.Attributes.Add("class", "");
            ToStaff.Attributes.Add("class", "");


            BindInboxItemMessage();
            dvMsg.Visible = true;
            lblMessage.Text = "Please Enter Description";
            dvMsg.Attributes.Add("class", "error_msg");

        }

    }

    protected void lnkViewMsg_Details(object sender, EventArgs e)
    {
        dvMsg.Visible = false;
        pnlPerson.Visible = true;
        LinkButton lnk = (LinkButton)sender;
        ListViewItem lml = (ListViewItem)lnk.NamingContainer;
        Label lblMessageId = lml.FindControl("lblMessageId") as Label;
        Int64 MsgId = Convert.ToInt64(lblMessageId.Text);


        TMSMyMessageDetails objMess = TMSMyMessageDetails.Get(MsgId);
        if (objMess != null)
        {
            lblTitle1.Text = objMess.MMDMessageSubject;
            lblDesc1.Text = objMess.MMDDescription;



        }

        objMess.MMDReadStatus = 1;
        objMess.Update();


        Control p = lnk.Parent;
        AjaxControlToolkit.ModalPopupExtender extPerson = (AjaxControlToolkit.ModalPopupExtender)p.FindControl("extPerson");
        extPerson.Show();

    }

    protected void btnPopUpCancel_Click(object sender, EventArgs e)
    {
        // DivItemDetails.Visible = false;
    }

    protected void click_lnkClose(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            pnlPerson.Visible = false;
            BindInboxItemMessage();
        }
        catch (Exception Ex)
        {
        }
    }

    protected void lnkMsgThraed_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            LinkButton lnkView = (LinkButton)sender;
            ListViewDataItem lnkMsgThraed = (ListViewDataItem)lnkView.NamingContainer;
            ListView lstMsgThread = (ListView)lnkMsgThraed.FindControl("lstMsgThread");
            HtmlGenericControl SectionViewThreadMsg = lnkMsgThraed.FindControl("SectionViewThreadMsg") as HtmlGenericControl;
            HtmlGenericControl Sectionreplybox = lnkMsgThraed.FindControl("Sectionreplybox") as HtmlGenericControl;

            LinkButton lnkCloseThread = (LinkButton)lnkMsgThraed.FindControl("lnkCloseThread");


            Sectionreplybox.Visible = false;
            SectionViewThreadMsg.Visible = true;
            Label lblMessageId = lnkMsgThraed.FindControl("lblMessageId") as Label;
            Int64 MsgId = Convert.ToInt64(lblMessageId.Text);
            TMSMyMessageDetails objmess = TMSMyMessageDetails.Get(Convert.ToInt64(lblMessageId.Text));
            if (objmess != null)
            {
                Int64 ReplyId = Convert.ToInt64(objmess.MMDReplyId);

                if (ReplyId == 0)
                {
                    DataTable dtComm = TMSMyMessageDetails.GetCommunicationDetails(Convert.ToInt64(lblMessageId.Text)).Tables[0];
                    {
                        lstMsgThread.DataSource = dtComm;
                        lstMsgThread.DataBind();
                    }
                }
                else
                {
                    DataTable dtComm = TMSMyMessageDetails.GetCommunicationDetails(ReplyId).Tables[0];
                    {
                        lstMsgThread.DataSource = dtComm;
                        lstMsgThread.DataBind();
                    }
                }
            }
            lnkView.Visible = false;
            lnkCloseThread.Visible = true;
        }
        catch (Exception ex) { }
    }
    protected void lnkCloseThread_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            LinkButton lnkClose = (LinkButton)sender;
            ListViewDataItem lnkCloseThread = (ListViewDataItem)lnkClose.NamingContainer;
            ListView lstMsgThread = (ListView)lnkCloseThread.FindControl("lstMsgThread");
            HtmlGenericControl SectionViewThreadMsg = lnkCloseThread.FindControl("SectionViewThreadMsg") as HtmlGenericControl;
            HtmlGenericControl Sectionreplybox = lnkCloseThread.FindControl("Sectionreplybox") as HtmlGenericControl;
            LinkButton lnkMsgThraed = (LinkButton)lnkCloseThread.FindControl("lnkMsgThraed");
            Sectionreplybox.Visible = false;
            SectionViewThreadMsg.Visible = false;
            lnkClose.Visible = false;
            lnkMsgThraed.Visible = true;

        }
        catch (Exception ex) { }
    }


    protected void btnCancel1_Click1(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            Button btnCancel1 = (Button)sender;
            ListViewDataItem btnCancel = (ListViewDataItem)btnCancel1.NamingContainer;
            HtmlGenericControl SectionViewThreadMsg = btnCancel.FindControl("SectionViewThreadMsg") as HtmlGenericControl;
            HtmlGenericControl Sectionreplybox = btnCancel.FindControl("Sectionreplybox") as HtmlGenericControl;
            Sectionreplybox.Visible = false;
            SectionViewThreadMsg.Visible = false;
        }
        catch (Exception ex) { }
    }



    private void BindFaculty()
    {
        string schoolType = null;
        Int64? standardId = null;
        if (ddlGroup.SelectedItem.Text == "Select Type")
        {
            schoolType = null;
        }
        else
        {
            schoolType = ddlGroup.SelectedItem.Text;
        }
        if (ddlStandard.SelectedItem.Text == "Select Standard")
        {
            standardId = null;
        }
        else
        {
            standardId = Convert.ToInt64(ddlStandard.SelectedItem.Value);
        }


        if ((schoolType == null) && (standardId == null))
        {
            DataTable dtFaculty = TMSFacultyDetails.GetAllFaculty().Tables[0];
            if (dtFaculty.Rows.Count > 0)
            {
                lvFaculty.DataSource = dtFaculty;
                lvFaculty.DataBind();
                ViewState["rowscount"] = lvFaculty.Items.Count;
            }
            else
            {
                lvFaculty.DataBind();
            }


        }

        else
        {

            /*  DataTable dtFacultyDetails = TMSFacultyDetails.GetCurrentStaffFacultyDetails(null, 2, null, schoolType, standardId).Tables[0];
              if (dtFacultyDetails.Rows.Count > 0)
              {
                  lvFaculty.DataSource = dtFacultyDetails;
                  lvFaculty.DataBind();
                  ViewState["rowscount"] = lvFaculty.Items.Count;
              }
              else
              {
                  lvFaculty.DataBind();
              }*/

            DataTable dtFacultyDetails = TMSFacultyDetails.GetTeacher_SchoolType_and_StandaradWise(standardId, schoolType).Tables[0];
            if (dtFacultyDetails.Rows.Count > 0)
            {
                lvFaculty.DataSource = dtFacultyDetails;
                lvFaculty.DataBind();
                ViewState["rowscount"] = lvFaculty.Items.Count;
            }
            else
            {
                lvFaculty.DataBind();
            }
        }

    }
    protected void Send_ToAll(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;

            SectionInbox.Visible = false;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;
            sendall.Visible = true;
            sendtech.Visible = false;
            sendpart.Visible = false;
            sendstaf.Visible = false;
            sendPrincipal.Visible = false;

            MyInBox.Attributes.Add("class", "");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "tabsactive");
            ToTeccher.Attributes.Add("class", "");
            ToParents.Attributes.Add("class", "");
            ToStaff.Attributes.Add("class", "");
            ToPrincipal.Attributes.Add("class", "");

            ddlSendToAll.Visible = false;

        }
        catch (Exception) { }
    }
    protected void buttonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            txtToTeacher.Text = "";
            int chkCount = 0, success = 0, cnt = 0;
            string chkBidBox = null, addedUser = null;



            SectionInbox.Visible = false;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;
            sendall.Visible = false;
            sendtech.Visible = true;
            sendpart.Visible = false;
            sendstaf.Visible = false;
            sendPrincipal.Visible = false;

            MyInBox.Attributes.Add("class", "");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "tabsactive");
            ToParents.Attributes.Add("class", "");
            ToStaff.Attributes.Add("class", "");
            ToPrincipal.Attributes.Add("class", "");


            for (int i = 0; i < lvFaculty.Items.Count; i++)
            {
                ListViewItem datarow = lvFaculty.Items[i];
                if (((CheckBox)datarow.FindControl("chkBidId")).Checked == true)
                {
                    chkCount++;
                }
            }
            if (chkCount > 0)
            {
                foreach (ListViewItem row in lvFaculty.Items)
                {
                    CheckBox chkStatus = (CheckBox)row.FindControl("chkBidId");
                    int chkId = Convert.ToInt32(((Label)row.FindControl("lblChkValue")).Text);

                    if (chkStatus.Checked == true)
                    {
                        ImageButton imgFaculty = (ImageButton)row.FindControl("imgFaculty");
                        cnt = cnt + 1;
                        chkBidBox += chkId + ",";
                        string name = ((Label)row.FindControl("lblUserName")).Text;
                        if (string.IsNullOrEmpty(txtToTeacher.Text))
                        {
                            txtToTeacher.Text = name;
                        }
                        else
                        {
                            txtToTeacher.Text = txtToTeacher.Text + "," + name;
                        }
                        //  addedUser += "<dl><dd class='col01'></dd><dd class='col02'><img src=" + imgFaculty.ImageUrl.Replace("~","..") + " width='32' height='32'></dd><dd class='col03'>" + ((Label)row.FindControl("lblUserName")).Text + "</dd><section class='clear'></section></dl>";
                    }
                }
                HFSeelctedID.Value = chkBidBox;
                // selectFaculty.Controls.Add(new LiteralControl(addedUser));
            }
        }
        catch (Exception) { }
    }
    protected void RemoveCity(object sender, EventArgs e)
    {
        try
        {

        }
        catch (Exception) { }
    }
    protected void Send_ToTeacher(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;

            SectionInbox.Visible = false;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;

            sendall.Visible = false;
            sendtech.Visible = true;
            SectionAllTeacher.Visible = true;
            SectionAllGroup.Visible = false;
            sendpart.Visible = false;
            sendstaf.Visible = false;
            sendPrincipal.Visible = false;

            MyInBox.Attributes.Add("class", "");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "tabsactive");
            ToParents.Attributes.Add("class", "");
            ToStaff.Attributes.Add("class", "");
            ToPrincipal.Attributes.Add("class", "");

            RadioAllTeacher.Checked = true;
            RadioAllGroup.Checked = false;


            BindGroup();
            BindStandard();
            BindFaculty();

            txtToTeacher.Text = "";
            txtSendtoteacherSub.Text = "";
            txtSendToTeacherDesc.Text = "";
        }
        catch (Exception) { }
    }
    private void BindGroup()
    {
        DataTable dtClassDetails1 = TMSSchoolType.GetSearch(null, null, 1).Tables[0];//null, null, 2, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1).Tables[0];
        if (dtClassDetails1.Rows.Count > 0)
        {
            ddlGroup.DataSource = dtClassDetails1;
            ddlGroup.DataTextField = "ST_ST_TypeName";
            ddlGroup.DataValueField = "ST_ST_TypeName";
            ddlGroup.DataBind();
            ddlGroup.Items.Insert(0, new ListItem("Select Type", "-1"));
        }
    }
    private void BindStandard()
    {
        DataTable dtClassDetails1 = TMSSchoolCategory.GetSearch(null, null, null, null, 1).Tables[0];//null, null, 2, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1).Tables[0];
        if (dtClassDetails1.Rows.Count > 0)
        {
            ddlStandard.DataSource = dtClassDetails1;
            ddlStandard.DataTextField = "SC_CategoryName";
            ddlStandard.DataValueField = "SC_CategoryId";
            ddlStandard.DataBind();
            ddlStandard.Items.Insert(0, new ListItem("Select Standard", "-1"));
        }
    }
    protected void btnTeacher_Send(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;

            SectionInbox.Visible = false;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;
            sendall.Visible = false;
            sendtech.Visible = true;
            sendpart.Visible = false;
            sendstaf.Visible = false;
            sendPrincipal.Visible = false;

            MyInBox.Attributes.Add("class", "");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "tabsactive");
            ToParents.Attributes.Add("class", "");
            ToStaff.Attributes.Add("class", "");
            ToPrincipal.Attributes.Add("class", "");

            string facultID = HFSeelctedID.Value;
            string[] facultySplit = facultID.Split(',');

            for (int i = 0; i < facultySplit.Length - 1; i++)
            {
                /* TMSMyMessageDetails objMyMessage = new TMSMyMessageDetails();
                 objMyMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                 objMyMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                 objMyMessage.MMDReceivedId = Convert.ToInt64(facultySplit[i]);
                 objMyMessage.MMDReadStatus = 0;
                 objMyMessage.MMDMessageTitle = HFSeelctedID.Value;
                 objMyMessage.MMDMessageSubject = txtSendtoteacherSub.Text;
                 objMyMessage.MMDDescription = txtSendToTeacherDesc.Text;
                 objMyMessage.MMDMessageRemarks = "SendToTeachers";
                 objMyMessage.MMDMessageType = "Send To Teachers From Principal";
                 objMyMessage.MMDStatus = 1;
                 objMyMessage.MMDSendDate = DateTime.Now;
                 objMyMessage.Insert();*/


                TMSMyMessageDetails objMyMessage = new TMSMyMessageDetails();
                objMyMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                objMyMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                objMyMessage.MMDReceivedId = Convert.ToInt64(facultySplit[i]);
                objMyMessage.MMDReadStatus = 0;
                objMyMessage.MMDMessageTitle = HFSeelctedID.Value;
                objMyMessage.MMDMessageSubject = txtSendtoteacherSub.Text;
                objMyMessage.MMDDescription = txtSendToTeacherDesc.Text;
                objMyMessage.MMDMessageRemarks = "Send To Teachers";
                objMyMessage.MMDMessageType = "Send To Teachers From Staff";
                objMyMessage.MMDAddedByType = "Account Manager";
                objMyMessage.MMDStatus = 1;
                objMyMessage.MMDSendDate = DateTime.Now;
                objMyMessage.Insert();
            }
            Response.Redirect("MyInbox.aspx?msg=Message Send To Teachers Successfully!!!.");
        }
        catch (Exception) { }
    }
    protected void Send_ToParents(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;

            SectionInbox.Visible = false;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;
            sendall.Visible = false;
            sendtech.Visible = false;
            sendpart.Visible = true;
            sendstaf.Visible = false;
            sendPrincipal.Visible = false;

            MyInBox.Attributes.Add("class", "");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "");
            ToParents.Attributes.Add("class", "tabsactive");
            ToStaff.Attributes.Add("class", "");
            ToPrincipal.Attributes.Add("class", "");


            BindParentStandard();
            BindParent();

            txtToParent.Text = "";
            txtParentSub.Text = "";
            txtParentDesc.Text = "";


        }
        catch (Exception) { }
    }
    protected void Send_ToStaff(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;

            SectionInbox.Visible = false;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;
            sendall.Visible = false;
            sendtech.Visible = false;
            sendpart.Visible = false;
            sendstaf.Visible = true;
            sendPrincipal.Visible = false;

            MyInBox.Attributes.Add("class", "");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "");
            ToParents.Attributes.Add("class", "");
            ToStaff.Attributes.Add("class", "tabsactive");
            ToPrincipal.Attributes.Add("class", "");

            BindStaff();

            txtToStaff.Text = "";
            txtStaffSub.Text = "";
            txtStaffDesc.Text = "";
        }
        catch (Exception) { }
    }

    protected void Send_ToPrincipal(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            SectionInbox.Visible = false;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;
            sendall.Visible = false;
            sendtech.Visible = false;
            sendpart.Visible = false;
            sendstaf.Visible = false;
            sendPrincipal.Visible = true;

            MyInBox.Attributes.Add("class", "");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "");
            ToParents.Attributes.Add("class", "");
            ToStaff.Attributes.Add("class", "");
            ToPrincipal.Attributes.Add("class", "tabsactive");

            Bindprincipal();

        }
        catch (Exception) { }
    }

    protected void Bindprincipal()
    {
        try
        {
            DataTable dtPrincipal = TMSFacultyDetails.GetStaffFacultyDetails(null, 1, null).Tables[0];
            if (dtPrincipal.Rows.Count > 0)
            {
                ddlPrincipal.DataSource = dtPrincipal;
                ddlPrincipal.DataValueField = "FD_LoginId";
                ddlPrincipal.DataTextField = "UserName";
                ddlPrincipal.DataBind();
                //ddlPrincipal.Items.Insert(0, new ListItem("Send To All", "0"));
            }
        }
        catch (Exception ex) { }
    }
    private void BindStaff()
    {
        string facultyType = null;
        if (ddlSelectStaff.SelectedItem.Text == "Select Department")
        {
            facultyType = null;
        }
        else
        {
            facultyType = ddlSelectStaff.SelectedItem.Value;
        }
        DataTable dtStaffDetails = TMSFacultyDetails.GetSearchOtherDeptStaffFacultyDetails(null, null, facultyType).Tables[0];
        if (dtStaffDetails.Rows.Count > 0)
        {
            lvStaffList.DataSource = dtStaffDetails;
            lvStaffList.DataBind();
            ViewState["rowscountstaff"] = lvStaffList.Items.Count;
        }
        else
        {
            lvStaffList.DataBind();
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccountManagerDashboard.aspx", false);

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        try
        {

            /* DataTable dtFacultyMessage = TMSMyMessageDetails.GetSearchAllSendMyMessageData().Tables[0];
             if (dtFacultyMessage.Rows.Count > 0)
             {
                 foreach (DataRow row in dtFacultyMessage.Rows)
                 {
                     TMSMyMessageDetails objMyMessage = new TMSMyMessageDetails();
                     objMyMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                     objMyMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                     objMyMessage.MMDReceivedId = Convert.ToInt64(row["FacultyId"]);
                     objMyMessage.MMDReadStatus = 0;
                     objMyMessage.MMDMessageTitle = ddlSendToAll.SelectedItem.Value;
                     objMyMessage.MMDMessageSubject = txtSubjectAll.Text;
                     objMyMessage.MMDDescription = txtMessageAll.Text;
                     objMyMessage.MMDMessageRemarks = "Send To All";
                     objMyMessage.MMDMessageType = "Send To All From Principal";
                     objMyMessage.MMDStatus = 1;
                     objMyMessage.MMDSendDate = DateTime.Now;
                     objMyMessage.Insert();
                 }
             }
             DataTable dtParentMessage = TMSMyMessageDetails.GetSearchAllSendMyMessageData().Tables[1];
             if (dtParentMessage.Rows.Count > 0)
             {
                 foreach (DataRow row in dtParentMessage.Rows)
                 {
                     TMSMyMessageDetails objMyMessage = new TMSMyMessageDetails();
                     objMyMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                     objMyMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                     objMyMessage.MMDReceivedId = Convert.ToInt64(row["ParentId"]);
                     objMyMessage.MMDReadStatus = 0;
                     objMyMessage.MMDMessageTitle = ddlSendToAll.SelectedItem.Value;
                     objMyMessage.MMDMessageSubject = txtSubjectAll.Text;
                     objMyMessage.MMDDescription = txtMessageAll.Text;
                     objMyMessage.MMDMessageRemarks = "Send To All";
                     objMyMessage.MMDMessageType = "Send To All From Principal";
                     objMyMessage.MMDStatus = 1;
                     objMyMessage.MMDSendDate = DateTime.Now;
                     objMyMessage.Insert();
                 }
             }
             DataTable dtStudentMessage = TMSMyMessageDetails.GetSearchAllSendMyMessageData().Tables[2];
             if (dtStudentMessage.Rows.Count > 0)
             {
                 foreach (DataRow row in dtStudentMessage.Rows)
                 {
                     TMSMyMessageDetails objMyMessage = new TMSMyMessageDetails();
                     objMyMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                     objMyMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                     objMyMessage.MMDReceivedId = Convert.ToInt64(row["StudentId"]);
                     objMyMessage.MMDReadStatus = 0;
                     objMyMessage.MMDMessageTitle = ddlSendToAll.SelectedItem.Value;
                     objMyMessage.MMDMessageSubject = txtSubjectAll.Text;
                     objMyMessage.MMDDescription = txtMessageAll.Text;
                     objMyMessage.MMDMessageType = "Send To All From Principal";
                     objMyMessage.MMDMessageRemarks = "Send To All";
                     objMyMessage.MMDStatus = 1;
                     objMyMessage.MMDSendDate = DateTime.Now;
                     objMyMessage.Insert();
                 }
             } */

            if (txtSubjectAll.Text != "")
            {
                DataTable dtFacultyMessage = TMSMyMessageDetails.GetSearchAllSendMyMessageData().Tables[0];
                if (dtFacultyMessage.Rows.Count > 0)
                {
                    foreach (DataRow row in dtFacultyMessage.Rows)
                    {

                        TMSMyMessageDetails objMyMessageFaculty = new TMSMyMessageDetails();
                        objMyMessageFaculty.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                        objMyMessageFaculty.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                        objMyMessageFaculty.MMDReceivedId = Convert.ToInt64(row["TeacherLoginId"]);
                        objMyMessageFaculty.MMDReadStatus = 0;
                        objMyMessageFaculty.MMDMessageTitle = ddlSendToAll.SelectedItem.Value;
                        objMyMessageFaculty.MMDMessageSubject = txtSubjectAll.Text;
                        objMyMessageFaculty.MMDDescription = txtMessageAll.Text;
                        objMyMessageFaculty.MMDMessageRemarks = "Send To All";
                        objMyMessageFaculty.MMDMessageType = "Send To Teachers From Staff";
                        objMyMessageFaculty.MMDAddedByType = "Account Manager";
                        objMyMessageFaculty.MMDStatus = 1;
                        objMyMessageFaculty.MMDSendDate = DateTime.Now;
                        objMyMessageFaculty.Insert();

                    }
                }

                DataTable dtStaffMessage = TMSMyMessageDetails.GetSearchAllSendMyMessageData().Tables[1];
                if (dtStaffMessage.Rows.Count > 0)
                {
                    foreach (DataRow row in dtStaffMessage.Rows)
                    {
                        if (Convert.ToInt64(Session["UserId"]) == Convert.ToInt64(row["StaffLoginId"]))
                        {

                        }

                        else
                        {
                            TMSMyMessageDetails objMyMessageStaff = new TMSMyMessageDetails();
                            objMyMessageStaff.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                            objMyMessageStaff.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                            objMyMessageStaff.MMDReceivedId = Convert.ToInt64(row["StaffLoginId"]);
                            objMyMessageStaff.MMDReadStatus = 0;
                            objMyMessageStaff.MMDMessageTitle = ddlSendToAll.SelectedItem.Value;
                            objMyMessageStaff.MMDMessageSubject = txtSubjectAll.Text;
                            objMyMessageStaff.MMDDescription = txtMessageAll.Text;
                            objMyMessageStaff.MMDMessageRemarks = "Send To All";
                            objMyMessageStaff.MMDMessageType = "Send To OtherStaff From Staff";
                            objMyMessageStaff.MMDAddedByType = "Account Manager";
                            objMyMessageStaff.MMDStatus = 1;
                            objMyMessageStaff.MMDSendDate = DateTime.Now;
                            objMyMessageStaff.Insert();
                        }
                    }
                }

                DataTable dtParentFatherMessage = TMSMyMessageDetails.GetSearchAllSendMyMessageData().Tables[2];
                if (dtParentFatherMessage.Rows.Count > 0)
                {
                    foreach (DataRow row in dtParentFatherMessage.Rows)
                    {


                        TMSMyMessageDetails objMyMessageParent = new TMSMyMessageDetails();
                        objMyMessageParent.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                        objMyMessageParent.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                        objMyMessageParent.MMDReceivedId = Convert.ToInt64(row["FatherLoginId"]);
                        objMyMessageParent.MMDReadStatus = 0;
                        objMyMessageParent.MMDMessageTitle = ddlSendToAll.SelectedItem.Value;
                        objMyMessageParent.MMDMessageSubject = txtSubjectAll.Text;
                        objMyMessageParent.MMDDescription = txtMessageAll.Text;
                        objMyMessageParent.MMDMessageRemarks = "Send To All";
                        objMyMessageParent.MMDMessageType = "Send To Parents From Staff";
                        objMyMessageParent.MMDAddedByType = "Account Manager";
                        objMyMessageParent.MMDStatus = 1;
                        objMyMessageParent.MMDSendDate = DateTime.Now;
                        objMyMessageParent.Insert();
                    }
                }

                DataTable dtParentMotherMessage = TMSMyMessageDetails.GetSearchAllSendMyMessageData().Tables[3];
                if (dtParentMotherMessage.Rows.Count > 0)
                {
                    foreach (DataRow row in dtParentMotherMessage.Rows)
                    {


                        TMSMyMessageDetails objMyMessageParent = new TMSMyMessageDetails();
                        objMyMessageParent.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                        objMyMessageParent.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                        objMyMessageParent.MMDReceivedId = Convert.ToInt64(row["MotherLoginId"]);
                        objMyMessageParent.MMDReadStatus = 0;
                        objMyMessageParent.MMDMessageTitle = ddlSendToAll.SelectedItem.Value;
                        objMyMessageParent.MMDMessageSubject = txtSubjectAll.Text;
                        objMyMessageParent.MMDDescription = txtMessageAll.Text;
                        objMyMessageParent.MMDMessageRemarks = "Send To All";
                        objMyMessageParent.MMDMessageType = "Send To Parents From Staff";
                        objMyMessageParent.MMDAddedByType = "Account Manager";
                        objMyMessageParent.MMDStatus = 1;
                        objMyMessageParent.MMDSendDate = DateTime.Now;
                        objMyMessageParent.Insert();
                    }
                }

                DataTable dtStudentMessage = TMSMyMessageDetails.GetSearchAllSendMyMessageData().Tables[4];
                if (dtStudentMessage.Rows.Count > 0)
                {
                    foreach (DataRow row in dtStudentMessage.Rows)
                    {
                        TMSMyMessageDetails objMyMessageStudent = new TMSMyMessageDetails();
                        objMyMessageStudent.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                        objMyMessageStudent.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                        objMyMessageStudent.MMDReceivedId = Convert.ToInt64(row["StudentLoginId"]);
                        objMyMessageStudent.MMDReadStatus = 0;
                        objMyMessageStudent.MMDMessageTitle = ddlSendToAll.SelectedItem.Value;
                        objMyMessageStudent.MMDMessageSubject = txtSubjectAll.Text;
                        objMyMessageStudent.MMDDescription = txtMessageAll.Text;
                        objMyMessageStudent.MMDMessageType = "Send To Students From Staff";
                        objMyMessageStudent.MMDMessageRemarks = "Send To All";
                        objMyMessageStudent.MMDAddedByType = "Account Manager";
                        objMyMessageStudent.MMDStatus = 1;
                        objMyMessageStudent.MMDSendDate = DateTime.Now;
                        objMyMessageStudent.Insert();
                    }
                }


                DataTable dtPrincipalMessage = TMSMyMessageDetails.GetSearchAllSendMyMessageData().Tables[5];
                if (dtPrincipalMessage.Rows.Count > 0)
                {
                    foreach (DataRow row in dtPrincipalMessage.Rows)
                    {
                        TMSMyMessageDetails objMyMessageStudent = new TMSMyMessageDetails();
                        objMyMessageStudent.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                        objMyMessageStudent.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                        objMyMessageStudent.MMDReceivedId = Convert.ToInt64(row["PrincipalLoginId"]);
                        objMyMessageStudent.MMDReadStatus = 0;
                        objMyMessageStudent.MMDMessageTitle = ddlSendToAll.SelectedItem.Value;
                        objMyMessageStudent.MMDMessageSubject = txtSubjectAll.Text;
                        objMyMessageStudent.MMDDescription = txtMessageAll.Text;
                        objMyMessageStudent.MMDMessageType = "Send To Principal From Staff";
                        objMyMessageStudent.MMDMessageRemarks = "Send To All";
                        objMyMessageStudent.MMDAddedByType = "Account Manager";
                        objMyMessageStudent.MMDStatus = 1;
                        objMyMessageStudent.MMDSendDate = DateTime.Now;
                        objMyMessageStudent.Insert();
                    }
                }



                Response.Redirect("MyInbox.aspx?msg=Message Send To All Successfully!!!.");
            }
            else
            {
                dvMsg.Visible = true;
                lblMessage.Text = "Please Enter Subject and Description";
                dvMsg.Attributes.Add("class", "error_msg");
            }
        }
        catch (Exception) { }
    }
    protected void DataPagerTrip_PreRender(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            BindFaculty();
        }
        catch (Exception) { }
    }
    protected void ddlGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            BindParticularStandard();
            BindFaculty();
        }
        catch (Exception) { }
    }

    protected void BindParticularStandard()
    {
        try
        {
            DataTable dtstandard = TMSSchoolCategory.GetSearch(null, null, ddlGroup.SelectedValue, null, 1).Tables[0];//null, null, 2, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1).Tables[0];
            if (dtstandard.Rows.Count > 0)
            {
                ddlStandard.DataSource = dtstandard;
                ddlStandard.DataTextField = "SC_CategoryName";
                ddlStandard.DataValueField = "SC_CategoryId";
                ddlStandard.DataBind();
                ddlStandard.Items.Insert(0, new ListItem("Select Standard", "-1"));
            }
        }
        catch (Exception) { }
    }

    protected void lvFaculty_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        try
        {
            Label lblTeacherLoginId = (Label)e.Item.FindControl("lblChkValue");
            CheckBox chkBidId = (CheckBox)e.Item.FindControl("CheckBox");
            ImageButton imgFaculty = (ImageButton)e.Item.FindControl("imgFaculty");
            Label lblUserName = (Label)e.Item.FindControl("lblUserName");
            Label lblCompleteYear1 = (Label)e.Item.FindControl("lblCompleteYear");


            /*HtmlGenericControl TeacherSection = (HtmlGenericControl)e.Item.FindControl("TeacherSection");
            Int64 TeacherLoginId = Convert.ToInt64(lblTeacherLoginId.Text);

            if (Convert.ToInt64(Session["UserId"]) == TeacherLoginId)
            {
                TeacherSection.Style.Add("display", "none");
                
            }*/


            Label lblCompleteYear = (Label)e.Item.FindControl("lblCompleteYear");
            if (!string.IsNullOrEmpty(lblCompleteYear.Text))
            {
                lblCompleteYear.Text = Convert.ToInt64(lblCompleteYear.Text) - 1 + "-" + lblCompleteYear.Text;
            }

        }
        catch (Exception) { }
    }
    protected void ddlStandard_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            BindFaculty();
        }
        catch (Exception) { }
    }
    protected void ddlParentStandard_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            BindParent();
        }
        catch (Exception) { }
    }
    private void BindParent()
    {
        Int64? standardId = null;
        if (ddlParentStandard.SelectedItem.Text == "Select Standard")
        {
            standardId = null;
        }
        else
        {
            standardId = Convert.ToInt64(ddlParentStandard.SelectedItem.Value);
        }
        DataTable dtParentDetails = TMSFacultyDetails.GetSearchParentDetails(null, null, standardId, null).Tables[0];
        if (dtParentDetails.Rows.Count > 0)
        {
            lvParentList.DataSource = dtParentDetails;
            lvParentList.DataBind();
            ViewState["rowscountparent"] = lvParentList.Items.Count;
        }
        else
        {
            lvParentList.DataBind();
        }

    }
    private void BindParentStandard()
    {
        dvMsg.Visible = false;
        DataTable dtClassDetails1 = TMSSchoolCategory.GetSearch(null, null, null, null, 1).Tables[0];//null, null, 2, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1).Tables[0];
        if (dtClassDetails1.Rows.Count > 0)
        {
            ddlParentStandard.DataSource = dtClassDetails1;
            ddlParentStandard.DataTextField = "SC_CategoryName";
            ddlParentStandard.DataValueField = "SC_CategoryId";
            ddlParentStandard.DataBind();
            ddlParentStandard.Items.Insert(0, new ListItem("Select Standard", "-1"));
        }
    }

    protected void lvParentList_DataBound(object sender, ListViewItemEventArgs e)
    {
    }
    protected void btnParentAdd_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            txtToParent.Text = "";
            int chkCount = 0, cnt = 0;
            string chkBidBox = null, addedUser = null;


            SectionInbox.Visible = false;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;
            sendall.Visible = false;
            sendtech.Visible = false;
            sendpart.Visible = true;
            sendstaf.Visible = false;
            sendPrincipal.Visible = false;

            MyInBox.Attributes.Add("class", "");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "");
            ToParents.Attributes.Add("class", "tabsactive");
            ToStaff.Attributes.Add("class", "");
            ToPrincipal.Attributes.Add("class", "");

            for (int i = 0; i < lvParentList.Items.Count; i++)
            {
                ListViewItem datarow = lvParentList.Items[i];
               // if ((((CheckBox)datarow.FindControl("chkParentId")).Checked == true) || (((CheckBox)datarow.FindControl("chkMotherId")).Checked == true))
               if ((((CheckBox)datarow.FindControl("chkParentId")).Checked == true) )
                {
                    chkCount++;
                }

            }

            if (chkCount > 0)
            {
                foreach (ListViewItem row in lvParentList.Items)
                {
                    CheckBox chkStatus = (CheckBox)row.FindControl("chkParentId");
                    int chkFatherId = Convert.ToInt32(((Label)row.FindControl("lblChkParentValue")).Text);

                    //CheckBox chkStatusOne = (CheckBox)row.FindControl("chkMotherId");
                   // int chkMotherId = Convert.ToInt32(((Label)row.FindControl("lblChkMotherValue")).Text);

                    if (chkStatus.Checked == true)
                    {
                        ImageButton imgParent = (ImageButton)row.FindControl("imgParent");
                        cnt = cnt + 1;
                        chkBidBox += chkFatherId + ",";
                        string name = ((Label)row.FindControl("lblParentName")).Text;
                        if (string.IsNullOrEmpty(txtToParent.Text))
                        {
                            txtToParent.Text = name;
                        }
                        else
                        {
                            txtToParent.Text = txtToParent.Text + "," + name;
                        }
                        // addedUser += "<dl><dd class='col01'></dd><dd class='col02'><img src=" + imgParent.ImageUrl.Replace("~","..") + " width='32' height='32'></dd><dd class='col03'>" + ((Label)row.FindControl("lblParentName")).Text + "</dd><section class='clear'></section></dl>";
                    }


                  /*  if (chkStatusOne.Checked == true)
                    {
                        ImageButton imgMother = (ImageButton)row.FindControl("imgMother");
                        cnt = cnt + 1;
                        chkBidBox += chkMotherId + ",";
                        Label mname = (Label)row.FindControl("lblMotherName");
                        //((Label)row.FindControl("lblMotherName")).Text;
                        if (string.IsNullOrEmpty(txtToParent.Text))
                        {
                            txtToParent.Text = mname.Text;
                        }
                        else
                        {
                            txtToParent.Text = txtToParent.Text + "," + mname.Text;
                        }
                        // addedUser += "<dl><dd class='col01'></dd><dd class='col02'><img src=" + imgParent.ImageUrl.Replace("~","..") + " width='32' height='32'></dd><dd class='col03'>" + ((Label)row.FindControl("lblParentName")).Text + "</dd><section class='clear'></section></dl>";
                    }*/


                }
                HFParentId.Value = chkBidBox;
                // selectParent.Controls.Add(new LiteralControl(addedUser));
            }
        }
        catch (Exception) { }
    }
    protected void btnParentSend_Click(object sender, EventArgs e)
    {
        try
        {

            SectionInbox.Visible = false;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;
            sendall.Visible = false;
            sendtech.Visible = false;
            sendpart.Visible = true;
            sendstaf.Visible = false;
            sendPrincipal.Visible = false;

            MyInBox.Attributes.Add("class", "");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "");
            ToParents.Attributes.Add("class", "tabsactive");
            ToStaff.Attributes.Add("class", "");
            ToPrincipal.Attributes.Add("class", "");


            string parentID = HFParentId.Value;
            string[] fparentSplit = parentID.Split(',');

            for (int i = 0; i < fparentSplit.Length - 1; i++)
            {
                /* TMSMyMessageDetails objMyMessage = new TMSMyMessageDetails();
                 objMyMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                 objMyMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                 objMyMessage.MMDReceivedId = Convert.ToInt64(fparentSplit[i]);
                 objMyMessage.MMDReadStatus = 0;
                 objMyMessage.MMDMessageTitle = parentID;
                 objMyMessage.MMDMessageSubject = txtParentSub.Text;
                 objMyMessage.MMDDescription = txtParentDesc.Text;
                 objMyMessage.MMDMessageRemarks = "SendToParents";
                 objMyMessage.MMDMessageType = "Send To Parents From Principal";
                 objMyMessage.MMDStatus = 1;
                 objMyMessage.MMDSendDate = DateTime.Now;
                 objMyMessage.Insert();*/


                TMSMyMessageDetails objMyMessage = new TMSMyMessageDetails();
                objMyMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                objMyMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                objMyMessage.MMDReceivedId = Convert.ToInt64(fparentSplit[i]);
                objMyMessage.MMDReadStatus = 0;
                objMyMessage.MMDMessageTitle = parentID;
                objMyMessage.MMDMessageSubject = txtParentSub.Text;
                objMyMessage.MMDDescription = txtParentDesc.Text;
                objMyMessage.MMDMessageRemarks = "SendToParents";
                objMyMessage.MMDMessageType = "Send To Parents From Staff";
                objMyMessage.MMDAddedByType = "Account Manager";
                objMyMessage.MMDStatus = 1;
                objMyMessage.MMDSendDate = DateTime.Now;
                objMyMessage.Insert();

            }
            Response.Redirect("MyInbox.aspx?msg=Message Send To Parents Successfully!!!.");
        }
        catch (Exception) { }
    }
    protected void btnParentCancel_Click(object sender, EventArgs e)
    {
        try { }
        catch (Exception) { }
    }

    protected void lvStaffList_DataBound(object sender, ListViewItemEventArgs e)
    {
        try
        {
            Label lblChkStaffValue = (Label)e.Item.FindControl("lblChkStaffValue");
            HtmlGenericControl StaffSection = (HtmlGenericControl)e.Item.FindControl("StaffSection");
            Int64 StaffLoginId = Convert.ToInt64(lblChkStaffValue.Text);

            if (Convert.ToInt64(Session["UserId"]) == StaffLoginId)
            {
                StaffSection.Style.Add("display", "none");

            }

        }
        catch (Exception ex) { }
    }
    protected void btnStaffSend_Click(object sender, EventArgs e)
    {
        try
        {

            SectionInbox.Visible = false;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;
            sendall.Visible = false;
            sendtech.Visible = false;
            sendpart.Visible = false;
            sendstaf.Visible = true;
            sendPrincipal.Visible = false;

            MyInBox.Attributes.Add("class", "");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "");
            ToParents.Attributes.Add("class", "");
            ToStaff.Attributes.Add("class", "tabsactive");
            ToPrincipal.Attributes.Add("class", "tabsactive");

            string staffID = HFStaffId.Value;
            string[] staffSplit = staffID.Split(',');

            for (int i = 0; i < staffSplit.Length - 1; i++)
            {

                TMSMyMessageDetails objMyMessage = new TMSMyMessageDetails();
                objMyMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                objMyMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                objMyMessage.MMDReceivedId = Convert.ToInt64(staffSplit[i]);
                objMyMessage.MMDReadStatus = 0;
                objMyMessage.MMDMessageTitle = staffID;
                objMyMessage.MMDMessageSubject = txtStaffSub.Text;
                objMyMessage.MMDDescription = txtStaffDesc.Text;
                objMyMessage.MMDMessageRemarks = "Send To Staff";
                objMyMessage.MMDMessageType = "Send To OtherStaff From Staff";
                objMyMessage.MMDAddedByType = "Account Manager";
                objMyMessage.MMDStatus = 1;
                objMyMessage.MMDSendDate = DateTime.Now;
                objMyMessage.Insert();

            }
            Response.Redirect("MyInbox.aspx?msg=Message Send To Staff Successfully!!!.");
        }
        catch (Exception) { }
    }
    protected void btnSatffAdd_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            txtToStaff.Text = "";
            int chkCount = 0, cnt = 0;
            string chkBidBox = null, addedUser = null;


            SectionInbox.Visible = false;
            SectionCompose.Visible = false;
            SectionSentMsg.Visible = false;
            sendall.Visible = false;
            sendtech.Visible = false;
            sendpart.Visible = false;
            sendstaf.Visible = true;
            sendPrincipal.Visible = false;

            MyInBox.Attributes.Add("class", "");
            MySentMesseages.Attributes.Add("class", "");
            Toall.Attributes.Add("class", "");
            ToTeccher.Attributes.Add("class", "");
            ToParents.Attributes.Add("class", "");
            ToStaff.Attributes.Add("class", "tabsactive");
            ToPrincipal.Attributes.Add("class", "");

            for (int i = 0; i < lvStaffList.Items.Count; i++)
            {
                ListViewItem datarow = lvStaffList.Items[i];
                if (((CheckBox)datarow.FindControl("chkStaffId")).Checked == true)
                {
                    chkCount++;
                }
            }
            if (chkCount > 0)
            {
                foreach (ListViewItem row in lvStaffList.Items)
                {
                    CheckBox chkStatus = (CheckBox)row.FindControl("chkStaffId");
                    int chkId = Convert.ToInt32(((Label)row.FindControl("lblChkStaffValue")).Text);

                    if (chkStatus.Checked == true)
                    {
                        ImageButton imgStaff = (ImageButton)row.FindControl("imgStaff");
                        cnt = cnt + 1;
                        chkBidBox += chkId + ",";
                        string name = ((Label)row.FindControl("lblStaffName")).Text;
                        if (string.IsNullOrEmpty(txtToStaff.Text))
                        {
                            txtToStaff.Text = name;
                        }
                        else
                        {
                            txtToStaff.Text = txtToStaff.Text + "," + name;
                        }
                        //addedUser += "<dl><dd class='col01'></dd><dd class='col02'><img src=" + imgStaff.ImageUrl.Replace("~", "..") + " width='32' height='32'></dd><dd class='col03'>" + ((Label)row.FindControl("lblStaffName")).Text + "</dd><section class='clear'></section></dl>";
                    }
                }
                HFStaffId.Value = chkBidBox;
                //selectStaff.Controls.Add(new LiteralControl(addedUser));
            }
        }
        catch (Exception) { }
    }
    protected void ddlSelectStaff_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            BindStaff();
        }
        catch (Exception) { }
    }

    protected void ddlGroupOne_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            BindAllGroup();
        }
        catch (Exception ex) { }

    }
    protected void buttonGroupAdd_Click(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            if (lstGroup.Items.Count > 0)
            {

                foreach (ListViewDataItem group in lstGroup.Items)
                {
                    CheckBox chkGroupAll = group.FindControl("chkGroupAll") as CheckBox;
                    if (chkGroupAll.Checked == true)
                    {
                        Label lblGroupId = group.FindControl("lblGroupId") as Label;
                        Int64 GroupId = Convert.ToInt64(lblGroupId.Text);

                        TMSGroupDetails objGroup = TMSGroupDetails.Get(GroupId);
                        if (objGroup != null)
                        {

                            string FacultyDetailsId = objGroup.GDGroupTeacherId.Remove(objGroup.GDGroupTeacherId.Length - 1, 1);

                            DataTable dtGroup = TMSGroupDetails.GetAllTeacherDetails_FromGroups(FacultyDetailsId, null, null).Tables[0];

                            if (dtGroup.Rows.Count > 0)
                            {



                                for (int i = 0; i < dtGroup.Rows.Count; i++)
                                {


                                    string name = dtGroup.Rows[i]["FD_FirstName"].ToString();
                                    if (string.IsNullOrEmpty(txtToGroup.Text))
                                    {
                                        txtToGroup.Text = name;
                                    }
                                    else
                                    {
                                        txtToGroup.Text = txtToGroup.Text + "," + name;
                                    }


                                }
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex) { }
    }
    protected void btnGroup_Send(object sender, EventArgs e)
    {
        try
        {
            if (lstGroup.Items.Count > 0)
            {

                foreach (ListViewDataItem group in lstGroup.Items)
                {
                    CheckBox chkGroupAll = group.FindControl("chkGroupAll") as CheckBox;
                    if (chkGroupAll.Checked == true)
                    {
                        Label lblGroupId = group.FindControl("lblGroupId") as Label;
                        Int64 GroupId = Convert.ToInt64(lblGroupId.Text);

                        TMSGroupDetails objGroup = TMSGroupDetails.Get(GroupId);
                        if (objGroup != null)
                        {

                            string FacultyDetailsId = objGroup.GDGroupTeacherId.Remove(objGroup.GDGroupTeacherId.Length - 1, 1);

                            DataTable dtGroup = TMSGroupDetails.GetAllTeacherDetails_FromGroups(FacultyDetailsId, null, null).Tables[0];

                            if (dtGroup.Rows.Count > 0)
                            {

                                for (int i = 0; i < dtGroup.Rows.Count; i++)
                                {
                                    //string name = dtGroup.Rows[i]["FD_FirstName"].ToString();
                                    //if (string.IsNullOrEmpty(txtToGroup.Text))
                                    // {
                                    //     txtToGroup.Text = name;
                                    // }
                                    // else
                                    // {
                                    //  txtToGroup.Text = txtToGroup.Text + "," + name;
                                    //}

                                    if (Convert.ToInt64(Session["UserId"]) == (Convert.ToInt64(dtGroup.Rows[i]["FD_LoginId"])))
                                    {

                                    }

                                    else
                                    {
                                        TMSMyMessageDetails objMyMessage = new TMSMyMessageDetails();
                                        objMyMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                                        objMyMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                                        objMyMessage.MMDReceivedId = Convert.ToInt64(dtGroup.Rows[i]["FD_LoginId"]);
                                        objMyMessage.MMDReadStatus = 0;
                                        objMyMessage.MMDMessageTitle = null;
                                        objMyMessage.MMDMessageSubject = txtGrpSubject.Text;
                                        objMyMessage.MMDDescription = txtGrpMessage.Text;
                                        objMyMessage.MMDMessageRemarks = "Send To Teachers";
                                        objMyMessage.MMDMessageType = "Send To Teachers From Staff";
                                        objMyMessage.MMDAddedByType = "Account Manager";
                                        objMyMessage.MMDStatus = 1;
                                        objMyMessage.MMDSendDate = DateTime.Now;
                                        objMyMessage.Insert();

                                    }
                                }

                            }
                        }
                    }
                }
            }

            Response.Redirect("MyInbox.aspx?msg=Message is successfully send", false);
        }
        catch (Exception ex) { }

    }
    protected void btnGrpCancel_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("Librariandashboard.aspx", false);
        }
        catch (Exception ex) { }
    }

    protected void lstGroup_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        try
        {
        }
        catch (Exception ex) { }
    }

    protected void RedioQuickSearch_CheckChanged(object sender, EventArgs e)
    {
        try
        {

            RadioButton rb = (RadioButton)sender;
            if (rb.ID == "RadioAllTeacher")
            {
                dvMsg.Visible = false;
                RadioAllTeacher.Checked = true;
                RadioAllGroup.Checked = false;

                SectionInbox.Visible = false;
                SectionCompose.Visible = false;
                SectionSentMsg.Visible = false;
                SectionAllTeacher.Visible = true;
                SectionAllGroup.Visible = false;

                sendall.Visible = false;
                sendtech.Visible = true;
                sendpart.Visible = false;
                sendstaf.Visible = false;
                sendPrincipal.Visible = false;


                MyInBox.Attributes.Add("class", "");
                MySentMesseages.Attributes.Add("class", "");
                Toall.Attributes.Add("class", "");
                ToTeccher.Attributes.Add("class", "tabsactive");
                ToParents.Attributes.Add("class", "");
                ToStaff.Attributes.Add("class", "");
                ToPrincipal.Attributes.Add("class", "");

                BindGroup();
                BindStandard();
                BindFaculty();

                txtToTeacher.Text = "";
                txtSendtoteacherSub.Text = "";
                txtSendToTeacherDesc.Text = "";
            }

            else
            {
                dvMsg.Visible = false;
                RadioAllTeacher.Checked = false;
                RadioAllGroup.Checked = true;
                SectionInbox.Visible = false;
                SectionCompose.Visible = false;
                SectionSentMsg.Visible = false;
                SectionAllTeacher.Visible = false;
                SectionAllGroup.Visible = true;
                sendall.Visible = false;
                sendtech.Visible = true;
                sendpart.Visible = false;
                sendstaf.Visible = false;
                sendPrincipal.Visible = false;

                MyInBox.Attributes.Add("class", "");
                MySentMesseages.Attributes.Add("class", "");
                Toall.Attributes.Add("class", "");
                ToTeccher.Attributes.Add("class", "tabsactive");
                ToParents.Attributes.Add("class", "");
                ToStaff.Attributes.Add("class", "");
                ToPrincipal.Attributes.Add("class", "");
                //BindAllGroup();

                DataTable dtGroup = TMSGroupDetails.GetSearch(null, null, null, null, null, null, null).Tables[0];//null, null, 2, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1).Tables[0];
                if (dtGroup.Rows.Count > 0)
                {
                    ddlGroupOne.DataSource = dtGroup;
                    ddlGroupOne.DataTextField = "GD_GroupName";
                    ddlGroupOne.DataValueField = "GD_GroupName";
                    ddlGroupOne.DataBind();
                    ddlGroupOne.Items.Insert(0, new ListItem("Select Group", "-1"));
                    lstGroup.DataSource = dtGroup;
                    lstGroup.DataBind();
                    ViewState["rowsgroupcount"] = lstGroup.Items.Count;
                }

                txtToGroup.Text = "";
                txtGrpSubject.Text = "";
                txtGrpMessage.Text = "";
            }
        }
        catch (Exception ex) { }
    }

    protected void BindAllGroup()
    {
        try
        {
            Int64? LoginId = null;

            string GroupType = null;

            if (ddlGroupOne.SelectedItem.Text == "Select Group")
            {
                GroupType = null;
            }
            else
            {
                GroupType = ddlGroupOne.SelectedItem.Text;
            }


            DataTable dtGroup = TMSGroupDetails.GetSearch(null, null, GroupType, null, null, null, null).Tables[0];//null, null, 2, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1).Tables[0];
            if (dtGroup.Rows.Count > 0)
            {
                ddlGroupOne.DataSource = dtGroup;
                ddlGroupOne.DataTextField = "GD_GroupName";
                ddlGroupOne.DataValueField = "GD_GroupName";
                ddlGroupOne.DataBind();
                ddlGroupOne.Items.Insert(0, new ListItem("Select Group", "-1"));
                lstGroup.DataSource = dtGroup;
                lstGroup.DataBind();

                ViewState["rowsgroupcount"] = lstGroup.Items.Count;
            }




        }
        catch (Exception ex) { }
    }


    protected void btnPrincipalSend_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtPrincipalSubject.Text != "")
            {
                //DataTable dtPrincipalMessage = TMSMyMessageDetails.GetSearchAllSendMyMessageData().Tables[5];
                TMSMyMessageDetails objMyMessage = new TMSMyMessageDetails();
                objMyMessage.MMDLoginId = Convert.ToInt64(Session["UserId"]);
                objMyMessage.MMDSenderId = Convert.ToInt64(Session["UserId"]);
                objMyMessage.MMDReceivedId = Convert.ToInt64(ddlPrincipal.SelectedValue);
                objMyMessage.MMDReadStatus = 0;
                objMyMessage.MMDMessageSubject = txtPrincipalSubject.Text;
                objMyMessage.MMDDescription = txtPrincipalMessage.Text;
                objMyMessage.MMDMessageType = "Send To Principal From Staff";
                objMyMessage.MMDMessageRemarks = "Send To Principal";
                objMyMessage.MMDAddedByType = "Account Manager";
                objMyMessage.MMDStatus = 1;
                objMyMessage.MMDSendDate = DateTime.Now;
                objMyMessage.Insert();

                Response.Redirect("MyInbox.aspx?msg=Message Send To Principal Successfully!!!.");
            }
            else
            {
                dvMsg.Visible = true;
                lblMessage.Text = "Please Enter Subject and Description";
                dvMsg.Attributes.Add("class", "error_msg");
            }
        }

        catch (Exception ex) { }
    }

    protected void lnkReply_Click1(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            LinkButton lnkReply = (LinkButton)sender;
            ListViewDataItem Replybtn = (ListViewDataItem)lnkReply.NamingContainer;
            HtmlGenericControl secMsgReply = Replybtn.FindControl("SectionViewThreadMsg") as HtmlGenericControl;
            HtmlGenericControl Sectionreplybox = Replybtn.FindControl("Sectionreplybox") as HtmlGenericControl;

            LinkButton lnkView = (LinkButton)Replybtn.FindControl("lnkMsgThraed");
            LinkButton lnkClose = (LinkButton)Replybtn.FindControl("lnkCloseThread");

            Sectionreplybox.Visible = true;
            secMsgReply.Visible = false;
            lnkView.Visible = true;
            lnkClose.Visible = false;

        }
        catch (Exception ex) { }
    }


    protected void rbtnInboxMessage_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            BindInboxItemMessage();
        }
        catch (Exception) { }
    }
    private void BindInboxItemMessage()
    {
        dvMsg.Visible = false;
        DataTable dtMessage = null;
        if (rbtnInboxMessage.SelectedItem.Value == "View All")
        {
            dtMessage = TMSMyMessageDetails.GetMessageDetailsFilterWise(null, null, null, Convert.ToInt64(Session["UserId"]), null, null, null, null, null, null, null).Tables[0];
        }
        else
        {
            dtMessage = TMSMyMessageDetails.GetMessageDetailsFilterWise(null, null, null, Convert.ToInt64(Session["UserId"]), null, null, null, null, null, rbtnInboxMessage.SelectedItem.Value, null).Tables[0];
        }
        if (dtMessage.Rows.Count > 0)
        {
            lstMessage.DataSource = dtMessage;
            lstMessage.DataBind();
        }
        else
        {
            lstMessage.DataSource = null;
            lstMessage.DataBind();
        }
    }
    protected void rbtnSentMessage_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            dvMsg.Visible = false;
            BindSentItemMessage();
        }
        catch (Exception) { }
    }
    private void BindSentItemMessage()
    {
        dvMsg.Visible = false;
        DataTable dtMessage = null;
        if (rbtnSentMessage.SelectedItem.Value == "Send To All")
        {
            dtMessage = TMSMyMessageDetails.GetMessageDetailsFilterWise(null, null, Convert.ToInt64(Session["UserId"]), null, null, null, null, null, null, null, null).Tables[0];
        }
        else
        {
            dtMessage = TMSMyMessageDetails.GetMessageDetailsFilterWise(null, null, Convert.ToInt64(Session["UserId"]), null, null, null, null, null, null, null, rbtnSentMessage.SelectedItem.Value).Tables[0];
        }
        if (dtMessage.Rows.Count > 0)
        {
            lstSentMsg.DataSource = dtMessage;
            lstSentMsg.DataBind();
        }
        else
        {
            lstSentMsg.DataSource = null;
            lstSentMsg.DataBind();
        }
    }
}
