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

        public RockPaperScissors()
        {
            InitializeComponent();
        }

        public void Rock_Click(object sender, EventArgs e)
        {
            string userPlay = "rock";
            opponentResult.Text = (opponent1.OpponentPlay());
            userResult.Text = (userPlay);
        }

        public void Paper_Click(object sender, EventArgs e)
        {
            string userPlay = "paper";
            opponentResult.Text = (opponent1.OpponentPlay());
            userResult.Text = (userPlay);
        }

        public void Scissors_Click(object sender, EventArgs e)
        {
            string userPlay = "scissors";
            opponentResult.Text = (opponent1.OpponentPlay());
            userResult.Text = (userPlay);
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
    }
}
