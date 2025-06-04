using HP_LoveCards.ViewModels;
using Microsoft.Maui.Controls;
using System;

namespace HP_LoveCards
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new GameViewModel();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (BindingContext is GameViewModel vm)
            {
                vm.CardBtn.Clear();
                _GameBoard.Children.Clear(); // in case it's reappearing

                int cols = 5;
                int rows = 4;
                int i = 0;

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (i >= vm.Cards.Count)
                            break;

                        var card = vm.Cards[i++];

                        var imageButton = new ImageButton
                        {
                            BindingContext = card,
                            Source = card.ImageSource,
                            Aspect = Aspect.AspectFit,
                            BackgroundColor = Colors.Transparent,
                        };

                        // Bind the Source to the Card's ImageSource property
                        imageButton.SetBinding(ImageButton.SourceProperty, nameof(card.ImageSource));

                        // Hook up click behavior
                        imageButton.Clicked += (s, e) =>
                        {
                            vm.FlipCard(card);
                            //imageButton.Source = card.ImageSource;
                        };

                        _GameBoard.Children.Add(imageButton);
                        vm.CardBtn.Add(imageButton);
                        Grid.SetRow(imageButton, row);
                        Grid.SetColumn(imageButton, col);
                    }
                }
            }
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            if (BindingContext is GameViewModel viewModel)
            {
                viewModel.NewGame();
                OnAppearing(); // redraw the UI
            }
        }


    }

}




//publisher - observer pattern
//list of observers,
//unsubscribe
//subscribe
//update
//invoke