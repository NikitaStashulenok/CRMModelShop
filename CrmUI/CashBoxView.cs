using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    class CashBoxView
    {
        CashDesk cashDesk;
        public Label CashDeskName { get; set; }
        public NumericUpDown Price { get; set; }
        public ProgressBar QueueLength { get; set; }
        public Label ExitCustomers { get; set; }
        public CashBoxView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;
            CashDeskName = new Label();
            Price = new NumericUpDown();
            QueueLength = new ProgressBar();
            ExitCustomers = new Label();
            // 
            // CashDeskName
            // 
            CashDeskName.AutoSize = true;
            CashDeskName.Location = new System.Drawing.Point(x, y);
            CashDeskName.Name = "label" + number.ToString();
            CashDeskName.Size = new System.Drawing.Size(38, 15);
            CashDeskName.TabIndex = number;
            CashDeskName.Text = cashDesk.ToString();
            // 
            // Price
            // 
            Price.Location = new System.Drawing.Point(x + 90, y);
            Price.Name = "numericUpDown" + number.ToString();
            Price.Size = new System.Drawing.Size(120, 23);
            Price.TabIndex = number + 1;
            Price.Maximum = 100000000000000000;
            Price.ReadOnly = true;
            // 
            // QueueLength
            // 
            QueueLength.Location = new System.Drawing.Point(x + 240, y);
            QueueLength.Maximum = 10;
            QueueLength.Name = "progressBar" + number;
            QueueLength.Size = new System.Drawing.Size(100, 23);
            QueueLength.TabIndex = number + 3;
            QueueLength.Value = 0;
            // 
            // ExitCustomers
            // 
            ExitCustomers.AutoSize = true;
            ExitCustomers.Location = new System.Drawing.Point(x + 500, y);
            ExitCustomers.Name = "label2-" + number.ToString();
            ExitCustomers.Size = new System.Drawing.Size(38, 15);
            ExitCustomers.TabIndex = number + 4;
            ExitCustomers.Text = "";


            cashDesk.CheckClosed += CashDesk_CheckClosed;
        }

        private void CashDesk_CheckClosed(object sender, Check e)
        {
            Price.Invoke((Action)delegate
            { 
                Price.Value += e.Price;
                QueueLength.Value = cashDesk.Count;
                ExitCustomers.Text = "Exit customers: " + cashDesk.ExitCustomer.ToString();
            });
        }
    }
}
