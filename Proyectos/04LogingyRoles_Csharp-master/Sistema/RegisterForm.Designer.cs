using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestorLogin
{
    partial class RegisterForm
    {
        private TextBox txtUser, txtPass;
        private ComboBox cmbRole;
        private Button btnRegister;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Text = "Registro de Usuario";
            this.Font = new Font("Segoe UI", 12);
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;

            txtUser = new TextBox()
            {
                Location = new Point(50, 50),
                Width = 300,
                PlaceholderText = "Usuario",
                BackColor = Color.FromArgb(45, 45, 45),
                ForeColor = Color.White
            };

            txtPass = new TextBox()
            {
                Location = new Point(50, 100),
                Width = 300,
                PlaceholderText = "Contraseña",
                BackColor = Color.FromArgb(45, 45, 45),
                ForeColor = Color.White,
                UseSystemPasswordChar = true
            };

            cmbRole = new ComboBox()
            {
                Location = new Point(50, 150),
                Width = 300,
                BackColor = Color.FromArgb(45, 45, 45),
                ForeColor = Color.White,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbRole.Items.AddRange(new string[] { "Admin", "Usuario" });

            btnRegister = new Button()
            {
                Text = "Registrar",
                Location = new Point(50, 200),
                Width = 300,
                Height = 40,
                BackColor = Color.FromArgb(0, 200, 83),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnRegister.Click += new EventHandler(btnRegister_Click);

            this.Controls.Add(txtUser);
            this.Controls.Add(txtPass);
            this.Controls.Add(cmbRole);
            this.Controls.Add(btnRegister);
        }
    }
}