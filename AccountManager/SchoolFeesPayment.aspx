<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="SchoolFeesPayment.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_SchoolFeesPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <section class="top_row bottom_bor">
                         <section class="achiv_toptitle">Student's <span>fee and payment</span></section>
                          <section class="top_row_back"><a href="AccountManagerDashboard.aspx">BACK</a></section>
                          <section class="clear"></section>
                         </section>
              <section class="top_row">

                <section class="tech_nam_box">
                <h3>
                <span style="color: #FFDE4D;font: bold 18px Myriad Pro,Trebuchet MS,arial,Helvetica,sans-serif;">
                Payment Status of Anusha J. Mishra   4th (A) </span>
                </h3>
                			<section class="stu_fees_details">
                                  <section class="stu_fees_block"><span>Total Fees :    </span>    Rs 8000 </section>
                            	   <section class="stu_fees_block"><span> Paid Fees :   </span>   Rs 4000 </section>
                              	   <section class="stu_fees_block"><span>Pending Fees : </span>    Rs 4000M </section>
                                   <section class="clear"></section>
                            </section>
                </section>
                        
              	  <table class="qs_student">
                       	  <thead>
                           	  <tr>
                               	  <th width="12%">Fees Installments</th>
                                  <th width="8%">Amount</th>
                                  <th width="7%">Status</th>
                                  <th width="9%">Last Date</th>
                                  <th width="8%">Late<br>
                                Fees</th>
                                  <th width="9%">Total Amount</th>
                                  <th width="10%">Fees<br>
                                  Paid On</th>
                                  <th width="14%">Payment<br>
                                  Type</th>
                                  <th width="15%"><p>Paid</p>
                                  <p>Fees</p></th>
                                  <th width="8%">Details</th>
                              </tr>
                          </thead>
                          <tfoot>
                       	  </tfoot>
                          <tbody>
                           	  <tr>
                               	  <td>Admission Fees</td>
                                  <td>Rs 3000</td>
                                  <td valign="middle" align="center"><img src="img/green_tick.png"/></td>
                                  <td>27/6/2011</td>
                                  <td>20 X 0</td>
                                  <td>Rs 3000</td>
                                  <td>27/6/2011</td>
                                   <td>
                                   <select class="acc_select">
                                   	<option>select</option>
                                   </select>
                                   </td>
                                   <td align="center"><input type="text" class="acc_select"></td>
                                  <td align="center"><a href="#">View Invoice </a> </td>
                              </tr>
                              <tr>
                               	  <td>Before Semester Fees</td>
                                  <td>Rs 3000</td>
                                  <td valign="middle" align="center"><img src="img/green_tick.png"/></td>
                                 <td>27/6/2011</td>
                                  <td>20 X 0</td>
                                  <td>Rs 3000</td>
                                <td>27/6/2011</td>
                                   <td>
                                   <select class="acc_select">
                                   	<option>select</option>
                                   </select>
                                   </td>
                                    <td align="center"><input type="text" class="acc_select"></td>
                                  <td align="center"><a href="#">View Invoice</a></td>
                              </tr>
                              <tr>
                           	    <td>Before Second Semester</td>
                                <td>Rs 3000</td>
                                <td valign="middle" align="center"><img src="img/blue_clock.png"/></td>
                               <td>27/6/2011</td>
                               <td>20 X 1</td>
                               <td>Rs 3020</td>
                               <td>---</td>
                                <td>
                                   <select class="acc_select">
                                   	<option>select</option>
                                   </select>
                                   </td>
                                 <td align="center"><input type="text" class="acc_select"></td>
                                <td align="center"><a href="#url">Send Alert</a></td>
                              </tr>
                                <tr>
                               	  <td>Final Examinations</td>
                                  <td>Rs 1000</td>
                                  <td valign="middle" align="center"><img src="img/blue_clock.png"/></td>
                                  <td>27/6/2011</td>
                                  <td>20 X1</td>
                                  <td>Rs 1020</td>
                                  <td>---</td>
                                    <td>
                                   <select class="acc_select">
                                   	<option>select</option>
                                   </select>
                                   </td>
                                     <td align="center"><input type="text" class="acc_select"></td>
                                <td align="center"><a href="#url">Send Alert</a></td>
                              </tr>
                                  
                          </tbody>
                     </table>
                </section>
</asp:Content>

