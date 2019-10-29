using System;

namespace ArraySorter
{
    /// <summary>
    /// Да се въведе от конзолата едномерен масив от цели числа и да се сортира по низходящ ред.
    /// Да се изведе сортирания масив.
    /// Да се изведе минималния му елемент.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Get the input array
            Console.Write("Type an array of numbers separated by spaces: ");
            string[] input = Console.ReadLine().Split(' ');
            int[] intArray = StringToIntArray(input);

            // Sort the array (descending)
            Array.Sort(intArray);
            Array.Reverse(intArray);

            // Find the min value in the array
            int min = FindMinInArray(intArray);

            // Display solution
            Console.WriteLine($"Sorted array: { PrettyPrintArray(intArray) }");
            Console.WriteLine($"The min value is: { min }");

            // Wait for input so the program does not close
            Console.WriteLine("\nPress Any Key To Exit . . .");
            Console.ReadKey();
        }

        /// <summary>
        /// Convert string array to int array
        /// </summary>
        static int[] StringToIntArray(string[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = int.Parse(array[i]);
            }

            return result;
        }

        /// <summary>
        /// Find the minimum value in a int array
        /// </summary>
        static int FindMinInArray(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        /// <summary>
        /// Pretty print a int array ({ 1 2 3 4 })
        /// </summary>
        static string PrettyPrintArray(int[] array)
        {
            string result = "{";
            for (int i = 0; i < array.Length; i++)
            {
                result += $" { array[i] } ";
            }
            result += "}";

            return result;
        }
    }
}
