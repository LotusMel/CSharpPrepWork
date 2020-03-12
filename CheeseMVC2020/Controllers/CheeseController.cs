using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC2020.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC2020.Controllers
{
    public class CheeseController : Controller
    {
        static private List<Cheese> Cheeses = new List<Cheese>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        //public IActionResult Remove()
        //{
        //    ViewBag.cheeses = Cheeses;
        //    return View();
        //}

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name, string describe)
        {
            Cheese newCheese = new Cheese
            {
                Description = describe,
                Name = name
            };

            // Add the new cheese to my existing cheeses
            Cheeses.Add(newCheese);

            return Redirect("/Cheese");
        }

        //[HttpPost]
        //[Route("/Cheese/Remove")]
        //public IActionResult RemoveCheese(string name)
        //{
            
        //    Cheeses.Remove(name);

        //    return Redirect("/Cheese");

        //}

        //public IActionResult Edit(int cheeseId)
        //{

        //}

        //[HttpPost]
        //public IActionResult Edit(int cheeseId, string name, string description)
        //{

        //}

    }
}
