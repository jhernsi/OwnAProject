using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDBModel
{
   public class MemberWithFavGames
    {
       public int ID { get; set; }
        public Member Member { get; set; }
        public List<FavGame> FavGames { get; set; }

        public MemberWithFavGames()
        {
            FavGames = new List<FavGame>();
        }
    }

   public class FavGame
    {
       public int ID { get; set; }
        public bool isFav { get; set; }
        public Game Game { get; set; }

    }
}
