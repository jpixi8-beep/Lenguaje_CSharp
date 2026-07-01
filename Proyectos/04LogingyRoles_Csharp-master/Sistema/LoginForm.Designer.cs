using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestorLogin
{
    partial class LoginForm
    {
        private TextBox txtUser, txtPass;
        private Button btnLogin, btnRegister;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Text = "Login";
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

            btnLogin = new Button()
            {
                Text = "Iniciar sesión",
                Location = new Point(50, 160),
                Width = 300,
                Height = 40,
                BackColor = Color.FromArgb(0, 200, 83),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnRegister = new Button()
            {
                Text = "Registrar usuario",
                Location = new Point(50, 210),
                Width = 300,
                Height = 40,
                BackColor = Color.FromArgb(0, 200, 83),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnLogin.Click += new EventHandler(btnLogin_Click);
            btnRegister.Click += new EventHandler(btnRegister_Click);

            this.Controls.Add(txtUser);
            this.Controls.Add(txtPass);
            this.Controls.Add(btnLogin);
            this.Controls.Add(btnRegister);
        }
    }
}