using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //when casting from a long variable to an int variable. If the value stored in a type is too big, it will overflow
            checked
            {
                int x = int.MaxValue - 1;
                WriteLine(x);
                x++;
                WriteLine(x);
                x++;
                WriteLine(x);
                x++;
                WriteLine(x);
                //int y = int.MaxValue + 1;
            }
            unchecked
            {
                int y = int.MaxValue + 1;
                WriteLine(y);
                y--;
                WriteLine(y);
                y--;
                WriteLine(y);
            }
        }
    }
}
