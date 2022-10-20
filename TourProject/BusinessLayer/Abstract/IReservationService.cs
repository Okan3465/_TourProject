using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLayer.Abstract.IGenericService;

namespace BusinessLayer.Abstract
{
   public interface IReservationService :IGenericService<Reservation>
    {
        List<Reservation> GetListWithReservationByPendingApproval(int id);
        List<Reservation> GetAcceptedReservations(int id);
        List<Reservation> GetListOfPreviousReservations(int id);
    }
}
