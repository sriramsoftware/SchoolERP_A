<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true"
    CodeFile="holidaycalender.aspx.cs" Inherits="Teacher_holidaycalender" Title=":: schoolerpsoft ::" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="achive_right_main">
            			 <section class="top_row">
                         <section class="achiv_toptitle">Holiday Calender for   <span>the year <asp:Label  ID ="lbllyear" runat ="server"></asp:Label></span></section>
                          <section class="top_row_back"><a href="javascript:history.go(-1)" title="Back">BACK</a></section>

                         <%--   <section class="dow_icon sprite rF"><a href="#url"></a></section> 
                            <section class="print_icon sprite rF"><a href="#url"></a></section>--%> 
                          <section class="clear"></section>
                         </section>
                		
                            <asp:ListView ID="listHolidaycalender" runat="server" >
                            <LayoutTemplate>
                               <table id="Table1" class="holiday" runat="server">
                            <thead>
                                	<tr>
                                    	<th>Date</th>
                                        <th>Day</th>
                                        <th>Holiday Name</th>
                                        <th>Holiday Type</th>
                                    </tr>
            		     </thead>
                    <tr id="itemPlaceholder" runat="server" ></tr> 
                </table>
           </LayoutTemplate>
            
                        
                   <ItemTemplate>
                          
                       
                          <tr>
                          
                                   <td class="bg_white">
                                   <asp:Label ID ="lbldate" runat ="server"  Text ='<%#Eval("Daydate")%>'></asp:Label>
                                 <%--  <%#DataBinder.Eval(Container.DataItem, "DBDate","{0:D}")%>--%>
                                      <%-- <asp:Label ID ="lbldate" runat ="server"  Text ='<%#Eval("HC_date","{0:D}")%>'></asp:Label> --%>   </td>
                                        <td class="bg_white"> <asp:Label ID ="Label1" runat ="server"  Text ='<%#Eval("NameOfDay")%>'></asp:Label></td>
                                        <td class="bg_white"> <asp:Label ID ="Label2" runat ="server"  Text ='<%#Eval("HC_Name")%>'></asp:Label></td>
                                        <td class="bg_white"> <asp:Label ID ="Label3" runat ="server"  Text ='<%#Eval("HC_Type")%>'></asp:Label></td>
                             </tr>
                                 
           </ItemTemplate>
                            
                        </asp:ListView>
                    </section>
</asp:Content>
