<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="RentAccountDetails.aspx.cs" Inherits="AccountManager_RentAccountDetails"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<script type="text/javascript">
    function GetSelectedRow(lnk) {
    var paidAmount= $(lnk).val();
    var totalAmount= $(lnk).parent().prev().children("input").val();
    //alert('paidAmount:'+paidAmount);
    //alert('totalAmount:'+totalAmount);
    
    if(parseInt(paidAmount)>parseInt( totalAmount))
    {
      alert("Paid Amount Should be less than TotalAmount ");
      return false;
    }
    else
    {
     $(lnk).parent().next().children("input").val(totalAmount-paidAmount);   
    }
    }
    </script>
    
    
    <script type="text/javascript">
    function GetSelectedRowOne(lnk) {
    var paidAmount= $(lnk).val();
    var totalAmount= $(lnk).parent().prev().children("input").val();
    //alert('paidAmount:'+paidAmount);
    //alert('totalAmount:'+totalAmount);
    
    if(parseInt(paidAmount)>parseInt( totalAmount))
    {
      alert("Paid Amount Should be less than TotalAmount ");
      return false;
    }
    else
    {
     $(lnk).parent().next().children("input").val(totalAmount-paidAmount);   
    }
    }
    </script>


<script type="text/javascript">
    function GetSelectedRowUpdate(lnk) {
    var totalAmount= $(lnk).val();
    var paidAmount= $(lnk).parent().next().children("input").val();
   
    if(parseInt(paidAmount)>parseInt( totalAmount))
    {
      alert("Paid Amount Should be less than TotalAmount ");
      return false;
    }
    else
    {
     $(lnk).parent().next().children("input").val(totalAmount-paidAmount);   
    }
    }
    </script>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <section class="top_row bottom_bor">
                         <section class="achiv_toptitle">Rent <span>Account Details</span></section>
                          <section class="clear"></section>
                         </section>


   <section id="dvMsg"  runat="server">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <section class="clear">
            </section>
            </section>
 <setion>
<asp:GridView ID="gvDetails" DataKeyNames="RAC_RentId" runat="server" AllowPaging="true" PageSize="10"
AutoGenerateColumns="false" CssClass="billing_invoic" Width="98%" 
ShowFooter="true" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Black"
onrowcancelingedit="gvDetails_RowCancelingEdit"
onrowdeleting="gvDetails_RowDeleting" onrowediting="gvDetails_RowEditing"
onrowupdating="gvDetails_RowUpdating"
onrowcommand="gvDetails_RowCommand"
OnPageIndexChanging="gvDetails_PageIndexChanging" EmptyDataRowStyle-ForeColor="Red">
<Columns>

<asp:TemplateField HeaderText="Month">
   <EditItemTemplate>
                <asp:DropDownList ID="ddlMonth" runat="server" 
                SelectedValue='<%# Eval("RAC_Month") %>'>
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
               <asp:ListItem Text="April" Value="April"></asp:ListItem>
               <asp:ListItem Text="May" Value="May"></asp:ListItem>
                </asp:DropDownList>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblMonth" runat="server" Text='<%#Eval("RAC_Month") %>'/>
            </ItemTemplate>
            <FooterTemplate>
                <asp:DropDownList ID="ddlfMonth" runat="server"  >
                <asp:ListItem Value="-1" >Select Month</asp:ListItem>
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
               <asp:ListItem Text="April" Value="April"></asp:ListItem>
               <asp:ListItem Text="May" Value="May"></asp:ListItem>
              </asp:DropDownList>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ForeColor="Red"
             ErrorMessage="Required" ControlToValidate="ddlfMonth" ValidationGroup="sub" InitialValue="-1"></asp:RequiredFieldValidator>
            </FooterTemplate>
</asp:TemplateField>


