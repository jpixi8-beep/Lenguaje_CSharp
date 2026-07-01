using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class LeaderboardForm : Form
    {
        private string connectionString = "Data Source=scores.db";

        public LeaderboardForm()
        {
            InitializeComponent();
            LoadScores();
        }

        private void LoadScores()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT player, score, date FROM scores ORDER BY score DESC LIMIT 10";
                using (var cmd = new SqliteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBoxScores.Items.Add($"{reader["player"]} - {reader["score"]} puntos ({reader["date"]})");
                    }
                }
            }
        }
    }
}