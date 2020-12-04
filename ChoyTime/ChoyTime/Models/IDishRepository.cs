using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoyTime.Models
{
    public interface IDishRepository
    {
        IEnumerable<Dish> AllDishes { get; }
        IEnumerable<Dish> DishOfTheWeek { get; }
        Dish GetDishById(int dishId);
    }
}
