using System.Collections.Generic;

namespace BonTemps.Models
{
    public class Allergen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public ICollection<AllergenDish> AllergenDishes { get; set; }
    }
}
