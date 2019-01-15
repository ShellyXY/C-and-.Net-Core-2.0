using System;
using System.IO;
using System.Xml;
using static System.Console;
using static System.Environment;
using static System.IO.Path;

namespace WorkingWithStreams
{
    class Program
    {
        //define an array of Viper pilot call signs
        static string[] callsigns = new string[] { "Husker", "Starbuck", "Apollo", "Boomer", "Bulldog", "Athena", "Helo", "Racetrack" };
        static void Main(string[] args)
        {
            //define a file to write to 
            string textFile = Combine(CurrentDirectory, "stream.txt");

            // create a text file and return a helper writer
            StreamWriter text = File.CreateText(textFile);


        }
    }
}
