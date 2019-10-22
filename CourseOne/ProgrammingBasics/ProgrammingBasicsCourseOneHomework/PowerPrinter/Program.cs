using System;

namespace PowerPrinter
{
    /// <summary>
    /// Задача: Напишете програма, която чете от конзолата цяло число n и печата числата от 2^0 до 2^n.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Ask the user for input
            Console.Write("Raise 2 to a power of: ");
            string input = Console.ReadLine();

            // Try to parse the input...
            if (int.TryParse(input, out int result))
            {
                if (result < 0)
                {
                    // ...if the parse is successful write all numbers from 2^0 to 2^n
                    for (int i = 0; i >= result; i--)
                    {
                        Console.Write("2 ^ {0} = {1}\n", i, Math.Pow(2, i));
                    }
                }
                else
                {
                    // ...if the parse is successful write all numbers from 2^0 to 2^n
                    for (int i = 0; i <= result; i++)
                    {
                        Console.Write("2 ^ {0} = {1}\n", i, Math.Pow(2, i));
                    }
                }
            }
            else
            {
                // ...if the parse is not successful, notify the user ( {{ -> escaped curly bracket )
                Console.WriteLine($"Wrong input {{ { input } }}! Make sure it is a number.");
            }

            // Wait for input so the program does not close
            Console.WriteLine("Press Any Key To Exit . . .");
            Console.ReadKey();
        }
    }
}
