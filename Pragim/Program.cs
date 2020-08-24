using System;
using System.Diagnostics.Contracts;
using Pragim.Services;

namespace Pragim
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            
            Console.WriteLine(FirstName + " " + LastName + " - PT");
        }
    }

    public class FullTimeEmployee : Employee
    {

    }
    public class Program
    {
        

        public static void Main()
        {
            
            GreetDelegate del = new GreetDelegate(ImplementDelegate.Greet);
            del("How are you doing");

            AdditionCalculator addition = new AdditionCalculator();
            addition.Integrate();
            CustomerAbstract differentCustomer = new CustomerAbstract();
            differentCustomer.Print();

            Customer customer1 = new Customer();
            customer1.Print();
            ((IAnotherInterface)customer1).Print();
            customer1.IAnotherInterfaceMethod();

            PolyEmployee[] employees = new PolyEmployee[4];

            employees[0] = new PolyEmployee();
            employees[1] = new PolyPartTimeEmployee();
            employees[2] = new PolyFullTimeEmployee();
            employees[3] = new PolyTemporaryEmployee();

            foreach (PolyEmployee e in employees)
            {
                e.PrintFullName();
            }

            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Chijioke";
            FTE.LastName = "Nwagwu";
            FTE.PrintFullName();

            Employee PTE = new PartTimeEmployee();
            PTE.FirstName = "Gloria";
            PTE.LastName = "Vincent";
            PTE.PrintFullName();

            Pragim.Services.Car VICar = new Pragim.Services.Car();
            VICar.Type = "Jeep";
            VICar.EngineNumber = "BE5050";
            VICar.Color = "Red";
            VICar.VehicleDetails();

            VehicleInheritance VIBike = new VehicleInheritance();
            VIBike.Type = "PowerBike";
            VIBike.EngineNumber = "PB002110";
            VIBike.Color = "Blue";
            VIBike.VehicleDetails();
        }
    }
}


