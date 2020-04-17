using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace registrationForm
{
    public partial class registrationForm : System.Web.UI.Page
    {
        string connectionstring = @"Data Source=DESKTOP-9K0CJQI\SQLEXPRESS;Initial Catalog=regform;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)

        {
               if(!IsPostBack)
               {
                   clear();
               }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="" || txtPassword.Text=="" )
            lblErrorMessage.Text = "Please Fill Mandotory Fields";

            else if (txtPassword.Text != txtconfirmPassword.Text)
            lblErrorMessage.Text = "Please Password does not match";

            else
                 {

            using (SqlConnection sqlCon = new SqlConnection(connectionstring))
                    { 
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAddorEdit", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(hfUserID.Value == "" ? "0" : hfUserID.Value));
                sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstname.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@LastName", txtLastname.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);
                sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@UserName", txtUsername.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                clear();
                lblSuccessMessage.Text = " submitted succseffuly";
                     }

            
                 }

          }
        void clear()
        {
            txtFirstname.Text = txtLastname.Text = txtContact.Text = txtAddress.Text = txtUsername.Text = txtPassword.Text = txtconfirmPassword.Text = "";
            hfUserID.Value = "";
            lblSuccessMessage.Text = lblErrorMessage.Text = "";
        }
}