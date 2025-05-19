using MyFirstWebApp.Core.Enums;
using MyFirstWebApp.Infrastructure.Entities;

namespace MyFirstWebApp.Infrastructure
{
	public class DatabaseContext
	{
		private List<Car> database;

        public DatabaseContext()
        {
            database = new List<Car>()
            {
                new Car()
                {
                    Make ="BMW",
                    Model = "6-series gran coupe",
                    Condition = Condition.New,
                    BodyStyle = BodyStyle.Coupe,
                    DateAdded = DateTime.Now,
                    Id =1, 
                    ImageUrl = "assets/images/featured-cars/fc1.png",
                    Price = 89395m,
                    Year = 2017
				},new Car()
				{
					Make ="Porsche",
					Model = "718 Cayman",
					Condition = Condition.New,
					BodyStyle = BodyStyle.Coupe,
					DateAdded = DateTime.Now,
					Id =1,
					ImageUrl = "assets/images/featured-cars/fc5.png",
					Price = 48500m,
					Year = 2017
				},new Car()
				{
					Make ="Infiniti",
					Model = "Z5",
					Condition = Condition.New,
					BodyStyle = BodyStyle.Coupe,
					DateAdded = DateTime.Now,
					Id =1,
					ImageUrl = "assets/images/featured-cars/fc4.png",
					Price = 36850m,
					Year = 2017
				}

			};
        }


        public List<Car> Cars 
		{
			get => database;
		}
    }
}
