using System;
using System.Linq;

namespace ProgrammingCourseWork.Display
{
    public static class BuyDisplay
    {
        public static void Display()
        {
            Console.Clear();

            Console.WriteLine("Напишете 'назад' за да се върнете или КОПУВАЙТЕЕ!!!\nПример: 1, Шопска салата, Таратор, Мусака");

            string input = Console.ReadLine();
            if (input.ToLower() == "назад")
            {
                return;
            }

            string[] cmd = input.Split(',');
            if (SingletonRestoraunt.Instance.Buy(int.Parse(cmd[0]), cmd.Skip(1).Take(cmd.Length - 1).ToArray()))
            {
                Console.WriteLine("Покупката успешна");
            }
            else
            {
                Console.WriteLine("Покупката неуспешна");
            }

            Display();
        }
    }
}
