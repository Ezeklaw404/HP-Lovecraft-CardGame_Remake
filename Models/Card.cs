using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_LoveCards.Models
{
    public class Card
    {
        public int Id {  get; set; }
        public ICardTemplate Template { get; }
        public readonly IPublisher publisher;
        private bool isFlipped;
        public bool IsFlipped => isFlipped;
        public string ImageSource => IsFlipped ? Template.ImagePath : ICardTemplate.CardBack;


        public Card(int id, ICardTemplate template, IPublisher publisher)
        {
            Id = id;
            Template = template;
            isFlipped = false;
            this.publisher = publisher;
        }

        public void Flip()
        {
            isFlipped = !isFlipped;
            publisher.Notify(this);
        }










    }
}


