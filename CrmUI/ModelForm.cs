using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class ModelForm : Form
    {
        ShopComputerModel model = new();
        public ModelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cashboxes = new List<CashBoxView>();

            for (int i = 0; i < model.СashDesks.Count; i++)
            {
                CashBoxView box = new CashBoxView(model.СashDesks[i], i, 20, 40 * i);
                cashboxes.Add(box);
                Controls.Add(box.CashDeskName);
                Controls.Add(box.Price);
                Controls.Add(box.QueueLength);
                Controls.Add(box.ExitCustomers);
            }

            model.Start();
        }

        private void ModelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.Stop();
        }

        private void ModelForm_Load(object sender, EventArgs e)
        {
            numericUpDownCashDeskSpeed.Value = model.CashDeskSpeed;
            numericUpDownCustomersSpeed.Value = model.CustomerSpeed;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            model.CashDeskSpeed = (int)numericUpDownCashDeskSpeed.Value;
        }

        private void numericUpDownCustomersSpeed_ValueChanged(object sender, EventArgs e)
        {
            model.CustomerSpeed = (int)numericUpDownCustomersSpeed.Value;
        }
    }
}
