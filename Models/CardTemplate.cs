using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_LoveCards.Models
{
    public class CardTemplate
    {
        public readonly string cardBack = "cardback.png";
        public readonly string imagePath;
        public readonly Monster cardType;
        

        public CardTemplate(int monster)
        {
            cardType = (Monster)monster;
            imagePath = (cardType.ToString().ToLower() + ".png");
        }
    }

    public enum Monster 
    {
        Azathoth, Cthulhu, Cultist, Dagon, ElderSign, MiGo,
            Necronomicon, NightGaunt, Nyarlathotep, YogSothoth
    }
}
