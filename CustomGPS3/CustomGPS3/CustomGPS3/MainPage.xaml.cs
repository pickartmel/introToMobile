using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Geolocator;

namespace CustomGPS3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void Update_Clicked(object sender, System.EventArgs e)
        {
            // DependencyService.Get<ICurrentLocation>().UpdateCurrentLocation();

            await RetrieveLocation();


            //var locator = CrossGeolocator.Current;
            //locator.DesiredAccuracy = 50;

            //var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);

            //lblLon.Text = position.Longitude.ToString();
            //lblLat.Text = position.Latitude.ToString();


        }

        private async Task RetrieveLocation()
        {

            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);

            lblLon.Text = position.Longitude.ToString();
            lblLat.Text = position.Latitude.ToString();


        }
    }
}
