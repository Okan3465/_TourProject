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
    public class TicketManager : ITicketService
    {
        ITicketDal _ticketDal;

        public TicketManager(ITicketDal ticketDal)
        {
            _ticketDal = ticketDal;
        }
        public void Create(Ticket entity)
        {
            _ticketDal.Create(entity);
        }

        public void Delete(Ticket entity)
        {
            _ticketDal.Delete(entity);
        }

        public List<Ticket> GetAll()
        {
            return _ticketDal.GetListAll();
        }

        public Ticket GetById(int id)
        {
            return _ticketDal.GetById(id);
        }

        public int GetCountBySeat(int routeId)
        {
            return _ticketDal.GetCountBySeat(routeId);
        }

        public string GetDate(int id)
        {
            return _ticketDal.GetDate(id);
        }

        public string GetHour(int id)
        {
            return _ticketDal.GetHours(id);
        }

        public int GetId()
        {
            return _ticketDal.GetId();
        }

        public Ticket GetLastEntry()
        {
            return _ticketDal.GetLastEntry();
        }

        public List<int> GetSeat(int routeId)
        {
            return _ticketDal.GetSeat(routeId);
        }

        public void Update(Ticket entity)
        {
            _ticketDal.Update(entity);
        }

        public void Update(Ticket entity, int[] ticketIds)
        {
            throw new NotImplementedException();
        }

    }
}
