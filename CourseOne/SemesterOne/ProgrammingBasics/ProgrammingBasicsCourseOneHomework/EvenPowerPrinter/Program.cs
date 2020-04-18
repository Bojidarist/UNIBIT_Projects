using System;

namespace EvenPowerPrinter
{
    /// <summary>
    /// Задача: Да се напише програма, която въвежда n и печата четните степени на 2 ≤ 2^n: 2^0, 2^2, 2^4, 2^8, …, 2^n.
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
                    // ...if the parse is successful write all negative even powers of two
                    for (int i = 0; i >= result; i--)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("2 ^ {0} = {1}\n", i, Math.Pow(2, i));
                        }
                    }
                }
                else
                {
                    // ...if the parse is successful write all positive even powers of two
                    for (int i = 0; i <= result; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("2 ^ {0} = {1}\n", i, Math.Pow(2, i));
                        }
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
