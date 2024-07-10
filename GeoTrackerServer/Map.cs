using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GeoTracker.Data;
using GeoTracker.Entities;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Microsoft.EntityFrameworkCore;

namespace GeoTracker
{
    public partial class Map : Form
    {
        private ApplicationDbContext _context;
        private GMapOverlay markersOverlay;

        public Map()
        {
            InitializeComponent();
            timer1.Start();
            markersOverlay = new GMapOverlay("markers");
            _context = new ApplicationDbContext();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            GetAllMarkers();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            gMapControl1.ShowCenter = false;
            gMapControl1.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.Position = new PointLatLng(36.848349, 28.254476);
            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 18;
            gMapControl1.Zoom = 12;
            gMapControl1.OnMarkerClick += new MarkerClick(gMapControl1_OnMarkerClick);

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

            gMapControl1.Overlays.Add(markersOverlay);
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom += 1;
        }

        private void btnZoom2_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom -= 1;
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (item.Tag is Entities.Location location)
            {
                textBox1.Text = location.User.UserName;
                textBox2.Text = location.Latitude.ToString(); 
                textBox3.Text = location.Longitude.ToString();
            }
        }

        private void GetAllMarkers()
        {
            List<Entities.Location> locations = _context.Locations.Include(l => l.User).ToList();
            var currentMarkers = markersOverlay.Markers.ToList();

            foreach (Entities.Location location in locations)
            {
                var existingMarker = currentMarkers.FirstOrDefault(m => m.Tag is Entities.Location l && l.Id == location.Id);
                if (existingMarker != null)
                {
                    existingMarker.Position = new PointLatLng(location.Latitude, location.Longitude);
                    existingMarker.Tag = location;
                }
                else
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(location.Latitude, location.Longitude),
                        GMarkerGoogleType.blue_small)
                    {
                        Tag = location
                    };
                    markersOverlay.Markers.Add(marker);
                }
            }

            var locationIds = locations.Select(l => l.Id).ToList();
            for (int i = currentMarkers.Count - 1; i >= 0; i--)
            {
                var marker = currentMarkers[i];
                if (marker.Tag is Entities.Location l && !locationIds.Contains(l.Id))
                {
                    markersOverlay.Markers.Remove(marker);
                }
            }

            gMapControl1.Refresh();
        }

    }
}
