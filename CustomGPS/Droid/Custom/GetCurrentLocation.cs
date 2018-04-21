using System;
using CustomGPS.Custom;
using Plugin.Geolocator;

[assembly: Xamarin.Forms.Dependency(typeof(CustomGPS.Droid.Custom.GetCurrentLocation))]

namespace CustomGPS.Droid.Custom
{
    public class GetCurrentLocation : ICurrentLocation
    {
        public event EventHandler LocationUpdated;
       CrossGeolocator locator;

        public GetCurrentLocation()
        {
            var ctx = Xamarin.Forms.Forms.Context;
            locator = new CrossGeolocator(ctx) {DesiredAccuracy = 50};
        }

        public void UpdateCurrentLocation()
        {
            var position = await locator.GetPositionAsnyc(timeoutMilliseconds: 10000);
          //  locator.GetPositionAsync(timeout: 10000).ContinueWith(t =>
            {
                App.CurrentLat = t.Result.Latitud;
                App.CurrentLon = t.Result.Longitude;
                LocationUpdated(null, null);
            }, TaskSheduler.FromCurrentSynchronizationContext());
        }

    }
}
