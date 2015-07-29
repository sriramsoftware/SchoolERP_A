<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="MyAccount.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_MyAccount" %>

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
                            	<li id="tc"><a class="active"  id ="aTeachersDetaitls" runat ="server"  href="TeacherSalaryDetails.aspx">Teachers Details</a></li>
                                <li id="td"><a  id ="aStaffDetails" runat ="server"  href="StaffSalaryDetails.aspx">Staff Details</a></li>
                                  <%--  <li id="ld"><a  id="aPrincipalDetails"  runat="server" href="PrincipalSalaryDetails.aspx">Principal Details</a></li>
                             <li id="ld"><a href="javascript:;">Nanny Details</a></li>
                                <li id="labo"><a href="javascript:;">School Gaurd</a></li>--%>
                                <section class="clear"></section>
                            </ul>
                         </section>   
                                  
                            <!-- Right Content Start -->
                            	<section class="tab_nav">
                      <ul class="ui-tabs-nav ui-helper-reset ui-helper-clearfix ui-widget-header ui-corner-all">
       <li class="ui-state-default ui-corner-top ui-tabs-selected ui-state-active"><a class="active" href="MyAccount.aspx">General Details</a></li>
             <li class="ui-state-default ui-corner-top"><a   href="ViewSalaryDetails.aspx">Salary Details</a></li>
              <%--<li class="ui-state-default ui-corner-top"><a href="ViewLeaveDetails.aspx">Leave Details</a></li>--%>
              <li class="ui-state-default ui-corner-top"><a href="AttachmentDetails.aspx">Attach Documents</a></li>
                                    <section class="clear"></section>
                                </ul>
                            </section>
                            	<section class="right_content tabsec_topsecn " style="width:690px!important;">
                                
                                <section class="personal_details_block">
                                    <section class="left lF">
                                    	<asp:Image ID ="imasdfdsg" runat ="server"  Width ="170px" Height ="170px" /> 
                                    </section>
                            <section class="right rF">	
                            <section>
                                 <section class="info"><span class="blu_txt"><asp:Label ID ="lblFullName" runat ="server" ></asp:Label> </span>
                                 <asp:Label  ID ="lblEduDetail" runat ="server" ></asp:Label>  </section>
                                 <section class="info"><strong>Address: </strong> <asp:Label  
                                 ID ="lblAddress" runat ="server" ></asp:Label></section>
                                 <section class="info" id ="totalexp" runat="server"><strong>Total Experience : </strong><asp:Label 
                                 ID ="lblexperience" runat ="server" ></asp:Label></section>
                                 </section>
                             <section class="pro_small_block lF">
                             	<dl>
                                	<dt>Mother Tongue</dt>
                                    <dd><asp:Label 
                                 ID ="lblmotherLong" runat ="server" ></asp:Label></dd>
                                    <section class="clear"></section>
                                </dl>
                                <dl>
                                	<dt>Birth Place</dt>
                                    <dd><asp:Label 
                                 ID ="lblbirthPlace" runat ="server" ></asp:Label></dd>
                                     <section class="clear"></section>
                                </dl>
                                <dl>
                                	<dt>Gender</dt>
                                    <dd><asp:Label 
                                 ID ="lblgender" runat ="server"></asp:Label></dd>
                                     <section class="clear"></section>
                                </dl>
                             </section>  
                             <section class="pro_small_block lF">
                             	<dl>
                                	<dt>Nationality</dt>
                                    <dd><asp:Label  ID ="lblnationality" runat ="server" ></asp:Label>
                                </dd>
                                    <section class="clear"></section>
                                </dl>
                                <dl>
                                	<dt>Caste</dt>
                                    <dd><asp:Label 
                                 ID ="lblcast" runat ="server" ></asp:Label></dd>
                                     <section class="clear"></section>
                                </dl>
                                <dl>
                                	<dt>Sub-Caste</dt>
                                    <dd><asp:Label 
                                 ID ="lblsubcast" runat ="server" ></asp:Label></dd>
                                     <section class="clear"></section>
                                </dl>
                             </section>
                             <section class="pro_small_block lF">
                             	<dl>
                                	<dt>Medical Problems</dt>
                                    <dd><asp:Label 
                                 ID ="lblmedicolprm" runat ="server" ></asp:Label></dd>
                                    <section class="clear"></section>
                                </dl>
                                <dl>
                                	<dt>Blood Group</dt>
                                    <dd><asp:Label 
                                 ID ="lblbloodgroup" runat ="server" ></asp:Label></dd>
                                     <section class="clear"></section>
                                </dl>
                                <%--<dl>
                                	<dt>Using Transport</dt>
                                    <dd><asp:Label 
                                 ID ="lblusingtransport" runat ="server" ></asp:Label></dd>
                                     <section class="clear"></section>
                                </dl>--%>
                             </section>  
                                 
                            </section>
                                    <section class="clear"></section>
                                </section>
                                 
                                 <section class="genral_wrapper" id ="general" runat="server">
                                 		<section class="font14 textbold yellowtext">General Information</section>
                                        
                                        <dl>
                                        	<dt>Standard I Teach</dt>
                                            <dd><asp:Label 
                                 ID ="lblstandard" runat ="server" ></asp:Label></dd>
                                            <section class="clear"></section>
                                        </dl>
                                        <dl>
                                        	<dt>Subject I Teach</dt>
                                            <dd><asp:Label 
                                 ID ="lblsubject" runat ="server" ></asp:Label></dd>
                                            <section class="clear"></section>
                                        </dl>
                                      
                                 </section>
                                 
                                 <section class="genral_wrapper">
                                 		<section class="font14 textbold yellowtext">Educational Details</section>
                                       
                                        <dl id ="dlfx" runat ="server"   >
                                        	<dt>Years of full-time classroom teaching experience:</dt>
                                            <dd> <asp:Label 
                                 ID ="lblexpyears" runat ="server" ></asp:Label> </dd>
                                            <section class="clear"></section>
                                        </dl>
                                        <dl>
                                        	<dt>Highest Degree Completed </dt>
                                            <dd> <asp:Label 
                                 ID ="lblhighestDegree" runat ="server" ></asp:Label></dd>
                                            <section class="clear"></section>
                                        </dl>
                                          <%--<dl>
                                        	<dt>Field of Study</dt>
                                            <dd><asp:Label 
                                 ID ="lblspeciolisation" runat ="server" ></asp:Label></dd>
                                            <section class="clear"></section>
                                        </dl>--%>
                                          <dl>
                                        	<dt>University</dt>
                                            <dd><asp:Label 
                                 ID ="lbluniversity" runat ="server" ></asp:Label></dd>
                                            <section class="clear"></section>
                                        </dl>
                                         <dl>
                                        	<dt>Completion Date of Highest Degree</dt>
                                            <dd><asp:Label 
                                 ID ="lblcomplicationDateofHigherDegree" runat ="server" ></asp:Label></dd>
                                            <section class="clear"></section>
                                        </dl>
                                 </section>
                                 
                         
                                 
                                </section>
                            <!-- Right Content End -->
</asp:Content>

