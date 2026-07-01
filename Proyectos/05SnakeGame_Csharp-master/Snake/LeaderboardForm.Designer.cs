using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    partial class LeaderboardForm
    {
        private ListBox listBoxScores;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Text = "Records";
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 12);

            listBoxScores = new ListBox()
            {
                Location = new Point(20, 20),
                Size = new Size(360, 240),
                BackColor = Color.FromArgb(30, 30, 30),
                ForeColor = Color.White
            };

            this.Controls.Add(listBoxScores);
        }
    }
}