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
    public class GameViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Card> Cards { get; set; }
        public ICommand FlipCardCommand { get; }

        public GameViewModel()
        {
            LoadCards();
            FlipCardCommand = new Command<Card>(FlipCard);
        }

        private void LoadCards()
        {
            GameBoard.Instance.GenerateCards();
            Cards = new ObservableCollection<Card>(GameBoard.Instance.Cards);
            OnPropertyChanged(nameof(Cards));
        }

        private void FlipCard(Card card)
        {
            if (card != null)
                card.IsFlipped = !card.IsFlipped;
        }

        public void NewGame()
        {
            GameBoard.Instance.NewGame();

            Cards.Clear();
            foreach (var card in GameBoard.Instance.Cards)
                Cards.Add(card);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

    }
}
