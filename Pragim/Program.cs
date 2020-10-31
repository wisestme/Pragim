using System;
using System.Diagnostics.Contracts;
using Pragim.Services;

namespace Pragim
{
    
    public class Program
    {
        public static void NotMain()
        {
            for(int i = 0; i <= 20; i++)
            {
                
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);
            }
            int[] myNumbers = new int[3];

            myNumbers[0] = 101;
            myNumbers[1] = 102;
            myNumbers[2] = 103;

            foreach (int oneNumber in myNumbers )
            {
                Console.WriteLine(oneNumber);
            }
        }
        public static void Main()
        {
            
            Console.WriteLine("Hello wisest... welcome to c# training");
            NotMain();
            //ImplementLists implementLists = new ImplementLists();
            //implementLists.LagosMarketsList();

            //WorkersPromotion workersPromotion = new WorkersPromotion();

            //PromotionDelegate agePromotion = new PromotionDelegate(workersPromotion.PromoteByAge);
            //agePromotion(40);

            //PromotionDelegate experiencePromotion = new PromotionDelegate(workersPromotion.PromoteByExperience);
            //experiencePromotion(7);

            //EmployeePromoter promoter = new EmployeePromoter();
            //promoter.AddEmployee();
            

            //Calculator adder = new Calculator(CalculatorDelegate.add);
            //Console.WriteLine(adder(5));

            //Calculator multiplier = new Calculator(CalculatorDelegate.multiply);
            //Console.WriteLine(multiplier(2));

            //Calculator getNum = new Calculator(CalculatorDelegate.getNumber);
            //Console.WriteLine(getNum(2));

            ////GreetDelegate del = new GreetDelegate(ImplementDelegate.Greet);
            ////del("How are you doing");

            ////GreetDelegate warner = new GreetDelegate(ImplementDelegate.Warn);
            ////warner("Keep out of reach of everybody");

            //ImplementDelegate implementDelegate = new ImplementDelegate();
            
            //TimelyGreeting greetingMorning = new TimelyGreeting(implementDelegate.GreetMorning);
            //greetingMorning("Morning");

            //TimelyGreeting greetAfternoon = new TimelyGreeting(implementDelegate.GreetAfternoon);
            //greetAfternoon("Afternoon");

            //TimelyGreeting greetEvening = new TimelyGreeting(implementDelegate.GreetEvening);
            //greetEvening("Evening");

            //AdditionCalculator addition = new AdditionCalculator();
            //addition.Integrate();
            //CustomerAbstract differentCustomer = new CustomerAbstract();
            //differentCustomer.Print();

            //Customer customer1 = new Customer();
            //customer1.Print();
            //((IAnotherInterface)customer1).Print();
            //customer1.IAnotherInterfaceMethod();

            //PolyEmployee[] employees = new PolyEmployee[4];

            //employees[0] = new PolyEmployee();
            //employees[1] = new PolyPartTimeEmployee();
            //employees[2] = new PolyFullTimeEmployee();
            //employees[3] = new PolyTemporaryEmployee();

            //foreach (PolyEmployee e in employees)
            //{
            //    e.PrintFullName();
            //}

            //FullTimeEmployee FTE = new FullTimeEmployee();
            //FTE.FirstName = "Chijioke";
            //FTE.LastName = "Nwagwu";
            //FTE.PrintFullName();

            //Employee PTE = new PartTimeEmployee();
            //PTE.FirstName = "Gloria";
            //PTE.LastName = "Vincent";
            //PTE.PrintFullName();

            //Pragim.Services.Car VICar = new Pragim.Services.Car();
            //VICar.Type = "Jeep";
            //VICar.EngineNumber = "BE5050";
            //VICar.Color = "Red";
            //VICar.VehicleDetails();

            //VehicleInheritance VIBike = new VehicleInheritance();
            //VIBike.Type = "PowerBike";
            //VIBike.EngineNumber = "PB002110";
            //VIBike.Color = "Blue";
            //VIBike.VehicleDetails();
        }
    }
}


