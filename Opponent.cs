using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class Opponent
    {
        public string OpponentPlay()
        {
            string[] play = { "rock", "paper", "scissors" };

            Random rand = new Random();

            int index = rand.Next(play.Length);

            string result = $"{play[index]}";
            return result;
        }
    }
}
