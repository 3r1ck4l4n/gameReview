using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VGamesReview
{
    public class User
    {
        private int idUser;
        private string nameUser;
        private string imageUser;
        private string emailUSer;
        private string password;

        public int IdUser { get => idUser; set => idUser = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }
        public string ImageUser { get => imageUser; set => imageUser = value; }
        public string EmailUSer { get => emailUSer; set => emailUSer = value; }
        public string Password { get => password; set => password = value; }

        public User(int idUser, string nameUser, string imageUser, string emailUSer)
        {
            this.idUser = idUser;
            this.nameUser = nameUser;
            this.imageUser = imageUser;
            this.EmailUSer = emailUSer;
        }

        public User(string nameUser,string password, string imageUser, string emailUSer)
        {
            this.password = password;
            this.nameUser = nameUser;
            this.imageUser = imageUser;
            this.EmailUSer = emailUSer;
        }

        public User()
        {
        }


    }
}