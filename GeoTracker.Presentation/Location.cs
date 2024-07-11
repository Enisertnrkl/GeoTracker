using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoTracker.Presentation.Abstract;

namespace GeoTracker.Presentation
{
    public class Location : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        DateTime TimeStamp { get; set; }
        public User User { get; set; }
    }
}
