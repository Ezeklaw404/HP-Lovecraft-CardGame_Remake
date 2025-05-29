using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_LoveCards.Models
{
    public class CardTemplate
    {
        //Flyweight for the card, sharing the const data.
        public readonly string cardBack = "cardback.png";
        public readonly string imagePath;
        public readonly Monster cardType;
        

        public CardTemplate(int monster)
        {
            cardType = (Monster)monster;
            imagePath = (cardType.ToString().ToLower() + ".png");
        }
    }

    //My different monsters, as this is where they are used/originate from I added them into this file
    public enum Monster 
    {
        Azathoth, Cthulhu, Cultist, Dagon, ElderSign, MiGo,
            Necronomicon, NightGaunt, Nyarlathotep, YogSothoth
    }
}
