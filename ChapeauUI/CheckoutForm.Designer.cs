
namespace ChapeauUI
{
    partial class CheckoutForm
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
            this.buttonBackToTableOverview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackToTableOverview
            // 
            this.buttonBackToTableOverview.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToTableOverview.Name = "buttonBackToTableOverview";
            this.buttonBackToTableOverview.Size = new System.Drawing.Size(134, 65);
            this.buttonBackToTableOverview.TabIndex = 0;
            this.buttonBackToTableOverview.Text = "Terug naar tafel overzicht";
            this.buttonBackToTableOverview.UseVisualStyleBackColor = true;
            this.buttonBackToTableOverview.Click += new System.EventHandler(this.buttonBackToTableOverview_Click);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackToTableOverview);
            this.Name = "CheckoutForm";
            this.Text = "CheckoutForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToTableOverview;
    }
}