using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLayer.Concrate.EFCore.EfCoreRouteRepository;

namespace DataAccessLayer.Concrate.EFCore
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City, TurContext>, ICityDal
    {
        public string cityname()
        {
            throw new NotImplementedException();
        }
    }
}
