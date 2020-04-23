using System;

namespace CSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello There!, welcome to the Payroll system");
            Console.WriteLine("___________________________________________");
            Console.ReadKey();

            var test1 = new Customers("Budong", 1);
            Console.WriteLine(test1.ToString());
            test1.orders.Add(new Order());
            test1.orders.Add(new Order());
            test1.orders.Add(new Order());

            Console.WriteLine(test1.orders.Count);*/
            
            
            //instantiate the object Staff1 from Staff Class.
            var staff1 = new Staff("Budong Drummond", 10);
            staff1.HoursWorked = 10;            
            Console.WriteLine(staff1.ToString());
            staff1.CalculatePay();

            Console.WriteLine("\n___________________________________________");
            Console.ReadKey();

            //instantiate the object manager1 from Manager Class - the child of Staff class.
            var manager1 = new Manager("Clare Carney");
            manager1.HoursWorked = 180;
            manager1.CalculatePay();
            Console.WriteLine(manager1.ToString());

            Console.WriteLine("\n___________________________________________");
            Console.ReadKey();

            //instantiate the object admin1 from Admin Class - the child of Staff class.
            var admin1 = new Admin("John Legend");
            admin1.HoursWorked = 170;
            admin1.CalculatePay();
            Console.WriteLine(admin1.ToString());

            Console.WriteLine("\n___________________________________________");
            Console.WriteLine("\n-----------Click any key to exit-----------");
            Console.ReadKey();
            
        }
    }
}
