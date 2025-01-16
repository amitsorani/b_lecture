<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="multiview_controll.aspx.cs" Inherits="demo1.multiview_controll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="view1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="This Is View 1"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" />
            </asp:View>
            <asp:View ID="view2" runat="server">
                <asp:Label ID="Label2" runat="server" Text="This is View 2"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Previous" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Next" />
            </asp:View>
            <asp:View ID="view3" runat="server">
                <asp:Label ID="Label3" runat="server" Text="This is View 3"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Previous" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Ok" />
            </asp:View>
        </asp:MultiView>
        <div>
        </div>
    </form>
</body>
</html>
