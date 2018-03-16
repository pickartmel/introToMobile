using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DateNight.Views
{
    public partial class CostPage : ContentPage
    {
        public CostPage()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            lblTotalCost.Text = String.Empty;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            try 
            {
                lblTotalCost.Text = App.dateCalc.GetTotalCost();
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Ok");
            }



        }
    }
}
