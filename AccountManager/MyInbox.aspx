
<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master"
    AutoEventWireup="true" CodeFile="MyInbox.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_MyInbox" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script>
       function fnSelectAll() {
           var rowCount = '<%=ViewState["rowscount"]%>';
           if (document.getElementById('<%=chkSelectAll.ClientID%>').checked == true) {

               for (var i = 0; i < rowCount; i++) {
                    document.getElementById('ctl00_ContentPlaceHolder1_lvFaculty_ctrl' + i + '_chkBidId').checked = true;
                   //document.getElementById('ContentPlaceHolder1_lvFaculty_chkBidId_' + i).checked = true;
               }
           }
           else {
               for (var i = 0; i < rowCount; i++) {
                    document.getElementById('ctl00_ContentPlaceHolder1_lvFaculty_ctrl' + i + '_chkBidId').checked = false;
                   //document.getElementById('ContentPlaceHolder1_lvFaculty_chkBidId_' + i).checked = false;
               }
           }
       }
       function fnSelectAllGroup() {
           var rowCount = '<%=ViewState["rowsgroupcount"]%>';
           //  alert(rowCount);
           if (document.getElementById('<%=chkSelectAllGroup.ClientID%>').checked == true) {
               for (var i = 0; i < rowCount; i++) {
                    document.getElementById('ctl00_ContentPlaceHolder1_lstGroup_ctrl' + i + '_chkGroupAll').checked = true;
                   //document.getElementById('ContentPlaceHolder1_lstGroup_chkGroupAll_' + i).checked = true;
               }
           }
           else {
               for (var i = 0; i < rowCount; i++) {
                   document.getElementById('ctl00_ContentPlaceHolder1_lstGroup_ctrl' + i + '_chkGroupAll').checked = false;
                   //document.getElementById('ContentPlaceHolder1_lstGroup_chkGroupAll_' + i).checked = false;
               }
           }
       }
       function fnSelectParentAll() {
           var rowCount = '<%=ViewState["rowscountparent"]%>';
           //  alert(rowCount);
           if (document.getElementById('<%=chkParent.ClientID%>').checked == true) {
               for (var i = 0; i < rowCount; i++) {
                    document.getElementById('ctl00_ContentPlaceHolder1_lvParentList_ctrl' + i + '_chkParentId').checked = true;
                   //document.getElementById('ContentPlaceHolder1_lvParentList_chkParentId_' + i).checked = true;
               }
           }
           else {
               for (var i = 0; i < rowCount; i++) {
                   document.getElementById('ctl00_ContentPlaceHolder1_lvParentList_ctrl' + i + '_chkParentId').checked = false;
                   //document.getElementById('ContentPlaceHolder1_lvParentList_chkParentId_' + i).checked = false;
               }
           }
       }
       function fnSelectStaffAll() {
           var rowCount = '<%=ViewState["rowscountstaff"]%>';
           //  alert(rowCount);
           if (document.getElementById('<%=chkAllStaff.ClientID%>').checked == true) {
               for (var i = 0; i < rowCount; i++) {
                   document.getElementById('ctl00_ContentPlaceHolder1_lvStaffList_ctrl' + i + '_chkStaffId').checked = true;
                   //document.getElementById('ContentPlaceHolder1_lvStaffList_chkStaffId_' + i).checked = true;
               }
           }
           else {
               for (var i = 0; i < rowCount; i++) {
                    document.getElementById('ctl00_ContentPlaceHolder1_lvStaffList_ctrl' + i + '_chkStaffId').checked = false;
                   //document.getElementById('ContentPlaceHolder1_lvStaffList_chkStaffId_' + i).checked = false;
               }
           }
       }
    </script>

    <script>
      function fnCheckSelection()
      {
         var rowCount = '<%=ViewState["rowscount"]%>'; 
         var chkCount = 0 ;
         
          if(document.getElementById('<%=chkSelectAll.ClientID%>').checked == true)
            return true;
         else 
         {
            for(var i=0; i<rowCount; i++)
               {
                  if(document.getElementById('ctl00_ContentPlaceHolder1_lvFaculty_ctrl' + i + '_chkBidId').checked == true)
                  {
                    chkCount = 1 ;
                    break;
                  }
               }
               
               if(chkCount == 0) {
               {
                 alert("Select two Bid Request to compare");
                 return false;
               }
               else
               
                 return true; 
         }
      }
    </script>

    <script type="text/javascript">
    function SetCategory(imgId){ 
    alert(imgId); 
         var secId='secImg'+imgId; 
         var replaceId=imgId;
         var HFSelectdImg =document.getElementById("HFSelectdImg");
         var SelectedCat=document.getElementById("HFSelectdImg").value;
         var replaceId=imgId+","; 
            if(document.getElementById(secId).className=="SelectedCategoryCSS")
             {
                document.getElementById(secId).setAttribute("class", "travlpackslidr_bg");
                document.getElementById("HFSelectdImg").value=SelectedCat.replace(replaceId,"");                                        
             }
             else
             {
               document.getElementById(secId).setAttribute("class", "SelectedCategoryCSS");
               document.getElementById("HFSelectdImg").value +=replaceId;
             }             
    }  
    function CheckOne(obj)
    {  
       var rowCount = '<%=ViewState["rowscount"]%>'; 
         var chkCount = 0 ;
         
          if(document.getElementById('<%=chkSelectAll.ClientID%>').checked == true)
            return true;
         else 
         {
              for(var i=0; i<rowCount; i++)
               {
                  if(document.getElementById('ctl00_ContentPlaceHolder1_lvFaculty_ctrl' + i + '_chkBidId').checked == true)
                  {
                  alert(document.getElementById('ctl00_ContentPlaceHolder1_lvFaculty_ctrl' + i + '_lblChkValue').innerHTML);                 
                    chkCount = 1 ;                
                  }
               }
         }
    }          
    </script>

    <style type="text/css">
        .bg
        {
            position: absolute;
            z-index: 100;
            top: 0px;
            left: 0px;
            background-color: #000;
            filter: alpha(opacity=60);
            -moz-opacity: 0.6;
            opacity: 0.6;
        }
        .modalBackground
        {
            position: absolute;
            z-index: 100;
            top: 0px;
            left: 0px;
            background-color: #000;
            filter: alpha(opacity=60);
            -moz-opacity: 0.6;
            opacity: 0.6;
        }
        .modalPopup
        {
            background-color: #ffffff;
            border-width: 3px;
            border-style: solid;
            border-color: Gray;
            padding: 10px 10px 10px 10px;
            width: 500px;
            height: 300px;
            overflow: auto;
            text-align: justify;
            color: #454545;
            font: 12px/18px Arial,Helvetica,sans-serif;
        }
        . news_title1
        {
            font: 18px "Trebuchet MS" ,Arial,Helvetica,sans-serif;
            margin-top: 25px;
            text-transform: uppercase;
        }
        }</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <section class="top_row">
        <section class="achiv_toptitle">
            My <span>Inbox</span>
        </section>
        <section class="top_row_back">
            <a href="javascript:history.go(-1)" title="Back">BACK</a></section>
        <section class="clear">
        </section>
    </section>
    <section class="top_row">
        <section id="dvMsg" runat="server" visible="false" style="width: -2px;">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <section class="clear">
            </section>
        </section>
        <section class="clear">
        </section>
    </section>
    <section class="tab_wrapp" id="tabs">
        <section class="tab_nav">
            <ul>
                <%--<li><a href="#inbox">Inbox</a></li>
                                    <li><a href="#sentitem">Sent Item</a></li>
                                     <li><a href="#compose">Compose</a></li>--%>
                <li><a id="MyInBox" runat="server" onserverclick="InBox_Click" class="tabsactive">Inbox</a></li>
                <li><a id="MySentMesseages" runat="server" onserverclick="MySentMesseages_Click">Sent Item</a></li>
                
                <li><a id="Toall" runat="server" onserverclick="Send_ToAll">Send to All</a></li>
                <li><a id="ToTeccher" runat="server" onserverclick="Send_ToTeacher">Send to Teachers</a></li>
                <li><a id="ToParents" runat="server" onserverclick="Send_ToParents">Send to Parents</a></li>
                <li><a id="ToStaff" runat="server" onserverclick="Send_ToStaff">Send to Staff</a></li>
                 <li><a id="ToPrincipal" runat="server" onserverclick="Send_ToPrincipal">Send to Principal</a></li>
                
                <section class="clear">
                </section>
            </ul>
        </section>
        <section class="tab_des_wrapp" runat="server" id="SectionInbox" style="margin: 9px 0px -4px 0px;">
         <section  style="padding-left :10px;">
             	 <asp:RadioButtonList ID="rbtnInboxMessage" runat="server" AutoPostBack="True" onselectedindexchanged="rbtnInboxMessage_SelectedIndexChanged"  RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="View All">View All</asp:ListItem>
                    <asp:ListItem Value="Send To Staff From Teachers">View Teacher Message</asp:ListItem>
                    <asp:ListItem Value="Send To OtherStaff From Staff">View Staff Message</asp:ListItem>
                    <asp:ListItem Value="Send To Staff From Parents">View Parent Message</asp:ListItem>
                    <asp:ListItem Value="Send To Staff From Principal">View Principal Message</asp:ListItem>
                  </asp:RadioButtonList>
            </section>
            <section class="inbox_wrapp">
                <asp:ListView ID="lstMessage" runat="server" ItemPlaceholderID="PlaceHolder1" OnItemDataBound="lstMessage_ItemDataBound"
                    OnItemCommand="lstMessage_ItemCommand" OnPagePropertiesChanging="lstMessage_ChangePage">
                    <LayoutTemplate>
                        <asp:PlaceHolder ID="PlaceHolder1" runat="server" />
                    </LayoutTemplate>
                    <ItemTemplate>
                    
                        <dl>
                            <section class="white_box">
                                <section class="img_box">
                                    <asp:ImageButton runat="server" ID="lblSenderPhoto" Width="58" Height="58" ImageUrl='<%#Bind("SenderPhoto") %>'>
                                    </asp:ImageButton></section>
                                <section class="inbox_txt_box">
                                    <section class="msg_title">
                                        <a id="aSenderName" runat="server" style="font-size: 12px; color:#0D8EB9; font-weight:bold;">
                                            <asp:Label runat="server" ID="lblSenderName" Text='<%#Bind("SenderName") %>'></asp:Label>
                                        &nbsp;<asp:Label runat="server" ID="lblDays" Text='<%#Bind("Days")%>' Visible="false"></asp:Label>
                                        <asp:Label runat="server" ID="lblHours" Text='<%#Bind("Hours")%>' Visible="false"></asp:Label>
                                          <asp:Label runat="server" ID="lblMins" Text='<%#Bind("Mins")%>' Visible="false"></asp:Label>
                                           <asp:Label runat="server" ID="lblSeconds" Text='<%#Bind("Seconds")%>' Visible="false"></asp:Label>
                                           <asp:Label runat="server" ID="lblAgo"  Visible="false"></asp:Label>
                                        &nbsp;(<asp:Label runat="server" ID="lblReplyTime" Text='<%#Bind("ReplyTime")%>'></asp:Label>)<%--&nbsp;<asp:Label runat="server" ID="lblStatus"></asp:Label>--%></a>
                                        <asp:Label ID="lblMessageId" runat="server" Text='<%# Bind("MMD_MessageId") %>' Visible="False"></asp:Label>
                                        <asp:Label ID="lblSenderId" runat="server" Text='<%# Bind("MMD_SenderId") %>' Visible="False"></asp:Label>
                                        <asp:Label ID="lblReceiverId" runat="server" Text='<%# Bind("MMD_ReceivedId") %>'
                                            Visible="False"></asp:Label>
                                            <asp:Label ID="lblReadStatus" runat="server" Text='<%# Bind("MMD_ReadStatus") %>' Visible="False"></asp:Label>
                                    </section>
                                    <article>Subject : &nbsp;<asp:Label runat="server" id="lblSubject" Text='<%#Bind("MMD_MessageSubject") %>'></asp:Label></article>
                                    <article>Description: &nbsp;<asp:Label runat="server" id="lblDesc" Text='<%#Eval("MMD_Description").ToString().Length > 10? Eval("MMD_Description").ToString().Substring(0, 10) : Eval("MMD_Description") %>'></asp:Label> &nbsp; 
                                                  <asp:LinkButton ID="lnkViewMsg"   runat="server" Text="View More...." OnClick="lnkViewMsg_Details"></asp:LinkButton>
                              <cc1:ModalPopupExtender  ID="extPerson" runat="server" TargetControlID="lnkViewMsg"
                                PopupControlID="pnlPerson"  BackgroundCssClass="modalBackground"  CacheDynamicResults="True" Enabled="True" ></cc1:ModalPopupExtender>
                                                </article>
                                </section>
                                <section class="replay_box">
                                    <section class="close">
                                        <asp:ImageButton ID="ImageButton1" CommandArgument='<%# Bind("MMD_MessageId") %>'
                                            CommandName="MsgDelete" runat="server" ImageUrl="../img/pop_close_icon.png" Height="15px"
                                            Width="15px" ToolTip="Delete Message" OnClientClick="javascript:return confirm('Do you want to delete the message?');">
                                        </asp:ImageButton></section>
                                    <asp:LinkButton ID="lnkReply" runat="server" Text="Reply" OnClick="lnkReply_Click1"></asp:LinkButton>
                                    <asp:LinkButton ID="lnkMsgThraed" runat="server" Text="ViewAll"   OnClick="lnkMsgThraed_Click" style="text-align:left"></asp:LinkButton>
                                     <asp:LinkButton ID="lnkCloseThread" runat="server" Text="Close"  OnClick="lnkCloseThread_Click" style="text-align:left" Visible="false"></asp:LinkButton>
                                </section>
                                <section class="clear">
                                </section>
                                <section id="Sectionreplybox" runat="server" class="msg_replay_box" style="margin-top: 10px;" visible="false">
                                    <asp:TextBox ID="txtMessage" runat="server" CssClass="textarea" TextMode="MultiLine"
                                        Height="138px" Width="632px"></asp:TextBox>
                                    <section>
                                        <asp:Button ID="btnCancel1" CssClass="black_btn rF" runat="server" OnClick="btnCancel1_Click1" Style="margin-left: 10px;"
                                            Text="Cancel" />
                                        <asp:Button ID="btnAnswer" CssClass="black_btn rF" runat="server" Text="Reply" OnClick="btnAnswer_Click" />
                                        <section class="clear">
                                        </section>
                                    </section>
                                </section>
                                <section id="SectionViewThreadMsg" runat="server" class="msg_replay_box" style="margin-top: 10px;" Visible="false">
                                 
                                      <asp:ListView runat="server" ID="lstMsgThread" ItemPlaceholderID="PlaceHolder2">
                               <LayoutTemplate> 
                                     <asp:PlaceHolder id="PlaceHolder2" runat="server" /> 
                               </LayoutTemplate>
                                 <ItemTemplate> 
                                  <section>                          
                                   <b><asp:Label runat="server" ID="lblReplySenderName" Text='<%# Bind("Sender_Name") %>'></asp:Label></b>
                                    &nbsp;<asp:Label runat="server" ID="lblSenderDate"  Text='<%# Bind("ReplyTime") %>'></asp:Label>
                                    <article><b>Description :</b> <asp:Label runat="server" id="lblReplyDesc" Text='<%# Bind("MMD_Description") %>'></asp:Label>
                                   <section class="clear"></section>
                                  </section>         
                                 </ItemTemplate>
                               <EmptyDataTemplate>
                                <asp:Label runat="server" ID="lblEmpty" Text="No Record Found" ForeColor="Red" style="padding-left:146px;"></asp:Label>
                               </EmptyDataTemplate>
                               </asp:ListView>
                                </section>
                            </section>
                        </dl>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        <asp:Label ID="Label242sf" Style="font-weight: bold; font-size: 13px; color: Red;"
                            runat="server" Text="No Record Found"></asp:Label>
                    </EmptyDataTemplate>
                </asp:ListView>
                <section class="pagna">
                    <ul>
                        <asp:DataPager ID="DataPagerTrip" runat="server" PagedControlID="lstMessage" PageSize="15">
                            <Fields>
                                <asp:NextPreviousPagerField ShowFirstPageButton="True" ShowNextPageButton="False"
                                    PreviousPageText="Previous" FirstPageText="First" ButtonCssClass="Pagbtn" />
                                <asp:NumericPagerField NumericButtonCssClass="Pagbtn" />
                                <asp:NextPreviousPagerField ShowLastPageButton="True" ShowPreviousPageButton="False"
                                    LastPageText="Last" NextPageText="Next" ButtonCssClass="Pagbtn" />
                            </Fields>
                        </asp:DataPager>
                    </ul>
                </section>
            </section>
        </section>
        <section class="tab_des_wrapp" runat="server" id="SectionCompose" style="margin: 9px 0px -4px 0px;">
            <section class="compose_box">
                <ul>
                    <%-- <li>
                                	<label>Select :</label>
                                    <select><option>Teacher</option></select>
                                 </li>
                                 <li>
                                	<label>To :</label>
                                   <input type="text">
                                 </li>
                                 <li>
                                	<label>Subject :</label>
                                    <input type="text">
                                 </li>
                                 <li>
                                	<label>Description :</label>
                                    <textarea></textarea>
                                    <section class="clear"></section>
                                 </li>--%>
                    <li>
                        <label>To :</label>
                        <asp:TextBox ID="txtMsgTo" runat="server" ReadOnly="true"></asp:TextBox>
                    </li>
                    <li>
                        <label>Subject :</label>
                        <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
                    </li>
                    <li>
                        <label>Description :</label>
                        <asp:TextBox ID="txtDesc" runat="server" TextMode="MultiLine"></asp:TextBox>
                        <section class="clear">
                        </section>
                    </li>
                </ul>
            </section>
            <section style="padding-right: 198px;" class="save_bt_box_small">
                <%--  <input type="submit" value="Save">
                           <input type="reset" value="Cancel">--%>
                <asp:Button ID="btnUpdate" Text="Reply" runat="server" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancelOne_Click" />
            </section>
        </section>
        <section class="tab_des_wrapp" runat="server" id="SectionSentMsg" style="margin: 9px 0px -4px 0px;">
                <section  style="padding-left :0px;">
             	 <asp:RadioButtonList ID="rbtnSentMessage" runat="server" AutoPostBack="True" onselectedindexchanged="rbtnSentMessage_SelectedIndexChanged"  RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="Send To All">View All</asp:ListItem>
                    <asp:ListItem Value="Send To Teachers">View Teacher Message</asp:ListItem>
                    <asp:ListItem Value="Send To Staff">View Staff Message</asp:ListItem>
                    <asp:ListItem Value="Send To Parents">View Parent Message</asp:ListItem>
                    <asp:ListItem Value="Send To Principal">View Principal Message</asp:ListItem>
                  </asp:RadioButtonList>
            </section>
            <asp:ListView ID="lstSentMsg" runat="server" ItemPlaceholderID="PlaceHolder1" OnItemDataBound="lstSentMsg_ItemDataBound"
                OnItemCommand="lstSentMsg_ItemCommand" OnPagePropertiesChanging="lstSentMsg_ChangePage">
                <LayoutTemplate>
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server" />
                </LayoutTemplate>
                <ItemTemplate>
                    <dl>
                        <section class="white_box">
                            <section class="inbox_txt_box">
                                <section class="msg_title">
                                    <a href="#">To:<asp:Label runat="server" ID="Label1" Text='<%#Bind("ReceiverName") %>'></asp:Label></a>&nbsp;
                                     <asp:Label runat="server" ID="lblDays" Text='<%#Bind("Days")%>' Visible="false"></asp:Label>
                                         &nbsp;<asp:Label runat="server" ID="lblHours" Text='<%#Bind("Hours")%>' Visible="false"></asp:Label>
                                          <asp:Label runat="server" ID="lblMins" Text='<%#Bind("Mins")%>' Visible="false"></asp:Label>
                                           <asp:Label runat="server" ID="lblSeconds" Text='<%#Bind("Seconds")%>' Visible="false"></asp:Label>
                                            <asp:Label runat="server" ID="lblAgo" Visible="false"></asp:Label>
                                        (<asp:Label runat="server" ID="lblReplyTime" Text='<%#Bind("ReplyTime")%>'></asp:Label>)
                                    <asp:ImageButton ID="ImageButton1" CommandArgument='<%# Bind("MMD_MessageId") %>'
                                        CommandName="MsgDelete" runat="server" ImageUrl="../img/pop_close_icon.png" Height="15px"
                                        Width="15px" ToolTip="Delete Message" Style="float: right;" OnClientClick="javascript:return confirm('Do you want to delete the message?');">
                                    </asp:ImageButton>
                                    <asp:Label ID="lblMessageId" runat="server" Text='<%# Bind("MMD_MessageId") %>' Visible="False"></asp:Label></section>
                                <article><b>Subject :</b> &nbsp;<asp:Label runat="server" id="lblSubject" Text='<%#Bind("MMD_MessageSubject") %>'></asp:Label></article>
                                <article><asp:Label runat="server" id="lblDesc" Text='<%#Bind("MMD_Description") %>'></asp:Label></article>
                            </section>
                            <section class="replay_box">
                                <section class="close">
                                </section>
                            </section>
                            <section class="clear">
                            </section>
                        </section>
                    </dl>
                </ItemTemplate>
                <EmptyDataTemplate>
                    <asp:Label ID="Label242sf" Style="font-weight: bold; font-size: 13px; color: Red;"
                        runat="server" Text="No Record Found"></asp:Label>
                </EmptyDataTemplate>
            </asp:ListView>
            <section class="pagna">
                <ul>
                    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="lstSentMsg" PageSize="10">
                        <Fields>
                            <asp:NextPreviousPagerField ShowFirstPageButton="True" ShowNextPageButton="False"
                                PreviousPageText="Previous" FirstPageText="First" ButtonCssClass="Pagbtn" />
                            <asp:NumericPagerField NumericButtonCssClass="Pagbtn" />
                            <asp:NextPreviousPagerField ShowLastPageButton="True" ShowPreviousPageButton="False"
                                LastPageText="Last" NextPageText="Next" ButtonCssClass="Pagbtn" />
                        </Fields>
                    </asp:DataPager>
                </ul>
            </section>
        </section>
    </section>
    
    <section class="tab_des_wrapp" id="sendall" runat="server" style="margin:9px 0px -4px 0px;">
 	<section class="compose_box">
		<ul>
    
     	
      
      <li>	<label>Subject :</label>
      
     <asp:DropDownList ID="ddlSendToAll" runat="server">
         <asp:ListItem>All</asp:ListItem>
          </asp:DropDownList>
      
      <asp:TextBox ID="txtSubjectAll"  MaxLength="250" runat="server"></asp:TextBox>
       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtSubjectAll" SetFocusOnError="true"
  ValidationGroup="sub" style="padding-left:230px;"></asp:RequiredFieldValidator>
      </li>
      <li>
     	<label>Message :</label>
    <asp:TextBox ID="txtMessageAll" TextMode="MultiLine" MaxLength="350" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtMessageAll" SetFocusOnError="true"
  ValidationGroup="sub" style="padding-left:230px;"></asp:RequiredFieldValidator>
  <cc1:filteredtextboxextender id="FilteredTextBoxExtender2" runat="server" enabled="True" validchars="abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789/?!@#$%^&*  " targetcontrolid="txtMessageAll" >
  </cc1:filteredtextboxextender>
         <section class="clear"></section>
      </li>
 </ul>
 </section>
 <section style="padding-right:198px;" class="save_bt_box_small">
 <asp:Button ID="btnSend" runat="server" Text="Send" OnClick=" btnSend_Click"  ValidationGroup="sub"></asp:Button>
 <asp:Button ID="Button1" runat="server" OnClick="btnCancel_Click"  Text="Cancel"/>
 </section>
 
