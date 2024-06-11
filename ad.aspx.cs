

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Web.Caching;
using System.Web.UI.WebControls;

namespace DBLABPROJECT
{
    public partial class ad : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void SubmitAd_Click(object sender, EventArgs e)
        {

            string role = Session["role"] as string;
            if (string.IsNullOrEmpty(role))
            {
                Response.Write("<script>alert('You need to log in First'); </script>");
                Response.Redirect("userlogin.aspx");
            }

            int temp = checkCarExists();
            if (temp==-1)
            {
                Response.Write("<script>alert('No such Car Model and Brand Exists'); </script>");
            }
            else
            {
                insertAdvertisement(temp);
            }
        }


        void insertAdvertisement(int temp)
        {

            try
            {

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO advertisement VALUES(@title, @ad_desc, @created_at, @updated_at, @user_email, @color, @mileage, @condition, @model_id, @price, @img)", con);


                //adding image
                if (CarImageFileUpload.HasFile)
                {
                    byte[] imageData = CarImageFileUpload.FileBytes;
                    cmd.Parameters.AddWithValue("@img", imageData);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@img", null);
                }


                //Response.Write("<script>alert('Sign up Successfull!. Go to Login Page to Log in.'); </script>");
                DateTime today = DateTime.Today;
                cmd.Parameters.AddWithValue("@title", TitleTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@ad_desc", DescriptionTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@created_at", today.ToString());
                cmd.Parameters.AddWithValue("@updated_at", today.ToString());
                cmd.Parameters.AddWithValue("@user_email", Session["email"]);
                cmd.Parameters.AddWithValue("@color", CarColorTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@mileage", MileageTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@condition", ConditionDropDown.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@model_id", temp);
                cmd.Parameters.AddWithValue("@price", PriceTextBox.Text);
                //cmd.Parameters.AddWithValue("@price", 1000);

                cmd.ExecuteNonQuery();


                con.Close();
                Response.Write("<script>alert('Ad Uploaded!'); </script>");


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");


            }



        }

        int checkCarExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM model WHERE model_name = '" + ModelTextBox.Text.Trim() + "' AND brand_name='" + BrandTextBox.Text.Trim() + "' ;", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        return Int32.Parse(dr.GetValue(0).ToString());
                    }
                    else
                    {
                        return -1;
                    }

                }
                return -1;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
                return -1;
            }
        }

    }
}