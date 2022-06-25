<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewGudang.aspx.cs" Inherits="Account_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <title> Gudang Minimarket</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="card">
            <h2> Tabel Barang Minimarket</h2>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="223px" Width="861px">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
     <asp:Button ID="Button1" runat="server" Text="Tambah Data" class=" btn btn-primary" OnClick="Button1_Click" />   
     <asp:Button ID="Button2" runat="server" Text="Refresh Data" class=" btn btn-info"  OnClick="Button2_Click" />
     <asp:Button ID="Button3" runat="server" Text="Logout" class=" btn btn-danger" OnClick="Button3_Click" />  
    </div>
    </form>
</body>
</html>
