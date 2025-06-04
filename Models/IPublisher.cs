using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_LoveCards.Models
{
    public interface IPublisher
    {
        void Subscribe(ISubscriber observer);
        void Unsubscribe(ISubscriber observer);
        void Notify(Card card);
    }
}
