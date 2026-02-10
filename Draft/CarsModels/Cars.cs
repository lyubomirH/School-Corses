using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsModels
{
    public class Cars
    {
        private string brand;
        private int price;
        private int year;
        private string licencePlate;
        private bool isElectric;

        public Cars(string brand, int price, int year, string licencePlate, bool isElectric)
        {
            this.brand = brand;
            this.price = price;
            this.year = year;
            this.licencePlate = licencePlate;
            this.isElectric = isElectric;
        }
        public string Brand
        {
            get => brand;
            set => brand = value;
        }
        public int Price
        {
            get => price;
            set => price = value;
        }
        public int Year
        {
            get => year;
            set => year = value;
        }
        public string LicencePlate
        {
            get => licencePlate;
            set => licencePlate = value;
        }
        public bool IsElectric
        {
            get => isElectric;
            set => isElectric = value;
        }
    }
}
