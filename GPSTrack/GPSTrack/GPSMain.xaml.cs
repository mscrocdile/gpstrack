using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GPSTrack
{
    public partial class GPSMain : ContentPage
    {
        public GPSMain()
        {
            InitializeComponent();
            var gpslist = new ObservableCollection<string>();
            lv.ItemsSource = gpslist;
        }
                
        public void trackclicked(object sender, EventArgs e)
        {
            string loc = DependencyService.Get<IGPSTrack>().getLocation().Result;
            
            (lv.ItemsSource as ObservableCollection<string>).Insert(0,loc);
        }

       

    }
}
