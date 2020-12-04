using ChoyTime.Models;
using ChoyTime.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoyTime.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDishRepository _dishRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IDishRepository dishRepository, ShoppingCart shoppingCart)
        {
            _dishRepository = dishRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int dishId)
        {
            var selectedDish = _dishRepository.AllDishes.FirstOrDefault(p => p.DishId == dishId);

            if (selectedDish != null)
            {
                _shoppingCart.AddToCart(selectedDish, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int dishId)
        {
            var selectedDish = _dishRepository.AllDishes.FirstOrDefault(p => p.DishId == dishId);

            if (selectedDish != null)
            {
                _shoppingCart.RemoveFromCart(selectedDish);
            }
            return RedirectToAction("Index");
        }
    }
}
