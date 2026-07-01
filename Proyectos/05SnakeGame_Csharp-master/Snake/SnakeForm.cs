using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace SnakeGame
{
    public partial class SnakeForm : Form
    {
        private List<Point> snake = new List<Point>();
        private Point food;
        private int score = 0;
        private string direction = "Right";
        private System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        private Label lblScore = new Label();
        private string connectionString = "Data Source=scores.db";

        public SnakeForm()
        {
            InitializeComponent();
            CreateDatabase();
            StartGame();
        }

        private void CreateDatabase()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS scores (
                                id INTEGER PRIMARY KEY,
                                player TEXT NOT NULL,
                                score INTEGER NOT NULL,
                                date TEXT NOT NULL)";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void StartGame()
        {
            snake.Clear();
            snake.Add(new Point(5, 5));
            direction = "Right";
            score = 0;
            lblScore.Text = "Score: 0";
            GenerateFood();

            gameTimer.Stop();              // detener cualquier ciclo previo
            gameTimer.Interval = 200;      // velocidad inicial fija
            gameTimer.Tick -= UpdateGame;  // quitar handlers viejos (por seguridad)
            gameTimer.Tick += UpdateGame;  // volver a enganchar el handler
            gameTimer.Start();


        }

        private void GenerateFood()
        {
            Random rnd = new Random();
            food = new Point(rnd.Next(0, 20), rnd.Next(0, 20));
        }

        private void UpdateGame(object? sender, EventArgs e)
        {
            Point head = snake[0];
            Point newHead = head;

            switch (direction)
            {
                case "Up": newHead.Y -= 1; break;
                case "Down": newHead.Y += 1; break;
                case "Left": newHead.X -= 1; break;
                case "Right": newHead.X += 1; break;
            }

            if (newHead.X < 0 || newHead.Y < 0 || newHead.X >= 20 || newHead.Y >= 20 || snake.Contains(newHead))
            {
                GameOver();
                return;
            }

            snake.Insert(0, newHead);

            if (newHead == food)
            {
                score += 10;
                lblScore.Text = "Score: " + score;
                GenerateFood();

                // opcional: aumentar velocidad cada cierto puntaje
                if (score % 50 == 0 && gameTimer.Interval > 50)
                {
                    gameTimer.Interval -= 20;
                }
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }

            this.Invalidate();
        }

        private void GameOver()
        {
            gameTimer.Stop();
            string player = Microsoft.VisualBasic.Interaction.InputBox("Ingresa tu nombre:", "Game Over", "Jugador");
            SaveScore(player, score);
            MessageBox.Show("Game Over! Puntuación: " + score);
            // Mostrar records al final de la partida
            LeaderboardForm leaderboard = new LeaderboardForm();
            leaderboard.ShowDialog();

            StartGame();
        }

        private void SaveScore(string player, int score)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO scores (player, score, date) VALUES (@player, @score, @date)";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@player", player);
                    cmd.Parameters.AddWithValue("@score", score);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush snakeColor = Brushes.Green;
            Brush foodColor = Brushes.Red;

            foreach (Point p in snake)
            {
                g.FillRectangle(snakeColor, new Rectangle(p.X * 20, p.Y * 20, 20, 20));
            }

            g.FillRectangle(foodColor, new Rectangle(food.X * 20, food.Y * 20, 20, 20));
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up: if (direction != "Down") direction = "Up"; break;
                case Keys.Down: if (direction != "Up") direction = "Down"; break;
                case Keys.Left: if (direction != "Right") direction = "Left"; break;
                case Keys.Right: if (direction != "Left") direction = "Right"; break;
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

    }
}