
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
            this.buttonBackToOwner = new System.Windows.Forms.Button();
            this.labelRegisterVoornaam = new System.Windows.Forms.Label();
            this.labelRegisterEmail = new System.Windows.Forms.Label();
            this.labelRegisterPhone = new System.Windows.Forms.Label();
            this.labelRegisterPin = new System.Windows.Forms.Label();
            this.labelRegisterPinRepeat = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelComboniatie = new System.Windows.Forms.Label();
            this.textBoxRegisterFirstname = new System.Windows.Forms.TextBox();
            this.textBoxRegisterLastname = new System.Windows.Forms.TextBox();
            this.textBoxRegisterEmail = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPIN = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPINRepeat = new System.Windows.Forms.TextBox();
            this.checkBoxPIN = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRegisterJob = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVraag = new System.Windows.Forms.Label();
            this.labelAntwoord = new System.Windows.Forms.Label();
            this.textBoxRegisterQuestion = new System.Windows.Forms.TextBox();
            this.textBoxRegisterAnswer = new System.Windows.Forms.TextBox();
            this.labelGeboorte = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelWelkom
            // 
            this.labelWelkom.AutoSize = true;
            this.labelWelkom.Location = new System.Drawing.Point(223, 31);
            this.labelWelkom.Name = "labelWelkom";
            this.labelWelkom.Size = new System.Drawing.Size(381, 60);
            this.labelWelkom.TabIndex = 0;
            this.labelWelkom.Text = "Vul hieronder de gegevens in van de nieuwe werknemer.\r\nDe pincode bestaat uit vie" +
    "r cijfers. \r\nAlle velden zijn verplicht in te vullen.\r\n";
            // 
            // buttonBackToOwner
            // 
            this.buttonBackToOwner.Location = new System.Drawing.Point(32, 27);
            this.buttonBackToOwner.Name = "buttonBackToOwner";
            this.buttonBackToOwner.Size = new System.Drawing.Size(105, 29);
            this.buttonBackToOwner.TabIndex = 1;
            this.buttonBackToOwner.Text = "<- Terug";
            this.buttonBackToOwner.UseVisualStyleBackColor = true;
            this.buttonBackToOwner.Click += new System.EventHandler(this.buttonBackToInlog_Click);
            // 
            // labelRegisterVoornaam
            // 
            this.labelRegisterVoornaam.AutoSize = true;
            this.labelRegisterVoornaam.Location = new System.Drawing.Point(36, 99);
            this.labelRegisterVoornaam.Name = "labelRegisterVoornaam";
            this.labelRegisterVoornaam.Size = new System.Drawing.Size(151, 20);
            this.labelRegisterVoornaam.TabIndex = 2;
            this.labelRegisterVoornaam.Text = "Voor- en achternaam:";
            // 
            // labelRegisterEmail
            // 
            this.labelRegisterEmail.AutoSize = true;
            this.labelRegisterEmail.Location = new System.Drawing.Point(98, 165);
            this.labelRegisterEmail.Name = "labelRegisterEmail";
            this.labelRegisterEmail.Size = new System.Drawing.Size(89, 20);
            this.labelRegisterEmail.TabIndex = 4;
            this.labelRegisterEmail.Text = "Email adres:";
            // 
            // labelRegisterPhone
            // 
            this.labelRegisterPhone.AutoSize = true;
            this.labelRegisterPhone.Location = new System.Drawing.Point(58, 199);
            this.labelRegisterPhone.Name = "labelRegisterPhone";
            this.labelRegisterPhone.Size = new System.Drawing.Size(129, 20);
            this.labelRegisterPhone.TabIndex = 5;
            this.labelRegisterPhone.Text = "Telefoon nummer:";
            // 
            // labelRegisterPin
            // 
            this.labelRegisterPin.AutoSize = true;
            this.labelRegisterPin.Location = new System.Drawing.Point(54, 267);
            this.labelRegisterPin.Name = "labelRegisterPin";
            this.labelRegisterPin.Size = new System.Drawing.Size(133, 20);
            this.labelRegisterPin.TabIndex = 6;
            this.labelRegisterPin.Text = "Wachtwoord (PIN):";
            // 
            // labelRegisterPinRepeat
            // 
            this.labelRegisterPinRepeat.AutoSize = true;
            this.labelRegisterPinRepeat.Location = new System.Drawing.Point(24, 304);
            this.labelRegisterPinRepeat.Name = "labelRegisterPinRepeat";
            this.labelRegisterPinRepeat.Size = new System.Drawing.Size(163, 20);
            this.labelRegisterPinRepeat.TabIndex = 7;
            this.labelRegisterPinRepeat.Text = "Herhaling wachtwoord:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(223, 518);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(113, 34);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Registeren";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelComboniatie
            // 
            this.labelComboniatie.AutoSize = true;
            this.labelComboniatie.Location = new System.Drawing.Point(155, 566);
            this.labelComboniatie.Name = "labelComboniatie";
            this.labelComboniatie.Size = new System.Drawing.Size(587, 40);
            this.labelComboniatie.TabIndex = 9;
            this.labelComboniatie.Text = "De combinatie van jouw werknemersnummer en pincode is belangrijk om in te loggen." +
    " \r\nSchrijf het ergens op, of onthoud het goed. ";
            // 
            // textBoxRegisterFirstname
            // 
            this.textBoxRegisterFirstname.Location = new System.Drawing.Point(223, 99);
            this.textBoxRegisterFirstname.Name = "textBoxRegisterFirstname";
            this.textBoxRegisterFirstname.Size = new System.Drawing.Size(157, 27);
            this.textBoxRegisterFirstname.TabIndex = 10;
            // 
            // textBoxRegisterLastname
            // 
            this.textBoxRegisterLastname.Location = new System.Drawing.Point(386, 99);
            this.textBoxRegisterLastname.Name = "textBoxRegisterLastname";
            this.textBoxRegisterLastname.Size = new System.Drawing.Size(157, 27);
            this.textBoxRegisterLastname.TabIndex = 11;
            // 
            // textBoxRegisterEmail
            // 
            this.textBoxRegisterEmail.Location = new System.Drawing.Point(223, 166);
            this.textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            this.textBoxRegisterEmail.Size = new System.Drawing.Size(256, 27);
            this.textBoxRegisterEmail.TabIndex = 12;
            // 
            // textBoxRegisterPhoneNumber
            // 
            this.textBoxRegisterPhoneNumber.Location = new System.Drawing.Point(223, 200);
            this.textBoxRegisterPhoneNumber.Name = "textBoxRegisterPhoneNumber";
            this.textBoxRegisterPhoneNumber.Size = new System.Drawing.Size(157, 27);
            this.textBoxRegisterPhoneNumber.TabIndex = 13;
            // 
            // textBoxRegisterPIN
            // 
            this.textBoxRegisterPIN.Location = new System.Drawing.Point(223, 268);
            this.textBoxRegisterPIN.Name = "textBoxRegisterPIN";
            this.textBoxRegisterPIN.PasswordChar = '*';
            this.textBoxRegisterPIN.Size = new System.Drawing.Size(95, 27);
            this.textBoxRegisterPIN.TabIndex = 14;
            // 
            // textBoxRegisterPINRepeat
            // 
            this.textBoxRegisterPINRepeat.Location = new System.Drawing.Point(223, 304);
            this.textBoxRegisterPINRepeat.Name = "textBoxRegisterPINRepeat";
            this.textBoxRegisterPINRepeat.PasswordChar = '*';
            this.textBoxRegisterPINRepeat.Size = new System.Drawing.Size(95, 27);
            this.textBoxRegisterPINRepeat.TabIndex = 15;
            // 
            // checkBoxPIN
            // 
            this.checkBoxPIN.AutoSize = true;
            this.checkBoxPIN.Location = new System.Drawing.Point(378, 271);
            this.checkBoxPIN.Name = "checkBoxPIN";
            this.checkBoxPIN.Size = new System.Drawing.Size(90, 24);
            this.checkBoxPIN.TabIndex = 16;
            this.checkBoxPIN.Text = "View PIN";
            this.checkBoxPIN.UseVisualStyleBackColor = true;
            this.checkBoxPIN.CheckedChanged += new System.EventHandler(this.checkBoxPIN_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gaat werken als:";
            // 
            // comboBoxRegisterJob
            // 
            this.comboBoxRegisterJob.FormattingEnabled = true;
            this.comboBoxRegisterJob.Items.AddRange(new object[] {
            "Chef",
            "Serveerster",
            "Bartender",
            "Eigenaar"});
            this.comboBoxRegisterJob.Location = new System.Drawing.Point(223, 234);
            this.comboBoxRegisterJob.Name = "comboBoxRegisterJob";
            this.comboBoxRegisterJob.Size = new System.Drawing.Size(157, 28);
            this.comboBoxRegisterJob.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 60);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mocht je in de toekomst je wachtwoord toch vergeten, \r\ndan kunnen we een nieuw wa" +
    "chtwoord voor je instellen d.m.v. \r\neen vraag en een antwoord. Deze mag je zelf " +
    "verzinnen";
            // 
            // labelVraag
            // 
            this.labelVraag.AutoSize = true;
            this.labelVraag.Location = new System.Drawing.Point(137, 438);
            this.labelVraag.Name = "labelVraag";
            this.labelVraag.Size = new System.Drawing.Size(50, 20);
            this.labelVraag.TabIndex = 20;
            this.labelVraag.Text = "Vraag:";
            // 
            // labelAntwoord
            // 
            this.labelAntwoord.AutoSize = true;
            this.labelAntwoord.Location = new System.Drawing.Point(109, 471);
            this.labelAntwoord.Name = "labelAntwoord";
            this.labelAntwoord.Size = new System.Drawing.Size(78, 20);
            this.labelAntwoord.TabIndex = 21;
            this.labelAntwoord.Text = "Antwoord:";
            // 
            // textBoxRegisterQuestion
            // 
            this.textBoxRegisterQuestion.Location = new System.Drawing.Point(223, 438);
            this.textBoxRegisterQuestion.Name = "textBoxRegisterQuestion";
            this.textBoxRegisterQuestion.Size = new System.Drawing.Size(256, 27);
            this.textBoxRegisterQuestion.TabIndex = 22;
            // 
            // textBoxRegisterAnswer
            // 
            this.textBoxRegisterAnswer.Location = new System.Drawing.Point(223, 471);
            this.textBoxRegisterAnswer.Name = "textBoxRegisterAnswer";
            this.textBoxRegisterAnswer.Size = new System.Drawing.Size(256, 27);
            this.textBoxRegisterAnswer.TabIndex = 23;
            // 
            // labelGeboorte
            // 
            this.labelGeboorte.AutoSize = true;
            this.labelGeboorte.Location = new System.Drawing.Point(69, 133);
            this.labelGeboorte.Name = "labelGeboorte";
            this.labelGeboorte.Size = new System.Drawing.Size(118, 20);
            this.labelGeboorte.TabIndex = 25;
            this.labelGeboorte.Text = "Geboortedatum:";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(223, 133);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(256, 27);
            this.dateTimePickerDateOfBirth.TabIndex = 26;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 714);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.labelGeboorte);
            this.Controls.Add(this.textBoxRegisterAnswer);
            this.Controls.Add(this.textBoxRegisterQuestion);
            this.Controls.Add(this.labelAntwoord);
            this.Controls.Add(this.labelVraag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRegisterJob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxPIN);
            this.Controls.Add(this.textBoxRegisterPINRepeat);
            this.Controls.Add(this.textBoxRegisterPIN);
            this.Controls.Add(this.textBoxRegisterPhoneNumber);
            this.Controls.Add(this.textBoxRegisterEmail);
            this.Controls.Add(this.textBoxRegisterLastname);
            this.Controls.Add(this.textBoxRegisterFirstname);
            this.Controls.Add(this.labelComboniatie);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelRegisterPinRepeat);
            this.Controls.Add(this.labelRegisterPin);
            this.Controls.Add(this.labelRegisterPhone);
            this.Controls.Add(this.labelRegisterEmail);
            this.Controls.Add(this.labelRegisterVoornaam);
            this.Controls.Add(this.buttonBackToOwner);
            this.Controls.Add(this.labelWelkom);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelkom;
        private System.Windows.Forms.Button buttonBackToOwner;
        private System.Windows.Forms.Label labelRegisterVoornaam;
        private System.Windows.Forms.Label labelRegisterEmail;
        private System.Windows.Forms.Label labelRegisterPhone;
        private System.Windows.Forms.Label labelRegisterPin;
        private System.Windows.Forms.Label labelRegisterPinRepeat;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelComboniatie;
        private System.Windows.Forms.TextBox textBoxRegisterFirstname;
        private System.Windows.Forms.TextBox textBoxRegisterLastname;
        private System.Windows.Forms.TextBox textBoxRegisterEmail;
        private System.Windows.Forms.TextBox textBoxRegisterPhoneNumber;
        private System.Windows.Forms.TextBox textBoxRegisterPIN;
        private System.Windows.Forms.TextBox textBoxRegisterPINRepeat;
        private System.Windows.Forms.CheckBox checkBoxPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRegisterJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVraag;
        private System.Windows.Forms.Label labelAntwoord;
        private System.Windows.Forms.TextBox textBoxRegisterQuestion;
        private System.Windows.Forms.TextBox textBoxRegisterAnswer;
        private System.Windows.Forms.Label labelGeboorte;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
    }
}