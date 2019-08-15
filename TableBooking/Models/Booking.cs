using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TableBooking.Data
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int TableID { get; set; }
        public DateTime BookingDate { get; set; }
        public string BookedFrom { get; set; }
        public string BookedUntil { get; set; }
        public int PartySize { get; set; }
    }
}
