using System;

namespace IvanTheProgrammer
{
    /// <summary>
    /// Задача: Иван е програмист в американска компания
    /// и работи от вкъщи средно N дни в месеца като изкарва средно по M долара на ден. 
    /// В края на годината Иван получава бонус, който е равен на 2.5 месечни заплати. 
    /// От спечеленото през годината му се удържат 25% данъци. 
    /// Напишете програма, която да пресмята, колко е чистата средна печалба на Иван на ден в лева,
    /// тъй като той харчи изкараното в България. 
    /// Приема се, че в годината има точно 365 дни. 
    /// Курсът на долара спрямо лева ще се чете от конзолата.
    /// 
    /// От конзолата се четат 3 числа:
    /// + На първия ред – работни дни в месеца. Цяло число в интервала [5…30]
    /// + На втория ред – изкарани пари на ден. Реално число в интервала [10.00… 2000.00]
    /// + На третия ред – курсът на долара спрямо  лева /1 долар = X лева/. ->
    /// ->  Реално число в интервала [0.99… 1.99] – не се изисква проверка за зададените интервали.
    /// 
    /// На конзолата да се отпечата 1 число – средната печалба на ден в лева. 
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Ask the user for input (no check is required for the inputs)
            Console.Write("Working days in month [5...30]: ");
            int workingDaysInMonth = int.Parse(Console.ReadLine());
            Console.Write("Money per day [10.00...2000.00]: ");
            double moneyPerDay = double.Parse(Console.ReadLine());
            Console.Write("The dollar exchange rate[0.99...1.99]: ");
            double dollarExchangeRate = double.Parse(Console.ReadLine());

            // Make the calculations
            double monthlyReward = workingDaysInMonth * moneyPerDay;
            double yearlyReward = monthlyReward * 12;
            double totalReward = yearlyReward + monthlyReward * 2.5;
            double tax = totalReward * 0.25;
            double totalRewardWithoutTax = totalReward - tax;
            double totalRewardWithoutTaxBGN = totalRewardWithoutTax * dollarExchangeRate;
            double averagePerDay = totalRewardWithoutTaxBGN / 365;

            // Tell the user the average reward per day in BGN
            Console.WriteLine($"Average reward per day (BGN): { averagePerDay }");

            // Wait for input so the program does not close
            Console.WriteLine("\nPress Any Key To Exit . . .");
            Console.ReadKey();
        }
    }
}
