
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(830, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 400);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(734, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gehele order:";
            // 
            // KitchenOrderOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewOrderOverview);
            this.Controls.Add(this.buttonTerug);
            this.Name = "KitchenOrderOverviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitchenOrderOverviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}