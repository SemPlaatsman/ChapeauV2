
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
            this.flowLayoutMeeBezig = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewMoetNog = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblMoetNog = new System.Windows.Forms.Label();
            this.lblMeeBezig = new System.Windows.Forms.Label();
            this.lblOverzicht = new System.Windows.Forms.Label();
            this.dataGridViewOverzicht = new System.Windows.Forms.DataGridView();
            this.ColumnOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVoorgerechten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTussengerechten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHoofdgerechten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNagerechten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoetNog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverzicht)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutMeeBezig
            // 
            this.flowLayoutMeeBezig.Location = new System.Drawing.Point(618, 52);
            this.flowLayoutMeeBezig.Name = "flowLayoutMeeBezig";
            this.flowLayoutMeeBezig.Size = new System.Drawing.Size(556, 612);
            this.flowLayoutMeeBezig.TabIndex = 1;
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
            this.dataGridViewMoetNog.TabIndex = 3;
            this.dataGridViewMoetNog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMoetNog_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Order";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tafel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // ColumnTijd
            // 
            this.ColumnTijd.HeaderText = "Tijd";
            this.ColumnTijd.Name = "ColumnTijd";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Bestellingen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 458;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Verwerk";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "";
            this.dataGridViewButtonColumn1.Width = 80;
            // 
            // lblMoetNog
            // 
            this.lblMoetNog.AutoSize = true;
            this.lblMoetNog.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMoetNog.Location = new System.Drawing.Point(12, 9);
            this.lblMoetNog.Name = "lblMoetNog";
            this.lblMoetNog.Size = new System.Drawing.Size(140, 37);
            this.lblMoetNog.TabIndex = 4;
            this.lblMoetNog.Text = "Moet nog:";
            // 
            // lblMeeBezig
            // 
            this.lblMeeBezig.AutoSize = true;
            this.lblMeeBezig.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeeBezig.Location = new System.Drawing.Point(618, 9);
            this.lblMeeBezig.Name = "lblMeeBezig";
            this.lblMeeBezig.Size = new System.Drawing.Size(147, 37);
            this.lblMeeBezig.TabIndex = 5;
            this.lblMeeBezig.Text = "Mee bezig:";
            // 
            // lblOverzicht
            // 
            this.lblOverzicht.AutoSize = true;
            this.lblOverzicht.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOverzicht.Location = new System.Drawing.Point(1180, 9);
            this.lblOverzicht.Name = "lblOverzicht";
            this.lblOverzicht.Size = new System.Drawing.Size(134, 37);
            this.lblOverzicht.TabIndex = 6;
            this.lblOverzicht.Text = "Overzicht:";
            // 
            // dataGridViewOverzicht
            // 
            this.dataGridViewOverzicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOverzicht.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOrder,
            this.ColumnTable,
            this.ColumnVoorgerechten,
            this.ColumnTussengerechten,
            this.ColumnHoofdgerechten,
            this.ColumnNagerechten});
            this.dataGridViewOverzicht.Location = new System.Drawing.Point(1180, 52);
            this.dataGridViewOverzicht.Name = "dataGridViewOverzicht";
            this.dataGridViewOverzicht.RowTemplate.Height = 25;
            this.dataGridViewOverzicht.Size = new System.Drawing.Size(400, 612);
            this.dataGridViewOverzicht.TabIndex = 7;
            // 
            // ColumnOrder
            // 
            this.ColumnOrder.HeaderText = "Order";
            this.ColumnOrder.Name = "ColumnOrder";
            // 
            // ColumnTable
            // 
            this.ColumnTable.HeaderText = "Tafel";
            this.ColumnTable.Name = "ColumnTable";
            // 
            // ColumnVoorgerechten
            // 
            this.ColumnVoorgerechten.HeaderText = "Voorgerechten";
            this.ColumnVoorgerechten.Name = "ColumnVoorgerechten";
            // 
            // ColumnTussengerechten
            // 
            this.ColumnTussengerechten.HeaderText = "Tussengerechten";
            this.ColumnTussengerechten.Name = "ColumnTussengerechten";
            // 
            // ColumnHoofdgerechten
            // 
            this.ColumnHoofdgerechten.HeaderText = "Hoofdgerechten";
            this.ColumnHoofdgerechten.Name = "ColumnHoofdgerechten";
            // 
            // ColumnNagerechten
            // 
            this.ColumnNagerechten.HeaderText = "Nagerechten";
            this.ColumnNagerechten.Name = "ColumnNagerechten";
            // 
            // KitchenDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.dataGridViewOverzicht);
            this.Controls.Add(this.lblOverzicht);
            this.Controls.Add(this.lblMeeBezig);
            this.Controls.Add(this.lblMoetNog);
            this.Controls.Add(this.dataGridViewMoetNog);
            this.Controls.Add(this.flowLayoutMeeBezig);
            this.Controls.Add(this.button1);
            this.Name = "KitchenDisplay";
            this.Text = "KitchenDisplay";
            //this.Load += new System.EventHandler(this.KitchenDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoetNog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverzicht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMeeBezig;
        private System.Windows.Forms.DataGridView dataGridViewMoetNog;
        private System.Windows.Forms.Label lblMoetNog;
        private System.Windows.Forms.Label lblMeeBezig;
        private System.Windows.Forms.Label lblOverzicht;
        private System.Windows.Forms.DataGridView dataGridViewOverzicht;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVoorgerechten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTussengerechten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHoofdgerechten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNagerechten;
    }
}