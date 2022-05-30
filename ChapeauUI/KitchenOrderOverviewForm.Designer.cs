
namespace ChapeauUI
{
    partial class KitchenOrderOverviewForm
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTerug
            // 
            this.buttonTerug.Location = new System.Drawing.Point(12, 382);
            this.buttonTerug.Name = "buttonTerug";
            this.buttonTerug.Size = new System.Drawing.Size(127, 56);
            this.buttonTerug.TabIndex = 0;
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
            this.dataGridViewOrderOverview.RowTemplate.Height = 25;
            this.dataGridViewOrderOverview.Size = new System.Drawing.Size(940, 364);
            this.dataGridViewOrderOverview.TabIndex = 1;
            this.dataGridViewOrderOverview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderOverview_CellValueChanged);
            this.dataGridViewOrderOverview.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewOrderOverview_CurrentCellDirtyStateChanged);
            // 
            // ColumnTijd
            // 
            this.ColumnTijd.DataPropertyName = "TimeOfOrder";
            this.ColumnTijd.HeaderText = "Tijd";
            this.ColumnTijd.Name = "ColumnTijd";
            // 
            // ColumnGerecht
            // 
            this.ColumnGerecht.DataPropertyName = "Gerecht";
            this.ColumnGerecht.HeaderText = "Gerecht";
            this.ColumnGerecht.Name = "ColumnGerecht";
            // 
            // ColumnType
            // 
            this.ColumnType.DataPropertyName = "Type";
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
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
            this.ColumnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnCurrentStatus
            // 
            this.ColumnCurrentStatus.HeaderText = "Huidige status";
            this.ColumnCurrentStatus.Name = "ColumnCurrentStatus";
            // 
            // ColumnCurrentServeerStatus
            // 
            this.ColumnCurrentServeerStatus.HeaderText = "Huidige serveer status";
            this.ColumnCurrentServeerStatus.Name = "ColumnCurrentServeerStatus";
            // 
            // KitchenOrderOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.dataGridViewOrderOverview);
            this.Controls.Add(this.buttonTerug);
            this.Name = "KitchenOrderOverviewForm";
            this.Text = "KitchenOrderOverviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTerug;
        private System.Windows.Forms.DataGridView dataGridViewOrderOverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGerecht;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCurrentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCurrentServeerStatus;
    }
}