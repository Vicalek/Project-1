using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoyTime.Models
{
    public class MockDishRepository: IDishRepository
    {
        //Hard coded catagory repo instance
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Dish> AllDishes =>
            new List<Dish>
            {
                new Dish {DishId = 1, Name="Steak", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="This is a long description", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InStock=true, DishOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"},
                new Dish {DishId = 2, Name="Wings", Price=7.95M, ShortDescription="Lorem Ipsum", LongDescription="This is a long description", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", InStock=true, DishOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"},
                new Dish {DishId = 3, Name="Cake", Price=4.95M, ShortDescription="Lorem Ipsum", LongDescription="This is a long description", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", InStock=true, DishOfTheWeek=false,ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg"},
                new Dish {DishId = 4, Name="Soda", Price=1.95M, ShortDescription="Lorem Ipsum", LongDescription="This is a long description", Category = _categoryRepository.AllCategories.ToList()[3],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", InStock=true, DishOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg"}
            };

        public IEnumerable<Dish> DishOfTheWeek { get; }

        public Dish GetDishById (int dishId)
        {
            return AllDishes.FirstOrDefault(p => p.DishId == dishId);
        }

    }
}
