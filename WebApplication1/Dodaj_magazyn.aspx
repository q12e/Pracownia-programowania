<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dodaj_magazyn.aspx.cs" Inherits="WebApplication1.Dodaj_magazyn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body bgcolor="#995e34">
   <center><h1>Dodawanie magazynu:</h1>
           <form id="form1" runat="server">
         <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-right: 1px" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="nazwa" HeaderText="nazwa" SortExpression="nazwa" />
                <asp:BoundField DataField="miasto" HeaderText="miasto" SortExpression="miasto" />
                <asp:BoundField DataField="adres" HeaderText="adres" SortExpression="adres" />
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
                   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbad_s426150ConnectionString %>" SelectCommand="SELECT * FROM [_Magazyny]"></asp:SqlDataSource>



        <div>


           <font size="5.5">
            Nazwa:                       <asp:TextBox ID="naz" runat="server"></asp:TextBox><br /><br />
            Miasto:                      <asp:TextBox ID="miasto1" runat="server"></asp:TextBox><br /><br />
            Adres:                   <asp:TextBox ID="adres1" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="Button1" runat="server" Text="Powrot" OnClick="Button1_Click1" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Dodaj do bazy" />
            <br />

            </font></div>
    </form></center>
</body>
</html>
