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
            this.panelItemSelected = new System.Windows.Forms.Panel();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelSelectedItem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewGerechten = new System.Windows.Forms.ListView();
            this.labelTypeGerecht = new System.Windows.Forms.Label();
            this.buttonTerugBestelling = new System.Windows.Forms.Button();
            this.panelViewOrder = new System.Windows.Forms.Panel();
            this.labelNoItems = new System.Windows.Forms.Label();
            this.panelVerwijderenBestelling = new System.Windows.Forms.Panel();
            this.buttonNeeVerwijderen = new System.Windows.Forms.Button();
            this.buttonJaVerwijderen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.listViewViewOrder = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonTerugSelectedItems = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelOrdered = new System.Windows.Forms.Panel();
            this.labelBesteld = new System.Windows.Forms.Label();
            this.buttonOrderedOk = new System.Windows.Forms.Button();
            this.buttonViewOrder = new System.Windows.Forms.Button();
            this.panelBestellen.SuspendLayout();
            this.panelItemSelected.SuspendLayout();
            this.panelViewOrder.SuspendLayout();
            this.panelVerwijderenBestelling.SuspendLayout();
            this.panelOrdered.SuspendLayout();
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
            this.buttonVoorgerecht.Location = new System.Drawing.Point(12, 81);
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
            this.buttonHoofdgerecht.Location = new System.Drawing.Point(12, 198);
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
            this.buttonNagerecht.Location = new System.Drawing.Point(12, 315);
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
            this.buttonDrankjes.Location = new System.Drawing.Point(12, 432);
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
            this.buttonBestel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBestel.Location = new System.Drawing.Point(262, 568);
            this.buttonBestel.Name = "buttonBestel";
            this.buttonBestel.Size = new System.Drawing.Size(252, 73);
            this.buttonBestel.TabIndex = 5;
            this.buttonBestel.Text = "Bestel";
            this.buttonBestel.UseVisualStyleBackColor = true;
            this.buttonBestel.Click += new System.EventHandler(this.buttonBestel_Click);
            // 
            // panelBestellen
            // 
            this.panelBestellen.Controls.Add(this.panelItemSelected);
            this.panelBestellen.Controls.Add(this.panelViewOrder);
            this.panelBestellen.Controls.Add(this.listViewGerechten);
            this.panelBestellen.Controls.Add(this.labelTypeGerecht);
            this.panelBestellen.Controls.Add(this.buttonTerugBestelling);
            this.panelBestellen.Location = new System.Drawing.Point(1, 0);
            this.panelBestellen.Name = "panelBestellen";
            this.panelBestellen.Size = new System.Drawing.Size(522, 641);
            this.panelBestellen.TabIndex = 6;
            // 
            // panelItemSelected
            // 
            this.panelItemSelected.Controls.Add(this.labelErrorMessage);
            this.panelItemSelected.Controls.Add(this.buttonAdd);
            this.panelItemSelected.Controls.Add(this.buttonCancel);
            this.panelItemSelected.Controls.Add(this.textBoxRemark);
            this.panelItemSelected.Controls.Add(this.label3);
            this.panelItemSelected.Controls.Add(this.label2);
            this.panelItemSelected.Controls.Add(this.textBoxAmount);
            this.panelItemSelected.Controls.Add(this.labelAmount);
            this.panelItemSelected.Controls.Add(this.labelSelectedItem);
            this.panelItemSelected.Controls.Add(this.label1);
            this.panelItemSelected.Location = new System.Drawing.Point(88, 132);
            this.panelItemSelected.Name = "panelItemSelected";
            this.panelItemSelected.Size = new System.Drawing.Size(353, 294);
            this.panelItemSelected.TabIndex = 8;
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Location = new System.Drawing.Point(8, 87);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(12, 15);
            this.labelErrorMessage.TabIndex = 9;
            this.labelErrorMessage.Text = "-";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(202, 255);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 27);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Voeg toe";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(16, 255);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(137, 27);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Annuleer";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Location = new System.Drawing.Point(14, 125);
            this.textBoxRemark.Multiline = true;
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(325, 114);
            this.textBoxRemark.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opmerking:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(77, 55);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(23, 23);
            this.textBoxAmount.TabIndex = 3;
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAmount.Location = new System.Drawing.Point(8, 58);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(47, 17);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Aantal:";
            // 
            // labelSelectedItem
            // 
            this.labelSelectedItem.AutoSize = true;
            this.labelSelectedItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedItem.Location = new System.Drawing.Point(8, 34);
            this.labelSelectedItem.Name = "labelSelectedItem";
            this.labelSelectedItem.Size = new System.Drawing.Size(13, 17);
            this.labelSelectedItem.TabIndex = 1;
            this.labelSelectedItem.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gekozen:";
            // 
            // listViewGerechten
            // 
            this.listViewGerechten.HideSelection = false;
            this.listViewGerechten.Location = new System.Drawing.Point(12, 74);
            this.listViewGerechten.MultiSelect = false;
            this.listViewGerechten.Name = "listViewGerechten";
            this.listViewGerechten.Size = new System.Drawing.Size(497, 555);
            this.listViewGerechten.TabIndex = 7;
            this.listViewGerechten.UseCompatibleStateImageBehavior = false;
            this.listViewGerechten.SelectedIndexChanged += new System.EventHandler(this.listViewGerechten_SelectedIndexChanged);
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
            // panelViewOrder
            // 
            this.panelViewOrder.Controls.Add(this.labelNoItems);
            this.panelViewOrder.Controls.Add(this.panelVerwijderenBestelling);
            this.panelViewOrder.Controls.Add(this.buttonDeleteOrder);
            this.panelViewOrder.Controls.Add(this.listViewViewOrder);
            this.panelViewOrder.Controls.Add(this.label6);
            this.panelViewOrder.Controls.Add(this.label5);
            this.panelViewOrder.Controls.Add(this.buttonAddComment);
            this.panelViewOrder.Controls.Add(this.textBoxComment);
            this.panelViewOrder.Controls.Add(this.buttonPlus);
            this.panelViewOrder.Controls.Add(this.buttonMinus);
            this.panelViewOrder.Controls.Add(this.buttonTerugSelectedItems);
            this.panelViewOrder.Controls.Add(this.label4);
            this.panelViewOrder.Location = new System.Drawing.Point(0, 0);
            this.panelViewOrder.Name = "panelViewOrder";
            this.panelViewOrder.Size = new System.Drawing.Size(522, 641);
            this.panelViewOrder.TabIndex = 8;
            // 
            // labelNoItems
            // 
            this.labelNoItems.AutoSize = true;
            this.labelNoItems.ForeColor = System.Drawing.Color.Red;
            this.labelNoItems.Location = new System.Drawing.Point(31, 546);
            this.labelNoItems.Name = "labelNoItems";
            this.labelNoItems.Size = new System.Drawing.Size(0, 15);
            this.labelNoItems.TabIndex = 12;
            // 
            // panelVerwijderenBestelling
            // 
            this.panelVerwijderenBestelling.Controls.Add(this.buttonNeeVerwijderen);
            this.panelVerwijderenBestelling.Controls.Add(this.buttonJaVerwijderen);
            this.panelVerwijderenBestelling.Controls.Add(this.label7);
            this.panelVerwijderenBestelling.Location = new System.Drawing.Point(138, 173);
            this.panelVerwijderenBestelling.Name = "panelVerwijderenBestelling";
            this.panelVerwijderenBestelling.Size = new System.Drawing.Size(261, 136);
            this.panelVerwijderenBestelling.TabIndex = 11;
            // 
            // buttonNeeVerwijderen
            // 
            this.buttonNeeVerwijderen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNeeVerwijderen.Location = new System.Drawing.Point(153, 66);
            this.buttonNeeVerwijderen.Name = "buttonNeeVerwijderen";
            this.buttonNeeVerwijderen.Size = new System.Drawing.Size(75, 41);
            this.buttonNeeVerwijderen.TabIndex = 2;
            this.buttonNeeVerwijderen.Text = "Nee";
            this.buttonNeeVerwijderen.UseVisualStyleBackColor = true;
            this.buttonNeeVerwijderen.Click += new System.EventHandler(this.buttonNeeVerwijderen_Click);
            // 
            // buttonJaVerwijderen
            // 
            this.buttonJaVerwijderen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonJaVerwijderen.Location = new System.Drawing.Point(38, 66);
            this.buttonJaVerwijderen.Name = "buttonJaVerwijderen";
            this.buttonJaVerwijderen.Size = new System.Drawing.Size(75, 41);
            this.buttonJaVerwijderen.TabIndex = 1;
            this.buttonJaVerwijderen.Text = "Ja";
            this.buttonJaVerwijderen.UseVisualStyleBackColor = true;
            this.buttonJaVerwijderen.Click += new System.EventHandler(this.buttonJaVerwijderen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(64, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Weet u dit zeker?";
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteOrder.Location = new System.Drawing.Point(31, 568);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(210, 46);
            this.buttonDeleteOrder.TabIndex = 10;
            this.buttonDeleteOrder.Text = "Verwijder gehele bestelling";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // listViewViewOrder
            // 
            this.listViewViewOrder.HideSelection = false;
            this.listViewViewOrder.Location = new System.Drawing.Point(12, 49);
            this.listViewViewOrder.Name = "listViewViewOrder";
            this.listViewViewOrder.Size = new System.Drawing.Size(497, 373);
            this.listViewViewOrder.TabIndex = 9;
            this.listViewViewOrder.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Aantal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(290, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Opmerking:";
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddComment.Location = new System.Drawing.Point(344, 583);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(98, 31);
            this.buttonAddComment.TabIndex = 6;
            this.buttonAddComment.Text = "Voeg toe";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(290, 462);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(219, 114);
            this.textBoxComment.TabIndex = 5;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlus.Location = new System.Drawing.Point(166, 462);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 51);
            this.buttonPlus.TabIndex = 4;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinus.Location = new System.Drawing.Point(31, 462);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 51);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonTerugSelectedItems
            // 
            this.buttonTerugSelectedItems.Location = new System.Drawing.Point(13, 15);
            this.buttonTerugSelectedItems.Name = "buttonTerugSelectedItems";
            this.buttonTerugSelectedItems.Size = new System.Drawing.Size(95, 27);
            this.buttonTerugSelectedItems.TabIndex = 2;
            this.buttonTerugSelectedItems.Text = "Terug";
            this.buttonTerugSelectedItems.UseVisualStyleBackColor = true;
            this.buttonTerugSelectedItems.Click += new System.EventHandler(this.buttonTerugSelectedItems_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(138, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Geselecteerde items:";
            // 
            // panelOrdered
            // 
            this.panelOrdered.Controls.Add(this.labelBesteld);
            this.panelOrdered.Controls.Add(this.buttonOrderedOk);
            this.panelOrdered.Location = new System.Drawing.Point(162, 257);
            this.panelOrdered.Name = "panelOrdered";
            this.panelOrdered.Size = new System.Drawing.Size(200, 100);
            this.panelOrdered.TabIndex = 8;
            // 
            // labelBesteld
            // 
            this.labelBesteld.AutoSize = true;
            this.labelBesteld.Location = new System.Drawing.Point(15, 12);
            this.labelBesteld.Name = "labelBesteld";
            this.labelBesteld.Size = new System.Drawing.Size(12, 15);
            this.labelBesteld.TabIndex = 0;
            this.labelBesteld.Text = "-";
            // 
            // buttonOrderedOk
            // 
            this.buttonOrderedOk.Location = new System.Drawing.Point(59, 62);
            this.buttonOrderedOk.Name = "buttonOrderedOk";
            this.buttonOrderedOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderedOk.TabIndex = 1;
            this.buttonOrderedOk.Text = "Ok";
            this.buttonOrderedOk.UseVisualStyleBackColor = true;
            this.buttonOrderedOk.Click += new System.EventHandler(this.buttonOrderedOk_Click);
            // 
            // buttonViewOrder
            // 
            this.buttonViewOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonViewOrder.Location = new System.Drawing.Point(12, 568);
            this.buttonViewOrder.Name = "buttonViewOrder";
            this.buttonViewOrder.Size = new System.Drawing.Size(244, 74);
            this.buttonViewOrder.TabIndex = 7;
            this.buttonViewOrder.Text = "Bekijk opgenomen items";
            this.buttonViewOrder.UseVisualStyleBackColor = true;
            this.buttonViewOrder.Click += new System.EventHandler(this.buttonViewOrder_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 640);
            this.Controls.Add(this.panelOrdered);
            this.Controls.Add(this.panelBestellen);
            this.Controls.Add(this.buttonDrankjes);
            this.Controls.Add(this.buttonViewOrder);
            this.Controls.Add(this.buttonNagerecht);
            this.Controls.Add(this.buttonBestel);
            this.Controls.Add(this.buttonHoofdgerecht);
            this.Controls.Add(this.buttonVoorgerecht);
            this.Controls.Add(this.buttonTerug);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panelBestellen.ResumeLayout(false);
            this.panelBestellen.PerformLayout();
            this.panelItemSelected.ResumeLayout(false);
            this.panelItemSelected.PerformLayout();
            this.panelViewOrder.ResumeLayout(false);
            this.panelViewOrder.PerformLayout();
            this.panelVerwijderenBestelling.ResumeLayout(false);
            this.panelVerwijderenBestelling.PerformLayout();
            this.panelOrdered.ResumeLayout(false);
            this.panelOrdered.PerformLayout();
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
        private System.Windows.Forms.Button buttonTerugBestelling;
        private System.Windows.Forms.ListView listViewGerechten;
        private System.Windows.Forms.Panel panelItemSelected;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxRemark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelSelectedItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Button buttonViewOrder;
        private System.Windows.Forms.Panel panelViewOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonTerugSelectedItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewViewOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Panel panelVerwijderenBestelling;
        private System.Windows.Forms.Button buttonNeeVerwijderen;
        private System.Windows.Forms.Button buttonJaVerwijderen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelNoItems;
        private System.Windows.Forms.Panel panelOrdered;
        private System.Windows.Forms.Button buttonOrderedOk;
        private System.Windows.Forms.Label labelBesteld;
    }
}