using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DateNight.Views
{
    public partial class CoffeePage : ContentPage
    {
        public CoffeePage()
        {
            InitializeComponent();

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            App.dateCalc.CoffeeCost = txtCoffeeCost.Text;
        }
    }
}
