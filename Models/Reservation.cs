using System;
using System.Collections.Generic;

namespace BonTemps.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Persons { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<ReservationTable> ReservationTables { get; set; }
        public ICollection<ReservationMenu> ReservationMenus { get; set; }
    }
}
