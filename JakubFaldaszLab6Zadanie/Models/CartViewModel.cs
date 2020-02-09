using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubFaldaszLab6Zadanie.Models
{
    public class CartViewModel
    {
        /// <summary>
        /// Lista przechowująca elementy w koszyku
        /// </summary>
        public List<ElectronicDeviceViewModel> CartItems { get; set; }
        /// <summary>
        /// Ilość przedmiotów w koszyku
        /// </summary>
        public int NumberOfElements{ get; set; }
        /// <summary>
        /// Cena całkowita za zakupy
        /// </summary>
        public decimal TotalPrice{ get; set; }

        /// <summary>
        /// Konstruktor klasy
        /// </summary>
        public CartViewModel()
        {
            CartItems = new List<ElectronicDeviceViewModel>();
            NumberOfElements = 0;
            TotalPrice = 0;
        }

        /// <summary>
        /// Dodanie elementu do koszyka i zwiększenie ilości przedmiotów oraz ceny
        /// </summary>
        /// <param name="item"></param>
        public void AddItemToCart(ElectronicDeviceViewModel item)
        {
            CartItems.Add(item);
            NumberOfElements++;
            TotalPrice += item.Price;
        }
        
        /// <summary>
        /// Usunięcie elementu z koszyka na podstawie nr id
        /// </summary>
        /// <param name="id"></param>
        public bool DeleteFromCartById(int id)
        {
            ElectronicDeviceViewModel temp = CartItems.Find(x => x.ID == id);
            if (temp is null)
                return false;
            
            TotalPrice -= temp.Price;
            NumberOfElements--;
            CartItems.Remove(temp);
            return true;
        }

        /// <summary>
        /// Usunięcie elementu z koszyka na podstawie przekazanego obiektu
        /// </summary>
        /// <param name="item"></param>
        public void DeleteFromCart(ElectronicDeviceViewModel item)
        {
            CartItems.Remove(item);
            TotalPrice -= item.Price;
            NumberOfElements--;
        }
    }
}
