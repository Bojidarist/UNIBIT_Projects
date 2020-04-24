using System;

namespace ProgrammingCourseWork.Helpers
{
    public static class ProductHelpers
    {
        public static Product ToProduct(this string input)
        {
            string[] data = input.Split(',');
            if (data.Length < 4)
            {
                throw new ArgumentException($"Invalid number of data: {data.Length}, Needed: 4");
            }

            double mass = double.Parse(data[2]);
            decimal price = decimal.Parse(data[3]);


            if (!(IsInRange(0, 100, price) && IsInRange(0, 1000, (decimal)mass)))
            {
                throw new ArgumentException("Mass or price are not in range");
            }

            return new Product(
                    data[0].ToCategory(),
                    data[1].ToLower(),
                    price,
                    mass);
        }

        private static bool IsInRange(decimal a, decimal b, decimal i)
        {
            return a <= i && i <= b;
        }

        public static Categories ToCategory(this string input)
        {
            switch (input.ToLower())
            {
                case "салата":
                    return Categories.Salad;
                case "супа":
                    return Categories.Soup;
                case "основно":
                case "основно ястие":
                    return Categories.Main;
                case "десерт":
                    return Categories.Dessert;
                case "напитка":
                    return Categories.Beverage;
                default:
                    throw new ArgumentException($"Invalid category: {input}");
            }
        }

        public static string ToBulgarian(this Categories c)
        {
            switch (c)
            {
                case Categories.Salad:
                    return "салата";
                case Categories.Soup:
                    return "супа";
                case Categories.Main:
                    return "основно ястие";
                case Categories.Beverage:
                    return "напитка";
                case Categories.Dessert:
                    return "десерт";
                default:
                    throw new ArgumentException($"Invalid category: {c}");
            }
        }
    }
}
