﻿namespace BonTemps.Models
{
    public class AllergenDish
    {
        public int AllergenId { get; set; }
        public Allergen Allergen { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }
    }
}
