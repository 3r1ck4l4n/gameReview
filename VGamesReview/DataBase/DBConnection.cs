
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace VGamesReview
{
    public class DBConnection
    {
        string cstr = "Server=LAPTOP-62LBQ0H0;Database=VGAMES_REVIEW;integrated security = true";
        public SqlConnection cnx = new SqlConnection();
        public DBConnection()
        {
            cnx.ConnectionString = cstr;
            System.Diagnostics.Debug.WriteLine("conective succesfully");
        }
        public void OpenConnetion()
        {
            try
            {
                cnx.Open();
                System.Diagnostics.Debug.WriteLine("Conexion Succesfully");
            }
            catch(Exception e) {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public void CloseConnection() {
            cnx.Close();
        }
    }
}