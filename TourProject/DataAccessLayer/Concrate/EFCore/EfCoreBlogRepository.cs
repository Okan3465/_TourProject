﻿using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate.EFCore
{
  public  class EfCoreBlogRepository : EfCoreGenericRepository<Blog, TurContext>, IBlogDal
    {

    }
}
