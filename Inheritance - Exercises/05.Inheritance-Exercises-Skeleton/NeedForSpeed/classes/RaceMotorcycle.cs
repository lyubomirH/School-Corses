﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.classes
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double RaceMotorcycleFuelConsumption = 8;

        public RaceMotorcycle(int horsePower, double fuel) 
            : base(horsePower, fuel) 
        { 
        }

        public override double FuelConsumption => RaceMotorcycleFuelConsumption;
    }
}
