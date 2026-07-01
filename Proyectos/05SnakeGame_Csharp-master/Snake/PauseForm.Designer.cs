using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    partial class PauseForm
    {
        private Button btnResume, btnRecords, btnExit;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Text = "Pausa";
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 12);

            btnResume = new Button()
            {
                Text = "Reanudar",
                Location = new Point(50, 50),
                Width = 200,
                Height = 40,
                BackColor = Color.Green,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnRecords = new Button()
            {
                Text = "Ver Records",
                Location = new Point(50, 100),
                Width = 200,
                Height = 40,
                BackColor = Color.Blue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnExit = new Button()
            {
                Text = "Salir",
                Location = new Point(50, 140),
                Width = 200,
                Height = 40,
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };



            btnResume.Click += new EventHandler(btnResume_Click);
            btnRecords.Click += new EventHandler(btnRecords_Click);
            btnExit.Click += new EventHandler(btnExit_Click);


            this.Controls.Add(btnResume);
            this.Controls.Add(btnRecords);
            this.Controls.Add(btnExit);

        }
    }
}