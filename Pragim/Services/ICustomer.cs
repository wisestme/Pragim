using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services
{
    interface ICustomer
    {
        void Print();
    }

    interface IAnotherInterface
    {
        void IAnotherInterfaceMethod();
        void Print();
    }

    public class Customer : ICustomer, IAnotherInterface
    {
        public void Print()
        {
            Console.WriteLine("Demo first explicit interface implementation");
        }

        void IAnotherInterface.Print()
        {
            Console.WriteLine("Demo second explicit interface");
        }

        public void IAnotherInterfaceMethod()
        {
            Console.WriteLine("Just experimenting multiple interface inheritance");
        }
    }
}
