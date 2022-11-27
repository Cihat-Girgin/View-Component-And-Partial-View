﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Razor.Inroduction.ViewComponentsAndPartialView.Web.Models;
using System.Diagnostics;
using System.Linq;

namespace Razor.Inroduction.ViewComponentsAndPartialView.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DatabaseContext _databaseContext;
        public HomeController(ILogger<HomeController> logger,DatabaseContext databaseContext)
        {
            _logger = logger;
            _databaseContext = databaseContext;
        }

        public IActionResult Index()
        {
            return View(_databaseContext.MenuItems.ToList());
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