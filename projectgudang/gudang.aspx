<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gudang.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <title> Tambah gudang</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h2> Tambah Barang</h2>
            <div class="form-group">
                    <label for="exampleInputPassword1">Id Barang</label>
                    <asp:Textbox type="number" class="form-control" runat="server" ID="id_barang" placeholder="id_barang"></asp:Textbox> 
            </div>
            <div class="form-group">
                    <label for="exampleInputPassword1">Nama Barang</label>
                    <asp:Textbox type="text" class="form-control" id="nama_barang" runat="server" placeholder="nama_barang"></asp:Textbox>
            </div>
            <div class="form-group">
                    <label for="exampleInputPassword1">Stock</label>
                    <asp:Textbox type="number" class="form-control" id="stock" runat="server" placeholder="stock"></asp:Textbox>
            </div>
            <div class="form-group">
                    <label for="exampleInputPassword1">Tanggal Masuk</label>
                    <asp:Textbox type="date" class="form-control" id="tanggal_masuk" runat="server" placeholder="tanggal_masuk"></asp:Textbox>
            </div>
            <div class="form-group">
                    <label for="exampleInputPassword1">Tanggal Keluar</label>
                    <asp:Textbox type="date" class="form-control" id="tanggal_keluar" runat="server" placeholder="tanggal_keluar"></asp:Textbox>
            </div>
            <div class="form-group">
                    <label for="exampleInputPassword1">Keterangan</label>
                    <asp:Textbox type="text" class="form-control" id="keterangan" runat="server" placeholder="keterangan"></asp:Textbox>
            </div>
            <div class="form-group">
                    <label for="exampleInputPassword1">Id Karyawan</label>
                    <asp:Textbox type="number" class="form-control" id="id_karyawan" runat="server" placeholder="id_karyawan"></asp:Textbox>
            </div>  
            <asp:Button ID="Button1" runat="server" Text="Tambah" class="btn btn-primary" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" class="btn btn-info" OnClick="Button2_Click1" Text="Edit" />
            <asp:Button ID="Button3" runat="server" class="btn btn-danger" OnClick="Button3_Click1" Text="Hapus" />
    </div>    
       
    </form>
</body>
</html>
