using ProgrammingCourseWork.Helpers;
using System;

namespace ProgrammingCourseWork.Display
{
    public static class MenuDisplay
    {
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine("Напишете 'назад' за да се върнете или въведете продукт за менюто\nПример: салата, Шопска салата, 350, 2.50");
            Console.WriteLine("\nМеню:");
            SingletonRestoraunt.Instance.PrintMenu();
            string input = Console.ReadLine();
            if (input.ToLower() == "назад")
            {
                return;
            }
            var product = input.ToProduct();
            SingletonRestoraunt.Instance.Menu.Add(product.Name.ToLower().Trim(), product);
            Display();
        }
    }
}
