namespace ChapeauUI
{
    partial class PaymentMethod
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
            this.label1 = new System.Windows.Forms.Label();
            this.AnnulerenBtn = new System.Windows.Forms.Button();
            this.ContantBtn = new System.Windows.Forms.Button();
            this.PinBtn = new System.Windows.Forms.Button();
            this.CreditCardBtn = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPartialPayment = new System.Windows.Forms.TextBox();
            this.labelPartialPayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manier van Betalen:";
            // 
            // AnnulerenBtn
            // 
            this.AnnulerenBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnnulerenBtn.Location = new System.Drawing.Point(140, 182);
            this.AnnulerenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnnulerenBtn.Name = "AnnulerenBtn";
            this.AnnulerenBtn.Size = new System.Drawing.Size(82, 31);
            this.AnnulerenBtn.TabIndex = 1;
            this.AnnulerenBtn.Text = "Annuleren";
            this.AnnulerenBtn.UseVisualStyleBackColor = true;
            this.AnnulerenBtn.Click += new System.EventHandler(this.AnnulerenBtn_Click);
            // 
            // ContantBtn
            // 
            this.ContantBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContantBtn.Location = new System.Drawing.Point(37, 136);
            this.ContantBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContantBtn.Name = "ContantBtn";
            this.ContantBtn.Size = new System.Drawing.Size(82, 30);
            this.ContantBtn.TabIndex = 2;
            this.ContantBtn.Text = "Contant";
            this.ContantBtn.UseVisualStyleBackColor = true;
            this.ContantBtn.Click += new System.EventHandler(this.ContantBtn_Click);
            // 
            // PinBtn
            // 
            this.PinBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PinBtn.Location = new System.Drawing.Point(140, 136);
            this.PinBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PinBtn.Name = "PinBtn";
            this.PinBtn.Size = new System.Drawing.Size(82, 30);
            this.PinBtn.TabIndex = 3;
            this.PinBtn.Text = "Pin";
            this.PinBtn.UseVisualStyleBackColor = true;
            this.PinBtn.Click += new System.EventHandler(this.PinBtn_Click);
            // 
            // CreditCardBtn
            // 
            this.CreditCardBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreditCardBtn.Location = new System.Drawing.Point(242, 136);
            this.CreditCardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreditCardBtn.Name = "CreditCardBtn";
            this.CreditCardBtn.Size = new System.Drawing.Size(82, 30);
            this.CreditCardBtn.TabIndex = 4;
            this.CreditCardBtn.Text = "Creditcard";
            this.CreditCardBtn.UseVisualStyleBackColor = true;
            this.CreditCardBtn.Click += new System.EventHandler(this.CreditCardBtn_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(10, 44);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(97, 17);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Totaal bedrag: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Verschillende betaalmethodes?  Vul hier deelbedrag in:";
            // 
            // textBoxPartialPayment
            // 
            this.textBoxPartialPayment.Location = new System.Drawing.Point(12, 88);
            this.textBoxPartialPayment.Name = "textBoxPartialPayment";
            this.textBoxPartialPayment.Size = new System.Drawing.Size(100, 23);
            this.textBoxPartialPayment.TabIndex = 7;
            // 
            // labelPartialPayment
            // 
            this.labelPartialPayment.AutoSize = true;
            this.labelPartialPayment.Location = new System.Drawing.Point(119, 91);
            this.labelPartialPayment.Name = "labelPartialPayment";
            this.labelPartialPayment.Size = new System.Drawing.Size(0, 15);
            this.labelPartialPayment.TabIndex = 8;
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 232);
            this.Controls.Add(this.labelPartialPayment);
            this.Controls.Add(this.textBoxPartialPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.CreditCardBtn);
            this.Controls.Add(this.PinBtn);
            this.Controls.Add(this.ContantBtn);
            this.Controls.Add(this.AnnulerenBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PaymentMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentMethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnnulerenBtn;
        private System.Windows.Forms.Button ContantBtn;
        private System.Windows.Forms.Button PinBtn;
        private System.Windows.Forms.Button CreditCardBtn;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPartialPayment;
        private System.Windows.Forms.Label labelPartialPayment;
    }
}