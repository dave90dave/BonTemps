using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonTemps.Models
{
    public class Table
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public ICollection<ReservationTable> ReservationTables { get; set; }
    }
}
