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
        protected void Login_Click(object sender, EventArgs e)
        {
            
            UserDB userDB = new UserDB();
            UserDB u = userDB;
        
            if (u.LoginU(email.Value.ToString(), Password1.Value.ToString()))
            {
                
                Session["userLogged"] = u.usua;
                email.Value = Session["userLogged"].ToString();
             Response.Redirect("AllGAmes.aspx");
            }


        }
    }
}