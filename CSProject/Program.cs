using System;

namespace CSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There!, welcome to the Payroll system");
            Console.WriteLine("___________________________________________");
            Console.ReadKey();

            //instantiate the object Staff1 from Staff Class.
            var staff1 = new Staff("Budong Drummond", 10);
            staff1.HoursWorked = 10;            
            Console.WriteLine(staff1.ToString());
            staff1.CalculatePay();

            Console.WriteLine("\n___________________________________________");
            Console.ReadKey();

            //instantiate the object manager1 from Manager Class the child of Staff class.
            var manager1 = new Manager("Clare Carney");
            manager1.HoursWorked = 180;
            Console.WriteLine(manager1.ToString());
            manager1.CalculatePay();

            Console.WriteLine("\n___________________________________________");
            Console.WriteLine("\n-----------Click any key to exit-----------");
            Console.ReadKey();
        }
    }
}
