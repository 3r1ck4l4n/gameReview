using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using VGamesReview.Objects;

namespace VGamesReview.DataBase
{
    public class ReviewDB : DBConnection
    {
        public int publishReview(Review review)
        {
            OpenConnetion();
            string query = @"IF EXISTS(SELECT * FROM REVIEW  WHERE ID_USER = @ID_USER AND ID_VIDEO_GAME = @ID_GAME)
                        UPDATE REVIEW
                        SET 
                        DESCRIPTION_REVIEW = @DESCRIPTION,
                        SCORE_GAME_REVIEW = @SCORE
                        WHERE ID_USER = @ID_USER AND ID_VIDEO_GAME = @ID_GAME
                    ELSE
                        INSERT INTO REVIEW VALUES(@ID_USER, @ID_GAME,@DESCRIPTION, @SCORE);";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, cnx);
                sqlCommand.Parameters.AddWithValue("@ID_USER", review.IdUser.ToString());
                sqlCommand.Parameters.AddWithValue("@ID_GAME", review.IdGame.ToString());
                sqlCommand.Parameters.AddWithValue("@DESCRIPTION", review.DescriptionReview.ToString());
                sqlCommand.Parameters.AddWithValue("@SCORE", review.ScoreGame.ToString());

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return 0;
            }
        }

        public List<Review> getReviewList(string id) {
            List<Review> reviews = new List<Review>();

            OpenConnetion();
            string query = "SELECT * FROM REVIEW INNER JOIN USERS ON REVIEW.ID_USER = USERS.ID_USER  WHERE ID_VIDEO_GAME = @ID"; 
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, cnx);
                sqlCommand.Parameters.AddWithValue("@ID", id);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                Review review;
                User user;
                while (dataReader.Read()) {
                    user = new User(Int16.Parse(dataReader.GetValue(5).ToString()), dataReader.GetValue(6).ToString(), dataReader.GetValue(9).ToString(), dataReader.GetValue(8).ToString());
                    review = new Review(Int16.Parse(dataReader.GetValue(1).ToString()), Int16.Parse(dataReader.GetValue(2).ToString()), dataReader.GetValue(3).ToString(), Int16.Parse(dataReader.GetValue(4).ToString()), user);
                    reviews.Add(review);
                }

            }
            catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return reviews;
        }

    }
}