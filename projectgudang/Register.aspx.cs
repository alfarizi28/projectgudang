using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Npgsql;

public partial class Register : System.Web.UI.Page
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
            cmd.CommandText = "Insert into users values(default,@nama,@email,@password,@no_hp,@alamat)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new NpgsqlParameter("@nama", nama_karyawan.Text));
            cmd.Parameters.Add(new NpgsqlParameter("@email", email.Text));
            cmd.Parameters.Add(new NpgsqlParameter("@password", password.Text));
            cmd.Parameters.Add(new NpgsqlParameter("@no_hp", no_hp.Text));
            cmd.Parameters.Add(new NpgsqlParameter("@alamat", alamat.Text));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();
            nama_karyawan.Text = "";
            email.Text = "";
            password.Text = "";
            no_hp.Text = "";
            alamat.Text = "";
            Label1.Text = "Akun Berhasil Didaftarkan!";
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}