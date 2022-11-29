using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Lesson7
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name and age: ");

            //string name = Console.ReadLine();
            //int age = Convert.ToInt32(Console.ReadLine());
            //string birthday = Console.ReadLine();

            //WriteNameAndAge(name, age, birthday);

            //Console.WriteLine("Enter a number");

            //int number = Convert.ToInt32(Console.ReadLine());
            //int trippledNumber = TrippleNumber(number);

            //Console.WriteLine($"{number * 3} = {trippledNumber}");

            Console.WriteLine(UkrainianGreeting("Slava Ukraini"));
            Console.WriteLine(UkrainianGreeting("Ukraina"));
            Console.WriteLine(UkrainianGreeting("Slava nazii"));

            Console.ReadLine();
        }

        public static void WriteNameAndAge(string name, int age, string birthday)
        {
            Console.WriteLine($"Name: {name} Age: {age}, Birthday: {birthday}");
        }

        public static int TrippleNumber(int number) 
            => number * 3;

        public static int TrippleNumber1(int number)
        {
            return number * 3;
        }

        public static string UkrainianGreeting(string text)
        {
            string answer;

            if(text == "Slava Ukraini")
            {
                answer = "Geroyam slava!";
            }
            else if(text == "Ukraina")
            {
                answer = "Ponad use!";
            }
            else if(text == "Slava nazii")
            {
                answer = "Smert vorogam!";
            }
            else
            {
                answer = ";(";
            }

            return answer;
        }
    }
}