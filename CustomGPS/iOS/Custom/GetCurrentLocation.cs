using System;
using CustomGPS.Custom;
using Plugin.Geolocator;



[assembly: Xamarin.Forms.Dependency(typeof(CustomGPS.iOS.Custom.GetCurrentLocation))]

namespace CustomGPS.iOS.Custom
{
    public class GetCurrentLocation : ICurrentLocation
    {
        public event EventHandler LocationUpdated;
        GeolocatorImplementation locator;


       

        public GetCurrentLocation()
        {
            locator = new GeolocatorImplementation();
        }

        public void UpdateCurrentLocation()
        {
            
            locator.GetPositionAsync(timeout: 10000).ContinueWith(t =>
            {
                App.CurrentLat = t.Result.Latitud;
                App.CurrentLon =  t.Result.Longitude; 
                LocationUpdated(null, null);
            }, TaskSheduler.FromCurrentSynchronizationContext());





        }

    }
}
