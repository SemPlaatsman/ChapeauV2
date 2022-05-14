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
            System.Windows.Forms.DateTimePicker receiptTijdBetalingDateTimePicker;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.receiptChapeau = new System.Windows.Forms.Label();
            this.receiptStraat = new System.Windows.Forms.Label();
            this.receiptPostCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.receiptTotaalArtikelLbl = new System.Windows.Forms.Label();
            this.receiptTotaalArtikelPrijsLbl = new System.Windows.Forms.Label();
            this.receiptTotaalBetaalMethodeLbl = new System.Windows.Forms.Label();
            this.receiptTotaalBetaalMethodePrijsLbl = new System.Windows.Forms.Label();
            this.receiptBetaling = new System.Windows.Forms.Label();
            this.receiptDatum = new System.Windows.Forms.Label();
            this.receiptTotaalPrijsLbl = new System.Windows.Forms.Label();
            this.receiptTotaalToonPrijsLbl = new System.Windows.Forms.Label();
            this.receiptBtwLbl = new System.Windows.Forms.Label();
            this.receiptLabel9 = new System.Windows.Forms.Label();
            this.receiptLabel10 = new System.Windows.Forms.Label();
            this.receiptLabel11 = new System.Windows.Forms.Label();
            this.receiptOpmerkingenTbl = new System.Windows.Forms.TableLayoutPanel();
            this.receiptLijn = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.receiptTipLbl = new System.Windows.Forms.Label();
            this.receiptTotaalStreep = new System.Windows.Forms.Label();
            receiptTijdBetalingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptTijdBetalingDateTimePicker
            // 
            receiptTijdBetalingDateTimePicker.CustomFormat = "dd-MM-yyyy  hh:mm";
            receiptTijdBetalingDateTimePicker.Enabled = false;
            receiptTijdBetalingDateTimePicker.Location = new System.Drawing.Point(118, 502);
            receiptTijdBetalingDateTimePicker.Name = "receiptTijdBetalingDateTimePicker";
            receiptTijdBetalingDateTimePicker.Size = new System.Drawing.Size(250, 27);
            receiptTijdBetalingDateTimePicker.TabIndex = 12;
            receiptTijdBetalingDateTimePicker.Value = new System.DateTime(2022, 5, 5, 11, 55, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 203);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // receiptChapeau
            // 
            this.receiptChapeau.AutoSize = true;
            this.receiptChapeau.Location = new System.Drawing.Point(163, 235);
            this.receiptChapeau.Name = "receiptChapeau";
            this.receiptChapeau.Size = new System.Drawing.Size(67, 20);
            this.receiptChapeau.TabIndex = 1;
            this.receiptChapeau.Text = "Chapeau";
            // 
            // receiptStraat
            // 
            this.receiptStraat.AutoSize = true;
            this.receiptStraat.Location = new System.Drawing.Point(145, 255);
            this.receiptStraat.Name = "receiptStraat";
            this.receiptStraat.Size = new System.Drawing.Size(106, 20);
            this.receiptStraat.TabIndex = 2;
            this.receiptStraat.Text = "Horsterweg 12";
            // 
            // receiptPostCode
            // 
            this.receiptPostCode.AutoSize = true;
            this.receiptPostCode.Location = new System.Drawing.Point(130, 275);
            this.receiptPostCode.Name = "receiptPostCode";
            this.receiptPostCode.Size = new System.Drawing.Size(132, 20);
            this.receiptPostCode.TabIndex = 3;
            this.receiptPostCode.Text = "3891 EV Zeewolde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "HIER KOMEN DE ARTIKELEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "HIER KOMEN DE ARTIKELEN";
            // 
            // receiptTotaalArtikelLbl
            // 
            this.receiptTotaalArtikelLbl.AutoSize = true;
            this.receiptTotaalArtikelLbl.Location = new System.Drawing.Point(37, 383);
            this.receiptTotaalArtikelLbl.Name = "receiptTotaalArtikelLbl";
            this.receiptTotaalArtikelLbl.Size = new System.Drawing.Size(123, 20);
            this.receiptTotaalArtikelLbl.TabIndex = 6;
            this.receiptTotaalArtikelLbl.Text = "Totaal 0 artikelen";
            // 
            // receiptTotaalArtikelPrijsLbl
            // 
            this.receiptTotaalArtikelPrijsLbl.AutoSize = true;
            this.receiptTotaalArtikelPrijsLbl.Location = new System.Drawing.Point(323, 383);
            this.receiptTotaalArtikelPrijsLbl.Name = "receiptTotaalArtikelPrijsLbl";
            this.receiptTotaalArtikelPrijsLbl.Size = new System.Drawing.Size(36, 20);
            this.receiptTotaalArtikelPrijsLbl.TabIndex = 7;
            this.receiptTotaalArtikelPrijsLbl.Text = "0,00";
            // 
            // receiptTotaalBetaalMethodeLbl
            // 
            this.receiptTotaalBetaalMethodeLbl.AutoSize = true;
            this.receiptTotaalBetaalMethodeLbl.Location = new System.Drawing.Point(37, 565);
            this.receiptTotaalBetaalMethodeLbl.Name = "receiptTotaalBetaalMethodeLbl";
            this.receiptTotaalBetaalMethodeLbl.Size = new System.Drawing.Size(254, 20);
            this.receiptTotaalBetaalMethodeLbl.TabIndex = 8;
            this.receiptTotaalBetaalMethodeLbl.Text = "BETAALMETHODE (Hier met de fooi)";
            // 
            // receiptTotaalBetaalMethodePrijsLbl
            // 
            this.receiptTotaalBetaalMethodePrijsLbl.AutoSize = true;
            this.receiptTotaalBetaalMethodePrijsLbl.Location = new System.Drawing.Point(292, 565);
            this.receiptTotaalBetaalMethodePrijsLbl.Name = "receiptTotaalBetaalMethodePrijsLbl";
            this.receiptTotaalBetaalMethodePrijsLbl.Size = new System.Drawing.Size(36, 20);
            this.receiptTotaalBetaalMethodePrijsLbl.TabIndex = 9;
            this.receiptTotaalBetaalMethodePrijsLbl.Text = "0,00";
            // 
            // receiptBetaling
            // 
            this.receiptBetaling.AutoSize = true;
            this.receiptBetaling.Location = new System.Drawing.Point(37, 487);
            this.receiptBetaling.Name = "receiptBetaling";
            this.receiptBetaling.Size = new System.Drawing.Size(75, 20);
            this.receiptBetaling.TabIndex = 10;
            this.receiptBetaling.Text = "BETALING";
            // 
            // receiptDatum
            // 
            this.receiptDatum.AutoSize = true;
            this.receiptDatum.Location = new System.Drawing.Point(37, 507);
            this.receiptDatum.Name = "receiptDatum";
            this.receiptDatum.Size = new System.Drawing.Size(57, 20);
            this.receiptDatum.TabIndex = 11;
            this.receiptDatum.Text = "Datum:";
            // 
            // receiptTotaalPrijsLbl
            // 
            this.receiptTotaalPrijsLbl.AutoSize = true;
            this.receiptTotaalPrijsLbl.Location = new System.Drawing.Point(37, 595);
            this.receiptTotaalPrijsLbl.Name = "receiptTotaalPrijsLbl";
            this.receiptTotaalPrijsLbl.Size = new System.Drawing.Size(50, 20);
            this.receiptTotaalPrijsLbl.TabIndex = 13;
            this.receiptTotaalPrijsLbl.Text = "Totaal";
            // 
            // receiptTotaalToonPrijsLbl
            // 
            this.receiptTotaalToonPrijsLbl.AutoSize = true;
            this.receiptTotaalToonPrijsLbl.Location = new System.Drawing.Point(292, 595);
            this.receiptTotaalToonPrijsLbl.Name = "receiptTotaalToonPrijsLbl";
            this.receiptTotaalToonPrijsLbl.Size = new System.Drawing.Size(67, 20);
            this.receiptTotaalToonPrijsLbl.TabIndex = 14;
            this.receiptTotaalToonPrijsLbl.Text = "0,00 EUR";
            // 
            // receiptBtwLbl
            // 
            this.receiptBtwLbl.AutoSize = true;
            this.receiptBtwLbl.Location = new System.Drawing.Point(37, 418);
            this.receiptBtwLbl.Name = "receiptBtwLbl";
            this.receiptBtwLbl.Size = new System.Drawing.Size(338, 20);
            this.receiptBtwLbl.TabIndex = 15;
            this.receiptBtwLbl.Text = "(BTW ......%                    x            0,00     =      0,00   )";
            // 
            // receiptLabel9
            // 
            this.receiptLabel9.AutoSize = true;
            this.receiptLabel9.Location = new System.Drawing.Point(92, 678);
            this.receiptLabel9.Name = "receiptLabel9";
            this.receiptLabel9.Size = new System.Drawing.Size(235, 20);
            this.receiptLabel9.TabIndex = 16;
            this.receiptLabel9.Text = "U bent geholpen door: GASTHEER";
            // 
            // receiptLabel10
            // 
            this.receiptLabel10.AutoSize = true;
            this.receiptLabel10.Location = new System.Drawing.Point(25, 818);
            this.receiptLabel10.Name = "receiptLabel10";
            this.receiptLabel10.Size = new System.Drawing.Size(364, 20);
            this.receiptLabel10.TabIndex = 17;
            this.receiptLabel10.Text = "Wij bedanken U voor uw bezoek en hopelijk tot ziens!";
            // 
            // receiptLabel11
            // 
            this.receiptLabel11.AutoSize = true;
            this.receiptLabel11.Location = new System.Drawing.Point(42, 698);
            this.receiptLabel11.Name = "receiptLabel11";
            this.receiptLabel11.Size = new System.Drawing.Size(83, 20);
            this.receiptLabel11.TabIndex = 18;
            this.receiptLabel11.Text = "Opmerking";
            // 
            // receiptOpmerkingenTbl
            // 
            this.receiptOpmerkingenTbl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.receiptOpmerkingenTbl.ColumnCount = 1;
            this.receiptOpmerkingenTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.receiptOpmerkingenTbl.Location = new System.Drawing.Point(42, 721);
            this.receiptOpmerkingenTbl.Name = "receiptOpmerkingenTbl";
            this.receiptOpmerkingenTbl.RowCount = 1;
            this.receiptOpmerkingenTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.receiptOpmerkingenTbl.Size = new System.Drawing.Size(333, 74);
            this.receiptOpmerkingenTbl.TabIndex = 19;
            // 
            // receiptLijn
            // 
            this.receiptLijn.AutoSize = true;
            this.receiptLijn.Location = new System.Drawing.Point(12, 456);
            this.receiptLijn.Name = "receiptLijn";
            this.receiptLijn.Size = new System.Drawing.Size(387, 20);
            this.receiptLijn.TabIndex = 20;
            this.receiptLijn.Text = "_______________________________________________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "_______________";
            // 
            // receiptTipLbl
            // 
            this.receiptTipLbl.AutoSize = true;
            this.receiptTipLbl.Location = new System.Drawing.Point(37, 625);
            this.receiptTipLbl.Name = "receiptTipLbl";
            this.receiptTipLbl.Size = new System.Drawing.Size(318, 20);
            this.receiptTipLbl.TabIndex = 22;
            this.receiptTipLbl.Text = "TOONT WANNEER FOOI (HET EXTRA BEDRAG)";
            // 
            // receiptTotaalStreep
            // 
            this.receiptTotaalStreep.AutoSize = true;
            this.receiptTotaalStreep.Location = new System.Drawing.Point(276, 575);
            this.receiptTotaalStreep.Name = "receiptTotaalStreep";
            this.receiptTotaalStreep.Size = new System.Drawing.Size(99, 20);
            this.receiptTotaalStreep.TabIndex = 23;
            this.receiptTotaalStreep.Text = "_______________";
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 866);
            this.Controls.Add(this.receiptTipLbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.receiptLijn);
            this.Controls.Add(this.receiptOpmerkingenTbl);
            this.Controls.Add(this.receiptLabel11);
            this.Controls.Add(this.receiptLabel10);
            this.Controls.Add(this.receiptLabel9);
            this.Controls.Add(this.receiptBtwLbl);
            this.Controls.Add(this.receiptTotaalToonPrijsLbl);
            this.Controls.Add(this.receiptTotaalPrijsLbl);
            this.Controls.Add(receiptTijdBetalingDateTimePicker);
            this.Controls.Add(this.receiptDatum);
            this.Controls.Add(this.receiptBetaling);
            this.Controls.Add(this.receiptTotaalBetaalMethodePrijsLbl);
            this.Controls.Add(this.receiptTotaalBetaalMethodeLbl);
            this.Controls.Add(this.receiptTotaalArtikelPrijsLbl);
            this.Controls.Add(this.receiptTotaalArtikelLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.receiptPostCode);
            this.Controls.Add(this.receiptStraat);
            this.Controls.Add(this.receiptChapeau);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.receiptTotaalStreep);
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label receiptChapeau;
        private System.Windows.Forms.Label receiptStraat;
        private System.Windows.Forms.Label receiptPostCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label receiptTotaalArtikelLbl;
        private System.Windows.Forms.Label receiptTotaalArtikelPrijsLbl;
        private System.Windows.Forms.Label receiptTotaalBetaalMethodeLbl;
        private System.Windows.Forms.Label receiptTotaalBetaalMethodePrijsLbl;
        private System.Windows.Forms.Label receiptBetaling;
        private System.Windows.Forms.Label receiptDatum;
        private System.Windows.Forms.Label receiptTotaalPrijsLbl;
        private System.Windows.Forms.Label receiptTotaalToonPrijsLbl;
        private System.Windows.Forms.Label receiptBtwLbl;
        private System.Windows.Forms.Label receiptLabel9;
        private System.Windows.Forms.Label receiptLabel10;
        private System.Windows.Forms.Label receiptLabel11;
        private System.Windows.Forms.TableLayoutPanel receiptOpmerkingenTbl;
        private System.Windows.Forms.Label receiptLijn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label receiptTipLbl;
        private System.Windows.Forms.Label receiptTotaalStreep;
    }
}