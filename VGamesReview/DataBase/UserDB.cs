using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace VGamesReview.DataBase
{
   
    public class UserDB : DBConnection
    {
        
        public User LoginU(string email, string pass) {
            OpenConnetion();
            User user;
            string query = "SELECT * FROM USERS WHERE PASSWORD_USER = @pass and EMAIL_USER= @email";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, cnx);
                sqlCommand.Parameters.AddWithValue("@pass", pass);
                sqlCommand.Parameters.AddWithValue("@email",email);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
               user = new User();
                while (dataReader.Read())
                {
                   user = new User(Int16.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString(), dataReader.GetValue(4).ToString(), dataReader.GetValue(3).ToString());
                    System.Diagnostics.Debug.WriteLine(Int16.Parse(dataReader.GetValue(0).ToString()) + dataReader.GetValue(1).ToString() + dataReader.GetValue(2).ToString() + dataReader.GetValue(3).ToString() + dataReader.GetValue(4).ToString());
                }
                if (user.NameUser != null )
                {
                    return user;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                user = new User();
            }
            return user;
        }

        public int RegisterUser(User user)
        {
            int succes = 0;

            OpenConnetion();
            string query = "INSERT INTO USERS VALUES(@NAME, @PASS, @EMAIL, @IMAGE);";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, cnx);
                sqlCommand.Parameters.AddWithValue("@NAME", user.NameUser.ToString());
                sqlCommand.Parameters.AddWithValue("@PASS", user.Password.ToString());
                sqlCommand.Parameters.AddWithValue("@EMAIL", user.EmailUSer.ToString());
                sqlCommand.Parameters.AddWithValue("@IMAGE", user.ImageUser.ToString());
                succes = sqlCommand.ExecuteNonQuery();
                return succes;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return succes;
            }
        }

    }
}