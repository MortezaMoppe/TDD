using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using uppgift2_par.Services;
using static uppgift2_par.Services.ShoppingCart;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void When_Get_Item()
        {
            var cart = new ShoppingCart();
            cart.AddProduct(5, "Chips", 1, 20);
            cart.GetItem(5);
            Assert.IsNotNull(cart.GetItem(5));
            Assert.AreEqual("Chips", cart.GetItem(5).Text);
            Console.WriteLine(cart.GetItem(5).Text);
        }

        [TestMethod]
        public void Get_Unique_Products()
        {
            var cart = new ShoppingCart();
            cart.AddProduct(5, "Chips", 1, 20);
            cart.AddProduct(1, "Cola", 2, 12);
            cart.AddProduct(2, "pepsi", 5, 2);

            Assert.AreEqual(cart.GetUniqueProductsCount(), 3);
        }

        [TestMethod]
        public void When_remove_item_calculate_quantity()
        {
            var cart = new ShoppingCart();
            cart.AddProduct(1, "Cola", 2, 12);

            cart.RemoveProduct(1,2);

            var result = cart.GetCountForProduct(1);

            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void When_add_product()
        {

            var product = new ShoppingCart();
            
            //int id, string text, int antal, decimal perPrice
            product.AddProduct(2,"pepsi",5, 2);

            Assert.AreEqual("pepsi", product.GetItem(2).Text);
            Console.WriteLine(product.GetItem(2).Text);
        }

        [TestMethod]
        public void getcountforproduct()
        {
            var product = new ShoppingCart();
            product.GetCountForProduct(1);
            product.AddProduct(1, "Godis", 5, 10);
            var antal = product.GetItem(1);

            if (antal == null)
            {
                Assert.AreEqual(product.GetCountForProduct(1), 0);
            }
            else
            {
                Assert.AreEqual(product.GetCountForProduct(1), product.GetItem(1).Antal);
            }

            Console.WriteLine(product.GetCountForProduct(1));
        }
    }

}