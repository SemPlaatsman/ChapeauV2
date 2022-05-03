
namespace ChapeauUI
{
    partial class RegisterForm
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
            this.labelWelkom = new System.Windows.Forms.Label();
            this.buttonBackToInlog = new System.Windows.Forms.Button();
            this.labelRegisterVoornaam = new System.Windows.Forms.Label();
            this.labelRegisterAchternaam = new System.Windows.Forms.Label();
            this.labelRegisterEmail = new System.Windows.Forms.Label();
            this.labelRegisterPhone = new System.Windows.Forms.Label();
            this.labelRegisterPin = new System.Windows.Forms.Label();
            this.labelRegisterPinRepeat = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelWelkom
            // 
            this.labelWelkom.AutoSize = true;
            this.labelWelkom.Location = new System.Drawing.Point(223, 31);
            this.labelWelkom.Name = "labelWelkom";
            this.labelWelkom.Size = new System.Drawing.Size(519, 60);
            this.labelWelkom.TabIndex = 0;
            this.labelWelkom.Text = "Welkom bij Chapeau. \r\nVul hieronder jouw gegevens in om een werknemersnummer te k" +
    "rijgen. \r\nVoor het wachtwoord moet je een pincode invullen bestaande uit vier ci" +
    "jfers. \r\n";
            // 
            // buttonBackToInlog
            // 
            this.buttonBackToInlog.Location = new System.Drawing.Point(32, 27);
            this.buttonBackToInlog.Name = "buttonBackToInlog";
            this.buttonBackToInlog.Size = new System.Drawing.Size(155, 29);
            this.buttonBackToInlog.TabIndex = 1;
            this.buttonBackToInlog.Text = "<- Terug naar inlog";
            this.buttonBackToInlog.UseVisualStyleBackColor = true;
            this.buttonBackToInlog.Click += new System.EventHandler(this.buttonBackToInlog_Click);
            // 
            // labelRegisterVoornaam
            // 
            this.labelRegisterVoornaam.AutoSize = true;
            this.labelRegisterVoornaam.Location = new System.Drawing.Point(107, 128);
            this.labelRegisterVoornaam.Name = "labelRegisterVoornaam";
            this.labelRegisterVoornaam.Size = new System.Drawing.Size(80, 20);
            this.labelRegisterVoornaam.TabIndex = 2;
            this.labelRegisterVoornaam.Text = "Voornaam:";
            // 
            // labelRegisterAchternaam
            // 
            this.labelRegisterAchternaam.AutoSize = true;
            this.labelRegisterAchternaam.Location = new System.Drawing.Point(95, 162);
            this.labelRegisterAchternaam.Name = "labelRegisterAchternaam";
            this.labelRegisterAchternaam.Size = new System.Drawing.Size(92, 20);
            this.labelRegisterAchternaam.TabIndex = 3;
            this.labelRegisterAchternaam.Text = "Achternaam:";
            // 
            // labelRegisterEmail
            // 
            this.labelRegisterEmail.AutoSize = true;
            this.labelRegisterEmail.Location = new System.Drawing.Point(98, 195);
            this.labelRegisterEmail.Name = "labelRegisterEmail";
            this.labelRegisterEmail.Size = new System.Drawing.Size(89, 20);
            this.labelRegisterEmail.TabIndex = 4;
            this.labelRegisterEmail.Text = "Email adres:";
            // 
            // labelRegisterPhone
            // 
            this.labelRegisterPhone.AutoSize = true;
            this.labelRegisterPhone.Location = new System.Drawing.Point(58, 229);
            this.labelRegisterPhone.Name = "labelRegisterPhone";
            this.labelRegisterPhone.Size = new System.Drawing.Size(129, 20);
            this.labelRegisterPhone.TabIndex = 5;
            this.labelRegisterPhone.Text = "Telefoon nummer:";
            // 
            // labelRegisterPin
            // 
            this.labelRegisterPin.AutoSize = true;
            this.labelRegisterPin.Location = new System.Drawing.Point(54, 263);
            this.labelRegisterPin.Name = "labelRegisterPin";
            this.labelRegisterPin.Size = new System.Drawing.Size(133, 20);
            this.labelRegisterPin.TabIndex = 6;
            this.labelRegisterPin.Text = "Wachtwoord (PIN):";
            // 
            // labelRegisterPinRepeat
            // 
            this.labelRegisterPinRepeat.AutoSize = true;
            this.labelRegisterPinRepeat.Location = new System.Drawing.Point(24, 300);
            this.labelRegisterPinRepeat.Name = "labelRegisterPinRepeat";
            this.labelRegisterPinRepeat.Size = new System.Drawing.Size(163, 20);
            this.labelRegisterPinRepeat.TabIndex = 7;
            this.labelRegisterPinRepeat.Text = "Herhaling wachtwoord:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(223, 355);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(113, 34);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Registeren";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "De combinatie van jouw werknemersnummer en pincode is belangrijk om in te loggen." +
    " \r\nSchrijf het ergens op, of onthoud het goed. ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 27);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 27);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(256, 27);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(223, 230);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(157, 27);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(223, 264);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(95, 27);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(223, 300);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(95, 27);
            this.textBox6.TabIndex = 15;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelRegisterPinRepeat);
            this.Controls.Add(this.labelRegisterPin);
            this.Controls.Add(this.labelRegisterPhone);
            this.Controls.Add(this.labelRegisterEmail);
            this.Controls.Add(this.labelRegisterAchternaam);
            this.Controls.Add(this.labelRegisterVoornaam);
            this.Controls.Add(this.buttonBackToInlog);
            this.Controls.Add(this.labelWelkom);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelkom;
        private System.Windows.Forms.Button buttonBackToInlog;
        private System.Windows.Forms.Label labelRegisterVoornaam;
        private System.Windows.Forms.Label labelRegisterAchternaam;
        private System.Windows.Forms.Label labelRegisterEmail;
        private System.Windows.Forms.Label labelRegisterPhone;
        private System.Windows.Forms.Label labelRegisterPin;
        private System.Windows.Forms.Label labelRegisterPinRepeat;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}