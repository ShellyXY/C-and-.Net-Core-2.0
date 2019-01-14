using System;
using static System.Console;
using System.Reflection;
using System.Linq;

namespace WorkingWithReflection
{

    class Program
    {
        [Coder("David Yang","14 January 2019")]
        [Coder("Queen Wu", "14 January 2019")]
        public static void DoStuff()
        { }
        static void Main(string[] args)
        {
            WriteLine("Assembly metadata:");
            Assembly assembly = Assembly.GetEntryAssembly();

            WriteLine($"Full name:{assembly.FullName}");
            WriteLine($"Location:{assembly.Location}");

            var attributes = assembly.GetCustomAttributes();

            WriteLine($"Attributes:");
            foreach (Attribute a in attributes)
            {
                WriteLine($"{a.GetType()}");
            }

            var version = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();

            var company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
            WriteLine($" Company: {company.Company}");

            //Creating custom attributes
            WriteLine($"Types:");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                WriteLine($"Name:{type.FullName}");

                MemberInfo[] members = type.GetMembers();

                foreach (MemberInfo member in members)
                {
                    WriteLine($"{member.MemberType} : {member.Name} ({member.DeclaringType.Name})");

                    var coders = member.GetCustomAttributes<CoderAttribute>()
                        .OrderByDescending(c => c.LastModified);

                    foreach (CoderAttribute coder in coders)
                    {
                        WriteLine($"Modified by {coder.Coder} on {coder.LastModified.ToShortDateString()}");
                    }
                }
            }

            ReadLine();
        }
    }
}
