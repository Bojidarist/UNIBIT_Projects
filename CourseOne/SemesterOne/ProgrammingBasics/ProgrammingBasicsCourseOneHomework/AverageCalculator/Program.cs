using System;

namespace AverageCalculator
{
    /// <summary>
    /// Задача: Съставете цикличен алгоритъм, 
    /// изчисляващ средно аритметично на n-числа,
    /// чийто стойности се въвеждат от потребителя.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Ask the user for the amount of numbers
            Console.Write("Number count (n): ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            // Ask the user to provide the needed numbers
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Number { i + 1 } will be: ");
                sum += double.Parse(Console.ReadLine());
            }

            // Add a new line for clearer output
            Console.WriteLine();
            // Calculate the average value of all numbers and print it
            Console.WriteLine($"Sum = { sum }");
            Console.WriteLine($"Count = { n }");
            Console.WriteLine($"Average = { sum / n }");

            // Wait for input so the program does not close
            Console.WriteLine("Press Any Key To Exit . . .");
            Console.ReadKey();
        }
    }
}
