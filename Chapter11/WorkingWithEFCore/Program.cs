using static System.Console;
using Packet.CS7;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Packt.CS7;

namespace Packet.CS7
{
    class Program
    {

        static void QueryingProducts()
        {
            using (var db = new Northwind())
            {
                var loggerFactory = db.GetService<ILoggerFactory>();
                WriteLine("Products that cost more than a price,and sorted");
                string input;
                decimal price;
                do
                {
                    Write("Enter a product price:");
                    input = ReadLine();
                } while (!decimal.TryParse(input, out price));

                IQueryable<Product> prods = db.Products
                           .Where(product => product.Cost > price)
                           .OrderByDescending(product => product.Cost);

                foreach (Product item in prods)
                {
                    WriteLine($"{item.ProductID} : {item.ProductName}  costs {item.Cost:$#,##0.00} and has {item.Stock} units in stock.");
                }
            }
        }
        static void QueryCategories()
        {
            using (var db = new Northwind())
            {
                WriteLine("Categories and how many products they have:");

                // a query to get all categories and their related products
                IQueryable<Category> cats = db.Categories;//.Include(c => c.Products);

                foreach (Category c in cats)
                {
                    WriteLine($"{c.CategoryName} has {c.Products.Count} products.");
                }
            }
        }
        static void QueryingWithLike()
        {
            using (var db = new Northwind())
            {
                var loggerFactory = db.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());

                Write("Enter part of a product name: ");
                string input = ReadLine();

                IQueryable<Product> prods = db.Products
                    .Where(p => EF.Functions.Like(p.ProductName, $"%{input}%"));

                foreach (Product item in prods)
                {
                    WriteLine($"{item.ProductName} has {item.Stock} units in stock. Discontinued? {item.Discontinued}");
                }
            }
        }
        static void Main(string[] args)
        {
            QueryCategories();
            //QueryingProducts();
            //QueryingWithLike();
            ReadKey();
        }
    }
}
