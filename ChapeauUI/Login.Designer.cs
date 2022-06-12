
namespace ChapeauUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelLoginWerknemersNummer = new System.Windows.Forms.Label();
            this.labelLoginPIN = new System.Windows.Forms.Label();
            this.textBoxLoginWerknemerNummer = new System.Windows.Forms.TextBox();
            this.textBoxLoginPIN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxViewPIN = new System.Windows.Forms.CheckBox();
            this.buttonWachtwoordVergeten = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewNames = new System.Windows.Forms.ListView();
            this.labelLoginError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(10, 115);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(103, 45);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelLoginWerknemersNummer
            // 
            this.labelLoginWerknemersNummer.AutoSize = true;
            this.labelLoginWerknemersNummer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoginWerknemersNummer.Location = new System.Drawing.Point(32, 515);
            this.labelLoginWerknemersNummer.Name = "labelLoginWerknemersNummer";
            this.labelLoginWerknemersNummer.Size = new System.Drawing.Size(161, 21);
            this.labelLoginWerknemersNummer.TabIndex = 2;
            this.labelLoginWerknemersNummer.Text = "Werknemersnummer:";
            // 
            // labelLoginPIN
            // 
            this.labelLoginPIN.AutoSize = true;
            this.labelLoginPIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoginPIN.Location = new System.Drawing.Point(32, 547);
            this.labelLoginPIN.Name = "labelLoginPIN";
            this.labelLoginPIN.Size = new System.Drawing.Size(35, 21);
            this.labelLoginPIN.TabIndex = 3;
            this.labelLoginPIN.Text = "Pin:";
            // 
            // textBoxLoginWerknemerNummer
            // 
            this.textBoxLoginWerknemerNummer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginWerknemerNummer.Location = new System.Drawing.Point(201, 515);
            this.textBoxLoginWerknemerNummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLoginWerknemerNummer.Name = "textBoxLoginWerknemerNummer";
            this.textBoxLoginWerknemerNummer.Size = new System.Drawing.Size(70, 29);
            this.textBoxLoginWerknemerNummer.TabIndex = 5;
            // 
            // textBoxLoginPIN
            // 
            this.textBoxLoginPIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginPIN.Location = new System.Drawing.Point(201, 547);
            this.textBoxLoginPIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLoginPIN.Name = "textBoxLoginPIN";
            this.textBoxLoginPIN.PasswordChar = '*';
            this.textBoxLoginPIN.Size = new System.Drawing.Size(70, 29);
            this.textBoxLoginPIN.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxViewPIN);
            this.panel1.Controls.Add(this.buttonWachtwoordVergeten);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Location = new System.Drawing.Point(22, 493);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 185);
            this.panel1.TabIndex = 9;
            // 
            // checkBoxViewPIN
            // 
            this.checkBoxViewPIN.AutoSize = true;
            this.checkBoxViewPIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxViewPIN.Location = new System.Drawing.Point(276, 55);
            this.checkBoxViewPIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxViewPIN.Name = "checkBoxViewPIN";
            this.checkBoxViewPIN.Size = new System.Drawing.Size(92, 25);
            this.checkBoxViewPIN.TabIndex = 0;
            this.checkBoxViewPIN.Text = "View PIN";
            this.checkBoxViewPIN.UseVisualStyleBackColor = true;
            this.checkBoxViewPIN.CheckedChanged += new System.EventHandler(this.checkBoxViewPIN_CheckedChanged);
            // 
            // buttonWachtwoordVergeten
            // 
            this.buttonWachtwoordVergeten.BackColor = System.Drawing.Color.White;
            this.buttonWachtwoordVergeten.Location = new System.Drawing.Point(119, 115);
            this.buttonWachtwoordVergeten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWachtwoordVergeten.Name = "buttonWachtwoordVergeten";
            this.buttonWachtwoordVergeten.Size = new System.Drawing.Size(103, 45);
            this.buttonWachtwoordVergeten.TabIndex = 11;
            this.buttonWachtwoordVergeten.Text = "Wachtwoord vergeten?";
            this.buttonWachtwoordVergeten.UseVisualStyleBackColor = false;
            this.buttonWachtwoordVergeten.Click += new System.EventHandler(this.buttonWachtwoordVergeten_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // listViewNames
            // 
            this.listViewNames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewNames.HideSelection = false;
            this.listViewNames.Location = new System.Drawing.Point(22, 165);
            this.listViewNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewNames.Name = "listViewNames";
            this.listViewNames.Size = new System.Drawing.Size(513, 324);
            this.listViewNames.TabIndex = 13;
            this.listViewNames.UseCompatibleStateImageBehavior = false;
            this.listViewNames.Click += new System.EventHandler(this.listViewNames_Click);
            // 
            // labelLoginError
            // 
            this.labelLoginError.AutoSize = true;
            this.labelLoginError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLoginError.ForeColor = System.Drawing.Color.Red;
            this.labelLoginError.Location = new System.Drawing.Point(32, 680);
            this.labelLoginError.Name = "labelLoginError";
            this.labelLoginError.Size = new System.Drawing.Size(0, 21);
            this.labelLoginError.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(560, 757);
            this.Controls.Add(this.labelLoginError);
            this.Controls.Add(this.listViewNames);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxLoginPIN);
            this.Controls.Add(this.textBoxLoginWerknemerNummer);
            this.Controls.Add(this.labelLoginPIN);
            this.Controls.Add(this.labelLoginWerknemersNummer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welkom bij Chapeau";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelLoginWerknemersNummer;
        private System.Windows.Forms.Label labelLoginPIN;
        private System.Windows.Forms.TextBox textBoxLoginWerknemerNummer;
        private System.Windows.Forms.TextBox textBoxLoginPIN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonWachtwoordVergeten;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxViewPIN;
        private System.Windows.Forms.ListView listViewNames;
        private System.Windows.Forms.Label labelLoginError;
    }
}

