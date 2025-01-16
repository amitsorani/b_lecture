<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="numberaddition.aspx.cs" Inherits="demo1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Addition</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Label ID="Label1" runat="server" Text="Num 1"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Num 2"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br /><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br /><br />
            <asp:Label ID="ResultLabel" runat="server" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
