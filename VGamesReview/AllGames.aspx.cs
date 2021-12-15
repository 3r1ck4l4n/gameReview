using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VGamesReview
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnection cnx = new DBConnection();

            GameDB dBCxn = new GameDB();

            List<VideoGame> games =  dBCxn.ConsultGames();
            Label label = new Label();
            foreach (VideoGame vg in games){
                System.Diagnostics.Debug.WriteLine(vg.Id_game+ "*********"+vg.NameVideoGame+ "********" + vg.DescriptionGame + "**********"+ vg.Specifications);
                container1.InnerHtml += "<a class='text-decoration-none d-block  w-25' href='GameDetail.aspx?id=" + vg.Id_game + "'><div class='card w-100'> " + "<img src='"+ vg.Image+ "'> "+ "<p class='text-primary text-center'>"+ vg.NameVideoGame + "</p>"+
                    "</div></a>";
            }
            

        }
    }
}