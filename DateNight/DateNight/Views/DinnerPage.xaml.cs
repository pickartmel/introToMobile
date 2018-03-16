using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DateNight.Views
{
    public partial class DinnerPage : ContentPage
    {
        public DinnerPage()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            App.dateCalc.DinnerCost = txtDinnerCost.Text;
        }
    }
}
