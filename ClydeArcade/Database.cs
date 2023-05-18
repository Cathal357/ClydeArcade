using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace ClydeArcade
{
    internal class Database
    {
        // This class will handle all database related tasks.
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=clydearcade;Uid=admin;Pwd=password;";

        public Database()
        {
            // This will create a new connection to the database.
            connection = new MySqlConnection(connectionString);
        }

        public void AddUserName(string userName)
        {
            // This will add a new username to the database.
            string query = "INSERT INTO USER (userName) VALUES (@userName)";

            // This will create a new command using the query and connection.
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // This will add the parameters to the query.
                command.Parameters.AddWithValue("@userName", userName);

                // This will open the connection, execute the command and then close the connection.
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void AddHighScore(string userName, string gameName, int score)
        {
            // This will add a new high score to the database, along with the username and game name.
            string query = "INSERT INTO HIGH_SCORES (userName, gameName, score) VALUES (@userName, @gameName, @score)";

            // This will create a new command using the query and connection.
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // This will add the parameters to the query.
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@gameName", gameName);
                command.Parameters.AddWithValue("@score", score);

                // This will open the connection, execute the command and then close the connection.
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
