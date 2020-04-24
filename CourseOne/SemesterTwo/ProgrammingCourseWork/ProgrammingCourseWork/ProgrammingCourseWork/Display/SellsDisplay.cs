using System;

namespace ProgrammingCourseWork.Display
{
    public static class SellsDisplay
    {
        public static void Display()
        {
            Console.Clear();

            SingletonRestoraunt.Instance.PrintSells();

            Console.ReadKey();
        }
    }
}
