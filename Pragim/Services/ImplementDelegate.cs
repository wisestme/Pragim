using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services
{
    public delegate void GreetDelegate(string messageDelegate);
    class ImplementDelegate
    {
        public static void Greet(string message)
        {
            Console.WriteLine(message);
        }
    }
}
