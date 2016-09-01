using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSTrack
{
    public interface IGPSTrack
    {
        Task<string> getLocation();
    }
}
