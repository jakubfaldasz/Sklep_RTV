using JakubFaldaszLab6Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JakubFaldaszLab6Zadanie.Tests
{
    public class CartViewModelShould
    {



        [Fact]
        public void IncrementNumberOfElementsAfterAddingItem()
        {
            CartViewModel cut = new CartViewModel();
            ElectronicDeviceViewModel item = new ElectronicDeviceViewModel();
            int numberOfElementsBeforeAdding = cut.NumberOfElements;
            cut.AddItemToCart(item);
            int numberOfElementsAfterAdding = cut.NumberOfElements;
            Assert.Equal(numberOfElementsAfterAdding, numberOfElementsBeforeAdding + 1);
        }

        [Fact]
        public void CalculateCorrectTotalPriceAfterAddingTwoElements()
        {
            CartViewModel cut = new CartViewModel();
            ElectronicDeviceViewModel item = new ElectronicDeviceViewModel();
            item.ID = 1;
            item.Manufacturer = "Lenovo";
            item.Photo = "photo.png";
            item.Price = 2500;
            ElectronicDeviceViewModel item2 = new ElectronicDeviceViewModel();
            item2.ID = 2;
            item2.Manufacturer = "Acer";
            item2.Photo = "photo2.png";
            item2.Price = 5600;

            cut.AddItemToCart(item);
            cut.AddItemToCart(item2);

            Assert.Equal(5600 + 2500,cut.TotalPrice);
        }

        [Fact]
        public void NotDeleteItemByIdFromCartIfNotPresent()
        {
            CartViewModel cut = new CartViewModel();

            bool wasDeleted = cut.DeleteFromCartById(1);

            Assert.False(wasDeleted);
        }

        [Fact]
        public void DeleteItemByIdFromCartIfPresent()
        {
            CartViewModel cut = new CartViewModel();
            ElectronicDeviceViewModel item = new ElectronicDeviceViewModel();
            item.ID = 1;
            item.Manufacturer = "Lenovo";
            item.Photo = "photo.png";
            item.Price = 2500;

            cut.AddItemToCart(item);
            bool wasDeleted = cut.DeleteFromCartById(1);

            Assert.True(wasDeleted);
        }


    }
}
