using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingConsoleUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private Discounts d;

        [TestInitialize]
        public void Initialization()
        {
            d = new Discounts();
            Console.Write("Initialization completed!");
        }

        [TestMethod]
        public void TestNoDiscountIfBuyingOneItem()
        {
            Product[] product = new Product[1];
            product[0] = new Product();
            product[0].sku = "1001";
            product[0].price = 120.0;

            double result = d.GetDiscounts(product);

            Assert.AreEqual(120.0, result);
        }

        [TestMethod]
        public void TestDiscountIfBuyingTwoItemsOfSameSKU()
        {
            Product[] product = new Product[2];
            product[0] = new Product();
            product[0].sku = "1001";
            product[0].price = 120.0;
            product[1] = new Product();
            product[1].sku = "1001";
            product[1].price = 100.0;

            double result = d.GetDiscounts(product);

            Assert.AreEqual(190.0, result);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Console.Write("Clean up completed!");
        }
    }
}
