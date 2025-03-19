using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AgainTheseActivities
{
    public class User
    {
        public int Id { get; set; }

        public string UserLogin { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsActive { get; set; }

        public static string GetPasswordHash(string password)
        {
            using SHA1 sha1Hash = SHA1.Create();
            byte[] sourceBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
            string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            return hash;
        }

        public static bool Login(string login, string password)
        {
            string userLogin = login;
            string userPassword = GetPasswordHash(password.Trim());

            if (string.IsNullOrEmpty(userLogin) || string.IsNullOrEmpty(userPassword))
                return false;

            try
            {
                DB db = new();
                db.OpenConnection();

                MySqlCommand checkLoginCommand = new(
                    @"SELECT COUNT(*) FROM users 
                      WHERE login = @userLogin AND hash = @hash AND isActive = TRUE",
                db.GetConnection());
                checkLoginCommand.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = userLogin;
                checkLoginCommand.Parameters.Add("@hash", MySqlDbType.VarChar).Value = userPassword;

                int userExists = Convert.ToInt32(checkLoginCommand.ExecuteScalar());

                db.CloseConnection();

                if (userExists == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при авторизации пользователя!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool Register(string login, string password)
        {
            string userLogin = login;
            string userPassword = GetPasswordHash(password.Trim());

            if (string.IsNullOrEmpty(userLogin) || string.IsNullOrEmpty(userPassword))
                return false;

            try
            {
                DB db = new();
                db.OpenConnection();

                MySqlCommand checkLoginCommand = new(
                    @"SELECT COUNT(*) FROM users 
                      WHERE login = @userLogin",
                db.GetConnection());
                checkLoginCommand.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = userLogin;

                int userExists = Convert.ToInt32(checkLoginCommand.ExecuteScalar());

                if (userExists > 0)
                {
                    MessageBox.Show("К сожалению, данный логин занят, попробуйте другой", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    MySqlCommand command = new(
                        @"INSERT INTO Users (login, hash, registration) 
                          VALUES (@userLogin, @hash, @registrationDate)",
                    db.GetConnection());

                    command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = userLogin;
                    command.Parameters.Add("@hash", MySqlDbType.VarChar).Value = userPassword;
                    command.Parameters.Add("@registrationDate", MySqlDbType.VarChar).Value = DateTime.Now;

                    if (command.ExecuteNonQuery() == 1)
                    {
                        db.CloseConnection();
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при регистрации пользователя!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
