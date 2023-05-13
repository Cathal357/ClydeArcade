using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClydeArcade
{
    public partial class Game2 : Form
    {
        // Declaring variables that will store in the database.
        string gameName = "Snake Escape";
        string userName = "";
        int score = 0;

        // Declaring variables that will be used in the game.
        int snake = 0;
        int snakeSize = 0;
        int food = 0;
        int snakeSpeed = 10;
        string direction = "right";

        public Game2()
        {
            InitializeComponent();
        }

        private void Game2_Load(object sender, EventArgs e)
        {
            
        }

        public void checkCollisions()
        {
            // This will check for any collisions with game objects and update the game accordingly.

            // This will check for collisions with the borders.
            if (game2_head.Bounds.IntersectsWith(game2_border1.Bounds) ||
                game2_head.Bounds.IntersectsWith(game2_border2.Bounds) ||
                game2_head.Bounds.IntersectsWith(game2_border3.Bounds) ||
                game2_head.Bounds.IntersectsWith(game2_border4.Bounds) ||
                game2_head.Bounds.IntersectsWith(game2_body.Bounds))
            {
                gameEnd();
            }

            // This will check for collisions with the food.
            if (game2_head.Bounds.IntersectsWith(game2_food.Bounds))
            {
                // This will call method to update score text.
                updateScore();

                // This will increment the score.
                score += 1;

                // This will hide the food and make it reappear somewhere else.

                // Get the the minimum and maximum x and y coordinates where the food can appear.
                int minX = game2_border1.Location.X + game2_food.Width;
                int maxX = game2_border1.Location.X + game2_border1.Width - game2_food.Width;
                int minY = game2_border1.Location.Y + game2_food.Height;
                int maxY = game2_border1.Location.Y + game2_border1.Height - game2_food.Height;

                // Generate random coordinates for the food within the confines of the borders.
                Random random = new Random();
                int x = random.Next(0, this.Width - game2_food.Width);
                int y = random.Next(0, this.Height - game2_food.Height);
                game2_food.Location = new Point(x, y);

                // This will add a new body part to the snake after eating food.

            }
        }

        public void updateSnake()
        {
            // This will be responsible for updating the snakes body based on user inputs.

            // This will move the snakes head in the direction the user inputs.
            if (direction == "right")
            {
                game2_head.Left += snakeSpeed;
            }
            else if (direction == "left")
            {
                game2_head.Left -= snakeSpeed;
            }
            else if (direction == "up")
            {
                game2_head.Top -= snakeSpeed;
            }
            else if (direction == "down")
            {
                game2_head.Top += snakeSpeed;
            }
        }

        public void updateScore()
        {
            // This will update the users score depending on their progress.
            lbl_game2_score.Text = "Score: " + score;
        }

        public void gameStart()
        {
            // This will start a new game if the user decides to play again.
            
            // Close the form and reopens it to restart the game.
            this.Close();
            Game2 game2 = new Game2();
            game2.Show();

            // This is to prevent the game from running if the user closes the form.
            if(game2 == null)
            {
                foreach (Form f in Application.OpenForms)
                {
                    f.Close();
                }
            }
        }

        public void gameEnd()
        {
            // This will end the game, present text to the user and update the leaderboard.
            game2_timer.Stop();

            // This will display game over text and options for the user to exit or retry.
            game2_gameOver.Visible = true;
            lbl_gameOver.Visible = true;
            btn_gameOverBack.Visible = true;
            btn_gameOverRetry.Visible = true;
            lbl_gameOver.Text = "Game Over!\n Score: " + score;
        }

        private void game2_KeyDown(object sender, KeyEventArgs e)
        {
            // Check which key was pressed and set the direction accordingly
            if (e.KeyCode == Keys.Right)
            {
                direction = "right";
            }
            else if (e.KeyCode == Keys.Left)
            {
                direction = "left";
            }
            else if (e.KeyCode == Keys.Up)
            {
                direction = "up";
            }
            else if (e.KeyCode == Keys.Down)
            {
                direction = "down";
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // Set the focus to so that user inputs have priority over the buttons
            this.Focus();

            // This will hide the game over screen at the beginning of the game.
            game2_gameOver.Visible = false;
            lbl_gameOver.Visible = false;
            btn_gameOverBack.Visible = false;
            btn_gameOverRetry.Visible = false;

            // This will call the methods that will update, check collisions and update the score.
            updateSnake();
            checkCollisions();
            updateScore();
        }

        private void btn_gameOverRetry_Click(object sender, EventArgs e)
        {
            gameStart();
        }

        private void btn_gameOverBack_Click(object sender, EventArgs e)
        {
            // This will take the user back to the arcade menu screen.

            // This will hide the current display.
            this.Hide();

            // This will create an instance of the arcade class and display it.
            ClydeArcade a1 = new ClydeArcade();
            a1.ShowDialog();
        }
    } //End of ClydeArcade class
} //End of namespace