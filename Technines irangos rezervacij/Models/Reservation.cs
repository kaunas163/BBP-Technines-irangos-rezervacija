using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Technines_irangos_rezervacij.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public DateTime TimeFrom { get; set; }

        public DateTime TimeTo { get; set; }

        public int ReservationStatusId { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
    }
}