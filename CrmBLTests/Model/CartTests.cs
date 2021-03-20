using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            //arrange
            var customer = new Customer()
            {
                CustomerId = 1,
                Name = "Nikita"
            };
            var product1 = new Product()
            {
                ProductId = 1,
                Name = "Bread",
                Price = 15.52m,
                Count = 1,
            };
            var product2 = new Product()
            {
                ProductId = 2,
                Name = "Tomato",
                Price = 10.00m,
                Count = 1,
            };
            var cart = new Cart(customer);
            var expectedResult = new List<Product>()
            {
                product1, product1, product2
            };

            //act
            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product2);

            var cartResult = cart.GetAll();
            //assert
            Assert.AreEqual(expectedResult.Count, cartResult.Count);
            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], cartResult[i]);
            }
        }
    }

 
    
}