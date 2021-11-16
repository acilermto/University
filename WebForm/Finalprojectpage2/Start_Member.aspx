<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start_Member.aspx.cs" Inherits="Finalprojectpage2.Start_Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" Font-Size="Large" GroupingText="註冊" Height="420px">
                <br />
                <asp:Label ID="Label1" runat="server" Text="使用者名稱"></asp:Label>
                &nbsp;
                <asp:TextBox ID="name_tb" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name_tb" ErrorMessage="請輸入使用者名稱"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="帳號"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="acc_tb" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="acc_tb" ErrorMessage="請輸入帳號"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="密碼"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="passwd_tb" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="passwd_tb" ErrorMessage="請輸入密碼"></asp:RequiredFieldValidator>
                <br />
                <br />
                確認<asp:Label ID="Label6" runat="server" Text="密碼"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="check_passwd_tb" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="check_passwd_tb" ControlToValidate="passwd_tb" ErrorMessage="兩次密碼不一致"></asp:CompareValidator>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="性別"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="sex_ddl" runat="server" Height="16px" Width="77px">
                    <asp:ListItem>男</asp:ListItem>
                    <asp:ListItem>女</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="電子信箱"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="mail_tb" runat="server"></asp:TextBox>
                @gmail.com&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="認證電子信箱" />
                <br />
                &nbsp;<br /><br /><asp:CheckBox ID="check_cb" runat="server" Text="同意會員條款，並進行註冊" />
&nbsp;
                <asp:Label ID="OK_lb" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Test_lb" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Button ID="register_bt" runat="server" OnClick="Button1_Click" Text="註冊" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="chat" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="返回" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
