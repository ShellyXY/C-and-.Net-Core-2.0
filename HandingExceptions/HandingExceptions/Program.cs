using System;
using static System.Console;

namespace HandingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("What is your age?");
            string input = Console.ReadLine();
            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old");
            }
            //catch(Exception ex)
            //{
            //    WriteLine($"{ex.GetType()} says {ex.Message}");
            //    //Get the type of the exception and the message of the exception
            //}

            //Catching specific exceptions
            //there might be other types of exceptions that can occur
            catch (FormatException)
            {
                WriteLine("The age you entered is not a valid number format");
            }

            catch (OverflowException)
            {
                WriteLine("Your age is a valid number format but it is either too big or small.");
            }


            WriteLine("After parsing");

           


        }
    }
}
