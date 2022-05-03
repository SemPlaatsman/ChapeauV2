
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
            this.labelLogin1 = new System.Windows.Forms.Label();
            this.labelLoginWerknemersNummer = new System.Windows.Forms.Label();
            this.labelLoginPIN = new System.Windows.Forms.Label();
            this.textBoxLoginWerknemerNummer = new System.Windows.Forms.TextBox();
            this.textBoxLoginPIN = new System.Windows.Forms.TextBox();
            this.labelNogGeenWNR = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxViewPIN = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonWachtwoordVergeten = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(57, 176);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(109, 29);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // labelLogin1
            // 
            this.labelLogin1.AutoSize = true;
            this.labelLogin1.Location = new System.Drawing.Point(45, 32);
            this.labelLogin1.Name = "labelLogin1";
            this.labelLogin1.Size = new System.Drawing.Size(406, 20);
            this.labelLogin1.TabIndex = 1;
            this.labelLogin1.Text = "Voer hieronder jouw werknemersnummer en wachtwoord in.";
            // 
            // labelLoginWerknemersNummer
            // 
            this.labelLoginWerknemersNummer.AutoSize = true;
            this.labelLoginWerknemersNummer.Location = new System.Drawing.Point(57, 96);
            this.labelLoginWerknemersNummer.Name = "labelLoginWerknemersNummer";
            this.labelLoginWerknemersNummer.Size = new System.Drawing.Size(148, 20);
            this.labelLoginWerknemersNummer.TabIndex = 2;
            this.labelLoginWerknemersNummer.Text = "Werknemersnummer:";
            // 
            // labelLoginPIN
            // 
            this.labelLoginPIN.AutoSize = true;
            this.labelLoginPIN.Location = new System.Drawing.Point(57, 138);
            this.labelLoginPIN.Name = "labelLoginPIN";
            this.labelLoginPIN.Size = new System.Drawing.Size(32, 20);
            this.labelLoginPIN.TabIndex = 3;
            this.labelLoginPIN.Text = "Pin:";
            // 
            // textBoxLoginWerknemerNummer
            // 
            this.textBoxLoginWerknemerNummer.Location = new System.Drawing.Point(250, 96);
            this.textBoxLoginWerknemerNummer.Name = "textBoxLoginWerknemerNummer";
            this.textBoxLoginWerknemerNummer.Size = new System.Drawing.Size(154, 27);
            this.textBoxLoginWerknemerNummer.TabIndex = 5;
            // 
            // textBoxLoginPIN
            // 
            this.textBoxLoginPIN.Location = new System.Drawing.Point(250, 138);
            this.textBoxLoginPIN.Name = "textBoxLoginPIN";
            this.textBoxLoginPIN.PasswordChar = '*';
            this.textBoxLoginPIN.Size = new System.Drawing.Size(82, 27);
            this.textBoxLoginPIN.TabIndex = 6;
            // 
            // labelNogGeenWNR
            // 
            this.labelNogGeenWNR.AutoSize = true;
            this.labelNogGeenWNR.Location = new System.Drawing.Point(57, 253);
            this.labelNogGeenWNR.Name = "labelNogGeenWNR";
            this.labelNogGeenWNR.Size = new System.Drawing.Size(269, 20);
            this.labelNogGeenWNR.TabIndex = 7;
            this.labelNogGeenWNR.Text = "Heb je nog geen werknemersnummer? ";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(57, 286);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(109, 29);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Registreren";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxViewPIN);
            this.panel1.Location = new System.Drawing.Point(45, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 147);
            this.panel1.TabIndex = 9;
            // 
            // checkBoxViewPIN
            // 
            this.checkBoxViewPIN.AutoSize = true;
            this.checkBoxViewPIN.Location = new System.Drawing.Point(316, 73);
            this.checkBoxViewPIN.Name = "checkBoxViewPIN";
            this.checkBoxViewPIN.Size = new System.Drawing.Size(90, 24);
            this.checkBoxViewPIN.TabIndex = 0;
            this.checkBoxViewPIN.Text = "View PIN";
            this.checkBoxViewPIN.UseVisualStyleBackColor = true;
            this.checkBoxViewPIN.CheckedChanged += new System.EventHandler(this.checkBoxViewPIN_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(45, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 108);
            this.panel2.TabIndex = 10;
            // 
            // buttonWachtwoordVergeten
            // 
            this.buttonWachtwoordVergeten.Location = new System.Drawing.Point(57, 405);
            this.buttonWachtwoordVergeten.Name = "buttonWachtwoordVergeten";
            this.buttonWachtwoordVergeten.Size = new System.Drawing.Size(147, 57);
            this.buttonWachtwoordVergeten.TabIndex = 11;
            this.buttonWachtwoordVergeten.Text = "Wachtwoord vergeten?";
            this.buttonWachtwoordVergeten.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 193);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonWachtwoordVergeten);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelNogGeenWNR);
            this.Controls.Add(this.textBoxLoginPIN);
            this.Controls.Add(this.textBoxLoginWerknemerNummer);
            this.Controls.Add(this.labelLoginPIN);
            this.Controls.Add(this.labelLoginWerknemersNummer);
            this.Controls.Add(this.labelLogin1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Welkom bij Chapeau";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelLogin1;
        private System.Windows.Forms.Label labelLoginWerknemersNummer;
        private System.Windows.Forms.Label labelLoginPIN;
        private System.Windows.Forms.TextBox textBoxLoginWerknemerNummer;
        private System.Windows.Forms.TextBox textBoxLoginPIN;
        private System.Windows.Forms.Label labelNogGeenWNR;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonWachtwoordVergeten;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxViewPIN;
    }
}

