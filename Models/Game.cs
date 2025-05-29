using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_LoveCards.Models
{
    public class Game
    {
        private static Game instance;
        public static Game Instance => instance ??= new Game();

        public GameBoard Board { get; }

        private Game()
        {
            Board = GameBoard.Instance;
        }

    }
}
