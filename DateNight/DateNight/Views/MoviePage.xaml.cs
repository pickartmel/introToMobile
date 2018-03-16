using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DateNight.Views
{
    public partial class MoviePage : ContentPage
    {
        public MoviePage()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            App.dateCalc.MovieCost = txtMovieCost.Text;
        }
    }
}
