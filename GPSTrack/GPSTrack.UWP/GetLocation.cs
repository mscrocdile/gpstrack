using GPSTrack.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetLocation))]
namespace GPSTrack.UWP
{
    
    public class GetLocation : Object, IGPSTrack
    {
        public async Task<string> getLocation()
        {
            return await Task.Run(()=> "not implemented").ConfigureAwait(false);
        }

    }
    
}
