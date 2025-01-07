<%@ Page Language="C#" AutoEventWireup="true" CodeFile="_3121.aspx.cs" Inherits="demo1._3121" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Image Slideshow and File Upload</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; padding: 20px;">
            <!-- Image Slideshow -->
            <asp:Image ID="Image1" runat="server" Width="500px" Height="300px" />
            <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick" />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <br /><br />

            <!-- File Upload Section -->
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Upload File" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>
