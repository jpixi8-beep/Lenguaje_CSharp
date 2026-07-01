using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    partial class SnakeForm
    {
        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Text = "Snake Game";
            this.BackColor = Color.Black;
            this.DoubleBuffered = true;

            lblScore = new Label()
            {
                Text = "Score: 0",
                Location = new Point(10, 410),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12)
            };
            Label lblPauseHint = new Label()
            {
                Text = "ESC = Pausa",
                Location = new Point(200, 410),
                ForeColor = Color.LightGray,
                Font = new Font("Segoe UI", 10, FontStyle.Italic)
            };

            this.Controls.Add(lblScore);
            this.Controls.Add(lblPauseHint);


        }
    }
}