using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FinalProject.Views
{
    public partial class MusicPage : ContentPage
    {
        decimal newPoints;
        decimal currentPoints;

        public MusicPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ResultsPage());
        }

        private void WhenImGone_Handled(object sender, EventArgs e)
        {
            decimal.TryParse(lblMusicPoints.Text, out currentPoints);
            newPoints = currentPoints + 1;
            lblMusicPoints.Text = newPoints.ToString();
        }
        private void CarryOn_Clicked(object sender, EventArgs e)
        {
            decimal.TryParse(lblMusicPoints.Text, out currentPoints);
            newPoints = currentPoints + 1;
            lblMusicPoints.Text = newPoints.ToString();
        }
        private void Sail_Clicked(object sender, EventArgs e)
        {
            decimal.TryParse(lblMusicPoints.Text, out currentPoints);
            newPoints = currentPoints + 1;
            lblMusicPoints.Text = newPoints.ToString();
        }

        private void Ignition_Clicked(object sender, EventArgs e)
        {
            decimal.TryParse(lblMusicPoints.Text, out currentPoints);
            newPoints = currentPoints + 2;
            lblMusicPoints.Text = newPoints.ToString();
        }
        private void BringMeToLife_Clicked(object sender, EventArgs e)
        {
            decimal.TryParse(lblMusicPoints.Text, out currentPoints);
            newPoints = currentPoints + 2;
            lblMusicPoints.Text = newPoints.ToString();
        }
        private void StacysMom_Clicked(object sender, EventArgs e)
        {
            decimal.TryParse(lblMusicPoints.Text, out currentPoints);
            newPoints = currentPoints + 2;
            lblMusicPoints.Text = newPoints.ToString();
        }

        private void StepByStep_Clicked(object sender, EventArgs e)
        {
            decimal.TryParse(lblMusicPoints.Text, out currentPoints);
            newPoints = currentPoints + 3;
            lblMusicPoints.Text = newPoints.ToString();
        }
        private void NothingCompares2U_Clicked(object sender, EventArgs e)
        {
            decimal.TryParse(lblMusicPoints.Text, out currentPoints);
            newPoints = currentPoints + 3;
            lblMusicPoints.Text = newPoints.ToString();
        }
        private void LiveWOYou_Clicked(object sender, EventArgs e)
        {
            decimal.TryParse(lblMusicPoints.Text, out currentPoints);
            newPoints = currentPoints + 3;
            lblMusicPoints.Text = newPoints.ToString();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            App.ageCalc.MusicAge = lblMusicPoints.Text;

        }

    }
}
