using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICityService
    {
        City GetById(int id);
        List<City> GetAll();
        void Create(City entity);
       
        void Update(City entity);
        void Delete(City entity);

        string cityname();
        void Update(City entity, int[] sehirIds);
    }
}
