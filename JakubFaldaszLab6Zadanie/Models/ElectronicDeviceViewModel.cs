using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubFaldaszLab6Zadanie.Models
{
    public class ElectronicDeviceViewModel
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Producent telefonu
        /// </summary>
        public string Manufacturer{ get; set; }
        /// <summary>
        /// Model telefonu
        /// </summary>
        public string Model{ get; set; }
        /// <summary>
        /// Cena
        /// </summary>
        public decimal Price{ get; set; }
        /// <summary>
        /// Ścieżka do zdjęcia telefonu
        /// </summary>
        public string Photo{ get; set; }

        /// <summary>
        /// Konstruktor modelu
        /// </summary>
        public ElectronicDeviceViewModel(string manufacturer, string model, decimal price, string photo)
        {
            Manufacturer = manufacturer;
            Model = model;
            Price = price;
            Photo = photo;
        }
        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public ElectronicDeviceViewModel()
        {

        }
    }
}
