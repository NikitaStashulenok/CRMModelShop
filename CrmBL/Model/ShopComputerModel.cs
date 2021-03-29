using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class ShopComputerModel
    {
        Random rnd = new();
        Generator Generator = new Generator();
        bool isWorking = false;
        public List<CashDesk> СashDesks { get; set; } = new();
        public List<Check> Checks { get; set; } = new();
        public List<Cart> Carts { get; set; } = new();
        public List<Sell> Sells { get; set; } = new();
        public Queue<Seller> Sellers { get; set; } = new();

        public ShopComputerModel()
        {
            var sellers = Generator.GetNewSellers(20);
            Generator.GetNewProducts(1000);
            Generator.GetNewCustomers(100);

            foreach (var seller in sellers)
            {
                Sellers.Enqueue(seller);
            }

            for (int i = 0; i < 3; i++)
            {
                СashDesks.Add(new CashDesk(СashDesks.Count, Sellers.Dequeue()));
            }
        }

        public void Start()
        {
            isWorking = true;
            Task.Run(() => CreateCarts(10, 1000));

            var cashDeskTasks = СashDesks.Select(c => new Task(() => CashDeskWork(c, 1000)));
            foreach (var task in cashDeskTasks)
            {
                task.Start();
            }
        }

        public void Stop()
        {
            isWorking = false;
        }

        private void CashDeskWork(CashDesk cashDesk, int sleep)
        {
            while (isWorking)
            {
                if (cashDesk.Count > 0)
                {
                    cashDesk.Dequeue();
                    Thread.Sleep(sleep);
                }
            }
        }

        private void CreateCarts(int customreCounts, int sleep)
        {
            while (isWorking)
            {
                var customers = Generator.GetNewCustomers(customreCounts);

                foreach (Customer customer in customers)
                {
                    var cart = new Cart(customer);
                    foreach (var product in Generator.GetRandomProducts(10, 30))
                    {
                        cart.Add(product);
                    }

                    var cashDesk = СashDesks[rnd.Next(СashDesks.Count)];
                    cashDesk.Enqueue(cart);
                }

                Thread.Sleep(sleep);
            }
        }
    }
}
