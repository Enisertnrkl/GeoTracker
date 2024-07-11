using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoTracker.DataAccess.Abstract;
using GeoTracker.DataAccess.Data;
using GeoTracker.Presentation;

namespace GeoTracker.DataAccess
{
    public class UserDal : IUserDal
    {
        public bool Add(User user)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                if (user != null)
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
