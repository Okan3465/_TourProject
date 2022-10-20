﻿using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate.EFCore
{
   public class EfCoreCustomerRepository:EfCoreGenericRepository<Customer,TurContext>,ICustomerDal
    {

    }
}
