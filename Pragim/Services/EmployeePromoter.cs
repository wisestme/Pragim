using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services
{
    delegate bool PromoteEmployeeNow(EmployeePromoter worker);
    class EmployeePromoter
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearsOfExperience { get; set; }
        public int Salary { get; set; }
        
         
      

        public void AddEmployee()
        {
            List<EmployeePromoter> EmployeesList = new List<EmployeePromoter>();

            EmployeesList.Add(new EmployeePromoter() { ID = 101, FirstName = "Tochukwu", LastName = "Nwankwu", YearsOfExperience = 3, Salary = 50000 });
            EmployeesList.Add(new EmployeePromoter() { ID = 102, FirstName = "Marvellous", LastName = "Chisom", YearsOfExperience = 5, Salary = 120000});
            EmployeesList.Add(new EmployeePromoter() { ID = 103, FirstName = "Onah", LastName = "Chidiebube", YearsOfExperience = 8, Salary = 150000 });
            EmployeesList.Add(new EmployeePromoter() { ID = 099, FirstName = "Idam", LastName = "Samuel", YearsOfExperience = 3, Salary = 40000 });

            //EmployeePromoter promote = new EmployeePromoter();
            //PromoteEmployeeNow(PromoteByExperience);
            PromoteEmployeeNow promoteEmployee = new PromoteEmployeeNow(PromoteByExperience);
            PromoteEmployeeNow promoteEmployee1 = new PromoteEmployeeNow(PromoteBySalary);

            EmployeePromoter.PromoteEmployee(EmployeesList, promoteEmployee);
            EmployeePromoter.PromoteEmployee(EmployeesList, promoteEmployee1);

        }

        public bool PromoteByExperience(EmployeePromoter staff)
        {
            if (staff.YearsOfExperience > 4)
            {
                return true;
            }
            else
            {
                return false;
            }

            //return true;
        }

        public bool PromoteBySalary(EmployeePromoter staff)
        {
            if (staff.Salary > 40000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PromoteEmployee(List<EmployeePromoter> Employees, PromoteEmployeeNow ToBePromoted)
        {
            foreach (EmployeePromoter staff in Employees)
            {
                if (ToBePromoted(staff))
                {
                    Console.WriteLine($"{staff.FirstName} has been promoted");
                }
            }
        }
        
       
    }

    
}
