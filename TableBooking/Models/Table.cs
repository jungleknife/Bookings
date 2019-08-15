using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TableBooking.Data
{
    public class Table
    {
        public int TableID { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public int TableNumber { get; set; }
    }
}
