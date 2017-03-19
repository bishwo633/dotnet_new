<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyFirstWebForm.aspx.cs" Inherits="WebApplicationWebForms.MyFirstWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style type="text/css">
        .mystyle {
            background-color: chocolate;
        }
    </style>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" CssClass="mystyle"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
