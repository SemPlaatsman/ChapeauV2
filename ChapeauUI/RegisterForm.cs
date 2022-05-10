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
using System.Text.RegularExpressions;
using HashingAlgorithms;

namespace ChapeauUI
{
    public partial class RegisterForm : Form
    {
        private string firstname;
        private string lastname;
        private string email;
        private DateTime dateOfBirth;
        private string phoneNumber;
        private int jobType;
        private string PIN; // Als Hash?!
        private string PINRepeat;
        private string question;
        private string answer;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonBackToInlog_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
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
            if (RegisterCheckMethod())
            {
                Employee employee = new Employee()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Password = PIN, // deze werkt ook nog niet. Moet met Hashing. 
                    Category = jobType,
                    DateOfBirth = dateOfBirth,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    Question = question,
                    Answer = answer
                };
            }


            // iets als Registerservice regService = new ...
            // regService.add(employee)

            // POP UP MET AANGEMAAKT WERKNEMERSNUMMER! 
            // moet dit in een nieuwe form? 

        }

        private bool RegisterCheckMethod() 
        {
            bool registerCheck = true;

            this.firstname = textBoxRegisterFirstname.Text;
            this.lastname = textBoxRegisterLastname.Text;
            this.email = textBoxRegisterEmail.Text;
            this.phoneNumber = textBoxRegisterPhoneNumber.Text;
            this.jobType = int.Parse(comboBoxRegisterJob.Text);
            this.PIN =  textBoxRegisterPIN.Text; // dit moet als HashSaltResult, hoe?
            this.PINRepeat = textBoxRegisterPINRepeat.Text;
            this.question = textBoxRegisterQuestion.Text;
            this.answer = textBoxRegisterAnswer.Text;

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
                // als ik hier een false in gooi dan kom ik nooit in true. 
            }
            catch (ChapeauException chapeau)
            {
                MessageBox.Show(chapeau.Message);
            }
            catch (Exception)
            {
                // normale exceptions besteed voor de logger.
            }
            return registerCheck;
        }

        private bool ValidateEmail(string email)
        {
            return new Regex(@"^[a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,3}").Match(email).Success;
        }
    }
}
