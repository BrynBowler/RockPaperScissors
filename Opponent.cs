using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class Opponent
    {
        public static void opponentPlay() 
        {
            string[] play = { "rock", "paper", "scissors" };

            Random rand = new Random();

            int index = rand.Next(play.Length);

            Console.WriteLine($"{play[index]}");

            Console.ReadLine();
        }
    }
}
