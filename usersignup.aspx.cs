using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBLABPROJECT
{
    public partial class usersignup : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Response.Write("<script>alert('Testing'); </script>");
            if (checkUserExists())
            {
                Response.Write("<script>alert('Account Already Registered With This Email'); </script>");
            }
            else
            {
                signUpNewUser();
            }


        }


        bool checkUserExists()
        {
            try
            {

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM user_account WHERE user_email = '"+TextBox4.Text.Trim()+"';", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
                return false;
            }


        }

        void signUpNewUser()
        {
            try
            {

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO user_account(name, contact, user_email, user_password) VALUES(@name, @contact, @user_email, @user_password)", con);

                //Response.Write("<script>alert('Sign up Successfull!. Go to Login Page to Log in.'); </script>");

                cmd.Parameters.AddWithValue("@name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@contact", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@user_email", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@user_password", TextBox9.Text.Trim());

                cmd.ExecuteNonQuery();


                con.Close();
                Response.Write("<script>alert('Sign up Successfull!. Go to Login Page to Log in.'); </script>");


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");


            }



        }

    }
}