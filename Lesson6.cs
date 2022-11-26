using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2mirni_masyvy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] numbers = { { 1, 4, 2 },
            //                   { 3, 6, 8 } };

            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.Write(numbers[i, j]);
            //    }

            //    Console.WriteLine();
            //}


            Console.WriteLine("Enter field size");

            int fieldSize = Convert.ToInt32(Console.ReadLine());

            char[,] field = new char[fieldSize, fieldSize]; // створюємо масив

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = '*';
                }
            } // заповнюємо масив зірочками (робимо дошку)

            bool zero = true;
            bool gameOver = false;

            while (!gameOver)
            {
                Console.Clear();

                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        Console.Write(field[i, j] + " ");
                    }

                    Console.WriteLine();
                }  // виводимо таблицю (поле)

                gameOver = true;

                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        if (field[i, j] == '*')
                        {
                            gameOver = false;
                        }
                    }
                }

                if (gameOver)
                {
                    break;
                }

                Console.WriteLine("Enter coordinate"); 
                // отримуємо координати i j, на яких треба поставити 0 або Х

                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());

                if (x >= field.GetLength(0) || y >= field.GetLength(1))
                {
                    Console.WriteLine("Error! Array is not that big");
                    Console.ReadKey();

                    continue;
                }

                if (field[x, y] == '*')
                {
                    if (zero) // якщо останній був 0, ставимо Х
                    {
                        field[x, y] = 'X';
                    }
                    else
                    {
                        field[x, y] = 'O';
                    }

                    zero = !zero; // міняємо значення zero на протилежне
                }
            }
        }
    }
}