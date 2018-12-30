using System;
using System.IO;
using System.Collections;
using static System.Convert;
using static System.Console;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("There are no comments");
            }
            else
            {
                WriteLine("There is at least one argument");
            }
            //As there is only a single statement inside each block, this code can be written without the curly braces
            if (args.Length == 0)
                WriteLine("There are no arguments.");
            else
                WriteLine("There is at least one argument.");

            //The if statement can use the is keyword in combination with declaring a local variable to make your code safer
            object o = 3;
            int j = 4;
            if (o is int i)
            {
                WriteLine($"{i} x {j}={i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply");
            }

        A_label://定义标签
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");
            switch (number)
            {
                case 1:
                    WriteLine("One");
                    break;//jumps to end of switch statement
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Three of four");
                    goto case 1;
                case 5:
                    //go to sleep for half a second
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
            }//end of switch statement

            string path = @"C:\Users\m1801\Desktop\C# learning";
            Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    WriteLine("The stream is to a file that I can write to.");
                    break;

                case MemoryStream ms:
                    WriteLine("The stream is to a memory address");
                    break;
                default: // always evaluated last despite its current position
                    WriteLine("The stream is some other type.");
                    break;

                case null:
                    WriteLine("The stream is null");
                    break;
            }

            //The while statement
            int x = 0;
            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            //The do statement
            string password = string.Empty;
            do
            {
                Write("Enter your password");
                password = ReadLine();
            } while (password != "secret");
            WriteLine("Correct");

            //The for statement
            for (int y = 1; y <= 10; y++)
            {
                WriteLine(y);
            }

            //The foreach statement
            string[] names = { "Adam", "Barry", "Charile" };
            //foreach (string name in names)
            //{
            //    WriteLine($"{name} has {name.Length} characters.");
            //}

            //IEnumerable
            IEnumerator e = names.GetEnumerator();
            while (e.MoveNext())
            {
                string name = (string)e.Current;//Current is read-only!
                WriteLine($"{name} has {name.Length} characters");
            }

            //Casting numbers implicitly(隐式)
            int a = 10;
            double b = a;//an int can be stored in a double
            WriteLine(b);

            double c = 9.8;
            int d = c;// compiler gives an error for this line.This means the type of the double can not be converted into the int type.

            //Casting numbers explicitly
            double c1 = 9.8;
            int d1 = (int)c1;
            WriteLine(d1);

            long e1 = 10;
            int f1 = (int)e1;
            WriteLine($"e is {e1} and f is {f1}");
            e1 = long.MaxValue;
            f1 = (int)e1;
            WriteLine($"e is {e1} and f is {f1}");

            //Using the convert type
            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} h is {h}");

            //Rounding numbers
            //It will round up if the decimal part is .5 or higher and the nondecimal part is odd, but it will round down if the nondecimal part is even. 
            //It always rounds down if the decimal part is less than .5.
            //Banker's Rounding
            double i = 9.49;
            double j = 9.5;
            double k = 10.49;
            double l = 10.5;
            WriteLine($"i is {i}, ToInt(i) is {ToInt32(i)}");
            WriteLine($"j is {j}, ToInt(j) is {ToInt32(j)}");
            WriteLine($"k is {k}, ToInt(k) is {ToInt32(k)}");
            WriteLine($"l is {l}, ToInt(l) is {ToInt32(l)}");

            //Converting from any type to a string
            int number1 = 12;
            WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new object();
            WriteLine(me.ToString());

            //Converting from a binary object to a string
            //ToBase64String and FromBase64String

            //allocate array of 128 bytes
            byte[] binaryObject = new byte[128];

            //populate array with random bytes
            (new Random()).NextBytes(binaryObject);

            WriteLine("Binary Object as bytes:");
            for (int index = 0; index < binaryObject.Length; index++)
            {
                Write($"{binaryObject[index]:X}");
            }
            WriteLine();

            //Convert to Base64 string
            string encoded = Convert.ToBase64String(binaryObject);

            WriteLine($"Binary Object as Base64:{encoded}");


            //Parsing from strings to numbers or dates and times
            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");
            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}.");
            WriteLine($"My birthday is {birthday:D}.");

            int count = int.Parse("abc");
            //Unhandled Exception: System.FormatException: Input string was not in a correct format.

            Write("How many eggs are there?");
            int count1;
            string input = Console.ReadLine();
            if (int.TryParse(input, out count))
            {
                WriteLine($"There are {count} eggs");
            }
            else
            {
                WriteLine("I could not parse the input.");
            }          
        }
    }
}