</section>
 <section class="tab_des_wrapp" id="sendtech" runat="server" style="margin:9px 0px -4px 0px;">
 
 
  <asp:RadioButton ID ="RadioAllTeacher" runat ="server"  Text ="All Teacher" GroupName ="q"   Checkedt="true" AutoPostBack ="true" OnCheckedChanged ="RedioQuickSearch_CheckChanged" />
  <asp:RadioButton ID ="RadioAllGroup" runat ="server" Text ="Group Of Teachers" GroupName ="q"  AutoPostBack ="true" OnCheckedChanged ="RedioQuickSearch_CheckChanged"/>
 
 <section id="SectionAllTeacher" runat="server">
		<section class="send_tech_wrapp">
     	<section class="send_tech_left">    
         	<section class="sle_box">  <asp:CheckBox ID="chkSelectAll" onclick="fnSelectAll()" runat="server"></asp:CheckBox>Select All</section>
             <section class="slec_group_box">
             <asp:DropDownList ID="ddlGroup" runat="server" AutoPOstBack="True" 
                     onselectedindexchanged="ddlGroup_SelectedIndexChanged"></asp:DropDownList>
                     <asp:DropDownList ID="ddlStandard" runat="server" 
        AutoPostBack="True" onselectedindexchanged="ddlStandard_SelectedIndexChanged"></asp:DropDownList>
             
             </section>
             <section class="sle_name_wrapp">
                 <asp:ListView ID="lvFaculty" runat="server" 
                ItemPlaceholderID="itemContainer" 
        onitemdatabound="lvFaculty_ItemDataBound">
                  <LayoutTemplate>
                       <ul>
                           <asp:PlaceHolder ID="itemContainer" runat="server"></asp:PlaceHolder>
                       </ul>
                   </LayoutTemplate>
                   <ItemTemplate>  
                                 
                     <dl>
                     
                        <asp:CheckBox ID="chkBidId" runat="server" onclick='JavaScript:CheckOne(this)'/>
                     <asp:Label ID="lblChkValue" runat="server" Text='<%#Eval("FD_LoginId") %>' Visible="false"></asp:Label>
                      <section class="img_box"><asp:ImageButton id="imgFaculty" ImageUrl='<%#Bind("FD_Image") %>' runat="server" width="32" height="32"></asp:ImageButton></section>
                      <section class="nd_box">
                          <b><a href="javascript:;"><asp:Label ID="lblUserName" runat="server" Text='<%#Eval("UserName")%>'></asp:Label> </a></b>
                          <section><%#Eval("FD_HighestDegreeCompletd")%> <%#Eval("FD_SpecificExpertise")%><br /><asp:Label id="lblCompleteYear" Text='<%#Bind("FD_CompletionDate") %>' runat="server"></asp:Label></section>
                      </section>
                      <section class="clear"></section>
                      
                  </dl>
                                 
                   </ItemTemplate>
                   <EmptyDataTemplate>
                   <asp:Label ID="Label1" runat="server" style="color:Red;" Text="No Record Exists."></asp:Label>
                   </EmptyDataTemplate>
                  </asp:ListView>
                   </section>   
                            
             </section> <section class="add_bt_box" style="margin-top:13px;">
 <asp:Button ID="buttonAdd"  runat="server" Text="ADD TO LIST"  OnClick="buttonAdd_Click"/>
         </section>    
     
       
         <section class="msg_send_box">
         	        <ul>
         	        <%--<li>
         	         <section >
                        <section class="left_cretgrp">
                        <section class="margin3810">
                           <section class="clear"></section> 
                         </section>
                         <section class="clear"></section>
                        <section class="mainteacher_grp mainteacher_cretgrp margintopminus" runat="server" id="SectionLeftCrtGrp">
                      <dl class="back_top_cret">
                     <dd class="col01">&nbsp;</dd>
                       <dd class="col02">Photo</dd>
                         <dd class="col03">Teacher's Name</dd>
                      
                      <section class="clear"></section>
                      </dl>
                      <section class="whitebody_cret" style="height:267px;" id="selectFaculty" runat="server">
                     </section>
                      
                      </section>
                         </section>
                            <section class="clear"></section>
                        </section>
                      
         	        </li>--%>
         	         <li>
                        <label>To :</label>
                  <asp:TextBox ID="txtToTeacher" TextMode="MultiLine" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtToTeacher" SetFocusOnError="true"
  ValidationGroup="sub1" style="padding-left:70px;"></asp:RequiredFieldValidator>
                   <section class="clear"></section>
                     </li>
         	         <li>
                        <label>Subject :</label>
                  <asp:TextBox ID="txtSendtoteacherSub" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtSendtoteacherSub" SetFocusOnError="true"
  ValidationGroup="sub1" style="padding-left:70px;"></asp:RequiredFieldValidator>
                   <section class="clear"></section>
                     </li>
                  <li>
                     <label>Message :</label>
                     <asp:TextBox ID="txtSendToTeacherDesc" TextMode="MultiLine" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtSendToTeacherDesc" SetFocusOnError="true"
  ValidationGroup="sub1" style="padding-left:70px;"></asp:RequiredFieldValidator>
                     <section class="clear"></section>
                  </li>
             </ul>
              <section style="padding-right:10px;" class="save_bt_box_small">
    <%-- <input type="reset" value="Cancel">--%>
            <asp:Button ID="btnTeacher" runat="server" Text="Send" OnClick="btnTeacher_Send"  ValidationGroup="sub1" />
    <%-- </ContentTemplate>
 </asp:UpdatePanel>--%>
