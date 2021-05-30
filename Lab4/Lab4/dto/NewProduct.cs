using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.dto
{
    class newProduct
    {
        public string productName { get; set; }
        public string category { get; set; }
        public string supplier { get; set; }
        public string unitPrice { get; set; }
        public string quantityPerUnit { get; set; }
        public string unitsInStock { get; set; }
        public string unitsOnOrder { get; set; }
        public string reorderLevel { get; set; }
        public string discontinued { get; set; }

        public newProduct()
        {
            productName = "Beef  steak";
            category = "Meat/Poultry";
            supplier = "Tokyo Traders";
            unitPrice = "30";
            quantityPerUnit = "20 - 1 kg tins";
            unitsInStock = "13";
            unitsOnOrder = "40";
            reorderLevel = "10";
        }


    }
}
