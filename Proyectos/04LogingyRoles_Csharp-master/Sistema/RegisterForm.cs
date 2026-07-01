using System;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace GestorLogin
{
    public partial class RegisterForm : Form
    {
        private string connectionString = "Data Source=users.db";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Usuario y contraseña son obligatorios.");
                return;
            }

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO users (username, password, role) VALUES (@user, @pass, @role)";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", txtUser.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario registrado correctamente.");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}