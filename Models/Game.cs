﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_LoveCards.Models
{
    public class Game
    {
        public GameBoard Board { get; }

        public Game()
        {
            Board = GameBoard.Instance;
        }
    }
}
