﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.classes
{
    public class Cake : Dessert
    {
        private const double CakeGrams = 250;
        private const double CakeCalories = 1000;
        private const decimal CakePrice = 5m;

        public Cake(string name)
            : base(name, CakePrice, CakeGrams, CakeCalories) 
        {
        }
    }
}
