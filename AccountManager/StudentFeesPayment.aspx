<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true"
    CodeFile="StudentFeesPayment.aspx.cs" Inherits="AccountManager_StudentFeesPayment" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="top_row">
                         <section class="achiv_toptitle">Student  <span> Fees And Payment</span></section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx" title="Back">BACK</a></section>
                            <section class="clear"></section>
                         </section>
    <section class="top_row">
    <asp:Button ID="Button1" runat="server" class="bt_sort" 
        Text="Sort" onclick="btnall_Click"></asp:Button>
                      <%--  <asp:Button ID="btnSort" runat="server" class="bt_sort" 
        Text="View" onclick="btnSort_Click"></asp:Button>--%>
        
         
                   	    <asp:DropDownList ID="ddlYear" runat="server" class="select_fy" style="width:120px!Important">
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
                        <asp:DropDownList ID="ddlMonth" runat="server" class="select_fy" style="width:125px!Important">
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
                            	                   
                            	           <asp:UpdatePanel ID="Panel" runat="server">
                                            <ContentTemplate>
                                                 <asp:DropDownList runat="server" CssClass="sortby" ID="ddlDivision" style="width:120px!Important">
                                                </asp:DropDownList>
                                                
                                                 <asp:DropDownList runat="server" ID="ddlStandard" CssClass="sortby" AutoPostBack="true"
                                                    OnSelectedIndexChanged="ddlStandard_SelectedIndexChanged" style="width:125px!Important">
                                                </asp:DropDownList>
                                                </ContentTemplate>
                                                 </asp:UpdatePanel>
                                                      <%--<asp:DropDownList runat="server" ID="ddlSchoolType" CssClass="sortby" AutoPostBack="true"
                                                    OnSelectedIndexChanged="ddlSchoolType_SelectedIndexChanged" style="width:120px!Important">
                                                    <asp:ListItem Text="Pre-Primary" Value="Pre-Primary"></asp:ListItem>
                                                </asp:DropDownList>--%>
                                                
                                                
                          <section class="clear"></section>
                         </section>
    <asp:GridView ID="grdFeesPayment" runat="server" OnRowEditing="grdFeesPayment_EditRow"
        OnRowUpdating="grdFeesPayment_UpdateRow" OnRowCancelingEdit="grdFeesPayment_CancelEditRow"
        CellPadding="15" Width="100%" EmptyDataText="No Record Exists" AutoGenerateColumns="false"
        GridLines="None" HeaderStyle-HorizontalAlign="Left" CssClass="time_table" 
        PageSize="15" AllowPaging="true"
        HeaderStyle-VerticalAlign="Top" 
        onpageindexchanging="grdFeesPayment_PageIndexChanging">
        <RowStyle HorizontalAlign="Left" />
        <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="Red"
            Font-Size="14px"></EmptyDataRowStyle>
        <Columns>
            <asp:TemplateField HeaderText="SR No." HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <asp:Label ID="lblSrNo" runat="server" Text="<%# Container.DataItemIndex + 1 %>"></asp:Label>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Name">
                <ItemTemplate>
                    <asp:Label ID="lblStudentName" runat="server" Text='<%# Bind("UserName") %>'></asp:Label>
                    <asp:Label ID="lblStudentLoginId" runat="server" Text='<%# Bind("SD_loginId") %>'
                        Visible="false"></asp:Label>
                    <asp:Label ID="ldlStudentStandardId" runat="server" Text='<%# Bind("SD_SchoolCategoryId") %>'
                        Visible="false"></asp:Label>
                    <asp:Label ID="ldlStudentDivisionId" runat="server" Text='<%# Bind("SD_SchoolSubCatId") %>'
                        Visible="false"></asp:Label>
                    <asp:Label ID="lblDetailsId" runat="server" Text='<%# Bind("SFP_DetailsId") %>' Visible="false"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Standard" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <asp:Label ID="lblStandard" runat="server" Text='<%# Bind("SC_CategoryName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Division" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <asp:Label ID="lblDivision" runat="server" Text='<%# Bind("SSC_SubCategoryName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Month" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <asp:Label ID="lblMonth" runat="server" Text='<%# Bind("SFP_Month") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Year" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <asp:Label ID="lblYear" runat="server" Text='<%# Bind("SFP_Year") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Total Fees" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <asp:Label ID="lblTotalFees" runat="server" Text='<%# Bind("SFP_TotalFees") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtTotalFees" runat="server" MaxLength="10" Text='<%# Eval("SFP_TotalFees") %>' />
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTotalFees"
                        ErrorMessage="Please Enter Total Fees!" Display="Dynamic" ValidationGroup="V"></asp:RequiredFieldValidator>
                    <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" Enabled="True"
                        ValidChars="0123456789" TargetControlID="txtTotalFees">
                    </cc1:FilteredTextBoxExtender>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Fees Paid" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <asp:Label ID="lblFeesPaid" runat="server" Text='<%# Bind("SFT_PaidFees") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtFeesPaid" runat="server" MaxLength="10" Text='<%# Eval("SFT_PaidFees") %>' />
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldtxtFeesPaid" runat="server" ControlToValidate="txtFeesPaid"
                        ErrorMessage="Please Enter Total Fees!" Display="Dynamic" ValidationGroup="V"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtFeesPaid"
                        ErrorMessage="Must Be less Than or equal To Total Fees " Operator="LessThanEqual"
                        Type="Double" ValidationGroup="V" ControlToCompare="txtTotalFees" />
                    <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtenderFeesPaid" runat="server"
                        Enabled="True" ValidChars="0123456789" TargetControlID="txtFeesPaid">
                    </cc1:FilteredTextBoxExtender>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Balance Fees" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <asp:Label ID="lblRemainingFees" runat="server" Text='<%# Bind("SFP_RemainingFees") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" CommandName="Edit" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="lnkUpdate" runat="server" Text="Update" CommandName="Update"
                        ValidationGroup="V" />
                    <asp:LinkButton ID="lnkCancel" runat="server" Text="Cancel" CommandName="Cancel" />
                </EditItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:HiddenField ID="HiddenType" runat="server" />
</asp:Content>
