using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace VGamesReview.DataBase
{
   
    public class UserDB : DBConnection
    {
        public int usua;
        public bool LoginU(string email, string pass) {
            OpenConnetion();
            User user;
            string query = "select * from USERS where password_user=@pass and EMAIL_USER=@email";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, cnx);
                sqlCommand.Parameters.AddWithValue("@pass", pass);
                sqlCommand.Parameters.AddWithValue("@email",email);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
               user = new User();
                while (dataReader.Read())
                {
                   user = new User(Int16.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString(), dataReader.GetValue(3).ToString());
                    System.Diagnostics.Debug.WriteLine(Int16.Parse(dataReader.GetValue(0).ToString()) + dataReader.GetValue(1).ToString() + dataReader.GetValue(2).ToString() + dataReader.GetValue(3).ToString() + dataReader.GetValue(4).ToString());
                }
                if (user.NameUser != null )
                {
                    usua = user.IdUser;
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                user = new User();
            }
            return false;
        }
    }
}