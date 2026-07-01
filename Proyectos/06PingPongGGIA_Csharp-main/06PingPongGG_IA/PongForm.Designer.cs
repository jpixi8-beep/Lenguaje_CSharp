using System.Drawing;
using System.Windows.Forms;

namespace PongGame
{
    partial class PongForm
    {
        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Text = "Pong Game";
            this.BackColor = Color.Black;
            this.DoubleBuffered = true;

            paddleLeft = new PictureBox()
            {
                BackColor = Color.White,
                Size = new Size(20, 100),
                Location = new Point(30, this.ClientSize.Height / 2 - 50)
            };

            paddleRight = new PictureBox()
            {
                BackColor = Color.White,
                Size = new Size(20, 100),
                Location = new Point(this.ClientSize.Width - 50, this.ClientSize.Height / 2 - 50)
            };

            ball = new PictureBox()
            {
                BackColor = Color.Red,
                Size = new Size(20, 20),
                Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2)
            };

            lblScore = new Label()
            {
                Text = "0 : 0",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(this.ClientSize.Width / 2 - 30, 20),
                AutoSize = true
            };

            this.Controls.Add(paddleLeft);
            this.Controls.Add(paddleRight);
            this.Controls.Add(ball);
            this.Controls.Add(lblScore);
        }
    }
}