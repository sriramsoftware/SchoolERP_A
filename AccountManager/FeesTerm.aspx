<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="FeesTerm.aspx.cs" Inherits="AccountManager_FeesTerm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <section class="top_row">
                         <section class="achiv_toptitle">Fees Term</section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx" title="Back">BACK</a></section>
                            <section class="clear"></section>
                             
    </section>
    <div style="text-align:center">
        <section>Fees Category:<asp:DropDownList ID="drpFeesCategory" AutoPostBack="True" ClientIDMode="Static" runat="server" OnSelectedIndexChanged="drpFeesCategory_SelectedIndexChanged" /></section>
    </div>
    <asp:GridView ID="grdFeesTerm" runat="server" DataKeyNames="MonthID" OnRowEditing="grdFeesTerm_EditRow"
        OnRowUpdating="grdFeesTerm_UpdateRow" OnRowCancelingEdit="grdFeesTerm_CancelEditRow"
        CellPadding="15" Width="100%" EmptyDataText="No Record Exists" AutoGenerateColumns="false"
        GridLines="None" HeaderStyle-HorizontalAlign="Left" CssClass="time_table" 
        AllowPaging="False" HeaderStyle-VerticalAlign="Top"  ShowFooter="false">
        <RowStyle HorizontalAlign="Left" />
        <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="Red"
            Font-Size="14px"></EmptyDataRowStyle>
        <Columns>
            
            <asp:TemplateField HeaderText="Month">
                <ItemTemplate>
                    <asp:Label ID="lblMonth"  runat="server" Text='<%# Bind("Month") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Fees Term">
                <EditItemTemplate>
                    <asp:TextBox ID="txtFeesTerm" runat="server" Text='<%#Eval("FeesTerm") %>' />
                    <asp:RequiredFieldValidator ID="rfvFeesTerm" runat="server" ControlToValidate="txtFeesTerm"
                        Text="*" ValidationGroup="vupdate" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblFeesTerm"  runat="server" Text='<%# Bind("FeesTerm") %>'></asp:Label>
                </ItemTemplate>
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
            </asp:TemplateField>
            
        </Columns>
    </asp:GridView>
</asp:Content>

