using System.Drawing;
using System.Windows.Forms;

namespace PongGame
{
    partial class MainMenuForm
    {
        private Button btnPvP, btnPvIA;
        private Label lblTitle;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Text = "PINGPONG GG";
            this.BackColor = Color.Black;

            lblTitle = new Label()
            {
                Text = "PINGPONG GG",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                Location = new Point(100, 40),
                AutoSize = true
            };

            btnPvP = new Button()
            {
                Text = "Iniciar PvP (3 pts)",
                Location = new Point(100, 120),
                Size = new Size(200, 40),
                BackColor = Color.Green,
                ForeColor = Color.White
            };

            btnPvIA = new Button()
            {
                Text = "Iniciar PvIA (3 pts)",
                Location = new Point(100, 180),
                Size = new Size(200, 40),
                BackColor = Color.Blue,
                ForeColor = Color.White
            };

            btnPvP.Click += new EventHandler(btnPvP_Click);
            btnPvIA.Click += new EventHandler(btnPvIA_Click);

            this.Controls.Add(lblTitle);
            this.Controls.Add(btnPvP);
            this.Controls.Add(btnPvIA);
        }
    }
}