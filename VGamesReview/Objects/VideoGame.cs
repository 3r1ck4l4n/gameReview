using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VGamesReview
{
    public class VideoGame
    {
        private int id_game;
        private string nameVideoGame;
        private string descriptionGame;
        private string specifications;
        private string category;
        private string image;

        public VideoGame(int id_game,string nameVideoGame, string descriptionGame, string specifications, string category, string image)
        {
            this.id_game = id_game;
            this.nameVideoGame = nameVideoGame;
            this.descriptionGame = descriptionGame;
            this.specifications = specifications;
            this.category = category;
            this.image = image;
        }

        public VideoGame() { 
        }
        public string NameVideoGame { get => nameVideoGame; set => nameVideoGame = value; }
        public string DescriptionGame { get => descriptionGame; set => descriptionGame = value; }
        public string Specifications { get => specifications; set => specifications = value; }
        public string Image { get => image; set => image = value; }
        public int Id_game { get => id_game; set => id_game = value; }
    }
}