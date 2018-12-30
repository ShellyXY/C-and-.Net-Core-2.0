using System;
using static System.Console;
using System.IO;

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
            Stream s = File.Open(Path.Combine(path,"file.txt"),FileMode.OpenOrCreate);

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


        }
    }
}
