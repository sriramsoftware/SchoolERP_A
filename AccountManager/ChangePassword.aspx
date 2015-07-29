<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_ChangePassword"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          <section class="achiv_toptitle">Change <span >Password</span> </section>
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
                        <section class="changepassword_box">
                          <dl>
                           <dt>Current Password</dt>
                           <dd>
                           <asp:TextBox ID="txtCurrentPassword" runat="server" CssClass="input" TextMode="Password"></asp:TextBox> 
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCurrentPassword" ForeColor="Red"
                Display="Dynamic" ErrorMessage="Required !" SetFocusOnError="True" ValidationGroup="password"></asp:RequiredFieldValidator>
                <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtCurrentPassword" ForeColor="Red"
                Display="Dynamic" ValidationGroup="password" ValidationExpression=".{6}.*" ErrorMessage="Enter minimum 6 characters !"></asp:RegularExpressionValidator>
                           </dd>
                           <section class="clear"></section>
                          </dl>
                           <dl>
                           <dt>New Password</dt>
                           <dd>
                           <asp:TextBox ID="txtNewPassword" runat="server" CssClass="input" TextMode="Password"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCurrentPassword" ForeColor="Red"
                Display="Dynamic" ErrorMessage="Required !" SetFocusOnError="True" ValidationGroup="password"></asp:RequiredFieldValidator>
                <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtNewPassword" ForeColor="Red"
                Display="Dynamic" ValidationGroup="password" ValidationExpression=".{6}.*" ErrorMessage="Enter minimum 6 characters !"></asp:RegularExpressionValidator>
                           </dd>
                           <section class="clear"></section>
                          </dl>
                           <dl>
                           <dt>Confirm Password</dt>
                           <dd>
                           <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="input" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtConfirmPassword" ForeColor="Red"
                Display="Dynamic" ErrorMessage="Required !" SetFocusOnError="True" ValidationGroup="password"></asp:RequiredFieldValidator>
                <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtConfirmPassword" ForeColor="Red"
                Display="Dynamic" ValidationGroup="password" ValidationExpression=".{6}.*" ErrorMessage="Enter minimum 6 characters !">
                </asp:RegularExpressionValidator>
                <br />
                   <asp:CompareValidator ID="txtPasswordConfirm_CompareValidator" runat="server" ControlToCompare="txtNewPassword" ForeColor="Red"
        ValidationGroup="password" ControlToValidate="txtConfirmPassword" Display="Dynamic"
        ErrorMessage="Please enter the same password as above"></asp:CompareValidator>
                           </dd>
                           <section class="clear"></section>
                          </dl>
                           <section class="save_bt_box">
                  <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" ValidationGroup="password" />
                  <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                </section>
                        </section>
                    </section>
</asp:Content>

