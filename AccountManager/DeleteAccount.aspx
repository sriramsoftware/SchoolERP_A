<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="DeleteAccount.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_DeleteAccount"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section class="dash_mid_wrapp">
                    	<h4>Delete<span>  Account</span></h4>
                        <section class="deleteaccount">                       
                        <h2>This action is Irreversible.</h2>
                        <section class="save_bt_box">
                           <%-- <input type="submit" value="Delete Account">
                            <input type="reset" value="Cancel">--%>
                            <asp:Button ID ="BtnSave" runat ="server"  
        Text ="Delete Account" onclick="BtnSave_Click"  OnClientClick="javascript:return confirm('Are You Sure To delete Account?');" />
                             <asp:Button ID ="btncancel" runat ="server"  
        Text ="Cancel" onclick="btncancel_Click" />
                        </section>
                       </section>
                    </section>
</asp:Content>

