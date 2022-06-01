
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
            this.labelWelkom.Location = new System.Drawing.Point(195, 23);
            this.labelWelkom.Name = "labelWelkom";
            this.labelWelkom.Size = new System.Drawing.Size(304, 45);
            this.labelWelkom.TabIndex = 0;
            this.labelWelkom.Text = "Vul hieronder de gegevens in van de nieuwe werknemer.\r\nDe pincode bestaat uit vie" +
    "r cijfers. \r\nAlle velden zijn verplicht in te vullen.\r\n";
            // 
            // buttonBackToOwner
            // 
            this.buttonBackToOwner.Location = new System.Drawing.Point(28, 20);
            this.buttonBackToOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBackToOwner.Name = "buttonBackToOwner";
            this.buttonBackToOwner.Size = new System.Drawing.Size(92, 22);
            this.buttonBackToOwner.TabIndex = 1;
            this.buttonBackToOwner.Text = "<- Terug";
            this.buttonBackToOwner.UseVisualStyleBackColor = true;
            this.buttonBackToOwner.Click += new System.EventHandler(this.buttonBackToInlog_Click);
            // 
            // labelRegisterVoornaam
            // 
            this.labelRegisterVoornaam.AutoSize = true;
            this.labelRegisterVoornaam.Location = new System.Drawing.Point(32, 74);
            this.labelRegisterVoornaam.Name = "labelRegisterVoornaam";
            this.labelRegisterVoornaam.Size = new System.Drawing.Size(121, 15);
            this.labelRegisterVoornaam.TabIndex = 2;
            this.labelRegisterVoornaam.Text = "Voor- en achternaam:";
            // 
            // labelRegisterEmail
            // 
            this.labelRegisterEmail.AutoSize = true;
            this.labelRegisterEmail.Location = new System.Drawing.Point(86, 124);
            this.labelRegisterEmail.Name = "labelRegisterEmail";
            this.labelRegisterEmail.Size = new System.Drawing.Size(70, 15);
            this.labelRegisterEmail.TabIndex = 4;
            this.labelRegisterEmail.Text = "Email adres:";
            // 
            // labelRegisterPhone
            // 
            this.labelRegisterPhone.AutoSize = true;
            this.labelRegisterPhone.Location = new System.Drawing.Point(51, 149);
            this.labelRegisterPhone.Name = "labelRegisterPhone";
            this.labelRegisterPhone.Size = new System.Drawing.Size(104, 15);
            this.labelRegisterPhone.TabIndex = 5;
            this.labelRegisterPhone.Text = "Telefoon nummer:";
            // 
            // labelRegisterPin
            // 
            this.labelRegisterPin.AutoSize = true;
            this.labelRegisterPin.Location = new System.Drawing.Point(47, 200);
            this.labelRegisterPin.Name = "labelRegisterPin";
            this.labelRegisterPin.Size = new System.Drawing.Size(108, 15);
            this.labelRegisterPin.TabIndex = 6;
            this.labelRegisterPin.Text = "Wachtwoord (PIN):";
            // 
            // labelRegisterPinRepeat
            // 
            this.labelRegisterPinRepeat.AutoSize = true;
            this.labelRegisterPinRepeat.Location = new System.Drawing.Point(21, 228);
            this.labelRegisterPinRepeat.Name = "labelRegisterPinRepeat";
            this.labelRegisterPinRepeat.Size = new System.Drawing.Size(131, 15);
            this.labelRegisterPinRepeat.TabIndex = 7;
            this.labelRegisterPinRepeat.Text = "Herhaling wachtwoord:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(195, 384);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(99, 50);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Registeren";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxRegisterFirstname
            // 
            this.textBoxRegisterFirstname.Location = new System.Drawing.Point(195, 74);
            this.textBoxRegisterFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegisterFirstname.Name = "textBoxRegisterFirstname";
            this.textBoxRegisterFirstname.Size = new System.Drawing.Size(138, 23);
            this.textBoxRegisterFirstname.TabIndex = 10;
            // 
            // textBoxRegisterLastname
            // 
            this.textBoxRegisterLastname.Location = new System.Drawing.Point(338, 74);
            this.textBoxRegisterLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegisterLastname.Name = "textBoxRegisterLastname";
            this.textBoxRegisterLastname.Size = new System.Drawing.Size(138, 23);
            this.textBoxRegisterLastname.TabIndex = 11;
            // 
            // textBoxRegisterEmail
            // 
            this.textBoxRegisterEmail.Location = new System.Drawing.Point(195, 124);
            this.textBoxRegisterEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            this.textBoxRegisterEmail.Size = new System.Drawing.Size(224, 23);
            this.textBoxRegisterEmail.TabIndex = 12;
            // 
            // textBoxRegisterPhoneNumber
            // 
            this.textBoxRegisterPhoneNumber.Location = new System.Drawing.Point(195, 150);
            this.textBoxRegisterPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegisterPhoneNumber.Name = "textBoxRegisterPhoneNumber";
            this.textBoxRegisterPhoneNumber.Size = new System.Drawing.Size(138, 23);
            this.textBoxRegisterPhoneNumber.TabIndex = 13;
            // 
            // textBoxRegisterPIN
            // 
            this.textBoxRegisterPIN.Location = new System.Drawing.Point(195, 201);
            this.textBoxRegisterPIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegisterPIN.Name = "textBoxRegisterPIN";
            this.textBoxRegisterPIN.PasswordChar = '*';
            this.textBoxRegisterPIN.Size = new System.Drawing.Size(84, 23);
            this.textBoxRegisterPIN.TabIndex = 14;
            // 
            // textBoxRegisterPINRepeat
            // 
            this.textBoxRegisterPINRepeat.Location = new System.Drawing.Point(195, 228);
            this.textBoxRegisterPINRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegisterPINRepeat.Name = "textBoxRegisterPINRepeat";
            this.textBoxRegisterPINRepeat.PasswordChar = '*';
            this.textBoxRegisterPINRepeat.Size = new System.Drawing.Size(84, 23);
            this.textBoxRegisterPINRepeat.TabIndex = 15;
            // 
            // checkBoxPIN
            // 
            this.checkBoxPIN.AutoSize = true;
            this.checkBoxPIN.Location = new System.Drawing.Point(331, 203);
            this.checkBoxPIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPIN.Name = "checkBoxPIN";
            this.checkBoxPIN.Size = new System.Drawing.Size(73, 19);
            this.checkBoxPIN.TabIndex = 16;
            this.checkBoxPIN.Text = "View PIN";
            this.checkBoxPIN.UseVisualStyleBackColor = true;
            this.checkBoxPIN.CheckedChanged += new System.EventHandler(this.checkBoxPIN_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
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
            this.comboBoxRegisterJob.Location = new System.Drawing.Point(195, 176);
            this.comboBoxRegisterJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRegisterJob.Name = "comboBoxRegisterJob";
            this.comboBoxRegisterJob.Size = new System.Drawing.Size(138, 23);
            this.comboBoxRegisterJob.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "Door middel van een vraag en een antwoord kunnen werknemers \r\neen nieuw wachtwoor" +
    "d instellen";
            // 
            // labelVraag
            // 
            this.labelVraag.AutoSize = true;
            this.labelVraag.Location = new System.Drawing.Point(120, 310);
            this.labelVraag.Name = "labelVraag";
            this.labelVraag.Size = new System.Drawing.Size(40, 15);
            this.labelVraag.TabIndex = 20;
            this.labelVraag.Text = "Vraag:";
            // 
            // labelAntwoord
            // 
            this.labelAntwoord.AutoSize = true;
            this.labelAntwoord.Location = new System.Drawing.Point(95, 334);
            this.labelAntwoord.Name = "labelAntwoord";
            this.labelAntwoord.Size = new System.Drawing.Size(63, 15);
            this.labelAntwoord.TabIndex = 21;
            this.labelAntwoord.Text = "Antwoord:";
            // 
            // textBoxRegisterQuestion
            // 
            this.textBoxRegisterQuestion.Location = new System.Drawing.Point(195, 310);
            this.textBoxRegisterQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegisterQuestion.Name = "textBoxRegisterQuestion";
            this.textBoxRegisterQuestion.Size = new System.Drawing.Size(224, 23);
            this.textBoxRegisterQuestion.TabIndex = 22;
            // 
            // textBoxRegisterAnswer
            // 
            this.textBoxRegisterAnswer.Location = new System.Drawing.Point(195, 334);
            this.textBoxRegisterAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegisterAnswer.Name = "textBoxRegisterAnswer";
            this.textBoxRegisterAnswer.Size = new System.Drawing.Size(224, 23);
            this.textBoxRegisterAnswer.TabIndex = 23;
            // 
            // labelGeboorte
            // 
            this.labelGeboorte.AutoSize = true;
            this.labelGeboorte.Location = new System.Drawing.Point(60, 100);
            this.labelGeboorte.Name = "labelGeboorte";
            this.labelGeboorte.Size = new System.Drawing.Size(94, 15);
            this.labelGeboorte.TabIndex = 25;
            this.labelGeboorte.Text = "Geboortedatum:";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(195, 100);
            this.dateTimePickerDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(224, 23);
            this.dateTimePickerDateOfBirth.TabIndex = 26;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(618, 504);
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
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelRegisterPinRepeat);
            this.Controls.Add(this.labelRegisterPin);
            this.Controls.Add(this.labelRegisterPhone);
            this.Controls.Add(this.labelRegisterEmail);
            this.Controls.Add(this.labelRegisterVoornaam);
            this.Controls.Add(this.buttonBackToOwner);
            this.Controls.Add(this.labelWelkom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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