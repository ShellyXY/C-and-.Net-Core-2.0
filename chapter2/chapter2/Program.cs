using System;
using System.IO;
using System.Xml;

namespace chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers int the range {int.MinValue:No} to {int.MaxValue:No}.");

            //double a = 0.1;
            //double b = 0.2;
            //if (a + b == 0.3)
            //{
            //    Console.WriteLine($"{a} + {b}");
            //}
            //else
            //{
            //    Console.WriteLine("${a} + {b} does NOT equal 0.3");
            //}
            //Console.ReadKey();
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
            //    Console.WriteLine($"{a.DefinedTypes.Count():N0}types" + 
            //        $"with {methodCount:No} methods in {r.Name} assembly.");
            //}
            //Console.ReadKey();


            double heightInMetres = 1.88;
            Console.WriteLine($"The variable {nameof(heightInMetres)} has the value { heightInMetres}.");

            decimal c = 0.1M;
            decimal d = 0.2M;
            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine("${c} + {d} does NOT equal 0.3");
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


            Console.WriteLine($"{default(int)}");//0
            Console.WriteLine($"{default(bool)}");//False
            Console.WriteLine($"{default(DateTime)}");// 1/01/0001 00:00:00


            //Nullable value type\
            int ICannotBeNull = 4;
            int? ICouldBeNull = null;
            //本来Int是不能赋值为空值的，现在，加了?表示可以赋值为空值
            Console.WriteLine(ICouldBeNull.GetValueOrDefault());//0
            ICouldBeNull = 4;
            Console.WriteLine(ICouldBeNull.GetValueOrDefault());//4


        }
    }
}
