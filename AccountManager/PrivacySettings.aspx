<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="PrivacySettings.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_PrivacySettings"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <section class="achiv_toptitle">Privacy <span >Setting</span> </section>
    <section class="top_row_back"><a href="javascript:history.go(-1)" title="Back">BACK</a></section>
    <section class="clear"></section>
    <section class="top_row">
                          <div id="dvMsg"  runat="server" visible="false" style="width:-2px;">
                           <asp:Label ID="lblMessage" runat="server"></asp:Label>
                        <div class="clear">
                     </div>
               </div>
                         </section>
    <section class="clear"></section>
    <section class="dash_mid_wrapp">
                        <section class="privacyseeting_box">
                          <dl>
                           <dt><b>Hide Location Details From Other Users</b></dt>
                           <dd>
                            <span><asp:RadioButton ID="rdbLocationOne" runat="server" GroupName="Loc" Text="Yes"  /></span>
                            <span><asp:RadioButton ID="rdbLocationTwo" runat="server" GroupName="Loc" Text="No" /></span>
                            
                            <section class="clear"></section>
                           </dd>
                          </dl>
                           <dl>
                           <dt><b>Display Profile Picture</b></dt>
                           <dd>
                             <span><asp:RadioButton ID="rdbPhotoOne" runat="server" GroupName="Img" Text="Yes" /></span>
                            <span><asp:RadioButton ID="rdbPhotoTwo" runat="server" GroupName="Img" Text="No" /> </span>
                            <section class="clear"></section>
                           </dd>
                          </dl>
                           <dl>
                           <dt><b>Display My Education Details</b></dt>
                           <dd>
                             <span><asp:RadioButton ID="rdbEducatioOne" runat="server" GroupName="Edu" Text="Yes" /></span>
                            <span><asp:RadioButton ID="rdbEducatioTwo" runat="server" GroupName="Edu" Text="No" /></span>
                            <section class="clear"></section>
                           </dd>
                          </dl>
                           <dl>
                           <dt><b>Hide My Contact Details From Other Users</b></dt>
                           <dd>
                             <span><asp:RadioButton ID="rdbContactOne" runat="server" GroupName="Contact" Text="Yes" /></span>
                            <span><asp:RadioButton ID="rdbContactTwo" runat="server" GroupName="Contact" Text="No" /></span>
                            <section class="clear"></section>
                           </dd>
                          </dl>
                         <section class="save_bt_box">
                <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" ValidationGroup="password" />
                  <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                </section>
                        </section>
                    </section>
</asp:Content>

