using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgainTheseActivities
{
    public partial class RegistrationForm : Form
    {
        private DB db = new DB();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        public string Login
        {
            get { return loginField.Text.Trim(); }
            set { loginField.Text = value; }
        }

        public string Password
        {
            get { return passwordField.Text.Trim(); }
            set { passwordField.Text = value; }
        }

        private void OpenSignIn_Click(object sender, EventArgs e)
        {
            LogInForm loginForm = new();
            loginForm.Show();

            this.Hide();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (User.Register(Login, Password))
            {
                MainForm mainForm = new(Login);
                mainForm.Show();

                this.Hide();
            }
        }
    }
}
