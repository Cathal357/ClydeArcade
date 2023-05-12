using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClydeArcade
{
    public partial class Game1 : Form
    {
        string gameName = "";
        string userName = "";
        int score = 0;

        int gravity = 5;
        int speed = 5;

        public Game1()
        {
            InitializeComponent();
        }

        private void Game1_Load(object sender, EventArgs e)
        {
           
        }

        public void updateGame()
        {
            // This will be responsible for updating the game based on user input, elapsed time etc.
            // This will cause the gravity to effect the user.
            game1_player.Top += gravity;

            // This will be responsible for moving the enemies.
            game1_enemy1.Left -= speed;
            game1_enemy2.Left -= speed;
            game1_enemy3.Left -= speed;
            game1_enemy4.Left -= speed;
            game1_enemy5.Left -= speed;
            game1_enemy6.Left -= speed;

            // This will be responsible for the conitnuous spawning of enemies.
            if (game1_enemy1.Left < -50)
            {
                game1_enemy1.Left = 750;
            }
            if (game1_enemy2.Left < -50)
            {
                game1_enemy2.Left = 750;
            }
            if (game1_enemy3.Left < -50)
            {
                game1_enemy3.Left = 750;
            }
            if (game1_enemy4.Left < -50)
            {
                game1_enemy4.Left = 750;
            }
            if (game1_enemy5.Left < -50)
            {
                game1_enemy5.Left = 750;
            }
            if (game1_enemy6.Left < -50)
            {
                game1_enemy6.Left = 750;
            }

            // Increase speed of the game as the user progresses.
            if (score == 50)
            {
                speed = 8;
            }
            if (score == 100)
            {
                speed = 10;
            }
            if (score == 150)
            {
                speed = 12;
            }
        }

        public void updateScore()
        {
            // This will update the users score depending on their progress.
            lbl_game1_score.Text = "Score: " + score;

            // This will update the score if the user has passed an enemy.
            if (game1_enemy1.Left < 0)
            {
                score++;
            }
        }

        public void checkCollisions()
        {
            // This will check for any collisions with game objects and update the game accordingly.

            if(game1_player.Bounds.IntersectsWith(game1_ground.Bounds) ||
               game1_player.Bounds.IntersectsWith(game1_enemy1.Bounds) ||
               game1_player.Bounds.IntersectsWith(game1_enemy2.Bounds) ||
               game1_player.Bounds.IntersectsWith(game1_enemy3.Bounds) ||
               game1_player.Bounds.IntersectsWith(game1_enemy4.Bounds) ||
               game1_player.Bounds.IntersectsWith(game1_enemy5.Bounds) ||
               game1_player.Bounds.IntersectsWith(game1_enemy6.Bounds))
            {
                gameEnd();
            }
        }

        public void gameStart()
        {
            // This will start a new game if the user decides to play again.
            
        }

        public void gameEnd()
        {
            // This will end the game, present text to the user and update the leaderboard.
            game1_timer.Stop();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            updateGame();
            checkCollisions();
            updateScore();
        }

        private void game1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void game1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
    } //End of ClydeArcade class
} //End of namespace