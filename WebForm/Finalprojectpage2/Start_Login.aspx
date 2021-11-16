<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start_Login.aspx.cs" Inherits="Finalprojectpage2.Start_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 登入頁面<br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="帳號"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="acc_tb" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="密碼"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="password_tb" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="test" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="login_bt" runat="server" OnClick="login_bt_Click" Text="登入" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="register_bt" runat="server" OnClick="register_bt_Click" Text="註冊" />
    </form>
</body>
</html>
