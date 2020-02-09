using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JakubFaldaszLab6Zadanie.Models;
using Microsoft.AspNetCore.Mvc;

namespace JakubFaldaszLab6Zadanie.Controllers
{
    public class ConsolesController : Controller
    {

        //Konsole
        List<ElectronicDeviceViewModel> consoles;

        /// <summary>
        /// Konstruktor inicjalizujący konsole
        /// </summary>
        public ConsolesController()
        {
            consoles = new List<ElectronicDeviceViewModel>();
            consoles.Add(new ElectronicDeviceViewModel("Microsoft", "Xbox One X", 1699, "~/Content/Images/Consoles/xbox.png"));
            consoles.Add(new ElectronicDeviceViewModel("Sony", "PS4", 1599, "~/Content/Images/Consoles/ps4.png"));
            consoles.Add(new ElectronicDeviceViewModel("Nintendo", "Switch", 1199, "~/Content/Images/Consoles/switch.png"));
        }


        /// <summary>
        /// Widok początkowy, wyświetla wszystkie konsole
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(consoles);
        }

        /// <summary>
        /// Przekazanie 
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