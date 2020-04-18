using System;

namespace FactorialCalculator
{
    /// <summary>
    /// Задача: Да се изчисли N! (1 ≤ N ≤ 12), като се има предвид че 5!=5*4*3*2*1 или 9!= 9*8*7*6*5*4*3*2*1. 
    /// Нека от конзолата да се зададе стойност за N.
    /// На екрана да се отпечата следното:
    /// „ N! = ………………“ , където N да е въведеното от потребителя число, 
    /// а след равенството да се извежда стойността на N!
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Ask the user for input
            Console.WriteLine("Factorial calculator (1 ≤ N ≤ 12)");
            Console.Write("N = ");
            string input = Console.ReadLine();
            // Try to parse the input to an integer
            bool parseSuccess = int.TryParse(input, out int n);
            int factorial = 1;

            // If the parsing is successful and in range, do the calculations
            if (parseSuccess)
            {
                if (1 <= n && n <= 12)
                {
                    Console.Write($"{ n }! = ");
                    for (int i = n; i >= 1; i--)
                    {
                        if (i != 1)
                        {
                            Console.Write($"{ i } * ");
                        }
                        else
                        {
                            Console.Write($"{ i }");
                        }
                        factorial *= i;
                    }

                    Console.Write($" = { factorial }\n");
                }
                else
                {
                    Console.WriteLine("The input is not in the range (1 ≤ N ≤ 12)");
                }
            }
            // If the parsing is not successful, notify the user
            else
            {
                Console.WriteLine("Wrong input!");
            }

            // Wait for input so the program does not close
            Console.WriteLine("\nPress Any Key To Exit . . .");
            Console.ReadKey();
        }
    }
}
