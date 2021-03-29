
namespace CrmUI
{
    partial class ModelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownCashDeskSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCustomersSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCashDeskSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomersSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownCashDeskSpeed
            // 
            this.numericUpDownCashDeskSpeed.Location = new System.Drawing.Point(649, 27);
            this.numericUpDownCashDeskSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCashDeskSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCashDeskSpeed.Name = "numericUpDownCashDeskSpeed";
            this.numericUpDownCashDeskSpeed.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownCashDeskSpeed.TabIndex = 1;
            this.numericUpDownCashDeskSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCashDeskSpeed.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDownCustomersSpeed
            // 
            this.numericUpDownCustomersSpeed.Location = new System.Drawing.Point(649, 73);
            this.numericUpDownCustomersSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCustomersSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCustomersSpeed.Name = "numericUpDownCustomersSpeed";
            this.numericUpDownCustomersSpeed.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownCustomersSpeed.TabIndex = 2;
            this.numericUpDownCustomersSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCustomersSpeed.ValueChanged += new System.EventHandler(this.numericUpDownCustomersSpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cash desk speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customers speed";
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownCustomersSpeed);
            this.Controls.Add(this.numericUpDownCashDeskSpeed);
            this.Controls.Add(this.button1);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelForm_FormClosing);
            this.Load += new System.EventHandler(this.ModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCashDeskSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomersSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownCashDeskSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomersSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}