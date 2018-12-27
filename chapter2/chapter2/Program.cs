using System;

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

            var population = 66_000_000;
        }
    }
}
