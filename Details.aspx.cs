using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Data;

namespace DBLABPROJECT
{
    public partial class Details : System.Web.UI.Page
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

                        SqlCommand cmd = new SqlCommand("select *  from advertisement inner join model on model.model_id = advertisement.model_id inner join car_feature on car_feature.feature_id = model.feature_id  where ad_id = @adId;", con);
                        cmd.Parameters.AddWithValue("@adId", adId); // Add parameter to the command
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Retrieve data and assign to controls or store in variables
                            byte[] imageData = (byte[])reader["img"];
                            string base64String = Convert.ToBase64String(imageData);
                            // Construct the data URI for embedding the image
                            string imageUrl = "data:image/jpeg;base64," + base64String;
                            // Set the src attribute of the Image control to the data URI
                            imgCar.ImageUrl = imageUrl;


                            string title = reader["title"].ToString();
                            string description = reader["ad_desc"].ToString();
                            decimal price = Convert.ToDecimal(reader["price"]);
                            string image = reader["img"].ToString();
                            int mileage = Convert.ToInt32(reader["mileage"]);

                            // Example: Assigning values to controls in the page
                            carTitle.Text = title;
                           // lblDescription.Text = description;
                            priceLabel.Text = price.ToString("C"); // Format price as currency
                          //  imgAd.ImageUrl = image;
                            mileageLabel.Text = mileage.ToString();


                            colorLabel.Text = "Color: " + reader["Color"].ToString();
                            mileageLabel.Text = "Mileage: " + reader["Mileage"].ToString();
                            conditionLabel.Text = "Condition: " + reader["Condition"].ToString();
                            modelLabel.Text = "Model: " + reader["Model_name"].ToString();
                            priceLabel.Text = "Price: " + reader["Price"].ToString();

                            transmissionTypeLabel.Text = "Transmission Type: " + reader["Transmission_Type"].ToString();
                            maxGearLabel.Text = "Max Gear: " + reader["Max_Gear"].ToString();
                            engineCapacityLabel.Text = "Engine Capacity: " + reader["Engine_Capacity"].ToString();
                            bodyTypeLabel.Text = "Body Type: " + reader["Body_Type"].ToString();
                            carTypeLabel.Text = "Car Type: " + reader["Car_Type"].ToString();
                            airBagsLabel.Text = "Air Bags: " + reader["Air_Bags"].ToString();
                            hpLabel.Text = "HP: " + reader["HP"].ToString();
                            torqueLabel.Text = "Torque: " + reader["Torque"].ToString();
                            tyreSizeLabel.Text = "Tyre Size: " + reader["Tyre_Size"].ToString();
                            seatingCapacityLabel.Text = "Seating Capacity: " + reader["Seating_Capacity"].ToString();
                            cruiseControlLabel.Text = "Cruise Control: " + reader["Cruise_Control"].ToString();
                            antiLockBSPowerMirrorLabel.Text = "Anti-Lock BS Power Mirror: " + reader["antilock_bs"].ToString();
                            powerSteeringLabel.Text = "Power Steering: " + reader["Power_Steering"].ToString();
                            powerWindowsLabel.Text = "Power Windows: " + reader["Power_Windows"].ToString();
                            sunRoofLabel.Text = "Sun Roof: " + reader["Sun_Roof"].ToString();
                            powerLocksLabel.Text = "Power Locks: " + reader["Power_Locks"].ToString();
                            alloyRimsLabel.Text = "Alloy Rims: " + reader["Alloy_Rims"].ToString();
                            airConditioningLabel.Text = "Air Conditioning: " + reader["Air_Conditioning"].ToString();
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

     
                 
                  
                }
            }
