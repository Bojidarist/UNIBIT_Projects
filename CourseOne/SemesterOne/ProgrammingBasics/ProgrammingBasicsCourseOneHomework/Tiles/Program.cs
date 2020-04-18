using System;

namespace Tiles
{
    /// <summary>
    /// На детска площадка трябва да се поставят плочки. 
    /// Площадката е с форма на квадрат със страна N метра. 
    /// Плочките са широки „W“ метра и дълги „L“ метра. 
    /// На площадката има една пейка с ширина M метра и дължина „O“ метра. 
    /// Под нея не е нужно да се слагат плочки. Всяка плочка се поставя за 0.2 минути.
    /// 
    /// Напишете програма, която чете от конзолата размерите на площадката, 
    /// плочките и пейката и пресмята колко плочки са необходими да се покрие площадката
    /// и пресмята времето за поставяне на всички плочки.
    /// 
    /// Пример: площадка с размер 20м. има площ 400кв.м. 
    /// Пейка широка 1м. и дълга 2м., заема площ 2кв.м. 
    /// Една плочка е широка 5м. и дълга 4м. има площ = 20кв.м. 
    /// Площта която трябва да се покрие е 400 – 2 = 398 кв.м. 
    /// Необходими са 398 / 20 = 19.90 плочки. 
    /// Необходимото време е 19.90 * 0.2 = 3.98 минути.
    /// 
    /// От конзолата се четат 5 числа:
    /// + N – дължината на страна от площадката в интервала [1...100]
    /// + W – широчината на една плочка в интервала [0.1...10.00]
    /// + L – дължината на една плочка в интервала [0.1...10.00]
    /// + М – широчината на пейката в интервала [0...10]
    /// + О – дължината на пейката в интервала [0...10]
    /// Да се отпечата на конзолата две числа: броят плочки необходи за ремонта и времето за поставяне. 
    /// </summary>
    class Program
    {
        static void Main()
        {
            // The time needed for a single tile to be placed (in minutes)
            const double timePerTile = 0.2;

            // Ask the user for input
            Console.Write("Length of playground's side [1...100](N): ");
            double playgroundWidth = double.Parse(Console.ReadLine());
            Console.Write("Width of a single tile [0.1...10.00](W): ");
            double tileWidth = double.Parse(Console.ReadLine());
            Console.Write("Length of a single tile [0.1...10.00](L): ");
            double tileLength = double.Parse(Console.ReadLine());
            Console.Write("Width of the bench [0...10](M): ");
            double benchWidth = double.Parse(Console.ReadLine());
            Console.Write("Length of the bench [0...10](O): ");
            double benchLength = double.Parse(Console.ReadLine());

            // Check if the input range is correct
            bool isInputCorrect = IsInputCorrect(playgroundWidth, tileWidth, tileLength, benchWidth, benchLength);
            if (!isInputCorrect)
            {
                Console.WriteLine("\nInput was not in the correct range!");

                // Wait for input so the program does not close
                Console.WriteLine("\nPress Any Key To Exit . . .");
                Console.ReadKey();
                return;
            }

            // Do the calculations
            double playgroundArea = playgroundWidth * playgroundWidth;
            double benchArea = benchWidth * benchLength;
            double tileArea = tileWidth * tileLength;
            double areaWithoudBench = playgroundArea - benchArea;
            double tilesNeeded = areaWithoudBench / tileArea;
            double timeNeeded = tilesNeeded * timePerTile;

            // Print the result to the console
            Console.WriteLine($"\nTiles needed: { tilesNeeded }");
            Console.WriteLine($"Time needed: { timeNeeded } minutes");

            // Wait for input so the program does not close
            Console.WriteLine("\nPress Any Key To Exit . . .");
            Console.ReadKey();
        }

        /// <summary>
        /// Checks if the input is in the correct range
        /// </summary>
        private static bool IsInputCorrect(double playgroundWidth, double tileWidth, double tileLength, double benchWidth, double benchLength)
        {
            if (!(1 <= playgroundWidth && playgroundWidth <= 100))
            {
                return false;
            }
            else if (!(0.1 <= tileWidth && tileWidth <= 10))
            {
                return false;
            }
            else if (!(0.1 <= tileLength && tileLength <= 10))
            {
                return false;
            }
            else if (!(0 <= benchWidth && benchWidth <= 10))
            {
                return false;
            }
            else if (!(0 <= benchLength && benchLength <= 10))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
