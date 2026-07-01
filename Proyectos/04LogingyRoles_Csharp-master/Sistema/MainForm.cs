using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestorLogin
{
    public partial class MainForm : Form
    {
        private string userRole;
        private Button btnManageUsers, btnReports, btnProfile, btnLogout;

        public MainForm(string role)
        {
            userRole = role;
            InitializeComponent();
            ConfigurarVista();
        }

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Text = "Panel Principal";
            this.Font = new Font("Segoe UI", 12);
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;

            btnManageUsers = new Button()
            {
                Text = "👥 Gestión de Usuarios",
                Location = new Point(50, 50),
                Width = 200,
                Height = 40,
                BackColor = Color.FromArgb(0, 200, 83),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnReports = new Button()
            {
                Text = "📊 Reportes",
                Location = new Point(50, 100),
                Width = 200,
                Height = 40,
                BackColor = Color.FromArgb(0, 200, 83),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnProfile = new Button()
            {
                Text = "👤 Perfil",
                Location = new Point(50, 150),
                Width = 200,
                Height = 40,
                BackColor = Color.FromArgb(0, 200, 83),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnLogout = new Button()
            {
                Text = "🚪 Salir",
                Location = new Point(50, 200),
                Width = 200,
                Height = 40,
                BackColor = Color.FromArgb(0, 200, 83),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnLogout.Click += (s, e) => { this.Close(); };

            this.Controls.Add(btnProfile);
            this.Controls.Add(btnLogout);
            this.Controls.Add(btnManageUsers);
            this.Controls.Add(btnReports);
        }

        private void ConfigurarVista()
        {
            if (userRole == "Admin")
            {
                btnManageUsers.Visible = true;
                btnReports.Visible = true;
                MessageBox.Show("Bienvenido Administrador. Acceso completo.");
            }
            else
            {
                btnManageUsers.Visible = false;
                btnReports.Visible = false;
                MessageBox.Show("Bienvenido Usuario. Acceso limitado.");
            }
        }
    }
}