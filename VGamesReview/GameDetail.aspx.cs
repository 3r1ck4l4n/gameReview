using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VGamesReview.DataBase;
using VGamesReview.Objects;

namespace VGamesReview
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        VideoGame vg;
        protected void Page_Load(object sender, EventArgs e)
        {
            reviewsContainer.InnerHtml = "";
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
            container1.InnerHtml = "<div class='card w-50'> " + "<img class='img-thumbnail w-50' src='" + vg.Image + "'> " + "<p class='text-primary'>" + vg.NameVideoGame + "</p>" +
                    "</div>";
            ReviewDB reviewDb = new ReviewDB();
            List<Review> reviews = reviewDb.getReviewList(id);

            foreach(Review rw in reviews) {
                reviewsContainer.InnerHtml += "<div class='mx-auto'><p class='mx-auto text-center text-primary'>" + rw.DescriptionReview + " <span class='text-primary'> Score: " + rw.ScoreGame +"</span></p><p class='text-right text-success'>" + rw.User.NameUser + "</p></div>";
                System.Diagnostics.Debug.WriteLine(rw.DescriptionReview);

            }
            

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (Session["userLogged"] != null)
            {
                if (TextArea1.Value !="" || TextArea1.Value.Length > 150) {
                    Review review = new Review(Int16.Parse(Session["userLogged"].ToString()), vg.Id_game, TextArea1.Value, Int16.Parse(DropDownList1.SelectedValue));
                    ReviewDB reviewDb = new ReviewDB();
                    int succes = reviewDb.publishReview(review);

                    if (succes != 0)
                    {
                        Response.Redirect("GameDetail.aspx?id=" + vg.Id_game);
                    }
                }
                else
                {
                    errorLogged.InnerText = "Your review must contain content, and must not be longer than 150 characters.";
                }

            }
            else
            {
                errorLogged.InnerText = "Login to register your review.";
            }



        }
    }
}