<asp:TemplateField HeaderText="Year">
<EditItemTemplate>
                <asp:DropDownList ID="ddlYear" runat="server" 
                SelectedValue='<%# Eval("RAC_Year") %>'>
               
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
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblYear" runat="server" Text='<%#Eval("RAC_Year") %>'/>
            </ItemTemplate>
            <FooterTemplate>
                <asp:DropDownList ID="ddlfYear" runat="server">
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
              <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ForeColor="Red"
             ErrorMessage="Required" ControlToValidate="ddlfYear" ValidationGroup="sub" InitialValue="-1"></asp:RequiredFieldValidator>
                                                    
            </FooterTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="Total Amount" HeaderStyle-HorizontalAlign="Left">
<EditItemTemplate>
<asp:TextBox ID="txtTotalAmount" runat="server" Text='<%#Eval("RAC_TotalAmount") %>' onblur="javascript:GetSelectedRowUpdate(this);"/>
</EditItemTemplate>
<ItemTemplate>
<asp:Label ID="lblTotalAmount" runat="server" Text='<%#Eval("RAC_TotalAmount") %>'/>
</ItemTemplate>
<FooterTemplate>
<asp:TextBox ID="txtfTotalAmount" runat="server"></asp:TextBox>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic"
  ErrorMessage="Required" ControlToValidate="txtfTotalAmount" SetFocusOnError="true"
  ValidationGroup="sub"></asp:RequiredFieldValidator>
  <cc1:filteredtextboxextender id="FilteredTextBoxExtender1" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtfTotalAmount" >
  </cc1:filteredtextboxextender>
</FooterTemplate>
</asp:TemplateField>


<asp:TemplateField HeaderText="Paid Amount" HeaderStyle-HorizontalAlign="Left">
<EditItemTemplate>
<asp:TextBox ID="txtPaidAmount" runat="server" Text='<%#Eval("RAC_PaidAmount") %>' onblur="javascript:GetSelectedRowOne(this);"/>
</EditItemTemplate>
<ItemTemplate>
<asp:Label ID="lblPaidAmount" runat="server" Text='<%#Eval("RAC_PaidAmount") %>'/>
</ItemTemplate>
<FooterTemplate>
<asp:TextBox ID="txtfPaidAmount" runat="server" onblur="javascript:GetSelectedRow(this);"></asp:TextBox>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic"
 ErrorMessage="Required" ControlToValidate="txtfPaidAmount" SetFocusOnError="true"
 ValidationGroup="sub"></asp:RequiredFieldValidator>
 <cc1:filteredtextboxextender id="FilteredTextBoxExtender2" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtfPaidAmount" >
 </cc1:filteredtextboxextender>
</FooterTemplate>
</asp:TemplateField>


<asp:TemplateField HeaderText="Any Dues" HeaderStyle-HorizontalAlign="Left">
<EditItemTemplate>
<asp:TextBox ID="txtDues" runat="server" Text='<%#Eval("RAC_AnyDues") %>' Enabled="false"/>
</EditItemTemplate>
<ItemTemplate>
<asp:Label ID="lblDues" runat="server" Text='<%#Eval("RAC_AnyDues") %>'/>
</ItemTemplate>
<FooterTemplate>
<asp:TextBox ID="txtfDues" runat="server" Enabled="false"></asp:TextBox>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic"
 ErrorMessage="Required" ControlToValidate="txtfDues" SetFocusOnError="true"
 ValidationGroup="sub"></asp:RequiredFieldValidator>
 <cc1:filteredtextboxextender id="FilteredTextBoxExtender3" runat="server" enabled="True" validchars="0123456789" targetcontrolid="txtfDues" >
</cc1:filteredtextboxextender>
</FooterTemplate>
</asp:TemplateField>


<asp:TemplateField HeaderText="Paid Status" HeaderStyle-HorizontalAlign="Left">
<EditItemTemplate>
                <asp:DropDownList ID="ddlPaidStatus" runat="server" 
                SelectedValue='<%# Eval("RAC_PaidStatus") %>'>
                 <asp:ListItem Text="Paid" Value="Paid"></asp:ListItem>
                <asp:ListItem Text="UnPaid" Value="UnPaid"></asp:ListItem>
