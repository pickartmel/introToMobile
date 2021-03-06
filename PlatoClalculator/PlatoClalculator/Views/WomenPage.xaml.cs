﻿using System;
using System.Collections.Generic;
using PlatoClalculator.Custom;

using Xamarin.Forms;

namespace PlatoClalculator.Views
{
    public partial class WomenPage : ContentPage
    {
        public WomenPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            {
                try                 {                     decimal decWomansAge;                     decimal.TryParse(txtWomansAge.Text, out decWomansAge);                     lblAgeOfMan.Text = "Your spouses' perfect age is: " + (decWomansAge * 2 - 7).ToString();                 }                 catch (Exception ex)                 {                     DisplayAlert("Error", ex.Message, "Ok");                 } 
            }
        }

        void ClearHandle_Clicked(object sender, System.EventArgs e)
        {
            txtWomansAge.Text = string.Empty;
            lblAgeOfMan.Text = string.Empty;
        }
    }
}