using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClydeArcade
{
    public partial class Game3 : Form
    {
        string gameName = "Memory Match";
        string userName = "";
        int score = 0;

        int[] grid = new int[9];
        int timer = 0;
        int[] cards = new int[9];
        int chosenCards = 0;
        int[] cardImage = new int[9];
        int remainingTime = 30;

        public Game3()
        {
            InitializeComponent();
        }

        private void Game3_Load(object sender, EventArgs e)
        {
            // This will load the game with the images randomised.
            assignImages();

            // This will hide the game over screen at the beginning of the game.
            game3_gameOver.Visible = false;
            lbl_gameOver.Visible = false;
            btn_gameOverBack.Visible = false;
            btn_gameOverRetry.Visible = false;
        }

        public void checkMatch()
        {
            // This will check if the user has been successful in matching two cards.

            if (chosenCards == 1)
            {
                if (!btn_card1.Visible && !btn_card2.Visible)
                {
                    updateGame();
                }
            }
            else if (chosenCards == 3)
            {
                if (!btn_card3.Visible && !btn_card4.Visible)
                {
                    updateGame();
                }
            }
            else if (chosenCards == 5)
            {
                if (!btn_card5.Visible && !btn_card6.Visible)
                {
                    updateGame();
                }
            }
            else if (chosenCards == 7)
            {
                if (!btn_card7.Visible && !btn_card8.Visible)
                {
                    updateGame();
                }
            }
            else
            {
                // The selected card is not part of any matching pair
                hideCard(chosenCards);
            }
        }

        public void updateGame()
        {
            // This will update the score and timer based on users successful matches.

            // Increment the score by 1
            score += 1;
            lbl_score.Text = $"Score: {score}";

            // Increase the remaining time by 10 seconds
            remainingTime += 10;

            // Check if the user has won the game
            if (score == 4)
            {
                // The user has won the game, shuffle cards again
                assignImages();

                // Reset the chosenCards variable for the next match
                chosenCards = 0;

                // Reset the visible cards
                btn_hidden1.Visible = true;
                btn_hidden2.Visible = true;
                btn_hidden3.Visible = true;
                btn_hidden4.Visible = true;
                btn_hidden5.Visible = true;
                btn_hidden6.Visible = true;
                btn_hidden7.Visible = true;
                btn_hidden8.Visible = true;
                btn_hidden9.Visible = true;
            }

            // This will end the game if the timer reaches 0.
            if (remainingTime == 0)
            {
                gameEnd();
            }
        }

        public void assignImages()
        {
            // This will assign images to the cards.

            // Create a list to hold the button locations
            List<Point> buttonLocations = new List<Point>
            {
                btn_card1.Location,
                btn_card2.Location,
                btn_card3.Location,
                btn_card4.Location,
                btn_card5.Location,
                btn_card6.Location,
                btn_card7.Location,
                btn_card8.Location,
                btn_card9.Location
            };

            // Shuffle the button locations 
            Random rnd = new Random();
            int n = buttonLocations.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Point temp = buttonLocations[k];
                buttonLocations[k] = buttonLocations[n];
                buttonLocations[n] = temp;
            }

            // Assign the shuffled locations back to the buttons
            btn_card1.Location = buttonLocations[0];
            btn_card2.Location = buttonLocations[1];
            btn_card3.Location = buttonLocations[2];
            btn_card4.Location = buttonLocations[3];
            btn_card5.Location = buttonLocations[4];
            btn_card6.Location = buttonLocations[5];
            btn_card7.Location = buttonLocations[6];
            btn_card8.Location = buttonLocations[7];
            btn_card9.Location = buttonLocations[8];
        }

        public void revealCard(int chosenCards)
        {
            // This will reveal a card after a user selects it.

            // This will take the users input and hide the button covering the cards with images to reveal their choice.
            switch(chosenCards)
            {
                case 1:
                    btn_hidden1.Visible = false;
                    break;
                case 2:
                    btn_hidden2.Visible = false;
                    break;
                case 3:
                    btn_hidden3.Visible = false;
                    break;
                case 4:
                    btn_hidden4.Visible = false;
                    break;
                case 5:
                    btn_hidden5.Visible = false;
                    break;
                case 6:
                    btn_hidden6.Visible = false;
                    break;
                case 7:
                    btn_hidden7.Visible = false;
                    break;
                case 8:
                    btn_hidden8.Visible = false;
                    break;
                case 9:
                    btn_hidden9.Visible = false;
                    break;
            }
            checkMatch();
        }

        public void hideCard(int chosenCards)
        {
            // This will hide a card if a user is unsuccessful in making a match.

            // This will take the user input and hide the button showing the images
            switch (chosenCards)
            {
                case 1:
                    btn_hidden1.Visible = true;
                    break;
                case 2:
                    btn_hidden2.Visible = true;
                    break;
                case 3:
                    btn_hidden3.Visible = true;
                    break;
                case 4:
                    btn_hidden4.Visible = true;
                    break;
                case 5:
                    btn_hidden5.Visible = true;
                    break;
                case 6:
                    btn_hidden6.Visible = true;
                    break;
                case 7:
                    btn_hidden7.Visible = true;
                    break;
                case 8:
                    btn_hidden8.Visible = true;
                    break;
                case 9:
                    btn_hidden9.Visible = true;
                    break;
            }
            // Decrement the time by 10 seconds for a failed match.
            remainingTime -= 10;
        }

        public void gameEnd()
        {
            // This will end the game, present text to the user and update the leaderboard.
            game3_timer.Stop();

            // This will display game over text and options for the user to exit or retry.
            game3_gameOver.Visible = true;
            lbl_gameOver.Visible = true;
            btn_gameOverBack.Visible = true;
            btn_gameOverRetry.Visible = true;
            lbl_gameOver.Text = "Game Over!\n Score: " + score;
        }

        public void gameStart()
        {
            // This will start a new game if the user decides to play again.

            // Close the form and reopens it to restart the game.
            this.Close();
            Game3 game3 = new Game3();
            game3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_score_Click(object sender, EventArgs e)
        {

        }

        private void btn_card1_Click(object sender, EventArgs e)
        {

        }
        private void btn_hidden1_Click(object sender, EventArgs e)
        {
            // This will reveal a card after a user selects it.
            chosenCards = 1;
            revealCard(chosenCards);
        }

        private void btn_card2_Click(object sender, EventArgs e)
        {

        }
        private void btn_hidden2_Click(object sender, EventArgs e)
        {
            // This will reveal a card after a user selects it.
            chosenCards = 2;
            revealCard(chosenCards);
        }

        private void btn_card3_Click(object sender, EventArgs e)
        {

        }
        private void btn_hidden3_Click(object sender, EventArgs e)
        {
            // This will reveal a card after a user selects it.
            chosenCards = 3;
            revealCard(chosenCards);
        }

        private void btn_card4_Click(object sender, EventArgs e)
        {

        }
        private void btn_hidden4_Click(object sender, EventArgs e)
        {
            // This will reveal a card after a user selects it.
            chosenCards = 4;
            revealCard(chosenCards);
        }

        private void btn_card5_Click(object sender, EventArgs e)
        {

        }
        private void btn_hidden5_Click(object sender, EventArgs e)
        {
            // This will reveal a card after a user selects it.
            chosenCards = 5;
            revealCard(chosenCards);
        }

        private void btn_card6_Click(object sender, EventArgs e)
        {

        }
        private void btn_hidden6_Click(object sender, EventArgs e)
        {
            // This will reveal a card after a user selects it.
            chosenCards = 6;
            revealCard(chosenCards);
        }

        private void btn_card7_Click(object sender, EventArgs e)
        {

        }
        private void btn_hidden7_Click(object sender, EventArgs e)
        {
            // This will reveal a card after a user selects it.
            chosenCards = 7;
            revealCard(chosenCards);
        }

        private void btn_card8_Click(object sender, EventArgs e)
        {

        }
        private void btn_hidden8_Click(object sender, EventArgs e)
        {
            // This will reveal a card after a user selects it.
            chosenCards = 8;
            revealCard(chosenCards);
        }

        private void btn_card9_Click(object sender, EventArgs e)
        {

        }
        private void btn_hidden9_Click(object sender, EventArgs e)
        {
            // This will reveal a card after a user selects it.
            chosenCards = 9;
            revealCard(chosenCards);
        }

        private void btn_gameStart_Click(object sender, EventArgs e)
        {
            // This will start the timer for the game.
            game3_timer.Start();

            // This will hide the start button.
            btn_gameStart.Visible = false;
        }

        private void game3_timerTick(object sender, EventArgs e)
        {
            // Decrement the remaining time by 1 second.
            remainingTime--;

            if (remainingTime < 0)
            {
                // The game has ended.
                game3_timer.Stop();
                gameEnd();
            }

            // Update the clock with the remaining time.
            lbl_timer.Text = $"00:{remainingTime}";

        }

        private void lbl_gameOver_Click(object sender, EventArgs e)
        {

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

        private void gameOver_Click(object sender, EventArgs e)
        {

        }
    } //End of Game3 class
} //End of namespace
