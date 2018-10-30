using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Client : System.Web.UI.Page
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


  


    protected void Button4_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Homepage.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        String a = TextBox3.Text;
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select * from adduser where name=@name";
        cmd.Connection = con;
        cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = Convert.ToString(TextBox3.Text);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            Label6.Visible = true;
            Label3.Text = dr["name"].ToString();
            Label4.Text = dr["phone"].ToString();
            Label6.Text = dr["address"].ToString();
            Label5.Text = dr["service"].ToString();
            Label7.Text = "hdgsfjh";
            Label2.Visible = true;
            Label2.Text = "Data found";
        }
        else
        {
            Label2.Visible = true;
            Label2.Text = "Not found";
        }
        dr.Close();
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        TextBox3.Text = "";
    }
}