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
            this.buttonHoofdgerecht = new System.Windows.Forms.Button();
            this.buttonNagerecht = new System.Windows.Forms.Button();
            this.buttonDrankjes = new System.Windows.Forms.Button();
            this.buttonBestel = new System.Windows.Forms.Button();
            this.panelBestellen = new System.Windows.Forms.Panel();
            this.listViewGerechten = new System.Windows.Forms.ListView();
            this.labelTypeGerecht = new System.Windows.Forms.Label();
            this.labelZoeken = new System.Windows.Forms.Label();
            this.textBoxZoeken = new System.Windows.Forms.TextBox();
            this.buttonTerugBestelling = new System.Windows.Forms.Button();
            this.buttonToevoegen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelBestellen.SuspendLayout();
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
            this.buttonTerug.Click += new System.EventHandler(this.buttonTerug_Click);
            // 
            // buttonVoorgerecht
            // 
            this.buttonVoorgerecht.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVoorgerecht.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonVoorgerecht.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVoorgerecht.Location = new System.Drawing.Point(12, 90);
            this.buttonVoorgerecht.Name = "buttonVoorgerecht";
            this.buttonVoorgerecht.Size = new System.Drawing.Size(498, 111);
            this.buttonVoorgerecht.TabIndex = 1;
            this.buttonVoorgerecht.Text = "Voorgerecht";
            this.buttonVoorgerecht.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVoorgerecht.UseVisualStyleBackColor = true;
            this.buttonVoorgerecht.Click += new System.EventHandler(this.buttonVoorgerecht_Click);
            // 
            // buttonHoofdgerecht
            // 
            this.buttonHoofdgerecht.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHoofdgerecht.Location = new System.Drawing.Point(12, 207);
            this.buttonHoofdgerecht.Name = "buttonHoofdgerecht";
            this.buttonHoofdgerecht.Size = new System.Drawing.Size(498, 111);
            this.buttonHoofdgerecht.TabIndex = 2;
            this.buttonHoofdgerecht.Text = "Hoofdgerecht";
            this.buttonHoofdgerecht.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHoofdgerecht.UseVisualStyleBackColor = true;
            this.buttonHoofdgerecht.Click += new System.EventHandler(this.buttonHoofdgerecht_Click);
            // 
            // buttonNagerecht
            // 
            this.buttonNagerecht.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNagerecht.Location = new System.Drawing.Point(12, 324);
            this.buttonNagerecht.Name = "buttonNagerecht";
            this.buttonNagerecht.Size = new System.Drawing.Size(498, 111);
            this.buttonNagerecht.TabIndex = 3;
            this.buttonNagerecht.Text = "Nagerecht";
            this.buttonNagerecht.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNagerecht.UseVisualStyleBackColor = true;
            this.buttonNagerecht.Click += new System.EventHandler(this.buttonNagerecht_Click);
            // 
            // buttonDrankjes
            // 
            this.buttonDrankjes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDrankjes.Location = new System.Drawing.Point(12, 441);
            this.buttonDrankjes.Name = "buttonDrankjes";
            this.buttonDrankjes.Size = new System.Drawing.Size(498, 111);
            this.buttonDrankjes.TabIndex = 4;
            this.buttonDrankjes.Text = "Drankjes";
            this.buttonDrankjes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDrankjes.UseMnemonic = false;
            this.buttonDrankjes.UseVisualStyleBackColor = true;
            this.buttonDrankjes.Click += new System.EventHandler(this.buttonDrankjes_Click);
            // 
            // buttonBestel
            // 
            this.buttonBestel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBestel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBestel.Location = new System.Drawing.Point(0, 569);
            this.buttonBestel.Name = "buttonBestel";
            this.buttonBestel.Size = new System.Drawing.Size(522, 71);
            this.buttonBestel.TabIndex = 5;
            this.buttonBestel.Text = "Bestel";
            this.buttonBestel.UseVisualStyleBackColor = true;
            // 
            // panelBestellen
            // 
            this.panelBestellen.Controls.Add(this.listViewGerechten);
            this.panelBestellen.Controls.Add(this.labelTypeGerecht);
            this.panelBestellen.Controls.Add(this.labelZoeken);
            this.panelBestellen.Controls.Add(this.textBoxZoeken);
            this.panelBestellen.Controls.Add(this.buttonTerugBestelling);
            this.panelBestellen.Controls.Add(this.buttonToevoegen);
            this.panelBestellen.Controls.Add(this.textBox1);
            this.panelBestellen.Location = new System.Drawing.Point(0, -1);
            this.panelBestellen.Name = "panelBestellen";
            this.panelBestellen.Size = new System.Drawing.Size(522, 641);
            this.panelBestellen.TabIndex = 6;
            // 
            // listViewGerechten
            // 
            this.listViewGerechten.HideSelection = false;
            this.listViewGerechten.Location = new System.Drawing.Point(12, 121);
            this.listViewGerechten.Name = "listViewGerechten";
            this.listViewGerechten.Size = new System.Drawing.Size(497, 315);
            this.listViewGerechten.TabIndex = 7;
            this.listViewGerechten.UseCompatibleStateImageBehavior = false;
            // 
            // labelTypeGerecht
            // 
            this.labelTypeGerecht.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTypeGerecht.AutoSize = true;
            this.labelTypeGerecht.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTypeGerecht.Location = new System.Drawing.Point(192, 17);
            this.labelTypeGerecht.Name = "labelTypeGerecht";
            this.labelTypeGerecht.Size = new System.Drawing.Size(147, 26);
            this.labelTypeGerecht.TabIndex = 6;
            this.labelTypeGerecht.Text = "Voorgerechten";
            // 
            // labelZoeken
            // 
            this.labelZoeken.AutoSize = true;
            this.labelZoeken.Location = new System.Drawing.Point(14, 61);
            this.labelZoeken.Name = "labelZoeken";
            this.labelZoeken.Size = new System.Drawing.Size(49, 15);
            this.labelZoeken.TabIndex = 5;
            this.labelZoeken.Text = "Zoeken:";
            // 
            // textBoxZoeken
            // 
            this.textBoxZoeken.Location = new System.Drawing.Point(12, 81);
            this.textBoxZoeken.Name = "textBoxZoeken";
            this.textBoxZoeken.Size = new System.Drawing.Size(497, 23);
            this.textBoxZoeken.TabIndex = 4;
            // 
            // buttonTerugBestelling
            // 
            this.buttonTerugBestelling.Location = new System.Drawing.Point(12, 13);
            this.buttonTerugBestelling.Name = "buttonTerugBestelling";
            this.buttonTerugBestelling.Size = new System.Drawing.Size(94, 38);
            this.buttonTerugBestelling.TabIndex = 3;
            this.buttonTerugBestelling.Text = "Terug";
            this.buttonTerugBestelling.UseVisualStyleBackColor = true;
            this.buttonTerugBestelling.Click += new System.EventHandler(this.buttonTerugBestelling_Click);
            // 
            // buttonToevoegen
            // 
            this.buttonToevoegen.Location = new System.Drawing.Point(62, 472);
            this.buttonToevoegen.Name = "buttonToevoegen";
            this.buttonToevoegen.Size = new System.Drawing.Size(152, 59);
            this.buttonToevoegen.TabIndex = 2;
            this.buttonToevoegen.Text = "Toevoegen";
            this.buttonToevoegen.UseVisualStyleBackColor = true;
            this.buttonToevoegen.Click += new System.EventHandler(this.buttonToevoegen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 457);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 100);
            this.textBox1.TabIndex = 1;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 640);
            this.Controls.Add(this.panelBestellen);
            this.Controls.Add(this.buttonBestel);
            this.Controls.Add(this.buttonDrankjes);
            this.Controls.Add(this.buttonNagerecht);
            this.Controls.Add(this.buttonHoofdgerecht);
            this.Controls.Add(this.buttonVoorgerecht);
            this.Controls.Add(this.buttonTerug);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panelBestellen.ResumeLayout(false);
            this.panelBestellen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTerug;
        private System.Windows.Forms.Button buttonVoorgerecht;
        private System.Windows.Forms.Button buttonHoofdgerecht;
        private System.Windows.Forms.Button buttonNagerecht;
        private System.Windows.Forms.Button buttonDrankjes;
        private System.Windows.Forms.Button buttonBestel;
        private System.Windows.Forms.Panel panelBestellen;
        private System.Windows.Forms.Label labelTypeGerecht;
        private System.Windows.Forms.Label labelZoeken;
        private System.Windows.Forms.TextBox textBoxZoeken;
        private System.Windows.Forms.Button buttonTerugBestelling;
        private System.Windows.Forms.Button buttonToevoegen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listViewGerechten;
    }
}