using System;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class PauseForm : Form
    {
        private SnakeForm parentForm;

        public PauseForm(SnakeForm parent)
        {
            parentForm = parent;
            InitializeComponent();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            parentForm.ResumeGame();
            this.Close();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            LeaderboardForm leaderboard = new LeaderboardForm();
            leaderboard.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}