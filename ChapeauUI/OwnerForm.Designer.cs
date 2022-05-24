
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
            this.buttonNewEmployee.Location = new System.Drawing.Point(21, 381);
            this.buttonNewEmployee.Name = "buttonNewEmployee";
            this.buttonNewEmployee.Size = new System.Drawing.Size(207, 48);
            this.buttonNewEmployee.TabIndex = 0;
            this.buttonNewEmployee.Text = "Registreer nieuwe medewerker";
            this.buttonNewEmployee.UseVisualStyleBackColor = true;
            this.buttonNewEmployee.Click += new System.EventHandler(this.buttonNewEmployee_Click);
            // 
            // buttonBackToLogin
            // 
            this.buttonBackToLogin.Location = new System.Drawing.Point(678, 392);
            this.buttonBackToLogin.Name = "buttonBackToLogin";
            this.buttonBackToLogin.Size = new System.Drawing.Size(110, 46);
            this.buttonBackToLogin.TabIndex = 1;
            this.buttonBackToLogin.Text = "Uitloggen";
            this.buttonBackToLogin.UseVisualStyleBackColor = true;
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackToLogin);
            this.Controls.Add(this.buttonNewEmployee);
            this.Name = "OwnerForm";
            this.Text = "OwnerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewEmployee;
        private System.Windows.Forms.Button buttonBackToLogin;
    }
}