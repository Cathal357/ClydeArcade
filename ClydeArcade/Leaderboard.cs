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
            // This is to prevent the game from running if the user closes the form.
            Leaderboard l1 = new Leaderboard();

            if (l1 == null)
            {
                foreach (Form f in Application.OpenForms)
                {
                    f.Close();
                }
            }
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
    } //End of Leaderboard class
} //End of namespace


