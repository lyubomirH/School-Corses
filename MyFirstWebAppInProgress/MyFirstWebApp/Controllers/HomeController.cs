using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Core.DTOs;
using MyFirstWebApp.Core.Interfaces;
using MyFirstWebApp.Models;
using System.Diagnostics;

namespace MyFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ICarsRepository<ICarModel> repo;

		public HomeController(ICarsRepository<ICarModel> _repo)
        {
            repo = _repo;
        }

        public IActionResult Index()
        {
            var cars = repo.GetAllCars();
            return View(cars);
        }
 
        [HttpPost]
        public IActionResult Add(CarModel car)
        {
            if (ModelState.IsValid == false)
            {
                return View("Error", new ErrorViewModel() { RequestId = "0" });
            }
            repo.AddCar(car);
            return RedirectToAction(nameof(Index));
        }
 
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
