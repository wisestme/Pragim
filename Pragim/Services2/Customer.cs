using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services2
{
    interface ICustomer
    {
        void Print();
    }
    public class Customer : ICustomer
    {
        string _firstName;
        string _lastName;

        public Customer(string FirstName, string LastName)
        {
            _firstName = FirstName;
            _lastName = LastName;
        }

        public void Print()
        {
            Console.WriteLine("Implementing Interface method");
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Full name is {_firstName} {_lastName}");
        }
    }
}
