using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestorTareas
{
    partial class TaskForm
    {
        private TextBox txtTitle, txtDescription;
        private ComboBox cmbStatus;
        private Button btnAdd, btnUpdate, btnDelete;
        private CheckedListBox lstTasks;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "Gestor de Tareas";
            this.Font = new Font("Segoe UI", 12);
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;

            // Campo título
            txtTitle = new TextBox()
            {
                Location = new Point(30, 40),
                Width = 350,
                PlaceholderText = "Título de la tarea",
                BackColor = Color.FromArgb(45, 45, 45),
                ForeColor = Color.White
            };

            // Campo descripción
            txtDescription = new TextBox()
            {
                Location = new Point(30, 90),
                Width = 350,
                PlaceholderText = "Descripción",
                BackColor = Color.FromArgb(45, 45, 45),
                ForeColor = Color.White
            };

            // Estado
            cmbStatus = new ComboBox()
            {
                Location = new Point(30, 140),
                Width = 350,
                BackColor = Color.FromArgb(45, 45, 45),
                ForeColor = Color.White,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbStatus.Items.AddRange(new string[] { "Pendiente", "En progreso", "Completada" });
            cmbStatus.SelectedIndex = 0;

            // Botones verticales
            btnAdd = new Button()
            {
                Text = "➕ Agregar",
                Location = new Point(30, 200),
                Width = 350,
                Height = 50,
                BackColor = Color.FromArgb(0, 200, 83),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnUpdate = new Button()
            {
                Text = "✏️ Editar",
                Location = new Point(30, 260),
                Width = 350,
                Height = 50,
                BackColor = Color.FromArgb(0, 200, 83),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnDelete = new Button()
            {
                Text = "🗑️ Eliminar",
                Location = new Point(30, 320),
                Width = 350,
                Height = 50,
                BackColor = Color.FromArgb(0, 200, 83),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // CheckedListBox para tareas
            lstTasks = new CheckedListBox()
            {
                Location = new Point(420, 40),
                Size = new Size(550, 500),
                BackColor = Color.FromArgb(45, 45, 45),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12),
                CheckOnClick = true
            };

            // Eventos
            btnAdd.Click += new EventHandler(btnAdd_Click);
            btnUpdate.Click += new EventHandler(btnUpdate_Click);
            btnDelete.Click += new EventHandler(btnDelete_Click);
            lstTasks.ItemCheck += new ItemCheckEventHandler(lstTasks_ItemCheck);

            // Controles
            this.Controls.Add(txtTitle);
            this.Controls.Add(txtDescription);
            this.Controls.Add(cmbStatus);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(lstTasks);
        }
    }
}