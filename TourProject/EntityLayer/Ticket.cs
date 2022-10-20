using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int SeatNo { get; set; }
        public double Price { get; set; }
        public Route Route { get; set; }
        public int RouteId { get; set; }
    }
}
