using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services
{
    delegate int Calculator(int n);
    public class CalculatorDelegate
    {
        static int number = 100;

        public static int add(int n)
        {
            number += n;
            return number;
        }

        public static int multiply(int n)
        {
            number *= n;
            return number;
        }

        public static int getNumber(int n)
        {
            return number;
        }
    }
}
