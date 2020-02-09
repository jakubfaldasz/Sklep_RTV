using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JakubFaldaszLab6Zadanie.Models;
using Microsoft.AspNetCore.Mvc;

namespace JakubFaldaszLab6Zadanie.Controllers
{
    public class CellPhonesController : Controller
    {
        // Telefony
        List<ElectronicDeviceViewModel> phones;

        /// <summary>
        /// Konstruktor inicjalizujący telefony
        /// </summary>
        public CellPhonesController()
        {
            phones = new List<ElectronicDeviceViewModel>();
            phones.Add(new ElectronicDeviceViewModel("Apple", "iPhone 11 Pro", 4299, "~/Content/Images/Phones/iphone.png"));
            phones.Add(new ElectronicDeviceViewModel("Samsung", "Galaxy S10", 3999, "~/Content/Images/Phones/samsung.png"));
            phones.Add(new ElectronicDeviceViewModel("Huawei", "P30 Pro", 3120, "~/Content/Images/Phones/huawei.png"));
            phones.Add(new ElectronicDeviceViewModel("Xiaomi", "Mi9", 1350, "~/Content/Images/Phones/xiaomi.png"));
        }

        /// <summary>
        /// Widok początkowy kontrolera, wyświetla wszystkie telefony
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(phones);
        }

        /// <summary>
        /// Przekazanie wybranego produktu do kontrolera Cart
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