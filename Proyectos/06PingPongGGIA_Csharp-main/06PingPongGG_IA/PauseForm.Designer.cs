using System.Drawing;
using System.Windows.Forms;

namespace PongGame
{
    partial class PauseForm
    {
        private Button btnResume, btnRestart, btnExit;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Text = "Pausa";
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 12);

            btnResume = new Button()
            {
                Text = "Reanudar",
                Location = new Point(50, 40),
                Size = new Size(200, 40),
                BackColor = Color.Green,
                ForeColor = Color.White
            };

            btnRestart = new Button()
            {
                Text = "Reiniciar",
                Location = new Point(50, 90),
                Size = new Size(200, 40),
                BackColor = Color.Blue,
                ForeColor = Color.White
            };

            btnExit = new Button()
            {
                Text = "Salir",
                Location = new Point(50, 140),
                Size = new Size(200, 40),
                BackColor = Color.Red,
                ForeColor = Color.White
            };

            btnResume.Click += new EventHandler(btnResume_Click);
            btnRestart.Click += new EventHandler(btnRestart_Click);
            btnExit.Click += new EventHandler(btnExit_Click);

            this.Controls.Add(btnResume);
            this.Controls.Add(btnRestart);
            this.Controls.Add(btnExit);
        }
    }
}