using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services
{
    public delegate void TimelyGreeting(string theMessage);
    class ImplementDelegate
    {
        string preMessage = "Good";
       public void GreetMorning(string message)
        {
            Console.WriteLine($"{preMessage} {message}");
        }

        public void GreetAfternoon(string message)
        {
            Console.WriteLine($"{preMessage} {message}");
        }

        public void GreetEvening(string message)
        {
            Console.WriteLine($"{preMessage} {message}");
        }
    }
}
