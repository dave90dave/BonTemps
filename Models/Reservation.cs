using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BonTemps.Models
{
    public class Reservation
    {
        [DisplayName("Reservering Id")]
        public int Id { get; set; }
        [DisplayName("Start Tijd")]
        public DateTime StartTime { get; set; }
        [DisplayName("Eind tijd")]
        public DateTime EndTime { get; set; }
        [DisplayName("Aantal personen")]
        public int Persons { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<ReservationTable> ReservationTables { get; set; }
        public ICollection<ReservationMenu> ReservationMenus { get; set; }
    }
}
