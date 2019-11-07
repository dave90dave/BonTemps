using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BonTemps.Models
{
    public class ApplicationUser : IdentityUser
    {
        [DisplayName("Voornaam")]
        public string FirstName { get; set; }
        [DisplayName("Achternaam")]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
        [DisplayName("Adres")]
        public string Address { get; set; }
        [DisplayName("Postcode")]
        public string Zipcode { get; set; }
        [DisplayName("Stad")]
        public string Hometown { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
