using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class CrmContext : DbContext
    {
        public CrmContext() : base("CrmConnection") { }

        public DbSet<Check> Check { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
