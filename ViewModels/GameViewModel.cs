using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HP_LoveCards.Models;

namespace HP_LoveCards.ViewModels
{
    public class GameViewModel : HP_LoveCards.Models.ISubscriber
    {
        public ObservableCollection<Card> Cards { get; set; }
        public List<ImageButton> CardBtn { get; set; }

        private Publisher publisher;

        public GameViewModel()
        {
            publisher = new();
            LoadCards();

        }

        private void LoadCards()
        {
            GameBoard.Instance.GenerateCards(publisher);
            Cards = new ObservableCollection<Card>(GameBoard.Instance.Cards);
            CardBtn = new List<ImageButton>();

            SubscribeToCards();
        }
        private void SubscribeToCards()
        {
            foreach (var card in Cards)
                publisher.Subscribe(this);
        }

        public void FlipCard(Card card)
        {
            card.Flip();
        }

        public void NewGame()
        {
            GameBoard.Instance.GenerateCards(publisher);

            Cards.Clear();
            foreach (var card in GameBoard.Instance.Cards)
                Cards.Add(card);
        }

        public void Update(Card card)
        {
            var btn = CardBtn.FirstOrDefault(b => b.BindingContext == card);
            if (btn != null)
                btn.Source = card.ImageSource;
        }


    }
}
