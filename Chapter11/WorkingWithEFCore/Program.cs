using static System.Console;
using Packet.CS7;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Packet.CS7 
{
    class Program
    {
        static void QueryingProducts()
        {
            WriteLine("Products that cost more than a price,and sorted");
            string input;
            decimal price;
            do
            {
                Write("Enter a product price:");
                input = ReadLine();
            } while (!decimal.TryParse(input, out price));
        }
        static void QueryCategories()
        {
            using (var db = new Northwind())
            {
                WriteLine("Categories and how many products they have:");

                // a query to get all categories and their related products
                IQueryable<Category> cats = db.Categories.Include(c => c.Products);

                foreach (Category c in cats)
                {
                    WriteLine($"{c.CategoryName} has {c.Products.Count} products.");
                }
            }
        }
        static void Main(string[] args)
        {
            QueryCategories();
            ReadKey();

        }
    }
}
