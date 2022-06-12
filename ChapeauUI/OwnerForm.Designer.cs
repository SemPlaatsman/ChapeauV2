
namespace ChapeauUI
{
    partial class OwnerForm
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
            this.buttonNewEmployee = new System.Windows.Forms.Button();
            this.buttonBackToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewEmployee
            // 
            this.buttonNewEmployee.BackColor = System.Drawing.Color.White;
            this.buttonNewEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNewEmployee.Location = new System.Drawing.Point(12, 669);
            this.buttonNewEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNewEmployee.Name = "buttonNewEmployee";
            this.buttonNewEmployee.Size = new System.Drawing.Size(181, 61);
            this.buttonNewEmployee.TabIndex = 0;
            this.buttonNewEmployee.Text = "Registreer nieuwe medewerker";
            this.buttonNewEmployee.UseVisualStyleBackColor = false;
            this.buttonNewEmployee.Click += new System.EventHandler(this.buttonNewEmployee_Click);
            // 
            // buttonBackToLogin
            // 
            this.buttonBackToLogin.BackColor = System.Drawing.Color.White;
            this.buttonBackToLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackToLogin.Location = new System.Drawing.Point(376, 669);
            this.buttonBackToLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBackToLogin.Name = "buttonBackToLogin";
            this.buttonBackToLogin.Size = new System.Drawing.Size(140, 61);
            this.buttonBackToLogin.TabIndex = 1;
            this.buttonBackToLogin.Text = "Uitloggen";
            this.buttonBackToLogin.UseVisualStyleBackColor = false;
            this.buttonBackToLogin.Click += new System.EventHandler(this.buttonBackToLogin_Click);
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(560, 757);
            this.Controls.Add(this.buttonBackToLogin);
            this.Controls.Add(this.buttonNewEmployee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OwnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewEmployee;
        private System.Windows.Forms.Button buttonBackToLogin;
    }
}