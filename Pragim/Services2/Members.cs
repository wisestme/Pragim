using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services2
{
    public class Members
    {
        public string FirstName;
        public string LastName;
        public string Email;

        //public Members(string firstName, string lastName, string email)
        //{
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //    this.Email = email;
        //}

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    public class PaidMembers : Members
    {
        public float Salary;
    }

    public class VolunteerMembers : Members
    {
        public float Stipend;
    }

    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    public class PartTimeEmployee : Employee
    {

    }

    public class FullTimeEmployee : Employee
    {

    }

    public class ContractEmployee : Employee
    {

    }

}
