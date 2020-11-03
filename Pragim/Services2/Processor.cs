using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services2
{
    class Processor
    {
        public static void Process()
        {
            //Members members = new Members();
            PaidMembers paidMembers = new PaidMembers();
            paidMembers.FirstName = "Chijioke";
            paidMembers.LastName = "Nwagwu";
            paidMembers.Email = "wisest@gmail.com";

            paidMembers.PrintFullName();

            VolunteerMembers volunteer = new VolunteerMembers();
            volunteer.FirstName = "Gloria";
            volunteer.LastName = "Vincent";
            volunteer.PrintFullName();

            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new ContractEmployee();

            foreach (Employee employee in employees)
            {
                employee.PrintFullName();
            }
        }
    }
}
