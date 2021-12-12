using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace VGamesReview
{
    public class GameDB : DBConnection
    {
        public List<VideoGame> ConsultGames()
        {
            OpenConnetion();
            List<VideoGame> games = new List<VideoGame>();
            string query = "SELECT * FROM VIDEO_GAMES";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, cnx);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    VideoGame game = new VideoGame(Int16.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString(), dataReader.GetValue(3).ToString(), dataReader.GetValue(4).ToString());
                    games.Add(game);
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            CloseConnection();
            return games;
        }

        public VideoGame SearchGame(string id)
        {
            OpenConnetion();
            VideoGame game;
            string query = "SELECT * FROM VIDEO_GAMES WHERE ID_VIDEO_GAME = @ID";
            System.Diagnostics.Debug.WriteLine(id);
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, cnx);
                sqlCommand.Parameters.AddWithValue("@ID", id);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                game = new VideoGame();
                while (dataReader.Read())
                {
                    game = new VideoGame(Int16.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString(), dataReader.GetValue(3).ToString(), dataReader.GetValue(4).ToString());
                    System.Diagnostics.Debug.WriteLine(Int16.Parse(dataReader.GetValue(0).ToString())+ dataReader.GetValue(1).ToString()+ dataReader.GetValue(2).ToString()+ dataReader.GetValue(3).ToString()+ dataReader.GetValue(4).ToString());
                }
            }
            catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e);
                game = new VideoGame();
            }

            CloseConnection();
            return game;

        }

    }
}