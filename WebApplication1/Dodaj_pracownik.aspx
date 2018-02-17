<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dodaj_pracownik.aspx.cs" Inherits="WebApplication1.Dodaj_pracownik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#ffd480">
    <center><h1>Dodawanie pracownika:</h1>
        
    <form id="form1" runat="server">
         <asp:GridView ID="GridView4" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-right: 1px" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id_pracownika" HeaderText="id_pracownika" ReadOnly="True" SortExpression="id_pracownika" />
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

        <div>


           <font size="5.5">
            Imie:                          <asp:TextBox ID="imie" runat="server"></asp:TextBox><br /><br />
            Nazwisko:                      <asp:TextBox ID="nazwisko" runat="server"></asp:TextBox><br /><br />
            Pesel:                        <asp:TextBox ID="pesel" runat="server"></asp:TextBox><br /><br />
            Numer Magazynu:                    <asp:TextBox ID="id_magazynu" runat="server"></asp:TextBox><br /><br />
            <br />

            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Powrót" />
&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Dodaj do bazy" />

            </font></div>
    </form></center>
    <p>
&nbsp;</p>
</body>
</html>
