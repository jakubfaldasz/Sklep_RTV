using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JakubFaldaszLab6Zadanie.Models;
using Microsoft.AspNetCore.Mvc;

namespace JakubFaldaszLab6Zadanie.Controllers
{
    public class CartController : Controller
    {
        //Koszyk sklepowy
        CartViewModel cart;

        /// <summary>
        /// Konstruktor klasy
        /// </summary>
        public CartController(CartViewModel cart)
        {
            this.cart = cart;
        }

        /// <summary>
        /// Widok początkowy (zawartość koszyka)
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(cart);
        }

        
        /// <summary>
        /// Przejście do zakupu
        /// </summary>
        /// <returns></returns>
        public IActionResult BuyNow()
        {
            return View();
        }

        /// <summary>
        /// Post request, wypełnienie formularza zakupu produktu
        /// </summary>
        /// <param name="boughtItem"></param>
        /// <param name="purchase"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult BuyNow(ElectronicDeviceViewModel boughtItem, PurchaseViewModel purchase)
        {
            purchase.TotalPrice += boughtItem.Price;

            ViewBag.Purchase = purchase;
            return View("ConfirmPurchase");
        }

        /// <summary>
        /// Zapłata za zakupy z koszyka
        /// </summary>
        /// <returns></returns>
        public IActionResult CheckoutFromCart()
        {
            ViewBag.Cart = cart;
            return View();
        }

        /// <summary>
        /// Potwierdzenie zapłaty za zakupy z koszyka
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CheckoutFromCart(PurchaseViewModel purchase)
        {
            purchase.TotalPrice = cart.TotalPrice;
            ViewBag.Purchase = purchase;
            return View("ConfirmPurchase");
        }


        /// <summary>
        /// Dodanie do koszyka produktu
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public IActionResult AddToCart(ElectronicDeviceViewModel item)
        {
            cart.AddItemToCart(item);
            return View("Index", cart);
        }


        /// <summary>
        /// Usuwanie z koszyka produktu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult DeleteFromCart(int id)
        {
            cart.DeleteFromCartById(id);
            return View("Index", cart);
        } 

    }
}