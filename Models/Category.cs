namespace BonTemps.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DishRef { get; set; }
        public Dish Dish { get; set; }
    }
}
