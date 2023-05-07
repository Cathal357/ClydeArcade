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

        }

        public void updateScore()
        {
            // This will update the users score depending on their progress.

        }

        public void checkCollisions()
        {
            // This will check for any collisions with game objects and update the game accordingly.

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