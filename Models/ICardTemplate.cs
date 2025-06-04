using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_LoveCards.Models
{
    public interface ICardTemplate
    {
        public const string CardBack = "cardback.png";
        string ImagePath {  get; }
        Monster CardType { get; }
    }
}
