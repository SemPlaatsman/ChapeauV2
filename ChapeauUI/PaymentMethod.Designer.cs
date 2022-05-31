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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manier van Betalen:";
            // 
            // AnnulerenBtn
            // 
            this.AnnulerenBtn.Location = new System.Drawing.Point(139, 90);
            this.AnnulerenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnnulerenBtn.Name = "AnnulerenBtn";
            this.AnnulerenBtn.Size = new System.Drawing.Size(82, 22);
            this.AnnulerenBtn.TabIndex = 1;
            this.AnnulerenBtn.Text = "Annuleren";
            this.AnnulerenBtn.UseVisualStyleBackColor = true;
            this.AnnulerenBtn.Click += new System.EventHandler(this.AnnulerenBtn_Click);
            // 
            // ContantBtn
            // 
            this.ContantBtn.Location = new System.Drawing.Point(36, 49);
            this.ContantBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContantBtn.Name = "ContantBtn";
            this.ContantBtn.Size = new System.Drawing.Size(82, 22);
            this.ContantBtn.TabIndex = 2;
            this.ContantBtn.Text = "Contant";
            this.ContantBtn.UseVisualStyleBackColor = true;
            this.ContantBtn.Click += new System.EventHandler(this.ContantBtn_Click);
            // 
            // PinBtn
            // 
            this.PinBtn.Location = new System.Drawing.Point(139, 49);
            this.PinBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PinBtn.Name = "PinBtn";
            this.PinBtn.Size = new System.Drawing.Size(82, 22);
            this.PinBtn.TabIndex = 3;
            this.PinBtn.Text = "Pin";
            this.PinBtn.UseVisualStyleBackColor = true;
            this.PinBtn.Click += new System.EventHandler(this.PinBtn_Click);
            // 
            // CreditCardBtn
            // 
            this.CreditCardBtn.Location = new System.Drawing.Point(241, 49);
            this.CreditCardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreditCardBtn.Name = "CreditCardBtn";
            this.CreditCardBtn.Size = new System.Drawing.Size(82, 22);
            this.CreditCardBtn.TabIndex = 4;
            this.CreditCardBtn.Text = "Creditcard";
            this.CreditCardBtn.UseVisualStyleBackColor = true;
            this.CreditCardBtn.Click += new System.EventHandler(this.CreditCardBtn_Click);
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 123);
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
    }
}