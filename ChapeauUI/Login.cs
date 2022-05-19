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
using HashingAlgorithms;
using ChapeauModel;
using ChapeauLogica;

namespace ChapeauUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ShowListView();
        }

        private void ShowListView() 
        {
            EmployeeService employeeService = new EmployeeService();
            List<Employee> allEmployees = employeeService.GetAllEmployees();

            listViewNames.View = View.Details;
            listViewNames.FullRowSelect = true;
            listViewNames.Columns.Add("Lastname", 200);
            listViewNames.Columns.Add("Firstname", 200);
            listViewNames.Columns.Add("Phone Number", 182);

            foreach (Employee employee in allEmployees)
            {
                ListViewItem li = new ListViewItem(employee.LastName);
                li.SubItems.Add(employee.FirstName);
                li.SubItems.Add(employee.PhoneNumber);
                li.Tag = employee;
                listViewNames.Items.Add(li);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }

        private void checkBoxViewPIN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxViewPIN.Checked)
                textBoxLoginPIN.PasswordChar = '\0';
            else
                textBoxLoginPIN.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            PasswordService passwordService = new PasswordService();
            LoginService loginService = new LoginService();
            int employeeID = int.Parse(textBoxLoginWerknemerNummer.Text);
            Employee employee = loginService.Login(employeeID);
           // MessageBox.Show(employee.Password);
            try
            {
                string checkPassword = passwordService.HashWithSalt(textBoxLoginPIN.Text).Digest;
                if (employee.Password == checkPassword)
                {
                    LoginWithRightJobType(employee);
                }
            }
            catch (Exception)
            {
                throw;
            }

            //d.m.v. de LoginWithRightJobType() wordt er bepaalde naar welk inlog scherm verwezen wordt. 


        }

        private void LoginWithRightJobType(Employee employee) 
        {
            switch (employee.Category)
            {
                case EmployeeCategory.Serveerster:
                    this.Hide();
                    TableOverviewForm tableOverviewForm = new TableOverviewForm();
                    tableOverviewForm.ShowDialog();
                    this.Close();
                    break;

            }


        }

        private void listViewNames_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)(listViewNames.SelectedItems[0].Tag);
            textBoxLoginWerknemerNummer.Text = employee.EmployeeID.ToString();
        }


    }
}
