using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public string cityname()
        {
            throw new NotImplementedException();
        }

        public void Create(City entity)
        {
            _cityDal.Create(entity);
        }

        public void Delete(City entity)
        {
            _cityDal.Delete(entity);
        }

        public List<City> GetAll()
        {
            return _cityDal.GetListAll();
        }

        public City GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(City entity)
        {
            _cityDal.Update(entity);
        }

        public void Update(City entity, int[] sehirIds)
        {
            throw new NotImplementedException();
        }
    }
}
