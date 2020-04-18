using System;

namespace BrickWorkers
{
    /// <summary>
    /// Задача: Строителни работници трябва да пренесат общо x тухли. 
    /// Работниците са w на брой и работят едновременно.
    /// Те превозват тухлите в колички, всяка с вместимост m тухли.
    /// Напишете програма, която прочита целите числа x, w и m 
    /// и пресмята колко най-малко курса трябва да направят работниците за да превозят тухлите.
    /// 
    /// От конзолата се четат 3 цели числа (по едно на ред):
    /// + Броят тухли x се чете от първия ред.
    /// + Броят работници w се чете от втория ред.
    /// + Вместимостта на количката m се чете от третия ред.
    /// Всички входни числа са цели и в диапазона [1…1000].
    /// Да се отпечата на конзолата минималният брой курсове, необходими за превозване на тухлите.
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.Write("Bricks: ");
            var bricks = int.Parse(Console.ReadLine());           // Input for x
            Console.Write("Workers: ");
            var workers = int.Parse(Console.ReadLine());          // Input for w
            Console.Write("Bricks per cart: ");
            var bricksPerCart = int.Parse(Console.ReadLine());     // Input for m

            // Check if all inputs are in the range [1 ... 1000]
            if (!(bricks >= 1 && workers >= 1 && bricksPerCart >= 1))
            {
                Console.WriteLine("The input is not in the range [1 ... 1000]!");
                Console.WriteLine("Press Any Key To Exit . . .");
                Console.ReadKey();
                return;
            }
            else if (!(bricks <= 1000 && workers <= 1000 && bricksPerCart <= 1000))
            {
                Console.WriteLine("The input is not in the range [1 ... 1000]!");
                Console.WriteLine("Press Any Key To Exit . . .");
                Console.ReadKey();
                return;
            }

            // Calculate the courses and print them to the console
            double bricksPerCourse = workers * bricksPerCart;
            double courses = Math.Ceiling(bricks / bricksPerCourse);
            Console.WriteLine($"Courses: { courses }");

            // Wait for input so the program does not close
            Console.WriteLine("Press Any Key To Exit . . .");
            Console.ReadKey();
        }
    }
}
