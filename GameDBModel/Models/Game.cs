using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameDBModel
{
    [MetadataType(typeof(GameMeta))]
    partial class Game
    {
        class GameMeta
        {
            [Display (Name = "Game Tile", Description= "Display Name of the Game")]
            
            public string Title { get; set; }

             [Display(Name = "Game Platform", Description = "Platform i.e Android, Windows, IOS")]
            public string Platform { get; set; }

        }
    }

  
}
