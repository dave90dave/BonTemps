using System.Collections.Generic;
using System.ComponentModel;

namespace BonTemps.Models
{
    public class Allergen
    {
        public int Id { get; set; }
        [DisplayName("Allergienaam")]
        public string Name { get; set; }
        [DisplayName("Fotopad")]
        public string ImagePath { get; set; }
        public ICollection<AllergenDish> AllergenDishes { get; set; }
    }
}
