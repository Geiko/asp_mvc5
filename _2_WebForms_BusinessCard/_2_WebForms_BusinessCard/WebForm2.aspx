<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_2_WebForms_BusinessCard.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebForms</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/stylesheet.css" rel="stylesheet" />
    <link href="Content/stylesheet.css" rel="stylesheet" />
</head>
<body class="body2">
    <form id="form2" runat="server">
        <div>
            <nav class="navbar navbar-default">
              <div class="container">

                <div class="navbar-header">
                  <a class="navbar-brand company" href="WebForm1.aspx">BMFN</a>
                </div>

                <ul class="nav navbar-nav">
                  <li><a href="WebForm1.aspx">Home</a></li>
                  <li class="active"><a href="WebForm2.aspx">Our Emploees</a></li>
                  <li><a href="WebForm3.aspx">Contact Us</a></li>  
                </ul>
              </div>
            </nav>

            <div class="container">
                <div class="row">
                    <div class="col-md-8 col-md-offset-2 text-center">
                        <h3>All Employees</h3>
                        <table class="table table-bordered table-hover">
                            <tr class="info">
                                <td>#</td>
                                <td>Name</td>
                                <td>Department</td>
                                <td>Position</td>
                                <td>Salary</td>
                            </tr>
                            <asp:Label ID="Output2" runat="server"/>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
