using System.Collections.Generic;
using System.ComponentModel;

namespace BonTemps.Models
{
    public class Menu
    {
        [DisplayName("Menuid")]
        public int Id { get; set; }
        [DisplayName("Menunaam")]
        public string Name { get; set; }
        [DisplayName("Menu beschrijving")]
        public string Description { get; set; }
        [DisplayName("Foto pad")]
        public string ImagePath { get; set; }
        public ICollection<ReservationMenu> ReservationMenus { get; set; }
        public ICollection<DishMenu> DishMenus { get; set; }
    }
}
