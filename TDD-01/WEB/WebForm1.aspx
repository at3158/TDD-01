<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TDD_01.WEB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="TEST"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        +<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        =<asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="cal" OnClick="Button1_Click" />
        <br />
        <br />
        <br />
         <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        -<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        =<asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="min" OnClick="Button2_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
