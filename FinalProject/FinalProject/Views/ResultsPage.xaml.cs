using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FinalProject.Views
{
    public partial class ResultsPage : ContentPage
    {
        public ResultsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                lblRealAge.Text = string.Empty;
                lblRealAge.Text = App.ageCalc.TotalAge();
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Ok");
            }
        }
    }
}
