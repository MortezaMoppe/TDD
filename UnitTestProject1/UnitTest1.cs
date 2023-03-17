using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Uppgift2.Services;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly ShoppingCart sut;
       
        [TestMethod]
        public void When_remove_item_result()
        {

            var parameter = "9";
            var result = GetCountForProduct(parameter);

        }

      
    }
}