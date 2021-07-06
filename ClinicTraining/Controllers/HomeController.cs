using ClinicTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicTraining.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Name = "Anything";
            ViewBag.Customer = new Customer();
            TempData["Date"] = DateTime.Today;
            ViewData["Title"] = "Just Test";
            return View("Main");
        }
        [HttpPost]
        public string Section(int id, string title)
        {
            return $"You passed {id} and title {title}";
        }

        public IActionResult Main()
        {
            return View("Main");
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
