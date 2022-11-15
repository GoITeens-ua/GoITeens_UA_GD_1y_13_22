using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ifStatement
{
    internal class Lesson3
    {
        static void Main(string[] args)
        {
            const string slavaUkraine = "Slava Ukraine";
            const string geroyamSlava = "Geroyam slava!";
            const string slavaNazii = "Slava nazii";
            const string smertVorogam = "Smert vorogam!";


            Console.WriteLine("Enter number");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 100)
            {
                Console.WriteLine("Bagato");
            }

            if (number % 2 == 1)
            {
                Console.WriteLine("Neparne");
            }

            Console.WriteLine("Enter phrase");

            string phrase = Console.ReadLine();

            if (phrase == "Slava Ukraine")
            {
                Console.WriteLine(geroyamSlava);
            }

            if (number > 100)
            {
                Console.WriteLine("Bagato");
            }
            else
            {
                Console.WriteLine("malo");
            }

            if (number % 2 == 1)
            {
                Console.WriteLine("Neparne");
            }
            else
            {
                Console.WriteLine("Parne");
            }

            Random random = new Random();

            int randomNumber = random.Next(0, 2);

            Console.WriteLine("Orel abo reshka?");

            if (randomNumber == 0)
            {
                Console.WriteLine("reshka");
            }

            Console.WriteLine("Orel abo reshka?");

            if (randomNumber == 0)
            {
                Console.WriteLine("reshka");
            }
            else
            {
                Console.WriteLine("orel");
            }

            Console.WriteLine("enter 2 numbers");

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number1 >= number2 ? "number1 is greater or equals" : "number2 is greater");

            if (phrase == slavaUkraine)
            {
                Console.WriteLine(geroyamSlava);
            }
            else if (phrase == slavaNazii)
            {
                Console.WriteLine(smertVorogam);
            }

            switch (phrase)
            {
                case slavaUkraine:
                    Console.WriteLine(geroyamSlava);
                    break;
                case slavaNazii:
                    Console.WriteLine(smertVorogam);
                    break;
                default:
                    Console.WriteLine(":(");
                    break;
            }

            Console.ReadLine();
        }
    }
}
