namespace ProgrammingCourseWork
{
    public class Product
    {
        public Categories Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Mass { get; set; }
        public string MassUnit
        {
            get
            {
                if (Category == Categories.Beverage)
                {
                    return "мл";
                }
                else
                {
                    return "гр";
                }
            }
        }
        public double CalorieMultiplier
        {
            get
            {
                switch (Category)
                {
                    case Categories.Salad:
                    case Categories.Soup:
                        return 0;
                    case Categories.Main:
                        return 1;
                    case Categories.Beverage:
                        return 1.5;
                    case Categories.Dessert:
                        return 3;
                    default:
                        return 0;
                }
            }
        }

        public Product(Categories cat, string name, decimal price, double mass)
        {
            Category = cat;
            Name = name;
            Price = price;
            Mass = mass;
        }

        public double GetCalories()
        {
            return Mass * CalorieMultiplier;
        }
    }
}
