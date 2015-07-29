<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true"
    CodeFile="Accountdriver.aspx.cs" Inherits="AccountManager_Accountdriver" Title=":: Bachpan Mayur Vihar ::" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .modalBackground
        { 
            background: url(img/black_transparant_img.png) repeat left top;           
        }
        .popup_wrapp
        {
            width: 712px;
            background: #fff;
            border: 1px solid #eae6cd;
            position: fixed;
            top: 16px;
            left: 300px;
            z-index: 99999;
            padding: 10px;
        }
        .pop_main_box
        {
            width: 652px;
            border: 1px solid #acacac;
            padding: 30px;
            position: relative;
        }
        .close_icon_popup
        {
            width: 16px;
            height: 16px;
            position: absolute;
            right: 9px;
            top: 9px;
        }
        .popup_title
        {
            font: normal 18px "Trebuchet MS" , Arial, Helvetica, sans-serif;
            color: #454545;
            padding: 0px 0px 10px;
            margin-bottom: 10px;
            text-transform: uppercase;
            border-bottom: 1px solid #acacac;
        }
        .inv_title
        {
            background: url(img/dark_gray_texture.jpg) repeat left top;
            border: 1px solid #afaca3;
            height: 39px;
            padding: 0px 15px;
            line-height: 39px;
            margin: 0px;
        }
        .tofrom_box
        {
            border: 0px solid #e7e5dd;
            padding: 17px 0px;
            border-top: 0px solid #fff;
            margin-bottom: 10px;
        }
        .tofrom_box dl
        {
            margin: 0px;
            padding: 0px;
            display: block;
        }
        .tofrom_box dl dd
        {
            float: left;
            width: 50%;
        }
        .tofrom_box dl dd span
        {
            font-weight: bold;
            color: #999;
        }
        .pay_title
        {
            font: bold 16px Arial, Helvetica, sans-serif;
            text-align: center;
            margin-bottom: 10px;
        }
        .net_amt_box
        {
            margin: 0px;
            padding: 0px;
        }
        .net_amt_box dl
        {
            width: 100%;
            display: block;
            margin: 0px;
            padding: 0px;
            font: bold 12px/24px Arial, Helvetica, sans-serif;
        }
        .net_amt_box dl dt
        {
            width: 144px;
            float: left;
            padding-left: 10px;
        }
        .net_amt_box dl dd
        {
            width: 450px;
            float: left;
            color: #8eb327;
        }
    </style>

    <script language="javascript">
//	function showOptions()
//	{
//		$("#optionmenu").toggle();
//	}
//	function showOptions_vsu()
//	{
//		$("#optionmenu_vsu").toggle();
//	}
//	function showOptions_vsd(ID)
//	{
//	var cntrl = document.getElementById(ID);
//		$(cntrl).toggle();
//	}
	
