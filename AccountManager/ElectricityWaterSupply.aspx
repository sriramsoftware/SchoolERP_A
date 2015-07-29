<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master"
    AutoEventWireup="true" CodeFile="ElectricityWaterSupply.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_ElectricityWaterSupply" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" language="javascript">

        function DisableKeys(e) {
            if (e.keyCode == 13 || e.keyCode == 9 || e.keyCode == 8)
                return true;
            else
                return false;
        }
    
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="top_row bottom_bor">
                         <section class="achiv_toptitle">Electricity<span> and water supply</span></section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx">BACK</a></section>
                          <section class="clear"></section>
                         </section>
    <div id="dvMsg" runat="server" visible="false">
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <div class="clear">
        </div>
    </div>
    <section class="electricity_nav_wrap">
                         	<ul>
                                 <li id="tc"><a href="#" style="cursor:auto" >&nbsp;</a></li>
                                <li id="td"><a class="active" id ="aElectricSupply"  runat ="server" onserverclick ="aElectricSupply_Click">Electricity Charges</a></li>
                                <li id="ld"><a id ="awaterSupply"  runat ="server" onserverclick ="awaterSupply_Click"  >Water Supply</a></li>
                             <li id="labo"><a   style="cursor:auto" href="javascript:;">&nbsp;</a></li>
                                <section class="clear"></section>
                            </ul>
                         </section>
    <section class="top_row" runat="server" id="SElecricity">
				<section class="elect_heading">Monthly Electricity Charges</section>
                <section class="marg20">
                
                 <section class="sortmain" >
                   
                  <section class="sort">
                  <asp:LinkButton ID ="linkbuttonAddElec" runat ="server"  OnClick ="AddElecricity_Click">
                  Add Electricity Bill
                  </asp:LinkButton>
                </section> </section> 
                <section id="sortsection" runat="server">
                  <section class="sortmain" >
                   <section class="sort">
                  <asp:LinkButton ID ="linkelectricity" runat ="server"  OnClick ="linkelectricity_Click">
                  Search
                  </asp:LinkButton>
                </section>
                 </section> 
                  
                  <asp:DropDownList ID ="DdlElecricity"  runat ="server"  CssClass ="sortby">
                  
                  </asp:DropDownList>
                          </section>
                 <section class="clear"></section>
                 </section>  
                    <section>      
                   <asp:GridView ID="GrdElecricity" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="16" 
                   CssClass="time_table_ut" Width="98%"  OnRowDataBound ="GriedElecricSuppy_RowDataBound"
                   OnPageIndexChanging="GrdElecricity_PageIndexChanging"
                     EmptyDataRowStyle-VerticalAlign="Middle" EmptyDataText="No Record Found" EmptyDataRowStyle-ForeColor="Red"
                    EmptyDataRowStyle-HorizontalAlign="Left" CellPadding="4" GridLines="None"
                   
                   >
                   <RowStyle HorizontalAlign="Center" VerticalAlign="Top"/>
                   <Columns>
                   
                       <asp:TemplateField HeaderText="SR.No.">
                           <ItemTemplate>
                               <asp:Label ID="lblSrNo" runat="server" 
                                   Text="<%# Container.DataItemIndex + 1 %>"></asp:Label>
                                      <asp:Label ID="lblEl_EbillID" runat="server" Text='<%# Bind("El_EbillID") %>' Visible="False"></asp:Label>
                                       <asp:Label ID ="lblPaidStatus" runat ="server" Text ='<%#Eval("EL_PaidStatus")%>' Visible ="false" ></asp:Label>
                    
                              <asp:Label ID ="lblDiff" runat ="server" Text ='<%#Eval("Diff")%>' Visible ="false" ></asp:Label>
                    
                           </ItemTemplate>
                           <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" />
                       </asp:TemplateField>
                        <asp:TemplateField HeaderText="Month">
                           <ItemTemplate>
                               <asp:Label ID="lbEL_Month" runat="server" Text='<%# Bind("EL_Month") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
               
               
                 <asp:TemplateField HeaderText="Year">
                           <ItemTemplate>
                               <asp:Label ID="lbEl_Year" runat="server" Text='<%# Bind("El_Year") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                      
                            
                           <asp:TemplateField HeaderText="Bill Amount">
                           <ItemTemplate>
                               <asp:Label ID="lbEL_BillAmount" runat="server" Text='<%# Bind("EL_BillAmount") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                       
                       <asp:TemplateField HeaderText="Last Date">
                           <ItemTemplate>
                               <asp:Label ID="lbEl_LastDate" runat="server" Text='<%# Bind("El_LastDate","{0:dd/MM/yyyy}") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>

                        <asp:TemplateField HeaderText="Paid Date">
                           <ItemTemplate>
                               <asp:Label ID="lblEl_BillPaidDate" runat="server" Text='<%# Bind("El_BillPaidDate","{0:dd/MM/yyyy}") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                       
                        <asp:TemplateField HeaderText="Late Fees">
                           <ItemTemplate>
                               <asp:Label ID="lbEL_LateFees" runat="server" Text='<%# Bind("EL_LateFees") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                   
                        <asp:TemplateField HeaderText="Total Cost">
                           <ItemTemplate>
                               <asp:Label ID="lblTotalCost" runat="server" ></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                       
                       <asp:TemplateField HeaderText="Paid Status">
                           <ItemTemplate>
                               <asp:Label ID="lbEL_PaidStatus" runat="server" Text='<%# Bind("EL_PaidStatus") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                  <asp:TemplateField HeaderText="Edit">
                           <ItemTemplate>
                           <asp:LinkButton ID ="linkelecricityEdit" runat ="server"  OnClick ="ElecricityEdit_Click" Text ="Edit"></asp:LinkButton>
                           </ItemTemplate>
                       </asp:TemplateField>
                     
                     <%--  <asp:TemplateField HeaderText="Delete">
                           <ItemTemplate>
                              <asp:ImageButton ID="IblDelete" runat="server" CommandName="Delete" ToolTip="Delete Record"
                                OnClientClick="javascript:return confirm('Do you want to delete the record?');"
                                ImageUrl="~/img/icon-delete.png"></asp:ImageButton>
                           </ItemTemplate>
                       </asp:TemplateField>--%>
                       
                   </Columns>
                   <HeaderStyle HorizontalAlign="Center" VerticalAlign="Top" />
               </asp:GridView>
                   </section>         
              	  
              	  
              	   </section>
    <section class="top_row" id="SWater" runat="server" visible="false">
				<section class="elect_heading">Monthly Water Supply Charges</section>
                <section class="marg20">
                <section class="sortmain" >
                   
                  <section class="sort">
                  <asp:LinkButton ID ="linkbutton1" runat ="server"  OnClick ="WaterSupply_Click">
                  Add Water Supply Bill
                  </asp:LinkButton>
                </section> </section> 
                <section id="sectionSortWater" runat="server">
                  <section class="sortmain"><section class="sort">
                  <asp:LinkButton ID ="linkwater" runat ="server" OnClick ="linkwater_Click" >
                  Search
                  </asp:LinkButton>
                  <%--<a href="#url">Sort</a>--%></section> </section> 
                  
                  <asp:DropDownList ID ="ddlwater"  runat ="server"  CssClass ="sortby">
                  
                  </asp:DropDownList>
                  <section class="clear"></section>
                  </section>
                 </section>  
                   
              	   <section>
                   
                   
                   
                   <asp:GridView ID="GrdWaterSupply" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="16" 
                   CssClass="time_table_ut" Width="98%"   OnRowDataBound ="GrdWaterSupply_RowDataBound"
                    OnPageIndexChanging="GrdWaterSupply_PageIndexChanging"
                     EmptyDataRowStyle-VerticalAlign="Middle" EmptyDataText="No Record Found" EmptyDataRowStyle-ForeColor="Red"
                    EmptyDataRowStyle-HorizontalAlign="Left" CellPadding="4" GridLines="None"
                   
                   >
                   <RowStyle HorizontalAlign="Center" VerticalAlign="Top"/>
                   <Columns>
                     <%--<asp:TemplateField>
                           <ItemTemplate>
                               <asp:CheckBox ID="chkStatus" runat="server"/>
                               
                           </ItemTemplate>
                       </asp:TemplateField>--%>
                       <asp:TemplateField HeaderText="SR.No.">
                           <ItemTemplate>
                               <asp:Label ID="lblSrNo" runat="server" 
                                   Text="<%# Container.DataItemIndex + 1 %>"></asp:Label>
                                     <asp:Label ID="lblWS_WSID" runat="server" Text='<%# Bind("WS_WSID") %>' Visible="False"></asp:Label>
                                    <asp:Label ID ="lblDiff" runat ="server" Text ='<%#Eval("Diff")%>' Visible ="false" ></asp:Label>
                              
                           </ItemTemplate>
                           <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" />
                       </asp:TemplateField>
                       
                      
                            
                           <asp:TemplateField HeaderText="Bill Amount">
                           <ItemTemplate>
                               <asp:Label ID="lbEL_BillAmount" runat="server" Text='<%# Bind("WS_BillAmount") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                       
                       <asp:TemplateField HeaderText="Last Date">
                           <ItemTemplate>
                               <asp:Label ID="lblWS_LastDate" runat="server" Text='<%# Bind("WS_LastDate","{0:dd/MM/yyyy}") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                       
                       
                         <asp:TemplateField HeaderText="Paid Date">
                           <ItemTemplate>
                               <asp:Label ID="lblEl_BillPaidDate" runat="server" Text='<%# Bind("WS_BillPaidDate","{0:dd/MM/yyyy}") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                       
                        <asp:TemplateField HeaderText="Late Fees">
                           <ItemTemplate>
                               <asp:Label ID="lbEL_LateFees" runat="server" Text='<%# Bind("WS_LateFees") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                            
                            
                        <asp:TemplateField HeaderText="Month">
                           <ItemTemplate>
                               <asp:Label ID="lbEL_Month" runat="server" Text='<%# Bind("WS_Month") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
               
               
                 <asp:TemplateField HeaderText="Year">
                           <ItemTemplate>
                               <asp:Label ID="lbEl_Year" runat="server" Text='<%# Bind("WS_Year") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                       
                        <asp:TemplateField HeaderText="Total Cost">
                           <ItemTemplate>
                               <asp:Label ID="lblTotalCost" runat="server" ></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                       
                       <asp:TemplateField HeaderText="Paid Status">
                           <ItemTemplate>
                               <asp:Label ID="lbEL_PaidStatus" runat="server" Text='<%# Bind("WS_PaidStatus") %>'></asp:Label>
                           </ItemTemplate>
                       </asp:TemplateField>
                  <asp:TemplateField HeaderText="Edit">
                           <ItemTemplate>
                            <asp:LinkButton ID ="linkelWaterEdit" runat ="server"  OnClick ="WaterEdit_Click" Text ="Edit">

