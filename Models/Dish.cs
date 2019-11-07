using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BonTemps.Models
{
    public class Dish
    {
        public int Id { get; set; }
        [DisplayName("Gerecht Naam")]
        public string Name { get; set; }
        [DisplayName("Gerecht beschrijving")]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Prijs")]
        public decimal Price { get; set; }
        [DisplayName("Foto Pad")]
        public string ImagePath { get; set; }
        public ICollection<DishMenu> DishMenus { get; set; }
        public int CategoryRef { get; set; }
        public Category Category { get; set; }
        public ICollection<AllergenDish> AllergenDishes { get; set; }
    }
}