//	function showOptions_vsu(id)
//	{
//	    var cntrl = document.getElementById(id);
//	  
//		$(cntrl).toggle();
//	}
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="achive_right_main">
            			 <section class="top_row">
                         <section class="achiv_toptitle">Transport    <span> Accounting</span></section>
                          <section class="top_row_back"><a href="javascript:history.go(-1)" title="Back">BACK</a></section>
                            <section class="clear"></section>
                         </section>
                         	 <section class="sl_ra_box">
                         	 
                         	  <asp:RadioButton  ID ="redioStudent" runat ="server"  AutoPostBack ="true" Text ="Bus Maintenance" OnCheckedChanged ="Redio_Bus"   GroupName ="r"  />
                         	  <asp:RadioButton  ID ="RadioBusDetails" runat ="server"  AutoPostBack ="true" Text ="Driver Managements" OnCheckedChanged ="Redio_Driver"  GroupName ="r"   Checked ="true" />
                         	 <asp:RadioButton  ID ="RadioDriver" runat ="server"  AutoPostBack ="true" Text ="Supporter Management" OnCheckedChanged ="Redio_Supporter" GroupName ="r"  />
                         	 
 
        </section>
                             <section class="bus_search_box">
							
								
                                <section class="clear"></section>
                             </section>
                         
              
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
                                                    <asp:ListItem Text="June" Value="June"></asp:ListItem>
                                                    <asp:ListItem Text="July" Value="July"></asp:ListItem>
                                                    <asp:ListItem Text="August" Value="August"></asp:ListItem>
                                                    <asp:ListItem Text="September" Value="September"></asp:ListItem>
                                                    <asp:ListItem Text="October" Value="October"></asp:ListItem>
                                                    <asp:ListItem Text="November" Value="November"></asp:ListItem>
                                                    <asp:ListItem Text="December" Value="December"></asp:ListItem>
                                                    <asp:ListItem Text="January" Value="January"></asp:ListItem>
                                                    <asp:ListItem Text="February" Value="February"></asp:ListItem>
                                                    <asp:ListItem Text="March" Value="March"></asp:ListItem>
                                                     <asp:ListItem Text="April" Value="April"></asp:ListItem>
                            	                   </asp:DropDownList>
                          <section class="clear"></section>
                         </section>
                 
                 
                 <asp:GridView ID="GriedViewDriver" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="16" 
                   CssClass="billing_invoic" Width="98%" 
                     OnPageIndexChanging="GriedViewDriver_PageIndexChanging" OnRowDataBound ="GriedViewDriver_RowDataBound"
                     EmptyDataRowStyle-VerticalAlign="Middle" EmptyDataText="No Record Found" EmptyDataRowStyle-ForeColor="Red"
                    EmptyDataRowStyle-HorizontalAlign="Left" CellPadding="4" GridLines="None" ShowFooter ="true">
                   <RowStyle HorizontalAlign="Center" VerticalAlign="Top"/>
                    <FooterStyle Font-Bold="true" BackColor="#61A6F8" ForeColor="black" />
                   <Columns>
                    <asp:TemplateField HeaderText="Id">
                           <ItemTemplate>
                           <asp:Label ID="Label1" runat="server" Text='<%# Bind("BSD_BusStaffId") %>'></asp:Label>
                               <asp:Label ID="lblsalDetailsId" runat="server" Text='<%# Bind("SI_DetailsId") %>' Visible ="false" ></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                       <asp:TemplateField HeaderText="Month">
                           <ItemTemplate>
                               <asp:Label ID="lbSI_Month" runat="server" Text='<%# Bind("SI_Month") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                       
                        <asp:TemplateField HeaderText="Year">
                           <ItemTemplate>
                               <asp:Label ID="lbSI_Year" runat="server" Text='<%# Bind("SI_Year") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                       <asp:TemplateField HeaderText="Name">
                           <ItemTemplate>
                               <asp:Label ID="lbBSD_StaffName" runat="server" Text='<%# Bind("BSD_StaffName") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>

                     <asp:TemplateField HeaderText="Gross Salary">
                           <ItemTemplate>
                               <asp:Label ID="lbSI_GrossSalary" runat="server" Text='<%# Bind("SI_GrossSalary") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
  
  
                     <asp:TemplateField HeaderText="Leave ">
                           <ItemTemplate>
                               <asp:Label ID="lbLeaveCount" runat="server" Text='<%# Bind("SI_LeaveCount") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                      <asp:TemplateField HeaderText="Leave DeductionAmount">
                           <ItemTemplate>
                          <asp:Label ID="lbSI_LeaveDeductionAmount" runat="server" Text='<%# Bind("SI_LeaveDeductionAmount") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                        <asp:TemplateField HeaderText="Salary Issued">
                           <ItemTemplate>
                               <asp:Label ID="lbSI_BasicSalary" runat="server" Text='<%# Bind("SI_BasicSalary") %>'></asp:Label>
                           </ItemTemplate>
                            <FooterTemplate >
                             <asp:Label ID="lblTotal" runat="server" style="color:#cc6c00; font:bold 14px Arial, Helvetica, sans-serif;"/>
                           </FooterTemplate>
                       </asp:TemplateField>
                        <asp:TemplateField >
                       <ItemTemplate >
                        <asp:LinkButton  ID="lnkViewMsg" CssClass="bt_view" OnClick="lnkViewSalarySlip_Details" runat="server"  Text="View Salary Slip"></asp:LinkButton>
                              <cc1:ModalPopupExtender  ID="SalarySlipPopUp" runat="server" TargetControlID="lnkViewMsg"
                                PopupControlID="PanSalarySection"  BackgroundCssClass="modalBackground"  CacheDynamicResults="True" Enabled="True" ></cc1:ModalPopupExtender> 
                       </ItemTemplate>
                       </asp:TemplateField>
                   </Columns> 
                   </asp:GridView>
                 
                   <asp:Panel ID="PanSalarySection"  runat="server" Visible="false">	
        <section style="background: #000; width: 100%; height: 100%; position: absolute;
            zoom: 1;  -ms-filter:"progid:DXImageTransform.Microsoft.Alpha(Opacity=50)";  filter: alpha(opacity=50);  opacity: 0.5; z-index: 999;"></section>
        <section class="popup_wrapp">
  <section class="pop_main_box">
    <section class="close_icon_popup"> <asp:ImageButton ID="lnkClose" runat="server" OnClick="click_lnkClose" ImageUrl="~/img/pop_close_icon.png"
                Height="16px" Width="16px" /></section>
    <section class="popup_title"> <span class="lF">Salary Slip</span>
   
      <section class="clear"></section>
    </section>
  
    <section class="pay_title">Payslip for the Month <Asp:Label id="lblMonthName" runat="server"></Asp:Label> <span> <Asp:Label id="lblYearName" runat="server"              >
    </Asp:Label> </span> </section>
    <table class="billing_invoic">
      <tfoot>
        <tr>
          <td><strong>Employee Name</strong></td>
          <td><Asp:Label id="lblEmployeeNmae" runat="server"></Asp:Label></td>
        
        </tr>
        <tr>
          <td><strong>Joining Date</strong></td>
          <td><Asp:Label id="lblJoiningDtae" runat="server"></Asp:Label></td>
        </tr>
        <tr>
          <td><strong>Designation</strong></td>
          <td><Asp:Label id="lblDesignation" runat="server"></Asp:Label></td>
        </tr>
        
         <%--<tr>
          <td><strong>Location</strong></td>
          <td><Asp:Label id="lblLocation" runat="server"></Asp:Label></td>
        </tr>--%>
      
      </tfoot>
      <tbody>
      </tbody>
    </table>

    <asp:GridView ID="grdSalarySlip" runat="server" 
        AutoGenerateColumns="False" CssClass="billing_invoic" Width="98%">
                    <Columns>
                  <asp:TemplateField HeaderText="Month" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                <asp:Label ID="lblMonth1" runat="server" Text='<%# Bind("SI_Month") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                       
                        
                         <asp:TemplateField HeaderText="Gross Salary" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                   <asp:Label ID="lblGrossSalary1" runat="server" Text='<%# Bind("SI_GrossSalary") %>'></asp:Label>               
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Leave Count" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                 <asp:Label ID="lblLeaveCount1" runat="server" Text='<%# Bind("SI_LeaveCount") %>'></asp:Label>                     
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Leave Deduction Amount" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                   <asp:Label ID="lblDeductionAmount1" runat="server" Text='<%# Bind("SI_LeaveDeductionAmount") %>'></asp:Label>                  
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField> 
                        
                      
                         <asp:TemplateField HeaderText="Salary Issued" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                  <asp:Label ID="lblBasicSalary1" runat="server" Text='<%# Bind("SI_BasicSalary") %>'></asp:Label>               
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                    </Columns>
                    </asp:GridView>
    
    
    <section class="net_amt_box">
    	<dl>
        	<dt>Net Amount :</dt>
            <dd><b>Rs:</b> <asp:Label ID ="lblNetSalary" runat ="server" ></asp:Label> /-
            </dd>
            <section class="clear"></section>
        </dl>
        <dl>
        	<dt>Net Pay in Words :</dt>
            <dd><asp:Label ID ="lblNetSalWord" runat ="server" ></asp:Label>Rupees Only</dd>
            <section class="clear"></section>
        </dl>
    </section>
  </section>
</section>
    </asp:Panel>
                    
              </section>
</asp:Content>
