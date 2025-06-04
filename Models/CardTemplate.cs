using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_LoveCards.Models
{
    public class CardTemplate : ICardTemplate
    {
        //Flyweight for the card, sharing the const data.
        private readonly string imagePath;
        private readonly Monster cardType;
        public string ImagePath => imagePath;

        public Monster CardType => cardType;
        
        

        public CardTemplate(int monster)
        { 
            cardType = (Monster)monster;
            imagePath = (cardType.ToString().ToLower() + ".png");
        }

    }


}


