using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  DataAccessLayer.Concrate.EFCore;

namespace DataAccessLayer.Concrate.EFCore
{
   public class EfCoreAboutRepository :EfCoreGenericRepository<About, TurContext>, IAboutDal
    {

    }
}
