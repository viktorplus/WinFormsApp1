using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RegistationForm : Form
    {
        LoginForm loginForm;
        public RegistationForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string address = txtAdress.Text;
            string telefon = txtTelefon.Text;
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            User newUser = new User(name, surname, address, telefon, login, password);
            Users.AddUser(newUser);
            //MessageBox.Show("Ok");
            Hide();
            loginForm.Show();


        }

    }
}

