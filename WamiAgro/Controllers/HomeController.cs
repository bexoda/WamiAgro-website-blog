using Microsoft.AspNetCore.Mvc;
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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("404")]
        public IActionResult PageNotFound()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}
