using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        FileHandler handler = new FileHandler();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string login;

            if (handler.UserLogin(username, password)== true)
            {
                login = "Succesful Login.";
                MessageBox.Show(login, "Login Status.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                login = "Username or Password is incorrect! Please make sure the user is registered.";
                MessageBox.Show(login, "Login Status.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string register;

            if (handler.UserRegister(username, password) == true)
            {
                register = "User already exists.";
                MessageBox.Show(register, "Register Status.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
            else
            {
                register = "New user has been registered.";
                MessageBox.Show(register, "Register Status.",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {

            MessageBox.Show(handler.checkConnection(), "Connection Status.");
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }
    }
}
