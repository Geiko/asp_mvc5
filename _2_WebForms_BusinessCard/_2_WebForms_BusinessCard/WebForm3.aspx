<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="_2_WebForms_BusinessCard.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/stylesheet.css" rel="stylesheet" />
    <link href="Content/stylesheet.css" rel="stylesheet" />
</head>
<body class="body3">
    <form id="form3" runat="server">
        <div>
            <nav class="navbar navbar-default">
              <div class="container">

                <div class="navbar-header">
                  <a class="navbar-brand company" href="WebForm1.aspx">BMFN</a>
                </div>

                <ul class="nav navbar-nav">
                  <li><a href="WebForm1.aspx">Home</a></li>
                  <li><a href="WebForm2.aspx">Our Emploees</a></li>
                  <li class="active"><a href="WebForm3.aspx">Contact Us</a></li>  
                </ul>
              </div>
            </nav>

            <div class="row">

                <div class="col-md-4 col-md-offset-1">
                    <asp:Label ID="Output3" runat="server" />
                </div>



                <div class="col-md-5 col-md-offset-1 form1">

                    <h1>General Inquiries</h1>

                    <div class="row string">
                        <div class="col-md-4 col-md-offset-1 text-center">
                            <span>Login</span>
                        </div>
                        <div class="col-md-7">
                            <asp:TextBox ID="LoginTextBox" TextMode="Password" runat="server" class="input"/>
                        </div>
                    </div>

                    <div class="row string">
                        <div class="col-md-4 col-md-offset-1 text-center">
                            <span>Email</span>
                        </div>
                        <div class="col-md-7">
                            <asp:TextBox ID="EmailTextBox" TextMode="Email" runat="server" class="input" />
                        </div>
                    </div>
                        
                    <div class="col-md-12">
                        <span>Comments or questions:</span>
                    </div>    
                    <asp:TextBox ID="MessageTextBox" TextMode="MultiLine" runat="server" class="questions"/>
                        
                    <div class="row">                        
                        <div class="col-md-12 center-block">
                            <asp:Button ID="Button1" Text="Submit" runat="server" class="btn btn-danger btn-lg" OnClick="Button1_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
