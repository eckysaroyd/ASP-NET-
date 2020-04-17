using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default: System.Web.UI.Page {  
    protected void Page_Load(object sender, EventArgs e) {  
  
    }  
    protected void Button1_Click(object sender, EventArgs e) {  
        SqlConnection con = new SqlConnection(@  
        "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");  
        SqlCommand cmd = new SqlCommand("select * from tbl_data where username=@username and word=@word", con);  
        cmd.Parameters.AddWithValue("@username", TextBox1.Text);  
        cmd.Parameters.AddWithValue("word", TextBox2.Text);  
        SqlDataAdapter sda = new SqlDataAdapter(cmd);  
        DataTable dt = new DataTable();  
        sda.Fill(dt);  
        con.Open();  
        int i = cmd.ExecuteNonQuery();  
        con.Close();  
  
        if (dt.Rows.Count > 0) {  
            Response.Redirect("Redirectform.aspx");  
        } else {  
            Label1.Text = "Your username and word is incorrect";  
            Label1.ForeColor = System.Drawing.Color.Red;  
  
        }  
  
  
    }  
}  