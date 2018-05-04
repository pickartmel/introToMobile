using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FinalProject.Views
{
    public partial class MoviePage : ContentPage
    {
        public MoviePage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
           Navigation.PushAsync(new MusicPage());
        }
    }
}
