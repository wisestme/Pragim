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
        }
    }
}
