using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_LoveCards.Models
{
    public class GameBoard
    {
        public readonly int PAIRS_COUNT = Enum.GetValues(typeof(Monster)).Length;
        private static GameBoard instance;
        public static GameBoard Instance => instance ??= new GameBoard();

        public List<Card> Cards { get; private set; }

        private GameBoard()
        {
            GenerateCards();
        }

        public void NewGame()
        {
            GenerateCards();
        }

        public void GenerateCards()
        {
            var cards = new List<Card>();
            int id = 0;

            for (int i = 0; i < PAIRS_COUNT; i++)
            {
                cards.Add(new Card(id++, new CardTemplate(i)));
                cards.Add(new Card(id++, new CardTemplate(i)));
            }

            // Shuffle cards
            Cards = cards.OrderBy(c => Guid.NewGuid()).ToList();

        }
    }
}
