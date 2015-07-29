<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="Announcement.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_Announcement"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

	 <section class="top_row">
                         <section class="achiv_toptitle">Announcements <span></span></section>
                          <section class="top_row_back"><a href="javascript:history.go(-1)" title="Back">BACK</a></section>
                         <section class="clear"></section>
                         </section>
    <section class="tab_wrapp" id="tabs">
                           
                            <section class="tab_des_wrapp" id="inbox">
                           		<section class="inbox_wrapp">
                           		 <asp:ListView ID="lstAnnouncement" runat="server" ItemPlaceholderID="PlaceHolder1" onitemdatabound="lstAnnouncement_ItemDataBound" >
                               <LayoutTemplate>
                              <asp:PlaceHolder ID="PlaceHolder1" runat="server" />
                               </LayoutTemplate>
                                    <ItemTemplate> 
                                	<dl>
                                    	<section class="white_box">
                                            <section class="inbox_txt_box">
                                            	<section class="msg_title"><a href="#"><a href="#"><asp:Label runat="server" id="lblTitle" Text='<%#Bind("SA_Title") %>'></asp:Label></a> &nbsp;<asp:Label runat="server" id="lblDays"></asp:Label> 
                                            	<asp:Label ID="lblAnnouncementId" runat="server" Text='<%# Bind("SA_AnnoucementId") %>' Visible="False"></asp:Label>
                                            	</section>
                                            	<br />
                                                <article style="width:600px;"><span ><asp:Label runat="server" id="lblDesc" Text='<%#Bind("SA_Description") %>'></asp:Label></span> </article>
                                            </section>
                                           
                                            <section class="clear"></section>
                                        </section>
                                    </dl>
                                      </ItemTemplate>
                 <EmptyDataTemplate>
                        <asp:Label ID="Label242sf" Style="font-weight: bold; font-size: 13px; color: Red;"
                            runat="server" Text="NoRecordFound"></asp:Label>
                    </EmptyDataTemplate>
            </asp:ListView>
                                   
                                   
                                    <section class="pagna">
                                	<ul>
                              <asp:DataPager ID="DataPagerTrip" runat="server" PagedControlID="lstAnnouncement" 
                            PageSize="5" onprerender="DataPagerTrip_PreRender">
                            <Fields>
                                <asp:NextPreviousPagerField ShowFirstPageButton="True" ShowNextPageButton="False"
                                    PreviousPageText="Previous" FirstPageText="First"
                                    ButtonCssClass="Pagbtn" />
                                <asp:NumericPagerField NumericButtonCssClass="Pagbtn" />
                                <asp:NextPreviousPagerField ShowLastPageButton="True" ShowPreviousPageButton="False"
                                    LastPageText="Last" NextPageText="Next"
                                    ButtonCssClass="Pagbtn" />
                            </Fields>
                        </asp:DataPager>
                                    </ul>
                                </section>
                                </section>
                           </section>
                           
                            
            			</section>
</asp:Content>


