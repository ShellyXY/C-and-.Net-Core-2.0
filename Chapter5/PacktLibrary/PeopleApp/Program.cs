using System;
using Packt.CS7;
using static System.Console;
using System.Collections.Generic;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "Bob Smith";
            p1.DateOfBirth = new System.DateTime(1965,12,22);
            WriteLine($"{p1.Name} was born on {p1.DateOfBirth:dddd,d MMMM yyyy}");
            WriteLine(p1.ToString());

            var p2 = new Person()
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 17)
            };
            WriteLine($"{p2.Name} was born on {p2.DateOfBirth:dddd,d MMMM yyyy}");

            p1.FavouriteAncientWonder = WonderOfTheAncientWorld.StatueOfZeusAtOlympia;
            WriteLine($"{p1.Name}'s favourite wonder is {p1.FavouriteAncientWonder}");

            p1.BucketList = WonderOfTheAncientWorld.HangingGardensOfBabylon | WonderOfTheAncientWorld.MausoleumAtHalicarnassus;
            //p1.BucketList = {WonderOfTheAncientWorld}18;


            WriteLine($"{p1.Name}'s bucket is {p1.BucketList}");
            p1.Children.Add(new Person {Name="Alfred"});
            p1.Children.Add(new Person { Name = "Zoe" });
            WriteLine($"{p1.Name} has {p1.Children.Count} children:");
            for (int child = 0; child < p1.Children.Count; child++)
            {
                WriteLine($"  {p1.Children[child].Name}");
            }

            BankAccount.InterestRate = 0.012M;
            var ba1 = new BankAccount();
            ba1.AccountName = "Mrs.Jones";
            ba1.Balance = 2400;
            WriteLine($"{ba1.AccountName} earned {ba1.Balance*BankAccount.InterestRate:C} interest.");
            var ba2 = new BankAccount();
            ba2.AccountName = "Ms.Gerrier";
            ba2.Balance = 98;
            WriteLine($"{ba2.AccountName} earned {ba2.Balance * BankAccount.InterestRate:C} interest");

            WriteLine($"{p1.Name} is a {Person.Species}");

            var p3 = new Person();
            WriteLine($"{p3.Name} was instantiated at {p3.Instantiated:hh:mm:ss} on {p3.Instantiated:dddd, d MMMM yyyy}");

            var p4 = new Person("Aziz");
            WriteLine($"{p4.Name} was instantiated at { p4.Instantiated:hh: mm: ss}   on { p4.Instantiated:dddd, d MMMM yyyy}");

            p1.WriteToConsole();
            WriteLine(p1.GetOrigin());

            Tuple<string, int> fruit4 = p1.GetFruitCS4();
            WriteLine($"There are {fruit4.Item1} {fruit4.Item2}.");

            (string, int) fruit7 = p1.GetFruitCS7();
            WriteLine($"{fruit7.Item1}, {fruit7.Item2} there are.");

            var fruitNamed = p1.GetNamedFruit();
            WriteLine($"Are there {fruitNamed.Number} {fruitNamed.Name}");

            //Deconstructing tuples
            (string fruitName, int fruitNumber) = p1.GetFruitCS7();
            WriteLine($"Deconstructed: {fruitName},{fruitNumber}");


            //Defining and passing parameters to methods
            WriteLine(p1.SayHello(""));
            WriteLine(p1.SayHello("Emily"));

            //Optional parameters and named arguments
            WriteLine(p1.OptionalParameters());
            p1.OptionalParameters("Jump!",98.5);

            //the order they are passed through can be swapped around
            p1.OptionalParameters(number:52.7,command:"Hide!");

            //skips the number parameter
            p1.OptionalParameters("Poke!",active:false);

            //Controlling how parameters are passed
            int a = 10;
            int b = 20;
            int c = 30;
            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            p1.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b}, c = {c}");

            //Defining read-only properties
            var sam = new Person
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };
            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);

            //Defining settable properties
            sam.FavoriteIceCream = "Chocoloate Fudge";
            WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
            sam.FavoritePrimaryColor = "Red";
            WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");

            //Defining indexers
            sam.Children.Add(new Person {Name = "Charlie"});
            sam.Children.Add(new Person {Name = "Ella"});
            WriteLine($"Sam's first child is {sam.Children[0].Name}");
            WriteLine($"Sam's second child is {sam.Children[1].Name}");
            WriteLine($"Sam's first child is {sam[0].Name}");
            WriteLine($"Sam's second child is {sam[1].Name}");

        }
    }
}
