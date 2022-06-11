namespace ChapeauUI
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.receiptChapeau = new System.Windows.Forms.Label();
            this.receiptStraat = new System.Windows.Forms.Label();
            this.receiptPostCode = new System.Windows.Forms.Label();
            this.receiptTotaalBetaalMethodeLbl = new System.Windows.Forms.Label();
            this.receiptTotaalOriginelePrijsLbl = new System.Windows.Forms.Label();
            this.receiptBetaling = new System.Windows.Forms.Label();
            this.receiptDatum = new System.Windows.Forms.Label();
            this.receiptTotaalPrijsLbl = new System.Windows.Forms.Label();
            this.receiptTotaalToonPrijsLbl = new System.Windows.Forms.Label();
            this.geholpenDoorLbl = new System.Windows.Forms.Label();
            this.receiptLabel10 = new System.Windows.Forms.Label();
            this.receiptLabel11 = new System.Windows.Forms.Label();
            this.receiptLijn = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.receiptTotaalStreep = new System.Windows.Forms.Label();
            this.BonPnl = new System.Windows.Forms.Panel();
            this.remarkTextbox = new System.Windows.Forms.TextBox();
            this.tipTotalLbl = new System.Windows.Forms.Label();
            this.tipOrDiscountLbl = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListView();
            this.betaalMethodeLbl = new System.Windows.Forms.Label();
            this.datumLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totaalMetBtwLbl = new System.Windows.Forms.Label();
            this.btwPriceLbl = new System.Windows.Forms.Label();
            this.receiptTotaalArtikelLbl = new System.Windows.Forms.Label();
            this.receiptBtwLbl = new System.Windows.Forms.Label();
            this.receiptTotaalArtikelPrijsLbl = new System.Windows.Forms.Label();
            this.TerugBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BonPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // receiptChapeau
            // 
            this.receiptChapeau.AutoSize = true;
            this.receiptChapeau.Location = new System.Drawing.Point(152, 133);
            this.receiptChapeau.Name = "receiptChapeau";
            this.receiptChapeau.Size = new System.Drawing.Size(54, 15);
            this.receiptChapeau.TabIndex = 1;
            this.receiptChapeau.Text = "Chapeau";
            // 
            // receiptStraat
            // 
            this.receiptStraat.AutoSize = true;
            this.receiptStraat.Location = new System.Drawing.Point(141, 148);
            this.receiptStraat.Name = "receiptStraat";
            this.receiptStraat.Size = new System.Drawing.Size(83, 15);
            this.receiptStraat.TabIndex = 2;
            this.receiptStraat.Text = "Horsterweg 12";
            // 
            // receiptPostCode
            // 
            this.receiptPostCode.AutoSize = true;
            this.receiptPostCode.Location = new System.Drawing.Point(132, 163);
            this.receiptPostCode.Name = "receiptPostCode";
            this.receiptPostCode.Size = new System.Drawing.Size(101, 15);
            this.receiptPostCode.TabIndex = 3;
            this.receiptPostCode.Text = "3891 EV Zeewolde";
            // 
            // receiptTotaalBetaalMethodeLbl
            // 
            this.receiptTotaalBetaalMethodeLbl.AutoSize = true;
            this.receiptTotaalBetaalMethodeLbl.Location = new System.Drawing.Point(38, 470);
            this.receiptTotaalBetaalMethodeLbl.Name = "receiptTotaalBetaalMethodeLbl";
            this.receiptTotaalBetaalMethodeLbl.Size = new System.Drawing.Size(98, 15);
            this.receiptTotaalBetaalMethodeLbl.TabIndex = 8;
            this.receiptTotaalBetaalMethodeLbl.Text = "Origineel bedrag:";
            // 
            // receiptTotaalOriginelePrijsLbl
            // 
            this.receiptTotaalOriginelePrijsLbl.AutoSize = true;
            this.receiptTotaalOriginelePrijsLbl.Location = new System.Drawing.Point(262, 470);
            this.receiptTotaalOriginelePrijsLbl.Name = "receiptTotaalOriginelePrijsLbl";
            this.receiptTotaalOriginelePrijsLbl.Size = new System.Drawing.Size(28, 15);
            this.receiptTotaalOriginelePrijsLbl.TabIndex = 9;
            this.receiptTotaalOriginelePrijsLbl.Text = "0,00";
            // 
            // receiptBetaling
            // 
            this.receiptBetaling.AutoSize = true;
            this.receiptBetaling.Location = new System.Drawing.Point(38, 411);
            this.receiptBetaling.Name = "receiptBetaling";
            this.receiptBetaling.Size = new System.Drawing.Size(105, 15);
            this.receiptBetaling.TabIndex = 10;
            this.receiptBetaling.Text = "BETAALMETHODE:";
            // 
            // receiptDatum
            // 
            this.receiptDatum.AutoSize = true;
            this.receiptDatum.Location = new System.Drawing.Point(38, 426);
            this.receiptDatum.Name = "receiptDatum";
            this.receiptDatum.Size = new System.Drawing.Size(46, 15);
            this.receiptDatum.TabIndex = 11;
            this.receiptDatum.Text = "Datum:";
            // 
            // receiptTotaalPrijsLbl
            // 
            this.receiptTotaalPrijsLbl.AutoSize = true;
            this.receiptTotaalPrijsLbl.Location = new System.Drawing.Point(38, 507);
            this.receiptTotaalPrijsLbl.Name = "receiptTotaalPrijsLbl";
            this.receiptTotaalPrijsLbl.Size = new System.Drawing.Size(83, 15);
            this.receiptTotaalPrijsLbl.TabIndex = 13;
            this.receiptTotaalPrijsLbl.Text = "Totaal betaald:";
            // 
            // receiptTotaalToonPrijsLbl
            // 
            this.receiptTotaalToonPrijsLbl.AutoSize = true;
            this.receiptTotaalToonPrijsLbl.Location = new System.Drawing.Point(262, 507);
            this.receiptTotaalToonPrijsLbl.Name = "receiptTotaalToonPrijsLbl";
            this.receiptTotaalToonPrijsLbl.Size = new System.Drawing.Size(52, 15);
            this.receiptTotaalToonPrijsLbl.TabIndex = 14;
            this.receiptTotaalToonPrijsLbl.Text = "0,00 EUR";
            // 
            // geholpenDoorLbl
            // 
            this.geholpenDoorLbl.AutoSize = true;
            this.geholpenDoorLbl.Location = new System.Drawing.Point(87, 554);
            this.geholpenDoorLbl.Name = "geholpenDoorLbl";
            this.geholpenDoorLbl.Size = new System.Drawing.Size(185, 15);
            this.geholpenDoorLbl.TabIndex = 16;
            this.geholpenDoorLbl.Text = "U bent geholpen door: GASTHEER";
            // 
            // receiptLabel10
            // 
            this.receiptLabel10.AutoSize = true;
            this.receiptLabel10.Location = new System.Drawing.Point(43, 660);
            this.receiptLabel10.Name = "receiptLabel10";
            this.receiptLabel10.Size = new System.Drawing.Size(287, 15);
            this.receiptLabel10.TabIndex = 17;
            this.receiptLabel10.Text = "Wij bedanken U voor uw bezoek en hopelijk tot ziens!";
            // 
            // receiptLabel11
            // 
            this.receiptLabel11.AutoSize = true;
            this.receiptLabel11.Location = new System.Drawing.Point(43, 569);
            this.receiptLabel11.Name = "receiptLabel11";
            this.receiptLabel11.Size = new System.Drawing.Size(70, 15);
            this.receiptLabel11.TabIndex = 18;
            this.receiptLabel11.Text = "Opmerking:";
            // 
            // receiptLijn
            // 
            this.receiptLijn.AutoSize = true;
            this.receiptLijn.Location = new System.Drawing.Point(17, 388);
            this.receiptLijn.Name = "receiptLijn";
            this.receiptLijn.Size = new System.Drawing.Size(322, 15);
            this.receiptLijn.TabIndex = 20;
            this.receiptLijn.Text = "_______________________________________________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "_______________";
            // 
            // receiptTotaalStreep
            // 
            this.receiptTotaalStreep.AutoSize = true;
            this.receiptTotaalStreep.Location = new System.Drawing.Point(248, 492);
            this.receiptTotaalStreep.Name = "receiptTotaalStreep";
            this.receiptTotaalStreep.Size = new System.Drawing.Size(82, 15);
            this.receiptTotaalStreep.TabIndex = 23;
            this.receiptTotaalStreep.Text = "_______________";
            // 
            // BonPnl
            // 
            this.BonPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BonPnl.Controls.Add(this.remarkTextbox);
            this.BonPnl.Controls.Add(this.tipTotalLbl);
            this.BonPnl.Controls.Add(this.tipOrDiscountLbl);
            this.BonPnl.Controls.Add(this.itemsListBox);
            this.BonPnl.Controls.Add(this.betaalMethodeLbl);
            this.BonPnl.Controls.Add(this.datumLbl);
            this.BonPnl.Controls.Add(this.label1);
            this.BonPnl.Controls.Add(this.totaalMetBtwLbl);
            this.BonPnl.Controls.Add(this.btwPriceLbl);
            this.BonPnl.Controls.Add(this.receiptTotaalArtikelLbl);
            this.BonPnl.Controls.Add(this.receiptBtwLbl);
            this.BonPnl.Controls.Add(this.receiptTotaalArtikelPrijsLbl);
            this.BonPnl.Controls.Add(this.receiptTotaalBetaalMethodeLbl);
            this.BonPnl.Controls.Add(this.receiptTotaalOriginelePrijsLbl);
            this.BonPnl.Controls.Add(this.pictureBox1);
            this.BonPnl.Controls.Add(this.receiptTotaalStreep);
            this.BonPnl.Controls.Add(this.label12);
            this.BonPnl.Controls.Add(this.receiptChapeau);
            this.BonPnl.Controls.Add(this.receiptLijn);
            this.BonPnl.Controls.Add(this.receiptStraat);
            this.BonPnl.Controls.Add(this.receiptPostCode);
            this.BonPnl.Controls.Add(this.receiptLabel11);
            this.BonPnl.Controls.Add(this.receiptLabel10);
            this.BonPnl.Controls.Add(this.geholpenDoorLbl);
            this.BonPnl.Controls.Add(this.receiptTotaalToonPrijsLbl);
            this.BonPnl.Controls.Add(this.receiptTotaalPrijsLbl);
            this.BonPnl.Controls.Add(this.receiptBetaling);
            this.BonPnl.Controls.Add(this.receiptDatum);
            this.BonPnl.Location = new System.Drawing.Point(68, 45);
            this.BonPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BonPnl.Name = "BonPnl";
            this.BonPnl.Size = new System.Drawing.Size(373, 688);
            this.BonPnl.TabIndex = 24;
            // 
            // remarkTextbox
            // 
            this.remarkTextbox.Location = new System.Drawing.Point(36, 590);
            this.remarkTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remarkTextbox.Multiline = true;
            this.remarkTextbox.Name = "remarkTextbox";
            this.remarkTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.remarkTextbox.Size = new System.Drawing.Size(299, 68);
            this.remarkTextbox.TabIndex = 38;
            // 
            // tipTotalLbl
            // 
            this.tipTotalLbl.AutoSize = true;
            this.tipTotalLbl.Location = new System.Drawing.Point(262, 487);
            this.tipTotalLbl.Name = "tipTotalLbl";
            this.tipTotalLbl.Size = new System.Drawing.Size(28, 15);
            this.tipTotalLbl.TabIndex = 37;
            this.tipTotalLbl.Text = "0,00";
            // 
            // tipOrDiscountLbl
            // 
            this.tipOrDiscountLbl.AutoSize = true;
            this.tipOrDiscountLbl.Location = new System.Drawing.Point(38, 484);
            this.tipOrDiscountLbl.Name = "tipOrDiscountLbl";
            this.tipOrDiscountLbl.Size = new System.Drawing.Size(73, 15);
            this.tipOrDiscountLbl.TabIndex = 36;
            this.tipOrDiscountLbl.Text = "Fooi bedrag:";
            // 
            // itemsListBox
            // 
            this.itemsListBox.HideSelection = false;
            this.itemsListBox.Location = new System.Drawing.Point(36, 180);
            this.itemsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(298, 146);
            this.itemsListBox.TabIndex = 35;
            this.itemsListBox.UseCompatibleStateImageBehavior = false;
            // 
            // betaalMethodeLbl
            // 
            this.betaalMethodeLbl.AutoSize = true;
            this.betaalMethodeLbl.Location = new System.Drawing.Point(203, 411);
            this.betaalMethodeLbl.Name = "betaalMethodeLbl";
            this.betaalMethodeLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.betaalMethodeLbl.Size = new System.Drawing.Size(87, 15);
            this.betaalMethodeLbl.TabIndex = 34;
            this.betaalMethodeLbl.Text = "betaalmethode";
            this.betaalMethodeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // datumLbl
            // 
            this.datumLbl.AutoSize = true;
            this.datumLbl.Location = new System.Drawing.Point(203, 426);
            this.datumLbl.Name = "datumLbl";
            this.datumLbl.Size = new System.Drawing.Size(30, 15);
            this.datumLbl.TabIndex = 33;
            this.datumLbl.Text = "date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "=";
            // 
            // totaalMetBtwLbl
            // 
            this.totaalMetBtwLbl.AutoSize = true;
            this.totaalMetBtwLbl.Location = new System.Drawing.Point(286, 362);
            this.totaalMetBtwLbl.Name = "totaalMetBtwLbl";
            this.totaalMetBtwLbl.Size = new System.Drawing.Size(28, 15);
            this.totaalMetBtwLbl.TabIndex = 31;
            this.totaalMetBtwLbl.Text = "0,00";
            // 
            // btwPriceLbl
            // 
            this.btwPriceLbl.AutoSize = true;
            this.btwPriceLbl.Location = new System.Drawing.Point(179, 362);
            this.btwPriceLbl.Name = "btwPriceLbl";
            this.btwPriceLbl.Size = new System.Drawing.Size(28, 15);
            this.btwPriceLbl.TabIndex = 30;
            this.btwPriceLbl.Text = "0,00";
            // 
            // receiptTotaalArtikelLbl
            // 
            this.receiptTotaalArtikelLbl.AutoSize = true;
            this.receiptTotaalArtikelLbl.Location = new System.Drawing.Point(36, 336);
            this.receiptTotaalArtikelLbl.Name = "receiptTotaalArtikelLbl";
            this.receiptTotaalArtikelLbl.Size = new System.Drawing.Size(165, 15);
            this.receiptTotaalArtikelLbl.TabIndex = 27;
            this.receiptTotaalArtikelLbl.Text = "Totaal 0 artikelen (zonder btw)";
            // 
            // receiptBtwLbl
            // 
            this.receiptBtwLbl.AutoSize = true;
            this.receiptBtwLbl.Location = new System.Drawing.Point(36, 362);
            this.receiptBtwLbl.Name = "receiptBtwLbl";
            this.receiptBtwLbl.Size = new System.Drawing.Size(102, 15);
            this.receiptBtwLbl.TabIndex = 29;
            this.receiptBtwLbl.Text = "(BTW                    =";
            // 
            // receiptTotaalArtikelPrijsLbl
            // 
            this.receiptTotaalArtikelPrijsLbl.AutoSize = true;
            this.receiptTotaalArtikelPrijsLbl.Location = new System.Drawing.Point(286, 336);
            this.receiptTotaalArtikelPrijsLbl.Name = "receiptTotaalArtikelPrijsLbl";
            this.receiptTotaalArtikelPrijsLbl.Size = new System.Drawing.Size(28, 15);
            this.receiptTotaalArtikelPrijsLbl.TabIndex = 28;
            this.receiptTotaalArtikelPrijsLbl.Text = "0,00";
            // 
            // TerugBtn
            // 
            this.TerugBtn.Location = new System.Drawing.Point(10, 9);
            this.TerugBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TerugBtn.Name = "TerugBtn";
            this.TerugBtn.Size = new System.Drawing.Size(90, 32);
            this.TerugBtn.TabIndex = 25;
            this.TerugBtn.Text = "Terug";
            this.TerugBtn.UseVisualStyleBackColor = true;
            this.TerugBtn.Click += new System.EventHandler(this.TerugBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(192, 749);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(133, 34);
            this.PrintBtn.TabIndex = 26;
            this.PrintBtn.Text = "Uitprinten";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 809);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.TerugBtn);
            this.Controls.Add(this.BonPnl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceiptForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BonPnl.ResumeLayout(false);
            this.BonPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label receiptChapeau;
        private System.Windows.Forms.Label receiptStraat;
        private System.Windows.Forms.Label receiptPostCode;
        private System.Windows.Forms.Label receiptTotaalBetaalMethodeLbl;
        private System.Windows.Forms.Label receiptTotaalOriginelePrijsLbl;
        private System.Windows.Forms.Label receiptBetaling;
        private System.Windows.Forms.Label receiptDatum;
        private System.Windows.Forms.Label receiptTotaalPrijsLbl;
        private System.Windows.Forms.Label receiptTotaalToonPrijsLbl;
        private System.Windows.Forms.Label geholpenDoorLbl;
        private System.Windows.Forms.Label receiptLabel10;
        private System.Windows.Forms.Label receiptLabel11;
        private System.Windows.Forms.Label receiptLijn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label receiptTotaalStreep;
        private System.Windows.Forms.Panel BonPnl;
        private System.Windows.Forms.Button TerugBtn;
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totaalMetBtwLbl;
        private System.Windows.Forms.Label btwPriceLbl;
        private System.Windows.Forms.Label receiptTotaalArtikelLbl;
        private System.Windows.Forms.Label receiptBtwLbl;
        private System.Windows.Forms.Label receiptTotaalArtikelPrijsLbl;
        private System.Windows.Forms.Label datumLbl;
        private System.Windows.Forms.Label betaalMethodeLbl;
        private System.Windows.Forms.ListView itemsListBox;
        private System.Windows.Forms.Label tipTotalLbl;
        private System.Windows.Forms.Label tipOrDiscountLbl;
        private System.Windows.Forms.TextBox remarkTextbox;
        private System.Windows.Forms.Button PrintBtn;
    }
}