using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BonTemps.Models
{
    public class Table
    {
        [DisplayName("TafelID")]
        public int Id { get; set; }
        [DisplayName("Tafel nummer")]
        public int Number { get; set; }
        public ICollection<ReservationTable> ReservationTables { get; set; }
    }
}
