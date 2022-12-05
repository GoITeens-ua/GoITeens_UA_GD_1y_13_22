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
            Console.WriteLine("Enter field size");

            int fieldSize;

            try
            {
                fieldSize = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                fieldSize = 3;
            }

            char[,] field = CreateField(fieldSize); 

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

                Console.WriteLine("Enter coordinate");
                // отримуємо координати i j, на яких треба поставити 0 або Х

                int x = 0, y = 0;

                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                }

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

                if (Win(field, 'X'))
                {
                    Console.WriteLine("X won!");
                    gameOver = true;
                }
                else if (Win(field, 'O'))
                {
                    Console.WriteLine("O won!");
                    gameOver = true;
                }
                else if (IsDraw(field))
                {
                    Console.WriteLine("Draw!");
                    gameOver = true;
                }
            }

            Console.WriteLine("Game Over!");

            Console.ReadLine();
        }

        public static char[,] CreateField(int fieldSize)
        {
            char[,] field = new char[fieldSize, fieldSize]; // створюємо масив

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = '*';
                }
            } // заповнюємо масив зірочками (робимо дошку)

            return field;
        }

        public static bool IsDraw(char[,] field)
        {
            bool isDraw = true;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == '*')
                    {
                        isDraw = false;
                    }
                }
            }

            return isDraw;
        }

        public static bool Win(char[,] field, char character)
        {
            bool win = false;
            int charCounter = 0;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == character)
                    {
                        charCounter++;
                    }
                }

                if(charCounter == field.GetLength(1))
                {
                    win = true;
                    break;
                }
                else
                {
                    charCounter = 0;
                }
            }

            return win;
        }
    }
}