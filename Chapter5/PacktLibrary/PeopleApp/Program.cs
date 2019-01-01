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

        }
    }
}
