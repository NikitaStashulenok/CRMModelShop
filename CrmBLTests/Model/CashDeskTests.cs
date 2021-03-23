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
    public class CashDeskTests
    {
        [TestMethod()]
        public void CashDeskTest()
        {
            //arrange

            var seller = new Seller()
            {
                SellerId = 1,
                Name = "seller1"
            };
            var customer1 = new Customer()
            {
                CustomerId = 1,
                Name = "customer #1"
            };
            var customer2 = new Customer()
            {
                CustomerId = 1,
                Name = "customer #2"
            };
            var product1 = new Product()
            {
                ProductId = 1,
                Name = "Bread",
                Price = 20.00m,
                Count = 10,
            };
            var product2 = new Product()
            {
                ProductId = 2,
                Name = "Tomato",
                Price = 10.00m,
                Count = 5,
            };
            var cart1 = new Cart(customer1);
            cart1.Add(product1);
            cart1.Add(product1);
            cart1.Add(product2);

            var cart2 = new Cart(customer2);
            cart2.Add(product1);
            cart2.Add(product2);
            cart2.Add(product2);

            var cashDesk = new CashDesk(1, seller);
            cashDesk.MaxQueueLength = 10;
            cashDesk.Enqueue(cart1);
            cashDesk.Enqueue(cart2);

            var expectedCart1Result = 50.00m;
            var expectedCart2Result = 40.00m;

            //act

            var actualCart1Result = cashDesk.Dequeue();
            var actualCart2Result = cashDesk.Dequeue();

            //assert

            Assert.AreEqual(expectedCart1Result, actualCart1Result);
            Assert.AreEqual(expectedCart2Result, actualCart2Result);
            Assert.AreEqual(7, product1.Count);
            Assert.AreEqual(2, product2.Count);
        }

    }
}