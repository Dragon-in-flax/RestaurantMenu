using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public interface IFormatStrategy
    {
        string Format(List<Dish> dishes);
    }
}
