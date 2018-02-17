﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usun_towar.aspx.cs" Inherits="WebApplication1.Usun_towar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body bgcolor="#ffd480">
    <form id="form1" runat="server">
        <div><center>
            <h1>Usuwanie Towaru:</h1>
             <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-right: 1px" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="nazwa" HeaderText="nazwa" SortExpression="nazwa" />
                <asp:BoundField DataField="ilosc" HeaderText="ilosc" SortExpression="ilosc" />
                <asp:BoundField DataField="cena" HeaderText="cena" SortExpression="cena" />
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
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbad_s426150ConnectionString %>" SelectCommand="SELECT * FROM [_Towar]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:dbad_s426150ConnectionString %>" SelectCommand="SELECT * FROM [_Towar]"></asp:SqlDataSource>

            <br /><br />
            <font size="5.5">Podaj Id towaru:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="IdTowaru" runat="server" ></asp:TextBox><br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Powrót" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Usuń" />
            <br />
        </div></center>
    </form>
</body>
</html>
