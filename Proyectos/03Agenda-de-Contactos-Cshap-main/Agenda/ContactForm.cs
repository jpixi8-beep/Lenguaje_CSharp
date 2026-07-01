using System;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace GestorContactos
{
    public partial class ContactForm : Form
    {
        private string connectionString = "Data Source=contacts.db";

        public ContactForm()
        {
            InitializeComponent();
            CreateDatabase();
            LoadContacts();
        }

        private void CreateDatabase()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS contacts (
                                id INTEGER PRIMARY KEY,
                                name TEXT NOT NULL,
                                phone TEXT,
                                email TEXT,
                                address TEXT)";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadContacts()
        {
            lstContacts.Items.Clear();
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM contacts";
                using (var cmd = new SqliteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lstContacts.Items.Add($"{reader["id"]} - {reader["name"]} ({reader["phone"]}, {reader["email"]})");
                    }
                }
            }
        }

        private bool ValidarTelefono(string phone)
        {
            return Regex.IsMatch(phone, @"^[0-9]{7,15}$"); // solo números, entre 7 y 15 dígitos
        }

        private bool ValidarEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidarTelefono(txtPhone.Text))
            {
                MessageBox.Show("Número de teléfono inválido. Solo números (7-15 dígitos).");
                return;
            }

            if (!ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("Correo electrónico inválido.");
                return;
            }

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO contacts (name, phone, email, address) VALUES (@name, @phone, @email, @address)";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadContacts();
            MessageBox.Show("Contacto agregado correctamente.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedItem == null) return;
            int id = int.Parse(lstContacts.SelectedItem.ToString().Split('-')[0].Trim());

            if (!ValidarTelefono(txtPhone.Text))
            {
                MessageBox.Show("Número de teléfono inválido.");
                return;
            }

            if (!ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("Correo electrónico inválido.");
                return;
            }

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE contacts SET name=@name, phone=@phone, email=@email, address=@address WHERE id=@id";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadContacts();
            MessageBox.Show("Contacto actualizado correctamente.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedItem == null) return;
            int id = int.Parse(lstContacts.SelectedItem.ToString().Split('-')[0].Trim());

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM contacts WHERE id=@id";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadContacts();
            MessageBox.Show("Contacto eliminado correctamente.");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string filePath = "contacts_export.csv";
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM contacts";
                using (var cmd = new SqliteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                using (var writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("ID,Name,Phone,Email,Address");
                    while (reader.Read())
                    {
                        writer.WriteLine($"{reader["id"]},{reader["name"]},{reader["phone"]},{reader["email"]},{reader["address"]}");
                    }
                }
            }
            MessageBox.Show($"Contactos exportados a {Path.GetFullPath(filePath)}");
        }
        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
{
    if (lstContacts.SelectedItem == null) return;

    // Obtener el ID del contacto seleccionado
    int id = int.Parse(lstContacts.SelectedItem.ToString().Split('-')[0].Trim());

    using (var conn = new SqliteConnection(connectionString))
    {
        conn.Open();
        string sql = "SELECT * FROM contacts WHERE id=@id";
        using (var cmd = new SqliteCommand(sql, conn))
        {
            cmd.Parameters.AddWithValue("@id", id);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtName.Text = reader["name"].ToString();
                    txtPhone.Text = reader["phone"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtAddress.Text = reader["address"].ToString();
                }
            }
        }
    }
}
    }
}