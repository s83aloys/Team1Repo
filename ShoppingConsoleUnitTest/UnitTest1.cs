using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingConsole;
using System.Collections.Generic;

namespace ShoppingConsoleUnitTest
{
    [TestClass]
    public class UnitTest1
    {
               
        [TestInitialize]
        public void Initialization()
        {
            Console.Write("Initialization completed!");
        }

        [TestMethod]
        public void TestNoDiscountIfBuyingOneItem()
        {
         

            double result = Program.ShoppingCart(new List<string>{"1"});

            Assert.AreEqual(4.0, result);
        }
    
        [TestCleanup]
        public void CleanUp()
        {
            Console.Write("Clean up completed!");
        }
    }
}
