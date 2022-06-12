using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErrorHandling;
using ChapeauModel;
using ChapeauLogica;
using System.Text.RegularExpressions;
using HashingAlgorithms;
using ChapeauInterfaces;

namespace ChapeauUI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonBackToInlog_Click(object sender, EventArgs e)
        {
            this.Hide();
            OwnerForm ownerForm = new OwnerForm();
            ownerForm.ShowDialog();
            this.Close();
        }

        private void checkBoxPIN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPIN.Checked)
                textBoxRegisterPIN.PasswordChar = '\0';
            else
                textBoxRegisterPIN.PasswordChar = '*';
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            {
                PasswordService sh = new PasswordService();
                Employee employee = new Employee()
                {
                    FirstName = textBoxRegisterFirstname.Text,
                    LastName = textBoxRegisterLastname.Text,
                    Password = sh.HashWithSalt(textBoxRegisterPIN.Text).Digest,
                    Category = (EmployeeCategory)comboBoxRegisterJob.SelectedIndex,
                    DateOfBirth = dateTimePickerDateOfBirth.Value,
                    Email = textBoxRegisterEmail.Text,
                    PhoneNumber = textBoxRegisterPhoneNumber.Text,
                    Question = textBoxRegisterQuestion.Text,
                    Answer = sh.HashWithSalt(textBoxRegisterAnswer.Text).Digest.ToLower()
                };

                RegisterService registerService = new RegisterService();
                registerService.AddEmployee(employee);

                MessageBox.Show($"{textBoxRegisterLastname.Text}, {textBoxRegisterFirstname.Text} is succesvol geregistreerd ");
            }
        }

        private bool RegisterCheckMethod() 
        {
            bool registerCheck = true;
            string firstname = textBoxRegisterFirstname.Text;
            string lastname = textBoxRegisterLastname.Text;
            string email = textBoxRegisterEmail.Text;
            string phoneNumber = textBoxRegisterPhoneNumber.Text;
            int jobType = comboBoxRegisterJob.SelectedIndex;
            string PIN =  textBoxRegisterPIN.Text; 
            string PINRepeat = textBoxRegisterPINRepeat.Text;
            string question = textBoxRegisterQuestion.Text;
            string answer = textBoxRegisterAnswer.Text;

            try
            {
                if (firstname == "" || lastname == "" ||  email == "" || phoneNumber == ""  || PIN == "" || PINRepeat == "" || question == "" || answer == "")
                {                   
                    throw new ChapeauException("Niet alle velden zijn ingevuld. Probeer het opnieuw.");                   
                }
                if (!ValidateEmail(email))
                {
                    textBoxRegisterEmail.Clear();
                    throw new ChapeauException("Dit is een ongeldig email adres. probeer het opnieuw ");
                }
                if (PIN.Length < 4 || PIN.Length > 4)
                {
                    textBoxRegisterPIN.Clear();
                    throw new ChapeauException("De pincode moet bestaan uit vier cijfers. Probeer het opnieuw");
                }
                if (PIN != PINRepeat)
                {
                    textBoxRegisterPINRepeat.Clear();
                    throw new ChapeauException("Wachtwoord komt niet overeen. Probeer het opnieuw.");                    
                } 
            }
            catch (ChapeauException chapeau)
            {
                MessageBox.Show(chapeau.Message);
            }
            catch (Exception exception)
            {
                ErrorLogger.WriteLogToFile(exception);
                MessageBox.Show(exception.Message);
            }
            return registerCheck;
        }

        private bool ValidateEmail(string email)
        {
            return new Regex(@"^[a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,3}").Match(email).Success;
        }
    }
}
