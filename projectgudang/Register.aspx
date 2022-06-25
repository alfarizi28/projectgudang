<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous"/>
    <title>Form Daftar Karyawan</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-title">
                    <h1>Form Daftar Karyawan</h1>
                </div>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <div class="card-body">
                    <div class="form-group">
                        &nbsp;<label for="nama_karyawan">Nama Karyawan</label>
                        &nbsp;<asp:TextBox type="text" ID="nama_karyawan" class="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        &nbsp;<label for="email">Email</label>
                        &nbsp;<asp:TextBox type="text" ID="email" class="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        &nbsp;<label for="password">Password</label>
                        &nbsp;<asp:TextBox type="text" ID="password" class="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        &nbsp;<label for="no_hp">No. Handphone</label>
                        &nbsp;<asp:TextBox type="number" ID="no_hp" class="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        &nbsp;<label for="alamat">Alamat</label>
                        &nbsp;<asp:TextBox type="text" ID="alamat" class="form-control" runat="server"></asp:TextBox>
                    </div>
                    <br />
                            <p>Sudah memiliki akun? <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Login</asp:LinkButton></p>
                        
                    <div class="form-group">
                        <asp:Button ID="Submit" class="btn btn-primary" runat="server" Text="Register" OnClick="Button1_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
