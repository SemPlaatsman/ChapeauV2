
namespace ChapeauUI
{
    partial class KitchenDisplay
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnOrderId = new System.Windows.Forms.ColumnHeader();
            this.columnTableId = new System.Windows.Forms.ColumnHeader();
            this.ColumnBestellingen = new System.Windows.Forms.ColumnHeader();
            this.listViewDone = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrderId,
            this.columnTableId,
            this.ColumnBestellingen});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(154, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(365, 612);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnOrderId
            // 
            this.columnOrderId.Text = "Order Id";
            // 
            // columnTableId
            // 
            this.columnTableId.Text = "Table Id";
            // 
            // ColumnBestellingen
            // 
            this.ColumnBestellingen.Text = "Bestellingen";
            // 
            // listViewDone
            // 
            this.listViewDone.HideSelection = false;
            this.listViewDone.Location = new System.Drawing.Point(801, 12);
            this.listViewDone.Name = "listViewDone";
            this.listViewDone.Size = new System.Drawing.Size(371, 612);
            this.listViewDone.TabIndex = 2;
            this.listViewDone.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(525, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 631);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // KitchenDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listViewDone);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "KitchenDisplay";
            this.Text = "KitchenDisplay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnOrderId;
        private System.Windows.Forms.ColumnHeader columnTableId;
        private System.Windows.Forms.ColumnHeader ColumnBestellingen;
        private System.Windows.Forms.ListView listViewDone;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}