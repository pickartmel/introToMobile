using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FinalProject.Views
{
    public partial class MoviePage : ContentPage
    {
        decimal newPoints;
        decimal currentPoints;
        
        public MoviePage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
           Navigation.PushAsync(new MusicPage());
        }

        void IdentityTheif_Handled(object sender, System.EventArgs e)
        {
            decimal.TryParse(lblPoints.Text, out currentPoints);
            newPoints = currentPoints +1 ;
            lblPoints.Text = newPoints.ToString();
        }

        void IronMan3_Clicked(object sender, System.EventArgs e)
        {
            decimal.TryParse(lblPoints.Text, out currentPoints);
            newPoints = currentPoints + 1;
            lblPoints.Text = newPoints.ToString();
        }

        void Mummy_Clicked(object sender, System.EventArgs e)
        {
            decimal.TryParse(lblPoints.Text, out currentPoints);
            newPoints = currentPoints + 1;
            lblPoints.Text = newPoints.ToString();
        }

        void VanillaSky_Clicked(object sender, System.EventArgs e)
        {
            decimal.TryParse(lblPoints.Text, out currentPoints);
            newPoints = currentPoints + 1;
            lblPoints.Text = newPoints.ToString();
        }

        void OldSchool_Clicked(object sender, System.EventArgs e)
        {
            decimal.TryParse(lblPoints.Text, out currentPoints);
            newPoints = currentPoints + 1;
            lblPoints.Text = newPoints.ToString();
        }

        void Matrix_Clicked(object sender, System.EventArgs e)
        {
            decimal.TryParse(lblPoints.Text, out currentPoints);
            newPoints = currentPoints + 1;
            lblPoints.Text = newPoints.ToString();
        }
    }
}
