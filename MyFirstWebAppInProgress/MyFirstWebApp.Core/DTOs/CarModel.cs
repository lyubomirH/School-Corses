using MyFirstWebApp.Core.Enums;
using MyFirstWebApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWebApp.Core.DTOs
{
    public class CarModel : ICarModel
    {
        public BodyStyle BodyStyle { get; set; }
        public Condition Condition { get; set; }
        public string ImageUrl { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
    }
}
