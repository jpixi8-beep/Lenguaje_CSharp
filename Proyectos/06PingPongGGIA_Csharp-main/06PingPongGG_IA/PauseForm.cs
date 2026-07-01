using System;
using System.Windows.Forms;

namespace PongGame
{
    public partial class PauseForm : Form
    {
        private PongForm parentForm;

        public PauseForm(PongForm parent)
        {
            parentForm = parent;
            InitializeComponent();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            parentForm.ResumeGame();
            this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            parentForm.RestartGame();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}