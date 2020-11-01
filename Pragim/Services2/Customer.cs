using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services2
{
    public class Customer
    {
        string _firstName;
        string _lastName;

        public Customer(string FirstName, string LastName)
        {
            _firstName = FirstName;
            _lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Full name is {_firstName} {_lastName}");
        }
    }
}
