<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu_form.aspx.cs" Inherits="WebApplication1.Menu_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Baza Magazynow</title>

</head>
<body bgcolor="#995e34">
       <center> <h1> Baza Magazynow</h1>
    <form id="form2" runat="server">
        <div>
             </div>
       
        <asp:Button ID="Button1" runat="server" Text="Pracownicy" OnClick="Button1_Click"  /><br /><br />
        <asp:Button ID="Button3" runat="server" Text="Towary" OnClick="Button3_Click" /><br /><br />
        <asp:Button ID="Button2" runat="server" Text="Magazyny" OnClick="Button2_Click" style="height: 26px" /><br /><br />
    </form></center>
</body>
</html>
