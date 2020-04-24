using System;

namespace ProgrammingCourseWork.Display
{
    public static class MainDisplay
    {
        public static void Display()
        {
            Console.Clear();

            Console.WriteLine("Изберете опция:");
            Console.WriteLine("1. Меню");
            Console.WriteLine("2. Купи");
            Console.WriteLine("3. Продажби");
            Console.WriteLine("4. Изход");
            string input = Console.ReadLine();
            if (input == "1")
            {
                MenuDisplay.Display();
            }
            else if (input == "2")
            {
                BuyDisplay.Display();
            }
            else if (input == "3")
            {
                SellsDisplay.Display();
            }
            else if (input == "4")
            {
                SellsDisplay.Display();
                Environment.Exit(0);
            }

            Display();
        }
    }
}
