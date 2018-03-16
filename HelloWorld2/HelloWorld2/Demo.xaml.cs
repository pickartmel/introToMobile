using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld2
{
    public partial class Demo : ContentPage
    {

        public Demo()
        {
            InitializeComponent();
        }


        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (lblDisplay.Text == "Good Bye For Now")
            {
                lblDisplay.Text = "Hello World";
            }
            else
            {
                lblDisplay.Text = "Good Bye For Now"; 
            }
        }
    }
}
