using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab2.dto;

namespace Lab2.Services
{
    class Servprd
    {
        public static void CreateNew(IWebElement productName, IWebElement category, IWebElement supplier, IWebElement unitPrice, IWebElement quantityPerUnit, IWebElement unitsInStock, IWebElement unitsOnOrder, IWebElement reorderLevel)
        {
            newProduct product = new newProduct();

            productName.SendKeys(product.productName);
            category.SendKeys(product.category);
            supplier.SendKeys(product.supplier);
            unitPrice.SendKeys(product.unitPrice);
            quantityPerUnit.SendKeys(product.quantityPerUnit);
            unitsInStock.SendKeys(product.unitsInStock);
            unitsOnOrder.SendKeys(product.unitsOnOrder);
            reorderLevel.SendKeys(product.reorderLevel);
        }
    }
}
