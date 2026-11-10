using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Dish
    {
        public string Name {  get; set; }
        public string Category { get; set; }
        public string Composition { get; set; }
        public decimal Price { get; set; }

        public Dish(string name, string category, string composition, decimal price)
        {
            Name = name;
            Category = category;
            Composition = composition;
            Price = price;
        }
    }
}
