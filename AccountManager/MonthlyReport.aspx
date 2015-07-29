<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="MonthlyReport.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_MonthlyReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <section class="top_row bottom_bor">
                         <section class="achiv_toptitle">Monthly<span> Report</span></section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx">BACK</a></section>
                          <section class="clear"></section>
                         </section>                                 
              <!-- Right Content Start -->                            
                            <section class="top_row">
                   		 <asp:Button ID="btnSort" runat="server" class="bt_sort" 
        Text="Sort" onclick="btnSort_Click"></asp:Button>
                   	    <asp:DropDownList ID="ddlYear" runat="server" class="select_fy">
                                                    <asp:ListItem Text="Select Year" Value="-1"></asp:ListItem>
                                                   
                                                    <asp:ListItem Text="2013" Value="2013"></asp:ListItem>
                                                    <asp:ListItem Text="2014" Value="2014"></asp:ListItem>
                                                    <asp:ListItem Text="2015" Value="2015"></asp:ListItem>
                                                    <asp:ListItem Text="2016" Value="2016"></asp:ListItem>
                                                    <asp:ListItem Text="2017" Value="2017"></asp:ListItem>
                                                    <asp:ListItem Text="2018" Value="2018"></asp:ListItem>
                                                    <asp:ListItem Text="2019" Value="2019"></asp:ListItem>
                                                    <asp:ListItem Text="2020" Value="2020"></asp:ListItem>
                                                    <asp:ListItem Text="2021" Value="2021"></asp:ListItem>
                            	                   </asp:DropDownList>
                                              <asp:DropDownList ID="ddlMonth" runat="server" class="select_fy">
                                                    <asp:ListItem Text="Select Month" Value="-1"></asp:ListItem>
                                                    <asp:ListItem Text="January" Value="January"></asp:ListItem>
                                                    <asp:ListItem Text="February" Value="February"></asp:ListItem>
                                                    <asp:ListItem Text="March" Value="March"></asp:ListItem>
                                                     <asp:ListItem Text="April" Value="April"></asp:ListItem>
                                                    <asp:ListItem Text="May" Value="May"></asp:ListItem>
                                                    <asp:ListItem Text="June" Value="June"></asp:ListItem>
                                                    <asp:ListItem Text="July" Value="July"></asp:ListItem>
                                                    <asp:ListItem Text="August" Value="August"></asp:ListItem>
                                                    <asp:ListItem Text="September" Value="September"></asp:ListItem>
                                                    <asp:ListItem Text="October" Value="October"></asp:ListItem>
                                                    <asp:ListItem Text="November" Value="November"></asp:ListItem>
                                                    <asp:ListItem Text="December" Value="December"></asp:ListItem>
                            	                   </asp:DropDownList>
                           <section class="clear"></section>
                        </section>                            
                           <section class="tab_nav">
                                 <ul class="ui-tabs-nav ui-helper-reset ui-helper-clearfix ui-widget-header ui-corner-all">
                                   <li class="ui-state-default ui-corner-top ui-tabs-selected ui-state-active"><a href="#" class="active">Expenditure</a></li>
                                   <%--<li class="ui-state-default ui-corner-top"><a href="#">Income</a></li>--%>
                                   <section class="clear"></section>
                                 </ul>
                            </section>
                            <section class="right_content tabsec_topsecn " style="width:690px;">
                            <table class="billing_invoic" align="center">
                               	  <thead>
                                   	   <tr>
                                       	   <th width="20%">Sr No.</th>
                                           <th width="51%">Amount Spent On</th>
                                           <th width="29%">Status</th>
                                       </tr>
                                   </thead>
                                   <tfoot>
                                   <tr>
                                         <td>3.</td>
                                         <td>School Maintenance</td>
                                         <td>Rs. <asp:Label ID="lblSchoolMaintance" runat="server" Text="0"></asp:Label></td>
                                   </tr>                                 
                                   <tr>
                                     <td>4.</td>
                                     <td>Transport Managment</td>
                                     <td>Rs.<asp:Label ID="lblTransportManagement" runat="server" Text="0"></asp:Label></td>
                                   </tr>                                 
                                   <tr>
                                     <td>5.</td>
                                     <td>Vendor Managment</td>
                                     <td>Rs.<asp:Label ID="lblVendorManagement" runat="server" Text="0"></asp:Label></td>
                                   </tr>                                 
                                   <tr>
                                     <td>&nbsp;</td>
                                     <td><strong>Total</strong></td>
                                     <td><strong>Rs. <asp:Label ID="lblTotal" runat="server" Text="0"></asp:Label></strong></td>
                                   </tr>
                                   </tfoot>
                                   <tbody>
                                   	   <tr>
                                           <td>1.</td>
                                           <td>Teacher and Staff Salary</td>
                                           <td>Rs.<asp:Label ID="lblSalaryAmt" runat="server" Text="0"></asp:Label></td>
                                       </tr>
                                       <tr>
                                           <td>2.</td>
                                           <td>Electricity and Water Supply</td>
                                           <td>Rs. <asp:Label ID="lblEleAndWaterSupply" runat="server" Text="0"></asp:Label></td>
                                       </tr>                                       
                                   </tbody>
                             </table>
                     </section>                            	
</asp:Content>