</asp:DropDownList>
</EditItemTemplate>
<ItemTemplate>
<asp:Label ID="lblPaid" runat="server" Text='<%#Eval("RAC_PaidStatus") %>'/>
</ItemTemplate>
<FooterTemplate>
  <asp:DropDownList ID="ddlfPaidStatus" runat="server">
                <asp:ListItem Value="-1" >Select Status</asp:ListItem>
                <asp:ListItem Text="Paid" Value="Paid"></asp:ListItem>
                <asp:ListItem Text="UnPaid" Value="UnPaid"></asp:ListItem>
</asp:DropDownList>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic"
 ErrorMessage="Required" ControlToValidate="ddlfPaidStatus" SetFocusOnError="true"
 ValidationGroup="sub" InitialValue="-1"></asp:RequiredFieldValidator>

</FooterTemplate>
</asp:TemplateField>


<asp:TemplateField HeaderText="TransactionDate" HeaderStyle-HorizontalAlign="Left">
<EditItemTemplate>
<asp:TextBox ID="txtTranDate" runat="server"  Text='<%#Eval("RAC_TransactionDate","{0:d}")%>' ></asp:TextBox>
                            	  <cc1:CalendarExtender ID="caltxtTranDate" runat="server" TargetControlID="txtTranDate">
                        </cc1:CalendarExtender>
 
</EditItemTemplate>

<ItemTemplate>
<asp:Label ID="lblTranDate" runat="server" Text='<%#Eval("RAC_TransactionDate","{0:d}")%>' />
</ItemTemplate>

<FooterTemplate>
<asp:TextBox ID="txtfTranDate" runat="server" ></asp:TextBox>
 <cc1:CalendarExtender ID="caltxtfTranDate" runat="server" TargetControlID="txtfTranDate">
 </cc1:CalendarExtender>
 
 <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic"
 ErrorMessage="Required" ControlToValidate="txtfTranDate" SetFocusOnError="true"
 ValidationGroup="sub"></asp:RequiredFieldValidator>
 <cc1:filteredtextboxextender id="FilteredTextBoxExtender5" runat="server" enabled="True" validchars="0123456789/" targetcontrolid="txtfTranDate" >
</cc1:filteredtextboxextender>
</FooterTemplate>
</asp:TemplateField>


<asp:TemplateField HeaderText="Add/Update/Delete" HeaderStyle-HorizontalAlign="Left">
<EditItemTemplate>
<asp:ImageButton ID="imgbtnUpdate" CommandName="Update" runat="server" ImageUrl="~/img/icon_correct.png" ToolTip="Update" Height="20px" Width="20px"/>
<asp:ImageButton ID="imgbtnCancel" runat="server" CommandName="Cancel" ImageUrl="~/img/cancel.png" ToolTip="Cancel" Height="20px" Width="20px" />
</EditItemTemplate>
<ItemTemplate>
<asp:ImageButton ID="imgbtnEdit" CommandName="Edit" runat="server" ImageUrl="~/img/icon_edit.png" ToolTip="Edit" Height="20px" Width="20px"   />
<asp:ImageButton ID="imgbtnDelete" CommandName="Delete" Text="Edit" OnClientClick="return confirm('Are you sure you want to delete this record?');" runat="server" ImageUrl="~/img/icon-delete.png" ToolTip="Delete" Height="20px" Width="20px" />
</ItemTemplate>
<FooterTemplate>
<asp:LinkButton ID="imgbtnAdd" runat="server"  Text="Insert" CommandName="AddNew" Width="30px" Height="30px" ToolTip="Add New Details" ValidationGroup="sub" ></asp:LinkButton>
</FooterTemplate>
</asp:TemplateField>

</Columns>
</asp:GridView>
</setion>
<div>
<asp:Label ID="lblresult" runat="server"></asp:Label>
</div>                                   
</asp:Content>

