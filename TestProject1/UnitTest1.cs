using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using uppgift2_par.Services;
using static uppgift2_par.Services.ShoppingCart;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
       

        [TestMethod]
        public void When_remove_item_calculate_quantity()
        {
            var cart = new ShoppingCart();
            var itemId = 9;
            var itemQ = 5;
            cart.AddProduct(1, "Cola", 2, 12);

            cart.RemoveProduct(1,2);

            var result = cart.GetCountForProduct(1);

            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void When_add_product()
        {

            var product = new ShoppingCart();
            product.GetCountForProduct(1);
            
            //int id, string text, int antal, decimal perPrice
            product.AddProduct(2,"pepsi",5, 2);


        }

        //    public int GetCountForProduct(int prodid)
        //{
        //  var item = _items.FirstOrDefault(r => r.ProductId == prodid);
        // if (item == null) return 0;
        // return item.Antal;
        // }


        [TestMethod]
        
       




}

}