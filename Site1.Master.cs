using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBLABPROJECT
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                LinkButton1.Visible = true;
                LinkButton2.Visible = true;

                LinkButton3.Visible = false;
                LinkButton4.Visible = false;
                LinkButton5.Visible = false;
                LinkButton6.Visible = false;



                if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = false;

                    LinkButton3.Visible = true;
                    LinkButton4.Visible = true;
                    LinkButton4.Text = "Hello Admin";
                    LinkButton5.Visible = true;
                    LinkButton6.Visible = true;


                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = false;

                    LinkButton3.Visible = true;
                    LinkButton4.Visible = true;
                    LinkButton4.Text = "Hello "+Session["username"].ToString();
                    LinkButton5.Visible = true;
                    LinkButton6.Visible = true;


                }
            }

            catch { 
                
            }
           

        }

       
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            //log out button
            Session["username"] = "";
            Session["role"] = "";
            Session["email"] = "";
            
            LinkButton1.Visible = true;
            LinkButton2.Visible = true;
           
            LinkButton3.Visible = false;
            LinkButton4.Visible = false;
            LinkButton5.Visible = false;

        }
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ad.aspx");
        }
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewads.aspx");
        }

    }
}