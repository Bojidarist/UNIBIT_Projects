using ProgrammingCourseWork.Display;
using System;
using System.Text;

namespace ProgrammingCourseWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Bulgarian text
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding("windows-1251");

            // Main Menu
            MainDisplay.Display();
        }
    }
}
