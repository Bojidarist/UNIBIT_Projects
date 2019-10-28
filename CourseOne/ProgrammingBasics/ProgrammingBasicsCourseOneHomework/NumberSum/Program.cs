using System;

namespace NumberSum
{
    /// <summary>
    /// Напишете програма, която въвежда цяло число num и отпечатва сумата от цифрите му.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Ask the user for input
            Console.Write("Type a number: ");
            string input = Console.ReadLine();
            int sum = 0;

            // Do the calculations
            for (int i = 0; i < input.Length; i++)
            {
                int number = int.Parse(input[i].ToString());
                if (i == input.Length - 1)
                {
                    Console.Write($"{ number }");
                }
                else
                {
                    Console.Write($"{ number } + ");
                }
                sum += number;
            }

            // Print the sum to the console
            Console.Write($" = { sum }");

            // Wait for input so the program does not close
            Console.WriteLine("\nPress Any Key To Exit . . .");
            Console.ReadKey();
        }
    }
}
