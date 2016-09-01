using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using GPSTrack.Droid;
using Plugin.Geolocator;
using System.Threading.Tasks;

[assembly: Dependency(typeof(GetLocation))]
namespace GPSTrack.Droid
{
    public class GetLocation : Java.Lang.Object, IGPSTrack
    {
        public async Task<string> getLocation()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 2;

            var position = await locator.GetPositionAsync();

            return string.Format("{0} {1} {2}", position.Timestamp, position.Latitude, position.Longitude);
        }
      
    }
}