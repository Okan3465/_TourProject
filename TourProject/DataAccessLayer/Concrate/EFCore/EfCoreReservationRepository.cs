using DataAccessLayer.Abstract;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate.EFCore
{
    public class EfCoreReservationRepository : EfCoreGenericRepository<Reservation, TurContext>, IReservationDal
    {
        TurContext turContext=new TurContext();
        public List<Reservation> GetAcceptedReservations(int id)
        {
            return turContext.Reservations.Include(x => x.Destination).Where(x => x.Status == "Rezervasyon Onaylandı" && x.AppUserId == id).ToList();
        }

        public List<Reservation> GetListOfPreviousReservations(int id)
        {
            return turContext.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id).ToList();
        }

        public List<Reservation> GetListWithReservationByPendingApproval(int id)
        {
            return turContext.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onay Bekliyor" && x.AppUserId==id).ToList();
        }
    }
}
