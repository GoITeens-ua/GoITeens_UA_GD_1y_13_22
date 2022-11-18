using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    internal class Lesson4
    {
        static void Main(string[] args)
        {
            #region nested ifs

            bool a = true;
            bool b = false;

            if (a)
            {
                if (b)
                {

                }
                else
                {

                }
            }

            #endregion

            #region while

            string answer = "y";

            while (answer == "y")
            {
                Console.WriteLine("Enter two numbers:");

                int number1 = Convert.ToInt32(Console.ReadLine()); //отримуємо від користувача строку та конвертуємо в інт
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(number1 + number2); //виводимо суму

                Console.WriteLine("Enter Y to continue:");

                answer = Console.ReadLine().ToLower(); //зчитуємо змінну від користувача
            }

            #endregion

            #region do ... while

            string answer2;

            do
            {
                Console.WriteLine("Enter two numbers:");

                int number1 = Convert.ToInt32(Console.ReadLine()); //отримуємо від користувача строку та конвертуємо в інт
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(number1 + number2); //виводимо суму

                Console.WriteLine("Enter Y to continue:");

                answer2 = Console.ReadLine().ToLower(); //зчитуємо змінну від користувача
            } // код виконається хоча б один раз
            while (answer2 == "y");

            #endregion

            #region for

            int j = 0;

            while (j < 10)
            {
                Console.WriteLine(j);

                j++;
            }

            for (int i = 5; i < 100; i++) // (до циклу; умова; під час циклу) 
            {
                Console.WriteLine(i);
            } // цей код працює так само, як і попередній while

            int headsCounter = 0; // кількість орлів
            int tailsCounter = 0; // кількість решек

            Random random = new Random();

            for (int i = 0; i < 10000; i++)
            {
                int headsOrTails = random.Next(0, 2); // рандомне число 1 або 0

                if (headsOrTails == 0)
                {
                    headsCounter++; 
                }
                else
                {
                    tailsCounter++;
                }
            }

            Console.WriteLine($"Heads: {headsCounter} Tails: {tailsCounter}");

            #endregion

            #region break

            while (true)
            {
                string text = Console.ReadLine();

                if (text == "end")
                {
                    break; // виходимо з циклу
                }
            }

            #endregion

            #region continue

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0) // якщо число парне, ми пропускаємо крок (ітерацію)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            #endregion

            Console.ReadLine();
        }
    }
}
