using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoTracker.DataAccess.Data;
using GeoTracker.Presentation;
using GeoTracker.Presentation.Abstract;
using Microsoft.EntityFrameworkCore;

namespace GeoTracker.DataAccess
{
    public class LocationDAL : ILocationDAL
    {
        private readonly ApplicationDbContext _context;

        public LocationDAL()
        {
            _context = new ApplicationDbContext();
        }

        public List<Location> GetAllLocations()
        {
            return  _context.Locations.Include(l => l.User).ToList();
        }
    }
}
