<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true"
    CodeFile="FeeHeads.aspx.cs" Inherits="AccountManager_FeeHeads" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="top_row">
                         <section class="achiv_toptitle">Fees Heads</section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx" title="Back">BACK</a></section>
                            <section class="clear"></section>
                             
    </section>
    <div style="text-align: center">
        <section>Fees Head:<asp:TextBox ID="txtFeeHeadsSearch" ClientIDMode="Static" runat="server"  /></section>
        <section><asp:Button runat="server" ID="btnSearchFeeHeads" OnClick="btnSearchFeeHeads_Click" Text="Search"/><asp:Button runat="server" ID="btnClearSearch" OnClick="btnClearSearch_Click" Text="Clear"/></section>
    </div>
    <asp:GridView ID="grdFeeHeads" runat="server" DataKeyNames="FeeHeadID" OnRowEditing="grdFeeHeads_EditRow"
        OnRowUpdating="grdFeeHeads_UpdateRow" OnRowCancelingEdit="grdFeeHeads_CancelEditRow"
        CellPadding="15" Width="100%" EmptyDataText="No Record Exists" AutoGenerateColumns="false"
        GridLines="None" HeaderStyle-HorizontalAlign="Left" CssClass="time_table" PageSize="5"
        AllowPaging="true" HeaderStyle-VerticalAlign="Top" OnPageIndexChanging="grdFeeHeads_PageIndexChanging"
        OnRowCommand="grdFeeHeads_RowCommand" OnRowDeleting="grdFeeHeads_RowDeleting"
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
            <asp:TemplateField HeaderText="Fee Category Name">
                <EditItemTemplate>
                    <asp:DropDownList CausesValidation="True" ID="drpFeeCategoryName" runat="server" DataSource='<%#GetFeeCategoryNames() %>'
                        DataTextField="FeeCategoryName" DataValueField="FeeCategoryID" SelectedValue='<%# Eval("FeeCategoryID") %>' />
                    <asp:RequiredFieldValidator InitialValue="0" ID="rfvFeeCategoryName" runat="server" ControlToValidate="drpFeeCategoryName"
                        Text="*" ValidationGroup="vupdate" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblFeeCategoryName" runat="server" Text='<%# Bind("FeeCategoryName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:DropDownList CausesValidation="True" ID="drpNewFeeCategoryName" runat="server"  DataSource='<%#GetFeeCategoryNames() %>'
                        DataTextField="FeeCategoryName" DataValueField="FeeCategoryID"/>
                    <asp:RequiredFieldValidator InitialValue="0" ID="rfvNewFeeCategoryName" runat="server" ControlToValidate="drpNewFeeCategoryName"
                        Text="*" ValidationGroup="vinsert" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Fee Head Name">
                <EditItemTemplate>
                    <asp:TextBox ID="txtFeeHeadName" runat="server" Text='<%#Eval("FeeHeadName") %>' />
                    <asp:RequiredFieldValidator ID="rfvFeeHeadName" runat="server" ControlToValidate="txtFeeHeadName"
                        Text="*" ValidationGroup="vupdate" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblFeeHeadName" runat="server" Text='<%# Bind("FeeHeadName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtNewFeeHeadName" runat="server" />
                    <asp:RequiredFieldValidator ID="rfvNewFeeHeadName" runat="server" ControlToValidate="txtNewFeeHeadName"
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