<asp:Button ID="Button2" runat="server" OnClick="btnCancel_Click"  Text="Cancel"/>
             </section>
         </section>
         <section class="clear"></section>
     </section>
     
   </section>  
   
   
    <section id="SectionAllGroup" runat="server">
		<section class="send_tech_wrapp">
     	<section class="send_tech_left">    
         	<section class="sle_box">  <asp:CheckBox ID="chkSelectAllGroup" onclick="fnSelectAllGroup()" runat="server"></asp:CheckBox>Select All</section>
             <section class="slec_group_box">
             <asp:DropDownList ID="ddlGroupOne" runat="server" AutoPOstBack="True" 
                     onselectedindexchanged="ddlGroupOne_SelectedIndexChanged"></asp:DropDownList>
                     <%--<asp:DropDownList ID="DropDownList2" runat="server" 
        AutoPostBack="True" onselectedindexchanged="ddlStandard_SelectedIndexChanged"></asp:DropDownList>--%>
             
             </section>
             <section class="sle_name_wrapp">
                 <asp:ListView ID="lstGroup" runat="server" 
                ItemPlaceholderID="itemGrpContainer" 
        onitemdatabound="lstGroup_ItemDataBound">
                  <LayoutTemplate>
                       <ul>
                           <asp:PlaceHolder ID="itemGrpContainer" runat="server"></asp:PlaceHolder>
                       </ul>
                   </LayoutTemplate>
                   <ItemTemplate>                   
                     <dl>
                        <asp:CheckBox ID="chkGroupAll" runat="server"/>
                     <asp:Label ID="lblGroupId" runat="server" Text='<%#Eval("GD_GroupId") %>' Visible="false"></asp:Label>
                      <asp:Label ID="lblGroupChkValue" runat="server" Visible="false"></asp:Label>
                     <%-- <section class="img_box"><asp:ImageButton id="imgFaculty" ImageUrl='<%#Bind("FD_Image") %>' runat="server" width="32" height="32"></asp:ImageButton></section>--%>
                      <section class="nd_box">
                      <asp:Label ID="lblGroupName" Text='<%#Bind("GD_GroupName") %>' runat="server"></asp:Label>
                         <%-- <b><a href="javascript:;"><asp:Label ID="lblUserName" runat="server" Text='<%#Eval("UserName")%>'></asp:Label> </a></b>
                          <section><%#Eval("FD_HighestDegreeCompletd")%> <%#Eval("FD_SpecificExpertise")%><br /><asp:Label id="lblCompleteYear" Text='<%#Bind("FD_CompletionDate") %>' runat="server"></asp:Label></section>--%>
                      </section>
                      <section class="clear"></section>
                  </dl>                 
                   </ItemTemplate>
                   <EmptyDataTemplate>
                   <asp:Label ID="Label1" runat="server" style="color:Red;" Text="No Record Exists."></asp:Label>
                   </EmptyDataTemplate>
                  </asp:ListView>
                   </section>   
                            
             </section> <section class="add_bt_box" style="margin-top:13px;">
 <asp:Button ID="buttonGroupAdd"  runat="server" Text="ADD TO LIST"  OnClick="buttonGroupAdd_Click"/>
         </section>    
     
       
         <section class="msg_send_box">
         	        <ul>
         	         <li>
                        <label>To :</label>
                  <asp:TextBox ID="txtToGroup" TextMode="MultiLine" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtToGroup" SetFocusOnError="true"
  ValidationGroup="sub2" style="padding-left:70px;"></asp:RequiredFieldValidator>
                   <section class="clear"></section>
                     </li>
         	         <li>
                        <label>Subject :</label>
                  <asp:TextBox ID="txtGrpSubject" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtGrpSubject" SetFocusOnError="true"
  ValidationGroup="sub2" style="padding-left:70px;"></asp:RequiredFieldValidator>
                   <section class="clear"></section>
                     </li>
                  <li>
                     <label>Message :</label>
                     <asp:TextBox ID="txtGrpMessage" TextMode="MultiLine" runat="server"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtGrpMessage" SetFocusOnError="true"
  ValidationGroup="sub2" style="padding-left:70px;"></asp:RequiredFieldValidator>
                     <section class="clear"></section>
                  </li>
             </ul>
              <section style="padding-right:10px;" class="save_bt_box_small">
    <%-- <input type="reset" value="Cancel">--%>
            <asp:Button ID="Button5" runat="server" Text="Send" OnClick="btnGroup_Send" ValidationGroup="sub2" />
    <%-- </ContentTemplate>
 </asp:UpdatePanel>--%>
