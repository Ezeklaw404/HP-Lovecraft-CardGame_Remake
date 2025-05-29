using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_LoveCards.Models
{
    public class Card : INotifyPropertyChanged
    {
        public int Id {  get; set; }
        public CardTemplate Template { get; set; }
        private bool isFlipped;


        public bool IsFlipped
        {
            get => isFlipped;
            set
            {
                if (isFlipped != value)
                {
                    isFlipped = value;
                    OnPropertyChanged(nameof(IsFlipped));
                    OnPropertyChanged(nameof(ImageSource));
                }
            }
        }

        public string ImageSource => IsFlipped ? Template.imagePath : Template.cardBack;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public Card(int id, CardTemplate template)
        {
            Id = id;
            Template = template;
            IsFlipped = false;
        }
    }
}
