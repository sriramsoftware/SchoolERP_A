<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="ViewTodaysMeal.aspx.cs" Inherits="Teacher_ViewTodaysMeal" Title=":: Bachpan Mayur Vihar ::" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script language="javascript">
        function showOptions() {
            $("#optionmenu").toggle();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
                           
                          <section class="top_row">
                         <section class="achiv_toptitle">Todays Meal</section>
						<section class="top_row_back"><a href="AccountManagerDashboard.aspx" title="Back">BACK</a></section>
                          <section class="clear"></section>
                         </section>                                             
                            <section class="top_row">
                                <div id="dvMsg"  runat="server" visible="false" style="width:-2px;">
                                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                                 <div class="clear">
                              </div>
                              </div>
                         <section class="clear"></section>
                         </section>
                  <section class="application_wrapp">
                         	
                        
                         		    <section class="faculty_wrapp">
                         	 <asp:ListView ID="lstApplication" runat="server" ItemPlaceholderID="PlaceHolder1" OnItemDatabound="lstApplication_ItemDataBound">
                             <LayoutTemplate>
                             <asp:PlaceHolder ID="PlaceHolder1" runat="server" />
                               </LayoutTemplate>
                                 <ItemTemplate> 
                              
                                 <dl style="width:674px;height:131px;">
                                    <dt style="width:241px;">
                                    <section class="faculty_img_box" style="width:228px;height:123px;">
                                     <asp:ImageButton id="imgbtnThum" Height="100%" Width="100%" runat="server" OnClick="btnimgbtnThum_Click"/>
                                    </section>
                                    </dt>
                                    <dd style="width:414px;">
                                       <section>
                                        <b>
                                        <asp:Label ID="lblAppFor" runat="server" Text='<%#Bind("TMD_MealMenu")%>'></asp:Label>
                                        </b>
                                        </section>
                                        <section>
                                        <b>Description</b>
                                        </section>
                                        <article><asp:Label ID="lblDesc" runat="server" Text='<%#Bind("TMD_MealDescription")%>'></asp:Label></article>
                                    </dd><section class="clear"></section>
                                 </dl>
                                 <asp:Label ID="lblCampus" runat="server" Text='<%#Bind("TMD_MealId")%>' Visible="false"></asp:Label>
                                 <asp:Label ID="lblThumbnailName" runat="server" Text='<%#Bind("TMD_MealImage")%>' Visible="false"></asp:Label>                             
                                 </ItemTemplate>
                               <EmptyDataTemplate>
                            <asp:Label ID="Label242sf" Style="font-weight: bold; font-size: 13px; color: Red;"
                            runat="server" Text="No Record Found"></asp:Label>
                       </EmptyDataTemplate>
                      </asp:ListView>
                            <section class="pagna">
                            	<ul>
                           <asp:DataPager ID="DataPagerTrip" runat="server" PagedControlID="lstApplication" 
                            PageSize="10" onprerender="DataPagerTrip_PreRender">
                            <Fields>
                                <asp:NextPreviousPagerField ShowFirstPageButton="True" ShowNextPageButton="False" PreviousPageText="Previous" FirstPageText="First" ButtonCssClass="Pagbtn" />
                                <asp:NumericPagerField NumericButtonCssClass="Pagbtn" />
                                <asp:NextPreviousPagerField ShowLastPageButton="True" ShowPreviousPageButton="False" LastPageText="Last" NextPageText="Next" ButtonCssClass="Pagbtn" />
                            </Fields>
                        </asp:DataPager>
                                </ul> </section>
                            </section>
                         </section>
</asp:Content>
