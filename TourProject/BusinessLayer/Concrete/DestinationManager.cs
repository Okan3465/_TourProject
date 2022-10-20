﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public Destination GetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public List<Destination> GetList()
        {
            return _destinationDal.GetListAll();
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Create(t);
        }

        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public void TUpdate(Destination t)
        {
            _destinationDal.Update(t);
        }
    }
}
