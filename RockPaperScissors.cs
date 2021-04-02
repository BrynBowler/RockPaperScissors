using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class RockPaperScissors : Form
    {

        Opponent opponent1 = new Opponent();

        public int userScore = 0;
        public int opponentScore = 0;

        public RockPaperScissors()
        {
            InitializeComponent();
        }

        public void Rock_Click(object sender, EventArgs e)
        {
            string userPlay = "rock";
            userResult.Text = (userPlay);
            Result.Text = "In Play";
            opponentResult.Text = (opponent1.OpponentPlay());
            Rock.Enabled = false;
            Scissors.Enabled = false;
            Paper.Enabled = false;
        }

        public void Paper_Click(object sender, EventArgs e)
        {
            string userPlay = "paper";
            userResult.Text = (userPlay);
            Result.Text = "In Play";
            opponentResult.Text = (opponent1.OpponentPlay());
            Rock.Enabled = false;
            Scissors.Enabled = false;
            Paper.Enabled = false;
        }

        public void Scissors_Click(object sender, EventArgs e)
        {
            string userPlay = "scissors";
            userResult.Text = (userPlay);
            Result.Text = "In Play";
            opponentResult.Text = (opponent1.OpponentPlay());
            Rock.Enabled = false;
            Scissors.Enabled = false;
            Paper.Enabled = false;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string userTextbox = userResult.Text;
            string opponentTextbox = opponentResult.Text;


            if (userTextbox == opponentTextbox)
            {
                Result.Text = "Draw";
            }
            else if ((userTextbox == "rock") && (opponentTextbox == "scissors"))
            {
                Result.Text = "Win!";
                userScore++;
            }
            else if ((userTextbox == "scissors") && (opponentTextbox == "paper"))
            {
                Result.Text = "Win!";
                userScore++;
            }
            else if ((userTextbox == "paper") && (opponentTextbox == "rock"))
            {
                Result.Text = "Win!";
                userScore++;
            }
            else if ((userTextbox == "rock") && (opponentTextbox == "paper"))
            {
                Result.Text = "Lose...";
                opponentScore++;
            }
            else if ((userTextbox == "paper") && (opponentTextbox == "scissors"))
            {
                Result.Text = "Lose...";
                opponentScore++;
            }
            else if ((userTextbox == "scissors") && (opponentTextbox == "rock"))
            {
                Result.Text = "Lose...";
                opponentScore++;
            }

            userTalley.Text = userScore.ToString();
            opponentTalley.Text = opponentScore.ToString();

            Rock.Enabled = true;
            Scissors.Enabled = true;
            Paper.Enabled = true;

            opponentResult.Text = "";
            userResult.Text = "";
        }
        public void opponentResult_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void userPlay_TextChanged(object sender, EventArgs e)
        {

        }

        private void playResult_Click(object sender, EventArgs e)
        {
            
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
