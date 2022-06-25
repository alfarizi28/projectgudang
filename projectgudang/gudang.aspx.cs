using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Npgsql;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Database=gudangfinal;Password=1234"))
        {
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Insert into barang values(@id_barang,@nama_barang,@stock,@tanggal_masuk,@tanggal_keluar,@keterangan,default)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new NpgsqlParameter("@id_barang", Convert.ToInt32(id_barang.Text)));
            cmd.Parameters.Add(new NpgsqlParameter("nama_barang", nama_barang.Text));
            cmd.Parameters.Add(new NpgsqlParameter("stock", stock.Text));
            cmd.Parameters.Add(new NpgsqlParameter("tanggal_masuk", tanggal_masuk.Text));
            cmd.Parameters.Add(new NpgsqlParameter("tanggal_keluar", tanggal_keluar.Text));
            cmd.Parameters.Add(new NpgsqlParameter("keterangan", keterangan.Text));
            cmd.Parameters.Add(new NpgsqlParameter("id_karyawan", id_karyawan.Text));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();
            id_barang.Text = "";
            nama_barang.Text = "";
            stock.Text = "";
            tanggal_masuk.Text = "";
            tanggal_keluar.Text = "";
            keterangan.Text = "";
            id_karyawan.Text = "";
        }

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Database=gudangfinal;Password=1234"))
        {
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "update barang set nama_barang=@nama_barang,stock=@stock,tanggal_masuk=@tanggal_masuk,tanggal_keluar=@tanggal_keluar,keterangan=@keterangan, id_karyawan=default where id_barang=@id_barang";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new NpgsqlParameter("@id_barang", Convert.ToInt32(id_barang.Text)));
            cmd.Parameters.Add(new NpgsqlParameter("nama_barang", nama_barang.Text));
            cmd.Parameters.Add(new NpgsqlParameter("stock", stock.Text));
            cmd.Parameters.Add(new NpgsqlParameter("tanggal_masuk", tanggal_masuk.Text));
            cmd.Parameters.Add(new NpgsqlParameter("tanggal_keluar", tanggal_keluar.Text));
            cmd.Parameters.Add(new NpgsqlParameter("keterangan", keterangan.Text));
            cmd.Parameters.Add(new NpgsqlParameter("id_karyawan", id_karyawan.Text));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();
            id_barang.Text = "";
            nama_barang.Text = "";
            stock.Text = "";
            tanggal_masuk.Text = "";
            tanggal_keluar.Text = "";
            keterangan.Text = "";
            id_karyawan.Text = "";
        }

    }

    protected void Button3_Click1(object sender, EventArgs e)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Database=gudangfinal;Password=1234"))
        {
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Delete from barang where id_barang=@id_barang";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new NpgsqlParameter("@id_barang", Convert.ToInt32(id_barang.Text)));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();
            id_barang.Text = "";
        }

    }
}