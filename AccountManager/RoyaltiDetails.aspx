<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="RoyaltiDetails.aspx.cs" Inherits="AccountManager_RoyaltiDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section class="top_row bottom_bor">
   <section class="achiv_toptitle">Royalty <span>Details</span></section>
    <section class="top_row_back"><a href="AccountManagerDashboard.aspx">BACK</a></section>
    <section class="clear"></section>
                        <section id="dvMsg" runat="server" visible="false" style="width: -2px;">
                            <asp:Label ID="lblMessage" runat="server"></asp:Label>
                            <section class="clear"></section>
                            </section>
</section>
                     <section class="tab_nav">
                           <ul>
                               <li class="ui-state-default ui-corner-top ui-tabs-selected ui-state-active" id="liOneTimeRoy" runat="server"  style="width:147px!important;" ><a href="#" id="hrefOneTimeRoyalty" runat="server" onserverclick="OneTimeRoyalty">One Time Royalty</a></li>
                               <li id="liMonthlyRoy" runat="server">
                               <a id="hrefMonthlyRoyalty" href="#" runat="server" onserverclick="MonthlyRoyalty" > Monthly Royalty</a></li>
                               <section class="clear"></section>
                           </ul>
                          
                       </section>
                         <section class="clear"></section>
                       <section id="secOneTimeRoyalty" runat="server" style="display:block;">
                        
                          <section id="secViewOneTimeRoyalty" runat="server">
                                 <section class="save_bt_box_small rF" style="margin-bottom:10px;">
                                       <asp:Button ID="btnAddOneTimeRoyalty" runat="server"   style="width:194px!important;"  Text="Add One Time Royalty" onclick="btnAddOneTimeRoyalty_Click"></asp:Button> 
                                        <section class="clear"></section>                                              
                                  </section>
                                  <section class="clear"></section>
                                <asp:GridView ID="grdOneTimeRoyaltyDetails" 
        runat="server" AutoGenerateColumns="False" CssClass="billing_invoic" Width="98%" 
                                        EmptyDataRowStyle-VerticalAlign="Middle" 
        EmptyDataText="No Record Found" EmptyDataRowStyle-ForeColor="Red" 
        EmptyDataRowStyle-HorizontalAlign="Left" CellPadding="4" GridLines="None" 
        AllowSorting="True"  AllowPaging="true" PageSize="12" 
        onpageindexchanging="grdOneTimeRoyaltyDetails_PageIndexChanging">
                                        <Columns>
                                       <asp:TemplateField HeaderText="SR.No." HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblRoyaltyId" runat="server" Text='<%# Bind("RD_RoyaltyId") %>' Visible="false"></asp:Label>                                                    
                                                       <asp:Label ID="lblSrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                       
                                             <asp:TemplateField HeaderText="Admission Charges" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblAdmissionCharges" runat="server" Text='<%# Bind("RD_AdmissionCharges") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                           <asp:TemplateField HeaderText="Annual Charges" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblAnnualCharges" runat="server" Text='<%# Bind("RD_AnnualCharges") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Registration Charges" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblRegistrationCharges" runat="server" Text='<%# Bind("RD_RegistrationCharges") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Student Kits Charges" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblStudentCharges" runat="server" Text='<%# Bind("RD_StudentKitCharges") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Uniforms Charges" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblUniformsCharges" runat="server" Text='<%# Bind("RD_UniformCharges") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Annual Day Charges" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblAnnualDayCharges" runat="server" Text='<%# Bind("RD_AnnualDayCharges") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Sport Day Charges" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblSportCharges" runat="server" Text='<%# Bind("RD_SportDayCharges") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Portfolio Charges" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblPortfolioCharges" runat="server" Text='<%# Bind("RD_PortfolioCharges") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField> 
                                             <asp:TemplateField HeaderText="Mis. Expenses" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblMisExpenses" runat="server" Text='<%# Bind("RD_MixExpensesCharges") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField> 
                                            <asp:TemplateField HeaderText="Transaction Date" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblMisExpenses" runat="server" Text='<%# Bind("RD_Date","{0:dd MMM yyyy}") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField> 
                                        </Columns>
                                        </asp:GridView>  
                          
                          </section>
                          <section  class="tabsec_topsecn" style="background:none!important;display:none;" id="secAddOneTimeRoyalty" runat="server">           
                               <fieldset>                                  
                                    <ul>
                                      <li> <label>Admission Charges :</label><asp:TextBox ID="txtAdmissionCharges" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Annual Charges :</label><asp:TextBox ID="txtAnnualCharges"  style="float:left;" Width="220px" runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Registration Charges :</label><asp:TextBox ID="txtRegistrationCharges" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Student Kits Charges :</label><asp:TextBox ID="txtStudentKitsCharges" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Uniforms Charges :</label><asp:TextBox ID="txtUniformsCharges" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Annual Day Charges :</label><asp:TextBox ID="txtAnnualDayCharges" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Sport Day Charges :</label><asp:TextBox ID="txtSportDayCharges" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Portfolio Charges :</label><asp:TextBox ID="txtPortfolioCharges" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Mis. Expenses :</label><asp:TextBox ID="txtMisExpenses" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                    <section class="save_bt_box_small lF" style="margin:0px 160px 8px 275px;">
                                       <asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click"></asp:Button>
                                         <asp:Button ID="btnCancel" runat="server" Text="Cancel" onclick="btnCancel_Click"></asp:Button>
                                     </section>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender1" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtAdmissionCharges" >
                                      </cc1:filteredtextboxextender>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender2" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtAnnualCharges" >
                                      </cc1:filteredtextboxextender>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender3" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtRegistrationCharges" >
                                      </cc1:filteredtextboxextender>
                                       <cc1:filteredtextboxextender id="FilteredTextBoxExtender4" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtStudentKitsCharges" >
                                      </cc1:filteredtextboxextender>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender5" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtUniformsCharges" >
                                      </cc1:filteredtextboxextender>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender6" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtAnnualDayCharges" >
                                      </cc1:filteredtextboxextender>
                                       <cc1:filteredtextboxextender id="FilteredTextBoxExtender7" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtSportDayCharges" >
                                      </cc1:filteredtextboxextender>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender8" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtPortfolioCharges" >
                                      </cc1:filteredtextboxextender>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender9" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtMisExpenses" >
                                      </cc1:filteredtextboxextender>
                                    </ul>                                   
                                </fieldset>
                           </section>
                          </section>             
                       <section id="secMonthlyRoyalty" runat="server" style="display:none;">
                               <section id="secViewMonthlyRoyalty" runat="server">
                                  <section class="save_bt_box_small rF" style="margin-bottom:10px;margin-left:20px;">
                                       <asp:Button ID="Button1" runat="server" Text="Add Monthly Royalty" onclick="btnMonthlyRoyalty_Click"></asp:Button>    
                                       <section class="clear"></section>        
                                  </section>                                 
                                      <asp:DropDownList ID="ddlMonthlyRoyaltyYear" OnSelectedIndexChanged="ddlMonthlyRoyaltyYear_SelectedIndexChanged" AutoPostBack="true" runat="server" CssClass=" select rF">
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
                                  <section class="clear"></section>
                                     <asp:GridView ID="grdMontlyRoyalty" 
        runat="server" AutoGenerateColumns="False" CssClass="billing_invoic" Width="98%" 
                                        EmptyDataRowStyle-VerticalAlign="Middle" 
        EmptyDataText="No Record Found" EmptyDataRowStyle-ForeColor="Red" 
        EmptyDataRowStyle-HorizontalAlign="Left" CellPadding="4" GridLines="None" 
        AllowSorting="True"  AllowPaging="true" PageSize="12" 
        onpageindexchanging="grdMontlyRoyalty_PageIndexChanging">
                                        <Columns>
                                       <asp:TemplateField HeaderText="SR.No." HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblRoyaltyId" runat="server" Text='<%# Bind("RD_RoyaltyId") %>' Visible="false"></asp:Label>                                                    
                                                       <asp:Label ID="lblSrNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                           <asp:TemplateField HeaderText="Month Name" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblMonth" runat="server" Text='<%# Bind("RD_Month") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Year" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblYear" runat="server" Text='<%# Bind("RD_Year") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Tution Fees" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblAdmissionCharges" runat="server" Text='<%# Bind("RD_TutionFees") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                           <asp:TemplateField HeaderText="Day Care Charges" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblAnnualCharges" runat="server" Text='<%# Bind("RD_DayCareCharges") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Meal Charges" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblRegistrationCharges" runat="server" Text='<%# Bind("RD_MealCharges") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Transportation Charges" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblStudentCharges" runat="server" Text='<%# Bind("RD_TransportationCharges") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Activity Charges" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblUniformsCharges" runat="server" Text='<%# Bind("RD_ActivityCharges") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="NTT Fees" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblAnnualDayCharges" runat="server" Text='<%# Bind("RD_NTTFees") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="CTET Coaching Charges" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblSportCharges" runat="server" Text='<%# Bind("RD_CTETCoaching") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Foreign Language Fees" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblPortfolioCharges" runat="server" Text='<%# Bind("RD_ForeignLanFees") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField> 
                                             <asp:TemplateField HeaderText="Mis. Expenses" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblMisExpenses" runat="server" Text='<%# Bind("RD_MisExpenses") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField> 
                                            <asp:TemplateField HeaderText="Transaction Date" HeaderStyle-HorizontalAlign="Left">
                                                <ItemTemplate>
                                                    <asp:Label ID ="lblMisExpenses" runat="server" Text='<%# Eval("RD_Date","{0:dd MMM yyyy}") %>'></asp:Label>                            
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                            </asp:TemplateField> 
                                        </Columns>
                                     </asp:GridView> 
                               </section>
                               <fieldset id="secAddMonthlyRoyalty" runat="server">
                                  <section class="teac_edit_form">
                                    <ul>
                                    <li><label>Select Month :</label>
                                                    <asp:DropDownList ID="ddlMonth" runat="server" style="float:left;" Width="220px">
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
                            	                   </asp:DropDownList></li>
                                    <li> <label>Select Year :</label>
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
                            	                   </asp:DropDownList></li>
                                      <li> <label>Tution Fees :</label><asp:TextBox ID="txtTutionFees" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Day Care Charges :</label><asp:TextBox ID="txtDayCareCharges"  style="float:left;" Width="220px" runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Meal Charges :</label><asp:TextBox ID="txtMealCharges" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Transportation Charges :</label><asp:TextBox ID="txtTransportationCharges" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Activity Charges :</label><asp:TextBox ID="txtActivityCharges" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>NTT Charges :</label><asp:TextBox ID="txtNTTCharges" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>CTET Coaching Charges :</label><asp:TextBox ID="txtCTETCharges" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Foreign Languages Fees :</label><asp:TextBox ID="txtForeignLanFees" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                      <li> <label>Mis. Expenses :</label><asp:TextBox ID="txtMisMonthlyExpenses" style="float:left;" Width="220px"  runat="server" Text="0"></asp:TextBox></li>
                                     <section class="save_bt_box_small lF" style="margin:0px 160px 8px 275px;">
                                       <asp:Button ID="btnMonthlySubmit" runat="server" Text="Submit" onclick="btnMonthlySubmit_Click"></asp:Button>
                                       <asp:Button ID="btnMonthlyCancel" runat="server" Text="Cancel" onclick="btnMonthlyCancel_Click"></asp:Button>
                                     </section>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender10" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtTutionFees" >
                                      </cc1:filteredtextboxextender>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender11" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtDayCareCharges" >
                                      </cc1:filteredtextboxextender>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender12" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtMealCharges" >
                                      </cc1:filteredtextboxextender>
                                       <cc1:filteredtextboxextender id="FilteredTextBoxExtender13" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtTransportationCharges" >
                                      </cc1:filteredtextboxextender>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender14" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtActivityCharges" >
                                      </cc1:filteredtextboxextender>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender15" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtNTTCharges" >
                                      </cc1:filteredtextboxextender>
                                       <cc1:filteredtextboxextender id="FilteredTextBoxExtender16" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtCTETCharges" >
                                      </cc1:filteredtextboxextender>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender17" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtForeignLanFees" >
                                      </cc1:filteredtextboxextender>
                                      <cc1:filteredtextboxextender id="FilteredTextBoxExtender18" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtMisMonthlyExpenses" >
                                      </cc1:filteredtextboxextender>
                                    </ul>
                                   </section>
                                </fieldset>
                       </section>
</asp:Content>

