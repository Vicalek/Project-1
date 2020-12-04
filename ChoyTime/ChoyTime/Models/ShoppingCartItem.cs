using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoyTime.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Dish Dish { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
