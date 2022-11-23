using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Homework3
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string answer;
            int randomNumber;

            do
            {
                Console.WriteLine("Make your gues! Heads or tails? To End the game enter 'end'");

                answer = Console.ReadLine();
                randomNumber = random.Next(0, 2);

                if (answer == "heads" || answer == "tails")
                {
                    if (randomNumber == 0 && answer == "tails")
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (randomNumber == 1 && answer == "heads")
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }
                }
            }
            while (answer != "end");
        }
    }
}
