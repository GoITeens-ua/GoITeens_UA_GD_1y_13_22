using System;
using System.Linq;

namespace orel_or_reshka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "Volvo", "Ford", "Audi", "Bentley" }; 

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (string car in cars)
            {
                // car = "ksdfhg"; // error, бо міняти значення змінних в foreach неможно
                Console.WriteLine(car);
            }

            Console.WriteLine();

            Array.Sort(cars);

            Array.Reverse(cars);

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            int[] numbers = { 2, 7, 1, 4, 6, 0 };

            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int[] grades = { 2, 6, 4, 10, 8, 12, 4, 5, 6, 12, 11 };

            Console.WriteLine(grades.Max());
            Console.WriteLine(grades.Min());

            Console.WriteLine(grades.Sum() / grades.Length); // середня оцінка

            int[] grades2 = { 3, 5, 8, 7, 9, 12, 11, 2, 10 };

            var allGrades = grades.Union(grades2); // поєднує два масиви

            foreach (int grade in allGrades)
            {
                Console.WriteLine(grade);
            }

            Console.ReadLine();
        }
    }
}