<asp:Button ID="Button6" runat="server" OnClick="btnGrpCancel_Click"  Text="Cancel"/>
             </section>
         </section>
         <section class="clear"></section>
     </section>
     
   </section>  
   
   
   
</section>

  <section class="tab_des_wrapp" id="sendpart" runat="server" style="margin:9px 0px -4px 0px;">
		<section class="send_tech_wrapp">
     	<section class="send_tech_left">
         	<section class="sle_box"> <asp:CheckBox ID="chkParent" onclick="fnSelectParentAll()" runat="server"></asp:CheckBox>Select All<section class="clear"></section></section>
             <section class="slec_group_box">
             
           <asp:DropDownList ID="ddlParentStandard" runat="server" 
        AutoPostBack="True" 
        onselectedindexchanged="ddlParentStandard_SelectedIndexChanged"></asp:DropDownList>
             </section>
             <section class="sle_name_wrapp">
               <asp:ListView ID="lvParentList" runat="server" ItemPlaceholderID="itemContainer" OnItemDataBound="lvParentList_DataBound">
                   <LayoutTemplate>
                      <ul>
                          <asp:PlaceHolder ID="itemContainer" runat="server"></asp:PlaceHolder>
                      </ul>
                   </LayoutTemplate>
                   <ItemTemplate>   
             	     <dl>
                  <asp:CheckBox ID="chkParentId" runat="server"/>
                    <asp:Label ID="lblChkParentValue" runat="server" Text='<%#Eval("PD_FatherLoginId") %>' Visible="false"></asp:Label>
                     <section class="img_box"><asp:ImageButton id="imgParent" ImageUrl='<%#Bind("PD_FatherPhoto") %>' runat="server" width="32" height="32"></asp:ImageButton></section>
                     <section class="nd_box">
                     	<b><a href="javascript:;"><asp:Label ID="lblParentName" runat="server" Text='<%#Eval("PD_FatherFullName")%>'></asp:Label></a></b>
                         <section><%#Eval("PD_FatherOccupation")%> at <br /><%#Eval("PD_FatherOrgName")%></section>
                     </section>
                     <section class="clear"></section>
               <%--  <br />
                  <asp:CheckBox ID="chkMotherId" runat="server"/>
                    <asp:Label ID="lblChkMotherValue" runat="server" Text='<%#Eval("PD_MotherLoginId") %>' Visible="false"></asp:Label>
                     <section class="img_box"><asp:ImageButton id="imgMother" ImageUrl='<%#Bind("PD_MotherPhoto") %>' runat="server" width="32" height="32"></asp:ImageButton></section>
                     <section class="nd_box">
                     	<b><a href="javascript:;"><asp:Label ID="lblMotherName" runat="server" Text='<%#Eval("PD_MotherFullName")%>'></asp:Label></a></b>
                         <section><%#Eval("PD_MotherOccupation")%> at <br /><%#Eval("PD_MotherOrgName")%></section>
                     </section>
                     <section class="clear"></section>--%>
                 </dl>
                 
                 
                   </ItemTemplate>
                   <EmptyDataTemplate>
                   <asp:Label ID="Label1" runat="server" style="color:Red;" Text="No Record Exists."></asp:Label>
                   </EmptyDataTemplate>
               </asp:ListView>
             </section>
             
         </section>   <section class="add_bt_box" style="margin-top:13px;">
             <asp:Button ID="btnParentAdd"  runat="server" Text="ADD TO LIST" onclick="btnParentAdd_Click"/>
         </section>      
         <section class="msg_send_box">
         	   <ul>
                 <%-- <li>
         	         <section >
                        <section class="left_cretgrp">
                        <section class="margin3810">
                           <section class="clear"></section> 
                         </section>
                         <section class="clear"></section>
                        <section class="mainteacher_grp mainteacher_cretgrp margintopminus" runat="server" id="SectionLeftCrtGrp1">
                      <dl class="back_top_cret">
                     <dd class="col01">&nbsp;</dd>
                       <dd class="col02">Photo</dd>
                         <dd class="col03">Parent's Name</dd>
                      
                      <section class="clear"></section>
                      </dl>
                      <section class="whitebody_cret" style="height:267px;" id="selectParent" runat="server">
                      
                     </section>
                      
                      </section>
                         </section>
                            <section class="clear"></section>
                        </section>
                      
         	        </li>--%>
         	        <li>
         	        <label>To :</label>
                  <asp:TextBox ID="txtToParent" TextMode="MultiLine" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtToParent" SetFocusOnError="true"
  ValidationGroup="sub" style="padding-left:70px;"></asp:RequiredFieldValidator>
                   <section class="clear"></section>
         	        </li>
         	        <li>
                        <label>Subject :</label>
                  <asp:TextBox ID="txtParentSub" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtParentSub" SetFocusOnError="true"
  ValidationGroup="sub" style="padding-left:70px;"></asp:RequiredFieldValidator>
                   <section class="clear"></section>
                     </li>
                  <li>
                     <label>Message :</label>
                     <asp:TextBox ID="txtParentDesc" TextMode="MultiLine" runat="server"></asp:TextBox>
                      
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtParentDesc" SetFocusOnError="true"
  ValidationGroup="sub" style="padding-left:70px;"></asp:RequiredFieldValidator>
                     <section class="clear"></section>
                  </li>
             </ul>
              <section style="padding-right:10px;" class="save_bt_box_small">
              <asp:Button ID="btnParentSend" runat="server"  Text="Send"  ValidationGroup="sub"
                onclick="btnParentSend_Click"/>

            <%-- <input type="reset" value="Cancel">--%>
