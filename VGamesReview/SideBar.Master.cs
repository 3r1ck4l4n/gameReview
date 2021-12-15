using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VGamesReview
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButton l1 = new LinkButton();
            LinkButton l2 = new LinkButton();
            if (Session["userLogged"] != null)
            {

                l1.ID = "Profile";
                l1.Text = "Profile";
                l1.Click += new EventHandler(this.Profile_Click);
                l1.CssClass = "nav-link link-primary";
                l2.ID = "Logout";
                l2.Text = "Logout";
                l2.Click += new EventHandler(this.Logout_Click);
                l2.CssClass = "nav-link link-primary";
                linkD1.Controls.Add(l1);
                linkD2.Controls.Add(l2);
                linkD3.InnerHtml += "<span class='nav-link link-primary'> Welcome "+ Session["userLoggedName"] + "! </span>" + "<img class='img-thumbnail w-25' src='" + Session["userLoggedImage"] + "'>";

            }
            else {
                
                l1.ID = "Login";
                l1.Text = "Login";
                l1.Click += new EventHandler(this.Login_Click);
                l1.CssClass = "nav-link link-primary";
                l2.ID = "Register";
                l2.Text = "Register";
                l2.Click += new EventHandler(this.Register_Click);
                l2.CssClass = "nav-link link-primary";
                linkD1.Controls.Add(l1);
                linkD2.Controls.Add(l2);


            }

        }

        protected void link1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllGames.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }


        protected void Profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllGames.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(Session["userLogged"].ToString()+"************************");
            Session.Abandon();
            System.Diagnostics.Debug.WriteLine(Session["userLogged"].ToString());
            Response.Redirect("Login.aspx");
        }
        protected void Register_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(Session["userLogged"]);
            Response.Redirect("RegisterUser.aspx");    
            
        }
    }
}