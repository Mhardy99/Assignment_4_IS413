using Assignment_4_IS413.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_IS413.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult StyleStuff()
        {
            return View();
        }

        public IActionResult Index()
        {
            List<string> restList = new List<string>();
            foreach(Top5Restaurant r in Top5Restaurant.GetTop5Restaurants())
            {

                restList.Add($"#{r.RestaurantRank}: {r.RestaurantName}, Dish: {r.FavDish}, Address: {r.RestaurantAddress}, Phone: {r.RestaurantPhone}, Website: {r.RestaurantLink} ");
            }
            return View(restList);
        }

        public IActionResult RestaurantList()
        {
            return View(TempStorage.Listrestaurants);
        }
        [HttpGet]
        public IActionResult EnterRestaurant()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterRestaurant(RestaurantResponse restaurant)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurant(restaurant);
                Response.Redirect("RestaurantList");
            }
            return View();
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