<asp:Button ID="btnParentCancel" runat="server" Text="Cancel" 
                onclick="btnParentCancel_Click"/>
             </section>
         </section>
         <section class="clear"></section>
     </section>
</section>
 <section class="tab_des_wrapp" id="sendstaf" runat="server" style="margin:9px 0px -4px 0px;">
		<section class="send_tech_wrapp">
     	<section class="send_tech_left">
         	<section class="sle_box"><asp:CheckBox ID="chkAllStaff" onclick="fnSelectStaffAll()" runat="server"></asp:CheckBox>Select All<section class="clear"></section></section>
             <section class="slec_group_box">
             	      <asp:DropDownList ID="ddlSelectStaff" runat="server" 
        AutoPostBack="True" 
        onselectedindexchanged="ddlSelectStaff_SelectedIndexChanged">
                          <asp:ListItem>Select Department</asp:ListItem>
                          <asp:ListItem>Transport</asp:ListItem>
                          <asp:ListItem>Vendor</asp:ListItem>
                          <asp:ListItem>Library</asp:ListItem>
                          <asp:ListItem>Account Manager</asp:ListItem>
    </asp:DropDownList>          	
             </section>
             <section class="sle_name_wrapp">
                <asp:ListView ID="lvStaffList" runat="server" ItemPlaceholderID="itemContainer" OnItemDataBound="lvStaffList_DataBound">
                   <LayoutTemplate>
                      <ul>
                          <asp:PlaceHolder ID="itemContainer" runat="server"></asp:PlaceHolder>
                      </ul>
                   </LayoutTemplate>
                   <ItemTemplate>   
             	     <dl>
             	      <section  id="StaffSection" runat="server"> 
                  <asp:CheckBox ID="chkStaffId" runat="server"/>
                     <asp:Label ID="lblChkStaffValue" runat="server" Text='<%#Eval("FD_LoginId") %>' Visible="false"></asp:Label>
                     <section class="img_box"><asp:ImageButton id="imgStaff" ImageUrl='<%#Bind("FD_Image") %>' runat="server" width="32" height="32"></asp:ImageButton></section>
                     <section class="nd_box">
                     	<b><a href="javascript:;"><asp:Label ID="lblStaffName" runat="server" Text='<%#Eval("UserName")%>'></asp:Label></a></b>
                         <section><%#Eval("FT_FacultyName")%></section>
                     </section>
                     <section class="clear"></section>
                     </section>
                 </dl>
                   </ItemTemplate>
                   <EmptyDataTemplate>
                   <asp:Label ID="Label1" runat="server" style="color:Red;" Text="No Record Exists."></asp:Label>
                   </EmptyDataTemplate>
               </asp:ListView>            	    
                </section>
                
            </section> <section class="add_bt_box">
            	 <asp:Button ID="btnSatffAdd"  runat="server" style="margin-top:13px;" Text="ADD TO LIST" onclick="btnSatffAdd_Click"/>
            </section>
           
            <section class="msg_send_box">
             <ul>
                  <%--<li>
         	         <section >
                        <section class="left_cretgrp">
                        <section class="margin3810">
                           <section class="clear"></section> 
                         </section>
                         <section class="clear"></section>
                        <section class="mainteacher_grp mainteacher_cretgrp margintopminus" runat="server" id="SectionLeftCrtGrp12">
                      <dl class="back_top_cret">
                     <dd class="col01">&nbsp;</dd>
                       <dd class="col02">Photo</dd>
                         <dd class="col03">Staff Name</dd>
                      
                      <section class="clear"></section>
                      </dl>
                      <section class="whitebody_cret" style="height:267px;" id="selectStaff" runat="server">
                      
                     </section>
                      
                      </section>
                         </section>
                           
                        </section>
                      
         	        </li>--%>
         	    <li>
                        <label>To :</label>
                  <asp:TextBox ID="txtToStaff" TextMode="MultiLine" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtToStaff" SetFocusOnError="true"
  ValidationGroup="sub" style="padding-left:70px;"></asp:RequiredFieldValidator>
                   <section class="clear"></section>
                     </li>
         	         <li>
                        <label>Subject :</label>
                  <asp:TextBox ID="txtStaffSub" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtStaffSub" SetFocusOnError="true"
  ValidationGroup="sub" style="padding-left:70px;"></asp:RequiredFieldValidator>
                   <section class="clear"></section>
                     </li>
                  <li>
                     <label>Message :</label>
                     <asp:TextBox ID="txtStaffDesc" TextMode="MultiLine" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtStaffDesc" SetFocusOnError="true"
  ValidationGroup="sub" style="padding-left:70px;"></asp:RequiredFieldValidator>
                     <section class="clear"></section>
                  </li>
             </ul>
                 <section style="padding-right:10px;" class="save_bt_box_small">
                  <asp:Button ID="btnStaffSend" runat="server" Text="Send" ValidationGroup="sub" 
        onclick="btnStaffSend_Click"/>
                <asp:Button ID="Button3" runat="server" OnClick="btnCancel_Click"  Text="Cancel"/>
                </section>
            </section>
            <section class="clear"></section>
        </section>
   </section>
   
   
    <section class="tab_des_wrapp" id="sendPrincipal" runat="server" style="margin:9px 0px -4px 0px;">
			<section class="compose_box">
		<ul>
    
        <li>	<label>Select User :</label>
      <asp:DropDownList ID="ddlPrincipal"  MaxLength="250" runat="server">
      </asp:DropDownList>
      </li>
      
      <li>	<label>Subject :</label>
      <asp:TextBox ID="txtPrincipalSubject"  MaxLength="250" runat="server"></asp:TextBox>
       <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtPrincipalSubject" SetFocusOnError="true"
  ValidationGroup="sub" style="padding-left:230px;"></asp:RequiredFieldValidator>
      </li>
      <li>
     	<label>Message :</label>
    <asp:TextBox ID="txtPrincipalMessage" TextMode="MultiLine" MaxLength="350" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtPrincipalMessage" SetFocusOnError="true"
  ValidationGroup="sub" style="padding-left:230px;"></asp:RequiredFieldValidator>
         <section class="clear"></section>
      </li>
 </ul>
 </section>
 <section style="padding-right:198px;" class="save_bt_box_small">
 <asp:Button ID="Button4" runat="server" Text="Send" OnClick=" btnPrincipalSend_Click" ValidationGroup="sub"></asp:Button>
 <asp:Button ID="Button7" runat="server" OnClick="btnCancel_Click"  Text="Cancel"/>
 </section>
   </section>
   
   
<asp:HiddenField ID="HFSeelctedID" runat="server" />
<asp:HiddenField ID="HFParentId" runat="server" />
<asp:HiddenField ID="HFStaffId" runat="server" />

    
    <asp:Panel ID="pnlPerson" runat="server" Style="display: none;" CssClass="modalPopup"
        Visible="false">
        <section style="float: right;">
            <asp:ImageButton ID="lnkClose" runat="server" OnClick="click_lnkClose" ImageUrl="~/img/pop_close_icon.png"
                Height="16px" Width="16px" />
            <%-- <asp:LinkButton ID="" runat="server">Close</asp:LinkButton>--%>
        </section>
        <br />
        <section class="news_title1">
            <b>Subject :</b> &nbsp;
            <asp:Label ID="lblTitle1" runat="server"> </asp:Label></section>
        <br />
        <article><b>Description :</b> &nbsp; <asp:Label  ID ="lblDesc1" runat ="server"> </asp:Label></article>
    </asp:Panel>
</asp:Content>
