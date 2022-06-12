
namespace ChapeauUI
{
    partial class BarDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarDisplay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMoetNog = new System.Windows.Forms.Label();
            this.lblOverzicht = new System.Windows.Forms.Label();
            this.lblMeeBezig = new System.Windows.Forms.Label();
            this.buttonUitloggen = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewMoetNog = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutMeeBezig = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewOverzicht = new System.Windows.Forms.DataGridView();
            this.ColumnOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDrinken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoetNog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverzicht)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMoetNog
            // 
            this.lblMoetNog.AutoSize = true;
            this.lblMoetNog.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMoetNog.Location = new System.Drawing.Point(12, 9);
            this.lblMoetNog.Name = "lblMoetNog";
            this.lblMoetNog.Size = new System.Drawing.Size(140, 37);
            this.lblMoetNog.TabIndex = 5;
            this.lblMoetNog.Text = "Moet nog:";
            // 
            // lblOverzicht
            // 
            this.lblOverzicht.AutoSize = true;
            this.lblOverzicht.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOverzicht.Location = new System.Drawing.Point(1180, 9);
            this.lblOverzicht.Name = "lblOverzicht";
            this.lblOverzicht.Size = new System.Drawing.Size(134, 37);
            this.lblOverzicht.TabIndex = 9;
            this.lblOverzicht.Text = "Overzicht:";
            // 
            // lblMeeBezig
            // 
            this.lblMeeBezig.AutoSize = true;
            this.lblMeeBezig.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeeBezig.Location = new System.Drawing.Point(618, 9);
            this.lblMeeBezig.Name = "lblMeeBezig";
            this.lblMeeBezig.Size = new System.Drawing.Size(147, 37);
            this.lblMeeBezig.TabIndex = 10;
            this.lblMeeBezig.Text = "Mee bezig:";
            // 
            // buttonUitloggen
            // 
            this.buttonUitloggen.BackColor = System.Drawing.Color.White;
            this.buttonUitloggen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUitloggen.Image = ((System.Drawing.Image)(resources.GetObject("buttonUitloggen.Image")));
            this.buttonUitloggen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUitloggen.Location = new System.Drawing.Point(12, 775);
            this.buttonUitloggen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUitloggen.Name = "buttonUitloggen";
            this.buttonUitloggen.Size = new System.Drawing.Size(221, 75);
            this.buttonUitloggen.TabIndex = 33;
            this.buttonUitloggen.Text = "       Uitloggen";
            this.buttonUitloggen.UseVisualStyleBackColor = false;
            this.buttonUitloggen.Click += new System.EventHandler(this.buttonUitloggen_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.White;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.Location = new System.Drawing.Point(12, 682);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(221, 75);
            this.buttonUpdate.TabIndex = 34;
            this.buttonUpdate.Text = "           Update orders";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewMoetNog
            // 
            this.dataGridViewMoetNog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoetNog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ColumnTijd,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1});
            this.dataGridViewMoetNog.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewMoetNog.Name = "dataGridViewMoetNog";
            this.dataGridViewMoetNog.RowTemplate.Height = 25;
            this.dataGridViewMoetNog.Size = new System.Drawing.Size(600, 612);
            this.dataGridViewMoetNog.TabIndex = 35;
            this.dataGridViewMoetNog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMoetNog_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Order";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 42;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tafel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 38;
            // 
            // ColumnTijd
            // 
            this.ColumnTijd.HeaderText = "Tijd";
            this.ColumnTijd.Name = "ColumnTijd";
            this.ColumnTijd.ReadOnly = true;
            this.ColumnTijd.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Bestellingen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 380;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Verwerk";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "";
            this.dataGridViewButtonColumn1.Width = 80;
            // 
            // flowLayoutMeeBezig
            // 
            this.flowLayoutMeeBezig.AutoScroll = true;
            this.flowLayoutMeeBezig.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutMeeBezig.Location = new System.Drawing.Point(618, 52);
            this.flowLayoutMeeBezig.Name = "flowLayoutMeeBezig";
            this.flowLayoutMeeBezig.Size = new System.Drawing.Size(556, 612);
            this.flowLayoutMeeBezig.TabIndex = 36;
            this.flowLayoutMeeBezig.WrapContents = false;
            // 
            // dataGridViewOverzicht
            // 
            this.dataGridViewOverzicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOverzicht.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOrder,
            this.ColumnTable,
            this.ColumnDrinken,
            this.ColumnOpen});
            this.dataGridViewOverzicht.Location = new System.Drawing.Point(1180, 52);
            this.dataGridViewOverzicht.Name = "dataGridViewOverzicht";
            this.dataGridViewOverzicht.RowTemplate.Height = 25;
            this.dataGridViewOverzicht.Size = new System.Drawing.Size(400, 612);
            this.dataGridViewOverzicht.TabIndex = 37;
            this.dataGridViewOverzicht.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOverzicht_CellContentClick);
            // 
            // ColumnOrder
            // 
            this.ColumnOrder.HeaderText = "Order";
            this.ColumnOrder.Name = "ColumnOrder";
            this.ColumnOrder.ReadOnly = true;
            this.ColumnOrder.Width = 42;
            // 
            // ColumnTable
            // 
            this.ColumnTable.HeaderText = "Tafel";
            this.ColumnTable.Name = "ColumnTable";
            this.ColumnTable.ReadOnly = true;
            this.ColumnTable.Width = 38;
            // 
            // ColumnDrinken
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnDrinken.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnDrinken.HeaderText = "Drinken";
            this.ColumnDrinken.Name = "ColumnDrinken";
            this.ColumnDrinken.ReadOnly = true;
            this.ColumnDrinken.Width = 59;
            // 
            // ColumnOpen
            // 
            this.ColumnOpen.HeaderText = "Open overzicht";
            this.ColumnOpen.Name = "ColumnOpen";
            this.ColumnOpen.Width = 64;
            // 
            // BarDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.dataGridViewOverzicht);
            this.Controls.Add(this.flowLayoutMeeBezig);
            this.Controls.Add(this.dataGridViewMoetNog);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonUitloggen);
            this.Controls.Add(this.lblMeeBezig);
            this.Controls.Add(this.lblOverzicht);
            this.Controls.Add(this.lblMoetNog);
            this.Name = "BarDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BarDisplay_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoetNog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverzicht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMoetNog;
        private System.Windows.Forms.Label lblOverzicht;
        private System.Windows.Forms.Label lblMeeBezig;
        private System.Windows.Forms.Button buttonUitloggen;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewMoetNog;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMeeBezig;
        private System.Windows.Forms.DataGridView dataGridViewOverzicht;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDrinken;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnOpen;
    }
}