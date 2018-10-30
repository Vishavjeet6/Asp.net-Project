using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Dropuser : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            String a = TextBox3.Text;
            cmd.CommandText = "delete from adduser where name=@name";
            cmd.Connection = con;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = Convert.ToString(TextBox3.Text);
            int b;
            b = cmd.ExecuteNonQuery();
            cmd.Dispose();
            TextBox3.Text = "";
            Label2.Visible = true;
            if (b != 0)
            {
                Label2.Text = "Record Deleted";
            }
            else
            {
                Label2.Text = "Wrong Name";
            }
        }
        catch
        {
            Label2.Visible = true;
            Label2.Text = "Wrong Name";
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            String a = TextBox4.Text;
            cmd.CommandText = "delete from tblogin where uname=@uname";
            cmd.Connection = con;
            cmd.Parameters.Add("@uname", SqlDbType.VarChar, 50).Value = Convert.ToString(TextBox4.Text);
            int b;
            b = cmd.ExecuteNonQuery();
            cmd.Dispose();
            TextBox4.Text = "";
            Label2.Visible = true;
            if (b != 0)
            {
                Label2.Text = "Record Deleted";
            }
            else
            {
                Label2.Text = "Wrong ID";
            }
        }
        catch
        {
            Label2.Visible = true;
            Label2.Text = "Wrong id";
        }
    }
}