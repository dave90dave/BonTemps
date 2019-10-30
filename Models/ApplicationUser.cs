using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BonTemps.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string Hometown { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