</asp:LinkButton>
                           </ItemTemplate>
                       </asp:TemplateField>
                       
                   </Columns>
                   <HeaderStyle HorizontalAlign="Center" VerticalAlign="Top" />
               </asp:GridView>
                   
                
                   </section>    
              	  </section>
    <section class="top_row" id="Addelecricity" runat="server" visible="false">
              	  <section class="elect_heading"> <asp:Label  ID ="lbladd" runat ="server"  Text ="Add" ></asp:Label> Electricity Charges</section>
              	   <fieldset>
            <section class="col1" style="width:60%">                    	
                    	<ul>
                    	     <li>
                            	<label>Bill Amount (RS):</label>
                            	<asp:TextBox ID="txtBillAmount" runat="server" MaxLength ="8" ></asp:TextBox>
                            	<br />
                            	<asp:RequiredFieldValidator ID ="req" runat ="server" ControlToValidate ="txtBillAmount" Display ="Dynamic" ErrorMessage ="Please Enter Bill Amount"  ValidationGroup ="V" style="margin-left:66px;padding-left:150px;" ></asp:RequiredFieldValidator>
                            	
                            	 <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" ValidChars="1234567890."
                                            runat="server" Enabled="True" TargetControlID="txtBillAmount">
                                        </cc1:FilteredTextBoxExtender>
                            </li>
                    	  <li>
                            	<label>Bill Last Date :</label>
                            	   <script type="text/javascript">
                            	       function ShowDatePopup5() {
                            	           $find("<%= txtDate1.ClientID %>").showPopup();

                            	       }
                            	       function HideDatePopup3() {
                            	           $find("<%= txtDate1.ClientID %>").hidePopup();

                            	       }                                        
                                                </script>
             <telerik:RadDatePicker ID="txtDate1" onkeypress="return DisableKeys(event);"    style="width :100px; height:32px"
              runat="server" Skin="Hay" DateInput-CssClass="sortby" >
              
             
                                                    <DateInput  EmptyMessage ="Select Last Date"  >
                                                        <ClientEvents OnFocus="ShowDatePopup5"/>
                                                    </DateInput>
                                                    <Calendar ShowRowHeaders="false" DayNameFormat="FirstLetter" FirstDayOfWeek="Default" UseColumnHeadersAsSelectors="False" 
                                                        UseRowHeadersAsSelectors="False"  >

                                                        <SpecialDays >
                                                       
            <telerik:RadCalendarDay Repeatable="Today" ItemStyle-BackColor="Green"> 
            </telerik:RadCalendarDay> 
        
                                                        
                                                        </SpecialDays>
                                                    </Calendar>
                                                    <DatePopupButton Visible="False" />
                                                           
                                                </telerik:RadDatePicker>
                                                <br />
                                                <asp:RequiredFieldValidator ID ="RequiredFieldValidator1" runat ="server" ControlToValidate ="txtDate1" Display ="Dynamic" ErrorMessage ="Please Select Bill Last Date"  ValidationGroup ="V" style="margin-left:66px;padding-left:150px;" ></asp:RequiredFieldValidator>
                            </li>
                            
                            <li>
                            	<label>Late Fees (RS):</label>
                            	<asp:TextBox ID="txtLateFees" runat="server" MaxLength ="8"></asp:TextBox>
                            	<br />
                            	 <asp:RequiredFieldValidator ID ="RequiredFieldValidator2" runat ="server" ControlToValidate ="txtLateFees" Display ="Dynamic" ErrorMessage ="Please Enter Late Fees"  ValidationGroup ="V" style="margin-left:66px;padding-left:150px;" ></asp:RequiredFieldValidator>
                            	  <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" ValidChars="1234567890."
                                            runat="server" Enabled="True" TargetControlID="txtLateFees">
                                        </cc1:FilteredTextBoxExtender>
                            </li>
                            
                            <li>
                            	<label>Bill No :<span class="red_col">*</span></label>
                            	<asp:TextBox ID="txtBillNumber" MaxLength="10" runat="server"></asp:TextBox>
                            	<br />
