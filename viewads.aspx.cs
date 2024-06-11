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
    public partial class viewads : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDataList(); // Call the method to bind data to the DataList
            }

        }

        //private void BindGrid()
        //{

        //    using (SqlConnection con = new SqlConnection(strcon))
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT title, ad_desc, price, img FROM advertisement", con);
        //        con.Open();
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        DataList1.DataSource = rdr;
        //        DataList1.DataBind();
        //    }
        //}


        private void BindDataList()
        {

            using (SqlConnection con = new SqlConnection(strcon))
            {

                try
                {
                SqlCommand cmd = new SqlCommand("SELECT ad_id, title, ad_desc, price, img, mileage, user_email FROM advertisement WHERE user_email = @useremail", con);
                con.Open();
                cmd.Parameters.AddWithValue("@useremail", Session["email"].ToString());
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                }
                catch(Exception ex)
                {
                    Response.Write("<h2>Exception Details:</h2>");
                    Response.Write("<p>" + ex.Message + "</p>");
                    Response.Write("<p>" + ex.StackTrace + "</p>");
                }
            }
        }




        protected string FormatPrice(double price)
        {
            string formattedPrice;
            if (price >= 10000000) // 1 crore or more
            {
                formattedPrice = (price / 10000000).ToString("0.##") + " crore ";
            }
            else if (price >= 100000)// Less than 1 crore
            {
                formattedPrice = (price / 100000).ToString("0.##") + " lacs ";
            }
            else
            {
                formattedPrice = price.ToString() + " Rs";
            }
            return formattedPrice;
        }

        protected string FormatMileage(string p)
        {
            string formattedPrice;
            int price = int.Parse(p);
            if (price >= 10000000) // 1 crore or more
            {
                formattedPrice = (price / 10000000).ToString("0.##") + " crore ";
            }
            else if (price >= 100000)// Less than 1 crore
            {
                formattedPrice = (price / 100000).ToString("0.##") + " lacs ";
            }
            else
            {
                formattedPrice = price.ToString();
            }
            return formattedPrice;
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {

                SqlCommand cmd = new SqlCommand("SELECT title, ad_desc, price, img, mileage FROM advertisement WHERE title like '%' + @makemodel + '%' AND price>= @minprice AND price<= @maxprice ", con);
                if (MaxPriceTextBox.Text == "")
                {
                    cmd.Parameters.AddWithValue("@maxprice", 999999999);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@maxprice", int.Parse(MaxPriceTextBox.Text.Trim()));

                }
                if (MinPriceTextBox.Text == "")
                {
                    cmd.Parameters.AddWithValue("@minprice", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@minprice", int.Parse(MinPriceTextBox.Text.Trim()));

                }
                cmd.Parameters.AddWithValue("@makemodel", MakeModelTextBox.Text);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                DataList1.DataSource = dt;
                DataList1.DataBind();
            }


        }




    }
}