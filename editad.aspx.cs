

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Web.Caching;
using System.Web.UI.WebControls;

namespace DBLABPROJECT
{
    public partial class editad : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                if (Request.QueryString["adId"] != null)
                {
                    int adId = Convert.ToInt32(Request.QueryString["adId"]);
                    // Retrieve car details from the database
                    try
                    {
                        SqlConnection con = new SqlConnection(strcon);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        SqlCommand cmd = new SqlCommand("select title, ad_desc, color, mileage, condition, price, model_name, brand_name from advertisement inner join model on advertisement.model_id = model.model_id where ad_id = @adId ;", con);
                        cmd.Parameters.AddWithValue("@adId", adId); // Add parameter to the command
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {

                            string title = reader["title"].ToString();
                            string description = reader["ad_desc"].ToString();
                            decimal price = Convert.ToDecimal(reader["price"]);
                            //string image = reader["img"].ToString();
                            int mileage = Convert.ToInt32(reader["mileage"]);

                            TitleTextBox.Text = title;
                            DescriptionTextBox.Text = description;

                            CarColorTextBox.Text = reader["color"].ToString();
                            MileageTextBox.Text = mileage.ToString();
                            PriceTextBox.Text = price.ToString(); // Format price as currency
                            ModelTextBox.Text = reader["model_name"].ToString(); // Format price as currency
                            BrandTextBox.Text = reader["brand_name"].ToString(); // Format price as currency

                        }


                    }
                    catch (Exception ex)
                    {
                        Response.Write("<h2>Exception Details:</h2>");
                        Response.Write("<p>" + ex.Message + "</p>");
                        Response.Write("<p>" + ex.StackTrace + "</p>");
                    }
                }

            }
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
            if (temp == -1)
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

            Response.Write("<script>alert('Here'); </script>");


            try
            {

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE advertisement set title = @title, ad_desc = @ad_desc, color =  @color, mileage = @mileage, condition = @condition, price =  @price where ad_id =@adid", con);
               
                
                int adId = Convert.ToInt32(Request.QueryString["adId"]);
                cmd.Parameters.AddWithValue("@adId", adId); // Add parameter to the command

                //adding image
                //if (CarImageFileUpload.HasFile)
                //{
                //    byte[] imageData = CarImageFileUpload.FileBytes;
                //    cmd.Parameters.AddWithValue("@img", imageData);

                //}
                //else
                //{
                //    cmd.Parameters.AddWithValue("@img", null);
                //}

              ///  Response.Write("<script>alert('here 2'); </script>");

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


                try
                {
                cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Response.Write("<h2>Exception Details:</h2>");
                    Response.Write("<p>" + ex.Message + "</p>");
                    Response.Write("<p>" + ex.StackTrace + "</p>");
                }



                con.Close();
                Response.Write("<script>alert('Ad Updated!'); </script>");


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