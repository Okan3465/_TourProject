﻿using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate.EFCore
{
    public class EfCoreDestinationRepository : EfCoreGenericRepository<Destination, TurContext>, IDestinationDal
    {
      
    }
}
