<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="StaffSalaryDetails.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_StaffDetails"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section class="top_row bottom_bor">
                          <section class="achiv_toptitle">Teacher<span>and staff salary</span></section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx">BACK</a></section>
                          <section class="clear"></section>
                         </section>
                         
             		<section class="accountant_nav_wrap"  style="width:373px;">
                         	<ul>
                                <li id="tc"><a  href="TeacherSalaryDetails.aspx">Teachers Details</a></li>
                                <li id="td"><a  class="active" href="StaffSalaryDetails.aspx">Staff Details</a></li>
                                <%-- <li id="ld"><a  href="PrincipalSalaryDetails.aspx">Principal Details</a></li>
                               <li id="ld"><a href="javascript:;">Nanny Details</a></li>
                                <li id="labo"><a href="javascript:;">School Gaurd</a></li>--%>
                                <section class="clear"></section>
                            </ul>
                         </section>   
                                  
                            <!-- Right Content Start -->
                            <section class="tab_nav" style="margin: 9px 0px 8px 0px;">
                                <ul class="ui-tabs-nav ui-helper-reset ui-helper-clearfix ui-widget-header ui-corner-all">
                                     <li class="ui-state-default ui-corner-top ">
                                     <a   runat ="server" onserverclick ="Transportation_Click" id ="aTransportation">Transportation</a></li>
                                     <li class="ui-state-default ui-corner-top">
                                     <a   runat ="server" onserverclick ="Vendor_Click" id ="aVendor">Vendor</a></li>
                                     <li class="ui-state-default ui-corner-top">
                                     <a  runat ="server" onserverclick ="Librarian_Click" id ="aLibrarian">Librarian</a></li>
                                     <li class="ui-state-default ui-corner-top ">
                                     <a  runat ="server" onserverclick ="Accountant_Click" id ="aAccountant"  >Accountant</a></li>
                                     <li class="ui-state-default ui-corner-top">
                                     <a  runat ="server" onserverclick ="Management_Click" id ="aManagement">Principal</a></li>
                                   <section class="clear"></section>
                                </ul>
                            </section>
                            <section class="top_row">
                 	<section >
          	         		
                  <asp:ListView  ID ="ListStaff" runat ="server" 
        onitemdatabound="ListStaff_ItemDataBound" >
                   
                   <LayoutTemplate >
                   
                   <asp:PlaceHolder ID ="itemPlaceHolder" runat ="server" >
                   
                   </asp:PlaceHolder>
                   </LayoutTemplate>
                    
                    <ItemTemplate >
                    <section class="graybg_childbox">
                            	<section class="tech_img_box">
                            <asp:Image ID ="image1" runat ="server"  ImageUrl ='<%#Eval("FD_Image") %>' width="58" height="58" />
                   
                  
                            	
                            	</section>
                                <section class="tech_det_box">
                                	<b><a > <asp:LinkButton ID="lbtnFacultyName" runat="server" Text='<%#Bind("UserName") %>'></asp:LinkButton></a></b><br />
                                  
                                    <article><asp:Label ID="lblDegree" runat="server" Text='<%#Bind("HighestDegreeCompletd") %>'></asp:Label>
                                    <asp:Label ID="lblCompleteYear" runat="server" Text='<%#Bind("CompletionDate") %>'></asp:Label></article>
                                    <article><b>Address :</b><asp:Label ID ="lblAddress" runat ="server"  Text='<%#Bind("FacultyPerAdd") %>'></asp:Label> &nbsp; <asp:Label ID ="lblCity" runat ="server"  Text='<%#Bind("FacultyCity") %>'></asp:Label>&nbsp;   <asp:Label ID ="lblState" runat ="server" Text='<%#Bind("FacultyState") %>' ></asp:Label> &nbsp;<asp:Label ID ="lblCountry" runat ="server"  Text='<%#Bind("FacultyCountry") %>'></asp:Label>
                                    </article>
                                </section>
                                <section class="tech_cont_detail">
                                    <section class="phone_icon"><asp:Label runat="server" id="lblContactNo" Text='<%#Bind("AD_MobileNo") %>'></asp:Label></section>
                                    <section class="send_msg"><asp:Label runat="server" id="lblEmailId" Text='<%#Bind("AD_EmailId") %>'></asp:Label></section>
                                </section>
                            	
                            <section class="view_pay_box rF" style="margin: 83px -251px 0;">
                            <asp:HyperLink ID ="hyper" runat ="server" NavigateUrl='<%# String.Format("ViewSalaryDetails.aspx?LoginId={0}&FacultyType={1}&type=Staff", Eval("FD_LoginId"), Eval("FD_FacultyId"))%>'  Text ="view Salary details" CssClass ="yellow_btnSalaryDetails" > </asp:HyperLink>
 <%--<asp:HyperLink ID ="hyper" runat ="server"   NavigateUrl='<%# Eval("FD_LoginId","ViewSalaryDetails.aspx?LoginId={0}&type=Staff") %>' Text ="view Salary details"  ></asp:HyperLink>--%>


 <%--  NavigateUrl ='<% String.Formate(ViewSalaryDetails.aspx?ID=Eval("FD_LoginId")) %>'></asp:HyperLink>
                           <a href="ViewSalaryDetails.aspx">view Salary details</a>--%>
                           <section class="clear"></section>
							</section>
                            </section>
                    
                    </ItemTemplate>
                   </asp:ListView>               		
                                  
                                 </section>
                                 
          	
          	
                     
               </section>
       
<asp:HiddenField  ID ="HiddenID" runat ="server" />
</asp:Content>

