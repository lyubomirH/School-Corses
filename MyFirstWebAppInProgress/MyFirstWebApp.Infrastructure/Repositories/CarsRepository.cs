using MyFirstWebApp.Core.DTOs;
using MyFirstWebApp.Core.Enums;
using MyFirstWebApp.Core.Interfaces;
using MyFirstWebApp.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWebApp.Infrastructure.Repositories
{
    public class CarsRepository : ICarsRepository<ICarModel>
    {
        private readonly DatabaseContext ctx;
        public CarsRepository()
        {
            ctx = new DatabaseContext();
        }
        public void AddCar(ICarModel car)
        {
            ctx.Cars.Add(MapModelToCar(car));
        }

        public IEnumerable<ICarModel> GetAllCars()
        {
            return ctx.Cars
                .Select(c => MapCarToModel(c));
        }

        public ICarModel GetById(int id)
        {
            int index = ctx.Cars.FindIndex(c => c.Id == id);
            if (index != -1)
            {
                return MapCarToModel(ctx.Cars[index]);
            }
            return null;
        }

        public void Remove(int id)
        {
            int index = ctx.Cars.FindIndex(c => c.Id == id);
            if (index != -1)
            {
                ctx.Cars.RemoveAt(index);
            }
        }

        private Car MapModelToCar(ICarModel model)
        {
            Car car = new Car()
            {
                Year = model.Year,
                BodyStyle = model.BodyStyle,
                Condition = model.Condition,
                ImageUrl = model.ImageUrl,
                Make = model.Make,
                Model = model.Model,
                Price = model.Price,
                DateAdded = DateTime.Now
            
            };
            return car;
        }

        private ICarModel MapCarToModel(Car car)
        {
            ICarModel model = new CarModel()
            {
                Year = car.Year,
                BodyStyle = car.BodyStyle,
                Condition = car.Condition,
                ImageUrl = car.ImageUrl,
                Make = car.Make,
                Model = car.Model,
                Price = car.Price
            };
            return model;
        }
    }
}
