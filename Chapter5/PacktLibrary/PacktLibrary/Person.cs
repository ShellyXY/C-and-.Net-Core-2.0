using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.CS7
{
    public class Person:Object
    {
        //fields
        public string Name;
        public DateTime DateOfBirth;
        public WonderOfTheAncientWorld FavouriteAncientWonder;
        public WonderOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
        //constants
        public const string Species = "Homo Sapien";
        //read-only fields 
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        //constructors（构造函数）
        public Person()
        {
            // set default values for fields 
            // including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName)
        {
            Name = initialName;
            Instantiated = DateTime.Now;
        }

        //methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd, d MMMM yyyy}");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        // the old C# 4 and .NET 4.0 System.Tuple type 
        public Tuple<string, int> GetFruitCS4()
        {
            return Tuple.Create("Apple",5);
        }

        // the new C# 7 syntax and new System.ValueTuple type 
        public (string, int) GetFruitCS7()
        {
            return ("Apple",5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name:"Apples" , Number:5);
        } 
    }
}
