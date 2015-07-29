<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="Leavedetails.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_Leavedetails"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <section class="top_row">
        <section class="achiv_toptitle">
            Leave  <span> Details</span>
        </section>
        <section class="top_row_back">
            <a href="javascript:history.go(-1)" title="Back">BACK</a></section>
        <section class="clear">
        </section>
    </section>
    <fieldset>
        <section class="right_content tabsec_topsecn " style="width: 690px!important;">
                                <section class="font14 textbold yellowtext">General</section>
                                    
                                    <section>
                                     <section class="newform">
                                   
                                                                            
                                      <dl>
                                       <dt>Casual Leave (CL) :</dt>
                                       <dd>
                                       <asp:Label  ID ="lblcasualLeave" runat ="server" ></asp:Label>
                                       </dd>
                                      </dl>    
                                      
                                       <section class="clear"></section>
                                       <dl>
                                       <dt>Earned Leave (EL):</dt>
                                       <dd>
                                       <asp:Label  ID ="lblEarnedLeave" runat ="server" ></asp:Label>
                                       </dd>
                                      </dl>   
                                      
                                      <section class="clear"></section>
                                       <dl>
                                       <dt>Paid Leave (PL) :</dt>
                                       <dd>
                                       <asp:Label  ID ="lblPaidLeave" runat ="server" ></asp:Label>
                                       </dd>
                                      </dl>                
                                         
                                         
                                         <section class="clear"></section>
                                       <dl>
                                       <dt>Sick Leave (SL) :</dt>
                                       <dd>
                                       <asp:Label  ID ="lblseakleave" runat ="server" ></asp:Label>
                                       </dd>
                                      </dl>       
                                         
                                          <section class="clear"></section>
                                       <dl>
                                       <dt>Other Leave (OL):</dt>
                                       <dd>
                                       <asp:Label  ID ="lblOtherLeave" runat ="server" ></asp:Label>
                                       </dd>
                                      </dl>      
                                         <section class="clear"></section>                                            
                                      </section>
                       
                                    </section>
                                    
                                                                 
                                     <section class="font14 textbold yellowtext">Special Case</section>
                                     <section>
                                     <section class="newform"> 
                                  
                                     
                                     <dl id ="liratepf" runat ="server" >
                                       <dt> Marital Leave :</dt>
                                      
                                     <dd>
                                      <asp:Label  ID ="lblMaritalLeave" runat ="server" ></asp:Label> 
                                     </dd>
                                     
                                      </dl>
                                      <section class="clear"></section>
                                      
                                      <dl id ="lirateamountPF" runat ="server" >
                                       <dt>
                                       
                                 Maternity Leave : </dt>
                                     <dd><asp:Label  ID ="lblMaternityLeave" runat ="server"  ></asp:Label></dd>
                                      </dl>
                                      
                                      
                                      <section class="clear"></section>
                                      </section > 
                                   
                                      </section> 
                                      
                                       <section class="clear"></section>
    </fieldset>
    <asp:HiddenField ID="HiddId" runat="server" />
</asp:Content>

