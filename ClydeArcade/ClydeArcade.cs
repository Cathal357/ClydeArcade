﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

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

            // This will hide the current display.
            this.Hide();

            // This will create an instance of the leaderboard class and display it.
            Game1 g1 = new Game1();
            g1.ShowDialog();

            // This will re-display the arcade if Leaderboard is force closed.
            g1 = null;
            this.Show();
        }

        public void playGame2()
        {
            // This will start game 2 and prompt the user to input a username for scoring purposes.

            // This will hide the current display.
            this.Hide();

            // This will create an instance of the leaderboard class and display it.
            Game2 g2 = new Game2();
            g2.ShowDialog();

            // This will re-display the arcade if Leaderboard is force closed.
            g2 = null;
            this.Show();
        }

        public void playGame3()
        {
            // This will start game 3 and prompt the user to input a username for scoring purposes.

            // This will hide the current display.
            this.Hide();

            // This will create an instance of the leaderboard class and display it.
            Game3 g3 = new Game3();
            g3.ShowDialog();

            // This will re-display the arcade if Leaderboard is force closed.
            g3 = null;
            this.Show();
        }

        public void showLeaderboard()
        {
            // This will show the leaderboard containing the top 3 scores for each game and who achieved those scores.

            // This will hide the current display.
                this.Hide();

            // This will create an instance of the leaderboard class and display it.
                Leaderboard l1 = new Leaderboard();
                l1.ShowDialog();

            // This will re-display the arcade if Leaderboard is force closed.
                l1 = null;
                this.Show();
        }

        public void exit()
        {
            // This will exit the program and shut down the arcade.

            // This will loop the statement to make sure all windows are closed.
                foreach (Form f in Application.OpenForms)
                {
                    f.Close();
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_game1_Click(object sender, EventArgs e)
        {
            playGame1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playGame2();
        }

        private void btn_game3_Click(object sender, EventArgs e)
        {
            playGame3();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showLeaderboard();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            exit();
        }
    } //End of ClydeArcade class
} //End of namespace
