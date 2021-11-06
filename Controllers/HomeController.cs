using DotNet5OctBatch_2021.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet5OctBatch_2021.Controllers
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
            Users oUser1 = new Users();
            oUser1.Id = 1;
            oUser1.Name = "ABC";
            oUser1.Password = "TEST";
            ViewBag.User1 = oUser1;

            Users oUser2 = new Users();
            oUser2.Id = 2;
            oUser2.Name = "XYZ";
            oUser2.Password = "123";

            ViewBag.OUser2 = oUser2;
            return View();
        }

        public IActionResult MyContact()
        {
            ViewBag.Name = "ASP Dot Net";
            return View();
        }
        public IActionResult MyFirstPage()
        {
            return View();
        }
    }
}
