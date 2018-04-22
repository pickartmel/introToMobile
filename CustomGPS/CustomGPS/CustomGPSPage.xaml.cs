using CustomGPS.Custom;
using Xamarin.Forms;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using System;

namespace CustomGPS
{
    public partial class CustomGPSPage : ContentPage
    {
        public CustomGPSPage()
        {
            InitializeComponent();
            DependencyService.Get<ICurrentLocation>().LocationUpdated += delegate
            {
                lblLon.Text = App.CurrentLon.ToString();
                lblLat.Text = App.CurrentLat.ToString();
            };
        }

        private async void Update_Clicked(object sender, System.EventArgs e)
        {
           DependencyService.Get<ICurrentLocation>().UpdateCurrentLocation();

            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);

            lblLon.Text = position.Longitude.ToString();
            lblLat.Text = position.Latitude.ToString();


        }

       

    }
}
