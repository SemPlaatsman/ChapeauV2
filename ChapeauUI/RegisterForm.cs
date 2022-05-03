using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string firstname = textBoxRegisterFirstname.Text;
            string lastname = textBoxRegisterLastname.Text;
            string email = textBoxRegisterEmail.Text;
            string phoneNumber = textBoxRegisterPhoneNumber.Text;
            string PIN = textBoxRegisterPIN.Text;
            string PINRepeat = textBoxRegisterPINRepeat.Text;

            try
            {
                if (firstname == "" || lastname == "" || email == "" || phoneNumber == "" || PIN == "")
                {
                    MessageBox.Show("Niet alle velden zijn ingevuld. Probeer het opnieuw.");
                }
                if (!email.Contains('@'))
                {
                    MessageBox.Show("Er ontbreekt een '@' in dit email adres. Probeer het opnieuw. ");
                    textBoxRegisterEmail.Clear();
                }
                if (PIN.Length < 4 || PIN.Length > 4)
                {
                    MessageBox.Show("De pincode moet bestaan uit vier cijfers. Probeer het opnieuw");
                    textBoxRegisterPIN.Clear();
                }
                if (PIN != PINRepeat)
                {
                    MessageBox.Show("Wachtwoord komt niet overeen. Probeer het opnieuw.");
                    textBoxRegisterPINRepeat.Clear();
                }
                // POP UP MET AANGEMAAKT WERKNEMERSNUMMER! 
                // moet dit in een nieuwe form? 

            }
            catch (Exception)
            {
                throw;
            }

            // Hier komt nog een iets van een RegisterDAO om het daadwerkelijk toe te voegen aan de database. 
            // register.AddRow(alle parameters) of iets dergelijks. 
        }
    }
}
