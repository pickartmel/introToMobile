using CustomGPS.Custom;
using Xamarin.Forms;

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

        void Update_Clicked(object sender, System.EventArgs e)
        {
            DependencyService.Get<ICurrentLocation>().UpdateCurrentLocation();
        }

       

    }
}
