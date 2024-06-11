

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
    public partial class deletead : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                if (Request.QueryString["adId"] != null)
                {
                    try
                    {

                        SqlConnection con = new SqlConnection(strcon);
                        if (con.State == System.Data.ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        SqlCommand cmd = new SqlCommand("Delete from  advertisement where ad_id =@adid", con);


                        int adId = Convert.ToInt32(Request.QueryString["adId"]);
                        cmd.Parameters.AddWithValue("@adId", adId); // Add parameter to the command




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
                        Response.Write("<script>alert('Ad Deleted!'); </script>");


                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('" + ex.Message + "'); </script>");
                    }
                }
            }

            }

        }

        }

       
