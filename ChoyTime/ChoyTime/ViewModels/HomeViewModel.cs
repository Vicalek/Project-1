﻿using ChoyTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoyTime.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Dish> DishOfTheWeek { get; set; }
    }
}
