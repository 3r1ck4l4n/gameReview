using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VGamesReview.DataBase;

namespace VGamesReview
{


    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            UserDB userDB = new UserDB();
            System.Diagnostics.Debug.WriteLine(email.Text + " ------ " + Password1.Value);
            User userLog = userDB.LoginU(email.Text, Password1.Value);
            Session["userLogged"] = userLog.IdUser;
            Session["userLoggedName"] = userLog.NameUser;
            Session["userLoggedImage"] = userLog.ImageUser;
            System.Diagnostics.Debug.WriteLine(Session["userLoggedImage"].ToString());
            if (Session["userLogged"] != null)
            {

                Response.Redirect("AllGAmes.aspx");
            }
        }
    }
}