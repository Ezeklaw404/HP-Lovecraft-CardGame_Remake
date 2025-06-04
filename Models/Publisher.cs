using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_LoveCards.Models
{
    public class Publisher : IPublisher
    {
        private readonly List<ISubscriber> _subscribers = new();

        public void Subscribe(ISubscriber observer)
        {
            if (!_subscribers.Contains(observer))
                _subscribers.Add(observer);
        }

        public void Unsubscribe(ISubscriber observer)
        {
            _subscribers.Remove(observer);
        }

        public void Notify(Card card)
        {
            foreach (var observer in _subscribers)
            {
                observer.Update(card);
            }
        }

    }
}
