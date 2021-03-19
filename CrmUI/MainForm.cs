using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL;
using CrmBL.Model;

namespace CrmUI
{
    public partial class MainForm : Form
    {
        CrmContext db;
        public MainForm()
        {
            InitializeComponent();
            db = new CrmContext();
        }

        private void Button_Product_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Product);
            catalogProduct.Show();
        }

        private void Button_Customer_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(db.Customer);
            catalogCustomer.Show();
        }

        private void Button_Seller_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Seller);
            catalogSeller.Show();
        }

        private void Button_Check_Click(object sender, EventArgs e)
        {
            var checkCustomer = new Catalog<Check>(db.Check);
            checkCustomer.Show();
        }

        private void button_Customer_Add_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Customer.Add(form.Customer);
                db.SaveChanges();
            }
        }
    }
}
