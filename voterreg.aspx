<%@ Page Language="C#" AutoEventWireup="true" CodeFile="voterreg.aspx.cs" Inherits="voterreg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
      <title>: : Online Voting System : :</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <link href="css/application.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="stylesheet" type="text/css" />
      <style type="text/css">
          .style1
          {
              width: 100%;
          }
      </style>
      <style type="text/css">
      
      .text
      {
          
    width:229px; 
    height:25px;
    border:1px solid #d7d7c8;
    background:#fff;
    padding:3px 5px; 
    margin-bottom:5px;
    color:#969696;
    font:13px Trebuchet MS, Arial, Helvetica, sans-serif;"
          
          }
          .style2
          {
              font-size: x-small;
          }
      </style>
</head>
<body>
    <form id="form1" runat="server">
  <div id="dvmaincontainer">
  <!--main div container starts here-->
  <div id="dvtopcontainer">
    <!-- top container starts here-->
    <div id="dvlogocontainer">
      <!-- logo container starts here-->
	  <h1 >Online Voting System </h1>
	  <h4>Best way to choose your </h4>
      
      <!-- logo container ends here-->
    </div>
    <div id="dvnavicontainer">
      <!-- navogation div starts here-->
      <img src="images/navi_left.jpg" alt="" />
<div id="tabs1" >
        <ul>
          <!-- CSS Tabs -->
          <li ><a href="index.aspx"><span>Home</span></a></li>
          <li id="current"><a href="login.aspx"><span>Login</span></a></li>
          <li><a href="signup.aspx"><span>Sign Up</span></a></li>
          <li><a href="Results.aspx"><span>Results</span></a></li>
          <li><a href="AdminLogin.aspx"><span>About Us</span></a></li>
        </ul>
      </div>
      <img src="images/navi_right.jpg" alt="" />
      <!-- navogation div ends here-->
    </div>
    <!-- top container ends here-->
  </div>
  <div id="dvbodycontainer">
    <!-- body div starts here-->
    <div id="dvbannerbgcontainer" style="height:auto;">
      <!-- banner bg div starts here-->
    
     
      <!-- banner bg div ends here-->
    </div>
    <div id="dvleftpanel">
      <!-- left pannel div starts here-->
      <div id="topimage">
        <!-- top left div starts here-->
       CLIENT TESTIMONIALS 
        <!--<img src="images/client.jpg" alt="Client Testimonials" width="274" height="34" title="Client Testimonials" /> -->
        <!-- top left div end here-->
      </div>
      <div id="midcont">
        <!-- left body div starts here-->
        <p>"Best services ever! I'd be lost without your company. Your company was great to work with and we look forward to dealing with you in the future. </p>
        <p>I would recommend your great services to anyone. I appreciate all your help and your passion for the environment."</p>
        <p><span>- Potential Client Testimonial</span></p>
        <!-- left body div ends here-->
      </div>
      <div id="leftfoot"><span>Nice little Sidebar</span>
        <p>This is where you can put some services text fillers.</p>
        <p>The more you put the better</p>
      </div>
      <!-- left pannel div ends here-->
    </div>
    <div id="dvrightpanel">
      <!-- right panel div starts here--> <div id="notice" class="error" runat="server"></div>
      <h1 style="border-bottom:1;">Voter Sign Up</h1>
      
      
      <div class="line"><img src="images/h_line.jpg" alt="" width="535	" height="1" title="" /></div>
     
      


     




  
     
        <table class="style1">
            <tr>
                <td colspan="2">
                    Account Information</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                   <label for="userid">User ID:</label></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="text"></asp:TextBox></td>
                <td>
                    [<span class="style2">Alpha-Numeric</span>]</td>
            </tr>
            <tr>
                <td>
                    <label for="Pass">Password:</label></td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="text" TextMode="Password"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                   <label for="email">Email:</label></td>
                <td>
                   <asp:TextBox ID="TextBox3" runat="server" CssClass="text"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="TextBox3" ErrorMessage="RegularExpressionValidator" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                   Personal Information</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
             <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                   <label for="fname">First Name:</label></td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="text"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TextBox4" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <label for="lname">Last Name:</label></td>
                <td>
                   <asp:TextBox ID="TextBox5" runat="server" CssClass="text"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="TextBox5" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                   <label for="f/h">Father/husband Name:</label></td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="text"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="TextBox6" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <label for="dob">Date of Birth:</label></td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="text"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="TextBox7" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                     <label for="gender">Gender:</label></td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="232px">
                        <asp:ListItem>Choose</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="DropDownList1" ErrorMessage="RequiredFieldValidator" 
                        InitialValue="Choose">*</asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr>
                <td>
                  <label for="contact">Contact Number:</label></td>
                <td>
                     <asp:TextBox ID="TextBox8" runat="server" CssClass="text"></asp:TextBox></td>
                <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                         ControlToValidate="TextBox8" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                 </td>
            </tr>
            <tr>
                <td>
                   <label for="add">Address:</label></td>
                <td>
                    <asp:TextBox ID="TextBox9" runat="server" Rows="3" 
                        TextMode="MultiLine" Width="230px"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="TextBox9" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <label for="city">City:</label></td>
                <td>
                     <asp:TextBox ID="TextBox10" runat="server" CssClass="text"></asp:TextBox></td>
                <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                         ControlToValidate="TextBox10" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                </td>
            </tr>
           
            <tr>
                <td>
                    <label for="image">Image:</label></td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Register" 
                        Width="110px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
     
      







  
     
      <!-- right panel div ends here-->
    </div>
    <!-- body div ends here-->
  </div>
  <div id="dvfootercontainer">
    <!-- footer div starts here-->
    <div id="foottop">
      <p><span>Copyright © 2008 Your Company Name</span> <a href="#" title="Home">Home</a><a href="#" title="Services">Services</a><a href="#" title="Portfolio">Portfolio</a><a href="#" title="Blog">Blog</a><a href="http://www.studio7designs.com">Eco Web Design by Studio7designs</a></p>
      <div class="design"> <a href="#"><img src="images/studio.jpg" alt="Studio7designs" border="0" title="Studio7designs" /></a> </div>
    </div>
    <!-- footer div ends here-->
  </div>
  <!--main div container ends here-->
</div>
    </form>
</body>
</html>
