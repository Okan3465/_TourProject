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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void CustomerAdd(Customer customer)
        {
            _customerDal.Create(customer);
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Customer t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Customer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Customer t)
        {
            throw new NotImplementedException();
        }
    }
}
