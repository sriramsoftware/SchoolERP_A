<%@ Page Language="C#" MasterPageFile="~/AccountManager/AccountManager.master"
    AutoEventWireup="true" CodeFile="MyProfile.aspx.cs" Inherits="TMSchoolMgmt_AccountManager_MyProfile" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="top_row">
                          <section class="top_row_back"><a href="javascript:history.go(-1)" title="Back">BACK</a></section>
                         </section>
    <section class="clear"></section>
    &nbsp; &nbsp; &nbsp;
    <section class="top_row">
                          <div id="dvMsg"  runat="server" visible="false" style="width:-2px;">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <div class="clear">
            </div>
           </div>
                         </section>
    <section class="clear"></section>
    &nbsp; &nbsp; &nbsp;
    <section id="SectionViewProfile" runat="server">
            	<h1>Personal <span>Details</span> <span><asp:Button ID="btnEdit" runat="server" Text="Edit Profile"  CssClass="go" OnClick="btnEdit_Click"  style="float:right;"/></span></h1>
                <fieldset>
                	<section class="col1">
                    	<ul>
                    		<li>
                            	<label>Full Name : </label> <asp:Label ID="lblFullName" runat="server" ></asp:Label> 
                            </li>
                            <li>
                            	<label>Date Of Birth : </label> <asp:Label ID="lblDOB" runat="server"></asp:Label>
                            <li>
                            	<label>Nationality :</label><asp:Label ID="lblNationality" runat="server" MaxLength="10" ></asp:Label> 
                            </li>
                            <li>
                            	<label>Gender  :</label><asp:Label ID="lblGender" runat="server" ></asp:Label>
                            </li>
                            <li>
                            	<label>Mother Tongue :</label><asp:Label ID="lblMotherTongue" runat="server" MaxLength="15" ></asp:Label> 
                            </li>
                            <li>
                            	<label>Any Medical Problems :</label> <asp:Label ID="lblMedicalproblems" runat="server" 
                        TextMode="MultiLine" ></asp:Label>
                            </li>
                        </ul>
                    </section>
                    <section class="col1">
                    	<ul>
                    		<li>
                            	<label>Photo : </label> <asp:Image Style="font-weight: bold" ID="Image1" runat="server" alt=" " Height="94" Width="94"/> 
                            </li>
                            <li>
                            	<label>Place of Birth :</label> <asp:Label ID="lblBithPlace" runat="server" ></asp:Label> 
                            </li>
                             <li>
                            	<label>Blood-Group :</label><asp:Label ID="lblBloodGroup" runat="server" ></asp:Label> 
                            </li>
                            <li>
                            	<label>Caste : </label> <asp:Label ID="lblCaste" runat="server" ></asp:Label> 
                            </li>
                            <li>
                            	<label>Sub - Caste  : </label><asp:Label ID="lblSubcaste" runat="server" ></asp:Label>
                            </li>
                            <li>
                            	<label>Date of Joining : </label> <asp:Label ID="lblDOJ" runat="server"  ></asp:Label>
                            </li>
                        </ul>
                    </section>
                </fieldset>
                <h1>Education <span>Details</span></h1>
                <fieldset>
                	<section class="col1">
                    	<ul>
                    	    <li>
                            	<label>Highest Degree  : </label><asp:Label ID="lblHihestDegree" runat="server"></asp:Label> 
                            </li>
                             <li>
                            	<label>Specialization: </label><asp:Label ID="lblSpecialization" runat="server"></asp:Label> 
                            </li>
                            <li>
                            	<label>Completed On Year : </label><asp:Label ID="lblCopleteYear" runat="server"></asp:Label> 
                            </li>
                            <li>
                            	<label>University : </label><asp:Label ID="lblUniversity" runat="server" MaxLength="100" ></asp:Label>
                            </li>
                        </ul>
                    </section>
                    <section class="col1">
                    </section>
                </fieldset>
                <h1>Residence <span>Details</span></h1>
                <fieldset>
                	<section class="col1">
                    	<ul>
                    		<li>
                            	<label>Residence Address :</label>  <asp:Label ID="lblAddress" runat="server" TextMode="MultiLine"></asp:Label>
                            </li>
                            <li>
                            	<label>Mobile No : </label> <asp:Label ID="lblmobileNo" runat="server" ></asp:Label>
                            </li>
                            <li>
                            	<label>Residence Phone :</label>  <asp:Label ID="lblResidencePhone" runat="server"></asp:Label>
                            </li>
                            <li>
                            	<label>Email ID </label> <asp:Label ID="lblEmailID" runat="server" ></asp:Label>
                            </li>
                        </ul>
                    </section>
                    <section class="col1">
                    	<ul>
                            <li>
                            	<label>Country : </label><asp:Label ID="lblCountry" runat="server" ></asp:Label> 
                            </li>
                            <li>
                            	<label id="SState" runat="server">State : </label><asp:Label ID="lblState" runat="server"></asp:Label> 
                            </li>
                    		<li>
                            	<label id="SCity" runat ="server">City : </label><asp:Label ID="lblCity" runat="server"></asp:Label> 
                            </li>
                            <li>
                            	<label>Pin : </label><asp:Label ID="lblPin" runat="server" ></asp:Label> 
                            </li>
                        </ul>
                    </section>
                </fieldset>
                <h1>Experience <span>Details</span></h1>
                 <fieldset>
                 <section class="col1">
                 <ul>
                    		<li>
                            	<label style="width :47%">Last School Was (If Applicable) :</label><asp:Label ID="lblLastSchoolWas" runat="server" MaxLength="100" ></asp:Label>
                            </li>
                            <li >
                            	<label style="width :47%">Last School From :</label> <asp:Label ID="lblLastSchoolFrom" runat="server" MaxLength="10" ></asp:Label>
                            </li>
                             <li>
                            	<label style="width :47%">Last School To :</label> <asp:Label ID="lblLastSchoolTo" runat="server" MaxLength="10" ></asp:Label>
                            </li>
                             <li>
                            	<label style="width :47%">Total Experience(In Month):</label> 
                            	<asp:Label ID="lblTotalExpInMonth" runat="server" MaxLength="10" ></asp:Label>             
                            </li>
                             <li>
                                <label style="width :47%">Total Experience(In Year):</label> <asp:Label ID="lblTotalExpInYear" runat="server" MaxLength="10" ></asp:Label>             
                           </li>
                            </ul>
                 </section>
                 <section class="col1">
                    	<ul>
                    	<li></li>
                    	<li></li>
                    	<li></li>
                           </ul></section>
                 </fieldset>
                 </section>
    <section id="SectionEditProfile" runat="server">
                 	<h1>Edit <span>Profile</span> </h1>
                   <section class="tab_des_wrapp" id="SectionAddNewTeacher" runat="server" style="margin:9px 0px -4px 0px;">
                                  <section class="tabsec_topsecn">
                            <section class="browsimg">
                            <section class="student_img_box lF">
                             <asp:Image ID="Image2" runat="server" style="height:94px;width:94px;" />
                            </section>
                            <section class="lF" style="margin:40px 0px 0px 20px;">
                           <asp:FileUpload id="FileUpload1" runat="server" /> 
                            </section>
                              <section class="clear"></section>
                            </section>
                            </section>
                           <section class="greentitle">Personal Details</section>
                             <section class="tabsec_topsecn">           
                   			  <fieldset>
                				 	 <section class="col1">
                    	<ul>
                    		<ul>
                    		<li>
                            	<label>Full Name : <span style="color:Red">*</span></label> <asp:TextBox ID="txtFullName" runat="server"  CssClass="forminputtab4"
                                    MaxLength="20" ></asp:TextBox> 
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ErrorMessage="Please Enter Teacher Name" ControlToValidate="txtFullName" 
                                    ValidationGroup="sub">.</asp:RequiredFieldValidator>
                            </li>
                            <li>
                            	<label>Middle Name :</label> <asp:TextBox ID="txtMiddleName" runat="server"  CssClass="forminputtab4"
                                    MaxLength="20" ></asp:TextBox> 
                                   
                            </li>
                            <li>
                            	<label>Last Name : <span style="color:Red">*</span></label> <asp:TextBox ID="txtLatName" runat="server"  CssClass="forminputtab4"
                                    MaxLength="20" ></asp:TextBox> 
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                    ErrorMessage="Please Enter Teacher Last Name" ControlToValidate="txtLatName" 
                                    ValidationGroup="sub">.</asp:RequiredFieldValidator>
                            </li>
                           
                            <li>
                            	<label>Nationality :</label><asp:TextBox ID="txtNationality" runat="server" CssClass="forminputtab4"
                                    MaxLength="10" ></asp:TextBox> 
                            </li>
                            <li>
                            	<label>Gender  :</label>
                            	 <asp:DropDownList ID="ddlGender" runat="server" CssClass="tab4_small" >
                                    <asp:ListItem>Select</asp:ListItem>
                                    <asp:ListItem>Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                  </asp:DropDownList>
                            </li>
                            <li>
                            	<label>Mother Tongue :</label><asp:TextBox ID="txtMotherTongue" runat="server" MaxLength="15"  CssClass="forminputtab4" ></asp:TextBox> 
                            </li>
                            <li>
                            	<label>Any Medical Problems :</label> <asp:TextBox ID="txtMedicalproblems" runat="server" CssClass="textare4"
                        TextMode="MultiLine" ></asp:TextBox>
                            </li>
                        </ul>
                        </ul>
                    </section>
                  				 	 <section class="col1">
                        <ul>
                         <li>
                            	<label>Date Of Birth : <span style="color:Red">*</span></label> <asp:TextBox ID="txtDOB" runat="server" CssClass="forminputtab4"></asp:TextBox>
                            
                        <cc1:CalendarExtender ID="CalendarExtender2" TargetControlID="txtDOB" runat="server"></cc1:CalendarExtender>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ErrorMessage="Please Enter Birth Date" ControlToValidate="txtDOB" 
                                    ValidationGroup="sub">.</asp:RequiredFieldValidator>
                            </li>
                            <li>
                            	<label>Place of Birth :</label> <asp:TextBox ID="txtBithPlace" runat="server"  CssClass="forminputtab4"
                                    MaxLength="50" ></asp:TextBox> 
                            </li>
                             <li>
                            	<label>Blood-Group :</label><asp:DropDownList ID="ddlBloddGroup" runat="server"  CssClass="tab4_small" >
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>A(+ve)</asp:ListItem>
                        <asp:ListItem>A(-ve)</asp:ListItem>
                         <asp:ListItem>B(+ve)</asp:ListItem>
                        <asp:ListItem>B(-ve)</asp:ListItem>
                         <asp:ListItem>AB(+ve)</asp:ListItem>
                        <asp:ListItem>AB(-ve)</asp:ListItem>
                         <asp:ListItem>O(+ve)</asp:ListItem>
                        <asp:ListItem>O(-ve)</asp:ListItem>
                    </asp:DropDownList>
                            </li>
                            <li>
                            	<label>Caste :</label> <asp:TextBox ID="txtCaste" runat="server"  CssClass="forminputtab4"
                                    MaxLength="50" ></asp:TextBox> 
                            </li>
                            <li>
                            	<label>Sub - Caste  : </label><asp:TextBox ID="txtSubcaste" runat="server"  CssClass="forminputtab4"
                                    MaxLength="50" ></asp:TextBox><cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender7" ValidChars="abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
                            runat="server" Enabled="True" TargetControlID="txtSubcaste">
                        </cc1:FilteredTextBoxExtender>
                            </li>
                            <li>
                            	<label>Date of Joining :</label> <asp:TextBox ID="txtDOJ" runat="server" CssClass="forminputtab4"
                            	 ></asp:TextBox>
                                 <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtDOJ">
                        </cc1:CalendarExtender>
                            </li>
                        </ul>
                    </section>
                 			  </fieldset>
                            <section class="clear"></section>
                            </section>       
                                <section class="greentitle">Education Details</section>
                                
                                <section class="tabsec_topsecn">           
                   			  <fieldset>
                				 <section class="col1">
                    	<ul>
                    	    <li>
                            	<label>Highest Degree  : <span style="color:Red">*</span></label>
                                <%--<asp:DropDownList ID="ddlHighestDegree" runat="server"  CssClass="tab4_small">
                                 </asp:DropDownList>--%>
                                 <asp:TextBox ID="txtHeighestDegree" runat="server" CssClass="forminputtab4" MaxLength="50"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ErrorMessage="Please Enter Heighest Degree" ControlToValidate="txtHeighestDegree" 
                                    ValidationGroup="sub">.</asp:RequiredFieldValidator>
                            </li>
                             <li>
                            	<label>Specialization Subject  : </label><asp:DropDownList ID="ddlSpeciallization" runat="server"  CssClass="tab4_small">
                    </asp:DropDownList>
                            </li>
                            <li>
                            	<label>Completed On Year : </label><asp:DropDownList ID="ddlCompletedYear" runat="server"  CssClass="tab4_small">
                    </asp:DropDownList>
                            </li>
                            <li>
                            	<label>University : </label><asp:TextBox 
                                    ID="txtUniversity" runat="server" MaxLength="100"  CssClass="forminputtab4"></asp:TextBox>
                            </li>
                        </ul>
                    </section>
                 			  </fieldset>
                            <section class="clear"></section>
                            </section>
                            <section class="greentitle">Residence Details</section>
                                
                                <section class="tabsec_topsecn">           
                   			  <fieldset>
                				 	<section class="col1">
                    	<ul>
                    		<li>
                            	<label>Residence Address :</label>  <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" CssClass="textare4"></asp:TextBox>
                            </li>
                            <li>
                            	<label>Mobile No : </label> <asp:TextBox ID="txtmobileNo" runat="server" 
                                    MaxLength="10" CssClass="forminputtab4"></asp:TextBox>
                                     	 <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" TargetControlID="txtmobileNo"
                                ValidChars="0123456789">
                            </cc1:FilteredTextBoxExtender>  
                            </li>
                            <li>
                            	<label>Residence Phone :</label>  <asp:TextBox ID="txtResidencePhone" runat="server" CssClass="forminputtab4"></asp:TextBox>
                	 <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server" TargetControlID="txtResidencePhone"
                                ValidChars="0123456789">
                            </cc1:FilteredTextBoxExtender>  
                            </li>
                            <li>
                            	<label>Email ID <span style="color:Red">*</span></label> 
                            	<asp:TextBox ID="txtEmailID" runat="server" onblur="CheckEmailAvailability('Student')" MaxLength="100"  CssClass="forminputtab4"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" SetFocusOnError="true" 
                                    ErrorMessage="Required" ControlToValidate="txtEmailID" Display="Dynamic"
                                    ValidationGroup="sub"></asp:RequiredFieldValidator>
                                 <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid Email Format"
                                        SetFocusOnError="true" ControlToValidate="txtEmailID" ValidationGroup="sub"
                                        Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                          <div class="err_msg">
                           <asp:Label ID="lblEmailMsg" style="line-height:18px!important;" runat="server"></asp:Label>
                          </div>
                          <asp:HiddenField ID="hfAlertText"  runat="server" />
                            </li>
                        </ul>
                    </section>
                    <section class="col1">
                    	<ul>
                            <li>
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                            <ContentTemplate>
                            	<label>Country : </label><asp:DropDownList ID="ddlCountry" runat="server" CssClass="tab4_small" AutoPostBack ="true" onselectedindexchanged="ddlCountry_SelectedIndexChanged">
                    </asp:DropDownList>
                    </ContentTemplate>
                  </asp:UpdatePanel>
                            </li>
                            <li>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                            	<label id="State" runat="server">State : </label><asp:DropDownList ID="ddlState" runat="server" CssClass="tab4_small" AutoPostBack ="true" onselectedindexchanged="ddlState_SelectedIndexChanged">
                                <asp:ListItem Value="0" >Select</asp:ListItem>
                    </asp:DropDownList>
                     </ContentTemplate>
                  </asp:UpdatePanel>
                            </li>
                    		<li>
                    		 <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                            	<label id="City" runat ="server">City : </label><asp:DropDownList ID="ddlCity" CssClass="tab4_small" runat="server" >
                                <asp:ListItem Value="0" >Select</asp:ListItem>
                    </asp:DropDownList>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                            </li>
                            <li>
                            	<label>Pin : </label><asp:TextBox ID="txtPin" runat="server" MaxLength="6"    CssClass="forminputtab4"></asp:TextBox> 
                            	 <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" TargetControlID="txtPin"
                                ValidChars="0123456789">
                            </cc1:FilteredTextBoxExtender>    
                            </li>
                        </ul>
                    </section>
                 			  </fieldset>
                            <section class="clear"></section>
                            </section>
                            <section class="greentitle">Exprience Details</section>
                                
                                <section class="tabsec_topsecn">           
                   			  <fieldset>
                				  <section class="col1">
                          <ul>
                    		<li>
                            	<label>Last School Was (If Applicable) :</label><asp:TextBox 
                                    ID="txtLastSchoolWas" runat="server" MaxLength="100"  CssClass="forminputtab4"></asp:TextBox>
                            </li>
                            <li>
                            	<label>Last School From :</label> 
                                <asp:TextBox ID="txtLastSchoolFrom" runat="server" MaxLength="10" CssClass="forminputtab4"></asp:TextBox>
                            </li>
                            <cc1:CalendarExtender ID="CalendarExtender4" runat="server" TargetControlID="txtLastSchoolFrom">
                        </cc1:CalendarExtender>
                             <li>
                            	<label>Last School To :</label> 
                                <asp:TextBox ID="txtLastSchoolTo" runat="server" MaxLength="10" CssClass="forminputtab4"></asp:TextBox>
                            </li>
                              <cc1:CalendarExtender ID="CalendarExtender5" runat="server" TargetControlID="txtLastSchoolTo">
                        </cc1:CalendarExtender>
                         <li>
                            	<label>Total Experience(In Month):</label> 
                            	<asp:TextBox ID="txtTotalExpInMonth" runat="server" MaxLength="5"  CssClass="forminputtab4"></asp:TextBox>             
                              <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" TargetControlID="txtTotalExpInMonth"
                                ValidChars="0123456789">
                            </cc1:FilteredTextBoxExtender>    
                            </li>
                             <li><label>Total Experience(In Year):</label> 
                            	<asp:TextBox ID="txtTotalExpInYear" runat="server" MaxLength="5" CssClass="forminputtab4"></asp:TextBox>
                            	<cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender4" runat="server" TargetControlID="txtTotalExpInYear"
                                ValidChars="0123456789">
                            </cc1:FilteredTextBoxExtender>             
                            	</li>
                            </ul>
                 </section>
                 <section class="col1">
                    	<ul>
                    	<li></li>
                    	<li></li>
                    	<li></li>
                           </ul></section>
                 			  </fieldset>
                            <section class="clear"></section>
                            </section>
       <section class="save_bt_box_small" style="padding-right:377px; margin:21px 0 8px 0;">
                                      <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click"  Text="Save" ValidationGroup="sub"/>
                           <asp:Button ID="btnCancel" runat="server" OnClick="btnCancelOne_Click"  Text="Cancel"/>
                                    </section>      
                           </section>
                 </section>
</asp:Content>
