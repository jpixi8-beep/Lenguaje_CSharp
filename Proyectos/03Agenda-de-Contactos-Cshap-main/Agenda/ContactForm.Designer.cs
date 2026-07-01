using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestorContactos
{
    partial class ContactForm
    {
        private TextBox txtName, txtPhone, txtEmail, txtAddress;
        private Button btnAdd, btnUpdate, btnDelete, btnExport;
        private ListBox lstContacts;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "Agenda de Contactos";
            this.Font = new Font("Segoe UI", 12);
            this.BackColor = Color.FromArgb(30, 30, 30);   // Fondo oscuro
            this.ForeColor = Color.White;                 // Texto blanco

            // Campos de entrada
            txtName = new TextBox()
            {
                Location = new Point(30, 40),
                Width = 350,
                PlaceholderText = "Nombre",
                BackColor = Color.FromArgb(45, 45, 45),
                ForeColor = Color.White
            };

            txtPhone = new TextBox()
            {
                Location = new Point(30, 90),
                Width = 350,
                PlaceholderText = "Teléfono",
                BackColor = Color.FromArgb(45, 45, 45),
                ForeColor = Color.White
            };

            txtEmail = new TextBox()
            {
                Location = new Point(30, 140),
                Width = 350,
                PlaceholderText = "Email",
                BackColor = Color.FromArgb(45, 45, 45),
                ForeColor = Color.White
            };

            txtAddress = new TextBox()
            {
                Location = new Point(30, 190),
                Width = 350,
                PlaceholderText = "Dirección",
                BackColor = Color.FromArgb(45, 45, 45),
                ForeColor = Color.White
            };

            // Botones verticales
            btnAdd = new Button()
            {
                Text = "➕ Agregar",
                Location = new Point(30, 250),
                Width = 350,
                Height = 50,
                BackColor = Color.FromArgb(0, 200, 83), // Verde acento
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnUpdate = new Button()
            {
                Text = "✏️ Editar",
                Location = new Point(30, 310),
                Width = 350,
                Height = 50,
                BackColor = Color.FromArgb(0, 200, 83),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnDelete = new Button()
            {
                Text = "🗑️ Eliminar",
                Location = new Point(30, 370),
                Width = 350,
                Height = 50,
                BackColor = Color.FromArgb(0, 200, 83),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnExport = new Button()
            {
                Text = "📤 Exportar CSV",
                Location = new Point(30, 430),
                Width = 350,
                Height = 50,
                BackColor = Color.FromArgb(0, 200, 83),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // Lista de contactos
            lstContacts = new ListBox()
            {
                Location = new Point(420, 40),
                Size = new Size(550, 500),
                BackColor = Color.FromArgb(45, 45, 45),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12)
            };

            // Eventos
            btnAdd.Click += new EventHandler(btnAdd_Click);
            btnUpdate.Click += new EventHandler(btnUpdate_Click);
            btnDelete.Click += new EventHandler(btnDelete_Click);
            btnExport.Click += new EventHandler(btnExport_Click);
lstContacts.SelectedIndexChanged += new EventHandler(lstContacts_SelectedIndexChanged);

            // Agregar controles
            this.Controls.Add(txtName);
            this.Controls.Add(txtPhone);
            this.Controls.Add(txtEmail);
            this.Controls.Add(txtAddress);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnExport);
            this.Controls.Add(lstContacts);
        }
    }
}