using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoTracker.Presentation;

namespace GeoTracker.DataAccess.Abstract
{
    public interface IUserDal
    {
        bool Add(User user);
    }
}
