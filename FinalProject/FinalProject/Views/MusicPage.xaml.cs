using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FinalProject.Views
{
    public partial class MusicPage : ContentPage
    {
        public MusicPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ResultsPage());
        }
    }
}
