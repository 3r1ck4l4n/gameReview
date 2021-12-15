using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VGamesReview.Objects
{
    public class Review
    {
        private int idReview;
        private int idUser;
        private int idGame;
        private string descriptionReview;
        private int scoreGame;
        private User user;
        public int IdReview { get => idReview; set => idReview = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public int IdGame { get => idGame; set => idGame = value; }
        public string DescriptionReview { get => descriptionReview; set => descriptionReview = value; }
        public int ScoreGame { get => scoreGame; set => scoreGame = value; }
        public User User { get => user; set => user = value; }

        public Review(int idUser, int idGame, string descriptionReview, int scoreGame)
        {
            this.idUser = idUser;
            this.idGame = idGame;
            this.descriptionReview = descriptionReview;
            this.scoreGame = scoreGame;
        }

        public Review(int idUser, int idGame, string descriptionReview, int scoreGame, User user)
        {
            this.idUser = idUser;
            this.idGame = idGame;
            this.descriptionReview = descriptionReview;
            this.scoreGame = scoreGame;
            this.user = user;
        }
        public Review()
        {
        }
    }
}