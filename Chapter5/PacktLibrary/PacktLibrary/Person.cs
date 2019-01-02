using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.CS7
{
    public class Person : Object
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
            return Tuple.Create("Apple", 5);
        }

        // the new C# 7 syntax and new System.ValueTuple type 
        public (string, int) GetFruitCS7()
        {
            return ("Apple", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        //Defining and passing parameters to methods
        public string SalyHello()
        {
            return $"{Name} says 'Hello!' ";
        }

        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        public string OptionalParameters(string command = "Run", double number = 0.0, bool active = true)
        {
            return $"command is {command}, number is {number}, active is {active}";
        }

        //Controlling how parameters are passed

        //By value(this is the default): Think of these as being in-only
        //By reference as a ref parameter: Think of these as being in-and-out
        //As an out parameter: Think of these as being out-only
        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default  
            // AND must be initialized inside the method 
            z = 99;

            // increment each parameter 
            x++;
            y++;
            z++;
        }

     
    }
}
