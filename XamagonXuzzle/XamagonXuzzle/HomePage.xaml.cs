using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamagonXuzzle
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent ();
        }

        async void OnButtonTap(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Hello There!", "Would you like to play a game?", "Yes", "No");
            if (answer == true)
            {
                PuzzlePage puzzle = new PuzzlePage();
                await Navigation.PushModalAsync(puzzle);
            }
        }
    }
}
