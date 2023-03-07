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
    public partial class ClydeArcade : Form
    {
        public ClydeArcade()
        {
            InitializeComponent();
        }

        private void ClydeArcade_Load(object sender, EventArgs e)
        {

        }

        public void displayMenu()
        {
            // This will display the menu that allows the user to select their choice.
        }

        public void playGame1()
        {
            // This will start game 1 and prompt the user to input a username for scoring purposes.
        }

        public void playGame2()
        {
            // This will start game 2 and prompt the user to input a username for scoring purposes.
        }

        public void playGame3()
        {
            // This will start game 3 and prompt the user to input a username for scoring purposes.
        }

        public void showLeaderboard()
        {
            // This will show the leaderboard containing the top 3 scores for each game and who achieved those scores.
        }

        public void exit()
        {
            // This will exit the program and shut down the arcade.
        }

    } //End of ClydeArcade class
} //End of namespace
