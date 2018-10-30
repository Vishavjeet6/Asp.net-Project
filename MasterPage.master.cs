using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class MasterPage : System.Web.UI.MasterPage
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
    private Int32 checkuser(String u, String p)
    {
        SqlCommand cmd = new SqlCommand("logincheck", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@un", SqlDbType.VarChar, 50).Value = u;
        cmd.Parameters.Add("@up", SqlDbType.VarChar, 50).Value = p;
        cmd.Parameters.Add("@ret", SqlDbType.Int);
        cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
        cmd.ExecuteNonQuery();
        Int32 k = Convert.ToInt32(cmd.Parameters["@ret"].Value);
        cmd.Dispose();
        return k;
    }

 
    
      
protected void Button1_Click(object sender, EventArgs e)
    {
        Int32 d;
        d = checkuser(TextBox1.Text, TextBox2.Text);
        if (d == -1)
        {
            Label1.Visible = true;
            Label1.Text = "Wrong User";
        }
        if (d == -2)
        {
            Label1.Visible = true;
            Label1.Text = "Wrong Password";
        }
        if (d == 1)
        {
            if (TextBox1.Text == "admin")
            {
                Response.Redirect("Adminpanel.aspx");
            }
            else
            {
                Response.Redirect("Client.aspx");
            }
        }
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
