using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VGamesReview.DataBase;
namespace VGamesReview
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            if (name.Text!="" && Password1.Value.ToString()!="" && profileUrl.Text!="" && email.Text!="")
            {
                User user = new User(name.Text, Password1.Value.ToString(), profileUrl.Text, email.Text);

                UserDB userDb = new UserDB();

                int succes = userDb.RegisterUser(user);

                if (succes != 0)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    error.InnerText = "Registration failed; please try later or review your details.";
                }

            }
            else
            {
                error.InnerText = "Registration failed; please try later or review your details.";
            }
            

        }
    }
}