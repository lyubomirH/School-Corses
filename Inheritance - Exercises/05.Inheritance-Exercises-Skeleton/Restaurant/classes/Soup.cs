﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.classes
{
    public class Soup : Starter
    {
        public Soup(string name, decimal price, double grams)
            : base(name, price, grams) 
        {
        }
    }
}
