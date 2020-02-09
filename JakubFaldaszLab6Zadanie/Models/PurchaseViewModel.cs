using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace JakubFaldaszLab6Zadanie.Models
{
    public class PurchaseViewModel
    {
        /// <summary>
        /// Imię
        /// </summary>
        [DisplayName("Imię")]
        public string Name { get; set; }

        /// <summary>
        /// Nazwisko
        /// </summary>
        [DisplayName("Nazwisko")]
        public string LastName{ get; set; }

        /// <summary>
        /// Adres email
        /// </summary>
        [DisplayName("Adres email")]
        public string EmailAddress{ get; set; }

        /// <summary>
        /// Lista przechowująca kupione produkty
        /// </summary>
        public List<ElectronicDeviceViewModel> PurchasedItems { get; set; }

        /// <summary>
        /// Ilość przedmiotów w koszyku
        /// </summary>
        public int NumberOfElements { get; set; }

        /// <summary>
        /// Cena całkowita za zakupy
        /// </summary>
        public decimal TotalPrice { get; set; }


        /// <summary>
        /// Konstruktor klasy
        /// </summary>
        public PurchaseViewModel()
        {
            PurchasedItems = new List<ElectronicDeviceViewModel>();
            TotalPrice = 0;
        }

    }
}
