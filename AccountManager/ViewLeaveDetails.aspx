<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="ViewLeaveDetails.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_ViewLeaveDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="top_row bottom_bor">
                          <section class="achiv_toptitle">Teacher <span>and staff salary</span></section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx">BACK</a></section>
                          <section class="clear"></section>
                         </section>
                         
              <section class="top_row bottom_bor">             
                           
    <div id="dvMsg" runat="server" visible="false">
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </div>
     <section class="clear"></section>
                         </section>
             		<section class="accountant_nav_wrap">
                         	<ul>
                                <li id="tc"><a id ="aTeachersDetaitls" runat ="server" class="active" href="TeacherSalaryDetails.aspx">Teachers Detaitls</a></li>
                                <li id="td"><a  id ="aStaffDetails" runat ="server"  href="StaffSalaryDetails.aspx">Staff Details</a></li>
                                <li id="ld"><a href="javascript:;">Nanny Details</a></li>
                                <li id="labo"><a href="javascript:;">School Gaurd</a></li>
                                <section class="clear"></section>
                            </ul>
                         </section>   
                                  
                            <!-- Right Content Start -->
                            	<section class="tab_nav">
                      <ul class="ui-tabs-nav ui-helper-reset ui-helper-clearfix ui-widget-header ui-corner-all">
      <li class="ui-state-default ui-corner-top "><a href="MyAccount.aspx">General Details</a></li>
             <li class="ui-state-default ui-corner-top"><a   href="ViewSalaryDetails.aspx">Salary Details</a></li>
              <li class="ui-state-default ui-corner-top ui-tabs-selected ui-state-active"><a class="active" href="ViewLeaveDetails.aspx">Leave Details</a></li>
              <li class="ui-state-default ui-corner-top"><a href="AttachmentDetails.aspx">Attach Documents</a></li>
                                    <section class="clear"></section>
                                </ul>
                            </section>
                            	<section class="right_content tabsec_topsecn " style="width:690px!important;">
                                 <section class="textbold marginbot_10"><asp:CheckBox ID="chkCustomizedSettings" runat="server" Text="Customized Leave Settings"></asp:CheckBox></section>
                                 <section class="marginbot_10"><asp:RadioButton ID="rbtnGeneral" runat="server" Text="General"></asp:RadioButton></section>
                                 <section>
                                 <section class="viewform formpartion margin_none newform lF">
                                  <dl>
                                   <dt>Casual Leave (CL) : <asp:CheckBox ID="chkCF" runat="server" Text="CF"></asp:CheckBox>&nbsp;</dt>
                                   <dd><asp:TextBox ID="txtCLLeave" runat="server" class="input2" Text ="0"></asp:TextBox></dd>
                                   <section class="clear"></section>
                                  </dl>
                                   <dl>
                                   <dt>Paid Leave (PL) :</dt>
                                   <dd><asp:TextBox ID="txtPLLeave" runat="server" class="input2" Text ="0" ></asp:TextBox></dd>
                                   <section class="clear"></section>
                                  </dl>
                                   <dl>
                                   <dt>Sick Leave (SL) :</dt>
                                   <dd><asp:TextBox ID="txtSLLeave" runat="server" class="input2" Text ="0"></asp:TextBox></dd>
                                   <section class="clear"></section>
                                  </dl>
                                 </section>
                                 <section class="viewform formpartion margin_none newform rF">
                                 
                                   <dl>
                                   <dt>Earned Leave (EL):</dt>
                                   <dd><asp:TextBox ID="txtELLeave" runat="server" class="input2" Text ="0"></asp:TextBox></dd>
                                   <section class="clear"></section>
                                  </dl>
                                   <dl>
                                   <dt>Other Leave (OL):</dt>
                                   <dd><asp:TextBox ID="txtOLLeave" runat="server" class="input2" Text ="0"></asp:TextBox></dd>
                                   <section class="clear"></section>
                                  </dl>
                                 </section>
                                 <section class="clear"></section>
                                 </section>
                                 
                                 <section class="marginbot_10"><asp:CheckBox ID="chkAdvance" runat="server" Text="Advance"></asp:CheckBox></section>
                                 
                                 <section class="calenderbox">
                               <%--  <section class="rF"><select name="" class="selectbox"></select></section>--%>
                                 <section class="clear"></section>
                                 <section>
                                  <dl>
                                   <dt>Month</dt>
                                   <dt>Jan</dt>
                                   <dt>Feb</dt>
                                   <dt>Mar</dt>
                                   <dt>Apr</dt>
                                   <dt>May</dt>
                                   <dt>June</dt>
                                   <dt>July</dt>
                                   <dt>Aug</dt>
                                   <dt>Sep</dt>
                                   <dt>Oct</dt>
                                   <dt>Nov</dt>
                                   <dt>Dec</dt>
                                   <section class="clear"></section>
                                  </dl>
                                  <dl>
                                   <dd>CL</dd>
                                   <dd><asp:TextBox ID="txtCLJan" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtCLFeb" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtCLMar" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtCLApr" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtCLMay" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtCLJun" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtCLJul" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtCLAug" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtCLSep" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtCLOct" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtCLNov" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtCLDec" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <section class="clear"></section>
                                  </dl>
                                  <dl>
                                   <dd>PL</dd>
                                   <dd><asp:TextBox ID="txtPLJan" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtPLFeb" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtPLMar" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtPLApr" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtPLMay" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtPLJun" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtPLJul" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtPLAug" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtPLSep" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtPLOct" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtPLNov" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtPLDec" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <section class="clear"></section>
                                  </dl>
                                  <dl>
                                   <dd>SL</dd>
                                   <dd><asp:TextBox ID="txtSLJan" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtSLFeb" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtSLMar" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtSLApr" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtSLMay" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtSLJun" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtSLJul" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtSLAug" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtSLSep" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtSLOct" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtSLNov" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtSLDec" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <section class="clear"></section>
                                  </dl>
                                  <dl>
                                   <dd>EL</dd>
                                   <dd><asp:TextBox ID="txtELJan" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtELFeb" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtELMar" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtELApr" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtELMay" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtELJun" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtELJul" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtELAug" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtELSep" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtELOct" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtELNov" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <dd><asp:TextBox ID="txtELDec" runat="server" class="calinput" Text ="0"></asp:TextBox></dd>
                                   <section class="clear"></section>
                                  </dl>
                                 </section>
                                 </section>
                                 
                                 <section>
                                 <p class="textbold">Special Case</p>
                                 <section class="viewform formpartion margin_none newform lF">                                 
                                   <dl>
                                   <dt>Marital Leave :</dt>
                                   <dd><asp:TextBox ID="txtMaritalLeave" runat="server" class="input2" Text ="0"></asp:TextBox></dd>
                                   <section class="clear"></section>
                                  </dl>
                                 </section>
                                 <section class="viewform formpartion margin_none newform rF">
                                 <dl>
                                   <dt>Maternity Leave :</dt>
                                   <dd><asp:TextBox ID="txtMaternityLeave" runat="server" class="input2" Text ="0"></asp:TextBox></dd>
                                   <section class="clear"></section>
                                  </dl>
                                 </section>
                                 <section class="clear"></section>
                                 </section>
                                 
                                 <asp:Button ID ="btnsave" runat ="server"   CssClass ="yellow_btn btnpad"
    Text ="Save" onclick="btnsave_Click"/>
                                </section>
                            <!-- Right Content End -->
                            <asp:HiddenField ID ="hiddLeaveID" runat ="server" />
                            <asp:HiddenField ID ="hiddenClID" runat ="server" />
                             <asp:HiddenField ID ="hiddPLID" runat ="server" />
                              <asp:HiddenField ID ="hiddSLID" runat ="server" />
                              <asp:HiddenField ID ="hiddELID" runat ="server" />
</asp:Content>

