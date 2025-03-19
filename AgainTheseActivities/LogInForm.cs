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

            if (User.Login(Login, Password))
            {
                //int userId = Convert.ToInt32(table.Rows[0]["userId"]);
                //string userName = table.Rows[0]["userName"].ToString();

                MainForm mainForm = new(Login);
                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.");
            }
        }

        private void OpenRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new();
            regForm.Show();

            this.Hide();
        }
    }
}
