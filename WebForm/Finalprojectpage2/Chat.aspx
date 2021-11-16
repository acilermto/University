<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="Finalprojectpage2.Chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            聊天訊息</p>
        <asp:Panel ID="message_pannel" runat="server" Height="58px" style="margin-bottom: 0px">
            &nbsp;<asp:Label ID="name_lb" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="message_tb" runat="server" Height="22px" Width="658px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="send_bt" runat="server" Text="傳送" OnClick="send_bt_Click" />
        </asp:Panel>
        </p>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:Label ID="message_lb" runat="server"></asp:Label>
                <br />
                <asp:Timer ID="Timer1" runat="server" Interval="1000">
                </asp:Timer>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
