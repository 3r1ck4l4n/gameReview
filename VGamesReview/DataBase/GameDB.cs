using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VGamesReview
{
    public class GameDB
    {
        static void Main(string[] args)
        {
            // Display the number of command line arguments.
            DBConnection cnx = new DBConnection();

            cnx.connectionDb();
        }
    }
}