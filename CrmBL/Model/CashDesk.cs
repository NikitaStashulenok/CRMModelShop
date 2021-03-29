
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class CashDesk
    {
        CrmContext db = new();
        public Seller Seller { get; set; }
        public Queue<Cart> Queue { get; set; }
        public int Number { get; set; }
        public int ExitCustomer { get; set; }
        public int MaxQueueLength { get; set; }
        public bool IsModel { get; set; }
        public int Count => Queue.Count;
        public event EventHandler<Check> CheckClosed;

        public CashDesk(int number, Seller seller)
        {
            Number = number;
            Seller = seller;
            Queue = new Queue<Cart>();
            IsModel = true;
            MaxQueueLength = 10;
        }
        
        public void Enqueue(Cart cart)
        {
            if (Queue.Count <= MaxQueueLength)
            {
                Queue.Enqueue(cart);
            }
            else
            {
                ExitCustomer++;
            }
        }

        public decimal Dequeue()
        {
            decimal sum = 0;
            if (Queue.Count == 0)
            {
                return 0;
            }
            var cart = Queue.Dequeue();

            if (cart != null)
            {
                var check = new Check()
                {
                    SellerId = Seller.SellerId,
                    Seller = Seller,
                    CustomerId = cart.Customer.CustomerId,
                    Customer = cart.Customer,
                    Created = DateTime.UtcNow
                };
                
                if(!IsModel)
                {
                    db.Check.Add(check);
                    db.SaveChanges();
                }
                else
                {
                    check.CheckId = 0;
                }

                var sells = new List<Sell>();
                foreach (Product prod in cart)
                {
                    if (prod.Count > 0)
                    {
                        var sell = new Sell()
                        {
                            ProductId = prod.ProductId,
                            Product = prod,
                            CheckId = check.CheckId,
                            Check = check
                        };
                        sells.Add(sell);

                        if (!IsModel)
                        {
                            db.Sells.Add(sell);
                        }

                        sum += prod.Price;
                        prod.Count--;
                    }
                }

                check.Price = sum;

                if (!IsModel)
                {
                    db.SaveChanges();
                }

                CheckClosed?.Invoke(this, check);
            }

            return sum;
        }

        public override string ToString()
        {
            return $"Cash Desk #{Number}";
        }
    }
}
