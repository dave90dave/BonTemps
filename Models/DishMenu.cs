﻿namespace BonTemps.Models
{
    public class DishMenu
    {
        public int DishId { get; set; }
        public Dish Dish { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
