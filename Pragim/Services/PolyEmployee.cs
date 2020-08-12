using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services
{
    public class PolyEmployee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PolyPartTimeEmployee : PolyEmployee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Part Time");
        }
    }

    public class PolyFullTimeEmployee : PolyEmployee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Full Time");
        }
    }

    public class PolyTemporaryEmployee : PolyEmployee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Temporary");
        }
    }
}
