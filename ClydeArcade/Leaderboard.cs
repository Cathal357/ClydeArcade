﻿using System;
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
    public partial class Leaderboard : Form
    {
        string gameName = "";
        string userName = "";
        int score = 0;

        int[] scoreArray = new int[100];

        public Leaderboard()
        {
            InitializeComponent();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            
        }

        public void showTopScore()
        {
            // This will return a list of the top three high scores.

        }

        public void addTopScore()
        {
            // This will store a new top score alongside the username of who achieved the score.

        }

        public void updateScore()
        {
            // This will update the leaderboard with a new top score.

        }

        private void btn_game1_Click(object sender, EventArgs e)
        {
            // This will take the user back to the arcade menu screen.

            // This will hide the current display.
                 this.Hide();

            // This will create an instance of the arcade class and display it.
                ClydeArcade a1 = new ClydeArcade();
                a1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void leaderboard_formClose(object sender, FormClosingEventArgs e)
        {
            // This will run as a failsafe to ensure that the program doesn't run in the background.
            foreach (Form f in Application.OpenForms)
            {
                f.Close();
                System.Environment.Exit(1);
            }
        }
    } //End of Leaderboard class
} //End of namespace


