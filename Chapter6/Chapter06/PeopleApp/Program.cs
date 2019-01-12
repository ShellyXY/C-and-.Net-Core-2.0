using System;
using Packt.CS7;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var jill = new Person { Name = "Jill" };

            // call instance method
            var baby1 = mary.ProcreateWith(harry);

            // call static method
            var baby2 = Person.Procreate(harry, jill);

            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{jill.Name} has {jill.Children.Count} children.");
            WriteLine($"{mary.Name}'s first child is named \"{mary.Children[0].Name}\".");

            //Implementing some functionality with an operator
            //call static operator
            var baby3 = harry * mary;


            harry.Shout += Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            Person[] people =
            {
                new Person {Name = "Simon"},
                new Person {Name = "Jenny"},
                new Person {Name = "Adam"},
                new Person {Name = "Richard"}
            };

            WriteLine($"Initial list of people");

            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            WriteLine("Use Person's IComparable implementation to sort:");

            Array.Sort(people);

            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            //Defining a separate comparer
            WriteLine("use PersonComparer's IComparer implementation to sort:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            //Making a generic type
            var t = new Thing();
            t.Data = 42;
            WriteLine($"Thing: {t.Process("42")}");

            var gt = new GenericThing<int>();
            gt.Data = 42;
            WriteLine($"GenericThing: {gt.Process("42")}");

            //Making a generic method
            string number1 = "4";
            WriteLine($"{number1} squared is {Squarer.Square<string>(number1)}");

            byte number2 = 3;
            WriteLine($"{number2} squared is {Squarer.Square<byte>(number2)}");

            //Defining a struct type
            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;
            WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X},{dv3.Y})");

            Employee e1 = new Employee
            {
                Name = "John Jones",
                DateOfBirth = new DateTime(1990, 7, 28)
            };

            //Extending classes
            e1.EmployeeCode = "JJ001";
            e1.HireDate = new DateTime(2014, 11, 23);
            WriteLine($"{e1.Name} was hired on {e1.HireDate:dd/MM/yy}");

            WriteLine(e1.ToString());

            //Polymorphism
            Employee aliceInEmployee = new Employee { Name = "Alice", EmployeeCode="AA123"};
            Person aliceInPerson = aliceInEmployee;
            aliceInEmployee.WriteToConsole();
            aliceInPerson.WriteToConsole();
            WriteLine(aliceInEmployee.ToString());
            WriteLine(aliceInPerson.ToString());

            //Explicit casting
            Employee e2 = (Employee)aliceInPerson;

            //Handling casting exceptions
            if (aliceInPerson is Employee)
            {
                WriteLine($"{nameof(aliceInPerson)} IS an Employee");
                Employee e21 = (Employee)aliceInPerson;
            }

            Employee e3 = aliceInPerson as Employee;
            if (e3 != null)
            {
                WriteLine($"{nameof(aliceInPerson)} AS an Employee");
            }

            //Inheriting from an exception
            try
            {
                e1.TimeTravel(new DateTime(1992, 12, 31));
            }
            catch (PersonException ex)
            {
                WriteLine(ex.Message);
            }

            //Using static methods to reuse functionality
            string email1 = "pamela@test.com";
            string email2 = "ian&test.com";

            WriteLine($"{email1} is a valid e-mail address: {StringExtensions.IsValidEmail(email1)}.");
            WriteLine($"{email2} is a valid e-mail address: {StringExtensions.IsValidEmail(email2)}.");

            //Using extension methods to reuse functionality
            WriteLine($"{email1} is a valid e-mail address:{email1.IsValidEmail()}.");
            WriteLine($"{email2} is a valid e-mail address:{email2.IsValidEmail()}.");

        }

        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
            throw new NotImplementedException();
        }

        //Attempting to sort objects without a method to compare

        
        


    }
}
