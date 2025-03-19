using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AgainTheseActivities
{
    public partial class LogInForm : Form
    {
        public LogInForm()
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Авторизация
            if (User.Login(Login, Password))
            {
                MainForm mainForm = new(Login);
                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Открыть форму регистрации
        private void OpenRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new();
            regForm.Show();

            this.Hide();
        }
    }
}
