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
    public class RouteManager : IRouteService
    {
        IRouteDal _routeDal;

        public RouteManager(IRouteDal routeDal)
        {
            _routeDal = routeDal;
        }

        public void Create(Route entity)
        {
            _routeDal.Create(entity);
        }

        public void Delete(Route entity)
        {
            _routeDal.Delete(entity);
        }

        public List<Route> GetAll()
        {
            return _routeDal.GetListAll();
        }

        public Route GetById(int id)
        {
            return _routeDal.GetById(id);
        }

        public string GetFrom(string from)
        {
            return _routeDal.GetFrom(from);
        }

        public int GetRouteBystrtFnsh(string start, string route1, string route2, string route3, string finish)
        {
            return _routeDal.GetRouteByStrtFnsh(start, route1, route2, route3, finish);
        }

        public Route GetRouteDetails(int id)
        {
            return _routeDal.GetRouteDetails(id);
        }

        public string GetTo(string to)
        {
            return _routeDal.GetTo(to);
        }

        public List<Route> GetTravel(string from, string to)
        {
            return _routeDal.GetTravel(from, to);
        }

        public void Update(Route entity)
        {
            _routeDal.Update(entity);
        }
    }
}