<asp:RequiredFieldValidator ID ="RequiredFieldValidator3" runat ="server" ControlToValidate ="txtBillNumber" Display ="Dynamic" ErrorMessage ="Please Enter Bill Number"  ValidationGroup ="V"  style="margin-left:66px;padding-left:150px;"></asp:RequiredFieldValidator>
                            </li>
                            
                            <li>
                            	<label>Bill Month :</label>
                            	<asp:DropDownList ID ="ddlMonth" runat ="server" >
                                
                             	
                              <asp:ListItem Value="January">January</asp:ListItem>
                              <asp:ListItem Value="February">February</asp:ListItem>
                              <asp:ListItem Value="March">March</asp:ListItem>
                              <asp:ListItem Value="April">April</asp:ListItem>
                              <asp:ListItem Value="May">May</asp:ListItem>
                              <asp:ListItem Value="June">June</asp:ListItem>
                              <asp:ListItem Value="July">July</asp:ListItem>
                              <asp:ListItem Value="August">August</asp:ListItem>
                              <asp:ListItem Value="September">September</asp:ListItem>
                              <asp:ListItem Value="October">October</asp:ListItem>
                              <asp:ListItem Value="November">November</asp:ListItem>
                              <asp:ListItem Value="December">December</asp:ListItem>
                            	</asp:DropDownList>
                            	
                            </li>
                            
                             <li>
                            	<label>Bill Year :</label>
                            	<asp:DropDownList ID ="ddlyear" runat ="server" >
                                
                              <asp:ListItem>2013</asp:ListItem>
                              <asp:ListItem>2014</asp:ListItem>
                              <asp:ListItem>2015</asp:ListItem>
                              <asp:ListItem>2016</asp:ListItem>
                              <asp:ListItem>2017</asp:ListItem>
                              <asp:ListItem>2018</asp:ListItem>
                              <asp:ListItem>2019</asp:ListItem>
                              <asp:ListItem>2020</asp:ListItem>
                            	</asp:DropDownList>
                            	
                            </li>
                            
                             <li>
                            	<label>Upload Bill:</label>
                            	<asp:FileUpload ID ="UploadFile" runat ="server" style="margin-left:195px;" />  &nbsp;&nbsp; <br /> 
                            	<asp:HyperLink ID ="Hylblfilename" runat ="server" Text ="View" Target ="_blank"  Visible ="false" style="float:right"></asp:HyperLink>
                            	<asp:Label ID ="lblfilename11" runat ="server" ForeColor="Red" style="margin-left:23px;" Text="Please Upload .jpg,.gif,.png,.jpeg,.bmp File." ></asp:Label>
                            	<br />
                            	<asp:RequiredFieldValidator ID ="RequiredFieldValidator4" runat ="server" ControlToValidate ="UploadFile" Display ="Dynamic" ErrorMessage ="Please Upload Bill File"  ValidationGroup ="V"  style="padding-left:203px"></asp:RequiredFieldValidator>
                            	
                            </li>
                               <li  id ="liUnpaid" runat ="server"  visible ="false" >
                            	<label>Paid  Status :</label>
                            	<asp:DropDownList ID ="ddlpaidstatus" runat ="server" >
                            	<%--<asp:ListItem Text ="Select" Value ="-1"></asp:ListItem>--%>
                            	<asp:ListItem Text ="Unpaid" Value ="Unpaid"></asp:ListItem>
                            	<asp:ListItem Text ="Paid" Value ="Paid"></asp:ListItem>
                            	</asp:DropDownList>
                            	
                            </li>
                        </ul>
                    </section>
        </fieldset>
        <section class="save_bt_box">
                
                <asp:Button ID="btnSubmit" runat="server" Text="Save" onclick="btnSubmit_Click"  
                        ValidationGroup="V" ></asp:Button>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" onclick="btnCancel_Click" ></asp:Button>
                 <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            ShowMessageBox="True" ShowSummary="False"/>
        </section>
              	  </section>
    <section class="top_row" id="AddwaterSupply" runat="server" visible="false">
    <section class="elect_heading"><asp:Label  ID ="lbladdw" runat ="server"  Text ="Add" ></asp:Label>   Water Supply Charges</section>
              	    <fieldset>
            <section class="col1" style="width:60%">             
                    
                    	<ul>
                    	     <li>
                            	<label>Bill Amount (RS):</label>
                            	<asp:TextBox ID="txtwbillamount" runat="server" MaxLength ="8" ></asp:TextBox>
                            	<br />
                            	<asp:RequiredFieldValidator ID ="RequiredFieldValidator5" runat ="server" ControlToValidate ="txtwbillamount" Display ="Dynamic" ErrorMessage ="Please Enter Bill Amount"  ValidationGroup ="V" style="margin-left:66px;padding-left:150px;" ></asp:RequiredFieldValidator>
                            	
                            	 <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender65" ValidChars="1234567890."
                                            runat="server" Enabled="True" TargetControlID="txtwbillamount">
                                        </cc1:FilteredTextBoxExtender>
                            </li>
                    	  <li>
                            	<label>Bill Last Date :</label>
                            	   <script type="text/javascript">
                            	       function ShowDatePopup6() {
                            	           $find("<%= txtDate2.ClientID %>").showPopup();

                            	       }
                            	       function HideDatePopup6() {
                            	           $find("<%= txtDate2.ClientID %>").hidePopup();

                            	       }                                               
                                                </script>
             <telerik:RadDatePicker ID="txtDate2" onkeypress="return DisableKeys(event);"  style="width :180px; height:32px"
              runat="server" Skin="Hay" DateInput-CssClass="sortby" >
                                                    <DateInput  EmptyMessage ="Select Last Date">
                                                        <ClientEvents OnFocus="ShowDatePopup6"/>
                                                    </DateInput>
                                                    <Calendar ShowRowHeaders="false" DayNameFormat="FirstLetter" FirstDayOfWeek="Default" UseColumnHeadersAsSelectors="False" 
                                                        UseRowHeadersAsSelectors="False">

                                                        <SpecialDays >
                                                       
            <telerik:RadCalendarDay Repeatable="Today" ItemStyle-BackColor="Green"> 
            </telerik:RadCalendarDay> 
        
                                                        
                                                        </SpecialDays>
                                                    </Calendar>
                                                    <DatePopupButton Visible="False" />
                                                           
                                                </telerik:RadDatePicker>
                                                <br />
                                                <asp:RequiredFieldValidator ID ="RequiredFieldValidator6" runat ="server" ControlToValidate ="txtDate2" Display ="Dynamic" ErrorMessage ="Please Select Bill Last Date"  ValidationGroup ="V" style="margin-left:66px;padding-left:150px;" ></asp:RequiredFieldValidator>
                            </li>
                            
                            <li>
                            	<label>Late Fees (RS):</label>
                            	<asp:TextBox ID="txtwlatefee" runat="server" MaxLength ="8" ></asp:TextBox>
                            	<br />
                            	 <asp:RequiredFieldValidator ID ="RequiredFieldValidator7" runat ="server" ControlToValidate ="txtwlatefee" Display ="Dynamic" ErrorMessage ="Please Enter Late Fees"  ValidationGroup ="V" style="margin-left:66px;padding-left:150px;" ></asp:RequiredFieldValidator>
                            	  <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtendererte" ValidChars="1234567890."
                                            runat="server" Enabled="True" TargetControlID="txtwlatefee">
                                        </cc1:FilteredTextBoxExtender>
                            </li>
                            
                            <li>
                            	<label>Bill No :</label>
                            	<asp:TextBox ID="txtwbillno" runat="server" MaxLength ="20"></asp:TextBox>
                            	<br />
                            	<asp:RequiredFieldValidator ID ="RequiredFieldValidator8" runat ="server" ControlToValidate ="txtwbillno" Display ="Dynamic" ErrorMessage ="Please Enter Bill Number"  ValidationGroup ="V" style="margin-left:66px;padding-left:150px;" ></asp:RequiredFieldValidator>
                            </li>
                            
                            <li>
                            	<label>Bill Month :</label>
                            	<asp:DropDownList ID ="ddlmonthw" runat ="server" >
                              <asp:ListItem Value="January">January</asp:ListItem>
                              <asp:ListItem Value="February">February</asp:ListItem>
                              <asp:ListItem Value="March">March</asp:ListItem>
                              <asp:ListItem Value="April">April</asp:ListItem>
                              <asp:ListItem Value="May">May</asp:ListItem>
                              <asp:ListItem Value="June">June</asp:ListItem>
                              <asp:ListItem Value="July">July</asp:ListItem>
                              <asp:ListItem Value="August">August</asp:ListItem>
                              <asp:ListItem Value="September">September</asp:ListItem>
                              <asp:ListItem Value="October">October</asp:ListItem>
                              <asp:ListItem Value="November">November</asp:ListItem>
                              <asp:ListItem Value="December">December</asp:ListItem>
                            	</asp:DropDownList>
                            	
                            </li>
                            
                             <li>
                             
                            	<label>Bill Year :</label>
                            	<asp:DropDownList ID ="ddlyearw" runat ="server" >
                                
                              <asp:ListItem>2013</asp:ListItem>
                              <asp:ListItem>2014</asp:ListItem>
                              <asp:ListItem>2015</asp:ListItem>
                              <asp:ListItem>2016</asp:ListItem>
                              <asp:ListItem>2017</asp:ListItem>
                              <asp:ListItem>2018</asp:ListItem>
                              <asp:ListItem>2019</asp:ListItem>
                              <asp:ListItem>2020</asp:ListItem>
                            	</asp:DropDownList>
                            	
                            </li>
                             <li>
                            	<label>Upload Bill:</label>
                            	<asp:FileUpload ID ="FileuploadWater" runat ="server" style="margin-left:70px;"  />  &nbsp;&nbsp;  <br />
                                <asp:Label ID ="Label1" runat ="server" ForeColor="Red" style="margin-left:23px;" Text="Please Upload .jpg,.gif,.png,.jpeg,.bmp File." ></asp:Label>
                            	<asp:HyperLink ID ="Hyperwater" runat ="server" Text ="View" Target ="_blank"  Visible ="false" style="float:right"></asp:HyperLink>
                            	
                            	<br />
                            	<asp:RequiredFieldValidator ID ="RequiredFieldValidator9" runat ="server" ControlToValidate ="FileuploadWater" Display ="Dynamic" ErrorMessage ="Please Upload Bill File"  ValidationGroup ="V"  style="padding-left:203px"></asp:RequiredFieldValidator>
                            	
                            </li>
                             <li  id ="liWater1" runat ="server"  visible ="false" >
                            	<label>Paid  Status :</label>
                            	<asp:DropDownList ID ="ddlpaidstatuswater" runat ="server" >
                            	<%--<asp:ListItem Text ="Select" Value ="-1"></asp:ListItem>--%>
                            	<asp:ListItem Text ="Unpaid" Value ="Unpaid"></asp:ListItem>
                            	<asp:ListItem Text ="Paid" Value ="Paid"></asp:ListItem>
                            	</asp:DropDownList>
                            	
                            </li>
                        </ul>
                    </section>
        </fieldset>
        <section class="save_bt_box">
                
                <asp:Button ID="bensubmitClick" runat="server" Text="Save" onclick="bensubmitClick_Click"  
                        ValidationGroup="V" ></asp:Button>
                <asp:Button ID="benCancelClick" runat="server" Text="Cancel" onclick="benCancelClick_Click" ></asp:Button>
                
            
        </section>
              	  </section>
    <asp:HiddenField ID="HiddPaud" runat="server" />
    <asp:HiddenField ID="HidduploadeFile" runat="server" />
    <asp:HiddenField ID="hiddElectricID" runat="server" />
    <asp:HiddenField ID="HiddwaterID" runat="server" />
</asp:Content>
