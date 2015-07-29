<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Welcome To schoolerpsoft</title>
     <link rel="shortcut icon" type="image/x-icon" href="img/favicon.ico">
    <link href="css/ie.css" rel="stylesheet" type="text/css" />
    <link href="css/main_layout.css" rel="stylesheet" type="text/css" />
    <link href="css/online_admission_form.css" rel="stylesheet" type="text/css" />
    <link href="css/admin.css" rel="stylesheet" type="text/css" />

    <%--<script src="js/html5.js" type="text/javascript"></script>--%>

    <script src="js/jquery-latest.min.js" type="text/javascript"></script>

    <script src="js/loopedslider.min.js" type="text/javascript"></script>

    <script language="javascript">
        function showOptions() {
            $("#optionmenu").toggle();
        }
    </script>

</head>
<body class="inner_page">
    <form id="form1" runat="server">
    <div>
        <!-- Header Start -->
        <header class="inner_hd">
        	<!-- Main Header Content Start -->
            	<section class="container">
                	<section class="admin_logo">
                        <a href="Default.aspx"><img src="img/final_logo.png" alt="Logo" title="Logo" /></a>
                    </section>

              
                        <section class="clear"></section>
                 
 
        </header>
        <!-- Header End -->
        <!-- Main Content Start -->
        <section class="container">
        	<section class="inner_container">
            <section class="inner_container_login">
            
            	<h1 class="txt_al_cen">User <span>LogIn</span></h1>
            	<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            	
                <fieldset class="user_login_box">

                <section class="loginbox rF" id="secLogin" runat="server">
                
                   <div class="errormss_login"><div id="dverror" runat="server" style="display: none; text-align:center; margin-bottom:10px;" class="errorbox">
                            <div >
                            <asp:Label  ID ="lblfmassage" runat ="server"   ></asp:Label>
                            </div>
                            <div >
                                <span id="lblMessage" style="color:Red" runat="server">
                                    <img src="../img/icon-warnning.png" />
                                </span>
                            </div>
                         
                           
                        </div>
                </div> 
            
                    	<ul class="userlogin" >
                        <li>

                            <asp:DropDownList ID="ddlLogintype" runat="server" class="select" style="width:291px!important;">
                             <asp:ListItem Value="0">Login As</asp:ListItem>
                                            <asp:ListItem Value="1">Principal</asp:ListItem>
                                            <asp:ListItem Value="2">Teacher</asp:ListItem>
                                             <asp:ListItem Value="8" Selected>Account Manager</asp:ListItem>                                          
                            </asp:DropDownList>
                        
                        </li>
                    		<li>
                        <asp:TextBox ID="txtUserName" Text="test@gmail.com" runat="server" CssClass="input" style="width:269px!important;"></asp:TextBox>
               <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender" WatermarkText="User Name"
                runat="server" Enabled="True" TargetControlID="txtUserName">
                </cc1:TextBoxWatermarkExtender>
                            	
                            </li>
                            <li>
                         <asp:TextBox ID="txtPassword" Text="123456" runat="server"  CssClass="input" style="width:269px!important;" ></asp:TextBox>
             <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1"  WatermarkText="Password"
            runat="server" Enabled="True" TargetControlID="txtPassword" >
             </cc1:TextBoxWatermarkExtender>        
                            </li>
                             <li style="min-height:20px!important;  text-align:left!important;">
                           
                                <asp:HyperLink ID ="hyperForgot" runat ="server"  NavigateUrl ="#url"   Text="Forgot Password"  >  </asp:HyperLink> 
                             </li> 
                            <section class="save_bt_box">
                      <asp:Button ID="btnLogin" runat="server" CssClass="loginbtn"  Text="Login"  onclick="btnLogin_Click"></asp:Button>
                
                </section>
                        </ul>
                        </section>

                              <section class="login_wrapp_inner sprite" id="secLogout" runat="server" style="display:none;">
									<section class="welcome_txt"></section>
                                   <!-- <h1> Rajeev Sharma</h1> -->
                                   <a href ="Management/DashboardPrincipal.aspx" id="hrefDashboard" runat="server"> <h1> <asp:Label ID="lblUser" runat="server"></asp:Label></h1></a>
                                    <article> <asp:Label ID="lblLoginType" runat="server"></asp:Label></article>
                                    <asp:Button ID="btnLogout" runat="server" Text="Logout" onclick="btnLogout_Click"></asp:Button>&nbsp;
                                </section>	
                   
                   
                </fieldset>
                  </section> 
                  </section>               
                  </section>
        <!-- Main Content End -->
        <!-- Footer Start -->
        <footer>
        	<section class="container">
            	<%-- <section class="ft_soc_box">
                	<span class="f_icon"><a href="#url"></a></span>
                    <span class="t_icon"><a href="#url"></a></span>
                    <span class="r_icon"><a href="#url"></a></span>
                    <section class="clear"></section>
                </section>
                <section class="ft_nav_box">
                	<a href="#url">Home</a> |
                    <a href="#url">About Us</a> |
                    <a href="#url">Rules &amp; Regulations</a> |
                    <a href="#url">Blog</a> |
                    <a href="#url">Testimonials</a> |
                    <a href="#url">Site Map</a> |
                    <a href="#url">Contact Us</a>
                </section>--%>
                <section class="copyright_box">&copy; 2015 asnasoftwaresolution.com. All Rights Reserved.</section>
            </section>
        </footer>
        <!-- Footer End -->
    </div>
    </form>
</body>
</html>