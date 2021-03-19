
namespace CrmUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Product = new System.Windows.Forms.Button();
            this.button_Customer = new System.Windows.Forms.Button();
            this.button_Seller = new System.Windows.Forms.Button();
            this.button_Check = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_Customer_Add = new System.Windows.Forms.Button();
            this.button_Seller_Add = new System.Windows.Forms.Button();
            this.button_Product_Add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Product
            // 
            this.button_Product.Location = new System.Drawing.Point(18, 14);
            this.button_Product.Name = "button_Product";
            this.button_Product.Size = new System.Drawing.Size(75, 23);
            this.button_Product.TabIndex = 0;
            this.button_Product.Text = "Product";
            this.button_Product.UseVisualStyleBackColor = true;
            this.button_Product.Click += new System.EventHandler(this.Button_Product_Click);
            // 
            // button_Customer
            // 
            this.button_Customer.Location = new System.Drawing.Point(18, 14);
            this.button_Customer.Name = "button_Customer";
            this.button_Customer.Size = new System.Drawing.Size(75, 23);
            this.button_Customer.TabIndex = 1;
            this.button_Customer.Text = "Customer";
            this.button_Customer.UseVisualStyleBackColor = true;
            this.button_Customer.Click += new System.EventHandler(this.Button_Customer_Click);
            // 
            // button_Seller
            // 
            this.button_Seller.Location = new System.Drawing.Point(18, 14);
            this.button_Seller.Name = "button_Seller";
            this.button_Seller.Size = new System.Drawing.Size(75, 23);
            this.button_Seller.TabIndex = 2;
            this.button_Seller.Text = "Seller";
            this.button_Seller.UseVisualStyleBackColor = true;
            this.button_Seller.Click += new System.EventHandler(this.Button_Seller_Click);
            // 
            // button_Check
            // 
            this.button_Check.Location = new System.Drawing.Point(18, 38);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(75, 23);
            this.button_Check.TabIndex = 3;
            this.button_Check.Text = "Check";
            this.button_Check.UseVisualStyleBackColor = true;
            this.button_Check.Click += new System.EventHandler(this.Button_Check_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Product_Add);
            this.panel1.Controls.Add(this.button_Product);
            this.panel1.Location = new System.Drawing.Point(106, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 100);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Customer_Add);
            this.panel2.Controls.Add(this.button_Customer);
            this.panel2.Location = new System.Drawing.Point(106, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 100);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_Seller_Add);
            this.panel3.Controls.Add(this.button_Seller);
            this.panel3.Location = new System.Drawing.Point(670, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 100);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_Check);
            this.panel4.Location = new System.Drawing.Point(670, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 100);
            this.panel4.TabIndex = 7;
            // 
            // button_Customer_Add
            // 
            this.button_Customer_Add.Location = new System.Drawing.Point(18, 64);
            this.button_Customer_Add.Name = "button_Customer_Add";
            this.button_Customer_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Customer_Add.TabIndex = 8;
            this.button_Customer_Add.Text = "Add";
            this.button_Customer_Add.UseVisualStyleBackColor = true;
            this.button_Customer_Add.Click += new System.EventHandler(this.button_Customer_Add_Click);
            // 
            // button_Seller_Add
            // 
            this.button_Seller_Add.Location = new System.Drawing.Point(18, 64);
            this.button_Seller_Add.Name = "button_Seller_Add";
            this.button_Seller_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Seller_Add.TabIndex = 3;
            this.button_Seller_Add.Text = "Add\r\n";
            this.button_Seller_Add.UseVisualStyleBackColor = true;
            // 
            // button_Product_Add
            // 
            this.button_Product_Add.Location = new System.Drawing.Point(18, 64);
            this.button_Product_Add.Name = "button_Product_Add";
            this.button_Product_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Product_Add.TabIndex = 1;
            this.button_Product_Add.Text = "Add";
            this.button_Product_Add.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(945, 522);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Product;
        private System.Windows.Forms.Button button_Customer;
        private System.Windows.Forms.Button button_Seller;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Product_Add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Customer_Add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Seller_Add;
        private System.Windows.Forms.Panel panel4;
    }
}

