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
    public partial class Game3 : Form
    {
        public Game3()
        {
            InitializeComponent();
        }

        private void Game3_Load(object sender, EventArgs e)
        {
            string gameName = "Memory Match";
            string userName = "";
            int score = 0;

            int[] grid = new int[8];
            int timer = 0;
            int[] cards = new int[8];
            int chosenCards = 0;
            int[] cardImage = new int[8];
        }

        public void checkMatch()
        {
            // This will check if the user has been successful in matching two cards.

        }

        public void updateGame()
        {
            // This will update the score and timer based on users successful or unsuccessful matches.

        }

        public void assignImages()
        {
            // This will be responsible for assigning images to the different cards.

        }

        public void revealCard()
        {
            // This will reveal a card after a user selects it.

        }

        public void hideCard()
        {
            // This will hide a card if a user is unsuccessful in making a match.

        }

        public void gameStart()
        {
            // This will start a new game if the user decides to play again.

        }

        public void gameEnd()
        {
            // This will end the game, present text to the user and update the leaderboard.

        }

    } //End of Game3 class
} //End of namespace
