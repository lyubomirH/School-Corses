﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NeedForSpeed.classes
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            FuelConsimption = 1.25;

        }
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public virtual double FuelConsimption { get; set; }

        public virtual void Drive(double kilometers)
        {
            Fuel -= kilometers * FuelConsimption;
        }
    }
}
