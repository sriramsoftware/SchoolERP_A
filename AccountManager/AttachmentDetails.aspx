<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="AttachmentDetails.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_AttachmentDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <section class="top_row bottom_bor">
                          <section class="achiv_toptitle">Teacher <span>and staff salary</span></section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx">BACK</a></section>
                          <section class="clear"></section>
                         </section>
                         
             		<section class="accountant_nav_wrap" style="width:373px;">
                         	<ul>
                                <li id="tc"><a class="active" id="aTeachersDetaitls" runat ="server"   href="TeacherSalaryDetails.aspx">Teachers Details</a></li>
                                <li id="td"><a  id="aStaffDetails" runat ="server"  href="StaffSalaryDetails.aspx">Staff Details</a></li>
                                <%-- <li id="ld"><a  id="aPrincipalDetails"  runat="server" href="PrincipalSalaryDetails.aspx">Principal Details</a></li>
                               <li id="ld"><a href="javascript:;">Nanny Details</a></li>
                                <li id="labo"><a href="javascript:;">School Gaurd</a></li>--%>
                                <section class="clear"></section>
                            </ul>
                         </section>   
                                  
                            <!-- Right Content Start -->
                            <section class="tab_nav">
                                <ul class="ui-tabs-nav ui-helper-reset ui-helper-clearfix ui-widget-header ui-corner-all">
                                     <li class="ui-state-default ui-corner-top ">
                                     <a href="MyAccount.aspx">General Details</a></    li>
                                     <li class="ui-state-default ui-corner-top">
                                     <a   href="ViewSalaryDetails.aspx">Salary Details</a></li>
                                    <%-- <li class="ui-state-default ui-corner-top">
                                     <a href="ViewLeaveDetails.aspx">Leave Details</a></li>--%>
                                     <li class="ui-state-default ui-corner-top ui-tabs-selected ui-state-active">
                                     <a class="active" href="AttachmentDetails.aspx">Attach Documents</a></li>
                                   <section class="clear"></section>
                                </ul>
                            </section>
          	<section class="right_content tabsec_topsecn " style="width:690px!important;">
          	
          	
          	<section class="genral_wrapper">
                                 		<section class="font14 textbold yellowtext">Attached Documents</section>
                                        <dl>
                                        	<dt>Age Proof</dt>
                                            <dd><asp:HyperLink ID ="hyperAge" runat ="server"  Target ="_blank"  ></asp:HyperLink></dd>
                                            <section class="clear"></section>
                                        </dl>
                                          <dl>
                                        	<dt>Passport Size Photos</dt>
                                            <dd><asp:HyperLink ID ="hyperPassphoto" runat ="server"   Target ="_blank"   ></asp:HyperLink></dd>
                                            <section class="clear"></section>
                                        </dl>
                                          <dl>
                                        	<dt>Original School leaving  Certificate</dt>
                                            <dd><asp:HyperLink ID ="hyperOleavingSchoolSertificate" runat ="server"  Target ="_blank"   ></asp:HyperLink></dd>
                                            <section class="clear"></section>
                                        </dl>
                                        <%-- <dl>
                                        	<dt>Copy Of Last Progress report card</dt>
                                            <dd><asp:HyperLink ID ="hyperProgressReport" runat ="server"  ></asp:HyperLink></dd>
                                            <section class="clear"></section>
                                        </dl>--%>
                                 </section>
          	
          	
              <%-- <section class="uploadconatin" style="margin-top:50px;">
                      <section class="newform marginbot_10">
                        <span class="margin_hor"><select class="select1" name=""><option>Select Document to be attached</option></select></span>
                        <span><input type="file" name=""></span>
                      </section>
                      <section style="padding-right:80px;" class="textright marginbot_15"><a href="#url">+ Add more attachments</a></section>
                      <section class="marginbot_10">
                        <span class="rF margin_hor"><input type="submit" class="yellow_btn btnpad" value="Cancel"></span>
                        <span class="rF"><input type="submit" class="gry_btn btnpad" value="upload"></span>
                        <section class="clear"></section>
                      </section>
                    </section>       --%>                          
               </section>
       
</asp:Content>

