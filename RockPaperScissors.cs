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
        public RockPaperScissors()
        {
            InitializeComponent();
        }

        public void Rock_Click(object sender, EventArgs e)
        {
            string userPlay = "rock";
        }

        public void Paper_Click(object sender, EventArgs e)
        {
            string userPlay = "paper";
        }

        public void Scissor_Click(object sender, EventArgs e)
        {
            string userPlay = "scissors";
        }
    }
}
