<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master"
    AutoEventWireup="true" CodeFile="StudentTypes.aspx.cs" Inherits="StudentTypes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="top_row">
                         <section class="achiv_toptitle">Student Type</section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx" title="Back">BACK</a></section>
                            <section class="clear"></section>
                             
    </section>
    <div style="text-align: center">
        <section>Student Type:<asp:TextBox ID="txtStudentTypeSearch" ClientIDMode="Static" runat="server"  /></section>
        <section><asp:Button runat="server" ID="btnSearchStudentType" OnClick="btnSearchStudentType_Click" Text="Search"/><asp:Button runat="server" ID="btnClearSearch" OnClick="btnClearSearch_Click" Text="Clear"/></section>
    </div>
    <asp:GridView ID="grdStudentType" runat="server" DataKeyNames="StudentTypeID" OnRowEditing="grdStudentType_EditRow"
        OnRowUpdating="grdStudentType_UpdateRow" OnRowCancelingEdit="grdStudentType_CancelEditRow"
        CellPadding="15" Width="100%" EmptyDataText="No Record Exists" AutoGenerateColumns="false"
        GridLines="None" HeaderStyle-HorizontalAlign="Left" CssClass="time_table" PageSize="5"
        AllowPaging="true" HeaderStyle-VerticalAlign="Top" OnPageIndexChanging="grdStudentType_PageIndexChanging"
        OnRowCommand="grdStudentType_RowCommand" OnRowDeleting="grdStudentType_RowDeleting"
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
                    <asp:DropDownList CausesValidation="True" ID="drpFeeCategoryName" runat="server"
                        DataSource='<%#GetFeeCategoryNames() %>' DataTextField="FeeCategoryName" DataValueField="FeeCategoryID"
                        SelectedValue='<%# Eval("FeeCategoryID") %>' />
                    <asp:RequiredFieldValidator InitialValue="0" ID="rfvFeeCategoryName" runat="server"
                        ControlToValidate="drpFeeCategoryName" Text="*" ValidationGroup="vupdate" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblFeeCategoryName" runat="server" Text='<%# Bind("FeeCategoryName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:DropDownList CausesValidation="True" ID="drpNewFeeCategoryName" runat="server"
                        DataSource='<%#GetFeeCategoryNames() %>' DataTextField="FeeCategoryName" DataValueField="FeeCategoryID" />
                    <asp:RequiredFieldValidator InitialValue="0" ID="rfvNewFeeCategoryName" runat="server"
                        ControlToValidate="drpNewFeeCategoryName" Text="*" ValidationGroup="vinsert" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Type Name">
                <EditItemTemplate>
                    <asp:TextBox ID="txtStudentTypeName" runat="server" Text='<%#Eval("StudentTypeName") %>' />
                    <asp:RequiredFieldValidator ID="rfvStudentTypeName" runat="server" ControlToValidate="txtStudentTypeName"
                        Text="*" ValidationGroup="vupdate" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblStudentTypeName" runat="server" Text='<%# Bind("StudentTypeName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtNewStudentTypeName" runat="server" />
                    <asp:RequiredFieldValidator ID="rfvNewStudentTypeName" runat="server" ControlToValidate="txtNewStudentTypeName"
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
