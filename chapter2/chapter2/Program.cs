using System;
using System.IO;
using System.Xml;
using static System.Console;

namespace chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine($"int uses {sizeof(int)} bytes and can store numbers int the range {int.MinValue:No} to {int.MaxValue:No}.");

            //double a = 0.1;
            //double b = 0.2;
            //if (a + b == 0.3)
            //{
            //    WriteLine($"{a} + {b}");
            //}
            //else
            //{
            //    WriteLine("${a} + {b} does NOT equal 0.3");
            //}
            //ReadKey();
            //System.Data.DataSet ds;
            //System.Net.Http.HttpClient Client;
            //foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            //{
            //    var a = Assembly.Load(new AssemblyName(r.FullName));
            //    int methodCount = 0;
            //    foreach (var t in a.DefinedTypes)
            //    {
            //        methodCount += t.GetMethods().Count();
            //    }
            //    WriteLine($"{a.DefinedTypes.Count():N0}types" + 
            //        $"with {methodCount:No} methods in {r.Name} assembly.");
            //}
            //ReadKey();


            double heightInMetres = 1.88;
            WriteLine($"The variable {nameof(heightInMetres)} has the value { heightInMetres}.");

            decimal c = 0.1M;
            decimal d = 0.2M;
            if (c + d == 0.3M)
            {
                WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                WriteLine("${c} + {d} does NOT equal 0.3");
            }

            //object height = 1.88;
            //object name = "Amir";
            //int length1 = name.length;
            //int length2 = ((string)name).Length;

            //dynamic anotherName = "Ahmed";
            //int length = anotherName.Length;//这里的dynamic类型没有智能提醒，原因是在编译器不会在Build time 的时候去检查

            //int population = 66_000_000;
            //double weight = 1.88;
            //decimal price = 4.99M;
            //string fruit = "Apples";
            //char letter = 'Z';
            //bool happy = true;

            //var is using inside the method as the local variables
            //The Conpiler will infer the  type from the literal value you assign after the assignment(=) operator.
            var population = 66_000_000;
            var weight = 1.88;
            var price = 4.99M;
            var fruit = "Apples";
            var letter = 'Z';
            var happy = true;

            //good use of var
            var xml1 = new XmlDocument();

            //unnecessarily verbose repeating XmlDocument
            XmlDocument xml2 = new XmlDocument();

            //bad use of var; what data type is file1?
            var file1 = File.CreateText(@"C:\something.txt");

            //good use of a specific type declaration
            StreamWriter file2 = File.CreateText(@"C:\something.txt");


            WriteLine($"{default(int)}");//0
            WriteLine($"{default(bool)}");//False
            WriteLine($"{default(DateTime)}");// 1/01/0001 00:00:00


            //Nullable value type\
            int ICannotBeNull = 4;
            int? ICouldBeNull = null;
            //本来Int是不能赋值为空值的，现在，加了?表示可以赋值为空值
            WriteLine(ICouldBeNull.GetValueOrDefault());//0
            ICouldBeNull = 4;
            WriteLine(ICouldBeNull.GetValueOrDefault());//4


            //When storing information about an address, 
            //you might want to force a value for the street, city, and region, but building can be left blank(that is, null)
            /* class Address
             {
                 string? Building;//can be null
                 string Street;//must have value;
                 string City;      // must have a value
                 string Region;    // must have a value
             }
             */

            // check is myVariable is not null before using it 
            if (ICouldBeNull != null)
            {
                // do something with ICouldBeNull 
            }

            //If you are trying to get a field or property from a variable that might be null, use the null check operator (?.)
            string authorName = null;
            //if authorName is null; instead of throwing an exception
            //null is returned
            int? howManyLetters = authorName?.Length;

            // result will be three if howManyLetters is null
            var result = howManyLetters ?? 3;
            WriteLine(result);//如果howManyLetters为空值的话，就将3赋值给他

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Array
            //declaring the size of the array
            string[] names = new string[4];
            //storing items at index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Tom";
            for (int i = 0; i < names.Length; i++)
            {
                WriteLine(names[i]);//read the item at this index
            }

            WriteLine($"The UK population is {population}.");
            Write($"The UK population is {population:N0}. ");
            WriteLine($"{weight}kg of {fruit} costs {price:C}.");

            //Get input from the user
            WriteLine("Type your first name and press ENTER");
            string firstName = ReadLine();
            Write("Type your age and press ENTER");
            string age = ReadLine();
            WriteLine($"Hello {firstName},you look good for{age}");

            //arguments
            WriteLine($"There are {args.Length} arguments.");

            //Enumerating arguments
            foreach (string arg in args)
            {
                WriteLine(arg);
            }

            ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[0], true);
            BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[1], true);
            WindowWidth = int.Parse(args[2]);
            WindowHeight = int.Parse(args[3]);
            WriteLine($"There are {args.Length} arguments.");
            foreach (var arg in args)
            {
                WriteLine(arg);
            }
            ReadKey();

        }
    }
}
