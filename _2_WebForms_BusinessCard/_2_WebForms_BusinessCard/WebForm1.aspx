<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2_WebForms_BusinessCard.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/stylesheet.css" rel="stylesheet" />
</head>
<body class="body1">
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-default">
              <div class="container">

                <div class="navbar-header">
                    <a class="navbar-brand company" href="WebForm1.aspx">BMFN</a>
                </div>

                <ul class="nav navbar-nav">
                      <li class="active"><a href="WebForm1.aspx">Home</a></li>
                      <li><a href="WebForm2.aspx">Our Emploees</a></li>
                      <li><a href="WebForm3.aspx">Contact Us</a></li>  
                </ul>
              </div>
            </nav>

            <div class="jumbotron">
                <h1 class="text-center">We are a Global Company</h1>
                <p class="text-center">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
            </div>
        </div>
    </form>
</body>
</html>
