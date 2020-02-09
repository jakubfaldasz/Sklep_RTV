using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JakubFaldaszLab6Zadanie.Models;
using Microsoft.AspNetCore.Mvc;

namespace JakubFaldaszLab6Zadanie.Controllers
{
    public class TVController : Controller
    {

        //Telewizory
        List<ElectronicDeviceViewModel> tvs;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public TVController()
        {
            tvs = new List<ElectronicDeviceViewModel>();
            tvs.Add(new ElectronicDeviceViewModel("LG", "65\" OLED", 6299, "~/Content/Images/TV/lg.png"));
            tvs.Add(new ElectronicDeviceViewModel("Samsung", "60\" QLED", 8999, "~/Content/Images/TV/samsung.png"));
            tvs.Add(new ElectronicDeviceViewModel("Sony", "55\" OLED", 5420, "~/Content/Images/TV/sony.png"));
        }

        /// <summary>
        /// Widok początkowy
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(tvs);
        }

        /// <summary>
        /// Przekazanie produktu do kontrolera Cart
        /// </summary>
        /// <param name="itemToBuy"></param>
        /// <returns></returns>
        public IActionResult PassToCartController(ElectronicDeviceViewModel itemToBuy)
        {
            ViewBag.itemToBuy = itemToBuy;

            return View("../Cart/BuyNow");
        }
    }
}