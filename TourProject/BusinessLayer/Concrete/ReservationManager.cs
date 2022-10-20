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
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetAcceptedReservations(int id)
        {
            return _reservationDal.GetAcceptedReservations(id);
        }

        public Reservation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetList()
        {
            return _reservationDal.GetListAll();
        }

        public List<Reservation> GetListOfPreviousReservations(int id)
        {
            return _reservationDal.GetListOfPreviousReservations(id);
        }

        public List<Reservation> GetListWithReservationByPendingApproval(int id)
        {
            return _reservationDal.GetListWithReservationByPendingApproval(id);
        }

        public void TAdd(Reservation t)
        {
            _reservationDal.Create(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
