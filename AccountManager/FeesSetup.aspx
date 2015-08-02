<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master"
    AutoEventWireup="true" CodeFile="FeesSetup.aspx.cs" Inherits="AccountManager_FeesSetup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <asp:GridView ID="grdFeesSetup" runat="server" DataKeyNames="FeesSetupID" OnRowEditing="grdFeesSetup_EditRow"
        OnRowUpdating="grdFeesSetup_UpdateRow" OnRowCancelingEdit="grdFeesSetup_CancelEditRow"
        CellPadding="15" Width="100%" EmptyDataText="No Record Exists" AutoGenerateColumns="false"
        GridLines="None" HeaderStyle-HorizontalAlign="Left" CssClass="time_table" PageSize="5"
        AllowPaging="true" HeaderStyle-VerticalAlign="Top" OnPageIndexChanging="grdFeesSetup_PageIndexChanging"
        OnRowCommand="grdFeesSetup_RowCommand" OnRowDeleting="grdFeesSetup_RowDeleting"
        ShowFooter="True">
        <RowStyle HorizontalAlign="Left" />
        <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="Red"
            Font-Size="14px"></EmptyDataRowStyle>
        <Columns>
            <asp:TemplateField HeaderText="Sr No." HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <asp:Label ID="lblSrNo" runat="server" Text="<%# Container.DataItemIndex + 1 %>"></asp:Label>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Class">
                <EditItemTemplate>
                    <asp:DropDownList CausesValidation="True" ID="drpSchoolCategoryName" AutoPostBack="True"
                        runat="server" DataSource='<%#GetSchoolCategory() %>' OnSelectedIndexChanged="drpSchoolCategory_SelectedIndexChanged"
                        DataTextField="SC_CategoryName" DataValueField="SC_CategoryId" SelectedValue='<%# Eval("SC_CategoryId") %>' />
                    <asp:RequiredFieldValidator InitialValue="0" ID="rfvSchoolCategory" runat="server"
                        ControlToValidate="drpSchoolCategoryName" Text="*" ValidationGroup="vupdate" />
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="drpSchoolCategoryName"
                        ErrorMessage="Entry Found" Display="Static" OnServerValidate="CheckDuplicateUpdate" ValidationGroup="vupdate" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblSchoolCategoryName" runat="server" Text='<%# Bind("SC_CategoryName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:DropDownList CausesValidation="True" ID="drpNewdrpSchoolCategory" runat="server"
                        DataSource='<%#GetSchoolCategory() %>' OnSelectedIndexChanged="drpSchoolCategoryNew_SelectedIndexChanged"
                        AutoPostBack="True" DataTextField="SC_CategoryName" DataValueField="SC_CategoryId" />
                    <asp:RequiredFieldValidator InitialValue="0" ID="rfvNewSchoolCategorye" runat="server"
                        ControlToValidate="drpNewdrpSchoolCategory" Text="*" ValidationGroup="vinsert" />
                    <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="drpNewdrpSchoolCategory"
                        ErrorMessage="Entry Found" Display="Static" OnServerValidate="CheckDuplicateInsert" ValidationGroup="vinsert" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Division">
                <EditItemTemplate>
                    <asp:DropDownList CausesValidation="True" ID="drpSchoolSubCategoryName" runat="server" >
                                            <asp:ListItem Value="0">Select</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator InitialValue="0" ID="rfvSchoolSubCategoryName" runat="server"
                        ControlToValidate="drpSchoolSubCategoryName" Text="*" ValidationGroup="vupdate" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblSchoolSubCategoryName" runat="server" Text='<%# Bind("SSC_SubCategoryName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:DropDownList CausesValidation="True" ID="drpNewSchoolSubCategoryName" runat="server">
                        <asp:ListItem Value="0">Select</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator InitialValue="0" ID="rfvNewSchoolSubCategoryName" runat="server"
                        ControlToValidate="drpNewSchoolSubCategoryName" Text="*" ValidationGroup="vinsert" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Fee Category Name">
                <EditItemTemplate>
                    <asp:DropDownList CausesValidation="True" ID="drpFeeCategoryName" runat="server" AutoPostBack="True" 
                        DataSource='<%#GetFeeCategoryNames() %>' DataTextField="FeeCategoryName" DataValueField="FeeCategoryID"
                        SelectedValue='<%# Eval("FeeCategoryID") %>' OnSelectedIndexChanged="drpFeeCategoryName_SelectedIndexChanged" />
                    <asp:RequiredFieldValidator InitialValue="0" ID="rfvFeeCategoryName" runat="server"
                        ControlToValidate="drpFeeCategoryName" Text="*" ValidationGroup="vupdate" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblFeeCategoryName" runat="server" Text='<%# Bind("FeeCategoryName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:DropDownList CausesValidation="True" ID="drpNewFeeCategoryName" runat="server" AutoPostBack="True"
                        DataSource='<%#GetFeeCategoryNames() %>' DataTextField="FeeCategoryName" DataValueField="FeeCategoryID" OnSelectedIndexChanged="drpNewFeeCategoryName_SelectedIndexChanged" />
                    <asp:RequiredFieldValidator InitialValue="0" ID="rfvNewFeeCategoryName" runat="server"
                        ControlToValidate="drpNewFeeCategoryName" Text="*" ValidationGroup="vinsert" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Fee Head Name">
                <EditItemTemplate>
                    <asp:DropDownList CausesValidation="True" ID="drpFeeHeadName" runat="server" >
                                            <asp:ListItem Value="0">Select</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvFeeHeadName" runat="server" ControlToValidate="drpFeeHeadName"
                        Text="*" ValidationGroup="vupdate" InitialValue="0" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblFeeHeadName" runat="server" Text='<%# Bind("FeeHeadName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:DropDownList CausesValidation="True" ID="drpNewFeeHeadName" runat="server" >
                                            <asp:ListItem Value="0">Select</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvNewFeeHeadName" runat="server" ControlToValidate="drpNewFeeHeadName"
                        Text="*" ValidationGroup="vinsert" InitialValue="0" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Fee Term">
                <EditItemTemplate>
                    <asp:DropDownList CausesValidation="True" ID="drpFeeTerm" runat="server" >
                                            <asp:ListItem Value="0">Select</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvFeeHeadName" runat="server" ControlToValidate="drpFeeTerm"
                        Text="*" ValidationGroup="vupdate" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblFeeHeadName" runat="server" Text='<%# Bind("FeesTerm") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:DropDownList CausesValidation="True" ID="drpNewFeeTerm" runat="server" >
                                            <asp:ListItem Value="0">Select</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvNewFeeTerm" runat="server" ControlToValidate="drpNewFeeTerm"
                        Text="*" ValidationGroup="vinsert" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Fees Amount">
                <EditItemTemplate>
                    <asp:TextBox ID="txtFeesAmount" runat="server" Text='<%#Eval("FeesAmount") %>' />
                    <asp:RequiredFieldValidator ID="rfvFeesAmount" runat="server" ControlToValidate="txtFeesAmount"
                        Text="*" ValidationGroup="vupdate" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblFeesAmount" runat="server" Text='<%# Bind("FeesAmount") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtNewFeesAmount" runat="server" Text='<%#Eval("FeesAmount") %>' />
                    <asp:RequiredFieldValidator ID="rfvNewFeesAmount" runat="server" ControlToValidate="txtNewFeesAmount"
                        Text="*" ValidationGroup="vinsert" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" CommandName="Edit" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="lnkUpdate" runat="server" Text="Update" CommandName="Update"
                        ValidationGroup="vupdate" />
                    <asp:LinkButton ID="lnkCancel" runat="server" Text="Cancel" CommandName="Cancel" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:LinkButton ID="lnkInsert" runat="server" Text="Add" CommandName="AddNew" ValidationGroup="vinsert" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" CommandName="Delete"
                        OnClientClick="javascript:return confirm('Are you sure you want to delete?')" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
