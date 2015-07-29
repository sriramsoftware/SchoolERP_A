<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="ChangePhoto.aspx.cs" Inherits="Principal_ChangePhoto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section class="top_row">
                         <section class="achiv_toptitle">Change <span>Photo</span></section>
                          <section class="top_row_back"><a href="javascript:history.go(-1)" title="Back">BACK</a></section>
                          
                             
                       <section class="clear"></section>

</section>

<section class="top_row">
<section id="dvMsg"  runat="server">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <section class="clear">
            </section>
          
</section>
<section class="clear"></section>

</section>
                         
                         
                          <fieldset style="padding: 20px 100px 10px;">
        <section class="student_img_box lF"><asp:Image ID ="image1" runat ="server"  width="94" height="94" /></section>
        <section class="lF" style="margin: 40px 0px 0px 20px;">
                           <asp:FileUpload id="FileUpload1" runat="server" />
                           <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FileUpload1"
                                Display="Dynamic" ErrorMessage="Required !" SetFocusOnError="True" ValidationGroup="Photo"></asp:RequiredFieldValidator>
                            </section>
    </fieldset>
    <section class="save_bt_box">
                <asp:Button ID="btnSubmit" runat="server"  CssClass="reset" Text="Submit" OnClick="btnSubmit_Click" ValidationGroup="Photo" />  
                <asp:Button ID="btnCancel" runat="server"  CssClass="reset" Text="Cancel" OnClick="btnCancel_Click" />  
                </section>
                         
</asp:Content>

