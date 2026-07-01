using System;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace GestorLogin
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Data Source=users.db";

        public LoginForm()
        {
            InitializeComponent();
            
            CreateDatabase();
        }

        private void CreateDatabase()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS users (
                                id INTEGER PRIMARY KEY,
                                username TEXT NOT NULL UNIQUE,
                                password TEXT NOT NULL,
                                role TEXT NOT NULL)";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT role FROM users WHERE username=@user AND password=@pass";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", txtUser.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                    var role = cmd.ExecuteScalar();

                    if (role != null)
                    {
                        this.Hide();
                        MainForm main = new MainForm(role.ToString());
                        main.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }
    }
}