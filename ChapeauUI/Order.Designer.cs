namespace ChapeauUI
{
    partial class Order
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
            this.buttonTerug = new System.Windows.Forms.Button();
            this.buttonVoorgerecht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTerug
            // 
            this.buttonTerug.Location = new System.Drawing.Point(12, 12);
            this.buttonTerug.Name = "buttonTerug";
            this.buttonTerug.Size = new System.Drawing.Size(94, 38);
            this.buttonTerug.TabIndex = 0;
            this.buttonTerug.Text = "Terug";
            this.buttonTerug.UseVisualStyleBackColor = true;
            // 
            // buttonVoorgerecht
            // 
            this.buttonVoorgerecht.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVoorgerecht.Image = global::ChapeauUI.Properties.Resources.chunks_wreak_menu_gastronomy_39826;
            this.buttonVoorgerecht.Location = new System.Drawing.Point(12, 90);
            this.buttonVoorgerecht.Name = "buttonVoorgerecht";
            this.buttonVoorgerecht.Size = new System.Drawing.Size(498, 121);
            this.buttonVoorgerecht.TabIndex = 1;
            this.buttonVoorgerecht.Text = "Voorgerecht";
            this.buttonVoorgerecht.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVoorgerecht.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 640);
            this.Controls.Add(this.buttonVoorgerecht);
            this.Controls.Add(this.buttonTerug);
            this.Name = "Order";
            this.Text = "Order";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTerug;
        private System.Windows.Forms.Button buttonVoorgerecht;
    }
}