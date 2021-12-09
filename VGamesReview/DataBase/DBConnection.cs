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
        public bool connectionDb()
        {
                
            try
            {
                string cstr = "Server=LAPTOP-62LBQ0H0;Database=VGAMES_REVIEW;integrated security = true";
                SqlConnection cnx = new SqlConnection(cstr);
                System.Diagnostics.Debug.WriteLine("conective succesfully");
                string query = "SELECT * FROM USERS";
                SqlDataAdapter adp = new SqlDataAdapter(query, cnx);
               
                DataSet dst = new DataSet();
                System.Diagnostics.Debug.WriteLine("Im here1");
                adp.Fill(dst);
                System.Diagnostics.Debug.WriteLine(dst.Tables[0].Columns.Count);
                for (int i = 0; i < dst.Tables[0].Rows.Count; i++)
                {
                    System.Diagnostics.Debug.WriteLine("Im here3");
                    for (int j = 0; j < dst.Tables[0].Columns.Count; j++)
                    {
                        System.Diagnostics.Debug.WriteLine(dst.Tables[0].Rows[i][j] + "\t");
                    }
                    System.Diagnostics.Debug.WriteLine("Im here");
                }
                cnx.Close();
                return true;
            }
            catch (SqlException e)
            {
                System.Diagnostics.Debug.WriteLine(e);

                return false;
            }
         
        }
    }
}