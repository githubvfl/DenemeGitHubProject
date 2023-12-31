﻿using DenemeGitHubProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DenemeGitHubProject.Controllers
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


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Privacy2()
        {
            return View();
        }

        public IActionResult Privacy3()
        {
            return View();
        }

        public IActionResult adsd()
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