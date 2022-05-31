
namespace ChapeauUI
{
    partial class TableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.checkBoxTable = new System.Windows.Forms.CheckBox();
            this.labelCurrentEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(38, 571);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 60);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Terug";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.BackColor = System.Drawing.Color.White;
            this.buttonNewOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNewOrder.Location = new System.Drawing.Point(199, 571);
            this.buttonNewOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(100, 60);
            this.buttonNewOrder.TabIndex = 1;
            this.buttonNewOrder.Text = "Nieuwe bestelling";
            this.buttonNewOrder.UseVisualStyleBackColor = false;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.BackColor = System.Drawing.Color.White;
            this.buttonCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCheckout.Location = new System.Drawing.Point(360, 571);
            this.buttonCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(100, 60);
            this.buttonCheckout.TabIndex = 3;
            this.buttonCheckout.Text = "Afrekenen";
            this.buttonCheckout.UseVisualStyleBackColor = false;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 99);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.SystemColors.Control;
            this.labelStatus.Location = new System.Drawing.Point(38, 157);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(45, 15);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status: ";
            // 
            // listViewOrder
            // 
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(38, 186);
            this.listViewOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(422, 356);
            this.listViewOrder.TabIndex = 6;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            // 
            // checkBoxTable
            // 
            this.checkBoxTable.AutoSize = true;
            this.checkBoxTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTable.Location = new System.Drawing.Point(174, 60);
            this.checkBoxTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxTable.Name = "checkBoxTable";
            this.checkBoxTable.Size = new System.Drawing.Size(66, 25);
            this.checkBoxTable.TabIndex = 7;
            this.checkBoxTable.Text = "Bezet";
            this.checkBoxTable.UseVisualStyleBackColor = true;
            this.checkBoxTable.CheckedChanged += new System.EventHandler(this.checkBoxTable_CheckedChanged);
            // 
            // labelCurrentEmployee
            // 
            this.labelCurrentEmployee.AutoSize = true;
            this.labelCurrentEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentEmployee.Location = new System.Drawing.Point(276, 61);
            this.labelCurrentEmployee.Name = "labelCurrentEmployee";
            this.labelCurrentEmployee.Size = new System.Drawing.Size(137, 42);
            this.labelCurrentEmployee.TabIndex = 8;
            this.labelCurrentEmployee.Text = "Geen medewerker\r\ngekoppeld";
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(513, 663);
            this.Controls.Add(this.labelCurrentEmployee);
            this.Controls.Add(this.checkBoxTable);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonNewOrder);
            this.Controls.Add(this.buttonBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TableForm";
            this.Text = "TableForm";
            this.Load += new System.EventHandler(this.TableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNewOrder;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.CheckBox checkBoxTable;
        private System.Windows.Forms.Label labelCurrentEmployee;
    }
}