using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services
{
    public abstract class ImplementAbstract
    {
        public abstract void Print();
    }

    public class CustomerAbstract : ImplementAbstract
    {
        public override void Print()
        {
            Console.WriteLine("Implement abstract classs");
        }
    }
}
