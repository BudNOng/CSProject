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

            //instantiate an object Staff1 from Staff Class.
            var staff1 = new Staff("Budong Drummond", 10);
            staff1.HoursWorked = 10;            
            Console.WriteLine(staff1.ToString());
            staff1.CalculatePay();

            Console.WriteLine("___________________________________________");
            Console.WriteLine("-----------Click any key to exit-----------");
            Console.ReadKey();
        }
    }
}
