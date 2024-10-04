using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using WamiAgro.Models;

namespace WamiAgro.Controllers
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
            return View();
        }

        public IActionResult WhoWeAre()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult FarmManagement()
        {
            return View();
        }

        public IActionResult WhatWeDo()
        {
            return View();
        }

        public IActionResult Social()
        {
            return View();
        }

        public IActionResult WamiMarket()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        // Redirect all errors to the Index page
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return RedirectToAction("Index");
        }

        // Redirect 404 errors to the Index page
        [Route("404")]
        public IActionResult PageNotFound()
        {
            Response.StatusCode = 404;
            return RedirectToAction("Index");
        }
    }
}
