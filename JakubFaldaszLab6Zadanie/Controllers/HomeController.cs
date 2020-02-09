using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JakubFaldaszLab6Zadanie.Models;

namespace JakubFaldaszLab6Zadanie.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        /// <summary>
        /// Widok początkowy
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
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
