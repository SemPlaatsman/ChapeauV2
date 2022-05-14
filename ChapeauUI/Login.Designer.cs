
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
            this.labelNogGeenWNR = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxViewPIN = new System.Windows.Forms.CheckBox();
            this.buttonWachtwoordVergeten = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewNames = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(37, 419);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(118, 60);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelLoginWerknemersNummer
            // 
            this.labelLoginWerknemersNummer.AutoSize = true;
            this.labelLoginWerknemersNummer.Location = new System.Drawing.Point(37, 339);
            this.labelLoginWerknemersNummer.Name = "labelLoginWerknemersNummer";
            this.labelLoginWerknemersNummer.Size = new System.Drawing.Size(148, 20);
            this.labelLoginWerknemersNummer.TabIndex = 2;
            this.labelLoginWerknemersNummer.Text = "Werknemersnummer:";
            // 
            // labelLoginPIN
            // 
            this.labelLoginPIN.AutoSize = true;
            this.labelLoginPIN.Location = new System.Drawing.Point(37, 381);
            this.labelLoginPIN.Name = "labelLoginPIN";
            this.labelLoginPIN.Size = new System.Drawing.Size(32, 20);
            this.labelLoginPIN.TabIndex = 3;
            this.labelLoginPIN.Text = "Pin:";
            // 
            // textBoxLoginWerknemerNummer
            // 
            this.textBoxLoginWerknemerNummer.Location = new System.Drawing.Point(230, 339);
            this.textBoxLoginWerknemerNummer.Name = "textBoxLoginWerknemerNummer";
            this.textBoxLoginWerknemerNummer.Size = new System.Drawing.Size(151, 27);
            this.textBoxLoginWerknemerNummer.TabIndex = 5;
            // 
            // textBoxLoginPIN
            // 
            this.textBoxLoginPIN.Location = new System.Drawing.Point(230, 381);
            this.textBoxLoginPIN.Name = "textBoxLoginPIN";
            this.textBoxLoginPIN.PasswordChar = '*';
            this.textBoxLoginPIN.Size = new System.Drawing.Size(79, 27);
            this.textBoxLoginPIN.TabIndex = 6;
            // 
            // labelNogGeenWNR
            // 
            this.labelNogGeenWNR.AutoSize = true;
            this.labelNogGeenWNR.Location = new System.Drawing.Point(37, 618);
            this.labelNogGeenWNR.Name = "labelNogGeenWNR";
            this.labelNogGeenWNR.Size = new System.Drawing.Size(269, 20);
            this.labelNogGeenWNR.TabIndex = 7;
            this.labelNogGeenWNR.Text = "Heb je nog geen werknemersnummer? ";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(37, 651);
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
            this.panel1.Controls.Add(this.buttonWachtwoordVergeten);
            this.panel1.Location = new System.Drawing.Point(25, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 178);
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
            // buttonWachtwoordVergeten
            // 
            this.buttonWachtwoordVergeten.Location = new System.Drawing.Point(147, 109);
            this.buttonWachtwoordVergeten.Name = "buttonWachtwoordVergeten";
            this.buttonWachtwoordVergeten.Size = new System.Drawing.Size(118, 60);
            this.buttonWachtwoordVergeten.TabIndex = 11;
            this.buttonWachtwoordVergeten.Text = "Wachtwoord vergeten?";
            this.buttonWachtwoordVergeten.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(25, 594);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 108);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 509);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 193);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // listViewNames
            // 
            this.listViewNames.HideSelection = false;
            this.listViewNames.Location = new System.Drawing.Point(25, 22);
            this.listViewNames.Name = "listViewNames";
            this.listViewNames.Size = new System.Drawing.Size(586, 282);
            this.listViewNames.TabIndex = 13;
            this.listViewNames.UseCompatibleStateImageBehavior = false;
            this.listViewNames.Click += new System.EventHandler(this.listViewNames_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 714);
            this.Controls.Add(this.listViewNames);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelNogGeenWNR);
            this.Controls.Add(this.textBoxLoginPIN);
            this.Controls.Add(this.textBoxLoginWerknemerNummer);
            this.Controls.Add(this.labelLoginPIN);
            this.Controls.Add(this.labelLoginWerknemersNummer);
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
        private System.Windows.Forms.ListView listViewNames;
    }
}

