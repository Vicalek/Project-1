using ChoyTime.Models;
using ChoyTime.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoyTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDishRepository _dishRepository;

        public HomeController(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                DishOfTheWeek = _dishRepository.DishOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
