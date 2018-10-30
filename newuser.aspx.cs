using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class newuser : System.Web.UI.Page
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
    void Clear()
    {
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert adduser values(@name,@phone,@address,@service)";
        cmd.Connection = con;
        if (TextBox5.Text != "" && TextBox6.Text != "" && TextBox5.Text != "" && TextBox6.Text != "")
        {
            try
            {
                cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = Convert.ToString(TextBox3.Text);
                cmd.Parameters.Add("@phone", SqlDbType.Int).Value = Convert.ToInt32(TextBox4.Text);
                cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = Convert.ToString(TextBox5.Text);
                cmd.Parameters.Add("@service", SqlDbType.Int).Value = Convert.ToInt32(TextBox6.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Clear();
                Label2.Visible = true;
                Label2.Text = "Data Saved";
            }
            catch
            {
                Label2.Visible = true;
                Label2.Text = "Error Data not saved RETRY";
                Clear();
            }
        }
        else
        {
            Label2.Visible = true;
            Label2.Text = "One of the above field is empty";
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert tblogin values(@uname,@upass)";
        cmd.Connection = con;
        if (TextBox7.Text != "" && TextBox8.Text != "" && TextBox9.Text != "")
        {
            if (TextBox8.Text == TextBox9.Text)
            {
                try
                {
                    cmd.Parameters.Add("@uname", SqlDbType.VarChar, 50).Value = Convert.ToString(TextBox7.Text);
                    cmd.Parameters.Add("@upass", SqlDbType.VarChar, 50).Value = Convert.ToString(TextBox8.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    Clear();
                    Label2.Visible = true;
                    Label2.Text = "Account created";
                }
                catch
                {
                    Label2.Visible = true;
                    Label2.Text = "Error Account not created";
                    Clear();
                }
            }
            else
            {
                {
                    Label2.Visible = true;
                    Label2.Text = "pass and retype pass not same";
                }
            }
        }
        else
        {
            Label2.Visible = true;
            Label2.Text = "One of the above field is empty";
        }
    }
}