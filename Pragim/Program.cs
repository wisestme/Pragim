using System;
using System.Diagnostics.Contracts;
using Pragim.Services;
using SecondServices = Pragim.Services2;

namespace Pragim
{
    
    public class Program
    {
        public void EvenNumbers(int target)
        {
            int start = 0;

            while(start < target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }

        public int adder(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public static void simpleMethod(ref int j)
        {
            j = 101;
        }

        public void Calculate(int firstNumber, int secondNumber, out int Sum, out int Product)
        {
            Sum = firstNumber + secondNumber;
            Product = firstNumber * secondNumber;
        }

        public static void ParameterMethod(params int[] Numbers)
        {
            Console.WriteLine($"There are {Numbers.Length} elements in the array");
        }

        public static void Main()
        {
            SecondServices.Customer customer = new SecondServices.Customer("Chijioke", "Nwagwu");
            customer.PrintFullName();
            Program program = new Program();

            ParameterMethod(1, 2, 3, 4, 5, 6);
            int plus = 0;
            int times = 0;

            program.Calculate(4, 5, out plus, out times);

            Console.WriteLine($"{plus}, {times}");

            int i = 0;
            simpleMethod(ref i);
            Console.WriteLine(i);


            

            int sum = program.adder(3, 8);
            Console.WriteLine(sum);

            program.EvenNumbers(28);
            Console.WriteLine("Hello wisest... welcome to c# training");
            
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


