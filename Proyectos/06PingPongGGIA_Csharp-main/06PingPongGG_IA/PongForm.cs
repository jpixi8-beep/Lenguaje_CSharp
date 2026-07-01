using System;
using System.Drawing;
using System.Windows.Forms;

namespace PongGame
{
    public partial class PongForm : Form
    {
        private PictureBox? paddleLeft, paddleRight, ball;
        private Label? lblScore;
        private int scoreLeft = 0, scoreRight = 0;
        private int ballSpeedX = 5, ballSpeedY = 5;
        private System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        private bool vsAI;

        public PongForm(bool aiMode)
        {
            vsAI = aiMode;
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            scoreLeft = 0;
            scoreRight = 0;
            if (lblScore != null) lblScore.Text = "0 : 0";

            if (ball != null)
                ball.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);

            ballSpeedX = 5;
            ballSpeedY = 5;

            gameTimer.Stop();
            gameTimer.Interval = 30;
            gameTimer.Tick -= UpdateGame;
            gameTimer.Tick += UpdateGame;
            gameTimer.Start();
        }

        private void UpdateGame(object? sender, EventArgs e)
        {
            if (ball == null || paddleLeft == null || paddleRight == null || lblScore == null)
                return;

            // mover pelota
            ball.Left += ballSpeedX;
            ball.Top += ballSpeedY;

            // IA mueve paleta derecha
            if (vsAI)
            {
                if (ball.Top > paddleRight.Top + paddleRight.Height / 2)
                    paddleRight.Top += 5;
                else if (ball.Top < paddleRight.Top + paddleRight.Height / 2)
                    paddleRight.Top -= 5;
            }

            // rebote en paredes
            if (ball.Top <= 0 || ball.Bottom >= this.ClientSize.Height)
                ballSpeedY = -ballSpeedY;

            // rebote en paletas
            if (ball.Bounds.IntersectsWith(paddleLeft.Bounds) || ball.Bounds.IntersectsWith(paddleRight.Bounds))
                ballSpeedX = -ballSpeedX;

            // punto jugador derecho
            if (ball.Left <= 0)
            {
                scoreRight++;
                lblScore.Text = $"{scoreLeft} : {scoreRight}";
                CheckWinner();
                ResetBall();
            }

            // punto jugador izquierdo
            if (ball.Right >= this.ClientSize.Width)
            {
                scoreLeft++;
                lblScore.Text = $"{scoreLeft} : {scoreRight}";
                CheckWinner();
                ResetBall();
            }
        }

        private void ResetBall()
        {
            if (ball == null) return;
            ball.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            ballSpeedX = -ballSpeedX;
        }

        private void CheckWinner()
        {
            if (scoreLeft == 3)
            {
                gameTimer.Stop();
                MessageBox.Show("Jugador Izquierdo gana!");
                StartGame();
            }
            else if (scoreRight == 3)
            {
                gameTimer.Stop();
                MessageBox.Show(vsAI ? "La IA gana!" : "Jugador Derecho gana!");
                StartGame();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (paddleLeft == null || paddleRight == null)
                return base.ProcessCmdKey(ref msg, keyData);

            switch (keyData)
            {
                case Keys.W: if (paddleLeft.Top > 0) paddleLeft.Top -= 20; break;
                case Keys.S: if (paddleLeft.Bottom < this.ClientSize.Height) paddleLeft.Top += 20; break;
                case Keys.Up: if (!vsAI && paddleRight.Top > 0) paddleRight.Top -= 20; break;
                case Keys.Down: if (!vsAI && paddleRight.Bottom < this.ClientSize.Height) paddleRight.Top += 20; break;
                case Keys.Escape:
                    PauseGame();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void PauseGame()
        {
            gameTimer.Stop();
            PauseForm pause = new PauseForm(this);
            pause.ShowDialog();
        }

        public void ResumeGame()
        {
            gameTimer.Start();
        }

        public void RestartGame()
        {
            StartGame();
        }
    }
}