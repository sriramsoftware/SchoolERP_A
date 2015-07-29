<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true"
    CodeFile="FeesCategories.aspx.cs" Inherits="AccountManager_FeesCategories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="top_row">
                         <section class="achiv_toptitle">Fees Categories</section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx" title="Back">BACK</a></section>
                            <section class="clear"></section>
                             
    </section>
    <div style="text-align:center">
        <section>Fees Category:<asp:TextBox ID="txtFeesCategorySearch" ClientIDMode="Static" runat="server"  /></section>
        
        <section><asp:Button runat="server" ID="btnSearchFeeCategory" OnClick="btnSearchFeeCategory_Click" Text="Search"/><asp:Button runat="server" ID="btnClearSearch" OnClick="btnClearSearch_Click" Text="Clear"/></section>
    </div>
    <asp:GridView ID="grdFeesCategory" runat="server" DataKeyNames="FeeCategoryID" OnRowEditing="grdFeesCategory_EditRow"
        OnRowUpdating="grdFeesCategory_UpdateRow" OnRowCancelingEdit="grdFeesCategory_CancelEditRow"
        CellPadding="15" Width="100%" EmptyDataText="No Record Exists" AutoGenerateColumns="false"
        GridLines="None" HeaderStyle-HorizontalAlign="Left" CssClass="time_table" PageSize="5"
        AllowPaging="true" HeaderStyle-VerticalAlign="Top" OnPageIndexChanging="grdFeesCategory_PageIndexChanging"
        OnRowCommand="grdFeesCategory_RowCommand" OnRowDeleting="grdFeesCategory_RowDeleting"
        ShowFooter="true">
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
            <asp:TemplateField HeaderText="Fee Category Name">
                <EditItemTemplate>
                    <asp:TextBox ID="txtFeeCategoryName" runat="server" Text='<%#Eval("FeeCategoryName") %>' />
                    <asp:RequiredFieldValidator ID="rfvFeeCategoryName" runat="server" ControlToValidate="txtFeeCategoryName"
                        Text="*" ValidationGroup="vupdate" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblFeeCategoryName" runat="server" Text='<%# Bind("FeeCategoryName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtNewFeeCategoryName" runat="server" />
                    <asp:RequiredFieldValidator ID="rfvNewFeeCategoryName" runat="server" ControlToValidate="txtNewFeeCategoryName"
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
