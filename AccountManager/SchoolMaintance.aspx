<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master"
    AutoEventWireup="true" CodeFile="SchoolMaintance.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_SchoolMaintance" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        
        .popup_wrapp
        {
            width: 432px;
            background: #fff;
            border: 1px solid #eae6cd;
            position: absolute;
            top: 230px;
            left: 460px;
            z-index: 99999;
            padding: 10px;
        }
        .pop_main_box
        {
            width: 370px;
            border: 1px solid #acacac;
            padding: 30px;
            position: relative;
            height: auto;
            min-height: 250px;
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
            background: url(../img/dark_gray_texture.jpg) repeat left top;
            border: 1px solid #afaca3;
            height: 39px;
            padding: 0px 15px;
            line-height: 39px;
            margin: 0px;
        }
        .tofrom_box
        {
            border: 1px solid #e7e5dd;
            padding: 17px 15px;
            border-top: 0px solid #fff;
            margin-bottom: 30px;
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
        .sta_box
        {
            margin: 0px;
            padding: 0px;
            line-height: 24px;
        }
        .inst_title
        {
            background: url(../img/dark_gray_texture.jpg) repeat left top;
            border: 1px solid #afaca3;
            border-bottom: 0px solid #fff;
            height: 39px;
            text-align: center;
            margin: 0px;
            font: bold 14px/39px Arial, Helvetica, sans-serif;
        }
        .total_box
        {
            margin: 0px;
            padding: 0px;
        }
        .total_box dl
        {
            margin: 0px;
            padding: 0px;
            display: block;
        }
        .total_box dl dt
        {
            float: left;
            text-align: right;
            width: 580px;
        }
        .total_box dl dd
        {
            float: right;
            width: 70px;
            text-align: right;
        }
        .tele_wraper
        {
            width: 370px;
        }
        .tele_wraper dl
        {
            width: 100%;
            border-bottom: 1px solid #ccc;
        }
        .tele_wraper dl dt
        {
            width: 130px;
            float: left;
        }
        .tele_wraper dl dd
        {
            width: 100px;
            float: left;
        }
       
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
                         <section class="top_row bottom_bor">
                         <section class="achiv_toptitle">School <span>Maintenance</span></section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx">BACK</a></section>
                          <section class="clear"></section>
                         </section>
    <section class="maintenance_nav_wrap" style="width:557px;">
                         	<ul>
                            <li id="tc"><a class="active" href="SchoolMaintance.aspx">Telephone</a></li>
                                <li id="td"><a href="PrintingAndStationary.aspx">Printing &amp; Stationary</a></li>
                                <li id="ld"><a href="OtherExpenses.aspx">Other Expenses</a></li>                               
                                <section class="clear"></section>
                            </ul>
                         </section>
    <section class="elect_heading"> Telephone Details </section>


    <asp:Button ID="btnAddBill" runat="server" Text="Add Telephone Bill" CssClass="go"
        OnClick="btnAddBill_Clikck" />
    <asp:DropDownList ID="ddlYear1" runat="server" width="120px" CssClass="select"
        AutoPostBack="true" OnSelectedIndexChanged="ddlYear1_SelectedIndexChanged">
       
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
    <section id="SectionMaintenanceDetails" runat="server" style="display: block;">
                         <br />
                   		 
                                
                     <asp:GridView ID="grdTelephoneBill" runat="server" 
        AutoGenerateColumns="False" CssClass="billing_invoic" Width="98%" onrowdatabound="grdTelephoneBill_RowDataBound" 
                    OnPageIndexChanging="grdTelephoneBill_PageIndexChanging" 
        EmptyDataRowStyle-VerticalAlign="Middle" EmptyDataText="No Record Found" EmptyDataRowStyle-ForeColor="Red"
                    EmptyDataRowStyle-HorizontalAlign="Left" CellPadding="4" GridLines="None"
                    AllowSorting="True"  AllowPaging="true" PageSize="10">
                    <Columns>
                   <asp:TemplateField HeaderText="Month" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                <asp:Label ID="lblMonth" runat="server" Text='<%# Bind("TBD_Month") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                       
                         <asp:TemplateField HeaderText="Library" HeaderStyle-HorizontalAlign="Left" Visible="false">
                            <ItemTemplate>
                            <asp:LinkButton ID ="lblLibraryBill" runat ="server" OnClick ="lblLibraryBill_Click" Text='<%# Bind("Library") %>' CommandArgument='<%#Bind("TBD_Month") %>' CommandName="Library"></asp:LinkButton>
                               <%-- <asp:Label ID="lblLibraryBill" runat="server"></asp:Label> --%>                               
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Canteen" HeaderStyle-HorizontalAlign="Left" Visible="false">
                            <ItemTemplate>
                             <asp:LinkButton ID ="lblCanteenBill" runat ="server" OnClick ="lblCanteenBill_Click" Text='<%# Bind("Canteen") %>' CommandArgument='<%#Bind("TBD_Month") %>' CommandName="Canteen"></asp:LinkButton>
                               <%-- <asp:Label ID="lblCanteenBill" runat="server" ></asp:Label>    --%>                            
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Staff" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                             <asp:LinkButton ID ="lblStaffBill" runat ="server" OnClick ="lblStaffBill_Click" Text='<%# Bind("Staff") %>' CommandArgument='<%#Bind("TBD_Month") %>' CommandName="Staff"></asp:LinkButton>
                                <%--<asp:Label ID="lblStaffBill" runat="server" ></asp:Label>  --%>                              
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Accounts" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                             <asp:LinkButton ID ="lblAccountsBill" runat ="server" OnClick ="lblAccountsBill_Click" Text='<%# Bind("Accounts") %>' CommandArgument='<%#Bind("TBD_Month") %>' CommandName="Accounts"></asp:LinkButton>
                                <%--<asp:Label ID="lblAccountsBill" runat="server"></asp:Label>      --%>                          
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField> 
                         
                         <asp:TemplateField HeaderText="Total" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                <asp:Label ID="lblTotal" runat="server" Text='<%# Bind("Total") %>'></asp:Label>                                
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField> 
                        
                       <asp:TemplateField HeaderText="Status" HeaderStyle-HorizontalAlign="Left" Visible="false">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkStatus" runat="server" OnClick="lnkStatus_Click" Text='<%# Bind("TBD_PaidStatus")%>' CommandArgument='<%#Bind("TBD_Month") %>'></asp:LinkButton> 
                                <asp:Label ID="lblPaidStatus" runat="server" Text='<%# Bind("TBD_PaidStatus")%>' Visible="false"></asp:Label>                                
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField> 
                                              
                    </Columns>
                    </asp:GridView>        
          </section>         		 
    <br />
    <br />
    <section class="top_row">
                          <section id="dvMsg" runat="server" visible="false" style="width: -2px;">
                            <asp:Label ID="lblMessage" runat="server"></asp:Label>
                            <section class="clear">
                            </section>
                            </section>
                            <section class="clear">
                            </section>
                        </section>
    <br />
    <section id="SectionAddBill" runat="server" style="display: none;">
                              <section   class="tabsec_topsecn" style="background:none!important;">           
                               <fieldset runat="server" id="fieldsetAddBill">
                                                <section class="teac_edit_form">
                                                    <ul>
                                                     <li>
                            	                         <label>Select Department :</label>
                            	                         <asp:DropDownList  ID ="ddlType" runat ="server" style="float:left;" onselectedindexchanged="ddlType_SelectedIndexChanged"   AutoPostBack ="true"  Width="220px">
                            	                       
                                                              <asp:ListItem Text="Staff" Value="Staff"></asp:ListItem>
                                                               <asp:ListItem Text="Accounts" Value="Accounts"></asp:ListItem>
                            	                          </asp:DropDownList>
                                                    </li>
                                                     
                                                     <li>
                            	                         <label>Telephone Number :</label>
                            	                         <asp:DropDownList  ID ="ddlPhone" runat ="server" style="float:left;"  Width="220px">
                            	                          </asp:DropDownList>
                                                           
                                                              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic"
                                    ErrorMessage="Required" ControlToValidate="ddlPhone" SetFocusOnError="true" InitialValue="-1" style="padding-left:240px"
                                    ValidationGroup="sub"></asp:RequiredFieldValidator>
                                                    </li>
                                                    
                                                     <li>
                            	                         <label>Telephone Bill :</label>
                            	                         <asp:TextBox ID="txtBill" runat="server" style="float:left;"  Width="220px" MaxLength="5"></asp:TextBox>
                            	                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic"
                                    ErrorMessage="Required" ControlToValidate="txtBill" SetFocusOnError="true" style="padding-left:240px"
                                    ValidationGroup="sub"></asp:RequiredFieldValidator>
                             
                                    <cc1:filteredtextboxextender id="FilteredTextBoxExtender1" validchars="0123456789."
                                      runat="server" enabled="True" targetcontrolid="txtBill">
                               </cc1:filteredtextboxextender>
                                                    </li>
                                                    
                                                     <li>
                                                    <label>Select Month :</label>
                                                    <asp:DropDownList ID="ddlMonth" runat="server" style="float:left;"  Width="220px">
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
                                                    </li>
                                                    
                                                     <li>
                                                    <label>Select Year :</label>
                                                    <asp:DropDownList ID="ddlYear" runat="server" style="float:left;" Width="220px">
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
                                                    </li>
                                                </ul>
                                                </section>
                                    <section class="save_bt_box_small lF" style="margin:0px 160px 8px 275px;">
                                     <asp:Button ID="btnSave" runat="server" Text="Submit" onclick="btnSave_Click" ValidationGroup="sub"></asp:Button>
                                      <asp:Button ID="btnCancel" runat="server"  CssClass="reset" Text="Cancel" OnClick="btnCancel_Click" />  
                                    </section>   
                                                </fieldset >
                     <asp:GridView ID="grdBillDetails" runat="server" AutoGenerateColumns="False" CssClass="billing_invoic" Width="98%" 
                    onrowdatabound="grdBillDetails_RowDataBound" 
                    OnPageIndexChanging="grdBillDetails_PageIndexChanging"  
                    onrowcancelingedit="grdBillDetails_RowCancelingEdit" 
                    onrowediting="grdBillDetails_RowEditing" 
                    onrowupdating="grdBillDetails_RowUpdating" 
                    EmptyDataRowStyle-VerticalAlign="Middle" EmptyDataText="No Record Found" 
                    EmptyDataRowStyle-ForeColor="Red"
                    EmptyDataRowStyle-HorizontalAlign="Left" CellPadding="4" GridLines="None"
                    AllowSorting="True"  AllowPaging="true" PageSize="10">
                    <Columns>
                   <asp:TemplateField HeaderText="Sr No" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                <asp:Label ID="lblBillId" runat="server" Text='<%# Bind("TBD_BillId") %>' Visible="false"></asp:Label>
                                 <asp:Label ID="lblTelephoneId" runat="server" Text='<%# Bind("TBD_TelephoneId") %>' Visible="false"></asp:Label>
                                   <asp:Label ID="lblSrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                       
                         <asp:TemplateField HeaderText="Department" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                            <asp:Label ID ="lblDepartmentName" runat="server" Text='<%# Bind("TD_TelephoneDepartment") %>'></asp:Label>                            
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                          <asp:TemplateField HeaderText="TelePhone Number" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                            <asp:Label ID ="lblDepartment" runat="server" Text='<%# Bind("TD_TelephoneNumber") %>'></asp:Label>                            
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Bill Amount" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                             <asp:Label ID ="lblBillAmount" runat="server" Text='<%# Bind("TBD_BillAmount") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="txtBillAmount" runat="server" Text='<%# Bind("TBD_BillAmount") %>'  MaxLength ="10" ></asp:TextBox>
                            <cc1:filteredtextboxextender id="FilteredTextBoxExtender1" validchars="0123456789."
                                      runat="server" enabled="True" targetcontrolid="txtBillAmount">
                               </cc1:filteredtextboxextender>
                            </EditItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Month" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                             <asp:Label ID ="lblMonthName" runat="server" Text='<%# Bind("TBD_Month") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Year" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                             <asp:Label ID ="lblMonth" runat="server" Text='<%# Bind("TBD_Year") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                  <asp:TemplateField HeaderText="Edit" ShowHeader="false">
               <ItemTemplate>
                   <asp:LinkButton ID="btnedit" runat="server" CommandName="Edit" Text="Edit" ></asp:LinkButton>
               </ItemTemplate>
               <EditItemTemplate>
                   <asp:LinkButton ID="btnupdate" runat="server" CommandName="Update" Text="Update" ></asp:LinkButton>
                   <asp:LinkButton ID="btncancel" runat="server" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
               </EditItemTemplate>
            </asp:TemplateField>
                    </Columns>
                    </asp:GridView>
                               <section class="clear"></section>
                               </section>
                               </section>
    <cc1:ModalPopupExtender ID="PopUpMaintenanace" runat="server" TargetControlID="btnDefault"
        PopupControlID="SectionTelephonePopUp">
    </cc1:ModalPopupExtender>
    <asp:Panel ID="SectionTelephonePopUp" runat="server" Style="background: #000; width: 100%;
        height: 100%; position: absolute; zoom: 1; filter: alpha(opacity=50); opacity: 0.90;
        z-index: 100; display: none;">
        <asp:Button runat="server" ID="btnDefault" Style="display: none;" />
        <section runat="server"></section>
        <section class="popup_wrapp">
	<section class="pop_main_box">
     <section class="close_icon_popup">
            <asp:ImageButton  ID="lnkClose" runat="server" onClick="lnkClose_Click" ImageUrl="../img/pop_close_icon.png"
                Height="16px" Width="16px"></asp:ImageButton>
        </section>
         
  <section class="inv_title">
  	
  	 <asp:ListView ID="lstPhone" runat="server" ItemPlaceholderID="PlaceHolder1" 
                            onitemdatabound="lstPhone_ItemDataBound" OnPagePropertiesChanging="lstPhone_ChangePage">
                <LayoutTemplate>
              <dl>
            	<dt>Telephone Number</dt>
                <dd>Bill</dd>
                <section class="clear"></section>
            </dl>
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server" />
                </LayoutTemplate>
                <ItemTemplate>
        	
            <section class="tele_wraper">
            <dl>
            	<dt><asp:Label ID="lblPhoneNumbers" Text='<%#Bind("TD_TelephoneNumber") %>' runat="server"></asp:Label>
                                	</dt>
                <dd>Rs:<asp:Label ID="lblAmount" Text='<%#Bind("TBD_BillAmount") %>' runat="server"></asp:Label></dd>
                <section class="clear"></section>
            </dl>
             <section class="clear"></section>
        </section>    
            
        
        </ItemTemplate>
                 <EmptyDataTemplate>
                        <asp:Label ID="lblNoRecord" Style="font-weight: bold; font-size: 13px; color: Red;"
                            runat="server" Text="No Record Found"></asp:Label>
                    </EmptyDataTemplate>
            </asp:ListView>
      <asp:DataPager ID="DataPagerTrip" runat="server" PagedControlID="lstPhone" 
                            PageSize="10" >
                            <Fields>
                                <asp:NextPreviousPagerField ShowFirstPageButton="True" ShowNextPageButton="False"
                                    PreviousPageText="Previous" FirstPageText="First"
                                    ButtonCssClass="Pagbtn" />
                                <asp:NumericPagerField NumericButtonCssClass="Pagbtn" />
                                <asp:NextPreviousPagerField ShowLastPageButton="True" ShowPreviousPageButton="False"
                                    LastPageText="Last" NextPageText="Next"
                                    ButtonCssClass="Pagbtn" />
                            </Fields>
                 </asp:DataPager>
  
</section>
</section>
</section>

    </asp:Panel>
</asp:Content>
