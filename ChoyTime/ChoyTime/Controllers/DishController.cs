using ChoyTime.Models;
using ChoyTime.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoyTime.Controllers
{
    public class DishController : Controller
    {
        private readonly IDishRepository _dishRespository;
        private readonly ICategoryRepository _categoryRepository;

        public DishController(IDishRepository dishRespository, ICategoryRepository categoryRepository)
        {

            _dishRespository = dishRespository;
            _categoryRepository = categoryRepository;

        }

        //public ViewResult List()
        //{
        //    DishesListViewModel dishesListViewModel = new DishesListViewModel();
        //    dishesListViewModel.Dishes = _dishRespository.AllDishes;

        //    dishesListViewModel.CurrentCategory = "Main Dishes";
        //    return View(dishesListViewModel);

        //}

        //new list action for improvements
        public ViewResult List(string category)
        {
            IEnumerable<Dish> dishes;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                dishes = _dishRespository.AllDishes.OrderBy(p => p.DishId);
                currentCategory = "All dishes";
            }
            else
            {
                dishes = _dishRespository.AllDishes.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.DishId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new DishesListViewModel
            {
                Dishes = dishes,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var dish = _dishRespository.GetDishById(id);
            if(dish == null)
            {
                return NotFound();
            }
            return View(dish);
        }

    }
}
