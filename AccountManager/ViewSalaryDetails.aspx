<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="ViewSalaryDetails.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_ViewSalaryDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <section class="top_row bottom_bor">
                          <section class="achiv_toptitle">Teacher <span>and staff salary</span></section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx">BACK</a></section>
                          <section class="clear"></section>
                         </section>
                         
                          <section class="top_row bottom_bor">             
                          <div id="dvMsg" runat="server" visible="false">
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </div>
                         </section>
             		     <section class="accountant_nav_wrap" style="width:373px;">
                        	<ul>
                            	<li id="tc"><a class="active"  id ="aTeachersDetaitls" runat ="server" href="TeacherSalaryDetails.aspx">Teachers Details</a></li>
                                <li id="td"><a   id ="aStaffDetails" runat ="server" href="StaffSalaryDetails.aspx">Staff Details</a></li>
                               <%--  <li id="ld"><a  id="aPrincipalDetails"  runat="server" href="PrincipalSalaryDetails.aspx">Principal Details</a></li>
                               <<li id="ld"><a href="javascript:;">Nanny Details</a></li>
                                <li id="labo"><a href="javascript:;">School Gaurd</a></li>--%>
                                <section class="clear"></section>
                            </ul>
                         </section>   
                                  
                            <!-- Right Content Start -->
                           <section class="tab_nav">
                              <ul class="ui-tabs-nav ui-helper-reset ui-helper-clearfix ui-widget-header ui-corner-all">
       <li class="ui-state-default ui-corner-top"><a  href="MyAccount.aspx">General Details</a></li>
             <li class="ui-state-default ui-corner-top   ui-tabs-selected ui-state-active" ><a class="active"  href="ViewSalaryDetails.aspx">Salary Details</a></li>
             <%-- <li class="ui-state-default ui-corner-top"><a href="ViewLeaveDetails.aspx">Leave Details</a></li>--%>
              <li class="ui-state-default ui-corner-top"><a href="AttachmentDetails.aspx">Attach Documents</a></li>
                                    <section class="clear"></section>
                                </ul>
                            </section>
                            <br />
                             <span style="float:right ">

                          <asp:Button ID="btnAdd" runat="server" Text="Add Salary Details" OnClick="btnAddSalary_Click"  CssClass ="yellow_btnSalaryDetails"/>  
                          </span> 
                      <section  id="SectionViewSalary" runat="server" class="right_content tabsec_topsecn " style="width:690px!important;" >
                    

                        <span style="float:right ">   <asp:Button ID="btnView" runat="server" Text="View Salary Details" OnClick="btnViewSalary_Click" CssClass ="yellow_btnSalaryDetails" />  </span>


                             <span>
                    
                   <asp:DropDownList ID="ddlYear1" runat="server" CssClass ="sortby" style="float:right">
                     <asp:ListItem Value="-1" >Select Year</asp:ListItem>
                   
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
                 </span>

                                 <asp:DropDownList  ID ="ddlMonth1" runat ="server" CssClass ="sortby" style="float:right">
                                     <asp:ListItem Value="-1" >Select Month</asp:ListItem>
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
               
             
                 <br/>
                 <br/>
                                <asp:GridView ID="grdSalary" runat="server" 
        AutoGenerateColumns="False" CssClass="billing_invoic" Width="98%" onrowdatabound="grdSalary_RowDataBound" 
                    OnPageIndexChanging="grdSalary_PageIndexChanging"  onrowdeleting="grdSalary_RowDeleting"
        EmptyDataRowStyle-VerticalAlign="Middle" EmptyDataText="No Record Found" EmptyDataRowStyle-ForeColor="Red"
                    EmptyDataRowStyle-HorizontalAlign="Left" CellPadding="4" GridLines="None"
                    AllowSorting="True"  AllowPaging="true" PageSize="12">
                    <Columns>
                  <asp:TemplateField HeaderText="Month" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                <asp:Label ID="lblMonth" runat="server" Text='<%# Bind("SI_Month") %>'></asp:Label>
                                <asp:Label ID="lblSalaryDetailsId" runat="server" Text='<%# Bind("SI_DetailsId") %>' Visible="false"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                       
                         <asp:TemplateField HeaderText="Teacher Name" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                <asp:Label ID="lblName" runat="server" Text='<%# Bind("FacultyName") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Gross Salary" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                   <asp:Label ID="lblGrossSalary" runat="server" Text='<%# Bind("SI_GrossSalary") %>'></asp:Label>               
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Leave Count" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                 <asp:Label ID="lblLeaveCount" runat="server" Text='<%# Bind("SI_LeaveCount") %>'></asp:Label>                     
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                         <asp:TemplateField HeaderText="Leave Deduction Amount" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                   <asp:Label ID="lblDeductionAmount" runat="server" Text='<%# Bind("SI_LeaveDeductionAmount") %>'></asp:Label>                  
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField> 
                        
                         <asp:TemplateField HeaderText="Net Salary" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                  <asp:Label ID="lblBasicSalary" runat="server" Text='<%# Bind("NetSalary") %>'></asp:Label>               
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                        
                         <asp:TemplateField HeaderText="Edit" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                   <asp:HyperLink ID="hlnkView" runat="server" CssClass="" 
                                   ImageUrl="~/img/icon_edit.png" 
                                   NavigateUrl='<%# Eval("SI_DetailsId","ViewSalaryDetails.aspx?var=edit&SI_DetailsId={0}") %>' TabIndex="6" 
                                   ToolTip="Edit Salary"></asp:HyperLink>                 
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                        
                         <asp:TemplateField HeaderText="Delete" HeaderStyle-HorizontalAlign="Left">
                            <ItemTemplate>
                                 <asp:ImageButton ID="IblDelete" runat="server" CommandName="Delete" ToolTip="Delete Salary Details"
                                OnClientClick="javascript:return confirm('Do you want to delete the record?');"
                                ImageUrl="~/img/icon-delete.png"  />             
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                        </asp:TemplateField>
                        
                        
                       
                    </Columns>
                    </asp:GridView>    
                       </section>  
                            <section id="SectionAddSalary" runat="server"  class="right_content tabsec_topsecn " style="width:690px!important;">
                                <section class="font14 textbold yellowtext">Pay-Period & Salary</section>
                                     <section class="newform">
                                      <dl class="marginbot_20">                                      
                                       <section class="schedulebx">
                                         <span>  <asp:RadioButton  ID="rbtmonth" runat ="server"  Text ="Monthly" Checked ="true" GroupName ="Type"  />   
                                         <asp:RadioButton  ID="rbtYear" runat ="server"  Text ="Yearly" GroupName ="Type" /></span>
                                         <section class="clear"></section>
                                       </section>                                         
                                      </dl>
                                      
                                             <dl>
                                       <dt>Month</dt>
                                       <dd>
                                       <asp:DropDownList  ID ="ddlMonth" runat ="server" CssClass ="select">
                                   <%--  <asp:ListItem Value="-1" >Select Month</asp:ListItem>--%>
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
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ForeColor="Red"
             ErrorMessage="Required" ControlToValidate="ddlMonth" ValidationGroup="sub" InitialValue="-1"></asp:RequiredFieldValidator>
                                    </dd>
                                      </dl> 
                                      
                                      <dl>
                                       <dt>Year</dt>
                                       <dd>
                                       <asp:DropDownList  ID ="ddlYear" runat ="server"  CssClass ="select">
                                       <%--<asp:ListItem Value="-1" >Select Year</asp:ListItem>--%>
                                       
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
                                       <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ForeColor="Red"
             ErrorMessage="Required" ControlToValidate="ddlYear" ValidationGroup="sub" InitialValue="-1"></asp:RequiredFieldValidator>
                                    </dd>
                                      </dl> 
                                      
                                                                            
                                    
                                      
                                        <dl>
                                       <dt>Gross Salary (Per Month)</dt>
                                       <dd>
                                       <asp:TextBox  ID ="txtGrossSalary" runat ="server" CssClass ="input" MaxLength ="8" ></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtGrossSalary" SetFocusOnError="true"
  ValidationGroup="sub"></asp:RequiredFieldValidator>
  <cc1:filteredtextboxextender id="FilteredTextBoxExtender2" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtGrossSalary" >
  </cc1:filteredtextboxextender>
                                    </dd>
                                      </dl> 
                                      
                                       <dl>
                                       <dt>Leave Count</dt>
                                       <dd>
                                       <asp:TextBox  ID ="txtLeaveCount" runat ="server" CssClass ="input" MaxLength ="8" ></asp:TextBox>
                                       <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtLeaveCount" SetFocusOnError="true"
  ValidationGroup="sub"></asp:RequiredFieldValidator>
  <cc1:filteredtextboxextender id="FilteredTextBoxExtender3" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtLeaveCount" >
  </cc1:filteredtextboxextender>
                                       
                                    </dd>
                                      </dl> 
                                      
                                       <dl>
                                       <dt>Leave Deduction Amount</dt>
                                       <dd>
                                       <asp:TextBox  ID ="txtDeductionAmt" runat ="server" CssClass ="input"  MaxLength ="8" ></asp:TextBox>
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtDeductionAmt" SetFocusOnError="true"
  ValidationGroup="sub"></asp:RequiredFieldValidator>
  <cc1:filteredtextboxextender id="FilteredTextBoxExtender4" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtDeductionAmt" >
  </cc1:filteredtextboxextender>
                                    </dd>
                                      </dl> 
                                      
                                      <%--  <dl>
                                       <dt>Net Salary (Per Month)</dt>
                                       <dd>
                                       <asp:TextBox  ID ="txtBasicSalary" runat ="server" CssClass ="input" MaxLength ="8" ></asp:TextBox>
                                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtBasicSalary" SetFocusOnError="true"
  ValidationGroup="sub"></asp:RequiredFieldValidator>
  <cc1:filteredtextboxextender id="FilteredTextBoxExtender1" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtBasicSalary" >
  </cc1:filteredtextboxextender>
                                    </dd>
                                      </dl>  
                                      --%>
                                    
                                     <dl>
                                       <dt>Salary Status</dt>
                                       <dd>
                                        <asp:DropDownList  ID ="ddlSalaryStatus" runat ="server" CssClass ="select">
                                   <%--  <asp:ListItem Value="-1" >Select Status</asp:ListItem>--%>
                                    <asp:ListItem Text="Paid" Value="Paid"></asp:ListItem>
                                     <asp:ListItem Text="Unpaid" Value="Unpaid"></asp:ListItem>
                                     </asp:DropDownList>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ForeColor="Red"
             ErrorMessage="Required" ControlToValidate="ddlSalaryStatus" ValidationGroup="sub" InitialValue="-1"></asp:RequiredFieldValidator>
                                    </dd>
                                      </dl>    
                                      
                                      
                                      </section>
                                    <section class="border marginbot_10" ></section>                            
                                    <!--Buttons-->
                                    <section  style="text-align:left;float:left ">
                                        <span  >
                                          <asp:Button ID ="btncancel" 
        runat ="server" Text ="Close" CssClass ="gry_btn btnpad" 
        onclick="btncancel_Click" /></span>
                              
                                         <span>
                                        <asp:Button ID ="btnsave" runat ="server" 
        Text ="Save" CssClass ="yellow_btn btnpad" onclick="btnsave_Click" ValidationGroup="sub" />
                                        </span>
                                         <section class="clear"></section>
                                       </section>
                                        
                               </section>
                            <!-- Right Content End -->
                            <asp:HiddenField ID ="HiddenSalaryId" runat ="server" />
</asp:Content>

