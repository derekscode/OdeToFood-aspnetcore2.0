using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Restaurant> list = new List<Restaurant>();

            list.Add(new Restaurant
            {
                Id = 5,
                Name = "Derek's Pizza Place"
            });

            list.Add(new Restaurant
            {
                Id = 17,
                Name = "Kim's Pizza Place"
            });



            var model = new Restaurant
            {
                Id = 17,
                Name = "Kim's Pizza Place"
            };

            return View(list);

        }
    }
}
