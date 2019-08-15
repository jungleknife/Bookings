﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TableBooking.Data
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}
