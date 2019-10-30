using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BonTemps.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public ICollection<DishMenu> DishMenus { get; set; }
        public Category Category { get; set; }
        public ICollection<AllergenDish> AllergenDishes { get; set; }
    }
}
