using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VGamesReview.Objects;

namespace VGamesReview
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        VideoGame vg;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                for (int i = 1; i < 5; i++)
                {
                    DropDownList1.Items.Add(i.ToString());
                }
            }
            string id= Request.QueryString["id"];

            System.Diagnostics.Debug.WriteLine(id);

            GameDB dBCxn = new GameDB();

             vg = dBCxn.SearchGame(id);
            container1.InnerHtml = "<div class='card w-75'> " + "<img src='" + vg.Image + "'> " + "<p class='text-primary'>" + vg.NameVideoGame + "</p>" +
                    "</div>";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (Session["userLogged"] != null)
            {
                Review review = new Review(vg.Id_game, 1, TextArea1.Value, Int16.Parse(DropDownList1.SelectedValue));
            }


        }
    }
}