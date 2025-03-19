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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadUsersList();
        }

        public void LoadUsersList()
        {
            try
            {
                DB db = new();
                db.OpenConnection();

                MySqlCommand command = new(
                    @"SELECT id, login, hash, isAdmin, isActive, registration FROM users",
                    db.GetConnection()
                );

                MySqlDataReader reader = command.ExecuteReader();

                // Очистка списка перед заполнением
                usersList.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new(reader["login"].ToString());
                    item.SubItems.Add(reader["isAdmin"].ToString());
                    item.SubItems.Add(reader["isActive"].ToString());
                    item.SubItems.Add(reader["registration"].ToString());

                    usersList.Items.Add(item);
                }

                reader.Close();
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке пользователей: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
