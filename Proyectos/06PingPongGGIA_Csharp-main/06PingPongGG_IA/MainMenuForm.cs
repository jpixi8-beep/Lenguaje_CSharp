using System;
using System.Drawing;
using System.Windows.Forms;

namespace PongGame
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnPvP_Click(object sender, EventArgs e)
        {
            PongForm game = new PongForm(false); // false = no IA
            game.ShowDialog();
        }

        private void btnPvIA_Click(object sender, EventArgs e)
        {
            PongForm game = new PongForm(true); // true = con IA
            game.ShowDialog();
        }
    }
}