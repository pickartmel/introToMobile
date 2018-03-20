using System;
using System.Collections.Generic;
using PlatoClalculator.Views;
using Xamarin.Forms;

namespace PlatoClalculator.Views
{
    public partial class ManPage : ContentPage
    {
        public ManPage()
        {
            InitializeComponent();
        }

        void btnEnter_Clicked(object sender, System.EventArgs e)
        {try
            {
                decimal decMansAge;
                decimal.TryParse(txtMansAge.Text, out decMansAge);
                lblAgeOfWoman.Text = "Your spouses' perfect age is: " + (decMansAge / 2 + 7).ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Error",ex.Message, "Ok");
            }


        }
    }
}
