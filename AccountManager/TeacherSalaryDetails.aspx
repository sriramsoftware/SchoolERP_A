<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master"
    AutoEventWireup="true" CodeFile="TeacherSalaryDetails.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_TeacherSalaryDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<%--
<asp:HyperLink ID ="asdfds" CssClass ="sumit"--%>
    <section class="top_row bottom_bor">
                         <section class="achiv_toptitle">Salary <span>Details</span></section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx">BACK</a></section>
                          <section class="clear"></section>
                         </section>
    <section class="accountant_nav_wrap" style="width:373px;">
                         	<ul>
                            	<li id="tc"><a class="active" href="TeacherSalaryDetails.aspx">Teachers Details</a></li>
                                <li id="td"><a href="StaffSalaryDetails.aspx">Staff Details</a></li>
                               <%--  <li id="ld"><a href="PrincipalSalaryDetails.aspx">Principal Details</a></li>
                               <li id="ld"><a href="javascript:;">Staff Details</a></li>
                                <li id="labo"><a href="javascript:;">School Gaurd</a></li>--%>
                                <section class="clear"></section>
                            </ul>
                         </section>
    <section class="top_row">

                <section class="marg20">
                
                                  <asp:Button ID ="btnsort" runat ="server"  
                                     Text ="Sort"  CssClass ="yellow_btn btnpad" onclick="btnsort_Click"/>
                                  <%--<asp:textbox runat="server" ID="txtEmpid" placeholder="EMP ID" />--%>
                                   <asp:textbox runat="server" ID="txtName" placeholder="Enter Name" />
                                  <%--<asp:DropDownList ID ="ddltype"  runat ="server"  AutoPostBack="true"  
        CssClass ="sortby" onselectedindexchanged="ddltype_SelectedIndexChanged">
                                  </asp:DropDownList>--%>
                                 
                                 
                                  <section class="clear"></section>
                 </section>  
                   
                   <section>
                   
                   
                   <asp:ListView  ID ="ListTeacher" runat ="server">
                   
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
                                	<b><a> <asp:LinkButton ID="lbtnFacultyName" runat="server" Text='<%#Bind("UserName") %>'></asp:LinkButton></a></b><br />
                                    <b><asp:Label ID="lblFDSpecificExpertise" runat="server" Text='<%#Bind("FD_SpecificExpertise") %>'></asp:Label> </b>
                                    <article><asp:Label ID="lblDegree" runat="server" Text='<%#Bind("FD_HighestDegreeCompletd") %>'></asp:Label>-
                                    <asp:Label ID="lblSpecialization" runat="server" Text='<%#Bind("FD_SpecificExpertise") %>'></asp:Label> (<asp:Label ID="lblCompleteYear" runat="server" Text='<%#Bind("FD_CompletionDate") %>'></asp:Label>)</article>
                                    <article><b>Address :</b><asp:Label ID ="lblAddress" runat ="server"  Text='<%#Bind("FacultyPerAdd") %>'></asp:Label> &nbsp; <asp:Label ID ="lblCity" runat ="server"  Text='<%#Bind("FacultyCity") %>'></asp:Label>&nbsp;   <asp:Label ID ="lblState" runat ="server" Text='<%#Bind("FacultyState") %>' ></asp:Label> &nbsp;<asp:Label ID ="lblCountry" runat ="server"  Text='<%#Bind("FacultyCountry") %>'></asp:Label>
                                    </article>
                                </section>
                                <section class="tech_cont_detail">
                                    <section class="phone_icon"><asp:Label runat="server" id="lblContactNo" Text='<%#Bind("AD_MobileNo") %>'></asp:Label></section>
                                    <section class="send_msg"><a><asp:Label runat="server" id="lblEmailId" Text='<%#Bind("AD_EmailId") %>'></asp:Label></a></section>
                                </section>
                           
                             <section class="view_pay_box rF">
                            
                            <asp:HyperLink ID ="hyper" runat ="server" NavigateUrl='<%# String.Format("ViewSalaryDetails.aspx?LoginId={0}&FacultyType={1}&type=Teacher", Eval("FD_LoginId"), Eval("FD_FacultyId"))%>'  Text ="view Salary details"  CssClass ="yellow_btnSalaryDetails" > </asp:HyperLink>
							</section>
                            </section>
                    
                    </ItemTemplate>
                     <EmptyDataTemplate>
                            <asp:Label ID="Label242sf" Style="font-weight: bold; font-size: 13px; color: Red;"
                                runat="server" Text="No Record Found!"></asp:Label>
                        </EmptyDataTemplate>
                   </asp:ListView>
                        </section>                       	  
                </section>
              
</asp:Content>
