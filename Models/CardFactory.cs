using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_LoveCards.Models
{
    public static class CardFactory
    {
        private static readonly Dictionary<int, ICardTemplate> _templates = new();


        public static ICardTemplate GetTemplate(int monsterId)
        {
            if (!_templates.ContainsKey(monsterId))
            {
                _templates[monsterId] = new CardTemplate(monsterId);
            }
            return _templates[monsterId];
        }


    }
}
