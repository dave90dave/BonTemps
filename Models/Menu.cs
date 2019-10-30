using System.Collections.Generic;

namespace BonTemps.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public ICollection<ReservationMenu> ReservationMenus { get; set; }
        public ICollection<DishMenu> DishMenus { get; set; }
    }
}
