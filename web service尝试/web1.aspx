<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="web1.aspx.cs" Inherits="web_service尝试.web1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;+
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            =<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="相加" />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;-<asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style1"></asp:TextBox>
        =
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="减法" />
        <br />
        <br />
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;*
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
&nbsp;=<asp:TextBox ID="TextBox9" runat="server" CssClass="auto-style1"></asp:TextBox>
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="乘法" />
    </form>
</body>
</html>
