using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_LoveCards.Models
{
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Stack<Card> matches;
        public byte Points { get; set; }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
            matches = new Stack<Card>();
            Points = 0;
        }


        public Card ChooseCard()
        {
            throw new NotImplementedException();
        }
    }
}
