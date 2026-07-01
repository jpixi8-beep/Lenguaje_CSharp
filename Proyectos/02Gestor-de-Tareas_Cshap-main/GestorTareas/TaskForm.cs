using System;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace GestorTareas
{
    public partial class TaskForm : Form
    {
        private string connectionString = "Data Source=tasks.db";

        public TaskForm()
        {
            InitializeComponent();
            MessageBox.Show("Componentes iniciados");
            CreateDatabase();
            MessageBox.Show("Base de datos creada");
            LoadTasks();
            MessageBox.Show("Base de datos cargada");
        }

        private void CreateDatabase()
        {
            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "CREATE TABLE IF NOT EXISTS tasks (id INTEGER PRIMARY KEY, title TEXT, description TEXT, status TEXT)";
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en CreateDatabase: " + ex.Message);
            }
        }

        private void LoadTasks()
        {
            lstTasks.Items.Clear();
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM tasks";
                using (var cmd = new SqliteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lstTasks.Items.Add($"{reader["id"]} - {reader["title"]} [{reader["status"]}]");
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO tasks (title, description, status) VALUES (@title, @desc, 'Pendiente')";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadTasks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem == null) return;
            int id = int.Parse(lstTasks.SelectedItem.ToString().Split('-')[0].Trim());

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE tasks SET title=@title, description=@desc, status=@status WHERE id=@id";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem?.ToString() ?? "Pendiente");
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadTasks();
        }

       private void btnDelete_Click(object sender, EventArgs e)
{
    if (lstTasks.CheckedItems.Count == 0 && lstTasks.SelectedItems.Count == 0)
    {
        MessageBox.Show("Selecciona al menos una tarea para eliminar.");
        return;
    }

    // Usamos una lista temporal para recorrer todas las seleccionadas
    var itemsToDelete = new System.Collections.Generic.List<string>();

    // Incluye las tareas marcadas con check
    foreach (var item in lstTasks.CheckedItems)
    {
        itemsToDelete.Add(item.ToString());
    }

    // Incluye también las seleccionadas con clic (por si no están checkeadas)
    foreach (var item in lstTasks.SelectedItems)
    {
        if (!itemsToDelete.Contains(item.ToString()))
            itemsToDelete.Add(item.ToString());
    }

    using (var conn = new Microsoft.Data.Sqlite.SqliteConnection(connectionString))
    {
        conn.Open();
        foreach (var itemText in itemsToDelete)
        {
            int id = int.Parse(itemText.Split('-')[0].Trim());
            string sql = "DELETE FROM tasks WHERE id=@id";
            using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    LoadTasks();
    MessageBox.Show($"{itemsToDelete.Count} tarea(s) eliminada(s).");
}
     private void lstTasks_ItemCheck(object sender, ItemCheckEventArgs e)
{
    try
    {
        // Obtener el texto del ítem que se está marcando/desmarcando
        string itemText = lstTasks.Items[e.Index].ToString();
        int id = int.Parse(itemText.Split('-')[0].Trim());

        // Determinar el nuevo estado según el check
        string nuevoEstado = (e.NewValue == CheckState.Checked) ? "Completada" : "Pendiente";

        using (var conn = new Microsoft.Data.Sqlite.SqliteConnection(connectionString))
        {
            conn.Open();
            string sql = "UPDATE tasks SET status=@status WHERE id=@id";
            using (var cmd = new Microsoft.Data.Sqlite.SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@status", nuevoEstado);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Refrescar la lista para mostrar el estado actualizado
        LoadTasks();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al actualizar estado: " + ex.Message);
    }
}

    }
}