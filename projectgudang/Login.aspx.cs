using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Npgsql;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Database=gudangfinal;Password=1234"))
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select * from users where email=@username and password=@password", conn);
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                Response.Redirect("ViewGudang.aspx");
            }
            else
            {
                Label1.Text = "Username dan Password yang anda inputkan salah !";
                Label1.ForeColor = System.Drawing.Color.Red;

            }

        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}