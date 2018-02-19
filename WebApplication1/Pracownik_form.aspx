<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pracownik_form.aspx.cs" Inherits="WebApplication1.Pracownik_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#995e34"><center>
    <form id="form1" runat="server">
        <div> <h1>Pracownicy<br /></h1>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-right: 1px" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="imie" HeaderText="imie" SortExpression="imie" />
                <asp:BoundField DataField="nazwisko" HeaderText="nazwisko" SortExpression="nazwisko" />
                <asp:BoundField DataField="pesel" HeaderText="pesel" SortExpression="pesel" />
                <asp:BoundField DataField="magazyn" HeaderText="magazyn" SortExpression="magazyn" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbad_s426150ConnectionString %>" SelectCommand="SELECT * FROM [_Pracownicy]"></asp:SqlDataSource>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Powrot do menu" />
<br /><br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Dodaj pracownika" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" Text="Usuń pracownika" />
            <br />
        </div></center>
    </form>
</body>
</html>
