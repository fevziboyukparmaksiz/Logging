﻿using Logging.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Logging.Controllers
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
            _logger.LogDebug("Index sayfasına girildi");
            _logger.LogInformation("Index sayfasına girildi");
            _logger.LogWarning("Index sayfasına girildi");
            _logger.LogError("Index sayfasına girildi");
            _logger.LogCritical("Index sayfasına girildi");

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