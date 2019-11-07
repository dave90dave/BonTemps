using System.ComponentModel;

namespace BonTemps.Models
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Categorie Naam")]
        public string Name { get; set; }
        public Dish Dish { get; set; }
    }
}
