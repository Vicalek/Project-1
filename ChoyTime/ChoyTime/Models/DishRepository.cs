using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoyTime.Models
{
    public class DishRepository : IDishRepository
    {
        private readonly AppDbContext _appDbContext;
        public DishRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Dish> AllDishes
        {
            get
            {
                return _appDbContext.Dishes.Include(c => c.Category);
            }
        }

        public IEnumerable<Dish> DishOfTheWeek
        {
            get
            {
                return _appDbContext.Dishes.Include(c => c.Category).Where(p => p.DishOfTheWeek);
            }
        }

    public Dish GetDishById(int dishId)
        {
            return _appDbContext.Dishes.FirstOrDefault(p => p.DishId == dishId);
        }
    }
}
