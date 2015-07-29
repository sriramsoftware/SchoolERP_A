<%@ Page Title="" Language="C#" MasterPageFile="~/AccountManager/AccountManager.master" AutoEventWireup="true" CodeFile="ViewFeesPaymentInvoice.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_ViewFeesPaymentInvoice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style>
<!--
.popup_wrapp{width:712px; background:#fff; border:1px solid #eae6cd; position:absolute; top:100px; left:300px; z-index:99999; padding:10px;}
.pop_main_box{width:652px; border:1px solid #acacac; padding:30px; position:relative;}
.close_icon_popup{width:16px; height:16px; position:absolute; right:9px; top:9px;}
.popup_title{font:normal 18px "Trebuchet MS", Arial, Helvetica, sans-serif; color:#454545; padding:0px 0px 10px; margin-bottom:10px; text-transform:uppercase; border-bottom:1px solid #acacac;}
.inv_title{background:url(img/dark_gray_texture.jpg) repeat left top; border:1px solid #afaca3; height:39px; padding:0px 15px; line-height:39px; margin:0px;}
.tofrom_box{border:1px solid #e7e5dd; padding:17px 15px; border-top:0px solid #fff; margin-bottom:30px;}		
.tofrom_box dl{margin:0px; padding:0px; display:block;}
.tofrom_box dl dd{float:left; width:50%;}			
.tofrom_box dl dd span{font-weight:bold; color:#999;}
.sta_box{margin:0px; padding:0px; line-height:24px;}
.inst_title{background:url(img/dark_gray_texture.jpg) repeat left top; border:1px solid #afaca3; border-bottom:0px solid #fff; height:39px; text-align:center;  margin:0px; font:bold 14px/39px Arial, Helvetica, sans-serif;}
.total_box{margin:0px; padding:0px;}
.total_box dl{margin:0px; padding:0px; display:block;}
.total_box dl dt{float:left; text-align:right; width:580px;}
.total_box dl dd{float:right; width:70px; text-align:right;}
-->
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section style="position:relative; height:100%; display:block;">
<section style="background:#000; width:100%; height:100%; position:absolute; zoom: 1;  filter: alpha(opacity=50); opacity: 0.5; z-index:999;"></section>
<section class="popup_wrapp">
	<section class="pop_main_box">
    	<section class="close_icon_popup"><a href="accountant_student_fees_details.html"><img src="img/pop_close_icon.png" width="16" height="16" /></a></section>
        <section class="popup_title">
        	<span class="lF">Invoice</span>
          <section class="dow_icon sprite rF"><a href="#url"></a></section>
          <section class="print_icon sprite rF"><a href="#url"></a></section>
            <section class="clear"></section>
        </section>
  <section class="inv_title">
        	<section class="lF"><b>Status : Release | Released Date- 10 Feb 2012</b></section>
            <section class="rF"><b>Documetn Id</b> : 14567</section>
            <section class="clear"></section>
        </section>	
  <section class="tofrom_box">
        	<dl>
            	<dd>
                	<span>To -</span><br />
                    <b>Blue Ridge School</b><br />
                    Kaasp County, B-204, Sk Street, Pune.<br />
                    Contact no. 89876807653
                </dd>
                <dd>
                	<span>From -</span><br />
                    <b>Aarohi Sharma</b><br />
                    16-B Road, Behind Pizza Corner, Pune.<br />
                    Contact no. 9988776652
                </dd>
                <section class="clear"></section>
            </dl>
        </section>
  <section class="sta_box">
        	<section class="lF">Std 6th A</section>
            <section class="rF">Invoice Date : 1st Aug 2011</section>
            <section class="clear"></section>
        </section>
      <section class="inst_title">Installment</section>
        <table class="billing_invoic">
                                	<thead>
                                    	<tr>
                                        	<th>Fees Installments</th>
                                            <th>Amount</th>
                                            <th>Status</th>
                                            <th>Last Date</th>
                                            <th>Late Fees</th>
                                            <th>Total Fees</th>
                                        </tr>
                                    </thead>
                                    <tfoot>
                                    	<tr>
                                            <td>2. Before Semester Fees</td>
                                            <td>Rs. 3000</td>
                                            <td><section class="check_icon sprite"><a href="#url"></a></section></td>
                                            <td>1st Aug 2011</td>
                                            <td>Rs. 20 x 0</td>
                                          <td>Paid</td>
                                        </tr>
                                    </tfoot>
                                    <tbody>
                                    	<tr>
                                            <td>1. Admission Fees</td>
                                            <td>Rs. 1000</td>
                                            <td><section class="check_icon sprite"><a href="#url"></a></section></td>
                                            <td>23rd June 2011</td>
                                            <td>Rs. 20 x 0</td>
                                          <td>Paid</td>
                                        </tr>
                                    </tbody>
                                </table>
		<section class="total_box">
        	<dl>
            	<dt>Total Without Vat :</dt>
                <dd>Rs 400</dd>
                <section class="clear"></section>
            </dl>
            <dl>
            	<dt>Vat :</dt>
                <dd>Rs 40</dd>
                <section class="clear"></section>
            </dl>
            <dl>
            	<dt>Total With Vat :</dt>
                <dd>Rs 440</dd>
                <section class="clear"></section>
            </dl>
            
        </section>
    </section>
</section>
</section>
</asp:Content>

