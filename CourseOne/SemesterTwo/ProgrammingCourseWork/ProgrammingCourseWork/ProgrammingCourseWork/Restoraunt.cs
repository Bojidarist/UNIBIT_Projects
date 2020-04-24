using ProgrammingCourseWork.Helpers;
using System;
using System.Collections.Generic;

namespace ProgrammingCourseWork
{
    public class Restoraunt
    {
        private int sellsCount = 0;
        private decimal sellsMoney = 0M;
        private Dictionary<Categories, Pair<int, decimal>> sellsByCategory;

        private Dictionary<int, List<Product>> Tables { get; set; }
        public Dictionary<string, Product> Menu { get; private set; }

        public Restoraunt()
        {
            Tables = new Dictionary<int, List<Product>>();
            Menu = new Dictionary<string, Product>();
            sellsByCategory = new Dictionary<Categories, Pair<int, decimal>>();
        }

        public bool Buy(int table, params string[] p)
        {
            if (1 <= table && table <= 30)
            {
                if (!Tables.ContainsKey(table))
                {
                    Tables.Add(table, new List<Product>());
                }
                foreach (var item in p)
                {
                    var product = Menu[item.ToLower().Trim()];
                    Tables[table].Add(product);
                    sellsCount++;
                    sellsMoney += product.Price;
                    if (!sellsByCategory.ContainsKey(product.Category))
                    {
                        sellsByCategory.Add(product.Category, new Pair<int, decimal>());
                    }
                    sellsByCategory[product.Category].First++;
                    sellsByCategory[product.Category].Second += product.Price;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintMenu()
        {
            foreach (var item in Menu)
            {
                Console.Write($"{item.Value.Category.ToBulgarian()}, {item.Value.Name}, {item.Value.Mass}{item.Value.MassUnit}, {item.Value.Price}лв\n");
            }
        }

        public void PrintSells()
        {
            Console.WriteLine($"Общо заети маси през деня: {Tables.Count}");
            Console.WriteLine($"Общо продажби: {sellsCount} - {sellsMoney}лв");
            Console.WriteLine($"По категории: ");
            Console.WriteLine($"    - Салата: {GetCategorySellCount(Categories.Salad)} - {GetCategorySellPrice(Categories.Salad)}лв");
            Console.WriteLine($"    - Супа: {GetCategorySellCount(Categories.Soup)} - {GetCategorySellPrice(Categories.Soup)}лв");
            Console.WriteLine($"    - Основно: {GetCategorySellCount(Categories.Main)} - {GetCategorySellPrice(Categories.Main)}лв");
            Console.WriteLine($"    - Десерт: {GetCategorySellCount(Categories.Dessert)} - {GetCategorySellPrice(Categories.Dessert)}лв");
            Console.WriteLine($"    - Напитка: {GetCategorySellCount(Categories.Beverage)} - {GetCategorySellPrice(Categories.Beverage)}лв");
        }

        private int GetCategorySellCount(Categories c)
        {
            if (sellsByCategory.ContainsKey(c))
            {
                return sellsByCategory[c].First;
            }
            return 0;
        }

        private decimal GetCategorySellPrice(Categories c)
        {
            if (sellsByCategory.ContainsKey(c))
            {
                return sellsByCategory[c].Second;
            }
            return 0;
        }
    }
}
