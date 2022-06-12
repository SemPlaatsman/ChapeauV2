
namespace ChapeauUI
{
    partial class OrderOverviewForm
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
            this.dataGridViewOrderOverview = new System.Windows.Forms.DataGridView();
            this.ColumnTijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGerecht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnCurrentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCurrentServeerStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelGeheleOrder = new System.Windows.Forms.Label();
            this.buttonTypeStatus = new System.Windows.Forms.Button();
            this.buttonFullStatus = new System.Windows.Forms.Button();
            this.labelPerType = new System.Windows.Forms.Label();
            this.comBoxType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTerug
            // 
            this.buttonTerug.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTerug.Location = new System.Drawing.Point(12, 382);
            this.buttonTerug.Name = "buttonTerug";
            this.buttonTerug.Size = new System.Drawing.Size(127, 56);
            this.buttonTerug.TabIndex = 1;
            this.buttonTerug.Text = "Terug";
            this.buttonTerug.UseVisualStyleBackColor = true;
            this.buttonTerug.Click += new System.EventHandler(this.buttonTerug_Click);
            // 
            // dataGridViewOrderOverview
            // 
            this.dataGridViewOrderOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTijd,
            this.ColumnGerecht,
            this.ColumnType,
            this.ColumnStatus,
            this.ColumnCurrentStatus,
            this.ColumnCurrentServeerStatus});
            this.dataGridViewOrderOverview.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOrderOverview.Name = "dataGridViewOrderOverview";
            this.dataGridViewOrderOverview.ReadOnly = true;
            this.dataGridViewOrderOverview.RowTemplate.Height = 25;
            this.dataGridViewOrderOverview.Size = new System.Drawing.Size(940, 364);
            this.dataGridViewOrderOverview.TabIndex = 0;
            this.dataGridViewOrderOverview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderOverview_CellValueChanged);
            this.dataGridViewOrderOverview.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewOrderOverview_CurrentCellDirtyStateChanged);
            // 
            // ColumnTijd
            // 
            this.ColumnTijd.DataPropertyName = "TimeOfOrder";
            this.ColumnTijd.HeaderText = "Tijd";
            this.ColumnTijd.Name = "ColumnTijd";
            this.ColumnTijd.ReadOnly = true;
            this.ColumnTijd.Width = 50;
            // 
            // ColumnGerecht
            // 
            this.ColumnGerecht.DataPropertyName = "Gerecht";
            this.ColumnGerecht.HeaderText = "Gerecht";
            this.ColumnGerecht.Name = "ColumnGerecht";
            this.ColumnGerecht.ReadOnly = true;
            this.ColumnGerecht.Width = 380;
            // 
            // ColumnType
            // 
            this.ColumnType.DataPropertyName = "Type";
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.Width = 126;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.DataPropertyName = "Status";
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Items.AddRange(new object[] {
            "Moet Nog",
            "Mee Bezig",
            "Klaar"});
            this.ColumnStatus.MaxDropDownItems = 3;
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnStatus.Width = 120;
            // 
            // ColumnCurrentStatus
            // 
            this.ColumnCurrentStatus.HeaderText = "Huidige status";
            this.ColumnCurrentStatus.Name = "ColumnCurrentStatus";
            this.ColumnCurrentStatus.ReadOnly = true;
            this.ColumnCurrentStatus.Width = 110;
            // 
            // ColumnCurrentServeerStatus
            // 
            this.ColumnCurrentServeerStatus.HeaderText = "Huidige serveer status";
            this.ColumnCurrentServeerStatus.Name = "ColumnCurrentServeerStatus";
            this.ColumnCurrentServeerStatus.ReadOnly = true;
            this.ColumnCurrentServeerStatus.Width = 150;
            // 
            // labelGeheleOrder
            // 
            this.labelGeheleOrder.AutoSize = true;
            this.labelGeheleOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGeheleOrder.Location = new System.Drawing.Point(708, 400);
            this.labelGeheleOrder.Name = "labelGeheleOrder";
            this.labelGeheleOrder.Size = new System.Drawing.Size(103, 21);
            this.labelGeheleOrder.TabIndex = 5;
            this.labelGeheleOrder.Text = "Gehele order:";
            // 
            // buttonTypeStatus
            // 
            this.buttonTypeStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTypeStatus.Location = new System.Drawing.Point(444, 390);
            this.buttonTypeStatus.Name = "buttonTypeStatus";
            this.buttonTypeStatus.Size = new System.Drawing.Size(122, 40);
            this.buttonTypeStatus.TabIndex = 3;
            this.buttonTypeStatus.UseVisualStyleBackColor = true;
            this.buttonTypeStatus.Click += new System.EventHandler(this.buttonTypeStatus_Click);
            // 
            // buttonFullStatus
            // 
            this.buttonFullStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFullStatus.Location = new System.Drawing.Point(817, 391);
            this.buttonFullStatus.Name = "buttonFullStatus";
            this.buttonFullStatus.Size = new System.Drawing.Size(122, 40);
            this.buttonFullStatus.TabIndex = 4;
            this.buttonFullStatus.UseVisualStyleBackColor = true;
            this.buttonFullStatus.Click += new System.EventHandler(this.buttonFullStatus_Click);
            // 
            // labelPerType
            // 
            this.labelPerType.AutoSize = true;
            this.labelPerType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPerType.Location = new System.Drawing.Point(242, 400);
            this.labelPerType.Name = "labelPerType";
            this.labelPerType.Size = new System.Drawing.Size(69, 21);
            this.labelPerType.TabIndex = 6;
            this.labelPerType.Text = "Per type:";
            // 
            // comBoxType
            // 
            this.comBoxType.FormattingEnabled = true;
            this.comBoxType.Items.AddRange(new object[] {
            "Voorgerecht",
            "Tussengerecht",
            "Hoofdgerecht",
            "Nagerecht"});
            this.comBoxType.Location = new System.Drawing.Point(317, 400);
            this.comBoxType.Name = "comBoxType";
            this.comBoxType.Size = new System.Drawing.Size(121, 23);
            this.comBoxType.TabIndex = 7;
            this.comBoxType.SelectedIndexChanged += new System.EventHandler(this.comBoxType_SelectedIndexChanged);
            // 
            // OrderOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.comBoxType);
            this.Controls.Add(this.labelPerType);
            this.Controls.Add(this.buttonFullStatus);
            this.Controls.Add(this.buttonTypeStatus);
            this.Controls.Add(this.labelGeheleOrder);
            this.Controls.Add(this.dataGridViewOrderOverview);
            this.Controls.Add(this.buttonTerug);
            this.Name = "OrderOverviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderOverviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTerug;
        private System.Windows.Forms.DataGridView dataGridViewOrderOverview;
        private System.Windows.Forms.Label labelGeheleOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGerecht;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCurrentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCurrentServeerStatus;
        private System.Windows.Forms.Button buttonTypeStatus;
        private System.Windows.Forms.Button buttonFullStatus;
        private System.Windows.Forms.Label labelPerType;
        private System.Windows.Forms.ComboBox comBoxType;
    }
}