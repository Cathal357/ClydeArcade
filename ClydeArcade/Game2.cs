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
    public partial class Game2 : Form
    {
        string gameName = "";
        string userName = "";
        int score = 0;

        int snake = 0;
        int snakeSize = 0;
        int food = 0;

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

        }

        public void updateSnake()
        {
            // This will be responsible for updating the snakes body based on user inputs.

        }

        public void updateScore()
        {
            // This will update the users score depending on their progress.

        }

        public void gameStart()
        {
            // This will start a new game if the user decides to play again.

        }

        public void gameEnd()
        {
            // This will end the game, present text to the user and update the leaderboard.

        }
    } //End of ClydeArcade class
} //End of namespace