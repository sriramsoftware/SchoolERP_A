<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="AccountManagerDashboard.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_AccountManagerDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <link rel="stylesheet" type="text/css" href="../css/all_dashboard.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section class="all_dashright" style="margin-left:0px!important">

<section class="tech_nam_box">
                        	<h3>
                        	<section class="redtxt"><asp:Label ID ="lblteachername" runat ="server" > </asp:Label> </section>                          	
                        	 	
                        	    <section class="clear"></section>
                        	</h3>
                            <span ><asp:Label ID ="lblteacherQualification" runat ="server" ></asp:Label></span>
                            <%--<section class="exp_txt_box">Total Experience  <asp:Label ID ="lblexperience" runat ="server" Text="0" ></asp:Label> Years</section>--%>
                        </section>
                        <section class="cont_det_box">
                        	<dl>
                            	<dt>Address :</dt>
                                <dd> <asp:Label ID ="lbladdressNuber" runat ="server" ></asp:Label></dd>
                                <section class="clear"></section>
                            </dl>
                            <dl>
                            	<dt>Contact No : </dt>
                                <dd> <asp:Label ID ="lblcontactNumber" runat ="server" ></asp:Label></dd>
                                <section class="clear"></section>
                            </dl>
                            <dl>
                            	<dt>Email :</dt>
                                <dd> <asp:Label ID ="lblemailID" runat ="server" ></asp:Label></dd>
                                <section class="clear"></section>
                            </dl>
                        </section>                    	
                     <%--   <h4>Past  <span>Experience</span></h4>--%>
                        <section class="pe_box">                 
                         <b><asp:Literal ID ="lblschoolname" runat ="server" ></asp:Literal></b> <br />
                            <asp:Label ID ="lblpasttime" runat ="server" ></asp:Label>  <asp:Label ID ="lblpastexpyear" runat ="server" ></asp:Label> 
                        </section>
                      	<h1 class="big_border font26">Quick <span>Links</span></h1>
						<section class="quick_link_box">
                        	<dl>
                                <dd>
                                	<section class="icon_box mystud_icon sprite"><a href="StudentFeesPayment.aspx"></a></section>
                                    <a href="StudentFeesPayment.aspx">Student's fee and payment</a>
                                </dd>
                                <dd>
                                	<section class="icon_box faculty_icon sprite"><a href="TeacherSalaryDetails.aspx"></a></section>
                                    <a href="TeacherSalaryDetails.aspx">Teacher and staff salary</a>
                                </dd>
                                 <dd>
                                	<section class="elect_ico"><a href="ElectricityWaterSupply.aspx"></a></section>
                                    <a href="ElectricityWaterSupply.aspx">Electricity and Water Supply</a>
                                </dd>
                                <dd>
                               <section class="settings_ico"><a href="SchoolMaintance.aspx"></a></section>
                                    <a href="SchoolMaintance.aspx">School Maintenance</a>
                                </dd>
                                 <%--<dd>
                                	<section class="icon_box sal_icon sprite"><a href="OtherCharity.aspx"></a></section>
                                    <a href="OtherCharity.aspx">Other Charity</a>
                                </dd>--%>
                                  <dd>
                                    <section class="icon_box"><a href="MonthlyReport.aspx">
                                 <img src="../img/upload/Monthly-report1.png"  align="absmiddle"/></a>
                                    </section>
                                    <a href="MonthlyReport.aspx">Monthly Report</a>
                                  </dd>
                                  <dd>
                                    <section class="icon_box"><a href="RoyaltiDetails.aspx"><img src="../img/upload/royalty1.png"  align="absmiddle"/></a></section>
                                    <a href="RoyaltiDetails.aspx">Royalty</a>
                                  </dd>
                                <%--   <dd>
                                    <section class="icon_box"><a href="RentAccountDetails.aspx"><img src="../img/upload/Rent-AC1.png"  align="absmiddle"/></a></section>
                                    <a href="RentAccountDetails.aspx">Rent A/C</a>
                                  </dd>--%>
                                    <dd>
                                	<section class="icon_box sound_icon sprite"><a href="Announcement.aspx"></a></section>
                                    <a href="Announcement.aspx">Special Announcements</a>
                                </dd>
                                  <section class="clear"></section>
                            </dl>
						</section>
                    </section>
</asp:Content>

