using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim
{
    interface IAdditionCalculator
    {
        void GetTwoNumbers();
    }

    public class AdditionCalculator : IAdditionCalculator
    {
        public string FirstNumberString { get; set; }
        public string SecondNumberString { get; set; }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public void GetTwoNumbers()
        {
            
            Console.WriteLine("Welcome to wisest console addition calculator.");
            Console.WriteLine("Please only numbers from zero to ten (0 - 10)");

            
            Console.WriteLine("Now enter your first number");
            FirstNumberString = Console.ReadLine();

            Console.WriteLine("Now enter your second number");
            SecondNumberString = Console.ReadLine();
        }

        public void ConvertUserInput()
        {

            //int FirstNumber, SecondNumber;

            try
            {
                FirstNumber = Convert.ToInt32(FirstNumberString);
                SecondNumber = Convert.ToInt32(SecondNumberString);

                int[] UserNumbers = { FirstNumber, SecondNumber };

                // OUT OF RANGE CUSTOM ERROR
                foreach(int UserNumber in UserNumbers)
                {
                    if(UserNumber < 0 || UserNumber > 10)
                    {
                        throw new ArithmeticException("At least one of your numbers is out of range");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AddUserInput()
        {
            int Answer;

            Answer = FirstNumber + SecondNumber;
            Console.WriteLine($"The sum of {FirstNumber} and {SecondNumber} is {Answer}");
        }

        public void Integrate()
        {
            GetTwoNumbers();
            ConvertUserInput();
            AddUserInput();
        }
    }
}
