using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TableBooking.Data
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        [DisplayName("First name")]
        [Display(Prompt ="Enter first name")]
        [MinLength(2), MaxLength(30)]
        public string FirstName { get; set; }
        [DisplayName("Last name")]
        [Required(ErrorMessage = "Please fill in your last name")]
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^(07\d{9}|447\d{9})$",
            ErrorMessage = "Please enter a valid mobile number")]
        public string Mobile { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
